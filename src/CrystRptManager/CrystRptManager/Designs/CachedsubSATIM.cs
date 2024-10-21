using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000010 RID: 16
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedsubSATIM : Component, ICachedReport
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000037E4 File Offset: 0x000027E4
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000037F7 File Offset: 0x000027F7
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public virtual bool IsCacheable
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000037FC File Offset: 0x000027FC
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0000380F File Offset: 0x0000280F
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public virtual bool ShareDBLogonInfo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00003814 File Offset: 0x00002814
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000382B File Offset: 0x0000282B
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual TimeSpan CacheTimeOut
		{
			get
			{
				return CachedReportConstants.DEFAULT_TIMEOUT;
			}
			set
			{
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003830 File Offset: 0x00002830
		public virtual ReportDocument CreateReport()
		{
			return new subSATIM
			{
				Site = this.Site
			};
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003858 File Offset: 0x00002858
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
