using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000023 RID: 35
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedSieuAmMM : Component, ICachedReport
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00005DE8 File Offset: 0x00004DE8
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00005DFB File Offset: 0x00004DFB
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

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00005E00 File Offset: 0x00004E00
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00005E13 File Offset: 0x00004E13
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

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00005E18 File Offset: 0x00004E18
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00005E2F File Offset: 0x00004E2F
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

		// Token: 0x0600013C RID: 316 RVA: 0x00005E34 File Offset: 0x00004E34
		public virtual ReportDocument CreateReport()
		{
			return new SieuAmMM
			{
				Site = this.Site
			};
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00005E5C File Offset: 0x00004E5C
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
