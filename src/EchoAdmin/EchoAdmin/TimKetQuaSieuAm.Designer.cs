namespace EchoAdmin
{
	// Token: 0x02000002 RID: 2
	public partial class TimKetQuaSieuAm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002088 File Offset: 0x00001088
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::SKCDExtCtrl.GridFilterFactories.DefaultGridFilterFactory defaultGridFilterFactory = new global::SKCDExtCtrl.GridFilterFactories.DefaultGridFilterFactory();
			this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.dataGridFilterExt1 = new global::SKCDExtCtrl.DataGridFilterExt(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridFilterExt1).BeginInit();
			base.SuspendLayout();
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new global::System.Drawing.Point(12, 78);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new global::System.Drawing.Size(695, 374);
			this.dataGridView1.TabIndex = 0;
			this.buttonOK.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonOK.Location = new global::System.Drawing.Point(538, 15);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(67, 28);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "&OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new global::System.EventHandler(this.buttonOK_Click);
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonCancel.Location = new global::System.Drawing.Point(624, 15);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(67, 28);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new global::System.EventHandler(this.buttonCancel_Click);
			this.dataGridFilterExt1.DataGridView = this.dataGridView1;
			defaultGridFilterFactory.CreateDistinctGridFilters = false;
			defaultGridFilterFactory.DefaultGridFilterType = typeof(global::SKCDExtCtrl.GridFilters.TextGridFilter);
			defaultGridFilterFactory.DefaultShowDateInBetweenOperator = false;
			defaultGridFilterFactory.DefaultShowNumericInBetweenOperator = false;
			defaultGridFilterFactory.HandleEnumerationTypes = true;
			defaultGridFilterFactory.MaximumDistinctValues = 20;
			this.dataGridFilterExt1.FilterFactory = defaultGridFilterFactory;
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(719, 464);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.dataGridView1);
			base.KeyPreview = true;
			base.Name = "TimKetQuaSieuAm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "TimKetQuaSieuAm";
			base.Load += new global::System.EventHandler(this.TimKetQuaSieuAm_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridFilterExt1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.DataGridView dataGridView1;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Button buttonCancel;

		// Token: 0x04000005 RID: 5
		private global::SKCDExtCtrl.DataGridFilterExt dataGridFilterExt1;
	}
}
