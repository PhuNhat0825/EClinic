using CrystalLibrary;
using CrystRptManager.Designs;
using System;
using System.Data;
using System.Windows.Forms;
using Utility;

namespace CrystRptManager
{
    public partial class ReportCommon : Form
    {
        // Token: 0x06000056 RID: 86 RVA: 0x00002A4C File Offset: 0x00001A4C
        public ReportCommon()
        {
            this.InitializeComponent();
        }

        public ReportCommon(string sReportFile)
        {
            this.InitializeComponent();
            this._sReportFile = sReportFile;
            this._myReport.DataSource = this._daReport;
        }

        public ReportCommon(string sReportFile, DataSet ds)
        {
            this.InitializeComponent();
            this._sReportFile = sReportFile;
            this._daReport = ds;
        }

        // Token: 0x06000059 RID: 89 RVA: 0x00002BA8 File Offset: 0x00001BA8
        public ReportCommon(string sReportFile, DataSet ds, string sParaName, object oParaValue)
        {
            this.InitializeComponent();
            this._sReportFile = sReportFile;
            this._daReport = ds;
            this._sParaName = sParaName;
            this._oParaValue = oParaValue;
            this._myReport.SetParameter(this._sParaName, this._oParaValue);
        }

        // Token: 0x0600005A RID: 90 RVA: 0x00002C44 File Offset: 0x00001C44
        public ReportCommon(string sReportFile, DataSet ds, string[] asParaName, object[] aoParaValue)
        {
            this.InitializeComponent();
            this._sReportFile = sReportFile;
            this._daReport = ds;
            this._asParaName = asParaName;
            this._aoParaValue = aoParaValue;
            this._myReport.SetParameter(this._asParaName, this._aoParaValue);
        }

        private void ReportCommon_Load(object sender, EventArgs e)
        {
            this._myReport.ReportFile = this._sReportFile;
            this._myReport.DataSource = this._daReport;
            this._myReport.Open();
            this._sReportName = this._sReportFile.Substring(this._sReportFile.LastIndexOf("\\") + 1, this._sReportFile.LastIndexOf(".") - this._sReportFile.LastIndexOf("\\") - 1);
            this.Text = this._AppName + "   " + this._sReportName;
            this.crystalReportViewer1.ReportSource = this._myReport.ReportSource;
            //this.crystalReportViewer1.ReportSource = this._sReportSource;
        }

        // Token: 0x17000030 RID: 48
        // (get) Token: 0x0600005D RID: 93 RVA: 0x00002DC8 File Offset: 0x00001DC8
        // (set) Token: 0x0600005C RID: 92 RVA: 0x00002D98 File Offset: 0x00001D98
        public string ReportName
        {
            get
            {
                return this._sReportName;
            }
            set
            {
                if (value != null && value != string.Empty)
                {
                    this._sReportName = value;
                }
            }
        }

        // Token: 0x17000031 RID: 49
        // (get) Token: 0x0600005F RID: 95 RVA: 0x00002DEC File Offset: 0x00001DEC
        // (set) Token: 0x0600005E RID: 94 RVA: 0x00002DE0 File Offset: 0x00001DE0
        public string ReportFile
        {
            get
            {
                return this._sReportFile;
            }
            set
            {
                this._sReportFile = value;
            }
        }

        public DataSet DataSource
        {
            get
            {
                return this._daReport;
            }
            set
            {
                this._daReport = value;
            }
        }

        private object _sReportSource = null;

        public object ReportSource
        {
            get
            {
                return this._sReportSource;
            }
            set
            {
                this._sReportSource = value;
            }
        }

        // Token: 0x06000062 RID: 98 RVA: 0x00002E26 File Offset: 0x00001E26
        public void SetParameter(string sParaName, object oParaValue)
        {
            this._myReport.SetParameterValue(sParaName, oParaValue);
        }

        // Token: 0x06000063 RID: 99 RVA: 0x00002E37 File Offset: 0x00001E37
        public void SetParameter(string[] asParaName, object[] aoParaValue)
        {
            this._myReport.SetParameterValue(asParaName, aoParaValue);
        }

        // Token: 0x06000064 RID: 100 RVA: 0x00002E48 File Offset: 0x00001E48
        public void ViewerStatusBar(bool visible)
        {
        }

        // Token: 0x04000005 RID: 5
        private string _sReportFile = string.Empty;

        private CrystalHelper _myReport = new CrystalHelper();

        // Token: 0x04000007 RID: 7
        private string _sReportName = string.Empty;

        // Token: 0x04000008 RID: 8
        private string _AppName = Application.ProductName + "-" + Application.ProductVersion;

        // Token: 0x04000009 RID: 9
        private DataSet _daReport = null;

        // Token: 0x0400000A RID: 10
        private string[] _asParaName;

        // Token: 0x0400000B RID: 11
        private object[] _aoParaValue;

        // Token: 0x0400000C RID: 12
        private string _sParaName;

        // Token: 0x0400000D RID: 13
        private object _oParaValue;

    }
}
