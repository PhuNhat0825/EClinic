using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000008 RID: 8
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedSieuAmThai2D_1 : Component, ICachedReport
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000027E4 File Offset: 0x000017E4
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000027F7 File Offset: 0x000017F7
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

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000027FC File Offset: 0x000017FC
		// (set) Token: 0x0600003D RID: 61 RVA: 0x0000280F File Offset: 0x0000180F
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

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002814 File Offset: 0x00001814
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0000282B File Offset: 0x0000182B
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

		// Token: 0x06000040 RID: 64 RVA: 0x00002830 File Offset: 0x00001830
		public virtual ReportDocument CreateReport()
		{
			return new SieuAmThai2D_1
			{
				Site = this.Site
			};
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002858 File Offset: 0x00001858
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
