namespace SwitchUnityPlatform
{
	partial class ChoosePlatformForm
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
			this.m_XboxOneButton = new System.Windows.Forms.Button();
			this.m_PS4Button = new System.Windows.Forms.Button();
			this.m_StandaloneButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// m_XboxOneButton
			// 
			this.m_XboxOneButton.Location = new System.Drawing.Point(12, 112);
			this.m_XboxOneButton.Name = "m_XboxOneButton";
			this.m_XboxOneButton.Size = new System.Drawing.Size(242, 33);
			this.m_XboxOneButton.TabIndex = 6;
			this.m_XboxOneButton.Text = "XboxOne";
			this.m_XboxOneButton.UseVisualStyleBackColor = true;
			this.m_XboxOneButton.Click += new System.EventHandler(this.OnXboxOneButton_Click);
			// 
			// m_PS4Button
			// 
			this.m_PS4Button.Location = new System.Drawing.Point(12, 62);
			this.m_PS4Button.Name = "m_PS4Button";
			this.m_PS4Button.Size = new System.Drawing.Size(242, 33);
			this.m_PS4Button.TabIndex = 5;
			this.m_PS4Button.Text = "PS4";
			this.m_PS4Button.UseVisualStyleBackColor = true;
			this.m_PS4Button.Click += new System.EventHandler(this.OnPS4Button_Click);
			// 
			// m_StandaloneButton
			// 
			this.m_StandaloneButton.Location = new System.Drawing.Point(12, 12);
			this.m_StandaloneButton.Name = "m_StandaloneButton";
			this.m_StandaloneButton.Size = new System.Drawing.Size(242, 33);
			this.m_StandaloneButton.TabIndex = 4;
			this.m_StandaloneButton.Text = "Standalone";
			this.m_StandaloneButton.UseVisualStyleBackColor = true;
			this.m_StandaloneButton.Click += new System.EventHandler(this.OnStandaloneButton_Click);
			// 
			// ChoosePlatformForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(267, 159);
			this.Controls.Add(this.m_XboxOneButton);
			this.Controls.Add(this.m_PS4Button);
			this.Controls.Add(this.m_StandaloneButton);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ChoosePlatformForm";
			this.ShowIcon = false;
			this.Text = "选择平台";
			this.Shown += new System.EventHandler(this.OnChoosePlatformForm_Shown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button m_XboxOneButton;
		private System.Windows.Forms.Button m_PS4Button;
		private System.Windows.Forms.Button m_StandaloneButton;
	}
}