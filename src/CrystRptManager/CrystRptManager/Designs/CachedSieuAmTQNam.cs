using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x0200001B RID: 27
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedSieuAmTQNam : Component, ICachedReport
	{
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00005274 File Offset: 0x00004274
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00005287 File Offset: 0x00004287
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

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000528C File Offset: 0x0000428C
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x0000529F File Offset: 0x0000429F
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

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x000052A4 File Offset: 0x000042A4
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x000052BB File Offset: 0x000042BB
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

		// Token: 0x060000FA RID: 250 RVA: 0x000052C0 File Offset: 0x000042C0
		public virtual ReportDocument CreateReport()
		{
			return new SieuAmTQNam
			{
				Site = this.Site
			};
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000052E8 File Offset: 0x000042E8
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
