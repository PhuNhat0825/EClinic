using CrystRptManager;
using DBInteraction;
using SKCDExtCtrl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Utility;

namespace EchoAdmin
{
    public partial class EchoAdmin : Form
    {
        // Token: 0x06000035 RID: 53 RVA: 0x000095B4 File Offset: 0x000085B4
        public EchoAdmin()
        {
            this.InitializeComponent();
            this.comboBoxPhongSieuAm.SelectedValueChanged += this.comboBoxPhongSieuAm_SelectedValueChanged;
            this.tabControl1.SelectedIndexChanged += this.tabControl1_SelectedIndexChanged;
            this.dataGridViewExt1.SelectionChanged += this.dataGridViewExt1_SelectionChanged;
        }

        // Token: 0x06000036 RID: 54 RVA: 0x00009655 File Offset: 0x00008655
        private void dataGridViewExt1_SelectionChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x06000037 RID: 55 RVA: 0x00009658 File Offset: 0x00008658
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab.Name == "tabPageHinhAnh" && this.boolLoadedCapture)
            {
                this.captureMovie1.EnablePreview = true;
                this.captureMovie1.ShowMovie();
            }
        }

        private void EchoAdmin_Load(object sender, EventArgs e)
        {
            EClinicDB.LoadDatasetIntoComboBox(ref this.comboBoxBsSieuAm, "BacSiSieuAm", "", true);
            EClinicDB.LoadDatasetIntoComboBox(ref this.comboBoxPhongSieuAm, "PhongSieuAm", "", true);
            if (EClinicConfig.AllowChangeRoom == "0")
            {
                this.comboBoxPhongSieuAm.Enabled = false;
                int num = (int)EClinicDB.ExecuteScalar("select phongban_id from dm_phongban where maphongban = '" + EClinicConfig.ComputerNo + "'");
                this.comboBoxPhongSieuAm.SelectedValue = num;
            }
            else
            {
                this.comboBoxPhongSieuAm.Enabled = true;
            }
        }

        // Token: 0x06000039 RID: 57 RVA: 0x00009754 File Offset: 0x00008754
        private void SetTrangThaiNutLenh(EchoAdmin.ButtonStat butStat)
        {
            switch (butStat)
            {
                case EchoAdmin.ButtonStat.Progress:
                    this.buttonSaveKetQua.Enabled = true;
                    this.buttonKetQua.Enabled = true;
                    this.buttonInHinhAnh.Enabled = true;
                    this.buttonInKetQua.Enabled = false;
                    this.boolDangTienHanhSieuAm = true;
                    break;
                case EchoAdmin.ButtonStat.Edit:
                    this.buttonSaveKetQua.Enabled = true;
                    this.buttonKetQua.Enabled = true;
                    this.buttonInHinhAnh.Enabled = true;
                    break;
                case EchoAdmin.ButtonStat.Save:
                    this.boolDangTienHanhSieuAm = false;
                    this.buttonInKetQua.Enabled = true;
                    break;
            }
        }

        // Token: 0x0600003A RID: 58 RVA: 0x0000980C File Offset: 0x0000880C
        private void buttonTienHanh_Click(object sender, EventArgs e)
        {
            if (this.boolLoadedControlKetqua)
            {
                this.LoadControlKetQuaSA("TQ1");
            }
            this.intCLSKetQuaChiTiet_Id = int.Parse(StringExt.StringZero(this.dataGridViewExt1.SelectedRows[0].Cells["YeuCauChiTiet_Id"].Value));
            if (this.TaoMoiKetQuaSieuAm(this.intCLSKetQuaChiTiet_Id))
            {
                this.boolLoadedCapture = true;
                this.SetTrangThaiNutLenh(EchoAdmin.ButtonStat.Progress);
                this.labelSoPhieuYeuCau.Text = this.dataGridViewExt1.SelectedRows[0].Cells["SoPhieuYeuCau"].Value.ToString();
                EClinicConfig.BenhNhanID = (int)this.dataGridViewExt1.SelectedRows[0].Cells["BenhNhan_Id"].Value;
                if (this.LoadDuLieuBenhNhan(EClinicConfig.BenhNhanID))
                {
                    this.labelBsSieuAm.Text = this.comboBoxBsSieuAm.Text;
                    this.labelPhongBanThucHien.Text = this.comboBoxPhongSieuAm.Text;
                    this.labelDichVuSieuAm.Text = StringExt.StringNull(this.dataGridViewExt1.SelectedRows[0].Cells["TenDichVu"].Value);
                    this.intDichVu_Id = int.Parse(StringExt.StringZero(this.dataGridViewExt1.SelectedRows[0].Cells["DichVu_id"].Value));
                    if (this.LoadMauKetQua(this.intDichVu_Id) > 0)
                    {
                        this.buttonMacDinh.Enabled = true;
                    }
                }
                this.tabControl1.SelectedTab = this.tabPageHinhAnh;
            }
            else
            {
                this.boolDangTienHanhSieuAm = true;
            }
            if (this.boolDangTienHanhSieuAm)
            {
                this.buttonTienHanh.Enabled = false;
            }
        }

        // Token: 0x0600003B RID: 59 RVA: 0x00009A04 File Offset: 0x00008A04
        private bool TaoMoiKetQuaSieuAm(int iSoPhieuYeuCau)
        {
            this.intClsKetqua = 0;
            return true;
        }

        // Token: 0x0600003C RID: 60 RVA: 0x00009A1E File Offset: 0x00008A1E
        private void buttonCapnhatDataGrid_Click(object sender, EventArgs e)
        {
            this.CapNhatDataGridDsYeuCau();
            this.buttonSuaKetQua.Enabled = false;
            this.buttonTienHanh.Enabled = true;
        }

        // Token: 0x0600003D RID: 61 RVA: 0x00009A42 File Offset: 0x00008A42
        private void comboBoxPhongSieuAm_SelectedValueChanged(object sender, EventArgs e)
        {
            this.buttonCapnhatDataGrid.PerformClick();
        }

        /// <summary>
        /// Load ds ben nhan can thuc hien sieu am cua phong sieu am.
        /// </summary>
        private void CapNhatDataGridDsYeuCau()
        {
            EClinicDB.LoadDatasetEncryptedIntoDataGridView(ref this.dataGridViewExt1, "dm_benhnhan", "YeuCauSieuAmChuaThucHien", "", StringExt.StringNull(this.comboBoxPhongSieuAm.SelectedValue));
            this.dataGridViewExt1.HeaderColumnState = DataGridViewExt.CustomHeaderState.HideColumn;
            this.dataGridViewExt1.CustomHeaderText = "SoPhieuYeuCau|Số phiếu YC|80; Ho_Ten|Họ tên Bệnh nhân|130; TenDichVu|Tên dịch vụ|120;DonGia|Đơn giá|50; MienGiam|Miễn giảm|50; TenPhongBan|Phòng ban thực hiện|80; NgayYeuCau|Ngày yêu cầu|110; TrangThai|Trạng thái|100";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(this.captureMovie1.ImageVideoShot);
            this.pictureBox1.Image = image;
            this.checkBox1.Checked = true;
        }

        // Token: 0x06000040 RID: 64 RVA: 0x00009AE8 File Offset: 0x00008AE8
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(this.captureMovie1.ImageVideoShot);
            this.pictureBox2.Image = image;
            this.checkBox2.Checked = true;
        }

        // Token: 0x06000041 RID: 65 RVA: 0x00009B24 File Offset: 0x00008B24
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(this.captureMovie1.ImageVideoShot);
            this.pictureBox3.Image = image;
            this.checkBox3.Checked = true;
        }

        // Token: 0x06000042 RID: 66 RVA: 0x00009B60 File Offset: 0x00008B60
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(this.captureMovie1.ImageVideoShot);
            this.pictureBox4.Image = image;
            this.checkBox4.Checked = true;
        }

        // Token: 0x06000043 RID: 67 RVA: 0x00009B9C File Offset: 0x00008B9C
        private void buttonInHinhAnh_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
            GeneralUtility.ArrayCaptureImagesPath.Clear();
            if (this.checkBox1.Checked)
            {
                text = Path.GetTempFileName();
                this.pictureBox1.Image.Save(text, ImageFormat.Jpeg);
                GeneralUtility.ArrayCaptureImagesPath.Add(text);
            }
            if (this.checkBox2.Checked)
            {
                text = Path.GetTempFileName();
                this.pictureBox2.Image.Save(text, ImageFormat.Jpeg);
                GeneralUtility.ArrayCaptureImagesPath.Add(text);
            }
            if (this.checkBox3.Checked)
            {
                text = Path.GetTempFileName();
                this.pictureBox3.Image.Save(text, ImageFormat.Jpeg);
                GeneralUtility.ArrayCaptureImagesPath.Add(text);
            }
            if (this.checkBox4.Checked)
            {
                text = Path.GetTempFileName();
                this.pictureBox4.Image.Save(text, ImageFormat.Jpeg);
                GeneralUtility.ArrayCaptureImagesPath.Add(text);
            }
            ReportDirectImage reportDirectImage = new ReportDirectImage();
            reportDirectImage.Show();
        }

        // Token: 0x06000044 RID: 68 RVA: 0x00009CBC File Offset: 0x00008CBC
        private void buttonKetQua_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPageKetQua;
        }

        // Token: 0x06000045 RID: 69 RVA: 0x00009CD4 File Offset: 0x00008CD4
        private int LoadMauKetQua(int intDichVuId)
        {
            EClinicDB.LoadDatasetIntoComboBox(ref this.comboBoxMauKetQua, "KetQuaSieuAmMau", "", StringExt.StringNull(intDichVuId), string.Empty);
            return this.comboBoxMauKetQua.Items.Count;
        }

        // Token: 0x06000046 RID: 70 RVA: 0x00009D1C File Offset: 0x00008D1C
        private void LoadControlKetQuaSA(string stringMaSieuAm)
        {
            this.boolLoadedControlKetqua = true;
        }

        // Token: 0x06000047 RID: 71 RVA: 0x00009D28 File Offset: 0x00008D28
        private void buttonMacDinh_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("SELECT  `sa`.Title, `sa`.Title_Alias,  `sa`.Text_001,  `sa`.Text_002,  `sa`.Text_003,  `sa`.KetLuan,  `sa`.GhiChu FROM  `dm_dichvu_giatrichuan` sa WHERE sa.`DichVu_GiaTriChuan_Id` ='{0}'", this.comboBoxMauKetQua.SelectedValue);
            dataSet = EClinicDB.FillDataset(stringBuilder.ToString(), true);
            DataTable dataTable = dataSet.Tables[0];
            DataTableReader dataTableReader = dataTable.CreateDataReader();
            while (dataTableReader.Read())
            {
                this.richTextBoxExtNoiDung.RichTextBox.Rtf = dataTableReader.GetString(2);
                this.richTextBoxExtKetLuan.RichTextBox.Rtf = dataTableReader.GetString(5);
                this.richTextBoxLoiDan.Rtf = dataTableReader.GetValue(6).ToString();
            }
            dataTableReader.Close();
        }

        // Token: 0x06000048 RID: 72 RVA: 0x00009DDC File Offset: 0x00008DDC
        private void buttonLayLaiKetQua_Click(object sender, EventArgs e)
        {
            this.DanhSachKetQuaSieuAmDaThucHien();
            if (this.dataGridViewExt1.RowCount > 0)
            {
                this.buttonSuaKetQua.Enabled = true;
            }
            else
            {
                this.buttonSuaKetQua.Enabled = false;
            }
        }

        // Token: 0x06000049 RID: 73 RVA: 0x00009E24 File Offset: 0x00008E24
        private void DanhSachKetQuaSieuAmDaThucHien()
        {
            string empty = string.Empty;
            EClinicDB.LoadDatasetIntoDataGridView(ref this.dataGridViewExt1, "YeuCauSieuAmDaThucHien", "", StringExt.StringNull(this.comboBoxPhongSieuAm.SelectedValue));
            this.dataGridViewExt1.HeaderColumnState = DataGridViewExt.CustomHeaderState.HideColumn;
            this.dataGridViewExt1.CustomHeaderText = "SoPhieuYeuCau|Số phiếu YC|80; Ho_Ten|Họ tên Bệnh nhân|130; TenDichVu|Tên dịch vụ|120;DonGia|Đơn giá|50; MienGiam|Miễn giảm|50; TenPhongBan|Phòng ban thực hiện|80; NgayYeuCau|Ngày yêu cầu|110; TrangThai|Trạng thái|100";
        }

        // Token: 0x0600004A RID: 74 RVA: 0x00009E7C File Offset: 0x00008E7C
        private bool LoadDuLieuBenhNhan(int intBenhNhanID)
        {
            ParamCollection paramCollection = new ParamCollection();
            paramCollection.Add("DataGroup", DbDataType.VarChar, 50, "ThongTinBenhNhan");
            paramCollection.Add("FiltData", DbDataType.Int32, 11, intBenhNhanID);
            DataSet dataSet = EClinicDB.FillDatasetDecrypt("sp_Sys_GetListDataGridView", paramCollection, "dm_benhnhan");
            DataRow dataRow = dataSet.Tables[0].Rows[0];
            bool result;
            if (dataRow != null)
            {
                this.labelMaYTE.Text = StringExt.StringNull(dataRow["MaYTe"]);
                this.labelHoTenBenhNhan.Text = StringExt.StringNull(dataRow["Ho_Ten"]);
                this.labelGioiTinh.Text = StringExt.StringNull(dataRow["Gioi_Tinh"]);
                this.labelNamSinh.Text = StringExt.StringNull(dataRow["Nam_Sinh"]);
                this.labelDiaChi.Text = StringExt.StringNull(dataRow["Dia_Chi"]) + ", " + StringExt.StringNull(dataRow["Quan_Huyen"]);
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        // Token: 0x0600004B RID: 75 RVA: 0x00009FA4 File Offset: 0x00008FA4
        private void buttonSaveKetQua_Click(object sender, EventArgs e)
        {
            if (this.LuuKetQuaSieuAm())
            {
                this.SetTrangThaiNutLenh(EchoAdmin.ButtonStat.Save);
                this.buttonCapnhatDataGrid.PerformClick();
            }
        }

        // Token: 0x0600004C RID: 76 RVA: 0x00009FD8 File Offset: 0x00008FD8
        private bool LuuKetQuaSieuAm()
        {
            string empty = string.Empty;
            ParamCollection paramCollection = new ParamCollection();
            if (this.intClsKetqua == 0)
            {
                paramCollection.Add("GroupCommand", DbDataType.VarString, 10, "INSERT");
            }
            else
            {
                paramCollection.Add("GroupCommand", DbDataType.VarString, 10, "UPDATE");
            }
            paramCollection.Add("CLSKetQua_Id", DbDataType.Int32, 11, this.intClsKetqua, ParameterDirection.InputOutput);
            paramCollection.Add("YeuCauChiTiet_Id", DbDataType.Int32, 11, this.intCLSKetQuaChiTiet_Id);
            paramCollection.Add("NgayThucHien", DbDataType.DateTime, 1, this.dateTimePickerThucHien.Value);
            paramCollection.Add("NoiThucHien_Id", DbDataType.Int32, 1, (int)this.comboBoxPhongSieuAm.SelectedValue);
            paramCollection.Add("BacSiThucHien_Id", DbDataType.Int32, 11, (int)this.comboBoxBsSieuAm.SelectedValue);
            paramCollection.Add("ChanDoanLamSang", DbDataType.String, 500, this.textBoxChanDoanLamSang.Text);
            paramCollection.Add("MoTa", DbDataType.Blob, 1, this.richTextBoxExtNoiDung.RichTextBox.Rtf);
            paramCollection.Add("KetLuan", DbDataType.Blob, 1, this.richTextBoxExtKetLuan.RichTextBox.Rtf);
            paramCollection.Add("GhiChu", DbDataType.Blob, 1, this.richTextBoxLoiDan.Rtf);
            try
            {
                EClinicDB.ExecuteNonQuery("spps_clsketqua", CommandType.StoredProcedure, paramCollection);
                this.intClsKetqua = int.Parse(paramCollection[1].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat(new object[]
                {
                    ex.Message,
                    "\n",
                    ex.Source,
                    "\n",
                    ex.InnerException
                }));
            }
            paramCollection.Clear();
            GeneralUtility.ArrayCaptureImages.Clear();
            if (this.checkBox1.Checked)
            {
                GeneralUtility.ArrayCaptureImages.Add((Bitmap)this.pictureBox1.Image.Clone());
            }
            if (this.checkBox2.Checked)
            {
                GeneralUtility.ArrayCaptureImages.Add((Bitmap)this.pictureBox2.Image.Clone());
            }
            if (this.checkBox3.Checked)
            {
                GeneralUtility.ArrayCaptureImages.Add((Bitmap)this.pictureBox3.Image.Clone());
            }
            if (this.checkBox4.Checked)
            {
                GeneralUtility.ArrayCaptureImages.Add((Bitmap)this.pictureBox4.Image.Clone());
            }
            foreach (int num in this.aImagesId)
            {
                paramCollection.Add("GroupCommand", DbDataType.VarString, 10, "DELETE");
                paramCollection.Add("Images_Id", DbDataType.Int32, 11, num);
                paramCollection.Add("CLSKetQua_Id", DbDataType.Int32, 11, 0);
                paramCollection.Add("Image_Data", DbDataType.Blob, 0, null);
                paramCollection.Add("TamNgung", DbDataType.Int32, 1, 0);
                try
                {
                    EClinicDB.ExecuteNonQuery("spps_clsketqua_images", CommandType.StoredProcedure, paramCollection);
                    paramCollection.Clear();
                }
                catch (Exception ex)
                {
                    paramCollection.Clear();
                    MessageBox.Show(string.Concat(new object[]
                    {
                        ex.Message,
                        "\n",
                        ex.Source,
                        "\n",
                        ex.InnerException
                    }));
                }
            }
            foreach (Bitmap image in GeneralUtility.ArrayCaptureImages)
            {
                paramCollection.Add("GroupCommand", DbDataType.VarString, 10, "INSERT");
                paramCollection.Add("Images_Id", DbDataType.Int32, 11, 0);
                paramCollection.Add("CLSKetQua_Id", DbDataType.Int32, 11, this.intClsKetqua);
                paramCollection.Add("Image_Data", DbDataType.Blob, 0, GeneralUtility.ReadBitmap2ByteArray(image));
                paramCollection.Add("TamNgung", DbDataType.Int32, 1, 0);
                try
                {
                    EClinicDB.ExecuteNonQuery("spps_clsketqua_images", CommandType.StoredProcedure, paramCollection);
                    paramCollection.Clear();
                }
                catch (Exception ex)
                {
                    paramCollection.Clear();
                    MessageBox.Show(string.Concat(new object[]
                    {
                        ex.Message,
                        "\n",
                        ex.Source,
                        "\n",
                        ex.InnerException
                    }));
                }
            }
            return true;
        }

        // Token: 0x0600004D RID: 77 RVA: 0x0000A4F4 File Offset: 0x000094F4
        private void buttonInKetQua_Click(object sender, EventArgs e)
        {

            ParamCollection paramCollection = new ParamCollection();
            paramCollection.Add("param1", DbDataType.Int32, 11, this.intCLSKetQuaChiTiet_Id);
            DataSet dataSet = EClinicDB.FillDatasetDecrypt("sp_rp_ketqua_sieuam_all_value", paramCollection, "dm_benhnhan");

            dataSet.Tables[0].TableName = "KetQuaSieuAm";

            paramCollection.Clear();

            new ReportCommon(EClinicConfig.ReportsPath + "SieuAmChung.rpt")
            {
                DataSource = dataSet
            }.Show();
        }

        // Token: 0x0600004E RID: 78 RVA: 0x0000A5DC File Offset: 0x000095DC
        private void buttonSuaKetQua_Click(object sender, EventArgs e)
        {
            if (this.boolDangTienHanhSieuAm)
            {
                MessageBox.Show("Đang thực hiện siêu âm!!!\n\nKhông thể tiến hành sửa chữa kết quả cũ\n\n Cần lưu lại kết quả đang thực hiện.");
                this.tabControl1.SelectedTab = this.tabPageKetQua;
            }
            else
            {
                this.LoadKetQuaSieuAmDaThucHien(this.intCLSKetQuaChiTiet_Id);
                this.SetTrangThaiNutLenh(EchoAdmin.ButtonStat.Edit);
            }
        }

        // Token: 0x0600004F RID: 79 RVA: 0x0000A630 File Offset: 0x00009630
        private void LoadKetQuaSieuAmDaThucHien(int intCLSKetQuaChiTiet_Id)
        {
            this.boolLoadedCapture = true;
            this.labelSoPhieuYeuCau.Text = this.dataGridViewExt1.SelectedRows[0].Cells["SoPhieuYeuCau"].Value.ToString();
            EClinicConfig.BenhNhanID = int.Parse(StringExt.StringZero(this.dataGridViewExt1.SelectedRows[0].Cells["BenhNhan_Id"].Value));
            if (this.LoadDuLieuBenhNhan(EClinicConfig.BenhNhanID))
            {
                this.labelBsSieuAm.Text = this.comboBoxBsSieuAm.Text;
                this.labelPhongBanThucHien.Text = this.comboBoxPhongSieuAm.Text;
                this.labelDichVuSieuAm.Text = StringExt.StringNull(this.dataGridViewExt1.SelectedRows[0].Cells["TenDichVu"].Value);
                this.intDichVu_Id = int.Parse(StringExt.StringZero(this.dataGridViewExt1.SelectedRows[0].Cells["DichVu_id"].Value));
                DataSet dataSet = EClinicDB.FillDataset("SELECT * FROM clsketqua KQ WHERE KQ.CLSKetQua_Id = '" + this.dataGridViewExt1.SelectedRows[0].Cells["CLSKetQua_Id"].Value.ToString() + "'");
                DataRow dataRow = dataSet.Tables[0].Rows[0];
                if (dataRow != null)
                {
                    this.textBoxChanDoanLamSang.Text = StringExt.StringNull(dataRow["ChanDoanLamSang"]);
                    this.richTextBoxExtNoiDung.RichTextBox.Rtf = StringExt.StringNull(dataRow["MoTa"]);
                    this.richTextBoxExtKetLuan.RichTextBox.Rtf = StringExt.StringNull(dataRow["KetLuan"]);
                    this.richTextBoxLoiDan.Rtf = StringExt.StringNull(dataRow["GhiChu"]);
                }
                dataSet = EClinicDB.FillDataset("SELECT * FROM clsketqua_images HA WHERE HA.CLSKetQua_Id = '" + this.dataGridViewExt1.SelectedRows[0].Cells["CLSKetQua_Id"].Value.ToString() + "'");
                this.aImagesId.Clear();
                this.pictureBox1.Image = null;
                this.checkBox1.Checked = false;
                this.pictureBox2.Image = null;
                this.checkBox2.Checked = false;
                this.pictureBox3.Image = null;
                this.checkBox3.Checked = false;
                this.pictureBox4.Image = null;
                this.checkBox4.Checked = false;
                for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
                {
                    dataRow = dataSet.Tables[0].Rows[i];
                    this.aImagesId.Add((int)dataRow["Images_Id"]);
                    byte[] content = (byte[])dataRow["Image_Data"];
                    Bitmap image = GeneralUtility.ReadByteArray2Image(content);
                    if (i == 0)
                    {
                        this.pictureBox1.Image = image;
                        this.checkBox1.Checked = true;
                    }
                    if (i == 1)
                    {
                        this.pictureBox2.Image = image;
                        this.checkBox2.Checked = true;
                    }
                    if (i == 2)
                    {
                        this.pictureBox3.Image = image;
                        this.checkBox3.Checked = true;
                    }
                    if (i == 3)
                    {
                        this.pictureBox4.Image = image;
                        this.checkBox4.Checked = true;
                    }
                }
                if (this.LoadMauKetQua(this.intDichVu_Id) > 0)
                {
                    this.buttonMacDinh.Enabled = true;
                }
            }
            this.boolDangTienHanhSieuAm = true;
            this.tabControl1.SelectedTab = this.tabPageKetQua;
        }

        // Token: 0x06000050 RID: 80 RVA: 0x0000AA5B File Offset: 0x00009A5B
        private void buttonChonBenhMoi_Click(object sender, EventArgs e)
        {
            this.intClsKetqua = 0;
            this.intCLSKetQuaChiTiet_Id = 0;
            this.boolDangTienHanhSieuAm = false;
            this.CapNhatDataGridDsYeuCau();
        }

        // Token: 0x06000051 RID: 81 RVA: 0x0000AA7A File Offset: 0x00009A7A
        private void buttonPauseHinhAnh_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x06000052 RID: 82 RVA: 0x0000AA80 File Offset: 0x00009A80
        private void buttonTimKetQua_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ParamCollection paramCollection = new ParamCollection();
            paramCollection.Add("DataGroup", DbDataType.VarChar, 50, "yeucausieuamdathuchien");
            paramCollection.Add("FiltData", DbDataType.VarChar, 11, string.Empty);
            ds = EClinicDB.FillDatasetDecrypt("sp_Sys_GetListDataGridView", paramCollection, "dm_benhnhan");
            TimKetQuaSieuAm timKetQuaSieuAm = new TimKetQuaSieuAm(ds);
            timKetQuaSieuAm.ShowDialog();
            this.intClsKetqua = timKetQuaSieuAm.ValueMember;
            if (this.intClsKetqua > 0)
            {
                this.buttonTienHanh.Enabled = false;
                this.buttonSuaKetQua.Enabled = true;
                this.ThemDanhSachKetQuaSieuAmDaThucHien(this.intClsKetqua);
            }
        }

        // Token: 0x06000053 RID: 83 RVA: 0x0000AB28 File Offset: 0x00009B28
        private void ThemDanhSachKetQuaSieuAmDaThucHien(int intClsKetqua)
        {
            ParamCollection paramCollection = new ParamCollection();
            paramCollection.Add("param1", DbDataType.Int32, 11, intClsKetqua);
            DataSet dataSet = EClinicDB.FillDatasetDecrypt("sp_KetQuaDaThucHienSieuAm", paramCollection, "dm_benhnhan");
            this.dataGridViewExt1.DataSource = dataSet;
            this.dataGridViewExt1.DataMember = dataSet.Tables[0].TableName;
            this.dataGridViewExt1.HeaderColumnState = DataGridViewExt.CustomHeaderState.HideColumn;
            this.dataGridViewExt1.CustomHeaderText = "SoPhieuYeuCau|Số phiếu YC|80; Ho_Ten|Họ tên Bệnh nhân|130; TenDichVu|Tên dịch vụ|120;TenPhongBan|Phòng ban thực hiện|80; NgayTao|Ngày thực hiện|110";
            this.intCLSKetQuaChiTiet_Id = int.Parse(StringExt.StringZero(this.dataGridViewExt1.SelectedRows[0].Cells["YeuCauChiTiet_Id"].Value));
        }

        // Token: 0x04000046 RID: 70
        private const string HEADER_COLUMN_TEXT = "SoPhieuYeuCau|Số phiếu YC|80; Ho_Ten|Họ tên Bệnh nhân|130; TenDichVu|Tên dịch vụ|120;DonGia|Đơn giá|50; MienGiam|Miễn giảm|50; TenPhongBan|Phòng ban thực hiện|80; NgayYeuCau|Ngày yêu cầu|110; TrangThai|Trạng thái|100";

        // Token: 0x0400008C RID: 140
        private bool boolLoadedControlKetqua = false;

        // Token: 0x0400008D RID: 141
        private bool boolLoadedCapture = true;

        // Token: 0x0400008E RID: 142
        private bool boolDangTienHanhSieuAm = false;

        // Token: 0x0400008F RID: 143
        private int intDichVu_Id = 0;

        // Token: 0x04000090 RID: 144
        private int intCLSKetQuaChiTiet_Id = 0;

        // Token: 0x04000091 RID: 145
        private List<int> aImagesId = new List<int>();

        // Token: 0x04000092 RID: 146
        private int intClsKetqua = 0;

        // Token: 0x02000008 RID: 8
        private enum ButtonStat
        {
            // Token: 0x04000094 RID: 148
            Progress,
            // Token: 0x04000095 RID: 149
            Edit,
            // Token: 0x04000096 RID: 150
            Save,
            // Token: 0x04000097 RID: 151
            Update,
            // Token: 0x04000098 RID: 152
            Cancel,
            // Token: 0x04000099 RID: 153
            AddNew
        }
    }
}
