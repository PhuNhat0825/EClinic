using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;

namespace CrystRptManager.Designs
{
	// Token: 0x02000018 RID: 24
	public class crSASK : ReportClass
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00004FBC File Offset: 0x00003FBC
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00004FD3 File Offset: 0x00003FD3
		public override string ResourceName
		{
			get
			{
				return "crSASK.rpt";
			}
			set
			{
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00004FD8 File Offset: 0x00003FD8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00004FFC File Offset: 0x00003FFC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00005020 File Offset: 0x00004020
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section3
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00005044 File Offset: 0x00004044
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00005068 File Offset: 0x00004068
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
