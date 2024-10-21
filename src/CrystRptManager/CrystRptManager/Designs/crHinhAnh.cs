using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;

namespace CrystRptManager.Designs
{
	// Token: 0x0200001C RID: 28
	public class crHinhAnh : ReportClass
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00005308 File Offset: 0x00004308
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000531F File Offset: 0x0000431F
		public override string ResourceName
		{
			get
			{
				return "crHinhAnh.rpt";
			}
			set
			{
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00005324 File Offset: 0x00004324
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00005348 File Offset: 0x00004348
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000536C File Offset: 0x0000436C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section3
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00005390 File Offset: 0x00004390
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000053B4 File Offset: 0x000043B4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section5
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}
	}
}
