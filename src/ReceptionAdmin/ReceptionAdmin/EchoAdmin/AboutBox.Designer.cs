namespace EchoAdmin
{
	// Token: 0x02000007 RID: 7
	internal partial class AboutBox : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00003E1C File Offset: 0x00002E1C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003E54 File Offset: 0x00002E54
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::EchoAdmin.AboutBox));
			this.tableLayoutPanel = new global::System.Windows.Forms.TableLayoutPanel();
			this.logoPictureBox = new global::System.Windows.Forms.PictureBox();
			this.labelProductName = new global::System.Windows.Forms.Label();
			this.labelVersion = new global::System.Windows.Forms.Label();
			this.labelCopyright = new global::System.Windows.Forms.Label();
			this.labelCompanyName = new global::System.Windows.Forms.Label();
			this.textBoxDescription = new global::System.Windows.Forms.TextBox();
			this.okButton = new global::System.Windows.Forms.Button();
			this.tableLayoutPanel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.logoPictureBox).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 33f));
			this.tableLayoutPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 67f));
			this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
			this.tableLayoutPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new global::System.Drawing.Point(9, 9);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 6;
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel.Size = new global::System.Drawing.Size(417, 265);
			this.tableLayoutPanel.TabIndex = 0;
			this.logoPictureBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.logoPictureBox.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("logoPictureBox.Image");
			this.logoPictureBox.Location = new global::System.Drawing.Point(3, 3);
			this.logoPictureBox.Name = "logoPictureBox";
			this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
			this.logoPictureBox.Size = new global::System.Drawing.Size(131, 259);
			this.logoPictureBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.logoPictureBox.TabIndex = 12;
			this.logoPictureBox.TabStop = false;
			this.labelProductName.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.labelProductName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelProductName.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.labelProductName.Location = new global::System.Drawing.Point(143, 0);
			this.labelProductName.Margin = new global::System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelProductName.MaximumSize = new global::System.Drawing.Size(0, 17);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new global::System.Drawing.Size(271, 17);
			this.labelProductName.TabIndex = 19;
			this.labelProductName.Text = "Product Name";
			this.labelProductName.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.labelVersion.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.labelVersion.Location = new global::System.Drawing.Point(143, 26);
			this.labelVersion.Margin = new global::System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelVersion.MaximumSize = new global::System.Drawing.Size(0, 17);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new global::System.Drawing.Size(271, 17);
			this.labelVersion.TabIndex = 0;
			this.labelVersion.Text = "Version";
			this.labelVersion.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCopyright.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.labelCopyright.Location = new global::System.Drawing.Point(143, 52);
			this.labelCopyright.Margin = new global::System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelCopyright.MaximumSize = new global::System.Drawing.Size(0, 17);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new global::System.Drawing.Size(271, 17);
			this.labelCopyright.TabIndex = 21;
			this.labelCopyright.Text = "Copyright";
			this.labelCopyright.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCompanyName.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.labelCompanyName.Location = new global::System.Drawing.Point(143, 78);
			this.labelCompanyName.Margin = new global::System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelCompanyName.MaximumSize = new global::System.Drawing.Size(0, 17);
			this.labelCompanyName.Name = "labelCompanyName";
			this.labelCompanyName.Size = new global::System.Drawing.Size(271, 17);
			this.labelCompanyName.TabIndex = 22;
			this.labelCompanyName.Text = "Company Name";
			this.labelCompanyName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.textBoxDescription.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.textBoxDescription.Location = new global::System.Drawing.Point(143, 107);
			this.textBoxDescription.Margin = new global::System.Windows.Forms.Padding(6, 3, 3, 3);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.textBoxDescription.Size = new global::System.Drawing.Size(271, 126);
			this.textBoxDescription.TabIndex = 23;
			this.textBoxDescription.TabStop = false;
			this.textBoxDescription.Text = "Description";
			this.okButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.okButton.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.okButton.Location = new global::System.Drawing.Point(339, 239);
			this.okButton.Name = "okButton";
			this.okButton.Size = new global::System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 24;
			this.okButton.Text = "&OK";
			this.okButton.Click += new global::System.EventHandler(this.okButton_Click);
			base.AcceptButton = this.okButton;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(435, 283);
			base.Controls.Add(this.tableLayoutPanel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AboutBox";
			base.Padding = new global::System.Windows.Forms.Padding(9);
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.logoPictureBox).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000021 RID: 33
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.PictureBox logoPictureBox;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label labelProductName;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Label labelVersion;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label labelCopyright;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Label labelCompanyName;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.TextBox textBoxDescription;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Button okButton;
	}
}
