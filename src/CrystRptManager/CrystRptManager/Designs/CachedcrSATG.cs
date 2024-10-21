using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x0200002E RID: 46
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedcrSATG : Component, ICachedReport
	{
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00006930 File Offset: 0x00005930
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00006943 File Offset: 0x00005943
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

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00006948 File Offset: 0x00005948
		// (set) Token: 0x0600019E RID: 414 RVA: 0x0000695B File Offset: 0x0000595B
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

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00006960 File Offset: 0x00005960
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00006977 File Offset: 0x00005977
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

		// Token: 0x060001A1 RID: 417 RVA: 0x0000697C File Offset: 0x0000597C
		public virtual ReportDocument CreateReport()
		{
			return new crSATG
			{
				Site = this.Site
			};
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000069A4 File Offset: 0x000059A4
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
