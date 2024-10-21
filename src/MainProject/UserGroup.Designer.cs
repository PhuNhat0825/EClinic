namespace MainProject
{
	// Token: 0x0200000A RID: 10
	public partial class UserGroup : global::System.Windows.Forms.Form
	{
		// Token: 0x06000074 RID: 116 RVA: 0x0000857C File Offset: 0x0000757C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000085B4 File Offset: 0x000075B4
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.checkedListBoxGroups = new global::System.Windows.Forms.CheckedListBox();
			this.buttonUpdate = new global::System.Windows.Forms.Button();
			this.buttonClose = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Blue;
			this.label1.Location = new global::System.Drawing.Point(24, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(169, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "PHÂN QUYỀN NGƯỜI DÙNG";
			this.checkedListBoxGroups.FormattingEnabled = true;
			this.checkedListBoxGroups.Location = new global::System.Drawing.Point(12, 44);
			this.checkedListBoxGroups.Name = "checkedListBoxGroups";
			this.checkedListBoxGroups.Size = new global::System.Drawing.Size(199, 154);
			this.checkedListBoxGroups.TabIndex = 0;
			this.buttonUpdate.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonUpdate.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonUpdate.Location = new global::System.Drawing.Point(37, 204);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new global::System.Drawing.Size(75, 27);
			this.buttonUpdate.TabIndex = 1;
			this.buttonUpdate.Text = "&Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new global::System.EventHandler(this.buttonUpdate_Click);
			this.buttonClose.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonClose.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonClose.Location = new global::System.Drawing.Point(118, 204);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(75, 27);
			this.buttonClose.TabIndex = 2;
			this.buttonClose.Text = "&Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			base.AcceptButton = this.buttonUpdate;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonClose;
			base.ClientSize = new global::System.Drawing.Size(225, 241);
			base.ControlBox = false;
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.buttonUpdate);
			base.Controls.Add(this.checkedListBoxGroups);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Name = "UserGroup";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "UserGroup";
			base.Load += new global::System.EventHandler(this.UserGroup_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000081 RID: 129
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.CheckedListBox checkedListBoxGroups;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Button buttonUpdate;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Button buttonClose;
	}
}
