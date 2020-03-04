using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchUnityPlatform
{
	public partial class SettingForm : Form
	{
		public SettingForm()
		{
			InitializeComponent();
		}

		private void OnChooseWorkDirectoryButton_Click(object sender, EventArgs e)
		{
			m_WorkDirectoryFolderBrowserDialog.SelectedPath = string.IsNullOrEmpty(m_WorkDirectoryTextBox.Text)
				? AppDomain.CurrentDomain.SetupInformation.ApplicationBase
				: m_WorkDirectoryTextBox.Text;
			if (m_WorkDirectoryFolderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				m_WorkDirectoryTextBox.Text = m_WorkDirectoryFolderBrowserDialog.SelectedPath;
			}
		}

		private void OnSaveButton_Click(object sender, EventArgs e)
		{
			Setting.GetInstance().WorkDirectory = m_WorkDirectoryTextBox.Text;

			Setting.GetInstance().Save();
			Close();
		}

		private void OnSettingForm_Shown(object sender, EventArgs e)
		{
			m_WorkDirectoryTextBox.Text = Setting.GetInstance().WorkDirectory;
		}
	}
}
