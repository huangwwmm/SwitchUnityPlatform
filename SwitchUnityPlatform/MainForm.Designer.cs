namespace SwitchUnityPlatform
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.m_SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_SwitchButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_SettingToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(409, 32);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// m_SettingToolStripMenuItem
			// 
			this.m_SettingToolStripMenuItem.Name = "m_SettingToolStripMenuItem";
			this.m_SettingToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
			this.m_SettingToolStripMenuItem.Text = "设置";
			this.m_SettingToolStripMenuItem.Click += new System.EventHandler(this.OnSettingToolStripMenuItem_Click);
			// 
			// m_SwitchButton
			// 
			this.m_SwitchButton.Location = new System.Drawing.Point(43, 40);
			this.m_SwitchButton.Name = "m_SwitchButton";
			this.m_SwitchButton.Size = new System.Drawing.Size(317, 33);
			this.m_SwitchButton.TabIndex = 1;
			this.m_SwitchButton.Text = "切换平台";
			this.m_SwitchButton.UseVisualStyleBackColor = true;
			this.m_SwitchButton.Click += new System.EventHandler(this.OnStandaloneButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 81);
			this.Controls.Add(this.m_SwitchButton);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "切换Unity平台";
			this.Shown += new System.EventHandler(this.OnMainForm_Shown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem m_SettingToolStripMenuItem;
		private System.Windows.Forms.Button m_SwitchButton;
	}
}

