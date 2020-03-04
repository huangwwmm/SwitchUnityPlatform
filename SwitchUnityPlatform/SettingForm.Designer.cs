namespace SwitchUnityPlatform
{
	partial class SettingForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.m_WorkDirectoryTextBox = new System.Windows.Forms.TextBox();
			this.m_ChooseWorkDirectoryButton = new System.Windows.Forms.Button();
			this.m_SaveButton = new System.Windows.Forms.Button();
			this.m_WorkDirectoryFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "工作目录";
			// 
			// m_WorkDirectoryTextBox
			// 
			this.m_WorkDirectoryTextBox.Location = new System.Drawing.Point(103, 9);
			this.m_WorkDirectoryTextBox.Name = "m_WorkDirectoryTextBox";
			this.m_WorkDirectoryTextBox.Size = new System.Drawing.Size(685, 26);
			this.m_WorkDirectoryTextBox.TabIndex = 1;
			// 
			// m_ChooseWorkDirectoryButton
			// 
			this.m_ChooseWorkDirectoryButton.Location = new System.Drawing.Point(794, 5);
			this.m_ChooseWorkDirectoryButton.Name = "m_ChooseWorkDirectoryButton";
			this.m_ChooseWorkDirectoryButton.Size = new System.Drawing.Size(33, 34);
			this.m_ChooseWorkDirectoryButton.TabIndex = 2;
			this.m_ChooseWorkDirectoryButton.Text = "...";
			this.m_ChooseWorkDirectoryButton.UseVisualStyleBackColor = true;
			this.m_ChooseWorkDirectoryButton.Click += new System.EventHandler(this.OnChooseWorkDirectoryButton_Click);
			// 
			// m_SaveButton
			// 
			this.m_SaveButton.Location = new System.Drawing.Point(748, 63);
			this.m_SaveButton.Name = "m_SaveButton";
			this.m_SaveButton.Size = new System.Drawing.Size(75, 32);
			this.m_SaveButton.TabIndex = 3;
			this.m_SaveButton.Text = "保存";
			this.m_SaveButton.UseVisualStyleBackColor = true;
			this.m_SaveButton.Click += new System.EventHandler(this.OnSaveButton_Click);
			// 
			// m_WorkDirectoryFolderBrowserDialog
			// 
			this.m_WorkDirectoryFolderBrowserDialog.Description = "选择工作目录";
			// 
			// SettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(835, 107);
			this.Controls.Add(this.m_SaveButton);
			this.Controls.Add(this.m_ChooseWorkDirectoryButton);
			this.Controls.Add(this.m_WorkDirectoryTextBox);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingForm";
			this.Text = "设置";
			this.Shown += new System.EventHandler(this.OnSettingForm_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox m_WorkDirectoryTextBox;
		private System.Windows.Forms.Button m_ChooseWorkDirectoryButton;
		private System.Windows.Forms.Button m_SaveButton;
		private System.Windows.Forms.FolderBrowserDialog m_WorkDirectoryFolderBrowserDialog;
	}
}