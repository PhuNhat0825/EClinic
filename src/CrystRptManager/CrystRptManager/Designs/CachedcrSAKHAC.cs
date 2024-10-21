using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000059 RID: 89
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedcrSAKHAC : Component, ICachedReport
	{
		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x0001A064 File Offset: 0x00019064
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x0001A077 File Offset: 0x00019077
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

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x0001A07C File Offset: 0x0001907C
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x0001A08F File Offset: 0x0001908F
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

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x0001A094 File Offset: 0x00019094
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x0001A0AB File Offset: 0x000190AB
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

		// Token: 0x06000752 RID: 1874 RVA: 0x0001A0B0 File Offset: 0x000190B0
		public virtual ReportDocument CreateReport()
		{
			return new crSAKHAC
			{
				Site = this.Site
			};
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0001A0D8 File Offset: 0x000190D8
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
