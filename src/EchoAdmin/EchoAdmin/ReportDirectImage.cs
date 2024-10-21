using EchoAdmin.Reports;
using System;
using System.Data;
using System.Windows.Forms;
using Utility;

namespace EchoAdmin
{
    // Token: 0x02000003 RID: 3
    public partial class ReportDirectImage : Form
    {
        // Token: 0x0600000E RID: 14 RVA: 0x000027A0 File Offset: 0x000017A0
        public ReportDirectImage()
        {
            this.InitializeComponent();
        }

        // Token: 0x0600000F RID: 15 RVA: 0x000027BC File Offset: 0x000017BC
        private void ReportDirectImage_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.BringToFront();
            this.crystalReportViewer1.DisplayGroupTree = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.ShowCloseButton = false;
            base.WindowState = FormWindowState.Maximized;
        }

        // Token: 0x06000010 RID: 16 RVA: 0x00002814 File Offset: 0x00001814
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable("image");
            dataTable.Columns.Add("image", typeof(byte[]));
            dataSet.Tables.Add(dataTable);
            foreach (string imagePath in GeneralUtility.ArrayCaptureImagesPath)
            {
                DataRow dataRow = dataSet.Tables["image"].NewRow();
                dataRow[0] = GeneralUtility.ReadBitmap2ByteArray(imagePath);
                dataSet.Tables["image"].Rows.Add(dataRow);
            }
            GeneralUtility.DeleteArrayImage();
            HinhAnhTrucTiep hinhAnhTrucTiep = new HinhAnhTrucTiep();
            hinhAnhTrucTiep.SetDataSource(dataTable);
            this.crystalReportViewer1.ReportSource = hinhAnhTrucTiep;
        }
    }
}
