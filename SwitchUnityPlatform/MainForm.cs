using System;
using System.IO;
using System.Windows.Forms;

namespace SwitchUnityPlatform
{
	public partial class MainForm : Form
	{
		private static readonly string UNITY_LIBRARY_DIRECTORY = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Library";

		private ChoosePlatformForm m_ChoosePlatformForm = new ChoosePlatformForm();

		public MainForm()
		{
			InitializeComponent();
		}

		private void OnMainForm_Shown(object sender, EventArgs e)
		{
			Setting.GetInstance();
		}

		private void OnSettingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new SettingForm().ShowDialog();
		}

		private void OnStandaloneButton_Click(object sender, EventArgs e)
		{
			m_ChoosePlatformForm.SelectedPlatform = string.Empty;
			m_ChoosePlatformForm.ShowDialog();
			string platform = m_ChoosePlatformForm.SelectedPlatform;
			if (string.IsNullOrEmpty(platform))
			{
				return;
			}

			if (MessageBox.Show($"确定要切换到{platform}平台？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}

			if (Directory.Exists(UNITY_LIBRARY_DIRECTORY)
				&& !Utility.IsDirectorySymbolicLink(UNITY_LIBRARY_DIRECTORY))
			{
				m_ChoosePlatformForm.SelectedPlatform = string.Empty;
				m_ChoosePlatformForm.HintMessageBox = "请选择当前项目正在使用的平台";
				m_ChoosePlatformForm.ShowDialog();
				string currentPlatform = m_ChoosePlatformForm.SelectedPlatform;
				if (string.IsNullOrEmpty(currentPlatform))
				{
					return;
				}

				string currentCache = Path.Combine(Setting.GetInstance().WorkDirectory, currentPlatform);
				if (Directory.Exists(currentCache))
				{
					MessageBox.Show($"工作目录中已经存在{currentPlatform}平台!\n请手动删除当前项目正在使用的Libaray目录，或工作目录中{currentPlatform}平台的Libaray目录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				Directory.Move(UNITY_LIBRARY_DIRECTORY, currentCache);
			}


			string target = Path.Combine(Setting.GetInstance().WorkDirectory, platform);
			if (!Directory.Exists(target))
			{
				Directory.CreateDirectory(target);
			}

			if (Directory.Exists(UNITY_LIBRARY_DIRECTORY))
			{
				Directory.Delete(UNITY_LIBRARY_DIRECTORY, true);
			}

			if (Utility.Mklink(UNITY_LIBRARY_DIRECTORY, target, false, true))
			{
				MessageBox.Show($"切换到{platform}平台成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show($"切换到{platform}平台失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}