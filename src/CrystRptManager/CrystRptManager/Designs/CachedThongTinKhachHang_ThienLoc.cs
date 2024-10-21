using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000021 RID: 33
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedThongTinKhachHang_ThienLoc : Component, ICachedReport
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00005C0C File Offset: 0x00004C0C
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00005C1F File Offset: 0x00004C1F
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

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00005C24 File Offset: 0x00004C24
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00005C37 File Offset: 0x00004C37
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

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00005C3C File Offset: 0x00004C3C
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00005C53 File Offset: 0x00004C53
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

		// Token: 0x06000128 RID: 296 RVA: 0x00005C58 File Offset: 0x00004C58
		public virtual ReportDocument CreateReport()
		{
			return new ThongTinKhachHang_ThienLoc
			{
				Site = this.Site
			};
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00005C80 File Offset: 0x00004C80
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
