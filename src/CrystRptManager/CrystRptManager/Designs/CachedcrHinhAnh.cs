using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x0200001D RID: 29
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedcrHinhAnh : Component, ICachedReport
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000053E4 File Offset: 0x000043E4
		// (set) Token: 0x06000106 RID: 262 RVA: 0x000053F7 File Offset: 0x000043F7
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

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000053FC File Offset: 0x000043FC
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0000540F File Offset: 0x0000440F
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

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00005414 File Offset: 0x00004414
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000542B File Offset: 0x0000442B
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

		// Token: 0x0600010B RID: 267 RVA: 0x00005430 File Offset: 0x00004430
		public virtual ReportDocument CreateReport()
		{
			return new crHinhAnh
			{
				Site = this.Site
			};
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00005458 File Offset: 0x00004458
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
