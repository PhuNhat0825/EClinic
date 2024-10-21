using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000006 RID: 6
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedcrSATQ_Nu : Component, ICachedReport
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000025E4 File Offset: 0x000015E4
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000025F7 File Offset: 0x000015F7
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000025FC File Offset: 0x000015FC
		// (set) Token: 0x06000028 RID: 40 RVA: 0x0000260F File Offset: 0x0000160F
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

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002614 File Offset: 0x00001614
		// (set) Token: 0x0600002A RID: 42 RVA: 0x0000262B File Offset: 0x0000162B
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x0600002B RID: 43 RVA: 0x00002630 File Offset: 0x00001630
		public virtual ReportDocument CreateReport()
		{
			return new crSATQ_Nu
			{
				Site = this.Site
			};
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002658 File Offset: 0x00001658
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
