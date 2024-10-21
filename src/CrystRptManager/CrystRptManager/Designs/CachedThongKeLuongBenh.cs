using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000014 RID: 20
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedThongKeLuongBenh : Component, ICachedReport
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00003CE0 File Offset: 0x00002CE0
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00003CF3 File Offset: 0x00002CF3
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

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00003CF8 File Offset: 0x00002CF8
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00003D0B File Offset: 0x00002D0B
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00003D10 File Offset: 0x00002D10
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00003D27 File Offset: 0x00002D27
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

		// Token: 0x060000C1 RID: 193 RVA: 0x00003D2C File Offset: 0x00002D2C
		public virtual ReportDocument CreateReport()
		{
			return new ThongKeLuongBenh
			{
				Site = this.Site
			};
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003D54 File Offset: 0x00002D54
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
