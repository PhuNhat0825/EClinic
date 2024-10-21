using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000003 RID: 3
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedSieuAmPhuKhoa : Component, ICachedReport
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000021C8 File Offset: 0x000011C8
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000021DB File Offset: 0x000011DB
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

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000021E0 File Offset: 0x000011E0
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000021F3 File Offset: 0x000011F3
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

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000021F8 File Offset: 0x000011F8
		// (set) Token: 0x06000013 RID: 19 RVA: 0x0000220F File Offset: 0x0000120F
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

		// Token: 0x06000014 RID: 20 RVA: 0x00002214 File Offset: 0x00001214
		public virtual ReportDocument CreateReport()
		{
			return new SieuAmPhuKhoa
			{
				Site = this.Site
			};
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000223C File Offset: 0x0000123C
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
