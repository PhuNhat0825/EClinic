using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000012 RID: 18
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedcrSATIM : Component, ICachedReport
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00003A2C File Offset: 0x00002A2C
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00003A3F File Offset: 0x00002A3F
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

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00003A44 File Offset: 0x00002A44
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00003A57 File Offset: 0x00002A57
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00003A5C File Offset: 0x00002A5C
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00003A73 File Offset: 0x00002A73
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

		// Token: 0x060000A7 RID: 167 RVA: 0x00003A78 File Offset: 0x00002A78
		public virtual ReportDocument CreateReport()
		{
			return new crSATIM
			{
				Site = this.Site
			};
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003AA0 File Offset: 0x00002AA0
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
