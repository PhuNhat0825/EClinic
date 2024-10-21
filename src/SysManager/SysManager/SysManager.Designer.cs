namespace SysManager
{
	// Token: 0x02000004 RID: 4
	public partial class SysManager : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000286C File Offset: 0x0000186C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000028A4 File Offset: 0x000018A4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SysManager.SysManager));
			this.ilCategories = new global::System.Windows.Forms.ImageList(this.components);
			this.ilItems = new global::System.Windows.Forms.ImageList(this.components);
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.navigationTree1 = new global::SKCDExtCtrl.TreeExt.NavigationTree();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.ilCategories.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("ilCategories.ImageStream");
			this.ilCategories.TransparentColor = global::System.Drawing.Color.Transparent;
			this.ilCategories.Images.SetKeyName(0, "task_32.ico");
			this.ilCategories.Images.SetKeyName(1, "calendar_32.ico");
			this.ilCategories.Images.SetKeyName(2, "contact_32.ico");
			this.ilItems.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("ilItems.ImageStream");
			this.ilItems.TransparentColor = global::System.Drawing.Color.Transparent;
			this.ilItems.Images.SetKeyName(0, "folder.ico");
			this.ilItems.Images.SetKeyName(1, "task.ico");
			this.ilItems.Images.SetKeyName(2, "bin.ico");
			this.ilItems.Images.SetKeyName(3, "contact.ico");
			this.ilItems.Images.SetKeyName(4, "journal.ico");
			this.ilItems.Images.SetKeyName(5, "note.ico");
			this.ilItems.Images.SetKeyName(6, "searchfolder.ico");
			this.splitContainer1.Location = new global::System.Drawing.Point(9, 12);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.panel2);
			this.splitContainer1.Panel2.Controls.Add(this.panel1);
			this.splitContainer1.Size = new global::System.Drawing.Size(828, 527);
			this.splitContainer1.SplitterDistance = 252;
			this.splitContainer1.TabIndex = 1;
			this.panel2.Controls.Add(this.navigationTree1);
			this.panel2.Location = new global::System.Drawing.Point(4, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(268, 522);
			this.panel2.TabIndex = 0;
			this.navigationTree1.CategoryHeaderBackColor = global::System.Drawing.Color.LightGreen;
			this.navigationTree1.CategoryHeaderFont = new global::System.Drawing.Font("Palatino Linotype", 15.75f, global::System.Drawing.FontStyle.Italic);
			this.navigationTree1.CategoryHeaderForeColor = global::System.Drawing.Color.Black;
			this.navigationTree1.CategorySelectedButtonBackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.navigationTree1.ImageListCategories = this.ilCategories;
			this.navigationTree1.ImageListItems = this.ilItems;
			this.navigationTree1.Location = new global::System.Drawing.Point(3, -5);
			this.navigationTree1.Name = "navigationTree1";
			this.navigationTree1.Size = new global::System.Drawing.Size(242, 527);
			this.navigationTree1.TabIndex = 0;
			this.navigationTree1.OnItemSelected += new global::SKCDExtCtrl.TreeExt.ItemSelected(this.navigationTree1_OnItemSelected);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(572, 527);
			this.panel1.TabIndex = 0;
			this.button3.Location = new global::System.Drawing.Point(262, 69);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(89, 25);
			this.button3.TabIndex = 3;
			this.button3.Text = "Refresh";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button2.Location = new global::System.Drawing.Point(146, 69);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(89, 25);
			this.button2.TabIndex = 2;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.Location = new global::System.Drawing.Point(32, 69);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(89, 25);
			this.button1.TabIndex = 1;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.textBox1.Location = new global::System.Drawing.Point(0, 14);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(572, 20);
			this.textBox1.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(849, 551);
			base.Controls.Add(this.splitContainer1);
			base.Name = "Form1";
			this.Text = "Form1";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000008 RID: 8
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000009 RID: 9
		private global::SKCDExtCtrl.TreeExt.NavigationTree navigationTree1;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.ImageList ilCategories;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.ImageList ilItems;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button button2;
	}
}
