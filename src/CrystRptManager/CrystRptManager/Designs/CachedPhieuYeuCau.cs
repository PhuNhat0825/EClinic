using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000030 RID: 48
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedPhieuYeuCau : Component, ICachedReport
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00006AC4 File Offset: 0x00005AC4
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00006AD7 File Offset: 0x00005AD7
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

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00006ADC File Offset: 0x00005ADC
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00006AEF File Offset: 0x00005AEF
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

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00006AF4 File Offset: 0x00005AF4
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00006B0B File Offset: 0x00005B0B
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

		// Token: 0x060001B3 RID: 435 RVA: 0x00006B10 File Offset: 0x00005B10
		public virtual ReportDocument CreateReport()
		{
			return new PhieuYeuCau
			{
				Site = this.Site
			};
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00006B38 File Offset: 0x00005B38
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
