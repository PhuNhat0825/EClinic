using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x0200002C RID: 44
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedSieuAmChung : Component, ICachedReport
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000067C0 File Offset: 0x000057C0
		// (set) Token: 0x0600018B RID: 395 RVA: 0x000067D3 File Offset: 0x000057D3
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

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000067D8 File Offset: 0x000057D8
		// (set) Token: 0x0600018D RID: 397 RVA: 0x000067EB File Offset: 0x000057EB
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

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600018E RID: 398 RVA: 0x000067F0 File Offset: 0x000057F0
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00006807 File Offset: 0x00005807
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

		// Token: 0x06000190 RID: 400 RVA: 0x0000680C File Offset: 0x0000580C
		public virtual ReportDocument CreateReport()
		{
			return new SieuAmChung
			{
				Site = this.Site
			};
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00006834 File Offset: 0x00005834
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
