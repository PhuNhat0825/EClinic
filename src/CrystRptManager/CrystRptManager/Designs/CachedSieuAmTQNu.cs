using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000055 RID: 85
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedSieuAmTQNu : Component, ICachedReport
	{
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x00019720 File Offset: 0x00018720
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00019733 File Offset: 0x00018733
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

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00019738 File Offset: 0x00018738
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x0001974B File Offset: 0x0001874B
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

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00019750 File Offset: 0x00018750
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x00019767 File Offset: 0x00018767
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

		// Token: 0x06000735 RID: 1845 RVA: 0x0001976C File Offset: 0x0001876C
		public virtual ReportDocument CreateReport()
		{
			return new SieuAmTQNu
			{
				Site = this.Site
			};
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00019794 File Offset: 0x00018794
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
