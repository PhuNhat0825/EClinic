using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x0200000E RID: 14
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedcrSATQ_Nam : Component, ICachedReport
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00003608 File Offset: 0x00002608
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000361B File Offset: 0x0000261B
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

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00003620 File Offset: 0x00002620
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00003633 File Offset: 0x00002633
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

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00003638 File Offset: 0x00002638
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000364F File Offset: 0x0000264F
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

		// Token: 0x0600007C RID: 124 RVA: 0x00003654 File Offset: 0x00002654
		public virtual ReportDocument CreateReport()
		{
			return new crSATQ_Nam
			{
				Site = this.Site
			};
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000367C File Offset: 0x0000267C
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
