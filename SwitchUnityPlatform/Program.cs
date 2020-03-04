using System;
using System.IO;
using System.Windows.Forms;

namespace SwitchUnityPlatform
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (Directory.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Assets\\")
				&& Directory.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "ProjectSettings\\"))
			{
				Application.Run(new MainForm());
			}
			else
			{
				MessageBox.Show("请把该软放Assets、ProjectSettings同级目录", "检测不到Unity项目", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
