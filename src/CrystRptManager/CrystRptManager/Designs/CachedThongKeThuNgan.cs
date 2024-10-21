using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000028 RID: 40
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedThongKeThuNgan : Component, ICachedReport
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000063C0 File Offset: 0x000053C0
		// (set) Token: 0x06000161 RID: 353 RVA: 0x000063D3 File Offset: 0x000053D3
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000162 RID: 354 RVA: 0x000063D8 File Offset: 0x000053D8
		// (set) Token: 0x06000163 RID: 355 RVA: 0x000063EB File Offset: 0x000053EB
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000063F0 File Offset: 0x000053F0
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00006407 File Offset: 0x00005407
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

		// Token: 0x06000166 RID: 358 RVA: 0x0000640C File Offset: 0x0000540C
		public virtual ReportDocument CreateReport()
		{
			return new ThongKeThuNgan
			{
				Site = this.Site
			};
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00006434 File Offset: 0x00005434
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
