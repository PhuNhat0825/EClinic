using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x0200000A RID: 10
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedSieuAmTGiap : Component, ICachedReport
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000029C0 File Offset: 0x000019C0
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000029D3 File Offset: 0x000019D3
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

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000029D8 File Offset: 0x000019D8
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000029EB File Offset: 0x000019EB
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

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000029F0 File Offset: 0x000019F0
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00002A07 File Offset: 0x00001A07
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

		// Token: 0x06000054 RID: 84 RVA: 0x00002A0C File Offset: 0x00001A0C
		public virtual ReportDocument CreateReport()
		{
			return new SieuAmTGiap
			{
				Site = this.Site
			};
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002A34 File Offset: 0x00001A34
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
