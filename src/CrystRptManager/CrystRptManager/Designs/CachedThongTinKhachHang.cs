using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000026 RID: 38
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedThongTinKhachHang : Component, ICachedReport
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00006208 File Offset: 0x00005208
		// (set) Token: 0x0600014E RID: 334 RVA: 0x0000621B File Offset: 0x0000521B
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00006220 File Offset: 0x00005220
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00006233 File Offset: 0x00005233
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00006238 File Offset: 0x00005238
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0000624F File Offset: 0x0000524F
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

		// Token: 0x06000153 RID: 339 RVA: 0x00006254 File Offset: 0x00005254
		public virtual ReportDocument CreateReport()
		{
			return new ThongTinKhachHang
			{
				Site = this.Site
			};
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000627C File Offset: 0x0000527C
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
