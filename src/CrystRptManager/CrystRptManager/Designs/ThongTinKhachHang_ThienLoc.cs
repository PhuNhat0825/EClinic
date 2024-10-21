using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;

namespace CrystRptManager.Designs
{
	// Token: 0x02000020 RID: 32
	public class ThongTinKhachHang_ThienLoc : ReportClass
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00005B30 File Offset: 0x00004B30
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00005B47 File Offset: 0x00004B47
		public override string ResourceName
		{
			get
			{
				return "ThongTinKhachHang-ThienLoc.rpt";
			}
			set
			{
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00005B4C File Offset: 0x00004B4C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00005B70 File Offset: 0x00004B70
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00005B94 File Offset: 0x00004B94
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section3
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00005BB8 File Offset: 0x00004BB8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00005BDC File Offset: 0x00004BDC
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section5
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}
	}
}
