using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000033 RID: 51
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedcrSATV : Component, ICachedReport
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x000070A4 File Offset: 0x000060A4
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x000070B7 File Offset: 0x000060B7
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

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000070BC File Offset: 0x000060BC
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x000070CF File Offset: 0x000060CF
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

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x000070D4 File Offset: 0x000060D4
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x000070EB File Offset: 0x000060EB
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

		// Token: 0x060001CA RID: 458 RVA: 0x000070F0 File Offset: 0x000060F0
		public virtual ReportDocument CreateReport()
		{
			return new crSATV
			{
				Site = this.Site
			};
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00007118 File Offset: 0x00006118
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
