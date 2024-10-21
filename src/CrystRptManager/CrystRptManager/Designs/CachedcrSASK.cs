using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000019 RID: 25
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedcrSASK : Component, ICachedReport
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00005098 File Offset: 0x00004098
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x000050AB File Offset: 0x000040AB
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

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000050B0 File Offset: 0x000040B0
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x000050C3 File Offset: 0x000040C3
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

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000050C8 File Offset: 0x000040C8
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000050DF File Offset: 0x000040DF
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

		// Token: 0x060000E6 RID: 230 RVA: 0x000050E4 File Offset: 0x000040E4
		public virtual ReportDocument CreateReport()
		{
			return new crSASK
			{
				Site = this.Site
			};
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000510C File Offset: 0x0000410C
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
