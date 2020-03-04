using System;
using System.Windows.Forms;

namespace SwitchUnityPlatform
{
	public partial class ChoosePlatformForm : Form
	{
		public string SelectedPlatform;
		public string HintMessageBox;

		public ChoosePlatformForm()
		{
			InitializeComponent();
		}

		private void OnStandaloneButton_Click(object sender, EventArgs e)
		{
			SelectedPlatform = "Standalone";
			Close();
		}

		private void OnPS4Button_Click(object sender, EventArgs e)
		{
			SelectedPlatform = "PS4";
			Close();
		}

		private void OnXboxOneButton_Click(object sender, EventArgs e)
		{
			SelectedPlatform = "XboxOne";
			Close();
		}

		private void OnChoosePlatformForm_Shown(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(HintMessageBox))
			{
				MessageBox.Show(HintMessageBox, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				HintMessageBox = string.Empty;
			}
		}
	}
}
