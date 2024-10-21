using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Utility;

namespace ReceptionAdmin
{
    // Token: 0x02000009 RID: 9
    public partial class ServicesManagement : Form
    {
        // Token: 0x06000067 RID: 103 RVA: 0x0000B8A9 File Offset: 0x0000A8A9
        public ServicesManagement()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000068 RID: 104 RVA: 0x0000B8D0 File Offset: 0x0000A8D0
        private void ServicesManagement_Load(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
            dataGridViewComboBoxColumn.Name = "Nhom_Dich_Vu";
            dataGridViewComboBoxColumn.HeaderText = "Nhóm dịch vụ";
            string sCommand = "select * from NHOM_DICH_VU";
            DataSet dataSet = EClinicDB.FillDataset(sCommand);
            dataGridViewComboBoxColumn.DataSource = dataSet.Tables[0];
            dataGridViewComboBoxColumn.DisplayMember = "Ten_Nhom";
            dataGridViewComboBoxColumn.ValueMember = "Nhom_DV_Id";
            this.da = EClinicDB.CreateMySqlDataAdapter("Select * from DICH_VU");
            this.dsDichVu = new DataSet();
            this.da.Fill(this.dsDichVu, "DICH_VU");
            MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(this.da);
            this.dataGridView_DichVu.DataSource = this.dsDichVu.Tables["DICH_VU"];
            this.dataGridView_DichVu.Columns.Add(dataGridViewComboBoxColumn);
            this.dataGridView_DichVu.Columns["Nhom_DV_Id"].Visible = false;
            this.dataGridView_DichVu.Columns["Dich_Vu_Id"].Visible = false;
            this.dataGridView_DichVu.Columns["DV_Code"].HeaderText = "Mã dịch vụ";
            this.dataGridView_DichVu.Columns["Ten"].HeaderText = "Tên dịch vụ";
            this.dataGridView_DichVu.Columns["Don_Gia"].HeaderText = "Đơn giá";
            this.dataGridView_DichVu.Columns["Thue_VAT"].HeaderText = "Thuế VAT";
            this.LoadNhomDVTuongUng();
        }

        // Token: 0x06000069 RID: 105 RVA: 0x0000BA64 File Offset: 0x0000AA64
        private void LoadNhomDVTuongUng()
        {
            for (int i = 0; i < this.dataGridView_DichVu.Rows.Count; i++)
            {
                this.dataGridView_DichVu.Rows[i].Cells["Nhom_Dich_Vu"].Value = this.dataGridView_DichVu.Rows[i].Cells["Nhom_DV_Id"].Value;
            }
        }

        // Token: 0x0600006A RID: 106 RVA: 0x0000BAE0 File Offset: 0x0000AAE0
        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                this.da.Update(this.dsDichVu, "DICH_VU");
                MessageBox.Show(__.T("Đã hoàn tất việc cập nhật danh sách các dịch vụ."));
            }
            catch
            {
                MessageBox.Show(__.T("Có lỗi xảy ra khi cập nhật bảng Dịch vụ."), __.T("Thông báo!"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        // Token: 0x0600006B RID: 107 RVA: 0x0000BB4C File Offset: 0x0000AB4C
        private void dataGridView_DichVu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView_DichVu.SelectedCells[0].ColumnIndex == this.dataGridView_DichVu.Columns["Nhom_Dich_Vu"].Index)
            {
                this.dataGridView_DichVu.Rows[this.dataGridView_DichVu.SelectedCells[0].RowIndex].Cells["Nhom_DV_Id"].Value = this.dataGridView_DichVu.SelectedCells[0].Value;
            }
        }

        // Token: 0x0600006C RID: 108 RVA: 0x0000BBE6 File Offset: 0x0000ABE6
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        // Token: 0x040000AA RID: 170
        private MySqlDataAdapter da = null;

        // Token: 0x040000AB RID: 171
        private DataSet dsDichVu = null;
    }
}
