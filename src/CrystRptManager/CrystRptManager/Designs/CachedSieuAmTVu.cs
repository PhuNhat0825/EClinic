using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x0200002A RID: 42
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedSieuAmTVu : Component, ICachedReport
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000065E4 File Offset: 0x000055E4
		// (set) Token: 0x06000177 RID: 375 RVA: 0x000065F7 File Offset: 0x000055F7
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

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000178 RID: 376 RVA: 0x000065FC File Offset: 0x000055FC
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0000660F File Offset: 0x0000560F
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00006614 File Offset: 0x00005614
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0000662B File Offset: 0x0000562B
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

		// Token: 0x0600017C RID: 380 RVA: 0x00006630 File Offset: 0x00005630
		public virtual ReportDocument CreateReport()
		{
			return new SieuAmTVu
			{
				Site = this.Site
			};
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00006658 File Offset: 0x00005658
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
