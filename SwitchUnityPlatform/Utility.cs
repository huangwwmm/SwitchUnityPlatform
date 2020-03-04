using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Windows.Forms;

namespace SwitchUnityPlatform
{
	public static class Utility
	{
		/// <summary>
		/// 不使用<see cref="System.IO.Directory.Delete"/>是因为它删不掉通过mklink创建的软连接
		/// </summary>
		public static bool Rmdir(string directory)
		{
			System.Diagnostics.ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe"
				, $"/c rmdir \"{directory}\"");

			processInfo.CreateNoWindow = true;
			processInfo.UseShellExecute = false;
			processInfo.RedirectStandardError = true;
			processInfo.RedirectStandardOutput = true;
			processInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			return ExecuteProcess(processInfo);
		}

		/// <summary>
		/// <see cref="https://docs.microsoft.com/en-us/windows-server/administration/windows-commands/mklink"/>
		/// </summary>
		/// <param name="link"></param>
		/// <param name="target"></param>
		/// <param name="isHard">true：硬链接  false：软连接</param>
		/// <param name="isDirectory">true：目录  false：文件</param>
		/// <param name="isOverlay">true：如果target存在则先删除再link</param>
		/// <returns>是否成功</returns>
		public static bool Mklink(string link, string target, bool isHard, bool isDirectory)
		{
			System.Diagnostics.ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe"
				, string.Format("/c mklink {0} {1} \"{2}\" \"{3}\""
					, isDirectory ? "/d" : ""
					, isHard ? "/h" : ""
					, link
					, target));

			processInfo.CreateNoWindow = true;
			processInfo.UseShellExecute = false;
			processInfo.RedirectStandardError = true;
			processInfo.RedirectStandardOutput = true;
			processInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

			return ExecuteProcess(processInfo);
		}

		/// <summary>
		/// 尝试检测目录是否为SymbolicLink
		/// </summary>
		public static bool IsDirectorySymbolicLink(string directory)
		{
			Runspace runspace = RunspaceFactory.CreateRunspace();
			runspace.Open();
			// create a pipeline and feed it the script text
			Pipeline pipeline = runspace.CreatePipeline();
			pipeline.Commands.AddScript($"Get-Item -Path '{directory}' | Select-Object -ExpandProperty LinkType");
			pipeline.Commands.Add("Out-String");
			// execute the script
			Collection<PSObject> results = pipeline.Invoke();
			// close the runspace
			runspace.Close();

			// convert the script result into a single string
			foreach (PSObject obj in results)
			{
				if (obj.ToString().Trim().ToLower() == "SymbolicLink".ToLower())
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// 执行Batch Command
		/// </summary>
		public static bool ExecuteProcess(System.Diagnostics.ProcessStartInfo processStartInfo)
		{
			bool success = ExecuteProcess(processStartInfo, out int exitCode, out string output, out string error);

			return success;
		}

		/// <summary>
		/// 执行Batch Command
		/// </summary>
		public static bool ExecuteProcess(System.Diagnostics.ProcessStartInfo processStartInfo, out int exitCode, out string output, out string error)
		{
			try
			{
				System.Diagnostics.Process process = System.Diagnostics.Process.Start(processStartInfo);
				process.WaitForExit();

				exitCode = process.ExitCode;
				output = processStartInfo.RedirectStandardOutput ? process.StandardOutput.ReadToEnd() : string.Empty;
				error = processStartInfo.RedirectStandardError ? process.StandardError.ReadToEnd() : string.Empty;

				process.Close();
			}
			catch (Exception e)
			{
				exitCode = -1;
				output = string.Empty;
				error = e.ToString();
			}

			string log = $"{processStartInfo.WorkingDirectory}> {processStartInfo.Arguments}\nExitCode:\n{exitCode}\nOutput:\n{output}\nError:{error}";
			Console.WriteLine(log);
			bool success = string.IsNullOrEmpty(error)
				&& exitCode == 0;
			if (!success)
			{
				MessageBox.Show(log, "CMD操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return success;
		}
	}
}