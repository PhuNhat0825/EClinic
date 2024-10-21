namespace MainProject
{
	// Token: 0x02000007 RID: 7
	public partial class StaffManagerForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00006C1C File Offset: 0x00005C1C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00006C54 File Offset: 0x00005C54
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::SKCDExtCtrl.GridFilterFactories.DefaultGridFilterFactory defaultGridFilterFactory = new global::SKCDExtCtrl.GridFilterFactories.DefaultGridFilterFactory();
			this.dataGridViewNhanVien = new global::System.Windows.Forms.DataGridView();
			this.buttonCapNhat = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.dataGridFilterExtenderNhanVien = new global::SKCDExtCtrl.DataGridFilterExt(this.components);
			this.buttonTaoUser = new global::System.Windows.Forms.Button();
			this.buttonEdit = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewNhanVien).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridFilterExtenderNhanVien).BeginInit();
			base.SuspendLayout();
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewNhanVien.Location = new global::System.Drawing.Point(12, 80);
			this.dataGridViewNhanVien.MultiSelect = false;
			this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
			this.dataGridViewNhanVien.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewNhanVien.Size = new global::System.Drawing.Size(987, 414);
			this.dataGridViewNhanVien.TabIndex = 0;
			this.dataGridViewNhanVien.CellEndEdit += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhanVien_CellEndEdit);
			this.dataGridViewNhanVien.DataError += new global::System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewNhanVien_DataError);
			this.buttonCapNhat.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonCapNhat.Location = new global::System.Drawing.Point(470, 511);
			this.buttonCapNhat.Name = "buttonCapNhat";
			this.buttonCapNhat.Size = new global::System.Drawing.Size(125, 39);
			this.buttonCapNhat.TabIndex = 1;
			this.buttonCapNhat.Text = "&Cập nhật";
			this.buttonCapNhat.UseVisualStyleBackColor = true;
			this.buttonCapNhat.Click += new global::System.EventHandler(this.buttonCapNhat_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Tahoma", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new global::System.Drawing.Point(364, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(235, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Danh Sách Nhân Viên";
			this.dataGridFilterExtenderNhanVien.DataGridView = this.dataGridViewNhanVien;
			defaultGridFilterFactory.CreateDistinctGridFilters = false;
			defaultGridFilterFactory.DefaultGridFilterType = typeof(global::SKCDExtCtrl.GridFilters.TextGridFilter);
			defaultGridFilterFactory.DefaultShowDateInBetweenOperator = false;
			defaultGridFilterFactory.DefaultShowNumericInBetweenOperator = false;
			defaultGridFilterFactory.HandleEnumerationTypes = true;
			defaultGridFilterFactory.MaximumDistinctValues = 20;
			this.dataGridFilterExtenderNhanVien.FilterFactory = defaultGridFilterFactory;
			this.dataGridFilterExtenderNhanVien.FilterText = "Lọc:";
			this.buttonTaoUser.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonTaoUser.Location = new global::System.Drawing.Point(601, 511);
			this.buttonTaoUser.Name = "buttonTaoUser";
			this.buttonTaoUser.Size = new global::System.Drawing.Size(125, 39);
			this.buttonTaoUser.TabIndex = 1;
			this.buttonTaoUser.Text = "&Tạo mã đăng nhập";
			this.buttonTaoUser.UseVisualStyleBackColor = true;
			this.buttonTaoUser.Click += new global::System.EventHandler(this.buttonTaoUser_Click);
			this.buttonEdit.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonEdit.Location = new global::System.Drawing.Point(339, 511);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new global::System.Drawing.Size(125, 39);
			this.buttonEdit.TabIndex = 1;
			this.buttonEdit.Text = "Chỉnh &sửa";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new global::System.EventHandler(this.buttonEdit_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1008, 562);
			base.Controls.Add(this.dataGridViewNhanVien);
			base.Controls.Add(this.buttonTaoUser);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.buttonEdit);
			base.Controls.Add(this.buttonCapNhat);
			base.Name = "StaffManagerForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "eClinic - Quản lý nhân viên";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Load += new global::System.EventHandler(this.StaffManagerForm_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewNhanVien).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridFilterExtenderNhanVien).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400006A RID: 106
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.DataGridView dataGridViewNhanVien;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.Button buttonCapNhat;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400006E RID: 110
		private global::SKCDExtCtrl.DataGridFilterExt dataGridFilterExtenderNhanVien;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Button buttonTaoUser;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.Button buttonEdit;
	}
}
