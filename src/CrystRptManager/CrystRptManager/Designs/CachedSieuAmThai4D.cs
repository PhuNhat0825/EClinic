using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000035 RID: 53
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedSieuAmThai4D : Component, ICachedReport
	{
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00007280 File Offset: 0x00006280
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00007293 File Offset: 0x00006293
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

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00007298 File Offset: 0x00006298
		// (set) Token: 0x060001DB RID: 475 RVA: 0x000072AB File Offset: 0x000062AB
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060001DC RID: 476 RVA: 0x000072B0 File Offset: 0x000062B0
		// (set) Token: 0x060001DD RID: 477 RVA: 0x000072C7 File Offset: 0x000062C7
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

		// Token: 0x060001DE RID: 478 RVA: 0x000072CC File Offset: 0x000062CC
		public virtual ReportDocument CreateReport()
		{
			return new SieuAmThai4D
			{
				Site = this.Site
			};
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000072F4 File Offset: 0x000062F4
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
