using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Utility;

namespace SysManager
{
    // Token: 0x02000003 RID: 3
    public partial class DanhMucPhongBan : Form
    {
        // Token: 0x06000006 RID: 6 RVA: 0x000023FC File Offset: 0x000013FC
        public DanhMucPhongBan()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000007 RID: 7 RVA: 0x00002430 File Offset: 0x00001430
        private void button2_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        // Token: 0x06000008 RID: 8 RVA: 0x0000243C File Offset: 0x0000143C
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.buttonEdit.Text == "&Save")
            {
                try
                {
                    this.da.Update(this.ds, "PHONGBAN");
                    MessageBox.Show(__.T("Cập nhật thành công !"));
                    this.SetStateButton("EDIT");
                }
                catch
                {
                    MessageBox.Show(__.T("Có lỗi xảy ra khi cập nhật bảng Danh mục phòng ban."), __.T("Thông báo!"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                this.SetStateButton("SAVE");
            }
        }

        // Token: 0x06000009 RID: 9 RVA: 0x000024E4 File Offset: 0x000014E4
        private void SetStateButton(string sState)
        {
            if (sState == "SAVE")
            {
                this.dataGridView1.AllowUserToAddRows = true;
                this.dataGridView1.AllowUserToDeleteRows = true;
                this.buttonEdit.Text = "&Save";
                this.buttonCancel.Enabled = false;
            }
            else
            {
                this.dataGridView1.AllowUserToAddRows = false;
                this.buttonEdit.Text = "&Edit";
                this.buttonCancel.Enabled = true;
            }
        }

        // Token: 0x0600000A RID: 10 RVA: 0x00002570 File Offset: 0x00001570
        private void DanhMucPhongBan_Load(object sender, EventArgs e)
        {
            this.LoadData();
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Columns.Remove("TamNgung");
            DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dataGridViewCheckBoxColumn.HeaderText = "Tạm Ngưng";
            dataGridViewCheckBoxColumn.Name = "TamNgung";
            dataGridViewCheckBoxColumn.DataPropertyName = "TamNgung";
            dataGridViewCheckBoxColumn.FalseValue = 0;
            dataGridViewCheckBoxColumn.TrueValue = 1;
            dataGridViewCheckBoxColumn.Width = 100;
            this.dataGridView1.Columns.Add(dataGridViewCheckBoxColumn);
        }

        // Token: 0x0600000B RID: 11 RVA: 0x00002614 File Offset: 0x00001614
        public void LoadData()
        {
            this.da.Fill(this.ds, "PHONGBAN");
            MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(this.da);
            this.dataGridView1.DataSource = this.ds.Tables["PHONGBAN"];
            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
            {
                this.dataGridView1.Columns[i].Visible = false;
            }
            this.dataGridView1.Columns["MaPhongBan"].Visible = true;
            this.dataGridView1.Columns["TenPhongBan"].Visible = true;
            this.dataGridView1.Columns["Cap"].Visible = true;
            this.dataGridView1.Columns["TamNgung"].Visible = true;
            this.dataGridView1.Columns["Ngaytao"].Visible = true;
            this.dataGridView1.Columns["MaPhongBan"].HeaderText = "Mã Phòng Ban";
            this.dataGridView1.Columns["MaPhongBan"].Width = 150;
            this.dataGridView1.Columns["TenPhongBan"].HeaderText = "Tên phòng ban";
            this.dataGridView1.Columns["TenPhongBan"].Width = 200;
            this.dataGridView1.Columns["Cap"].HeaderText = "Cấp";
            this.dataGridView1.Columns["Cap"].ToolTipText = "Chỉ nhận các giá trị nguyên 1, 2...";
            this.dataGridView1.Columns["TamNgung"].HeaderText = "Tạm ngưng";
            this.dataGridView1.Columns["TamNgung"].ToolTipText = "Chỉ nhận các giá trị 0 hoặc 1";
            this.dataGridView1.Columns["Ngaytao"].HeaderText = "Ngày khởi tạo";
            this.dataGridView1.Columns["Ngaytao"].Width = 200;
        }

        // Token: 0x04000006 RID: 6
        private MySqlDataAdapter da = EClinicDB.CreateMySqlDataAdapter("Select * from dm_phongban");

        // Token: 0x04000007 RID: 7
        private DataSet ds = new DataSet();
    }
}
