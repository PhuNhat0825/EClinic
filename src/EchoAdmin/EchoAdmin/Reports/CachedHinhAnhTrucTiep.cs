using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace EchoAdmin.Reports
{
	// Token: 0x0200000C RID: 12
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedHinhAnhTrucTiep : Component, ICachedReport
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0000B3D0 File Offset: 0x0000A3D0
		// (set) Token: 0x0600006B RID: 107 RVA: 0x0000B3E3 File Offset: 0x0000A3E3
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

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000B3E8 File Offset: 0x0000A3E8
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0000B3FB File Offset: 0x0000A3FB
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000B400 File Offset: 0x0000A400
		// (set) Token: 0x0600006F RID: 111 RVA: 0x0000B417 File Offset: 0x0000A417
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

		// Token: 0x06000070 RID: 112 RVA: 0x0000B41C File Offset: 0x0000A41C
		public virtual ReportDocument CreateReport()
		{
			return new HinhAnhTrucTiep
			{
				Site = this.Site
			};
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000B444 File Offset: 0x0000A444
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
