using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CrystRptManager.DataSets
{
	// Token: 0x02000036 RID: 54
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[HelpKeyword("vs.data.DataSet")]
	[ToolboxItem(true)]
	[XmlRoot("dsKetQuaSA")]
	[DesignerCategory("code")]
	[Serializable]
	public class dsKetQuaSA : DataSet
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x0000730C File Offset: 0x0000630C
		[DebuggerNonUserCode]
		public dsKetQuaSA()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00007368 File Offset: 0x00006368
		[DebuggerNonUserCode]
		protected dsKetQuaSA(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			if (base.IsBinarySerialized(info, context))
			{
				this.InitVars(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
			}
			else
			{
				string s = (string)info.GetValue("XmlSchema", typeof(string));
				if (base.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
				{
					DataSet dataSet = new DataSet();
					dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
					if (dataSet.Tables["SAKHAC"] != null)
					{
						base.Tables.Add(new dsKetQuaSA.SAKHACDataTable(dataSet.Tables["SAKHAC"]));
					}
					if (dataSet.Tables["SASK"] != null)
					{
						base.Tables.Add(new dsKetQuaSA.SASKDataTable(dataSet.Tables["SASK"]));
					}
					if (dataSet.Tables["SATG"] != null)
					{
						base.Tables.Add(new dsKetQuaSA.SATGDataTable(dataSet.Tables["SATG"]));
					}
					if (dataSet.Tables["SATV"] != null)
					{
						base.Tables.Add(new dsKetQuaSA.SATVDataTable(dataSet.Tables["SATV"]));
					}
					if (dataSet.Tables["SATQ"] != null)
					{
						base.Tables.Add(new dsKetQuaSA.SATQDataTable(dataSet.Tables["SATQ"]));
					}
					if (dataSet.Tables["SATIM"] != null)
					{
						base.Tables.Add(new dsKetQuaSA.SATIMDataTable(dataSet.Tables["SATIM"]));
					}
					if (dataSet.Tables["Images"] != null)
					{
						base.Tables.Add(new dsKetQuaSA.ImagesDataTable(dataSet.Tables["Images"]));
					}
					base.DataSetName = dataSet.DataSetName;
					base.Prefix = dataSet.Prefix;
					base.Namespace = dataSet.Namespace;
					base.Locale = dataSet.Locale;
					base.CaseSensitive = dataSet.CaseSensitive;
					base.EnforceConstraints = dataSet.EnforceConstraints;
					base.Merge(dataSet, false, MissingSchemaAction.Add);
					this.InitVars();
				}
				else
				{
					base.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				}
				base.GetSerializationData(info, context);
				CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.SchemaChanged);
				base.Tables.CollectionChanged += value2;
				this.Relations.CollectionChanged += value2;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00007664 File Offset: 0x00006664
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		public dsKetQuaSA.SAKHACDataTable SAKHAC
		{
			get
			{
				return this.tableSAKHAC;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000767C File Offset: 0x0000667C
		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public dsKetQuaSA.SASKDataTable SASK
		{
			get
			{
				return this.tableSASK;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00007694 File Offset: 0x00006694
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		public dsKetQuaSA.SATGDataTable SATG
		{
			get
			{
				return this.tableSATG;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x000076AC File Offset: 0x000066AC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public dsKetQuaSA.SATVDataTable SATV
		{
			get
			{
				return this.tableSATV;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x000076C4 File Offset: 0x000066C4
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		public dsKetQuaSA.SATQDataTable SATQ
		{
			get
			{
				return this.tableSATQ;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x000076DC File Offset: 0x000066DC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public dsKetQuaSA.SATIMDataTable SATIM
		{
			get
			{
				return this.tableSATIM;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000076F4 File Offset: 0x000066F4
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		public dsKetQuaSA.ImagesDataTable Images
		{
			get
			{
				return this.tableImages;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000770C File Offset: 0x0000670C
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00007724 File Offset: 0x00006724
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Browsable(true)]
		[DebuggerNonUserCode]
		public override SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this._schemaSerializationMode;
			}
			set
			{
				this._schemaSerializationMode = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00007730 File Offset: 0x00006730
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DebuggerNonUserCode]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00007748 File Offset: 0x00006748
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DebuggerNonUserCode]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00007760 File Offset: 0x00006760
		[DebuggerNonUserCode]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00007778 File Offset: 0x00006778
		[DebuggerNonUserCode]
		public override DataSet Clone()
		{
			dsKetQuaSA dsKetQuaSA = (dsKetQuaSA)base.Clone();
			dsKetQuaSA.InitVars();
			dsKetQuaSA.SchemaSerializationMode = this.SchemaSerializationMode;
			return dsKetQuaSA;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000077AC File Offset: 0x000067AC
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000077C0 File Offset: 0x000067C0
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000077D4 File Offset: 0x000067D4
		[DebuggerNonUserCode]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["SAKHAC"] != null)
				{
					base.Tables.Add(new dsKetQuaSA.SAKHACDataTable(dataSet.Tables["SAKHAC"]));
				}
				if (dataSet.Tables["SASK"] != null)
				{
					base.Tables.Add(new dsKetQuaSA.SASKDataTable(dataSet.Tables["SASK"]));
				}
				if (dataSet.Tables["SATG"] != null)
				{
					base.Tables.Add(new dsKetQuaSA.SATGDataTable(dataSet.Tables["SATG"]));
				}
				if (dataSet.Tables["SATV"] != null)
				{
					base.Tables.Add(new dsKetQuaSA.SATVDataTable(dataSet.Tables["SATV"]));
				}
				if (dataSet.Tables["SATQ"] != null)
				{
					base.Tables.Add(new dsKetQuaSA.SATQDataTable(dataSet.Tables["SATQ"]));
				}
				if (dataSet.Tables["SATIM"] != null)
				{
					base.Tables.Add(new dsKetQuaSA.SATIMDataTable(dataSet.Tables["SATIM"]));
				}
				if (dataSet.Tables["Images"] != null)
				{
					base.Tables.Add(new dsKetQuaSA.ImagesDataTable(dataSet.Tables["Images"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				base.ReadXml(reader);
				this.InitVars();
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00007A18 File Offset: 0x00006A18
		[DebuggerNonUserCode]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00007A53 File Offset: 0x00006A53
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00007A60 File Offset: 0x00006A60
		[DebuggerNonUserCode]
		internal void InitVars(bool initTable)
		{
			this.tableSAKHAC = (dsKetQuaSA.SAKHACDataTable)base.Tables["SAKHAC"];
			if (initTable)
			{
				if (this.tableSAKHAC != null)
				{
					this.tableSAKHAC.InitVars();
				}
			}
			this.tableSASK = (dsKetQuaSA.SASKDataTable)base.Tables["SASK"];
			if (initTable)
			{
				if (this.tableSASK != null)
				{
					this.tableSASK.InitVars();
				}
			}
			this.tableSATG = (dsKetQuaSA.SATGDataTable)base.Tables["SATG"];
			if (initTable)
			{
				if (this.tableSATG != null)
				{
					this.tableSATG.InitVars();
				}
			}
			this.tableSATV = (dsKetQuaSA.SATVDataTable)base.Tables["SATV"];
			if (initTable)
			{
				if (this.tableSATV != null)
				{
					this.tableSATV.InitVars();
				}
			}
			this.tableSATQ = (dsKetQuaSA.SATQDataTable)base.Tables["SATQ"];
			if (initTable)
			{
				if (this.tableSATQ != null)
				{
					this.tableSATQ.InitVars();
				}
			}
			this.tableSATIM = (dsKetQuaSA.SATIMDataTable)base.Tables["SATIM"];
			if (initTable)
			{
				if (this.tableSATIM != null)
				{
					this.tableSATIM.InitVars();
				}
			}
			this.tableImages = (dsKetQuaSA.ImagesDataTable)base.Tables["Images"];
			if (initTable)
			{
				if (this.tableImages != null)
				{
					this.tableImages.InitVars();
				}
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00007C30 File Offset: 0x00006C30
		[DebuggerNonUserCode]
		private void InitClass()
		{
			base.DataSetName = "dsKetQuaSA";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/dsKetQuaSA.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSAKHAC = new dsKetQuaSA.SAKHACDataTable();
			base.Tables.Add(this.tableSAKHAC);
			this.tableSASK = new dsKetQuaSA.SASKDataTable();
			base.Tables.Add(this.tableSASK);
			this.tableSATG = new dsKetQuaSA.SATGDataTable();
			base.Tables.Add(this.tableSATG);
			this.tableSATV = new dsKetQuaSA.SATVDataTable();
			base.Tables.Add(this.tableSATV);
			this.tableSATQ = new dsKetQuaSA.SATQDataTable();
			base.Tables.Add(this.tableSATQ);
			this.tableSATIM = new dsKetQuaSA.SATIMDataTable();
			base.Tables.Add(this.tableSATIM);
			this.tableImages = new dsKetQuaSA.ImagesDataTable();
			base.Tables.Add(this.tableImages);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00007D40 File Offset: 0x00006D40
		[DebuggerNonUserCode]
		private bool ShouldSerializeSAKHAC()
		{
			return false;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00007D54 File Offset: 0x00006D54
		[DebuggerNonUserCode]
		private bool ShouldSerializeSASK()
		{
			return false;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00007D68 File Offset: 0x00006D68
		[DebuggerNonUserCode]
		private bool ShouldSerializeSATG()
		{
			return false;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00007D7C File Offset: 0x00006D7C
		[DebuggerNonUserCode]
		private bool ShouldSerializeSATV()
		{
			return false;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00007D90 File Offset: 0x00006D90
		[DebuggerNonUserCode]
		private bool ShouldSerializeSATQ()
		{
			return false;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00007DA4 File Offset: 0x00006DA4
		[DebuggerNonUserCode]
		private bool ShouldSerializeSATIM()
		{
			return false;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00007DB8 File Offset: 0x00006DB8
		[DebuggerNonUserCode]
		private bool ShouldSerializeImages()
		{
			return false;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00007DCC File Offset: 0x00006DCC
		[DebuggerNonUserCode]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00007DF4 File Offset: 0x00006DF4
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			dsKetQuaSA dsKetQuaSA = new dsKetQuaSA();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			xs.Add(dsKetQuaSA.GetSchemaSerializable());
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = dsKetQuaSA.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			return xmlSchemaComplexType;
		}

		// Token: 0x04000035 RID: 53
		private dsKetQuaSA.SAKHACDataTable tableSAKHAC;

		// Token: 0x04000036 RID: 54
		private dsKetQuaSA.SASKDataTable tableSASK;

		// Token: 0x04000037 RID: 55
		private dsKetQuaSA.SATGDataTable tableSATG;

		// Token: 0x04000038 RID: 56
		private dsKetQuaSA.SATVDataTable tableSATV;

		// Token: 0x04000039 RID: 57
		private dsKetQuaSA.SATQDataTable tableSATQ;

		// Token: 0x0400003A RID: 58
		private dsKetQuaSA.SATIMDataTable tableSATIM;

		// Token: 0x0400003B RID: 59
		private dsKetQuaSA.ImagesDataTable tableImages;

		// Token: 0x0400003C RID: 60
		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x06000200 RID: 512
		public delegate void SAKHACRowChangeEventHandler(object sender, dsKetQuaSA.SAKHACRowChangeEvent e);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x06000204 RID: 516
		public delegate void SASKRowChangeEventHandler(object sender, dsKetQuaSA.SASKRowChangeEvent e);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x06000208 RID: 520
		public delegate void SATGRowChangeEventHandler(object sender, dsKetQuaSA.SATGRowChangeEvent e);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x0600020C RID: 524
		public delegate void SATVRowChangeEventHandler(object sender, dsKetQuaSA.SATVRowChangeEvent e);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x06000210 RID: 528
		public delegate void SATQRowChangeEventHandler(object sender, dsKetQuaSA.SATQRowChangeEvent e);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x06000214 RID: 532
		public delegate void SATIMRowChangeEventHandler(object sender, dsKetQuaSA.SATIMRowChangeEvent e);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000218 RID: 536
		public delegate void ImagesRowChangeEventHandler(object sender, dsKetQuaSA.ImagesRowChangeEvent e);

		// Token: 0x0200003E RID: 62
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SAKHACDataTable : DataTable, IEnumerable
		{
			// Token: 0x0600021B RID: 539 RVA: 0x00007E50 File Offset: 0x00006E50
			[DebuggerNonUserCode]
			public SAKHACDataTable()
			{
				base.TableName = "SAKHAC";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x0600021C RID: 540 RVA: 0x00007E7C File Offset: 0x00006E7C
			[DebuggerNonUserCode]
			internal SAKHACDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x0600021D RID: 541 RVA: 0x00007F41 File Offset: 0x00006F41
			[DebuggerNonUserCode]
			protected SAKHACDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x0600021E RID: 542 RVA: 0x00007F58 File Offset: 0x00006F58
			[DebuggerNonUserCode]
			public DataColumn KetQua_SAKhac_IdColumn
			{
				get
				{
					return this.columnKetQua_SAKhac_Id;
				}
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x0600021F RID: 543 RVA: 0x00007F70 File Offset: 0x00006F70
			[DebuggerNonUserCode]
			public DataColumn SA_KHAC_IdColumn
			{
				get
				{
					return this.columnSA_KHAC_Id;
				}
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x06000220 RID: 544 RVA: 0x00007F88 File Offset: 0x00006F88
			[DebuggerNonUserCode]
			public DataColumn Benh_Nhan_IdColumn
			{
				get
				{
					return this.columnBenh_Nhan_Id;
				}
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x06000221 RID: 545 RVA: 0x00007FA0 File Offset: 0x00006FA0
			[DebuggerNonUserCode]
			public DataColumn Y_Te_IdColumn
			{
				get
				{
					return this.columnY_Te_Id;
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x06000222 RID: 546 RVA: 0x00007FB8 File Offset: 0x00006FB8
			[DebuggerNonUserCode]
			public DataColumn Ho_TenColumn
			{
				get
				{
					return this.columnHo_Ten;
				}
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x06000223 RID: 547 RVA: 0x00007FD0 File Offset: 0x00006FD0
			[DebuggerNonUserCode]
			public DataColumn Gioi_TinhColumn
			{
				get
				{
					return this.columnGioi_Tinh;
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x06000224 RID: 548 RVA: 0x00007FE8 File Offset: 0x00006FE8
			[DebuggerNonUserCode]
			public DataColumn Nam_SinhColumn
			{
				get
				{
					return this.columnNam_Sinh;
				}
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x06000225 RID: 549 RVA: 0x00008000 File Offset: 0x00007000
			[DebuggerNonUserCode]
			public DataColumn Dia_ChiColumn
			{
				get
				{
					return this.columnDia_Chi;
				}
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x06000226 RID: 550 RVA: 0x00008018 File Offset: 0x00007018
			[DebuggerNonUserCode]
			public DataColumn NgayColumn
			{
				get
				{
					return this.columnNgay;
				}
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x06000227 RID: 551 RVA: 0x00008030 File Offset: 0x00007030
			[DebuggerNonUserCode]
			public DataColumn Lam_sangColumn
			{
				get
				{
					return this.columnLam_sang;
				}
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x06000228 RID: 552 RVA: 0x00008048 File Offset: 0x00007048
			[DebuggerNonUserCode]
			public DataColumn Bo_phan_SAColumn
			{
				get
				{
					return this.columnBo_phan_SA;
				}
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x06000229 RID: 553 RVA: 0x00008060 File Offset: 0x00007060
			[DebuggerNonUserCode]
			public DataColumn Ton_ThuongColumn
			{
				get
				{
					return this.columnTon_Thuong;
				}
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x0600022A RID: 554 RVA: 0x00008078 File Offset: 0x00007078
			[DebuggerNonUserCode]
			public DataColumn KhacColumn
			{
				get
				{
					return this.columnKhac;
				}
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x0600022B RID: 555 RVA: 0x00008090 File Offset: 0x00007090
			[DebuggerNonUserCode]
			public DataColumn Ket_LuanColumn
			{
				get
				{
					return this.columnKet_Luan;
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x0600022C RID: 556 RVA: 0x000080A8 File Offset: 0x000070A8
			[DebuggerNonUserCode]
			public DataColumn DS_Anh_KQColumn
			{
				get
				{
					return this.columnDS_Anh_KQ;
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x0600022D RID: 557 RVA: 0x000080C0 File Offset: 0x000070C0
			[DebuggerNonUserCode]
			public DataColumn Ho_Ten_BSSAColumn
			{
				get
				{
					return this.columnHo_Ten_BSSA;
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x0600022E RID: 558 RVA: 0x000080D8 File Offset: 0x000070D8
			[DebuggerNonUserCode]
			public DataColumn Trinh_DoColumn
			{
				get
				{
					return this.columnTrinh_Do;
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x0600022F RID: 559 RVA: 0x000080F0 File Offset: 0x000070F0
			[Browsable(false)]
			[DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x1700010E RID: 270
			[DebuggerNonUserCode]
			public dsKetQuaSA.SAKHACRow this[int index]
			{
				get
				{
					return (dsKetQuaSA.SAKHACRow)base.Rows[index];
				}
			}

			// Token: 0x14000001 RID: 1
			// (add) Token: 0x06000231 RID: 561 RVA: 0x00008133 File Offset: 0x00007133
			// (remove) Token: 0x06000232 RID: 562 RVA: 0x0000814C File Offset: 0x0000714C
			public event dsKetQuaSA.SAKHACRowChangeEventHandler SAKHACRowChanging;

			// Token: 0x14000002 RID: 2
			// (add) Token: 0x06000233 RID: 563 RVA: 0x00008165 File Offset: 0x00007165
			// (remove) Token: 0x06000234 RID: 564 RVA: 0x0000817E File Offset: 0x0000717E
			public event dsKetQuaSA.SAKHACRowChangeEventHandler SAKHACRowChanged;

			// Token: 0x14000003 RID: 3
			// (add) Token: 0x06000235 RID: 565 RVA: 0x00008197 File Offset: 0x00007197
			// (remove) Token: 0x06000236 RID: 566 RVA: 0x000081B0 File Offset: 0x000071B0
			public event dsKetQuaSA.SAKHACRowChangeEventHandler SAKHACRowDeleting;

			// Token: 0x14000004 RID: 4
			// (add) Token: 0x06000237 RID: 567 RVA: 0x000081C9 File Offset: 0x000071C9
			// (remove) Token: 0x06000238 RID: 568 RVA: 0x000081E2 File Offset: 0x000071E2
			public event dsKetQuaSA.SAKHACRowChangeEventHandler SAKHACRowDeleted;

			// Token: 0x06000239 RID: 569 RVA: 0x000081FB File Offset: 0x000071FB
			[DebuggerNonUserCode]
			public void AddSAKHACRow(dsKetQuaSA.SAKHACRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x0600023A RID: 570 RVA: 0x0000820C File Offset: 0x0000720C
			[DebuggerNonUserCode]
			public dsKetQuaSA.SAKHACRow AddSAKHACRow(string KetQua_SAKhac_Id, string SA_KHAC_Id, string Benh_Nhan_Id, string Y_Te_Id, string Ho_Ten, string Gioi_Tinh, string Nam_Sinh, string Dia_Chi, string Ngay, string Lam_sang, string Bo_phan_SA, string Ton_Thuong, string Khac, string Ket_Luan, string DS_Anh_KQ, string Ho_Ten_BSSA, string Trinh_Do)
			{
				dsKetQuaSA.SAKHACRow sakhacrow = (dsKetQuaSA.SAKHACRow)base.NewRow();
				sakhacrow.ItemArray = new object[]
				{
					KetQua_SAKhac_Id,
					SA_KHAC_Id,
					Benh_Nhan_Id,
					Y_Te_Id,
					Ho_Ten,
					Gioi_Tinh,
					Nam_Sinh,
					Dia_Chi,
					Ngay,
					Lam_sang,
					Bo_phan_SA,
					Ton_Thuong,
					Khac,
					Ket_Luan,
					DS_Anh_KQ,
					Ho_Ten_BSSA,
					Trinh_Do
				};
				base.Rows.Add(sakhacrow);
				return sakhacrow;
			}

			// Token: 0x0600023B RID: 571 RVA: 0x000082A4 File Offset: 0x000072A4
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x0600023C RID: 572 RVA: 0x000082C4 File Offset: 0x000072C4
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				dsKetQuaSA.SAKHACDataTable sakhacdataTable = (dsKetQuaSA.SAKHACDataTable)base.Clone();
				sakhacdataTable.InitVars();
				return sakhacdataTable;
			}

			// Token: 0x0600023D RID: 573 RVA: 0x000082EC File Offset: 0x000072EC
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new dsKetQuaSA.SAKHACDataTable();
			}

			// Token: 0x0600023E RID: 574 RVA: 0x00008304 File Offset: 0x00007304
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnKetQua_SAKhac_Id = base.Columns["KetQua_SAKhac_Id"];
				this.columnSA_KHAC_Id = base.Columns["SA_KHAC_Id"];
				this.columnBenh_Nhan_Id = base.Columns["Benh_Nhan_Id"];
				this.columnY_Te_Id = base.Columns["Y_Te_Id"];
				this.columnHo_Ten = base.Columns["Ho_Ten"];
				this.columnGioi_Tinh = base.Columns["Gioi_Tinh"];
				this.columnNam_Sinh = base.Columns["Nam_Sinh"];
				this.columnDia_Chi = base.Columns["Dia_Chi"];
				this.columnNgay = base.Columns["Ngay"];
				this.columnLam_sang = base.Columns["Lam_sang"];
				this.columnBo_phan_SA = base.Columns["Bo_phan_SA"];
				this.columnTon_Thuong = base.Columns["Ton_Thuong"];
				this.columnKhac = base.Columns["Khac"];
				this.columnKet_Luan = base.Columns["Ket_Luan"];
				this.columnDS_Anh_KQ = base.Columns["DS_Anh_KQ"];
				this.columnHo_Ten_BSSA = base.Columns["Ho_Ten_BSSA"];
				this.columnTrinh_Do = base.Columns["Trinh_Do"];
			}

			// Token: 0x0600023F RID: 575 RVA: 0x00008488 File Offset: 0x00007488
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnKetQua_SAKhac_Id = new DataColumn("KetQua_SAKhac_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKetQua_SAKhac_Id);
				this.columnSA_KHAC_Id = new DataColumn("SA_KHAC_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSA_KHAC_Id);
				this.columnBenh_Nhan_Id = new DataColumn("Benh_Nhan_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBenh_Nhan_Id);
				this.columnY_Te_Id = new DataColumn("Y_Te_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnY_Te_Id);
				this.columnHo_Ten = new DataColumn("Ho_Ten", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHo_Ten);
				this.columnGioi_Tinh = new DataColumn("Gioi_Tinh", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGioi_Tinh);
				this.columnNam_Sinh = new DataColumn("Nam_Sinh", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNam_Sinh);
				this.columnDia_Chi = new DataColumn("Dia_Chi", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDia_Chi);
				this.columnNgay = new DataColumn("Ngay", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNgay);
				this.columnLam_sang = new DataColumn("Lam_sang", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnLam_sang);
				this.columnBo_phan_SA = new DataColumn("Bo_phan_SA", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBo_phan_SA);
				this.columnTon_Thuong = new DataColumn("Ton_Thuong", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTon_Thuong);
				this.columnKhac = new DataColumn("Khac", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKhac);
				this.columnKet_Luan = new DataColumn("Ket_Luan", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKet_Luan);
				this.columnDS_Anh_KQ = new DataColumn("DS_Anh_KQ", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDS_Anh_KQ);
				this.columnHo_Ten_BSSA = new DataColumn("Ho_Ten_BSSA", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHo_Ten_BSSA);
				this.columnTrinh_Do = new DataColumn("Trinh_Do", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTrinh_Do);
				this.columnBo_phan_SA.Caption = "Gan";
				this.columnTon_Thuong.Caption = "Mat";
			}

			// Token: 0x06000240 RID: 576 RVA: 0x000087C8 File Offset: 0x000077C8
			[DebuggerNonUserCode]
			public dsKetQuaSA.SAKHACRow NewSAKHACRow()
			{
				return (dsKetQuaSA.SAKHACRow)base.NewRow();
			}

			// Token: 0x06000241 RID: 577 RVA: 0x000087E8 File Offset: 0x000077E8
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsKetQuaSA.SAKHACRow(builder);
			}

			// Token: 0x06000242 RID: 578 RVA: 0x00008800 File Offset: 0x00007800
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(dsKetQuaSA.SAKHACRow);
			}

			// Token: 0x06000243 RID: 579 RVA: 0x0000881C File Offset: 0x0000781C
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SAKHACRowChanged != null)
				{
					this.SAKHACRowChanged(this, new dsKetQuaSA.SAKHACRowChangeEvent((dsKetQuaSA.SAKHACRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000244 RID: 580 RVA: 0x00008864 File Offset: 0x00007864
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SAKHACRowChanging != null)
				{
					this.SAKHACRowChanging(this, new dsKetQuaSA.SAKHACRowChangeEvent((dsKetQuaSA.SAKHACRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000245 RID: 581 RVA: 0x000088AC File Offset: 0x000078AC
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SAKHACRowDeleted != null)
				{
					this.SAKHACRowDeleted(this, new dsKetQuaSA.SAKHACRowChangeEvent((dsKetQuaSA.SAKHACRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000246 RID: 582 RVA: 0x000088F4 File Offset: 0x000078F4
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SAKHACRowDeleting != null)
				{
					this.SAKHACRowDeleting(this, new dsKetQuaSA.SAKHACRowChangeEvent((dsKetQuaSA.SAKHACRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000247 RID: 583 RVA: 0x0000893C File Offset: 0x0000793C
			[DebuggerNonUserCode]
			public void RemoveSAKHACRow(dsKetQuaSA.SAKHACRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000248 RID: 584 RVA: 0x0000894C File Offset: 0x0000794C
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				dsKetQuaSA dsKetQuaSA = new dsKetQuaSA();
				xs.Add(dsKetQuaSA.GetSchemaSerializable());
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dsKetQuaSA.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SAKHACDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x0400003D RID: 61
			private DataColumn columnKetQua_SAKhac_Id;

			// Token: 0x0400003E RID: 62
			private DataColumn columnSA_KHAC_Id;

			// Token: 0x0400003F RID: 63
			private DataColumn columnBenh_Nhan_Id;

			// Token: 0x04000040 RID: 64
			private DataColumn columnY_Te_Id;

			// Token: 0x04000041 RID: 65
			private DataColumn columnHo_Ten;

			// Token: 0x04000042 RID: 66
			private DataColumn columnGioi_Tinh;

			// Token: 0x04000043 RID: 67
			private DataColumn columnNam_Sinh;

			// Token: 0x04000044 RID: 68
			private DataColumn columnDia_Chi;

			// Token: 0x04000045 RID: 69
			private DataColumn columnNgay;

			// Token: 0x04000046 RID: 70
			private DataColumn columnLam_sang;

			// Token: 0x04000047 RID: 71
			private DataColumn columnBo_phan_SA;

			// Token: 0x04000048 RID: 72
			private DataColumn columnTon_Thuong;

			// Token: 0x04000049 RID: 73
			private DataColumn columnKhac;

			// Token: 0x0400004A RID: 74
			private DataColumn columnKet_Luan;

			// Token: 0x0400004B RID: 75
			private DataColumn columnDS_Anh_KQ;

			// Token: 0x0400004C RID: 76
			private DataColumn columnHo_Ten_BSSA;

			// Token: 0x0400004D RID: 77
			private DataColumn columnTrinh_Do;
		}

		// Token: 0x0200003F RID: 63
		[XmlSchemaProvider("GetTypedTableSchema")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[Serializable]
		public class SASKDataTable : DataTable, IEnumerable
		{
			// Token: 0x06000249 RID: 585 RVA: 0x00008A65 File Offset: 0x00007A65
			[DebuggerNonUserCode]
			public SASKDataTable()
			{
				base.TableName = "SASK";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x0600024A RID: 586 RVA: 0x00008A94 File Offset: 0x00007A94
			[DebuggerNonUserCode]
			internal SASKDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x0600024B RID: 587 RVA: 0x00008B59 File Offset: 0x00007B59
			[DebuggerNonUserCode]
			protected SASKDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x0600024C RID: 588 RVA: 0x00008B70 File Offset: 0x00007B70
			[DebuggerNonUserCode]
			public DataColumn KetQua_SASK_IdColumn
			{
				get
				{
					return this.columnKetQua_SASK_Id;
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x0600024D RID: 589 RVA: 0x00008B88 File Offset: 0x00007B88
			[DebuggerNonUserCode]
			public DataColumn SA_SK_IdColumn
			{
				get
				{
					return this.columnSA_SK_Id;
				}
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x0600024E RID: 590 RVA: 0x00008BA0 File Offset: 0x00007BA0
			[DebuggerNonUserCode]
			public DataColumn Benh_Nhan_IdColumn
			{
				get
				{
					return this.columnBenh_Nhan_Id;
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x0600024F RID: 591 RVA: 0x00008BB8 File Offset: 0x00007BB8
			[DebuggerNonUserCode]
			public DataColumn Y_Te_IdColumn
			{
				get
				{
					return this.columnY_Te_Id;
				}
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x06000250 RID: 592 RVA: 0x00008BD0 File Offset: 0x00007BD0
			[DebuggerNonUserCode]
			public DataColumn Ho_TenColumn
			{
				get
				{
					return this.columnHo_Ten;
				}
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x06000251 RID: 593 RVA: 0x00008BE8 File Offset: 0x00007BE8
			[DebuggerNonUserCode]
			public DataColumn Gioi_TinhColumn
			{
				get
				{
					return this.columnGioi_Tinh;
				}
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x06000252 RID: 594 RVA: 0x00008C00 File Offset: 0x00007C00
			[DebuggerNonUserCode]
			public DataColumn Nam_SinhColumn
			{
				get
				{
					return this.columnNam_Sinh;
				}
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x06000253 RID: 595 RVA: 0x00008C18 File Offset: 0x00007C18
			[DebuggerNonUserCode]
			public DataColumn Dia_ChiColumn
			{
				get
				{
					return this.columnDia_Chi;
				}
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000254 RID: 596 RVA: 0x00008C30 File Offset: 0x00007C30
			[DebuggerNonUserCode]
			public DataColumn NgayColumn
			{
				get
				{
					return this.columnNgay;
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000255 RID: 597 RVA: 0x00008C48 File Offset: 0x00007C48
			[DebuggerNonUserCode]
			public DataColumn Lam_sangColumn
			{
				get
				{
					return this.columnLam_sang;
				}
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000256 RID: 598 RVA: 0x00008C60 File Offset: 0x00007C60
			[DebuggerNonUserCode]
			public DataColumn So_LuongColumn
			{
				get
				{
					return this.columnSo_Luong;
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x06000257 RID: 599 RVA: 0x00008C78 File Offset: 0x00007C78
			[DebuggerNonUserCode]
			public DataColumn Tan_So_TimColumn
			{
				get
				{
					return this.columnTan_So_Tim;
				}
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x06000258 RID: 600 RVA: 0x00008C90 File Offset: 0x00007C90
			[DebuggerNonUserCode]
			public DataColumn Cu_DongColumn
			{
				get
				{
					return this.columnCu_Dong;
				}
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x06000259 RID: 601 RVA: 0x00008CA8 File Offset: 0x00007CA8
			[DebuggerNonUserCode]
			public DataColumn NgoiColumn
			{
				get
				{
					return this.columnNgoi;
				}
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x0600025A RID: 602 RVA: 0x00008CC0 File Offset: 0x00007CC0
			[DebuggerNonUserCode]
			public DataColumn GSColumn
			{
				get
				{
					return this.columnGS;
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x0600025B RID: 603 RVA: 0x00008CD8 File Offset: 0x00007CD8
			[DebuggerNonUserCode]
			public DataColumn CRLColumn
			{
				get
				{
					return this.columnCRL;
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x0600025C RID: 604 RVA: 0x00008CF0 File Offset: 0x00007CF0
			[DebuggerNonUserCode]
			public DataColumn BDPColumn
			{
				get
				{
					return this.columnBDP;
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x0600025D RID: 605 RVA: 0x00008D08 File Offset: 0x00007D08
			[DebuggerNonUserCode]
			public DataColumn FLColumn
			{
				get
				{
					return this.columnFL;
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x0600025E RID: 606 RVA: 0x00008D20 File Offset: 0x00007D20
			[DebuggerNonUserCode]
			public DataColumn APBDColumn
			{
				get
				{
					return this.columnAPBD;
				}
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x0600025F RID: 607 RVA: 0x00008D38 File Offset: 0x00007D38
			[DebuggerNonUserCode]
			public DataColumn TBDColumn
			{
				get
				{
					return this.columnTBD;
				}
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x06000260 RID: 608 RVA: 0x00008D50 File Offset: 0x00007D50
			[DebuggerNonUserCode]
			public DataColumn CanNangColumn
			{
				get
				{
					return this.columnCanNang;
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000261 RID: 609 RVA: 0x00008D68 File Offset: 0x00007D68
			[DebuggerNonUserCode]
			public DataColumn Di_TatColumn
			{
				get
				{
					return this.columnDi_Tat;
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000262 RID: 610 RVA: 0x00008D80 File Offset: 0x00007D80
			[DebuggerNonUserCode]
			public DataColumn OiColumn
			{
				get
				{
					return this.columnOi;
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x06000263 RID: 611 RVA: 0x00008D98 File Offset: 0x00007D98
			[DebuggerNonUserCode]
			public DataColumn RonColumn
			{
				get
				{
					return this.columnRon;
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x06000264 RID: 612 RVA: 0x00008DB0 File Offset: 0x00007DB0
			[DebuggerNonUserCode]
			public DataColumn Do_NhauColumn
			{
				get
				{
					return this.columnDo_Nhau;
				}
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000265 RID: 613 RVA: 0x00008DC8 File Offset: 0x00007DC8
			[DebuggerNonUserCode]
			public DataColumn Vi_Tri_NhauColumn
			{
				get
				{
					return this.columnVi_Tri_Nhau;
				}
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000266 RID: 614 RVA: 0x00008DE0 File Offset: 0x00007DE0
			[DebuggerNonUserCode]
			public DataColumn KhacColumn
			{
				get
				{
					return this.columnKhac;
				}
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000267 RID: 615 RVA: 0x00008DF8 File Offset: 0x00007DF8
			[DebuggerNonUserCode]
			public DataColumn Ket_LuanColumn
			{
				get
				{
					return this.columnKet_Luan;
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x06000268 RID: 616 RVA: 0x00008E10 File Offset: 0x00007E10
			[DebuggerNonUserCode]
			public DataColumn DS_Anh_KQColumn
			{
				get
				{
					return this.columnDS_Anh_KQ;
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x06000269 RID: 617 RVA: 0x00008E28 File Offset: 0x00007E28
			[DebuggerNonUserCode]
			public DataColumn Ho_Ten_BSSAColumn
			{
				get
				{
					return this.columnHo_Ten_BSSA;
				}
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x0600026A RID: 618 RVA: 0x00008E40 File Offset: 0x00007E40
			[DebuggerNonUserCode]
			public DataColumn Trinh_DoColumn
			{
				get
				{
					return this.columnTrinh_Do;
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x0600026B RID: 619 RVA: 0x00008E58 File Offset: 0x00007E58
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x1700012F RID: 303
			[DebuggerNonUserCode]
			public dsKetQuaSA.SASKRow this[int index]
			{
				get
				{
					return (dsKetQuaSA.SASKRow)base.Rows[index];
				}
			}

			// Token: 0x14000005 RID: 5
			// (add) Token: 0x0600026D RID: 621 RVA: 0x00008E9B File Offset: 0x00007E9B
			// (remove) Token: 0x0600026E RID: 622 RVA: 0x00008EB4 File Offset: 0x00007EB4
			public event dsKetQuaSA.SASKRowChangeEventHandler SASKRowChanging;

			// Token: 0x14000006 RID: 6
			// (add) Token: 0x0600026F RID: 623 RVA: 0x00008ECD File Offset: 0x00007ECD
			// (remove) Token: 0x06000270 RID: 624 RVA: 0x00008EE6 File Offset: 0x00007EE6
			public event dsKetQuaSA.SASKRowChangeEventHandler SASKRowChanged;

			// Token: 0x14000007 RID: 7
			// (add) Token: 0x06000271 RID: 625 RVA: 0x00008EFF File Offset: 0x00007EFF
			// (remove) Token: 0x06000272 RID: 626 RVA: 0x00008F18 File Offset: 0x00007F18
			public event dsKetQuaSA.SASKRowChangeEventHandler SASKRowDeleting;

			// Token: 0x14000008 RID: 8
			// (add) Token: 0x06000273 RID: 627 RVA: 0x00008F31 File Offset: 0x00007F31
			// (remove) Token: 0x06000274 RID: 628 RVA: 0x00008F4A File Offset: 0x00007F4A
			public event dsKetQuaSA.SASKRowChangeEventHandler SASKRowDeleted;

			// Token: 0x06000275 RID: 629 RVA: 0x00008F63 File Offset: 0x00007F63
			[DebuggerNonUserCode]
			public void AddSASKRow(dsKetQuaSA.SASKRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x06000276 RID: 630 RVA: 0x00008F74 File Offset: 0x00007F74
			[DebuggerNonUserCode]
			public dsKetQuaSA.SASKRow AddSASKRow(string KetQua_SASK_Id, string SA_SK_Id, string Benh_Nhan_Id, string Y_Te_Id, string Ho_Ten, string Gioi_Tinh, string Nam_Sinh, string Dia_Chi, string Ngay, string Lam_sang, string So_Luong, string Tan_So_Tim, string Cu_Dong, string Ngoi, string GS, string CRL, string BDP, string FL, string APBD, string TBD, string CanNang, string Di_Tat, string Oi, string Ron, string Do_Nhau, string Vi_Tri_Nhau, string Khac, string Ket_Luan, string DS_Anh_KQ, string Ho_Ten_BSSA, string Trinh_Do)
			{
				dsKetQuaSA.SASKRow saskrow = (dsKetQuaSA.SASKRow)base.NewRow();
				saskrow.ItemArray = new object[]
				{
					KetQua_SASK_Id,
					SA_SK_Id,
					Benh_Nhan_Id,
					Y_Te_Id,
					Ho_Ten,
					Gioi_Tinh,
					Nam_Sinh,
					Dia_Chi,
					Ngay,
					Lam_sang,
					So_Luong,
					Tan_So_Tim,
					Cu_Dong,
					Ngoi,
					GS,
					CRL,
					BDP,
					FL,
					APBD,
					TBD,
					CanNang,
					Di_Tat,
					Oi,
					Ron,
					Do_Nhau,
					Vi_Tri_Nhau,
					Khac,
					Ket_Luan,
					DS_Anh_KQ,
					Ho_Ten_BSSA,
					Trinh_Do
				};
				base.Rows.Add(saskrow);
				return saskrow;
			}

			// Token: 0x06000277 RID: 631 RVA: 0x00009060 File Offset: 0x00008060
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x06000278 RID: 632 RVA: 0x00009080 File Offset: 0x00008080
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				dsKetQuaSA.SASKDataTable saskdataTable = (dsKetQuaSA.SASKDataTable)base.Clone();
				saskdataTable.InitVars();
				return saskdataTable;
			}

			// Token: 0x06000279 RID: 633 RVA: 0x000090A8 File Offset: 0x000080A8
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new dsKetQuaSA.SASKDataTable();
			}

			// Token: 0x0600027A RID: 634 RVA: 0x000090C0 File Offset: 0x000080C0
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnKetQua_SASK_Id = base.Columns["KetQua_SASK_Id"];
				this.columnSA_SK_Id = base.Columns["SA_SK_Id"];
				this.columnBenh_Nhan_Id = base.Columns["Benh_Nhan_Id"];
				this.columnY_Te_Id = base.Columns["Y_Te_Id"];
				this.columnHo_Ten = base.Columns["Ho_Ten"];
				this.columnGioi_Tinh = base.Columns["Gioi_Tinh"];
				this.columnNam_Sinh = base.Columns["Nam_Sinh"];
				this.columnDia_Chi = base.Columns["Dia_Chi"];
				this.columnNgay = base.Columns["Ngay"];
				this.columnLam_sang = base.Columns["Lam_sang"];
				this.columnSo_Luong = base.Columns["So_Luong"];
				this.columnTan_So_Tim = base.Columns["Tan_So_Tim"];
				this.columnCu_Dong = base.Columns["Cu_Dong"];
				this.columnNgoi = base.Columns["Ngoi"];
				this.columnGS = base.Columns["GS"];
				this.columnCRL = base.Columns["CRL"];
				this.columnBDP = base.Columns["BDP"];
				this.columnFL = base.Columns["FL"];
				this.columnAPBD = base.Columns["APBD"];
				this.columnTBD = base.Columns["TBD"];
				this.columnCanNang = base.Columns["CanNang"];
				this.columnDi_Tat = base.Columns["Di_Tat"];
				this.columnOi = base.Columns["Oi"];
				this.columnRon = base.Columns["Ron"];
				this.columnDo_Nhau = base.Columns["Do_Nhau"];
				this.columnVi_Tri_Nhau = base.Columns["Vi_Tri_Nhau"];
				this.columnKhac = base.Columns["Khac"];
				this.columnKet_Luan = base.Columns["Ket_Luan"];
				this.columnDS_Anh_KQ = base.Columns["DS_Anh_KQ"];
				this.columnHo_Ten_BSSA = base.Columns["Ho_Ten_BSSA"];
				this.columnTrinh_Do = base.Columns["Trinh_Do"];
			}

			// Token: 0x0600027B RID: 635 RVA: 0x00009378 File Offset: 0x00008378
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnKetQua_SASK_Id = new DataColumn("KetQua_SASK_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKetQua_SASK_Id);
				this.columnSA_SK_Id = new DataColumn("SA_SK_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSA_SK_Id);
				this.columnBenh_Nhan_Id = new DataColumn("Benh_Nhan_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBenh_Nhan_Id);
				this.columnY_Te_Id = new DataColumn("Y_Te_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnY_Te_Id);
				this.columnHo_Ten = new DataColumn("Ho_Ten", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHo_Ten);
				this.columnGioi_Tinh = new DataColumn("Gioi_Tinh", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGioi_Tinh);
				this.columnNam_Sinh = new DataColumn("Nam_Sinh", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNam_Sinh);
				this.columnDia_Chi = new DataColumn("Dia_Chi", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDia_Chi);
				this.columnNgay = new DataColumn("Ngay", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNgay);
				this.columnLam_sang = new DataColumn("Lam_sang", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnLam_sang);
				this.columnSo_Luong = new DataColumn("So_Luong", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSo_Luong);
				this.columnTan_So_Tim = new DataColumn("Tan_So_Tim", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTan_So_Tim);
				this.columnCu_Dong = new DataColumn("Cu_Dong", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCu_Dong);
				this.columnNgoi = new DataColumn("Ngoi", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNgoi);
				this.columnGS = new DataColumn("GS", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGS);
				this.columnCRL = new DataColumn("CRL", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCRL);
				this.columnBDP = new DataColumn("BDP", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBDP);
				this.columnFL = new DataColumn("FL", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnFL);
				this.columnAPBD = new DataColumn("APBD", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAPBD);
				this.columnTBD = new DataColumn("TBD", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTBD);
				this.columnCanNang = new DataColumn("CanNang", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCanNang);
				this.columnDi_Tat = new DataColumn("Di_Tat", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDi_Tat);
				this.columnOi = new DataColumn("Oi", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOi);
				this.columnRon = new DataColumn("Ron", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRon);
				this.columnDo_Nhau = new DataColumn("Do_Nhau", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDo_Nhau);
				this.columnVi_Tri_Nhau = new DataColumn("Vi_Tri_Nhau", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnVi_Tri_Nhau);
				this.columnKhac = new DataColumn("Khac", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKhac);
				this.columnKet_Luan = new DataColumn("Ket_Luan", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKet_Luan);
				this.columnDS_Anh_KQ = new DataColumn("DS_Anh_KQ", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDS_Anh_KQ);
				this.columnHo_Ten_BSSA = new DataColumn("Ho_Ten_BSSA", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHo_Ten_BSSA);
				this.columnTrinh_Do = new DataColumn("Trinh_Do", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTrinh_Do);
				this.columnSo_Luong.Caption = "Gan";
				this.columnTan_So_Tim.Caption = "Mat";
				this.columnCu_Dong.Caption = "Lach";
				this.columnNgoi.Caption = "Tuy";
				this.columnGS.Caption = "ThanP";
				this.columnCRL.Caption = "ThanT";
				this.columnBDP.Caption = "DMCBung";
				this.columnFL.Caption = "TLT";
				this.columnAPBD.Caption = "Bang_Quang";
				this.columnTBD.Caption = "Tu_Cung";
				this.columnDi_Tat.Caption = "Buong_Trung";
				this.columnOi.Caption = "Tui_Cung";
				this.columnRon.Caption = "Khac";
				this.columnDo_Nhau.Caption = "Ket_Luan";
				this.columnVi_Tri_Nhau.Caption = "DS_Anh_KQ";
				this.columnKhac.Caption = "Ho_Ten_BSSA";
				this.columnKet_Luan.Caption = "Trinh_Do";
			}

			// Token: 0x0600027C RID: 636 RVA: 0x00009A3C File Offset: 0x00008A3C
			[DebuggerNonUserCode]
			public dsKetQuaSA.SASKRow NewSASKRow()
			{
				return (dsKetQuaSA.SASKRow)base.NewRow();
			}

			// Token: 0x0600027D RID: 637 RVA: 0x00009A5C File Offset: 0x00008A5C
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsKetQuaSA.SASKRow(builder);
			}

			// Token: 0x0600027E RID: 638 RVA: 0x00009A74 File Offset: 0x00008A74
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(dsKetQuaSA.SASKRow);
			}

			// Token: 0x0600027F RID: 639 RVA: 0x00009A90 File Offset: 0x00008A90
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SASKRowChanged != null)
				{
					this.SASKRowChanged(this, new dsKetQuaSA.SASKRowChangeEvent((dsKetQuaSA.SASKRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000280 RID: 640 RVA: 0x00009AD8 File Offset: 0x00008AD8
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SASKRowChanging != null)
				{
					this.SASKRowChanging(this, new dsKetQuaSA.SASKRowChangeEvent((dsKetQuaSA.SASKRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000281 RID: 641 RVA: 0x00009B20 File Offset: 0x00008B20
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SASKRowDeleted != null)
				{
					this.SASKRowDeleted(this, new dsKetQuaSA.SASKRowChangeEvent((dsKetQuaSA.SASKRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000282 RID: 642 RVA: 0x00009B68 File Offset: 0x00008B68
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SASKRowDeleting != null)
				{
					this.SASKRowDeleting(this, new dsKetQuaSA.SASKRowChangeEvent((dsKetQuaSA.SASKRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000283 RID: 643 RVA: 0x00009BB0 File Offset: 0x00008BB0
			[DebuggerNonUserCode]
			public void RemoveSASKRow(dsKetQuaSA.SASKRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000284 RID: 644 RVA: 0x00009BC0 File Offset: 0x00008BC0
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				dsKetQuaSA dsKetQuaSA = new dsKetQuaSA();
				xs.Add(dsKetQuaSA.GetSchemaSerializable());
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dsKetQuaSA.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SASKDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x04000052 RID: 82
			private DataColumn columnKetQua_SASK_Id;

			// Token: 0x04000053 RID: 83
			private DataColumn columnSA_SK_Id;

			// Token: 0x04000054 RID: 84
			private DataColumn columnBenh_Nhan_Id;

			// Token: 0x04000055 RID: 85
			private DataColumn columnY_Te_Id;

			// Token: 0x04000056 RID: 86
			private DataColumn columnHo_Ten;

			// Token: 0x04000057 RID: 87
			private DataColumn columnGioi_Tinh;

			// Token: 0x04000058 RID: 88
			private DataColumn columnNam_Sinh;

			// Token: 0x04000059 RID: 89
			private DataColumn columnDia_Chi;

			// Token: 0x0400005A RID: 90
			private DataColumn columnNgay;

			// Token: 0x0400005B RID: 91
			private DataColumn columnLam_sang;

			// Token: 0x0400005C RID: 92
			private DataColumn columnSo_Luong;

			// Token: 0x0400005D RID: 93
			private DataColumn columnTan_So_Tim;

			// Token: 0x0400005E RID: 94
			private DataColumn columnCu_Dong;

			// Token: 0x0400005F RID: 95
			private DataColumn columnNgoi;

			// Token: 0x04000060 RID: 96
			private DataColumn columnGS;

			// Token: 0x04000061 RID: 97
			private DataColumn columnCRL;

			// Token: 0x04000062 RID: 98
			private DataColumn columnBDP;

			// Token: 0x04000063 RID: 99
			private DataColumn columnFL;

			// Token: 0x04000064 RID: 100
			private DataColumn columnAPBD;

			// Token: 0x04000065 RID: 101
			private DataColumn columnTBD;

			// Token: 0x04000066 RID: 102
			private DataColumn columnCanNang;

			// Token: 0x04000067 RID: 103
			private DataColumn columnDi_Tat;

			// Token: 0x04000068 RID: 104
			private DataColumn columnOi;

			// Token: 0x04000069 RID: 105
			private DataColumn columnRon;

			// Token: 0x0400006A RID: 106
			private DataColumn columnDo_Nhau;

			// Token: 0x0400006B RID: 107
			private DataColumn columnVi_Tri_Nhau;

			// Token: 0x0400006C RID: 108
			private DataColumn columnKhac;

			// Token: 0x0400006D RID: 109
			private DataColumn columnKet_Luan;

			// Token: 0x0400006E RID: 110
			private DataColumn columnDS_Anh_KQ;

			// Token: 0x0400006F RID: 111
			private DataColumn columnHo_Ten_BSSA;

			// Token: 0x04000070 RID: 112
			private DataColumn columnTrinh_Do;
		}

		// Token: 0x02000040 RID: 64
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SATGDataTable : DataTable, IEnumerable
		{
			// Token: 0x06000285 RID: 645 RVA: 0x00009CD9 File Offset: 0x00008CD9
			[DebuggerNonUserCode]
			public SATGDataTable()
			{
				base.TableName = "SATG";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000286 RID: 646 RVA: 0x00009D08 File Offset: 0x00008D08
			[DebuggerNonUserCode]
			internal SATGDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x06000287 RID: 647 RVA: 0x00009DCD File Offset: 0x00008DCD
			[DebuggerNonUserCode]
			protected SATGDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x06000288 RID: 648 RVA: 0x00009DE4 File Offset: 0x00008DE4
			[DebuggerNonUserCode]
			public DataColumn KetQua_SATG_IdColumn
			{
				get
				{
					return this.columnKetQua_SATG_Id;
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x06000289 RID: 649 RVA: 0x00009DFC File Offset: 0x00008DFC
			[DebuggerNonUserCode]
			public DataColumn SA_TG_IdColumn
			{
				get
				{
					return this.columnSA_TG_Id;
				}
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x0600028A RID: 650 RVA: 0x00009E14 File Offset: 0x00008E14
			[DebuggerNonUserCode]
			public DataColumn Benh_Nhan_IdColumn
			{
				get
				{
					return this.columnBenh_Nhan_Id;
				}
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x0600028B RID: 651 RVA: 0x00009E2C File Offset: 0x00008E2C
			[DebuggerNonUserCode]
			public DataColumn Y_Te_IdColumn
			{
				get
				{
					return this.columnY_Te_Id;
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x0600028C RID: 652 RVA: 0x00009E44 File Offset: 0x00008E44
			[DebuggerNonUserCode]
			public DataColumn Ho_TenColumn
			{
				get
				{
					return this.columnHo_Ten;
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x0600028D RID: 653 RVA: 0x00009E5C File Offset: 0x00008E5C
			[DebuggerNonUserCode]
			public DataColumn Gioi_TinhColumn
			{
				get
				{
					return this.columnGioi_Tinh;
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x0600028E RID: 654 RVA: 0x00009E74 File Offset: 0x00008E74
			[DebuggerNonUserCode]
			public DataColumn Nam_SinhColumn
			{
				get
				{
					return this.columnNam_Sinh;
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x0600028F RID: 655 RVA: 0x00009E8C File Offset: 0x00008E8C
			[DebuggerNonUserCode]
			public DataColumn Dia_ChiColumn
			{
				get
				{
					return this.columnDia_Chi;
				}
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x06000290 RID: 656 RVA: 0x00009EA4 File Offset: 0x00008EA4
			[DebuggerNonUserCode]
			public DataColumn NgayColumn
			{
				get
				{
					return this.columnNgay;
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x06000291 RID: 657 RVA: 0x00009EBC File Offset: 0x00008EBC
			[DebuggerNonUserCode]
			public DataColumn Lam_sangColumn
			{
				get
				{
					return this.columnLam_sang;
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000292 RID: 658 RVA: 0x00009ED4 File Offset: 0x00008ED4
			[DebuggerNonUserCode]
			public DataColumn EoColumn
			{
				get
				{
					return this.columnEo;
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x06000293 RID: 659 RVA: 0x00009EEC File Offset: 0x00008EEC
			[DebuggerNonUserCode]
			public DataColumn Dai_PColumn
			{
				get
				{
					return this.columnDai_P;
				}
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x06000294 RID: 660 RVA: 0x00009F04 File Offset: 0x00008F04
			[DebuggerNonUserCode]
			public DataColumn Rong_PColumn
			{
				get
				{
					return this.columnRong_P;
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x06000295 RID: 661 RVA: 0x00009F1C File Offset: 0x00008F1C
			[DebuggerNonUserCode]
			public DataColumn Day_PColumn
			{
				get
				{
					return this.columnDay_P;
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x06000296 RID: 662 RVA: 0x00009F34 File Offset: 0x00008F34
			[DebuggerNonUserCode]
			public DataColumn Dai_TColumn
			{
				get
				{
					return this.columnDai_T;
				}
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x06000297 RID: 663 RVA: 0x00009F4C File Offset: 0x00008F4C
			[DebuggerNonUserCode]
			public DataColumn Rong_TColumn
			{
				get
				{
					return this.columnRong_T;
				}
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x06000298 RID: 664 RVA: 0x00009F64 File Offset: 0x00008F64
			[DebuggerNonUserCode]
			public DataColumn Day_TColumn
			{
				get
				{
					return this.columnDay_T;
				}
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x06000299 RID: 665 RVA: 0x00009F7C File Offset: 0x00008F7C
			[DebuggerNonUserCode]
			public DataColumn Ton_ThuongColumn
			{
				get
				{
					return this.columnTon_Thuong;
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x0600029A RID: 666 RVA: 0x00009F94 File Offset: 0x00008F94
			[DebuggerNonUserCode]
			public DataColumn Cau_TrucColumn
			{
				get
				{
					return this.columnCau_Truc;
				}
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x0600029B RID: 667 RVA: 0x00009FAC File Offset: 0x00008FAC
			[DebuggerNonUserCode]
			public DataColumn HachColumn
			{
				get
				{
					return this.columnHach;
				}
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x0600029C RID: 668 RVA: 0x00009FC4 File Offset: 0x00008FC4
			[DebuggerNonUserCode]
			public DataColumn KhacColumn
			{
				get
				{
					return this.columnKhac;
				}
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x0600029D RID: 669 RVA: 0x00009FDC File Offset: 0x00008FDC
			[DebuggerNonUserCode]
			public DataColumn Ket_LuanColumn
			{
				get
				{
					return this.columnKet_Luan;
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x0600029E RID: 670 RVA: 0x00009FF4 File Offset: 0x00008FF4
			[DebuggerNonUserCode]
			public DataColumn DS_Anh_KQColumn
			{
				get
				{
					return this.columnDS_Anh_KQ;
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x0600029F RID: 671 RVA: 0x0000A00C File Offset: 0x0000900C
			[DebuggerNonUserCode]
			public DataColumn Ho_Ten_BSSAColumn
			{
				get
				{
					return this.columnHo_Ten_BSSA;
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000A024 File Offset: 0x00009024
			[DebuggerNonUserCode]
			public DataColumn Trinh_DoColumn
			{
				get
				{
					return this.columnTrinh_Do;
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000A03C File Offset: 0x0000903C
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x1700014A RID: 330
			[DebuggerNonUserCode]
			public dsKetQuaSA.SATGRow this[int index]
			{
				get
				{
					return (dsKetQuaSA.SATGRow)base.Rows[index];
				}
			}

			// Token: 0x14000009 RID: 9
			// (add) Token: 0x060002A3 RID: 675 RVA: 0x0000A07F File Offset: 0x0000907F
			// (remove) Token: 0x060002A4 RID: 676 RVA: 0x0000A098 File Offset: 0x00009098
			public event dsKetQuaSA.SATGRowChangeEventHandler SATGRowChanging;

			// Token: 0x1400000A RID: 10
			// (add) Token: 0x060002A5 RID: 677 RVA: 0x0000A0B1 File Offset: 0x000090B1
			// (remove) Token: 0x060002A6 RID: 678 RVA: 0x0000A0CA File Offset: 0x000090CA
			public event dsKetQuaSA.SATGRowChangeEventHandler SATGRowChanged;

			// Token: 0x1400000B RID: 11
			// (add) Token: 0x060002A7 RID: 679 RVA: 0x0000A0E3 File Offset: 0x000090E3
			// (remove) Token: 0x060002A8 RID: 680 RVA: 0x0000A0FC File Offset: 0x000090FC
			public event dsKetQuaSA.SATGRowChangeEventHandler SATGRowDeleting;

			// Token: 0x1400000C RID: 12
			// (add) Token: 0x060002A9 RID: 681 RVA: 0x0000A115 File Offset: 0x00009115
			// (remove) Token: 0x060002AA RID: 682 RVA: 0x0000A12E File Offset: 0x0000912E
			public event dsKetQuaSA.SATGRowChangeEventHandler SATGRowDeleted;

			// Token: 0x060002AB RID: 683 RVA: 0x0000A147 File Offset: 0x00009147
			[DebuggerNonUserCode]
			public void AddSATGRow(dsKetQuaSA.SATGRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x060002AC RID: 684 RVA: 0x0000A158 File Offset: 0x00009158
			[DebuggerNonUserCode]
			public dsKetQuaSA.SATGRow AddSATGRow(string KetQua_SATG_Id, string SA_TG_Id, string Benh_Nhan_Id, string Y_Te_Id, string Ho_Ten, string Gioi_Tinh, string Nam_Sinh, string Dia_Chi, string Ngay, string Lam_sang, string Eo, string Dai_P, string Rong_P, string Day_P, string Dai_T, string Rong_T, string Day_T, string Ton_Thuong, string Cau_Truc, string Hach, string Khac, string Ket_Luan, string DS_Anh_KQ, string Ho_Ten_BSSA, string Trinh_Do)
			{
				dsKetQuaSA.SATGRow satgrow = (dsKetQuaSA.SATGRow)base.NewRow();
				satgrow.ItemArray = new object[]
				{
					KetQua_SATG_Id,
					SA_TG_Id,
					Benh_Nhan_Id,
					Y_Te_Id,
					Ho_Ten,
					Gioi_Tinh,
					Nam_Sinh,
					Dia_Chi,
					Ngay,
					Lam_sang,
					Eo,
					Dai_P,
					Rong_P,
					Day_P,
					Dai_T,
					Rong_T,
					Day_T,
					Ton_Thuong,
					Cau_Truc,
					Hach,
					Khac,
					Ket_Luan,
					DS_Anh_KQ,
					Ho_Ten_BSSA,
					Trinh_Do
				};
				base.Rows.Add(satgrow);
				return satgrow;
			}

			// Token: 0x060002AD RID: 685 RVA: 0x0000A220 File Offset: 0x00009220
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x060002AE RID: 686 RVA: 0x0000A240 File Offset: 0x00009240
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				dsKetQuaSA.SATGDataTable satgdataTable = (dsKetQuaSA.SATGDataTable)base.Clone();
				satgdataTable.InitVars();
				return satgdataTable;
			}

			// Token: 0x060002AF RID: 687 RVA: 0x0000A268 File Offset: 0x00009268
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new dsKetQuaSA.SATGDataTable();
			}

			// Token: 0x060002B0 RID: 688 RVA: 0x0000A280 File Offset: 0x00009280
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnKetQua_SATG_Id = base.Columns["KetQua_SATG_Id"];
				this.columnSA_TG_Id = base.Columns["SA_TG_Id"];
				this.columnBenh_Nhan_Id = base.Columns["Benh_Nhan_Id"];
				this.columnY_Te_Id = base.Columns["Y_Te_Id"];
				this.columnHo_Ten = base.Columns["Ho_Ten"];
				this.columnGioi_Tinh = base.Columns["Gioi_Tinh"];
				this.columnNam_Sinh = base.Columns["Nam_Sinh"];
				this.columnDia_Chi = base.Columns["Dia_Chi"];
				this.columnNgay = base.Columns["Ngay"];
				this.columnLam_sang = base.Columns["Lam_sang"];
				this.columnEo = base.Columns["Eo"];
				this.columnDai_P = base.Columns["Dai_P"];
				this.columnRong_P = base.Columns["Rong_P"];
				this.columnDay_P = base.Columns["Day_P"];
				this.columnDai_T = base.Columns["Dai_T"];
				this.columnRong_T = base.Columns["Rong_T"];
				this.columnDay_T = base.Columns["Day_T"];
				this.columnTon_Thuong = base.Columns["Ton_Thuong"];
				this.columnCau_Truc = base.Columns["Cau_Truc"];
				this.columnHach = base.Columns["Hach"];
				this.columnKhac = base.Columns["Khac"];
				this.columnKet_Luan = base.Columns["Ket_Luan"];
				this.columnDS_Anh_KQ = base.Columns["DS_Anh_KQ"];
				this.columnHo_Ten_BSSA = base.Columns["Ho_Ten_BSSA"];
				this.columnTrinh_Do = base.Columns["Trinh_Do"];
			}

			// Token: 0x060002B1 RID: 689 RVA: 0x0000A4B4 File Offset: 0x000094B4
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnKetQua_SATG_Id = new DataColumn("KetQua_SATG_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKetQua_SATG_Id);
				this.columnSA_TG_Id = new DataColumn("SA_TG_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSA_TG_Id);
				this.columnBenh_Nhan_Id = new DataColumn("Benh_Nhan_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBenh_Nhan_Id);
				this.columnY_Te_Id = new DataColumn("Y_Te_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnY_Te_Id);
				this.columnHo_Ten = new DataColumn("Ho_Ten", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHo_Ten);
				this.columnGioi_Tinh = new DataColumn("Gioi_Tinh", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGioi_Tinh);
				this.columnNam_Sinh = new DataColumn("Nam_Sinh", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNam_Sinh);
				this.columnDia_Chi = new DataColumn("Dia_Chi", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDia_Chi);
				this.columnNgay = new DataColumn("Ngay", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNgay);
				this.columnLam_sang = new DataColumn("Lam_sang", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnLam_sang);
				this.columnEo = new DataColumn("Eo", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnEo);
				this.columnDai_P = new DataColumn("Dai_P", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDai_P);
				this.columnRong_P = new DataColumn("Rong_P", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRong_P);
				this.columnDay_P = new DataColumn("Day_P", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDay_P);
				this.columnDai_T = new DataColumn("Dai_T", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDai_T);
				this.columnRong_T = new DataColumn("Rong_T", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRong_T);
				this.columnDay_T = new DataColumn("Day_T", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDay_T);
				this.columnTon_Thuong = new DataColumn("Ton_Thuong", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTon_Thuong);
				this.columnCau_Truc = new DataColumn("Cau_Truc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCau_Truc);
				this.columnHach = new DataColumn("Hach", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHach);
				this.columnKhac = new DataColumn("Khac", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKhac);
				this.columnKet_Luan = new DataColumn("Ket_Luan", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKet_Luan);
				this.columnDS_Anh_KQ = new DataColumn("DS_Anh_KQ", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDS_Anh_KQ);
				this.columnHo_Ten_BSSA = new DataColumn("Ho_Ten_BSSA", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHo_Ten_BSSA);
				this.columnTrinh_Do = new DataColumn("Trinh_Do", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTrinh_Do);
				this.columnEo.Caption = "Gan";
				this.columnDai_P.Caption = "Mat";
				this.columnRong_P.Caption = "Lach";
				this.columnDay_P.Caption = "Tuy";
				this.columnDai_T.Caption = "ThanP";
				this.columnRong_T.Caption = "ThanT";
				this.columnDay_T.Caption = "DMCBung";
				this.columnTon_Thuong.Caption = "TLT";
				this.columnCau_Truc.Caption = "Bang_Quang";
				this.columnHach.Caption = "Tu_Cung";
			}

			// Token: 0x060002B2 RID: 690 RVA: 0x0000A9EC File Offset: 0x000099EC
			[DebuggerNonUserCode]
			public dsKetQuaSA.SATGRow NewSATGRow()
			{
				return (dsKetQuaSA.SATGRow)base.NewRow();
			}

			// Token: 0x060002B3 RID: 691 RVA: 0x0000AA0C File Offset: 0x00009A0C
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsKetQuaSA.SATGRow(builder);
			}

			// Token: 0x060002B4 RID: 692 RVA: 0x0000AA24 File Offset: 0x00009A24
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(dsKetQuaSA.SATGRow);
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x0000AA40 File Offset: 0x00009A40
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SATGRowChanged != null)
				{
					this.SATGRowChanged(this, new dsKetQuaSA.SATGRowChangeEvent((dsKetQuaSA.SATGRow)e.Row, e.Action));
				}
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x0000AA88 File Offset: 0x00009A88
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SATGRowChanging != null)
				{
					this.SATGRowChanging(this, new dsKetQuaSA.SATGRowChangeEvent((dsKetQuaSA.SATGRow)e.Row, e.Action));
				}
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x0000AAD0 File Offset: 0x00009AD0
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SATGRowDeleted != null)
				{
					this.SATGRowDeleted(this, new dsKetQuaSA.SATGRowChangeEvent((dsKetQuaSA.SATGRow)e.Row, e.Action));
				}
			}

			// Token: 0x060002B8 RID: 696 RVA: 0x0000AB18 File Offset: 0x00009B18
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SATGRowDeleting != null)
				{
					this.SATGRowDeleting(this, new dsKetQuaSA.SATGRowChangeEvent((dsKetQuaSA.SATGRow)e.Row, e.Action));
				}
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x0000AB60 File Offset: 0x00009B60
			[DebuggerNonUserCode]
			public void RemoveSATGRow(dsKetQuaSA.SATGRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x060002BA RID: 698 RVA: 0x0000AB70 File Offset: 0x00009B70
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				dsKetQuaSA dsKetQuaSA = new dsKetQuaSA();
				xs.Add(dsKetQuaSA.GetSchemaSerializable());
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dsKetQuaSA.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SATGDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x04000075 RID: 117
			private DataColumn columnKetQua_SATG_Id;

			// Token: 0x04000076 RID: 118
			private DataColumn columnSA_TG_Id;

			// Token: 0x04000077 RID: 119
			private DataColumn columnBenh_Nhan_Id;

			// Token: 0x04000078 RID: 120
			private DataColumn columnY_Te_Id;

			// Token: 0x04000079 RID: 121
			private DataColumn columnHo_Ten;

			// Token: 0x0400007A RID: 122
			private DataColumn columnGioi_Tinh;

			// Token: 0x0400007B RID: 123
			private DataColumn columnNam_Sinh;

			// Token: 0x0400007C RID: 124
			private DataColumn columnDia_Chi;

			// Token: 0x0400007D RID: 125
			private DataColumn columnNgay;

			// Token: 0x0400007E RID: 126
			private DataColumn columnLam_sang;

			// Token: 0x0400007F RID: 127
			private DataColumn columnEo;

			// Token: 0x04000080 RID: 128
			private DataColumn columnDai_P;

			// Token: 0x04000081 RID: 129
			private DataColumn columnRong_P;

			// Token: 0x04000082 RID: 130
			private DataColumn columnDay_P;

			// Token: 0x04000083 RID: 131
			private DataColumn columnDai_T;

			// Token: 0x04000084 RID: 132
			private DataColumn columnRong_T;

			// Token: 0x04000085 RID: 133
			private DataColumn columnDay_T;

			// Token: 0x04000086 RID: 134
			private DataColumn columnTon_Thuong;

			// Token: 0x04000087 RID: 135
			private DataColumn columnCau_Truc;

			// Token: 0x04000088 RID: 136
			private DataColumn columnHach;

			// Token: 0x04000089 RID: 137
			private DataColumn columnKhac;

			// Token: 0x0400008A RID: 138
			private DataColumn columnKet_Luan;

			// Token: 0x0400008B RID: 139
			private DataColumn columnDS_Anh_KQ;

			// Token: 0x0400008C RID: 140
			private DataColumn columnHo_Ten_BSSA;

			// Token: 0x0400008D RID: 141
			private DataColumn columnTrinh_Do;
		}

		// Token: 0x02000041 RID: 65
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SATVDataTable : DataTable, IEnumerable
		{
			// Token: 0x060002BB RID: 699 RVA: 0x0000AC89 File Offset: 0x00009C89
			[DebuggerNonUserCode]
			public SATVDataTable()
			{
				base.TableName = "SATV";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x060002BC RID: 700 RVA: 0x0000ACB8 File Offset: 0x00009CB8
			[DebuggerNonUserCode]
			internal SATVDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x060002BD RID: 701 RVA: 0x0000AD7D File Offset: 0x00009D7D
			[DebuggerNonUserCode]
			protected SATVDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x060002BE RID: 702 RVA: 0x0000AD94 File Offset: 0x00009D94
			[DebuggerNonUserCode]
			public DataColumn KetQua_SATV_IdColumn
			{
				get
				{
					return this.columnKetQua_SATV_Id;
				}
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x060002BF RID: 703 RVA: 0x0000ADAC File Offset: 0x00009DAC
			[DebuggerNonUserCode]
			public DataColumn SA_TV_IdColumn
			{
				get
				{
					return this.columnSA_TV_Id;
				}
			}

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000ADC4 File Offset: 0x00009DC4
			[DebuggerNonUserCode]
			public DataColumn Benh_Nhan_IdColumn
			{
				get
				{
					return this.columnBenh_Nhan_Id;
				}
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000ADDC File Offset: 0x00009DDC
			[DebuggerNonUserCode]
			public DataColumn Y_Te_IdColumn
			{
				get
				{
					return this.columnY_Te_Id;
				}
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000ADF4 File Offset: 0x00009DF4
			[DebuggerNonUserCode]
			public DataColumn Ho_TenColumn
			{
				get
				{
					return this.columnHo_Ten;
				}
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000AE0C File Offset: 0x00009E0C
			[DebuggerNonUserCode]
			public DataColumn Gioi_TinhColumn
			{
				get
				{
					return this.columnGioi_Tinh;
				}
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000AE24 File Offset: 0x00009E24
			[DebuggerNonUserCode]
			public DataColumn Nam_SinhColumn
			{
				get
				{
					return this.columnNam_Sinh;
				}
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000AE3C File Offset: 0x00009E3C
			[DebuggerNonUserCode]
			public DataColumn Dia_ChiColumn
			{
				get
				{
					return this.columnDia_Chi;
				}
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000AE54 File Offset: 0x00009E54
			[DebuggerNonUserCode]
			public DataColumn NgayColumn
			{
				get
				{
					return this.columnNgay;
				}
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x060002C7 RID: 711 RVA: 0x0000AE6C File Offset: 0x00009E6C
			[DebuggerNonUserCode]
			public DataColumn Lam_sangColumn
			{
				get
				{
					return this.columnLam_sang;
				}
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000AE84 File Offset: 0x00009E84
			[DebuggerNonUserCode]
			public DataColumn Vi_Tri_Ton_ThuongColumn
			{
				get
				{
					return this.columnVi_Tri_Ton_Thuong;
				}
			}

			// Token: 0x17000156 RID: 342
			// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000AE9C File Offset: 0x00009E9C
			[DebuggerNonUserCode]
			public DataColumn HachColumn
			{
				get
				{
					return this.columnHach;
				}
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x060002CA RID: 714 RVA: 0x0000AEB4 File Offset: 0x00009EB4
			[DebuggerNonUserCode]
			public DataColumn Cau_TrucColumn
			{
				get
				{
					return this.columnCau_Truc;
				}
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x060002CB RID: 715 RVA: 0x0000AECC File Offset: 0x00009ECC
			[DebuggerNonUserCode]
			public DataColumn Kich_Thuoc_BuouColumn
			{
				get
				{
					return this.columnKich_Thuoc_Buou;
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x060002CC RID: 716 RVA: 0x0000AEE4 File Offset: 0x00009EE4
			[DebuggerNonUserCode]
			public DataColumn Bo_BuouColumn
			{
				get
				{
					return this.columnBo_Buou;
				}
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x060002CD RID: 717 RVA: 0x0000AEFC File Offset: 0x00009EFC
			[DebuggerNonUserCode]
			public DataColumn Cau_Truc_BuouColumn
			{
				get
				{
					return this.columnCau_Truc_Buou;
				}
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x060002CE RID: 718 RVA: 0x0000AF14 File Offset: 0x00009F14
			[DebuggerNonUserCode]
			public DataColumn KhacColumn
			{
				get
				{
					return this.columnKhac;
				}
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x060002CF RID: 719 RVA: 0x0000AF2C File Offset: 0x00009F2C
			[DebuggerNonUserCode]
			public DataColumn Ket_LuanColumn
			{
				get
				{
					return this.columnKet_Luan;
				}
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000AF44 File Offset: 0x00009F44
			[DebuggerNonUserCode]
			public DataColumn DS_Anh_KQColumn
			{
				get
				{
					return this.columnDS_Anh_KQ;
				}
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000AF5C File Offset: 0x00009F5C
			[DebuggerNonUserCode]
			public DataColumn Ho_Ten_BSSAColumn
			{
				get
				{
					return this.columnHo_Ten_BSSA;
				}
			}

			// Token: 0x1700015F RID: 351
			// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000AF74 File Offset: 0x00009F74
			[DebuggerNonUserCode]
			public DataColumn Trinh_DoColumn
			{
				get
				{
					return this.columnTrinh_Do;
				}
			}

			// Token: 0x17000160 RID: 352
			// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000AF8C File Offset: 0x00009F8C
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x17000161 RID: 353
			[DebuggerNonUserCode]
			public dsKetQuaSA.SATVRow this[int index]
			{
				get
				{
					return (dsKetQuaSA.SATVRow)base.Rows[index];
				}
			}

			// Token: 0x1400000D RID: 13
			// (add) Token: 0x060002D5 RID: 725 RVA: 0x0000AFCF File Offset: 0x00009FCF
			// (remove) Token: 0x060002D6 RID: 726 RVA: 0x0000AFE8 File Offset: 0x00009FE8
			public event dsKetQuaSA.SATVRowChangeEventHandler SATVRowChanging;

			// Token: 0x1400000E RID: 14
			// (add) Token: 0x060002D7 RID: 727 RVA: 0x0000B001 File Offset: 0x0000A001
			// (remove) Token: 0x060002D8 RID: 728 RVA: 0x0000B01A File Offset: 0x0000A01A
			public event dsKetQuaSA.SATVRowChangeEventHandler SATVRowChanged;

			// Token: 0x1400000F RID: 15
			// (add) Token: 0x060002D9 RID: 729 RVA: 0x0000B033 File Offset: 0x0000A033
			// (remove) Token: 0x060002DA RID: 730 RVA: 0x0000B04C File Offset: 0x0000A04C
			public event dsKetQuaSA.SATVRowChangeEventHandler SATVRowDeleting;

			// Token: 0x14000010 RID: 16
			// (add) Token: 0x060002DB RID: 731 RVA: 0x0000B065 File Offset: 0x0000A065
			// (remove) Token: 0x060002DC RID: 732 RVA: 0x0000B07E File Offset: 0x0000A07E
			public event dsKetQuaSA.SATVRowChangeEventHandler SATVRowDeleted;

			// Token: 0x060002DD RID: 733 RVA: 0x0000B097 File Offset: 0x0000A097
			[DebuggerNonUserCode]
			public void AddSATVRow(dsKetQuaSA.SATVRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x060002DE RID: 734 RVA: 0x0000B0A8 File Offset: 0x0000A0A8
			[DebuggerNonUserCode]
			public dsKetQuaSA.SATVRow AddSATVRow(string KetQua_SATV_Id, string SA_TV_Id, string Benh_Nhan_Id, string Y_Te_Id, string Ho_Ten, string Gioi_Tinh, string Nam_Sinh, string Dia_Chi, string Ngay, string Lam_sang, string Vi_Tri_Ton_Thuong, string Hach, string Cau_Truc, string Kich_Thuoc_Buou, string Bo_Buou, string Cau_Truc_Buou, string Khac, string Ket_Luan, string DS_Anh_KQ, string Ho_Ten_BSSA, string Trinh_Do)
			{
				dsKetQuaSA.SATVRow satvrow = (dsKetQuaSA.SATVRow)base.NewRow();
				satvrow.ItemArray = new object[]
				{
					KetQua_SATV_Id,
					SA_TV_Id,
					Benh_Nhan_Id,
					Y_Te_Id,
					Ho_Ten,
					Gioi_Tinh,
					Nam_Sinh,
					Dia_Chi,
					Ngay,
					Lam_sang,
					Vi_Tri_Ton_Thuong,
					Hach,
					Cau_Truc,
					Kich_Thuoc_Buou,
					Bo_Buou,
					Cau_Truc_Buou,
					Khac,
					Ket_Luan,
					DS_Anh_KQ,
					Ho_Ten_BSSA,
					Trinh_Do
				};
				base.Rows.Add(satvrow);
				return satvrow;
			}

			// Token: 0x060002DF RID: 735 RVA: 0x0000B158 File Offset: 0x0000A158
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x060002E0 RID: 736 RVA: 0x0000B178 File Offset: 0x0000A178
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				dsKetQuaSA.SATVDataTable satvdataTable = (dsKetQuaSA.SATVDataTable)base.Clone();
				satvdataTable.InitVars();
				return satvdataTable;
			}

			// Token: 0x060002E1 RID: 737 RVA: 0x0000B1A0 File Offset: 0x0000A1A0
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new dsKetQuaSA.SATVDataTable();
			}

			// Token: 0x060002E2 RID: 738 RVA: 0x0000B1B8 File Offset: 0x0000A1B8
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnKetQua_SATV_Id = base.Columns["KetQua_SATV_Id"];
				this.columnSA_TV_Id = base.Columns["SA_TV_Id"];
				this.columnBenh_Nhan_Id = base.Columns["Benh_Nhan_Id"];
				this.columnY_Te_Id = base.Columns["Y_Te_Id"];
				this.columnHo_Ten = base.Columns["Ho_Ten"];
				this.columnGioi_Tinh = base.Columns["Gioi_Tinh"];
				this.columnNam_Sinh = base.Columns["Nam_Sinh"];
				this.columnDia_Chi = base.Columns["Dia_Chi"];
				this.columnNgay = base.Columns["Ngay"];
				this.columnLam_sang = base.Columns["Lam_sang"];
				this.columnVi_Tri_Ton_Thuong = base.Columns["Vi_Tri_Ton_Thuong"];
				this.columnHach = base.Columns["Hach"];
				this.columnCau_Truc = base.Columns["Cau_Truc"];
				this.columnKich_Thuoc_Buou = base.Columns["Kich_Thuoc_Buou"];
				this.columnBo_Buou = base.Columns["Bo_Buou"];
				this.columnCau_Truc_Buou = base.Columns["Cau_Truc_Buou"];
				this.columnKhac = base.Columns["Khac"];
				this.columnKet_Luan = base.Columns["Ket_Luan"];
				this.columnDS_Anh_KQ = base.Columns["DS_Anh_KQ"];
				this.columnHo_Ten_BSSA = base.Columns["Ho_Ten_BSSA"];
				this.columnTrinh_Do = base.Columns["Trinh_Do"];
			}

			// Token: 0x060002E3 RID: 739 RVA: 0x0000B394 File Offset: 0x0000A394
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnKetQua_SATV_Id = new DataColumn("KetQua_SATV_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKetQua_SATV_Id);
				this.columnSA_TV_Id = new DataColumn("SA_TV_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSA_TV_Id);
				this.columnBenh_Nhan_Id = new DataColumn("Benh_Nhan_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBenh_Nhan_Id);
				this.columnY_Te_Id = new DataColumn("Y_Te_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnY_Te_Id);
				this.columnHo_Ten = new DataColumn("Ho_Ten", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHo_Ten);
				this.columnGioi_Tinh = new DataColumn("Gioi_Tinh", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGioi_Tinh);
				this.columnNam_Sinh = new DataColumn("Nam_Sinh", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNam_Sinh);
				this.columnDia_Chi = new DataColumn("Dia_Chi", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDia_Chi);
				this.columnNgay = new DataColumn("Ngay", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNgay);
				this.columnLam_sang = new DataColumn("Lam_sang", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnLam_sang);
				this.columnVi_Tri_Ton_Thuong = new DataColumn("Vi_Tri_Ton_Thuong", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnVi_Tri_Ton_Thuong);
				this.columnHach = new DataColumn("Hach", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHach);
				this.columnCau_Truc = new DataColumn("Cau_Truc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCau_Truc);
				this.columnKich_Thuoc_Buou = new DataColumn("Kich_Thuoc_Buou", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKich_Thuoc_Buou);
				this.columnBo_Buou = new DataColumn("Bo_Buou", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBo_Buou);
				this.columnCau_Truc_Buou = new DataColumn("Cau_Truc_Buou", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCau_Truc_Buou);
				this.columnKhac = new DataColumn("Khac", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKhac);
				this.columnKet_Luan = new DataColumn("Ket_Luan", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKet_Luan);
				this.columnDS_Anh_KQ = new DataColumn("DS_Anh_KQ", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDS_Anh_KQ);
				this.columnHo_Ten_BSSA = new DataColumn("Ho_Ten_BSSA", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHo_Ten_BSSA);
				this.columnTrinh_Do = new DataColumn("Trinh_Do", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTrinh_Do);
				this.columnVi_Tri_Ton_Thuong.Caption = "Gan";
				this.columnHach.Caption = "Mat";
				this.columnCau_Truc.Caption = "Lach";
				this.columnKich_Thuoc_Buou.Caption = "Tuy";
				this.columnBo_Buou.Caption = "ThanP";
				this.columnCau_Truc_Buou.Caption = "ThanT";
			}

			// Token: 0x060002E4 RID: 740 RVA: 0x0000B7D0 File Offset: 0x0000A7D0
			[DebuggerNonUserCode]
			public dsKetQuaSA.SATVRow NewSATVRow()
			{
				return (dsKetQuaSA.SATVRow)base.NewRow();
			}

			// Token: 0x060002E5 RID: 741 RVA: 0x0000B7F0 File Offset: 0x0000A7F0
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsKetQuaSA.SATVRow(builder);
			}

			// Token: 0x060002E6 RID: 742 RVA: 0x0000B808 File Offset: 0x0000A808
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(dsKetQuaSA.SATVRow);
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x0000B824 File Offset: 0x0000A824
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SATVRowChanged != null)
				{
					this.SATVRowChanged(this, new dsKetQuaSA.SATVRowChangeEvent((dsKetQuaSA.SATVRow)e.Row, e.Action));
				}
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x0000B86C File Offset: 0x0000A86C
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SATVRowChanging != null)
				{
					this.SATVRowChanging(this, new dsKetQuaSA.SATVRowChangeEvent((dsKetQuaSA.SATVRow)e.Row, e.Action));
				}
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x0000B8B4 File Offset: 0x0000A8B4
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SATVRowDeleted != null)
				{
					this.SATVRowDeleted(this, new dsKetQuaSA.SATVRowChangeEvent((dsKetQuaSA.SATVRow)e.Row, e.Action));
				}
			}

			// Token: 0x060002EA RID: 746 RVA: 0x0000B8FC File Offset: 0x0000A8FC
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SATVRowDeleting != null)
				{
					this.SATVRowDeleting(this, new dsKetQuaSA.SATVRowChangeEvent((dsKetQuaSA.SATVRow)e.Row, e.Action));
				}
			}

			// Token: 0x060002EB RID: 747 RVA: 0x0000B944 File Offset: 0x0000A944
			[DebuggerNonUserCode]
			public void RemoveSATVRow(dsKetQuaSA.SATVRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x060002EC RID: 748 RVA: 0x0000B954 File Offset: 0x0000A954
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				dsKetQuaSA dsKetQuaSA = new dsKetQuaSA();
				xs.Add(dsKetQuaSA.GetSchemaSerializable());
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dsKetQuaSA.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SATVDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x04000092 RID: 146
			private DataColumn columnKetQua_SATV_Id;

			// Token: 0x04000093 RID: 147
			private DataColumn columnSA_TV_Id;

			// Token: 0x04000094 RID: 148
			private DataColumn columnBenh_Nhan_Id;

			// Token: 0x04000095 RID: 149
			private DataColumn columnY_Te_Id;

			// Token: 0x04000096 RID: 150
			private DataColumn columnHo_Ten;

			// Token: 0x04000097 RID: 151
			private DataColumn columnGioi_Tinh;

			// Token: 0x04000098 RID: 152
			private DataColumn columnNam_Sinh;

			// Token: 0x04000099 RID: 153
			private DataColumn columnDia_Chi;

			// Token: 0x0400009A RID: 154
			private DataColumn columnNgay;

			// Token: 0x0400009B RID: 155
			private DataColumn columnLam_sang;

			// Token: 0x0400009C RID: 156
			private DataColumn columnVi_Tri_Ton_Thuong;

			// Token: 0x0400009D RID: 157
			private DataColumn columnHach;

			// Token: 0x0400009E RID: 158
			private DataColumn columnCau_Truc;

			// Token: 0x0400009F RID: 159
			private DataColumn columnKich_Thuoc_Buou;

			// Token: 0x040000A0 RID: 160
			private DataColumn columnBo_Buou;

			// Token: 0x040000A1 RID: 161
			private DataColumn columnCau_Truc_Buou;

			// Token: 0x040000A2 RID: 162
			private DataColumn columnKhac;

			// Token: 0x040000A3 RID: 163
			private DataColumn columnKet_Luan;

			// Token: 0x040000A4 RID: 164
			private DataColumn columnDS_Anh_KQ;

			// Token: 0x040000A5 RID: 165
			private DataColumn columnHo_Ten_BSSA;

			// Token: 0x040000A6 RID: 166
			private DataColumn columnTrinh_Do;
		}

		// Token: 0x02000042 RID: 66
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SATQDataTable : DataTable, IEnumerable
		{
			// Token: 0x060002ED RID: 749 RVA: 0x0000BA6D File Offset: 0x0000AA6D
			[DebuggerNonUserCode]
			public SATQDataTable()
			{
				base.TableName = "SATQ";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x060002EE RID: 750 RVA: 0x0000BA9C File Offset: 0x0000AA9C
			[DebuggerNonUserCode]
			internal SATQDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x060002EF RID: 751 RVA: 0x0000BB61 File Offset: 0x0000AB61
			[DebuggerNonUserCode]
			protected SATQDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000BB78 File Offset: 0x0000AB78
			[DebuggerNonUserCode]
			public DataColumn KetQua_SATQ_IdColumn
			{
				get
				{
					return this.columnKetQua_SATQ_Id;
				}
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000BB90 File Offset: 0x0000AB90
			[DebuggerNonUserCode]
			public DataColumn SA_TQ_IdColumn
			{
				get
				{
					return this.columnSA_TQ_Id;
				}
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x060002F2 RID: 754 RVA: 0x0000BBA8 File Offset: 0x0000ABA8
			[DebuggerNonUserCode]
			public DataColumn BenhNhan_IdColumn
			{
				get
				{
					return this.columnBenhNhan_Id;
				}
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000BBC0 File Offset: 0x0000ABC0
			[DebuggerNonUserCode]
			public DataColumn Y_Te_IdColumn
			{
				get
				{
					return this.columnY_Te_Id;
				}
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000BBD8 File Offset: 0x0000ABD8
			[DebuggerNonUserCode]
			public DataColumn Ho_TenColumn
			{
				get
				{
					return this.columnHo_Ten;
				}
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000BBF0 File Offset: 0x0000ABF0
			[DebuggerNonUserCode]
			public DataColumn Gioi_TinhColumn
			{
				get
				{
					return this.columnGioi_Tinh;
				}
			}

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000BC08 File Offset: 0x0000AC08
			[DebuggerNonUserCode]
			public DataColumn Nam_SinhColumn
			{
				get
				{
					return this.columnNam_Sinh;
				}
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x060002F7 RID: 759 RVA: 0x0000BC20 File Offset: 0x0000AC20
			[DebuggerNonUserCode]
			public DataColumn Dia_ChiColumn
			{
				get
				{
					return this.columnDia_Chi;
				}
			}

			// Token: 0x1700016A RID: 362
			// (get) Token: 0x060002F8 RID: 760 RVA: 0x0000BC38 File Offset: 0x0000AC38
			[DebuggerNonUserCode]
			public DataColumn NgayColumn
			{
				get
				{
					return this.columnNgay;
				}
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000BC50 File Offset: 0x0000AC50
			[DebuggerNonUserCode]
			public DataColumn Lam_SangColumn
			{
				get
				{
					return this.columnLam_Sang;
				}
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x060002FA RID: 762 RVA: 0x0000BC68 File Offset: 0x0000AC68
			[DebuggerNonUserCode]
			public DataColumn GanColumn
			{
				get
				{
					return this.columnGan;
				}
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x060002FB RID: 763 RVA: 0x0000BC80 File Offset: 0x0000AC80
			[DebuggerNonUserCode]
			public DataColumn MatColumn
			{
				get
				{
					return this.columnMat;
				}
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x060002FC RID: 764 RVA: 0x0000BC98 File Offset: 0x0000AC98
			[DebuggerNonUserCode]
			public DataColumn TuyColumn
			{
				get
				{
					return this.columnTuy;
				}
			}

			// Token: 0x1700016F RID: 367
			// (get) Token: 0x060002FD RID: 765 RVA: 0x0000BCB0 File Offset: 0x0000ACB0
			[DebuggerNonUserCode]
			public DataColumn LachColumn
			{
				get
				{
					return this.columnLach;
				}
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x060002FE RID: 766 RVA: 0x0000BCC8 File Offset: 0x0000ACC8
			[DebuggerNonUserCode]
			public DataColumn ThanPColumn
			{
				get
				{
					return this.columnThanP;
				}
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x060002FF RID: 767 RVA: 0x0000BCE0 File Offset: 0x0000ACE0
			[DebuggerNonUserCode]
			public DataColumn ThanTColumn
			{
				get
				{
					return this.columnThanT;
				}
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x06000300 RID: 768 RVA: 0x0000BCF8 File Offset: 0x0000ACF8
			[DebuggerNonUserCode]
			public DataColumn DMCBungColumn
			{
				get
				{
					return this.columnDMCBung;
				}
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x06000301 RID: 769 RVA: 0x0000BD10 File Offset: 0x0000AD10
			[DebuggerNonUserCode]
			public DataColumn TLTColumn
			{
				get
				{
					return this.columnTLT;
				}
			}

			// Token: 0x17000174 RID: 372
			// (get) Token: 0x06000302 RID: 770 RVA: 0x0000BD28 File Offset: 0x0000AD28
			[DebuggerNonUserCode]
			public DataColumn TuCungColumn
			{
				get
				{
					return this.columnTuCung;
				}
			}

			// Token: 0x17000175 RID: 373
			// (get) Token: 0x06000303 RID: 771 RVA: 0x0000BD40 File Offset: 0x0000AD40
			[DebuggerNonUserCode]
			public DataColumn BuongTrungColumn
			{
				get
				{
					return this.columnBuongTrung;
				}
			}

			// Token: 0x17000176 RID: 374
			// (get) Token: 0x06000304 RID: 772 RVA: 0x0000BD58 File Offset: 0x0000AD58
			[DebuggerNonUserCode]
			public DataColumn Bang_QuangColumn
			{
				get
				{
					return this.columnBang_Quang;
				}
			}

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x06000305 RID: 773 RVA: 0x0000BD70 File Offset: 0x0000AD70
			[DebuggerNonUserCode]
			public DataColumn KhacColumn
			{
				get
				{
					return this.columnKhac;
				}
			}

			// Token: 0x17000178 RID: 376
			// (get) Token: 0x06000306 RID: 774 RVA: 0x0000BD88 File Offset: 0x0000AD88
			[DebuggerNonUserCode]
			public DataColumn Ket_LuanColumn
			{
				get
				{
					return this.columnKet_Luan;
				}
			}

			// Token: 0x17000179 RID: 377
			// (get) Token: 0x06000307 RID: 775 RVA: 0x0000BDA0 File Offset: 0x0000ADA0
			[DebuggerNonUserCode]
			public DataColumn DS_Anh_KQColumn
			{
				get
				{
					return this.columnDS_Anh_KQ;
				}
			}

			// Token: 0x1700017A RID: 378
			// (get) Token: 0x06000308 RID: 776 RVA: 0x0000BDB8 File Offset: 0x0000ADB8
			[DebuggerNonUserCode]
			public DataColumn Ho_Ten_BSSAColumn
			{
				get
				{
					return this.columnHo_Ten_BSSA;
				}
			}

			// Token: 0x1700017B RID: 379
			// (get) Token: 0x06000309 RID: 777 RVA: 0x0000BDD0 File Offset: 0x0000ADD0
			[DebuggerNonUserCode]
			public DataColumn Trinh_DoColumn
			{
				get
				{
					return this.columnTrinh_Do;
				}
			}

			// Token: 0x1700017C RID: 380
			// (get) Token: 0x0600030A RID: 778 RVA: 0x0000BDE8 File Offset: 0x0000ADE8
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x1700017D RID: 381
			[DebuggerNonUserCode]
			public dsKetQuaSA.SATQRow this[int index]
			{
				get
				{
					return (dsKetQuaSA.SATQRow)base.Rows[index];
				}
			}

			// Token: 0x14000011 RID: 17
			// (add) Token: 0x0600030C RID: 780 RVA: 0x0000BE2B File Offset: 0x0000AE2B
			// (remove) Token: 0x0600030D RID: 781 RVA: 0x0000BE44 File Offset: 0x0000AE44
			public event dsKetQuaSA.SATQRowChangeEventHandler SATQRowChanging;

			// Token: 0x14000012 RID: 18
			// (add) Token: 0x0600030E RID: 782 RVA: 0x0000BE5D File Offset: 0x0000AE5D
			// (remove) Token: 0x0600030F RID: 783 RVA: 0x0000BE76 File Offset: 0x0000AE76
			public event dsKetQuaSA.SATQRowChangeEventHandler SATQRowChanged;

			// Token: 0x14000013 RID: 19
			// (add) Token: 0x06000310 RID: 784 RVA: 0x0000BE8F File Offset: 0x0000AE8F
			// (remove) Token: 0x06000311 RID: 785 RVA: 0x0000BEA8 File Offset: 0x0000AEA8
			public event dsKetQuaSA.SATQRowChangeEventHandler SATQRowDeleting;

			// Token: 0x14000014 RID: 20
			// (add) Token: 0x06000312 RID: 786 RVA: 0x0000BEC1 File Offset: 0x0000AEC1
			// (remove) Token: 0x06000313 RID: 787 RVA: 0x0000BEDA File Offset: 0x0000AEDA
			public event dsKetQuaSA.SATQRowChangeEventHandler SATQRowDeleted;

			// Token: 0x06000314 RID: 788 RVA: 0x0000BEF3 File Offset: 0x0000AEF3
			[DebuggerNonUserCode]
			public void AddSATQRow(dsKetQuaSA.SATQRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x06000315 RID: 789 RVA: 0x0000BF04 File Offset: 0x0000AF04
			[DebuggerNonUserCode]
			public dsKetQuaSA.SATQRow AddSATQRow(string KetQua_SATQ_Id, string SA_TQ_Id, string BenhNhan_Id, string Y_Te_Id, string Ho_Ten, string Gioi_Tinh, string Nam_Sinh, string Dia_Chi, string Ngay, string Lam_Sang, string Gan, string Mat, string Tuy, string Lach, string ThanP, string ThanT, string DMCBung, string TLT, string TuCung, string BuongTrung, string Bang_Quang, string Khac, string Ket_Luan, string DS_Anh_KQ, string Ho_Ten_BSSA, string Trinh_Do)
			{
				dsKetQuaSA.SATQRow satqrow = (dsKetQuaSA.SATQRow)base.NewRow();
				satqrow.ItemArray = new object[]
				{
					KetQua_SATQ_Id,
					SA_TQ_Id,
					BenhNhan_Id,
					Y_Te_Id,
					Ho_Ten,
					Gioi_Tinh,
					Nam_Sinh,
					Dia_Chi,
					Ngay,
					Lam_Sang,
					Gan,
					Mat,
					Tuy,
					Lach,
					ThanP,
					ThanT,
					DMCBung,
					TLT,
					TuCung,
					BuongTrung,
					Bang_Quang,
					Khac,
					Ket_Luan,
					DS_Anh_KQ,
					Ho_Ten_BSSA,
					Trinh_Do
				};
				base.Rows.Add(satqrow);
				return satqrow;
			}

			// Token: 0x06000316 RID: 790 RVA: 0x0000BFD0 File Offset: 0x0000AFD0
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x06000317 RID: 791 RVA: 0x0000BFF0 File Offset: 0x0000AFF0
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				dsKetQuaSA.SATQDataTable satqdataTable = (dsKetQuaSA.SATQDataTable)base.Clone();
				satqdataTable.InitVars();
				return satqdataTable;
			}

			// Token: 0x06000318 RID: 792 RVA: 0x0000C018 File Offset: 0x0000B018
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new dsKetQuaSA.SATQDataTable();
			}

			// Token: 0x06000319 RID: 793 RVA: 0x0000C030 File Offset: 0x0000B030
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnKetQua_SATQ_Id = base.Columns["KetQua_SATQ_Id"];
				this.columnSA_TQ_Id = base.Columns["SA_TQ_Id"];
				this.columnBenhNhan_Id = base.Columns["BenhNhan_Id"];
				this.columnY_Te_Id = base.Columns["Y_Te_Id"];
				this.columnHo_Ten = base.Columns["Ho_Ten"];
				this.columnGioi_Tinh = base.Columns["Gioi_Tinh"];
				this.columnNam_Sinh = base.Columns["Nam_Sinh"];
				this.columnDia_Chi = base.Columns["Dia_Chi"];
				this.columnNgay = base.Columns["Ngay"];
				this.columnLam_Sang = base.Columns["Lam_Sang"];
				this.columnGan = base.Columns["Gan"];
				this.columnMat = base.Columns["Mat"];
				this.columnTuy = base.Columns["Tuy"];
				this.columnLach = base.Columns["Lach"];
				this.columnThanP = base.Columns["ThanP"];
				this.columnThanT = base.Columns["ThanT"];
				this.columnDMCBung = base.Columns["DMCBung"];
				this.columnTLT = base.Columns["TLT"];
				this.columnTuCung = base.Columns["TuCung"];
				this.columnBuongTrung = base.Columns["BuongTrung"];
				this.columnBang_Quang = base.Columns["Bang_Quang"];
				this.columnKhac = base.Columns["Khac"];
				this.columnKet_Luan = base.Columns["Ket_Luan"];
				this.columnDS_Anh_KQ = base.Columns["DS_Anh_KQ"];
				this.columnHo_Ten_BSSA = base.Columns["Ho_Ten_BSSA"];
				this.columnTrinh_Do = base.Columns["Trinh_Do"];
			}

			// Token: 0x0600031A RID: 794 RVA: 0x0000C27C File Offset: 0x0000B27C
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnKetQua_SATQ_Id = new DataColumn("KetQua_SATQ_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKetQua_SATQ_Id);
				this.columnSA_TQ_Id = new DataColumn("SA_TQ_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSA_TQ_Id);
				this.columnBenhNhan_Id = new DataColumn("BenhNhan_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBenhNhan_Id);
				this.columnY_Te_Id = new DataColumn("Y_Te_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnY_Te_Id);
				this.columnHo_Ten = new DataColumn("Ho_Ten", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHo_Ten);
				this.columnGioi_Tinh = new DataColumn("Gioi_Tinh", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGioi_Tinh);
				this.columnNam_Sinh = new DataColumn("Nam_Sinh", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNam_Sinh);
				this.columnDia_Chi = new DataColumn("Dia_Chi", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDia_Chi);
				this.columnNgay = new DataColumn("Ngay", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNgay);
				this.columnLam_Sang = new DataColumn("Lam_Sang", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnLam_Sang);
				this.columnGan = new DataColumn("Gan", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGan);
				this.columnMat = new DataColumn("Mat", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnMat);
				this.columnTuy = new DataColumn("Tuy", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTuy);
				this.columnLach = new DataColumn("Lach", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnLach);
				this.columnThanP = new DataColumn("ThanP", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnThanP);
				this.columnThanT = new DataColumn("ThanT", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnThanT);
				this.columnDMCBung = new DataColumn("DMCBung", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDMCBung);
				this.columnTLT = new DataColumn("TLT", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTLT);
				this.columnTuCung = new DataColumn("TuCung", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTuCung);
				this.columnBuongTrung = new DataColumn("BuongTrung", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBuongTrung);
				this.columnBang_Quang = new DataColumn("Bang_Quang", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBang_Quang);
				this.columnKhac = new DataColumn("Khac", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKhac);
				this.columnKet_Luan = new DataColumn("Ket_Luan", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKet_Luan);
				this.columnDS_Anh_KQ = new DataColumn("DS_Anh_KQ", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDS_Anh_KQ);
				this.columnHo_Ten_BSSA = new DataColumn("Ho_Ten_BSSA", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHo_Ten_BSSA);
				this.columnTrinh_Do = new DataColumn("Trinh_Do", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTrinh_Do);
			}

			// Token: 0x0600031B RID: 795 RVA: 0x0000C738 File Offset: 0x0000B738
			[DebuggerNonUserCode]
			public dsKetQuaSA.SATQRow NewSATQRow()
			{
				return (dsKetQuaSA.SATQRow)base.NewRow();
			}

			// Token: 0x0600031C RID: 796 RVA: 0x0000C758 File Offset: 0x0000B758
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsKetQuaSA.SATQRow(builder);
			}

			// Token: 0x0600031D RID: 797 RVA: 0x0000C770 File Offset: 0x0000B770
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(dsKetQuaSA.SATQRow);
			}

			// Token: 0x0600031E RID: 798 RVA: 0x0000C78C File Offset: 0x0000B78C
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SATQRowChanged != null)
				{
					this.SATQRowChanged(this, new dsKetQuaSA.SATQRowChangeEvent((dsKetQuaSA.SATQRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600031F RID: 799 RVA: 0x0000C7D4 File Offset: 0x0000B7D4
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SATQRowChanging != null)
				{
					this.SATQRowChanging(this, new dsKetQuaSA.SATQRowChangeEvent((dsKetQuaSA.SATQRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000320 RID: 800 RVA: 0x0000C81C File Offset: 0x0000B81C
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SATQRowDeleted != null)
				{
					this.SATQRowDeleted(this, new dsKetQuaSA.SATQRowChangeEvent((dsKetQuaSA.SATQRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000321 RID: 801 RVA: 0x0000C864 File Offset: 0x0000B864
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SATQRowDeleting != null)
				{
					this.SATQRowDeleting(this, new dsKetQuaSA.SATQRowChangeEvent((dsKetQuaSA.SATQRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000322 RID: 802 RVA: 0x0000C8AC File Offset: 0x0000B8AC
			[DebuggerNonUserCode]
			public void RemoveSATQRow(dsKetQuaSA.SATQRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000323 RID: 803 RVA: 0x0000C8BC File Offset: 0x0000B8BC
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				dsKetQuaSA dsKetQuaSA = new dsKetQuaSA();
				xs.Add(dsKetQuaSA.GetSchemaSerializable());
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dsKetQuaSA.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SATQDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x040000AB RID: 171
			private DataColumn columnKetQua_SATQ_Id;

			// Token: 0x040000AC RID: 172
			private DataColumn columnSA_TQ_Id;

			// Token: 0x040000AD RID: 173
			private DataColumn columnBenhNhan_Id;

			// Token: 0x040000AE RID: 174
			private DataColumn columnY_Te_Id;

			// Token: 0x040000AF RID: 175
			private DataColumn columnHo_Ten;

			// Token: 0x040000B0 RID: 176
			private DataColumn columnGioi_Tinh;

			// Token: 0x040000B1 RID: 177
			private DataColumn columnNam_Sinh;

			// Token: 0x040000B2 RID: 178
			private DataColumn columnDia_Chi;

			// Token: 0x040000B3 RID: 179
			private DataColumn columnNgay;

			// Token: 0x040000B4 RID: 180
			private DataColumn columnLam_Sang;

			// Token: 0x040000B5 RID: 181
			private DataColumn columnGan;

			// Token: 0x040000B6 RID: 182
			private DataColumn columnMat;

			// Token: 0x040000B7 RID: 183
			private DataColumn columnTuy;

			// Token: 0x040000B8 RID: 184
			private DataColumn columnLach;

			// Token: 0x040000B9 RID: 185
			private DataColumn columnThanP;

			// Token: 0x040000BA RID: 186
			private DataColumn columnThanT;

			// Token: 0x040000BB RID: 187
			private DataColumn columnDMCBung;

			// Token: 0x040000BC RID: 188
			private DataColumn columnTLT;

			// Token: 0x040000BD RID: 189
			private DataColumn columnTuCung;

			// Token: 0x040000BE RID: 190
			private DataColumn columnBuongTrung;

			// Token: 0x040000BF RID: 191
			private DataColumn columnBang_Quang;

			// Token: 0x040000C0 RID: 192
			private DataColumn columnKhac;

			// Token: 0x040000C1 RID: 193
			private DataColumn columnKet_Luan;

			// Token: 0x040000C2 RID: 194
			private DataColumn columnDS_Anh_KQ;

			// Token: 0x040000C3 RID: 195
			private DataColumn columnHo_Ten_BSSA;

			// Token: 0x040000C4 RID: 196
			private DataColumn columnTrinh_Do;
		}

		// Token: 0x02000043 RID: 67
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SATIMDataTable : DataTable, IEnumerable
		{
			// Token: 0x06000324 RID: 804 RVA: 0x0000C9D5 File Offset: 0x0000B9D5
			[DebuggerNonUserCode]
			public SATIMDataTable()
			{
				base.TableName = "SATIM";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000325 RID: 805 RVA: 0x0000CA04 File Offset: 0x0000BA04
			[DebuggerNonUserCode]
			internal SATIMDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x06000326 RID: 806 RVA: 0x0000CAC9 File Offset: 0x0000BAC9
			[DebuggerNonUserCode]
			protected SATIMDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x06000327 RID: 807 RVA: 0x0000CAE0 File Offset: 0x0000BAE0
			[DebuggerNonUserCode]
			public DataColumn KetQua_SATM_IdColumn
			{
				get
				{
					return this.columnKetQua_SATM_Id;
				}
			}

			// Token: 0x1700017F RID: 383
			// (get) Token: 0x06000328 RID: 808 RVA: 0x0000CAF8 File Offset: 0x0000BAF8
			[DebuggerNonUserCode]
			public DataColumn SA_TM_IdColumn
			{
				get
				{
					return this.columnSA_TM_Id;
				}
			}

			// Token: 0x17000180 RID: 384
			// (get) Token: 0x06000329 RID: 809 RVA: 0x0000CB10 File Offset: 0x0000BB10
			[DebuggerNonUserCode]
			public DataColumn BenhNhan_IdColumn
			{
				get
				{
					return this.columnBenhNhan_Id;
				}
			}

			// Token: 0x17000181 RID: 385
			// (get) Token: 0x0600032A RID: 810 RVA: 0x0000CB28 File Offset: 0x0000BB28
			[DebuggerNonUserCode]
			public DataColumn Y_Te_IdColumn
			{
				get
				{
					return this.columnY_Te_Id;
				}
			}

			// Token: 0x17000182 RID: 386
			// (get) Token: 0x0600032B RID: 811 RVA: 0x0000CB40 File Offset: 0x0000BB40
			[DebuggerNonUserCode]
			public DataColumn Ho_TenColumn
			{
				get
				{
					return this.columnHo_Ten;
				}
			}

			// Token: 0x17000183 RID: 387
			// (get) Token: 0x0600032C RID: 812 RVA: 0x0000CB58 File Offset: 0x0000BB58
			[DebuggerNonUserCode]
			public DataColumn Gioi_TinhColumn
			{
				get
				{
					return this.columnGioi_Tinh;
				}
			}

			// Token: 0x17000184 RID: 388
			// (get) Token: 0x0600032D RID: 813 RVA: 0x0000CB70 File Offset: 0x0000BB70
			[DebuggerNonUserCode]
			public DataColumn Nam_SinhColumn
			{
				get
				{
					return this.columnNam_Sinh;
				}
			}

			// Token: 0x17000185 RID: 389
			// (get) Token: 0x0600032E RID: 814 RVA: 0x0000CB88 File Offset: 0x0000BB88
			[DebuggerNonUserCode]
			public DataColumn Dia_ChiColumn
			{
				get
				{
					return this.columnDia_Chi;
				}
			}

			// Token: 0x17000186 RID: 390
			// (get) Token: 0x0600032F RID: 815 RVA: 0x0000CBA0 File Offset: 0x0000BBA0
			[DebuggerNonUserCode]
			public DataColumn Huyen_TinhColumn
			{
				get
				{
					return this.columnHuyen_Tinh;
				}
			}

			// Token: 0x17000187 RID: 391
			// (get) Token: 0x06000330 RID: 816 RVA: 0x0000CBB8 File Offset: 0x0000BBB8
			[DebuggerNonUserCode]
			public DataColumn NgayColumn
			{
				get
				{
					return this.columnNgay;
				}
			}

			// Token: 0x17000188 RID: 392
			// (get) Token: 0x06000331 RID: 817 RVA: 0x0000CBD0 File Offset: 0x0000BBD0
			[DebuggerNonUserCode]
			public DataColumn Lam_SangColumn
			{
				get
				{
					return this.columnLam_Sang;
				}
			}

			// Token: 0x17000189 RID: 393
			// (get) Token: 0x06000332 RID: 818 RVA: 0x0000CBE8 File Offset: 0x0000BBE8
			[DebuggerNonUserCode]
			public DataColumn KhacColumn
			{
				get
				{
					return this.columnKhac;
				}
			}

			// Token: 0x1700018A RID: 394
			// (get) Token: 0x06000333 RID: 819 RVA: 0x0000CC00 File Offset: 0x0000BC00
			[DebuggerNonUserCode]
			public DataColumn Ket_LuanColumn
			{
				get
				{
					return this.columnKet_Luan;
				}
			}

			// Token: 0x1700018B RID: 395
			// (get) Token: 0x06000334 RID: 820 RVA: 0x0000CC18 File Offset: 0x0000BC18
			[DebuggerNonUserCode]
			public DataColumn DS_Anh_KQColumn
			{
				get
				{
					return this.columnDS_Anh_KQ;
				}
			}

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x06000335 RID: 821 RVA: 0x0000CC30 File Offset: 0x0000BC30
			[DebuggerNonUserCode]
			public DataColumn Trinh_DoColumn
			{
				get
				{
					return this.columnTrinh_Do;
				}
			}

			// Token: 0x1700018D RID: 397
			// (get) Token: 0x06000336 RID: 822 RVA: 0x0000CC48 File Offset: 0x0000BC48
			[DebuggerNonUserCode]
			public DataColumn Ho_Ten_BSSAColumn
			{
				get
				{
					return this.columnHo_Ten_BSSA;
				}
			}

			// Token: 0x1700018E RID: 398
			// (get) Token: 0x06000337 RID: 823 RVA: 0x0000CC60 File Offset: 0x0000BC60
			[DebuggerNonUserCode]
			public DataColumn Can_NangColumn
			{
				get
				{
					return this.columnCan_Nang;
				}
			}

			// Token: 0x1700018F RID: 399
			// (get) Token: 0x06000338 RID: 824 RVA: 0x0000CC78 File Offset: 0x0000BC78
			[DebuggerNonUserCode]
			public DataColumn Chieu_CaoColumn
			{
				get
				{
					return this.columnChieu_Cao;
				}
			}

			// Token: 0x17000190 RID: 400
			// (get) Token: 0x06000339 RID: 825 RVA: 0x0000CC90 File Offset: 0x0000BC90
			[DebuggerNonUserCode]
			public DataColumn BSAColumn
			{
				get
				{
					return this.columnBSA;
				}
			}

			// Token: 0x17000191 RID: 401
			// (get) Token: 0x0600033A RID: 826 RVA: 0x0000CCA8 File Offset: 0x0000BCA8
			[DebuggerNonUserCode]
			public DataColumn Nhip_TimColumn
			{
				get
				{
					return this.columnNhip_Tim;
				}
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x0600033B RID: 827 RVA: 0x0000CCC0 File Offset: 0x0000BCC0
			[DebuggerNonUserCode]
			public DataColumn Huyet_ApColumn
			{
				get
				{
					return this.columnHuyet_Ap;
				}
			}

			// Token: 0x17000193 RID: 403
			// (get) Token: 0x0600033C RID: 828 RVA: 0x0000CCD8 File Offset: 0x0000BCD8
			[DebuggerNonUserCode]
			public DataColumn _2_TM_IVSdColumn
			{
				get
				{
					return this.column2_TM_IVSd;
				}
			}

			// Token: 0x17000194 RID: 404
			// (get) Token: 0x0600033D RID: 829 RVA: 0x0000CCF0 File Offset: 0x0000BCF0
			[DebuggerNonUserCode]
			public DataColumn _2_TM_LVDdColumn
			{
				get
				{
					return this.column2_TM_LVDd;
				}
			}

			// Token: 0x17000195 RID: 405
			// (get) Token: 0x0600033E RID: 830 RVA: 0x0000CD08 File Offset: 0x0000BD08
			[DebuggerNonUserCode]
			public DataColumn _2_TM_PLVWColumn
			{
				get
				{
					return this.column2_TM_PLVW;
				}
			}

			// Token: 0x17000196 RID: 406
			// (get) Token: 0x0600033F RID: 831 RVA: 0x0000CD20 File Offset: 0x0000BD20
			[DebuggerNonUserCode]
			public DataColumn _2_TM_IVSsColumn
			{
				get
				{
					return this.column2_TM_IVSs;
				}
			}

			// Token: 0x17000197 RID: 407
			// (get) Token: 0x06000340 RID: 832 RVA: 0x0000CD38 File Offset: 0x0000BD38
			[DebuggerNonUserCode]
			public DataColumn _2_TM_LVDsColumn
			{
				get
				{
					return this.column2_TM_LVDs;
				}
			}

			// Token: 0x17000198 RID: 408
			// (get) Token: 0x06000341 RID: 833 RVA: 0x0000CD50 File Offset: 0x0000BD50
			[DebuggerNonUserCode]
			public DataColumn _2_TM_PLVWsColumn
			{
				get
				{
					return this.column2_TM_PLVWs;
				}
			}

			// Token: 0x17000199 RID: 409
			// (get) Token: 0x06000342 RID: 834 RVA: 0x0000CD68 File Offset: 0x0000BD68
			[DebuggerNonUserCode]
			public DataColumn _2_TM_SFColumn
			{
				get
				{
					return this.column2_TM_SF;
				}
			}

			// Token: 0x1700019A RID: 410
			// (get) Token: 0x06000343 RID: 835 RVA: 0x0000CD80 File Offset: 0x0000BD80
			[DebuggerNonUserCode]
			public DataColumn _2_TM_EFColumn
			{
				get
				{
					return this.column2_TM_EF;
				}
			}

			// Token: 0x1700019B RID: 411
			// (get) Token: 0x06000344 RID: 836 RVA: 0x0000CD98 File Offset: 0x0000BD98
			[DebuggerNonUserCode]
			public DataColumn _2_TM_RVdColumn
			{
				get
				{
					return this.column2_TM_RVd;
				}
			}

			// Token: 0x1700019C RID: 412
			// (get) Token: 0x06000345 RID: 837 RVA: 0x0000CDB0 File Offset: 0x0000BDB0
			[DebuggerNonUserCode]
			public DataColumn _2_TM_AoColumn
			{
				get
				{
					return this.column2_TM_Ao;
				}
			}

			// Token: 0x1700019D RID: 413
			// (get) Token: 0x06000346 RID: 838 RVA: 0x0000CDC8 File Offset: 0x0000BDC8
			[DebuggerNonUserCode]
			public DataColumn _2_TM_LAColumn
			{
				get
				{
					return this.column2_TM_LA;
				}
			}

			// Token: 0x1700019E RID: 414
			// (get) Token: 0x06000347 RID: 839 RVA: 0x0000CDE0 File Offset: 0x0000BDE0
			[DebuggerNonUserCode]
			public DataColumn _2_TM_AVoColumn
			{
				get
				{
					return this.column2_TM_AVo;
				}
			}

			// Token: 0x1700019F RID: 415
			// (get) Token: 0x06000348 RID: 840 RVA: 0x0000CDF8 File Offset: 0x0000BDF8
			[DebuggerNonUserCode]
			public DataColumn _2_2D_SitusColumn
			{
				get
				{
					return this.column2_2D_Situs;
				}
			}

			// Token: 0x170001A0 RID: 416
			// (get) Token: 0x06000349 RID: 841 RVA: 0x0000CE10 File Offset: 0x0000BE10
			[DebuggerNonUserCode]
			public DataColumn _2_2D_VEINSColumn
			{
				get
				{
					return this.column2_2D_VEINS;
				}
			}

			// Token: 0x170001A1 RID: 417
			// (get) Token: 0x0600034A RID: 842 RVA: 0x0000CE28 File Offset: 0x0000BE28
			[DebuggerNonUserCode]
			public DataColumn _2_2D_AtriumColumn
			{
				get
				{
					return this.column2_2D_Atrium;
				}
			}

			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x0600034B RID: 843 RVA: 0x0000CE40 File Offset: 0x0000BE40
			[DebuggerNonUserCode]
			public DataColumn _2_2D_VentricleColumn
			{
				get
				{
					return this.column2_2D_Ventricle;
				}
			}

			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x0600034C RID: 844 RVA: 0x0000CE58 File Offset: 0x0000BE58
			[DebuggerNonUserCode]
			public DataColumn _2_2D_DaiDongMachColumn
			{
				get
				{
					return this.column2_2D_DaiDongMach;
				}
			}

			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x0600034D RID: 845 RVA: 0x0000CE70 File Offset: 0x0000BE70
			[DebuggerNonUserCode]
			public DataColumn _2_2D_MangNgoaiTimColumn
			{
				get
				{
					return this.column2_2D_MangNgoaiTim;
				}
			}

			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x0600034E RID: 846 RVA: 0x0000CE88 File Offset: 0x0000BE88
			[DebuggerNonUserCode]
			public DataColumn _2_2D_IVCColumn
			{
				get
				{
					return this.column2_2D_IVC;
				}
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x0600034F RID: 847 RVA: 0x0000CEA0 File Offset: 0x0000BEA0
			[DebuggerNonUserCode]
			public DataColumn _2_2D_LSVCColumn
			{
				get
				{
					return this.column2_2D_LSVC;
				}
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x06000350 RID: 848 RVA: 0x0000CEB8 File Offset: 0x0000BEB8
			[DebuggerNonUserCode]
			public DataColumn _2_2D_ValvesColumn
			{
				get
				{
					return this.column2_2D_Valves;
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x06000351 RID: 849 RVA: 0x0000CED0 File Offset: 0x0000BED0
			[DebuggerNonUserCode]
			public DataColumn _2_2D_DMCAoColumn
			{
				get
				{
					return this.column2_2D_DMCAo;
				}
			}

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x06000352 RID: 850 RVA: 0x0000CEE8 File Offset: 0x0000BEE8
			[DebuggerNonUserCode]
			public DataColumn _2_2D_DMPPAColumn
			{
				get
				{
					return this.column2_2D_DMPPA;
				}
			}

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x06000353 RID: 851 RVA: 0x0000CF00 File Offset: 0x0000BF00
			[DebuggerNonUserCode]
			public DataColumn _2_2D_AnnColumn
			{
				get
				{
					return this.column2_2D_Ann;
				}
			}

			// Token: 0x170001AB RID: 427
			// (get) Token: 0x06000354 RID: 852 RVA: 0x0000CF18 File Offset: 0x0000BF18
			[DebuggerNonUserCode]
			public DataColumn _2_2D_RSVCColumn
			{
				get
				{
					return this.column2_2D_RSVC;
				}
			}

			// Token: 0x170001AC RID: 428
			// (get) Token: 0x06000355 RID: 853 RVA: 0x0000CF30 File Offset: 0x0000BF30
			[DebuggerNonUserCode]
			public DataColumn _2_2D_PulmVeinsColumn
			{
				get
				{
					return this.column2_2D_PulmVeins;
				}
			}

			// Token: 0x170001AD RID: 429
			// (get) Token: 0x06000356 RID: 854 RVA: 0x0000CF48 File Offset: 0x0000BF48
			[DebuggerNonUserCode]
			public DataColumn _2_2D_TricAnnColumn
			{
				get
				{
					return this.column2_2D_TricAnn;
				}
			}

			// Token: 0x170001AE RID: 430
			// (get) Token: 0x06000357 RID: 855 RVA: 0x0000CF60 File Offset: 0x0000BF60
			[DebuggerNonUserCode]
			public DataColumn _2_2D_D2Column
			{
				get
				{
					return this.column2_2D_D2;
				}
			}

			// Token: 0x170001AF RID: 431
			// (get) Token: 0x06000358 RID: 856 RVA: 0x0000CF78 File Offset: 0x0000BF78
			[DebuggerNonUserCode]
			public DataColumn _2_2D_PATrunkColumn
			{
				get
				{
					return this.column2_2D_PATrunk;
				}
			}

			// Token: 0x170001B0 RID: 432
			// (get) Token: 0x06000359 RID: 857 RVA: 0x0000CF90 File Offset: 0x0000BF90
			[DebuggerNonUserCode]
			public DataColumn _2_2D_InnVeinColumn
			{
				get
				{
					return this.column2_2D_InnVein;
				}
			}

			// Token: 0x170001B1 RID: 433
			// (get) Token: 0x0600035A RID: 858 RVA: 0x0000CFA8 File Offset: 0x0000BFA8
			[DebuggerNonUserCode]
			public DataColumn _2_2D_AzygosColumn
			{
				get
				{
					return this.column2_2D_Azygos;
				}
			}

			// Token: 0x170001B2 RID: 434
			// (get) Token: 0x0600035B RID: 859 RVA: 0x0000CFC0 File Offset: 0x0000BFC0
			[DebuggerNonUserCode]
			public DataColumn _2_2D_MitAnnColumn
			{
				get
				{
					return this.column2_2D_MitAnn;
				}
			}

			// Token: 0x170001B3 RID: 435
			// (get) Token: 0x0600035C RID: 860 RVA: 0x0000CFD8 File Offset: 0x0000BFD8
			[DebuggerNonUserCode]
			public DataColumn _2_2D_LPAColumn
			{
				get
				{
					return this.column2_2D_LPA;
				}
			}

			// Token: 0x170001B4 RID: 436
			// (get) Token: 0x0600035D RID: 861 RVA: 0x0000CFF0 File Offset: 0x0000BFF0
			[DebuggerNonUserCode]
			public DataColumn _2_2D_RPAColumn
			{
				get
				{
					return this.column2_2D_RPA;
				}
			}

			// Token: 0x170001B5 RID: 437
			// (get) Token: 0x0600035E RID: 862 RVA: 0x0000D008 File Offset: 0x0000C008
			[DebuggerNonUserCode]
			public DataColumn _2_KhacColumn
			{
				get
				{
					return this.column2_Khac;
				}
			}

			// Token: 0x170001B6 RID: 438
			// (get) Token: 0x0600035F RID: 863 RVA: 0x0000D020 File Offset: 0x0000C020
			[DebuggerNonUserCode]
			public DataColumn _3_2la_VmaxColumn
			{
				get
				{
					return this.column3_2la_Vmax;
				}
			}

			// Token: 0x170001B7 RID: 439
			// (get) Token: 0x06000360 RID: 864 RVA: 0x0000D038 File Offset: 0x0000C038
			[DebuggerNonUserCode]
			public DataColumn _3_2la_MaxGdColumn
			{
				get
				{
					return this.column3_2la_MaxGd;
				}
			}

			// Token: 0x170001B8 RID: 440
			// (get) Token: 0x06000361 RID: 865 RVA: 0x0000D050 File Offset: 0x0000C050
			[DebuggerNonUserCode]
			public DataColumn _3_2la_StenosisColumn
			{
				get
				{
					return this.column3_2la_Stenosis;
				}
			}

			// Token: 0x170001B9 RID: 441
			// (get) Token: 0x06000362 RID: 866 RVA: 0x0000D068 File Offset: 0x0000C068
			[DebuggerNonUserCode]
			public DataColumn _3_2la_MeanGdColumn
			{
				get
				{
					return this.column3_2la_MeanGd;
				}
			}

			// Token: 0x170001BA RID: 442
			// (get) Token: 0x06000363 RID: 867 RVA: 0x0000D080 File Offset: 0x0000C080
			[DebuggerNonUserCode]
			public DataColumn _3_2la_PHTColumn
			{
				get
				{
					return this.column3_2la_PHT;
				}
			}

			// Token: 0x170001BB RID: 443
			// (get) Token: 0x06000364 RID: 868 RVA: 0x0000D098 File Offset: 0x0000C098
			[DebuggerNonUserCode]
			public DataColumn _3_2la_HoColumn
			{
				get
				{
					return this.column3_2la_Ho;
				}
			}

			// Token: 0x170001BC RID: 444
			// (get) Token: 0x06000365 RID: 869 RVA: 0x0000D0B0 File Offset: 0x0000C0B0
			[DebuggerNonUserCode]
			public DataColumn _3_2la_DegreeColumn
			{
				get
				{
					return this.column3_2la_Degree;
				}
			}

			// Token: 0x170001BD RID: 445
			// (get) Token: 0x06000366 RID: 870 RVA: 0x0000D0C8 File Offset: 0x0000C0C8
			[DebuggerNonUserCode]
			public DataColumn _3_DMC_VmaxColumn
			{
				get
				{
					return this.column3_DMC_Vmax;
				}
			}

			// Token: 0x170001BE RID: 446
			// (get) Token: 0x06000367 RID: 871 RVA: 0x0000D0E0 File Offset: 0x0000C0E0
			[DebuggerNonUserCode]
			public DataColumn _3_DMC_MaxGdColumn
			{
				get
				{
					return this.column3_DMC_MaxGd;
				}
			}

			// Token: 0x170001BF RID: 447
			// (get) Token: 0x06000368 RID: 872 RVA: 0x0000D0F8 File Offset: 0x0000C0F8
			[DebuggerNonUserCode]
			public DataColumn _3_DMC_StenosisColumn
			{
				get
				{
					return this.column3_DMC_Stenosis;
				}
			}

			// Token: 0x170001C0 RID: 448
			// (get) Token: 0x06000369 RID: 873 RVA: 0x0000D110 File Offset: 0x0000C110
			[DebuggerNonUserCode]
			public DataColumn _3_DMC_MeanGdColumn
			{
				get
				{
					return this.column3_DMC_MeanGd;
				}
			}

			// Token: 0x170001C1 RID: 449
			// (get) Token: 0x0600036A RID: 874 RVA: 0x0000D128 File Offset: 0x0000C128
			[DebuggerNonUserCode]
			public DataColumn _3_DMC_EdcColumn
			{
				get
				{
					return this.column3_DMC_Edc;
				}
			}

			// Token: 0x170001C2 RID: 450
			// (get) Token: 0x0600036B RID: 875 RVA: 0x0000D140 File Offset: 0x0000C140
			[DebuggerNonUserCode]
			public DataColumn _3_DMC_HoColumn
			{
				get
				{
					return this.column3_DMC_Ho;
				}
			}

			// Token: 0x170001C3 RID: 451
			// (get) Token: 0x0600036C RID: 876 RVA: 0x0000D158 File Offset: 0x0000C158
			[DebuggerNonUserCode]
			public DataColumn _3_DMC_PHTColumn
			{
				get
				{
					return this.column3_DMC_PHT;
				}
			}

			// Token: 0x170001C4 RID: 452
			// (get) Token: 0x0600036D RID: 877 RVA: 0x0000D170 File Offset: 0x0000C170
			[DebuggerNonUserCode]
			public DataColumn _3_DMC_EDTDColumn
			{
				get
				{
					return this.column3_DMC_EDTD;
				}
			}

			// Token: 0x170001C5 RID: 453
			// (get) Token: 0x0600036E RID: 878 RVA: 0x0000D188 File Offset: 0x0000C188
			[DebuggerNonUserCode]
			public DataColumn _3_DMC_DegreeColumn
			{
				get
				{
					return this.column3_DMC_Degree;
				}
			}

			// Token: 0x170001C6 RID: 454
			// (get) Token: 0x0600036F RID: 879 RVA: 0x0000D1A0 File Offset: 0x0000C1A0
			[DebuggerNonUserCode]
			public DataColumn _3_DMC_DFOColumn
			{
				get
				{
					return this.column3_DMC_DFO;
				}
			}

			// Token: 0x170001C7 RID: 455
			// (get) Token: 0x06000370 RID: 880 RVA: 0x0000D1B8 File Offset: 0x0000C1B8
			[DebuggerNonUserCode]
			public DataColumn _3_DMC_DoLanColumn
			{
				get
				{
					return this.column3_DMC_DoLan;
				}
			}

			// Token: 0x170001C8 RID: 456
			// (get) Token: 0x06000371 RID: 881 RVA: 0x0000D1D0 File Offset: 0x0000C1D0
			[DebuggerNonUserCode]
			public DataColumn _3_3la_VmaxColumn
			{
				get
				{
					return this.column3_3la_Vmax;
				}
			}

			// Token: 0x170001C9 RID: 457
			// (get) Token: 0x06000372 RID: 882 RVA: 0x0000D1E8 File Offset: 0x0000C1E8
			[DebuggerNonUserCode]
			public DataColumn _3_3la_HoColumn
			{
				get
				{
					return this.column3_3la_Ho;
				}
			}

			// Token: 0x170001CA RID: 458
			// (get) Token: 0x06000373 RID: 883 RVA: 0x0000D200 File Offset: 0x0000C200
			[DebuggerNonUserCode]
			public DataColumn _3_3la_MaxGdColumn
			{
				get
				{
					return this.column3_3la_MaxGd;
				}
			}

			// Token: 0x170001CB RID: 459
			// (get) Token: 0x06000374 RID: 884 RVA: 0x0000D218 File Offset: 0x0000C218
			[DebuggerNonUserCode]
			public DataColumn _3_3la_ALDMPTTColumn
			{
				get
				{
					return this.column3_3la_ALDMPTT;
				}
			}

			// Token: 0x170001CC RID: 460
			// (get) Token: 0x06000375 RID: 885 RVA: 0x0000D230 File Offset: 0x0000C230
			[DebuggerNonUserCode]
			public DataColumn _3_3la_MeanGdColumn
			{
				get
				{
					return this.column3_3la_MeanGd;
				}
			}

			// Token: 0x170001CD RID: 461
			// (get) Token: 0x06000376 RID: 886 RVA: 0x0000D248 File Offset: 0x0000C248
			[DebuggerNonUserCode]
			public DataColumn _3_DMP_VmaxColumn
			{
				get
				{
					return this.column3_DMP_Vmax;
				}
			}

			// Token: 0x170001CE RID: 462
			// (get) Token: 0x06000377 RID: 887 RVA: 0x0000D260 File Offset: 0x0000C260
			[DebuggerNonUserCode]
			public DataColumn _3_DMP_MaxGdColumn
			{
				get
				{
					return this.column3_DMP_MaxGd;
				}
			}

			// Token: 0x170001CF RID: 463
			// (get) Token: 0x06000378 RID: 888 RVA: 0x0000D278 File Offset: 0x0000C278
			[DebuggerNonUserCode]
			public DataColumn _3_DMP_HoDMPColumn
			{
				get
				{
					return this.column3_DMP_HoDMP;
				}
			}

			// Token: 0x170001D0 RID: 464
			// (get) Token: 0x06000379 RID: 889 RVA: 0x0000D290 File Offset: 0x0000C290
			[DebuggerNonUserCode]
			public DataColumn _3_DMP_QpQsColumn
			{
				get
				{
					return this.column3_DMP_QpQs;
				}
			}

			// Token: 0x170001D1 RID: 465
			// (get) Token: 0x0600037A RID: 890 RVA: 0x0000D2A8 File Offset: 0x0000C2A8
			[DebuggerNonUserCode]
			public DataColumn _3_DMP_MeanGdColumn
			{
				get
				{
					return this.column3_DMP_MeanGd;
				}
			}

			// Token: 0x170001D2 RID: 466
			// (get) Token: 0x0600037B RID: 891 RVA: 0x0000D2C0 File Offset: 0x0000C2C0
			[DebuggerNonUserCode]
			public DataColumn _3_DMP_ALDMPTBColumn
			{
				get
				{
					return this.column3_DMP_ALDMPTB;
				}
			}

			// Token: 0x170001D3 RID: 467
			// (get) Token: 0x0600037C RID: 892 RVA: 0x0000D2D8 File Offset: 0x0000C2D8
			[DebuggerNonUserCode]
			public DataColumn _3_DMP_ALDMPTTrColumn
			{
				get
				{
					return this.column3_DMP_ALDMPTTr;
				}
			}

			// Token: 0x170001D4 RID: 468
			// (get) Token: 0x0600037D RID: 893 RVA: 0x0000D2F0 File Offset: 0x0000C2F0
			[DebuggerNonUserCode]
			public DataColumn _3_KhacColumn
			{
				get
				{
					return this.column3_Khac;
				}
			}

			// Token: 0x170001D5 RID: 469
			// (get) Token: 0x0600037E RID: 894 RVA: 0x0000D308 File Offset: 0x0000C308
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x170001D6 RID: 470
			[DebuggerNonUserCode]
			public dsKetQuaSA.SATIMRow this[int index]
			{
				get
				{
					return (dsKetQuaSA.SATIMRow)base.Rows[index];
				}
			}

			// Token: 0x14000015 RID: 21
			// (add) Token: 0x06000380 RID: 896 RVA: 0x0000D34B File Offset: 0x0000C34B
			// (remove) Token: 0x06000381 RID: 897 RVA: 0x0000D364 File Offset: 0x0000C364
			public event dsKetQuaSA.SATIMRowChangeEventHandler SATIMRowChanging;

			// Token: 0x14000016 RID: 22
			// (add) Token: 0x06000382 RID: 898 RVA: 0x0000D37D File Offset: 0x0000C37D
			// (remove) Token: 0x06000383 RID: 899 RVA: 0x0000D396 File Offset: 0x0000C396
			public event dsKetQuaSA.SATIMRowChangeEventHandler SATIMRowChanged;

			// Token: 0x14000017 RID: 23
			// (add) Token: 0x06000384 RID: 900 RVA: 0x0000D3AF File Offset: 0x0000C3AF
			// (remove) Token: 0x06000385 RID: 901 RVA: 0x0000D3C8 File Offset: 0x0000C3C8
			public event dsKetQuaSA.SATIMRowChangeEventHandler SATIMRowDeleting;

			// Token: 0x14000018 RID: 24
			// (add) Token: 0x06000386 RID: 902 RVA: 0x0000D3E1 File Offset: 0x0000C3E1
			// (remove) Token: 0x06000387 RID: 903 RVA: 0x0000D3FA File Offset: 0x0000C3FA
			public event dsKetQuaSA.SATIMRowChangeEventHandler SATIMRowDeleted;

			// Token: 0x06000388 RID: 904 RVA: 0x0000D413 File Offset: 0x0000C413
			[DebuggerNonUserCode]
			public void AddSATIMRow(dsKetQuaSA.SATIMRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x06000389 RID: 905 RVA: 0x0000D424 File Offset: 0x0000C424
			[DebuggerNonUserCode]
			public dsKetQuaSA.SATIMRow AddSATIMRow(uint KetQua_SATM_Id, string SA_TM_Id, string BenhNhan_Id, string Y_Te_Id, string Ho_Ten, string Gioi_Tinh, string Nam_Sinh, string Dia_Chi, string Huyen_Tinh, string Ngay, string Lam_Sang, string Khac, string Ket_Luan, string DS_Anh_KQ, string Trinh_Do, string Ho_Ten_BSSA, string Can_Nang, string Chieu_Cao, string BSA, string Nhip_Tim, string Huyet_Ap, string _2_TM_IVSd, string _2_TM_LVDd, string _2_TM_PLVW, string _2_TM_IVSs, string _2_TM_LVDs, string _2_TM_PLVWs, string _2_TM_SF, string _2_TM_EF, string _2_TM_RVd, string _2_TM_Ao, string _2_TM_LA, string _2_TM_AVo, string _2_2D_Situs, string _2_2D_VEINS, string _2_2D_Atrium, string _2_2D_Ventricle, string _2_2D_DaiDongMach, string _2_2D_MangNgoaiTim, string _2_2D_IVC, string _2_2D_LSVC, string _2_2D_Valves, string _2_2D_DMCAo, string _2_2D_DMPPA, string _2_2D_Ann, string _2_2D_RSVC, string _2_2D_PulmVeins, string _2_2D_TricAnn, string _2_2D_D2, string _2_2D_PATrunk, string _2_2D_InnVein, string _2_2D_Azygos, string _2_2D_MitAnn, string _2_2D_LPA, string _2_2D_RPA, string _2_Khac, string _3_2la_Vmax, string _3_2la_MaxGd, string _3_2la_Stenosis, string _3_2la_MeanGd, string _3_2la_PHT, string _3_2la_Ho, string _3_2la_Degree, string _3_DMC_Vmax, string _3_DMC_MaxGd, string _3_DMC_Stenosis, string _3_DMC_MeanGd, string _3_DMC_Edc, string _3_DMC_Ho, string _3_DMC_PHT, string _3_DMC_EDTD, string _3_DMC_Degree, string _3_DMC_DFO, string _3_DMC_DoLan, string _3_3la_Vmax, string _3_3la_Ho, string _3_3la_MaxGd, string _3_3la_ALDMPTT, string _3_3la_MeanGd, string _3_DMP_Vmax, string _3_DMP_MaxGd, string _3_DMP_HoDMP, string _3_DMP_QpQs, string _3_DMP_MeanGd, string _3_DMP_ALDMPTB, string _3_DMP_ALDMPTTr, string _3_Khac)
			{
				dsKetQuaSA.SATIMRow satimrow = (dsKetQuaSA.SATIMRow)base.NewRow();
				satimrow.ItemArray = new object[]
				{
					KetQua_SATM_Id,
					SA_TM_Id,
					BenhNhan_Id,
					Y_Te_Id,
					Ho_Ten,
					Gioi_Tinh,
					Nam_Sinh,
					Dia_Chi,
					Huyen_Tinh,
					Ngay,
					Lam_Sang,
					Khac,
					Ket_Luan,
					DS_Anh_KQ,
					Trinh_Do,
					Ho_Ten_BSSA,
					Can_Nang,
					Chieu_Cao,
					BSA,
					Nhip_Tim,
					Huyet_Ap,
					_2_TM_IVSd,
					_2_TM_LVDd,
					_2_TM_PLVW,
					_2_TM_IVSs,
					_2_TM_LVDs,
					_2_TM_PLVWs,
					_2_TM_SF,
					_2_TM_EF,
					_2_TM_RVd,
					_2_TM_Ao,
					_2_TM_LA,
					_2_TM_AVo,
					_2_2D_Situs,
					_2_2D_VEINS,
					_2_2D_Atrium,
					_2_2D_Ventricle,
					_2_2D_DaiDongMach,
					_2_2D_MangNgoaiTim,
					_2_2D_IVC,
					_2_2D_LSVC,
					_2_2D_Valves,
					_2_2D_DMCAo,
					_2_2D_DMPPA,
					_2_2D_Ann,
					_2_2D_RSVC,
					_2_2D_PulmVeins,
					_2_2D_TricAnn,
					_2_2D_D2,
					_2_2D_PATrunk,
					_2_2D_InnVein,
					_2_2D_Azygos,
					_2_2D_MitAnn,
					_2_2D_LPA,
					_2_2D_RPA,
					_2_Khac,
					_3_2la_Vmax,
					_3_2la_MaxGd,
					_3_2la_Stenosis,
					_3_2la_MeanGd,
					_3_2la_PHT,
					_3_2la_Ho,
					_3_2la_Degree,
					_3_DMC_Vmax,
					_3_DMC_MaxGd,
					_3_DMC_Stenosis,
					_3_DMC_MeanGd,
					_3_DMC_Edc,
					_3_DMC_Ho,
					_3_DMC_PHT,
					_3_DMC_EDTD,
					_3_DMC_Degree,
					_3_DMC_DFO,
					_3_DMC_DoLan,
					_3_3la_Vmax,
					_3_3la_Ho,
					_3_3la_MaxGd,
					_3_3la_ALDMPTT,
					_3_3la_MeanGd,
					_3_DMP_Vmax,
					_3_DMP_MaxGd,
					_3_DMP_HoDMP,
					_3_DMP_QpQs,
					_3_DMP_MeanGd,
					_3_DMP_ALDMPTB,
					_3_DMP_ALDMPTTr,
					_3_Khac
				};
				base.Rows.Add(satimrow);
				return satimrow;
			}

			// Token: 0x0600038A RID: 906 RVA: 0x0000D664 File Offset: 0x0000C664
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x0600038B RID: 907 RVA: 0x0000D684 File Offset: 0x0000C684
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				dsKetQuaSA.SATIMDataTable satimdataTable = (dsKetQuaSA.SATIMDataTable)base.Clone();
				satimdataTable.InitVars();
				return satimdataTable;
			}

			// Token: 0x0600038C RID: 908 RVA: 0x0000D6AC File Offset: 0x0000C6AC
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new dsKetQuaSA.SATIMDataTable();
			}

			// Token: 0x0600038D RID: 909 RVA: 0x0000D6C4 File Offset: 0x0000C6C4
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnKetQua_SATM_Id = base.Columns["KetQua_SATM_Id"];
				this.columnSA_TM_Id = base.Columns["SA_TM_Id"];
				this.columnBenhNhan_Id = base.Columns["BenhNhan_Id"];
				this.columnY_Te_Id = base.Columns["Y_Te_Id"];
				this.columnHo_Ten = base.Columns["Ho_Ten"];
				this.columnGioi_Tinh = base.Columns["Gioi_Tinh"];
				this.columnNam_Sinh = base.Columns["Nam_Sinh"];
				this.columnDia_Chi = base.Columns["Dia_Chi"];
				this.columnHuyen_Tinh = base.Columns["Huyen_Tinh"];
				this.columnNgay = base.Columns["Ngay"];
				this.columnLam_Sang = base.Columns["Lam_Sang"];
				this.columnKhac = base.Columns["Khac"];
				this.columnKet_Luan = base.Columns["Ket_Luan"];
				this.columnDS_Anh_KQ = base.Columns["DS_Anh_KQ"];
				this.columnTrinh_Do = base.Columns["Trinh_Do"];
				this.columnHo_Ten_BSSA = base.Columns["Ho_Ten_BSSA"];
				this.columnCan_Nang = base.Columns["Can_Nang"];
				this.columnChieu_Cao = base.Columns["Chieu_Cao"];
				this.columnBSA = base.Columns["BSA"];
				this.columnNhip_Tim = base.Columns["Nhip_Tim"];
				this.columnHuyet_Ap = base.Columns["Huyet_Ap"];
				this.column2_TM_IVSd = base.Columns["2_TM_IVSd"];
				this.column2_TM_LVDd = base.Columns["2_TM_LVDd"];
				this.column2_TM_PLVW = base.Columns["2_TM_PLVW"];
				this.column2_TM_IVSs = base.Columns["2_TM_IVSs"];
				this.column2_TM_LVDs = base.Columns["2_TM_LVDs"];
				this.column2_TM_PLVWs = base.Columns["2_TM_PLVWs"];
				this.column2_TM_SF = base.Columns["2_TM_SF"];
				this.column2_TM_EF = base.Columns["2_TM_EF"];
				this.column2_TM_RVd = base.Columns["2_TM_RVd"];
				this.column2_TM_Ao = base.Columns["2_TM_Ao"];
				this.column2_TM_LA = base.Columns["2_TM_LA"];
				this.column2_TM_AVo = base.Columns["2_TM_AVo"];
				this.column2_2D_Situs = base.Columns["2_2D_Situs"];
				this.column2_2D_VEINS = base.Columns["2_2D_VEINS"];
				this.column2_2D_Atrium = base.Columns["2_2D_Atrium"];
				this.column2_2D_Ventricle = base.Columns["2_2D_Ventricle"];
				this.column2_2D_DaiDongMach = base.Columns["2_2D_DaiDongMach"];
				this.column2_2D_MangNgoaiTim = base.Columns["2_2D_MangNgoaiTim"];
				this.column2_2D_IVC = base.Columns["2_2D_IVC"];
				this.column2_2D_LSVC = base.Columns["2_2D_LSVC"];
				this.column2_2D_Valves = base.Columns["2_2D_Valves"];
				this.column2_2D_DMCAo = base.Columns["2_2D_DMCAo"];
				this.column2_2D_DMPPA = base.Columns["2_2D_DMPPA"];
				this.column2_2D_Ann = base.Columns["2_2D_Ann"];
				this.column2_2D_RSVC = base.Columns["2_2D_RSVC"];
				this.column2_2D_PulmVeins = base.Columns["2_2D_PulmVeins"];
				this.column2_2D_TricAnn = base.Columns["2_2D_TricAnn"];
				this.column2_2D_D2 = base.Columns["2_2D_D2"];
				this.column2_2D_PATrunk = base.Columns["2_2D_PATrunk"];
				this.column2_2D_InnVein = base.Columns["2_2D_InnVein"];
				this.column2_2D_Azygos = base.Columns["2_2D_Azygos"];
				this.column2_2D_MitAnn = base.Columns["2_2D_MitAnn"];
				this.column2_2D_LPA = base.Columns["2_2D_LPA"];
				this.column2_2D_RPA = base.Columns["2_2D_RPA"];
				this.column2_Khac = base.Columns["2_Khac"];
				this.column3_2la_Vmax = base.Columns["3_2la_Vmax"];
				this.column3_2la_MaxGd = base.Columns["3_2la_MaxGd"];
				this.column3_2la_Stenosis = base.Columns["3_2la_Stenosis"];
				this.column3_2la_MeanGd = base.Columns["3_2la_MeanGd"];
				this.column3_2la_PHT = base.Columns["3_2la_PHT"];
				this.column3_2la_Ho = base.Columns["3_2la_Ho"];
				this.column3_2la_Degree = base.Columns["3_2la_Degree"];
				this.column3_DMC_Vmax = base.Columns["3_DMC_Vmax"];
				this.column3_DMC_MaxGd = base.Columns["3_DMC_MaxGd"];
				this.column3_DMC_Stenosis = base.Columns["3_DMC_Stenosis"];
				this.column3_DMC_MeanGd = base.Columns["3_DMC_MeanGd"];
				this.column3_DMC_Edc = base.Columns["3_DMC_Edc"];
				this.column3_DMC_Ho = base.Columns["3_DMC_Ho"];
				this.column3_DMC_PHT = base.Columns["3_DMC_PHT"];
				this.column3_DMC_EDTD = base.Columns["3_DMC_EDTD"];
				this.column3_DMC_Degree = base.Columns["3_DMC_Degree"];
				this.column3_DMC_DFO = base.Columns["3_DMC_DFO"];
				this.column3_DMC_DoLan = base.Columns["3_DMC_DoLan"];
				this.column3_3la_Vmax = base.Columns["3_3la_Vmax"];
				this.column3_3la_Ho = base.Columns["3_3la_Ho"];
				this.column3_3la_MaxGd = base.Columns["3_3la_MaxGd"];
				this.column3_3la_ALDMPTT = base.Columns["3_3la_ALDMPTT"];
				this.column3_3la_MeanGd = base.Columns["3_3la_MeanGd"];
				this.column3_DMP_Vmax = base.Columns["3_DMP_Vmax"];
				this.column3_DMP_MaxGd = base.Columns["3_DMP_MaxGd"];
				this.column3_DMP_HoDMP = base.Columns["3_DMP_HoDMP"];
				this.column3_DMP_QpQs = base.Columns["3_DMP_QpQs"];
				this.column3_DMP_MeanGd = base.Columns["3_DMP_MeanGd"];
				this.column3_DMP_ALDMPTB = base.Columns["3_DMP_ALDMPTB"];
				this.column3_DMP_ALDMPTTr = base.Columns["3_DMP_ALDMPTTr"];
				this.column3_Khac = base.Columns["3_Khac"];
			}

			// Token: 0x0600038E RID: 910 RVA: 0x0000DE4C File Offset: 0x0000CE4C
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnKetQua_SATM_Id = new DataColumn("KetQua_SATM_Id", typeof(uint), null, MappingType.Element);
				base.Columns.Add(this.columnKetQua_SATM_Id);
				this.columnSA_TM_Id = new DataColumn("SA_TM_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSA_TM_Id);
				this.columnBenhNhan_Id = new DataColumn("BenhNhan_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBenhNhan_Id);
				this.columnY_Te_Id = new DataColumn("Y_Te_Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnY_Te_Id);
				this.columnHo_Ten = new DataColumn("Ho_Ten", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHo_Ten);
				this.columnGioi_Tinh = new DataColumn("Gioi_Tinh", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGioi_Tinh);
				this.columnNam_Sinh = new DataColumn("Nam_Sinh", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNam_Sinh);
				this.columnDia_Chi = new DataColumn("Dia_Chi", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDia_Chi);
				this.columnHuyen_Tinh = new DataColumn("Huyen_Tinh", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHuyen_Tinh);
				this.columnNgay = new DataColumn("Ngay", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNgay);
				this.columnLam_Sang = new DataColumn("Lam_Sang", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnLam_Sang);
				this.columnKhac = new DataColumn("Khac", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKhac);
				this.columnKet_Luan = new DataColumn("Ket_Luan", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKet_Luan);
				this.columnDS_Anh_KQ = new DataColumn("DS_Anh_KQ", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDS_Anh_KQ);
				this.columnTrinh_Do = new DataColumn("Trinh_Do", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTrinh_Do);
				this.columnHo_Ten_BSSA = new DataColumn("Ho_Ten_BSSA", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHo_Ten_BSSA);
				this.columnCan_Nang = new DataColumn("Can_Nang", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCan_Nang);
				this.columnChieu_Cao = new DataColumn("Chieu_Cao", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnChieu_Cao);
				this.columnBSA = new DataColumn("BSA", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBSA);
				this.columnNhip_Tim = new DataColumn("Nhip_Tim", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNhip_Tim);
				this.columnHuyet_Ap = new DataColumn("Huyet_Ap", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHuyet_Ap);
				this.column2_TM_IVSd = new DataColumn("2_TM_IVSd", typeof(string), null, MappingType.Element);
				this.column2_TM_IVSd.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_TM_IVSd");
				this.column2_TM_IVSd.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_TM_IVSdColumn");
				this.column2_TM_IVSd.ExtendedProperties.Add("Generator_UserColumnName", "2_TM_IVSd");
				base.Columns.Add(this.column2_TM_IVSd);
				this.column2_TM_LVDd = new DataColumn("2_TM_LVDd", typeof(string), null, MappingType.Element);
				this.column2_TM_LVDd.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_TM_LVDd");
				this.column2_TM_LVDd.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_TM_LVDdColumn");
				this.column2_TM_LVDd.ExtendedProperties.Add("Generator_UserColumnName", "2_TM_LVDd");
				base.Columns.Add(this.column2_TM_LVDd);
				this.column2_TM_PLVW = new DataColumn("2_TM_PLVW", typeof(string), null, MappingType.Element);
				this.column2_TM_PLVW.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_TM_PLVW");
				this.column2_TM_PLVW.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_TM_PLVWColumn");
				this.column2_TM_PLVW.ExtendedProperties.Add("Generator_UserColumnName", "2_TM_PLVW");
				base.Columns.Add(this.column2_TM_PLVW);
				this.column2_TM_IVSs = new DataColumn("2_TM_IVSs", typeof(string), null, MappingType.Element);
				this.column2_TM_IVSs.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_TM_IVSs");
				this.column2_TM_IVSs.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_TM_IVSsColumn");
				this.column2_TM_IVSs.ExtendedProperties.Add("Generator_UserColumnName", "2_TM_IVSs");
				base.Columns.Add(this.column2_TM_IVSs);
				this.column2_TM_LVDs = new DataColumn("2_TM_LVDs", typeof(string), null, MappingType.Element);
				this.column2_TM_LVDs.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_TM_LVDs");
				this.column2_TM_LVDs.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_TM_LVDsColumn");
				this.column2_TM_LVDs.ExtendedProperties.Add("Generator_UserColumnName", "2_TM_LVDs");
				base.Columns.Add(this.column2_TM_LVDs);
				this.column2_TM_PLVWs = new DataColumn("2_TM_PLVWs", typeof(string), null, MappingType.Element);
				this.column2_TM_PLVWs.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_TM_PLVWs");
				this.column2_TM_PLVWs.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_TM_PLVWsColumn");
				this.column2_TM_PLVWs.ExtendedProperties.Add("Generator_UserColumnName", "2_TM_PLVWs");
				base.Columns.Add(this.column2_TM_PLVWs);
				this.column2_TM_SF = new DataColumn("2_TM_SF", typeof(string), null, MappingType.Element);
				this.column2_TM_SF.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_TM_SF");
				this.column2_TM_SF.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_TM_SFColumn");
				this.column2_TM_SF.ExtendedProperties.Add("Generator_UserColumnName", "2_TM_SF");
				base.Columns.Add(this.column2_TM_SF);
				this.column2_TM_EF = new DataColumn("2_TM_EF", typeof(string), null, MappingType.Element);
				this.column2_TM_EF.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_TM_EF");
				this.column2_TM_EF.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_TM_EFColumn");
				this.column2_TM_EF.ExtendedProperties.Add("Generator_UserColumnName", "2_TM_EF");
				base.Columns.Add(this.column2_TM_EF);
				this.column2_TM_RVd = new DataColumn("2_TM_RVd", typeof(string), null, MappingType.Element);
				this.column2_TM_RVd.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_TM_RVd");
				this.column2_TM_RVd.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_TM_RVdColumn");
				this.column2_TM_RVd.ExtendedProperties.Add("Generator_UserColumnName", "2_TM_RVd");
				base.Columns.Add(this.column2_TM_RVd);
				this.column2_TM_Ao = new DataColumn("2_TM_Ao", typeof(string), null, MappingType.Element);
				this.column2_TM_Ao.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_TM_Ao");
				this.column2_TM_Ao.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_TM_AoColumn");
				this.column2_TM_Ao.ExtendedProperties.Add("Generator_UserColumnName", "2_TM_Ao");
				base.Columns.Add(this.column2_TM_Ao);
				this.column2_TM_LA = new DataColumn("2_TM_LA", typeof(string), null, MappingType.Element);
				this.column2_TM_LA.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_TM_LA");
				this.column2_TM_LA.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_TM_LAColumn");
				this.column2_TM_LA.ExtendedProperties.Add("Generator_UserColumnName", "2_TM_LA");
				base.Columns.Add(this.column2_TM_LA);
				this.column2_TM_AVo = new DataColumn("2_TM_AVo", typeof(string), null, MappingType.Element);
				this.column2_TM_AVo.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_TM_AVo");
				this.column2_TM_AVo.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_TM_AVoColumn");
				this.column2_TM_AVo.ExtendedProperties.Add("Generator_UserColumnName", "2_TM_AVo");
				base.Columns.Add(this.column2_TM_AVo);
				this.column2_2D_Situs = new DataColumn("2_2D_Situs", typeof(string), null, MappingType.Element);
				this.column2_2D_Situs.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_Situs");
				this.column2_2D_Situs.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_SitusColumn");
				this.column2_2D_Situs.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_Situs");
				base.Columns.Add(this.column2_2D_Situs);
				this.column2_2D_VEINS = new DataColumn("2_2D_VEINS", typeof(string), null, MappingType.Element);
				this.column2_2D_VEINS.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_VEINS");
				this.column2_2D_VEINS.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_VEINSColumn");
				this.column2_2D_VEINS.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_VEINS");
				base.Columns.Add(this.column2_2D_VEINS);
				this.column2_2D_Atrium = new DataColumn("2_2D_Atrium", typeof(string), null, MappingType.Element);
				this.column2_2D_Atrium.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_Atrium");
				this.column2_2D_Atrium.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_AtriumColumn");
				this.column2_2D_Atrium.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_Atrium");
				base.Columns.Add(this.column2_2D_Atrium);
				this.column2_2D_Ventricle = new DataColumn("2_2D_Ventricle", typeof(string), null, MappingType.Element);
				this.column2_2D_Ventricle.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_Ventricle");
				this.column2_2D_Ventricle.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_VentricleColumn");
				this.column2_2D_Ventricle.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_Ventricle");
				base.Columns.Add(this.column2_2D_Ventricle);
				this.column2_2D_DaiDongMach = new DataColumn("2_2D_DaiDongMach", typeof(string), null, MappingType.Element);
				this.column2_2D_DaiDongMach.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_DaiDongMach");
				this.column2_2D_DaiDongMach.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_DaiDongMachColumn");
				this.column2_2D_DaiDongMach.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_DaiDongMach");
				base.Columns.Add(this.column2_2D_DaiDongMach);
				this.column2_2D_MangNgoaiTim = new DataColumn("2_2D_MangNgoaiTim", typeof(string), null, MappingType.Element);
				this.column2_2D_MangNgoaiTim.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_MangNgoaiTim");
				this.column2_2D_MangNgoaiTim.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_MangNgoaiTimColumn");
				this.column2_2D_MangNgoaiTim.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_MangNgoaiTim");
				base.Columns.Add(this.column2_2D_MangNgoaiTim);
				this.column2_2D_IVC = new DataColumn("2_2D_IVC", typeof(string), null, MappingType.Element);
				this.column2_2D_IVC.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_IVC");
				this.column2_2D_IVC.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_IVCColumn");
				this.column2_2D_IVC.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_IVC");
				base.Columns.Add(this.column2_2D_IVC);
				this.column2_2D_LSVC = new DataColumn("2_2D_LSVC", typeof(string), null, MappingType.Element);
				this.column2_2D_LSVC.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_LSVC");
				this.column2_2D_LSVC.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_LSVCColumn");
				this.column2_2D_LSVC.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_LSVC");
				base.Columns.Add(this.column2_2D_LSVC);
				this.column2_2D_Valves = new DataColumn("2_2D_Valves", typeof(string), null, MappingType.Element);
				this.column2_2D_Valves.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_Valves");
				this.column2_2D_Valves.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_ValvesColumn");
				this.column2_2D_Valves.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_Valves");
				base.Columns.Add(this.column2_2D_Valves);
				this.column2_2D_DMCAo = new DataColumn("2_2D_DMCAo", typeof(string), null, MappingType.Element);
				this.column2_2D_DMCAo.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_DMCAo");
				this.column2_2D_DMCAo.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_DMCAoColumn");
				this.column2_2D_DMCAo.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_DMCAo");
				base.Columns.Add(this.column2_2D_DMCAo);
				this.column2_2D_DMPPA = new DataColumn("2_2D_DMPPA", typeof(string), null, MappingType.Element);
				this.column2_2D_DMPPA.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_DMPPA");
				this.column2_2D_DMPPA.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_DMPPAColumn");
				this.column2_2D_DMPPA.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_DMPPA");
				base.Columns.Add(this.column2_2D_DMPPA);
				this.column2_2D_Ann = new DataColumn("2_2D_Ann", typeof(string), null, MappingType.Element);
				this.column2_2D_Ann.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_Ann");
				this.column2_2D_Ann.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_AnnColumn");
				this.column2_2D_Ann.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_Ann");
				base.Columns.Add(this.column2_2D_Ann);
				this.column2_2D_RSVC = new DataColumn("2_2D_RSVC", typeof(string), null, MappingType.Element);
				this.column2_2D_RSVC.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_RSVC");
				this.column2_2D_RSVC.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_RSVCColumn");
				this.column2_2D_RSVC.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_RSVC");
				base.Columns.Add(this.column2_2D_RSVC);
				this.column2_2D_PulmVeins = new DataColumn("2_2D_PulmVeins", typeof(string), null, MappingType.Element);
				this.column2_2D_PulmVeins.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_PulmVeins");
				this.column2_2D_PulmVeins.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_PulmVeinsColumn");
				this.column2_2D_PulmVeins.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_PulmVeins");
				base.Columns.Add(this.column2_2D_PulmVeins);
				this.column2_2D_TricAnn = new DataColumn("2_2D_TricAnn", typeof(string), null, MappingType.Element);
				this.column2_2D_TricAnn.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_TricAnn");
				this.column2_2D_TricAnn.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_TricAnnColumn");
				this.column2_2D_TricAnn.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_TricAnn");
				base.Columns.Add(this.column2_2D_TricAnn);
				this.column2_2D_D2 = new DataColumn("2_2D_D2", typeof(string), null, MappingType.Element);
				this.column2_2D_D2.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_D2");
				this.column2_2D_D2.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_D2Column");
				this.column2_2D_D2.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_D2");
				base.Columns.Add(this.column2_2D_D2);
				this.column2_2D_PATrunk = new DataColumn("2_2D_PATrunk", typeof(string), null, MappingType.Element);
				this.column2_2D_PATrunk.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_PATrunk");
				this.column2_2D_PATrunk.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_PATrunkColumn");
				this.column2_2D_PATrunk.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_PATrunk");
				base.Columns.Add(this.column2_2D_PATrunk);
				this.column2_2D_InnVein = new DataColumn("2_2D_InnVein", typeof(string), null, MappingType.Element);
				this.column2_2D_InnVein.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_InnVein");
				this.column2_2D_InnVein.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_InnVeinColumn");
				this.column2_2D_InnVein.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_InnVein");
				base.Columns.Add(this.column2_2D_InnVein);
				this.column2_2D_Azygos = new DataColumn("2_2D_Azygos", typeof(string), null, MappingType.Element);
				this.column2_2D_Azygos.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_Azygos");
				this.column2_2D_Azygos.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_AzygosColumn");
				this.column2_2D_Azygos.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_Azygos");
				base.Columns.Add(this.column2_2D_Azygos);
				this.column2_2D_MitAnn = new DataColumn("2_2D_MitAnn", typeof(string), null, MappingType.Element);
				this.column2_2D_MitAnn.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_MitAnn");
				this.column2_2D_MitAnn.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_MitAnnColumn");
				this.column2_2D_MitAnn.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_MitAnn");
				base.Columns.Add(this.column2_2D_MitAnn);
				this.column2_2D_LPA = new DataColumn("2_2D_LPA", typeof(string), null, MappingType.Element);
				this.column2_2D_LPA.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_LPA");
				this.column2_2D_LPA.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_LPAColumn");
				this.column2_2D_LPA.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_LPA");
				base.Columns.Add(this.column2_2D_LPA);
				this.column2_2D_RPA = new DataColumn("2_2D_RPA", typeof(string), null, MappingType.Element);
				this.column2_2D_RPA.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_2D_RPA");
				this.column2_2D_RPA.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_2D_RPAColumn");
				this.column2_2D_RPA.ExtendedProperties.Add("Generator_UserColumnName", "2_2D_RPA");
				base.Columns.Add(this.column2_2D_RPA);
				this.column2_Khac = new DataColumn("2_Khac", typeof(string), null, MappingType.Element);
				this.column2_Khac.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_2_Khac");
				this.column2_Khac.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_2_KhacColumn");
				this.column2_Khac.ExtendedProperties.Add("Generator_UserColumnName", "2_Khac");
				base.Columns.Add(this.column2_Khac);
				this.column3_2la_Vmax = new DataColumn("3_2la_Vmax", typeof(string), null, MappingType.Element);
				this.column3_2la_Vmax.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_2la_Vmax");
				this.column3_2la_Vmax.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_2la_VmaxColumn");
				this.column3_2la_Vmax.ExtendedProperties.Add("Generator_UserColumnName", "3_2la_Vmax");
				base.Columns.Add(this.column3_2la_Vmax);
				this.column3_2la_MaxGd = new DataColumn("3_2la_MaxGd", typeof(string), null, MappingType.Element);
				this.column3_2la_MaxGd.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_2la_MaxGd");
				this.column3_2la_MaxGd.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_2la_MaxGdColumn");
				this.column3_2la_MaxGd.ExtendedProperties.Add("Generator_UserColumnName", "3_2la_MaxGd");
				base.Columns.Add(this.column3_2la_MaxGd);
				this.column3_2la_Stenosis = new DataColumn("3_2la_Stenosis", typeof(string), null, MappingType.Element);
				this.column3_2la_Stenosis.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_2la_Stenosis");
				this.column3_2la_Stenosis.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_2la_StenosisColumn");
				this.column3_2la_Stenosis.ExtendedProperties.Add("Generator_UserColumnName", "3_2la_Stenosis");
				base.Columns.Add(this.column3_2la_Stenosis);
				this.column3_2la_MeanGd = new DataColumn("3_2la_MeanGd", typeof(string), null, MappingType.Element);
				this.column3_2la_MeanGd.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_2la_MeanGd");
				this.column3_2la_MeanGd.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_2la_MeanGdColumn");
				this.column3_2la_MeanGd.ExtendedProperties.Add("Generator_UserColumnName", "3_2la_MeanGd");
				base.Columns.Add(this.column3_2la_MeanGd);
				this.column3_2la_PHT = new DataColumn("3_2la_PHT", typeof(string), null, MappingType.Element);
				this.column3_2la_PHT.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_2la_PHT");
				this.column3_2la_PHT.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_2la_PHTColumn");
				this.column3_2la_PHT.ExtendedProperties.Add("Generator_UserColumnName", "3_2la_PHT");
				base.Columns.Add(this.column3_2la_PHT);
				this.column3_2la_Ho = new DataColumn("3_2la_Ho", typeof(string), null, MappingType.Element);
				this.column3_2la_Ho.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_2la_Ho");
				this.column3_2la_Ho.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_2la_HoColumn");
				this.column3_2la_Ho.ExtendedProperties.Add("Generator_UserColumnName", "3_2la_Ho");
				base.Columns.Add(this.column3_2la_Ho);
				this.column3_2la_Degree = new DataColumn("3_2la_Degree", typeof(string), null, MappingType.Element);
				this.column3_2la_Degree.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_2la_Degree");
				this.column3_2la_Degree.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_2la_DegreeColumn");
				this.column3_2la_Degree.ExtendedProperties.Add("Generator_UserColumnName", "3_2la_Degree");
				base.Columns.Add(this.column3_2la_Degree);
				this.column3_DMC_Vmax = new DataColumn("3_DMC_Vmax", typeof(string), null, MappingType.Element);
				this.column3_DMC_Vmax.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMC_Vmax");
				this.column3_DMC_Vmax.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMC_VmaxColumn");
				this.column3_DMC_Vmax.ExtendedProperties.Add("Generator_UserColumnName", "3_DMC_Vmax");
				base.Columns.Add(this.column3_DMC_Vmax);
				this.column3_DMC_MaxGd = new DataColumn("3_DMC_MaxGd", typeof(string), null, MappingType.Element);
				this.column3_DMC_MaxGd.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMC_MaxGd");
				this.column3_DMC_MaxGd.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMC_MaxGdColumn");
				this.column3_DMC_MaxGd.ExtendedProperties.Add("Generator_UserColumnName", "3_DMC_MaxGd");
				base.Columns.Add(this.column3_DMC_MaxGd);
				this.column3_DMC_Stenosis = new DataColumn("3_DMC_Stenosis", typeof(string), null, MappingType.Element);
				this.column3_DMC_Stenosis.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMC_Stenosis");
				this.column3_DMC_Stenosis.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMC_StenosisColumn");
				this.column3_DMC_Stenosis.ExtendedProperties.Add("Generator_UserColumnName", "3_DMC_Stenosis");
				base.Columns.Add(this.column3_DMC_Stenosis);
				this.column3_DMC_MeanGd = new DataColumn("3_DMC_MeanGd", typeof(string), null, MappingType.Element);
				this.column3_DMC_MeanGd.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMC_MeanGd");
				this.column3_DMC_MeanGd.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMC_MeanGdColumn");
				this.column3_DMC_MeanGd.ExtendedProperties.Add("Generator_UserColumnName", "3_DMC_MeanGd");
				base.Columns.Add(this.column3_DMC_MeanGd);
				this.column3_DMC_Edc = new DataColumn("3_DMC_Edc", typeof(string), null, MappingType.Element);
				this.column3_DMC_Edc.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMC_Edc");
				this.column3_DMC_Edc.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMC_EdcColumn");
				this.column3_DMC_Edc.ExtendedProperties.Add("Generator_UserColumnName", "3_DMC_Edc");
				base.Columns.Add(this.column3_DMC_Edc);
				this.column3_DMC_Ho = new DataColumn("3_DMC_Ho", typeof(string), null, MappingType.Element);
				this.column3_DMC_Ho.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMC_Ho");
				this.column3_DMC_Ho.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMC_HoColumn");
				this.column3_DMC_Ho.ExtendedProperties.Add("Generator_UserColumnName", "3_DMC_Ho");
				base.Columns.Add(this.column3_DMC_Ho);
				this.column3_DMC_PHT = new DataColumn("3_DMC_PHT", typeof(string), null, MappingType.Element);
				this.column3_DMC_PHT.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMC_PHT");
				this.column3_DMC_PHT.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMC_PHTColumn");
				this.column3_DMC_PHT.ExtendedProperties.Add("Generator_UserColumnName", "3_DMC_PHT");
				base.Columns.Add(this.column3_DMC_PHT);
				this.column3_DMC_EDTD = new DataColumn("3_DMC_EDTD", typeof(string), null, MappingType.Element);
				this.column3_DMC_EDTD.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMC_EDTD");
				this.column3_DMC_EDTD.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMC_EDTDColumn");
				this.column3_DMC_EDTD.ExtendedProperties.Add("Generator_UserColumnName", "3_DMC_EDTD");
				base.Columns.Add(this.column3_DMC_EDTD);
				this.column3_DMC_Degree = new DataColumn("3_DMC_Degree", typeof(string), null, MappingType.Element);
				this.column3_DMC_Degree.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMC_Degree");
				this.column3_DMC_Degree.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMC_DegreeColumn");
				this.column3_DMC_Degree.ExtendedProperties.Add("Generator_UserColumnName", "3_DMC_Degree");
				base.Columns.Add(this.column3_DMC_Degree);
				this.column3_DMC_DFO = new DataColumn("3_DMC_DFO", typeof(string), null, MappingType.Element);
				this.column3_DMC_DFO.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMC_DFO");
				this.column3_DMC_DFO.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMC_DFOColumn");
				this.column3_DMC_DFO.ExtendedProperties.Add("Generator_UserColumnName", "3_DMC_DFO");
				base.Columns.Add(this.column3_DMC_DFO);
				this.column3_DMC_DoLan = new DataColumn("3_DMC_DoLan", typeof(string), null, MappingType.Element);
				this.column3_DMC_DoLan.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMC_DoLan");
				this.column3_DMC_DoLan.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMC_DoLanColumn");
				this.column3_DMC_DoLan.ExtendedProperties.Add("Generator_UserColumnName", "3_DMC_DoLan");
				base.Columns.Add(this.column3_DMC_DoLan);
				this.column3_3la_Vmax = new DataColumn("3_3la_Vmax", typeof(string), null, MappingType.Element);
				this.column3_3la_Vmax.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_3la_Vmax");
				this.column3_3la_Vmax.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_3la_VmaxColumn");
				this.column3_3la_Vmax.ExtendedProperties.Add("Generator_UserColumnName", "3_3la_Vmax");
				base.Columns.Add(this.column3_3la_Vmax);
				this.column3_3la_Ho = new DataColumn("3_3la_Ho", typeof(string), null, MappingType.Element);
				this.column3_3la_Ho.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_3la_Ho");
				this.column3_3la_Ho.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_3la_HoColumn");
				this.column3_3la_Ho.ExtendedProperties.Add("Generator_UserColumnName", "3_3la_Ho");
				base.Columns.Add(this.column3_3la_Ho);
				this.column3_3la_MaxGd = new DataColumn("3_3la_MaxGd", typeof(string), null, MappingType.Element);
				this.column3_3la_MaxGd.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_3la_MaxGd");
				this.column3_3la_MaxGd.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_3la_MaxGdColumn");
				this.column3_3la_MaxGd.ExtendedProperties.Add("Generator_UserColumnName", "3_3la_MaxGd");
				base.Columns.Add(this.column3_3la_MaxGd);
				this.column3_3la_ALDMPTT = new DataColumn("3_3la_ALDMPTT", typeof(string), null, MappingType.Element);
				this.column3_3la_ALDMPTT.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_3la_ALDMPTT");
				this.column3_3la_ALDMPTT.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_3la_ALDMPTTColumn");
				this.column3_3la_ALDMPTT.ExtendedProperties.Add("Generator_UserColumnName", "3_3la_ALDMPTT");
				base.Columns.Add(this.column3_3la_ALDMPTT);
				this.column3_3la_MeanGd = new DataColumn("3_3la_MeanGd", typeof(string), null, MappingType.Element);
				this.column3_3la_MeanGd.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_3la_MeanGd");
				this.column3_3la_MeanGd.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_3la_MeanGdColumn");
				this.column3_3la_MeanGd.ExtendedProperties.Add("Generator_UserColumnName", "3_3la_MeanGd");
				base.Columns.Add(this.column3_3la_MeanGd);
				this.column3_DMP_Vmax = new DataColumn("3_DMP_Vmax", typeof(string), null, MappingType.Element);
				this.column3_DMP_Vmax.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMP_Vmax");
				this.column3_DMP_Vmax.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMP_VmaxColumn");
				this.column3_DMP_Vmax.ExtendedProperties.Add("Generator_UserColumnName", "3_DMP_Vmax");
				base.Columns.Add(this.column3_DMP_Vmax);
				this.column3_DMP_MaxGd = new DataColumn("3_DMP_MaxGd", typeof(string), null, MappingType.Element);
				this.column3_DMP_MaxGd.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMP_MaxGd");
				this.column3_DMP_MaxGd.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMP_MaxGdColumn");
				this.column3_DMP_MaxGd.ExtendedProperties.Add("Generator_UserColumnName", "3_DMP_MaxGd");
				base.Columns.Add(this.column3_DMP_MaxGd);
				this.column3_DMP_HoDMP = new DataColumn("3_DMP_HoDMP", typeof(string), null, MappingType.Element);
				this.column3_DMP_HoDMP.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMP_HoDMP");
				this.column3_DMP_HoDMP.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMP_HoDMPColumn");
				this.column3_DMP_HoDMP.ExtendedProperties.Add("Generator_UserColumnName", "3_DMP_HoDMP");
				base.Columns.Add(this.column3_DMP_HoDMP);
				this.column3_DMP_QpQs = new DataColumn("3_DMP_QpQs", typeof(string), null, MappingType.Element);
				this.column3_DMP_QpQs.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMP_QpQs");
				this.column3_DMP_QpQs.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMP_QpQsColumn");
				this.column3_DMP_QpQs.ExtendedProperties.Add("Generator_UserColumnName", "3_DMP_QpQs");
				base.Columns.Add(this.column3_DMP_QpQs);
				this.column3_DMP_MeanGd = new DataColumn("3_DMP_MeanGd", typeof(string), null, MappingType.Element);
				this.column3_DMP_MeanGd.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMP_MeanGd");
				this.column3_DMP_MeanGd.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMP_MeanGdColumn");
				this.column3_DMP_MeanGd.ExtendedProperties.Add("Generator_UserColumnName", "3_DMP_MeanGd");
				base.Columns.Add(this.column3_DMP_MeanGd);
				this.column3_DMP_ALDMPTB = new DataColumn("3_DMP_ALDMPTB", typeof(string), null, MappingType.Element);
				this.column3_DMP_ALDMPTB.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMP_ALDMPTB");
				this.column3_DMP_ALDMPTB.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMP_ALDMPTBColumn");
				this.column3_DMP_ALDMPTB.ExtendedProperties.Add("Generator_UserColumnName", "3_DMP_ALDMPTB");
				base.Columns.Add(this.column3_DMP_ALDMPTB);
				this.column3_DMP_ALDMPTTr = new DataColumn("3_DMP_ALDMPTTr", typeof(string), null, MappingType.Element);
				this.column3_DMP_ALDMPTTr.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_DMP_ALDMPTTr");
				this.column3_DMP_ALDMPTTr.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_DMP_ALDMPTTrColumn");
				this.column3_DMP_ALDMPTTr.ExtendedProperties.Add("Generator_UserColumnName", "3_DMP_ALDMPTTr");
				base.Columns.Add(this.column3_DMP_ALDMPTTr);
				this.column3_Khac = new DataColumn("3_Khac", typeof(string), null, MappingType.Element);
				this.column3_Khac.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_3_Khac");
				this.column3_Khac.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_3_KhacColumn");
				this.column3_Khac.ExtendedProperties.Add("Generator_UserColumnName", "3_Khac");
				base.Columns.Add(this.column3_Khac);
				this.columnKetQua_SATM_Id.Caption = "KetQua_SATQ_Id";
				this.columnSA_TM_Id.Caption = "SA_TQ_Id";
				this.column2_2D_PulmVeins.Caption = "Column1";
				this.column2_2D_TricAnn.Caption = "Column2";
				this.column2_2D_PATrunk.Caption = "Column1";
				this.column2_2D_InnVein.Caption = "Column2";
				this.column2_2D_Azygos.Caption = "Column1";
				this.column2_2D_MitAnn.Caption = "Column2";
				this.column2_2D_LPA.Caption = "Column1";
				this.column2_2D_RPA.Caption = "Column2";
				this.column2_Khac.Caption = "Column1";
				this.column3_2la_Vmax.Caption = "Column1";
				this.column3_2la_MaxGd.Caption = "Column2";
				this.column3_2la_Stenosis.Caption = "Column1";
				this.column3_2la_MeanGd.Caption = "Column2";
				this.column3_2la_PHT.Caption = "Column2";
				this.column3_DMC_Vmax.Caption = "Column1";
				this.column3_DMC_MaxGd.Caption = "Column2";
				this.column3_DMC_Stenosis.Caption = "Column1";
				this.column3_DMC_MeanGd.Caption = "Column1";
				this.column3_DMC_Edc.Caption = "Column2";
				this.column3_DMC_Ho.Caption = "Column2";
				this.column3_DMC_PHT.Caption = "Column1";
				this.column3_DMC_EDTD.Caption = "Column1";
				this.column3_DMC_Degree.Caption = "Column2";
				this.column3_DMC_DFO.Caption = "Column1";
				this.column3_DMC_DoLan.Caption = "Column1";
				this.column3_3la_Vmax.Caption = "Column2";
				this.column3_3la_Ho.Caption = "Column2";
				this.column3_3la_MaxGd.Caption = "Column2";
				this.column3_3la_ALDMPTT.Caption = "Column1";
				this.column3_3la_MeanGd.Caption = "Column1";
				this.column3_DMP_Vmax.Caption = "Column2";
				this.column3_DMP_MaxGd.Caption = "Column1";
				this.column3_DMP_HoDMP.Caption = "Column1";
				this.column3_DMP_QpQs.Caption = "Column2";
				this.column3_DMP_MeanGd.Caption = "Column2";
				this.column3_DMP_ALDMPTB.Caption = "Column2";
			}

			// Token: 0x0600038F RID: 911 RVA: 0x00010564 File Offset: 0x0000F564
			[DebuggerNonUserCode]
			public dsKetQuaSA.SATIMRow NewSATIMRow()
			{
				return (dsKetQuaSA.SATIMRow)base.NewRow();
			}

			// Token: 0x06000390 RID: 912 RVA: 0x00010584 File Offset: 0x0000F584
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsKetQuaSA.SATIMRow(builder);
			}

			// Token: 0x06000391 RID: 913 RVA: 0x0001059C File Offset: 0x0000F59C
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(dsKetQuaSA.SATIMRow);
			}

			// Token: 0x06000392 RID: 914 RVA: 0x000105B8 File Offset: 0x0000F5B8
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SATIMRowChanged != null)
				{
					this.SATIMRowChanged(this, new dsKetQuaSA.SATIMRowChangeEvent((dsKetQuaSA.SATIMRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000393 RID: 915 RVA: 0x00010600 File Offset: 0x0000F600
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SATIMRowChanging != null)
				{
					this.SATIMRowChanging(this, new dsKetQuaSA.SATIMRowChangeEvent((dsKetQuaSA.SATIMRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000394 RID: 916 RVA: 0x00010648 File Offset: 0x0000F648
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SATIMRowDeleted != null)
				{
					this.SATIMRowDeleted(this, new dsKetQuaSA.SATIMRowChangeEvent((dsKetQuaSA.SATIMRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000395 RID: 917 RVA: 0x00010690 File Offset: 0x0000F690
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SATIMRowDeleting != null)
				{
					this.SATIMRowDeleting(this, new dsKetQuaSA.SATIMRowChangeEvent((dsKetQuaSA.SATIMRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000396 RID: 918 RVA: 0x000106D8 File Offset: 0x0000F6D8
			[DebuggerNonUserCode]
			public void RemoveSATIMRow(dsKetQuaSA.SATIMRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000397 RID: 919 RVA: 0x000106E8 File Offset: 0x0000F6E8
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				dsKetQuaSA dsKetQuaSA = new dsKetQuaSA();
				xs.Add(dsKetQuaSA.GetSchemaSerializable());
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dsKetQuaSA.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SATIMDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x040000C9 RID: 201
			private DataColumn columnKetQua_SATM_Id;

			// Token: 0x040000CA RID: 202
			private DataColumn columnSA_TM_Id;

			// Token: 0x040000CB RID: 203
			private DataColumn columnBenhNhan_Id;

			// Token: 0x040000CC RID: 204
			private DataColumn columnY_Te_Id;

			// Token: 0x040000CD RID: 205
			private DataColumn columnHo_Ten;

			// Token: 0x040000CE RID: 206
			private DataColumn columnGioi_Tinh;

			// Token: 0x040000CF RID: 207
			private DataColumn columnNam_Sinh;

			// Token: 0x040000D0 RID: 208
			private DataColumn columnDia_Chi;

			// Token: 0x040000D1 RID: 209
			private DataColumn columnHuyen_Tinh;

			// Token: 0x040000D2 RID: 210
			private DataColumn columnNgay;

			// Token: 0x040000D3 RID: 211
			private DataColumn columnLam_Sang;

			// Token: 0x040000D4 RID: 212
			private DataColumn columnKhac;

			// Token: 0x040000D5 RID: 213
			private DataColumn columnKet_Luan;

			// Token: 0x040000D6 RID: 214
			private DataColumn columnDS_Anh_KQ;

			// Token: 0x040000D7 RID: 215
			private DataColumn columnTrinh_Do;

			// Token: 0x040000D8 RID: 216
			private DataColumn columnHo_Ten_BSSA;

			// Token: 0x040000D9 RID: 217
			private DataColumn columnCan_Nang;

			// Token: 0x040000DA RID: 218
			private DataColumn columnChieu_Cao;

			// Token: 0x040000DB RID: 219
			private DataColumn columnBSA;

			// Token: 0x040000DC RID: 220
			private DataColumn columnNhip_Tim;

			// Token: 0x040000DD RID: 221
			private DataColumn columnHuyet_Ap;

			// Token: 0x040000DE RID: 222
			private DataColumn column2_TM_IVSd;

			// Token: 0x040000DF RID: 223
			private DataColumn column2_TM_LVDd;

			// Token: 0x040000E0 RID: 224
			private DataColumn column2_TM_PLVW;

			// Token: 0x040000E1 RID: 225
			private DataColumn column2_TM_IVSs;

			// Token: 0x040000E2 RID: 226
			private DataColumn column2_TM_LVDs;

			// Token: 0x040000E3 RID: 227
			private DataColumn column2_TM_PLVWs;

			// Token: 0x040000E4 RID: 228
			private DataColumn column2_TM_SF;

			// Token: 0x040000E5 RID: 229
			private DataColumn column2_TM_EF;

			// Token: 0x040000E6 RID: 230
			private DataColumn column2_TM_RVd;

			// Token: 0x040000E7 RID: 231
			private DataColumn column2_TM_Ao;

			// Token: 0x040000E8 RID: 232
			private DataColumn column2_TM_LA;

			// Token: 0x040000E9 RID: 233
			private DataColumn column2_TM_AVo;

			// Token: 0x040000EA RID: 234
			private DataColumn column2_2D_Situs;

			// Token: 0x040000EB RID: 235
			private DataColumn column2_2D_VEINS;

			// Token: 0x040000EC RID: 236
			private DataColumn column2_2D_Atrium;

			// Token: 0x040000ED RID: 237
			private DataColumn column2_2D_Ventricle;

			// Token: 0x040000EE RID: 238
			private DataColumn column2_2D_DaiDongMach;

			// Token: 0x040000EF RID: 239
			private DataColumn column2_2D_MangNgoaiTim;

			// Token: 0x040000F0 RID: 240
			private DataColumn column2_2D_IVC;

			// Token: 0x040000F1 RID: 241
			private DataColumn column2_2D_LSVC;

			// Token: 0x040000F2 RID: 242
			private DataColumn column2_2D_Valves;

			// Token: 0x040000F3 RID: 243
			private DataColumn column2_2D_DMCAo;

			// Token: 0x040000F4 RID: 244
			private DataColumn column2_2D_DMPPA;

			// Token: 0x040000F5 RID: 245
			private DataColumn column2_2D_Ann;

			// Token: 0x040000F6 RID: 246
			private DataColumn column2_2D_RSVC;

			// Token: 0x040000F7 RID: 247
			private DataColumn column2_2D_PulmVeins;

			// Token: 0x040000F8 RID: 248
			private DataColumn column2_2D_TricAnn;

			// Token: 0x040000F9 RID: 249
			private DataColumn column2_2D_D2;

			// Token: 0x040000FA RID: 250
			private DataColumn column2_2D_PATrunk;

			// Token: 0x040000FB RID: 251
			private DataColumn column2_2D_InnVein;

			// Token: 0x040000FC RID: 252
			private DataColumn column2_2D_Azygos;

			// Token: 0x040000FD RID: 253
			private DataColumn column2_2D_MitAnn;

			// Token: 0x040000FE RID: 254
			private DataColumn column2_2D_LPA;

			// Token: 0x040000FF RID: 255
			private DataColumn column2_2D_RPA;

			// Token: 0x04000100 RID: 256
			private DataColumn column2_Khac;

			// Token: 0x04000101 RID: 257
			private DataColumn column3_2la_Vmax;

			// Token: 0x04000102 RID: 258
			private DataColumn column3_2la_MaxGd;

			// Token: 0x04000103 RID: 259
			private DataColumn column3_2la_Stenosis;

			// Token: 0x04000104 RID: 260
			private DataColumn column3_2la_MeanGd;

			// Token: 0x04000105 RID: 261
			private DataColumn column3_2la_PHT;

			// Token: 0x04000106 RID: 262
			private DataColumn column3_2la_Ho;

			// Token: 0x04000107 RID: 263
			private DataColumn column3_2la_Degree;

			// Token: 0x04000108 RID: 264
			private DataColumn column3_DMC_Vmax;

			// Token: 0x04000109 RID: 265
			private DataColumn column3_DMC_MaxGd;

			// Token: 0x0400010A RID: 266
			private DataColumn column3_DMC_Stenosis;

			// Token: 0x0400010B RID: 267
			private DataColumn column3_DMC_MeanGd;

			// Token: 0x0400010C RID: 268
			private DataColumn column3_DMC_Edc;

			// Token: 0x0400010D RID: 269
			private DataColumn column3_DMC_Ho;

			// Token: 0x0400010E RID: 270
			private DataColumn column3_DMC_PHT;

			// Token: 0x0400010F RID: 271
			private DataColumn column3_DMC_EDTD;

			// Token: 0x04000110 RID: 272
			private DataColumn column3_DMC_Degree;

			// Token: 0x04000111 RID: 273
			private DataColumn column3_DMC_DFO;

			// Token: 0x04000112 RID: 274
			private DataColumn column3_DMC_DoLan;

			// Token: 0x04000113 RID: 275
			private DataColumn column3_3la_Vmax;

			// Token: 0x04000114 RID: 276
			private DataColumn column3_3la_Ho;

			// Token: 0x04000115 RID: 277
			private DataColumn column3_3la_MaxGd;

			// Token: 0x04000116 RID: 278
			private DataColumn column3_3la_ALDMPTT;

			// Token: 0x04000117 RID: 279
			private DataColumn column3_3la_MeanGd;

			// Token: 0x04000118 RID: 280
			private DataColumn column3_DMP_Vmax;

			// Token: 0x04000119 RID: 281
			private DataColumn column3_DMP_MaxGd;

			// Token: 0x0400011A RID: 282
			private DataColumn column3_DMP_HoDMP;

			// Token: 0x0400011B RID: 283
			private DataColumn column3_DMP_QpQs;

			// Token: 0x0400011C RID: 284
			private DataColumn column3_DMP_MeanGd;

			// Token: 0x0400011D RID: 285
			private DataColumn column3_DMP_ALDMPTB;

			// Token: 0x0400011E RID: 286
			private DataColumn column3_DMP_ALDMPTTr;

			// Token: 0x0400011F RID: 287
			private DataColumn column3_Khac;
		}

		// Token: 0x02000044 RID: 68
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class ImagesDataTable : DataTable, IEnumerable
		{
			// Token: 0x06000398 RID: 920 RVA: 0x00010801 File Offset: 0x0000F801
			[DebuggerNonUserCode]
			public ImagesDataTable()
			{
				base.TableName = "Images";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000399 RID: 921 RVA: 0x00010830 File Offset: 0x0000F830
			[DebuggerNonUserCode]
			internal ImagesDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x0600039A RID: 922 RVA: 0x000108F5 File Offset: 0x0000F8F5
			[DebuggerNonUserCode]
			protected ImagesDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x170001D7 RID: 471
			// (get) Token: 0x0600039B RID: 923 RVA: 0x0001090C File Offset: 0x0000F90C
			[DebuggerNonUserCode]
			public DataColumn Image1Column
			{
				get
				{
					return this.columnImage1;
				}
			}

			// Token: 0x170001D8 RID: 472
			// (get) Token: 0x0600039C RID: 924 RVA: 0x00010924 File Offset: 0x0000F924
			[DebuggerNonUserCode]
			public DataColumn Image2Column
			{
				get
				{
					return this.columnImage2;
				}
			}

			// Token: 0x170001D9 RID: 473
			// (get) Token: 0x0600039D RID: 925 RVA: 0x0001093C File Offset: 0x0000F93C
			[DebuggerNonUserCode]
			public DataColumn Image3Column
			{
				get
				{
					return this.columnImage3;
				}
			}

			// Token: 0x170001DA RID: 474
			// (get) Token: 0x0600039E RID: 926 RVA: 0x00010954 File Offset: 0x0000F954
			[DebuggerNonUserCode]
			public DataColumn Image4Column
			{
				get
				{
					return this.columnImage4;
				}
			}

			// Token: 0x170001DB RID: 475
			// (get) Token: 0x0600039F RID: 927 RVA: 0x0001096C File Offset: 0x0000F96C
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x170001DC RID: 476
			[DebuggerNonUserCode]
			public dsKetQuaSA.ImagesRow this[int index]
			{
				get
				{
					return (dsKetQuaSA.ImagesRow)base.Rows[index];
				}
			}

			// Token: 0x14000019 RID: 25
			// (add) Token: 0x060003A1 RID: 929 RVA: 0x000109AF File Offset: 0x0000F9AF
			// (remove) Token: 0x060003A2 RID: 930 RVA: 0x000109C8 File Offset: 0x0000F9C8
			public event dsKetQuaSA.ImagesRowChangeEventHandler ImagesRowChanging;

			// Token: 0x1400001A RID: 26
			// (add) Token: 0x060003A3 RID: 931 RVA: 0x000109E1 File Offset: 0x0000F9E1
			// (remove) Token: 0x060003A4 RID: 932 RVA: 0x000109FA File Offset: 0x0000F9FA
			public event dsKetQuaSA.ImagesRowChangeEventHandler ImagesRowChanged;

			// Token: 0x1400001B RID: 27
			// (add) Token: 0x060003A5 RID: 933 RVA: 0x00010A13 File Offset: 0x0000FA13
			// (remove) Token: 0x060003A6 RID: 934 RVA: 0x00010A2C File Offset: 0x0000FA2C
			public event dsKetQuaSA.ImagesRowChangeEventHandler ImagesRowDeleting;

			// Token: 0x1400001C RID: 28
			// (add) Token: 0x060003A7 RID: 935 RVA: 0x00010A45 File Offset: 0x0000FA45
			// (remove) Token: 0x060003A8 RID: 936 RVA: 0x00010A5E File Offset: 0x0000FA5E
			public event dsKetQuaSA.ImagesRowChangeEventHandler ImagesRowDeleted;

			// Token: 0x060003A9 RID: 937 RVA: 0x00010A77 File Offset: 0x0000FA77
			[DebuggerNonUserCode]
			public void AddImagesRow(dsKetQuaSA.ImagesRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x060003AA RID: 938 RVA: 0x00010A88 File Offset: 0x0000FA88
			[DebuggerNonUserCode]
			public dsKetQuaSA.ImagesRow AddImagesRow(byte[] Image1, byte[] Image2, byte[] Image3, byte[] Image4)
			{
				dsKetQuaSA.ImagesRow imagesRow = (dsKetQuaSA.ImagesRow)base.NewRow();
				imagesRow.ItemArray = new object[]
				{
					Image1,
					Image2,
					Image3,
					Image4
				};
				base.Rows.Add(imagesRow);
				return imagesRow;
			}

			// Token: 0x060003AB RID: 939 RVA: 0x00010AD4 File Offset: 0x0000FAD4
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x060003AC RID: 940 RVA: 0x00010AF4 File Offset: 0x0000FAF4
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				dsKetQuaSA.ImagesDataTable imagesDataTable = (dsKetQuaSA.ImagesDataTable)base.Clone();
				imagesDataTable.InitVars();
				return imagesDataTable;
			}

			// Token: 0x060003AD RID: 941 RVA: 0x00010B1C File Offset: 0x0000FB1C
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new dsKetQuaSA.ImagesDataTable();
			}

			// Token: 0x060003AE RID: 942 RVA: 0x00010B34 File Offset: 0x0000FB34
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnImage1 = base.Columns["Image1"];
				this.columnImage2 = base.Columns["Image2"];
				this.columnImage3 = base.Columns["Image3"];
				this.columnImage4 = base.Columns["Image4"];
			}

			// Token: 0x060003AF RID: 943 RVA: 0x00010B9C File Offset: 0x0000FB9C
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnImage1 = new DataColumn("Image1", typeof(byte[]), null, MappingType.Element);
				base.Columns.Add(this.columnImage1);
				this.columnImage2 = new DataColumn("Image2", typeof(byte[]), null, MappingType.Element);
				base.Columns.Add(this.columnImage2);
				this.columnImage3 = new DataColumn("Image3", typeof(byte[]), null, MappingType.Element);
				base.Columns.Add(this.columnImage3);
				this.columnImage4 = new DataColumn("Image4", typeof(byte[]), null, MappingType.Element);
				base.Columns.Add(this.columnImage4);
			}

			// Token: 0x060003B0 RID: 944 RVA: 0x00010C64 File Offset: 0x0000FC64
			[DebuggerNonUserCode]
			public dsKetQuaSA.ImagesRow NewImagesRow()
			{
				return (dsKetQuaSA.ImagesRow)base.NewRow();
			}

			// Token: 0x060003B1 RID: 945 RVA: 0x00010C84 File Offset: 0x0000FC84
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsKetQuaSA.ImagesRow(builder);
			}

			// Token: 0x060003B2 RID: 946 RVA: 0x00010C9C File Offset: 0x0000FC9C
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(dsKetQuaSA.ImagesRow);
			}

			// Token: 0x060003B3 RID: 947 RVA: 0x00010CB8 File Offset: 0x0000FCB8
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.ImagesRowChanged != null)
				{
					this.ImagesRowChanged(this, new dsKetQuaSA.ImagesRowChangeEvent((dsKetQuaSA.ImagesRow)e.Row, e.Action));
				}
			}

			// Token: 0x060003B4 RID: 948 RVA: 0x00010D00 File Offset: 0x0000FD00
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.ImagesRowChanging != null)
				{
					this.ImagesRowChanging(this, new dsKetQuaSA.ImagesRowChangeEvent((dsKetQuaSA.ImagesRow)e.Row, e.Action));
				}
			}

			// Token: 0x060003B5 RID: 949 RVA: 0x00010D48 File Offset: 0x0000FD48
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.ImagesRowDeleted != null)
				{
					this.ImagesRowDeleted(this, new dsKetQuaSA.ImagesRowChangeEvent((dsKetQuaSA.ImagesRow)e.Row, e.Action));
				}
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x00010D90 File Offset: 0x0000FD90
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.ImagesRowDeleting != null)
				{
					this.ImagesRowDeleting(this, new dsKetQuaSA.ImagesRowChangeEvent((dsKetQuaSA.ImagesRow)e.Row, e.Action));
				}
			}

			// Token: 0x060003B7 RID: 951 RVA: 0x00010DD8 File Offset: 0x0000FDD8
			[DebuggerNonUserCode]
			public void RemoveImagesRow(dsKetQuaSA.ImagesRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x00010DE8 File Offset: 0x0000FDE8
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				dsKetQuaSA dsKetQuaSA = new dsKetQuaSA();
				xs.Add(dsKetQuaSA.GetSchemaSerializable());
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dsKetQuaSA.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "ImagesDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x04000124 RID: 292
			private DataColumn columnImage1;

			// Token: 0x04000125 RID: 293
			private DataColumn columnImage2;

			// Token: 0x04000126 RID: 294
			private DataColumn columnImage3;

			// Token: 0x04000127 RID: 295
			private DataColumn columnImage4;
		}

		// Token: 0x02000045 RID: 69
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SAKHACRow : DataRow
		{
			// Token: 0x060003B9 RID: 953 RVA: 0x00010F01 File Offset: 0x0000FF01
			[DebuggerNonUserCode]
			internal SAKHACRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSAKHAC = (dsKetQuaSA.SAKHACDataTable)base.Table;
			}

			// Token: 0x170001DD RID: 477
			// (get) Token: 0x060003BA RID: 954 RVA: 0x00010F20 File Offset: 0x0000FF20
			// (set) Token: 0x060003BB RID: 955 RVA: 0x00010F68 File Offset: 0x0000FF68
			[DebuggerNonUserCode]
			public string KetQua_SAKhac_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.KetQua_SAKhac_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'KetQua_SAKhac_Id' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.KetQua_SAKhac_IdColumn] = value;
				}
			}

			// Token: 0x170001DE RID: 478
			// (get) Token: 0x060003BC RID: 956 RVA: 0x00010F80 File Offset: 0x0000FF80
			// (set) Token: 0x060003BD RID: 957 RVA: 0x00010FC8 File Offset: 0x0000FFC8
			[DebuggerNonUserCode]
			public string SA_KHAC_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.SA_KHAC_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'SA_KHAC_Id' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.SA_KHAC_IdColumn] = value;
				}
			}

			// Token: 0x170001DF RID: 479
			// (get) Token: 0x060003BE RID: 958 RVA: 0x00010FE0 File Offset: 0x0000FFE0
			// (set) Token: 0x060003BF RID: 959 RVA: 0x00011028 File Offset: 0x00010028
			[DebuggerNonUserCode]
			public string Benh_Nhan_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.Benh_Nhan_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Benh_Nhan_Id' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.Benh_Nhan_IdColumn] = value;
				}
			}

			// Token: 0x170001E0 RID: 480
			// (get) Token: 0x060003C0 RID: 960 RVA: 0x00011040 File Offset: 0x00010040
			// (set) Token: 0x060003C1 RID: 961 RVA: 0x00011088 File Offset: 0x00010088
			[DebuggerNonUserCode]
			public string Y_Te_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.Y_Te_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Y_Te_Id' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.Y_Te_IdColumn] = value;
				}
			}

			// Token: 0x170001E1 RID: 481
			// (get) Token: 0x060003C2 RID: 962 RVA: 0x000110A0 File Offset: 0x000100A0
			// (set) Token: 0x060003C3 RID: 963 RVA: 0x000110E8 File Offset: 0x000100E8
			[DebuggerNonUserCode]
			public string Ho_Ten
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.Ho_TenColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ho_Ten' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.Ho_TenColumn] = value;
				}
			}

			// Token: 0x170001E2 RID: 482
			// (get) Token: 0x060003C4 RID: 964 RVA: 0x00011100 File Offset: 0x00010100
			// (set) Token: 0x060003C5 RID: 965 RVA: 0x00011148 File Offset: 0x00010148
			[DebuggerNonUserCode]
			public string Gioi_Tinh
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.Gioi_TinhColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Gioi_Tinh' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.Gioi_TinhColumn] = value;
				}
			}

			// Token: 0x170001E3 RID: 483
			// (get) Token: 0x060003C6 RID: 966 RVA: 0x00011160 File Offset: 0x00010160
			// (set) Token: 0x060003C7 RID: 967 RVA: 0x000111A8 File Offset: 0x000101A8
			[DebuggerNonUserCode]
			public string Nam_Sinh
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.Nam_SinhColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Nam_Sinh' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.Nam_SinhColumn] = value;
				}
			}

			// Token: 0x170001E4 RID: 484
			// (get) Token: 0x060003C8 RID: 968 RVA: 0x000111C0 File Offset: 0x000101C0
			// (set) Token: 0x060003C9 RID: 969 RVA: 0x00011208 File Offset: 0x00010208
			[DebuggerNonUserCode]
			public string Dia_Chi
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.Dia_ChiColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Dia_Chi' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.Dia_ChiColumn] = value;
				}
			}

			// Token: 0x170001E5 RID: 485
			// (get) Token: 0x060003CA RID: 970 RVA: 0x00011220 File Offset: 0x00010220
			// (set) Token: 0x060003CB RID: 971 RVA: 0x00011268 File Offset: 0x00010268
			[DebuggerNonUserCode]
			public string Ngay
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.NgayColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ngay' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.NgayColumn] = value;
				}
			}

			// Token: 0x170001E6 RID: 486
			// (get) Token: 0x060003CC RID: 972 RVA: 0x00011280 File Offset: 0x00010280
			// (set) Token: 0x060003CD RID: 973 RVA: 0x000112C8 File Offset: 0x000102C8
			[DebuggerNonUserCode]
			public string Lam_sang
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.Lam_sangColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Lam_sang' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.Lam_sangColumn] = value;
				}
			}

			// Token: 0x170001E7 RID: 487
			// (get) Token: 0x060003CE RID: 974 RVA: 0x000112E0 File Offset: 0x000102E0
			// (set) Token: 0x060003CF RID: 975 RVA: 0x00011328 File Offset: 0x00010328
			[DebuggerNonUserCode]
			public string Bo_phan_SA
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.Bo_phan_SAColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Bo_phan_SA' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.Bo_phan_SAColumn] = value;
				}
			}

			// Token: 0x170001E8 RID: 488
			// (get) Token: 0x060003D0 RID: 976 RVA: 0x00011340 File Offset: 0x00010340
			// (set) Token: 0x060003D1 RID: 977 RVA: 0x00011388 File Offset: 0x00010388
			[DebuggerNonUserCode]
			public string Ton_Thuong
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.Ton_ThuongColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ton_Thuong' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.Ton_ThuongColumn] = value;
				}
			}

			// Token: 0x170001E9 RID: 489
			// (get) Token: 0x060003D2 RID: 978 RVA: 0x000113A0 File Offset: 0x000103A0
			// (set) Token: 0x060003D3 RID: 979 RVA: 0x000113E8 File Offset: 0x000103E8
			[DebuggerNonUserCode]
			public string Khac
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.KhacColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Khac' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.KhacColumn] = value;
				}
			}

			// Token: 0x170001EA RID: 490
			// (get) Token: 0x060003D4 RID: 980 RVA: 0x00011400 File Offset: 0x00010400
			// (set) Token: 0x060003D5 RID: 981 RVA: 0x00011448 File Offset: 0x00010448
			[DebuggerNonUserCode]
			public string Ket_Luan
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.Ket_LuanColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ket_Luan' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.Ket_LuanColumn] = value;
				}
			}

			// Token: 0x170001EB RID: 491
			// (get) Token: 0x060003D6 RID: 982 RVA: 0x00011460 File Offset: 0x00010460
			// (set) Token: 0x060003D7 RID: 983 RVA: 0x000114A8 File Offset: 0x000104A8
			[DebuggerNonUserCode]
			public string DS_Anh_KQ
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.DS_Anh_KQColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'DS_Anh_KQ' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.DS_Anh_KQColumn] = value;
				}
			}

			// Token: 0x170001EC RID: 492
			// (get) Token: 0x060003D8 RID: 984 RVA: 0x000114C0 File Offset: 0x000104C0
			// (set) Token: 0x060003D9 RID: 985 RVA: 0x00011508 File Offset: 0x00010508
			[DebuggerNonUserCode]
			public string Ho_Ten_BSSA
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.Ho_Ten_BSSAColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ho_Ten_BSSA' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.Ho_Ten_BSSAColumn] = value;
				}
			}

			// Token: 0x170001ED RID: 493
			// (get) Token: 0x060003DA RID: 986 RVA: 0x00011520 File Offset: 0x00010520
			// (set) Token: 0x060003DB RID: 987 RVA: 0x00011568 File Offset: 0x00010568
			[DebuggerNonUserCode]
			public string Trinh_Do
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSAKHAC.Trinh_DoColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Trinh_Do' in table 'SAKHAC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSAKHAC.Trinh_DoColumn] = value;
				}
			}

			// Token: 0x060003DC RID: 988 RVA: 0x00011580 File Offset: 0x00010580
			[DebuggerNonUserCode]
			public bool IsKetQua_SAKhac_IdNull()
			{
				return base.IsNull(this.tableSAKHAC.KetQua_SAKhac_IdColumn);
			}

			// Token: 0x060003DD RID: 989 RVA: 0x000115A3 File Offset: 0x000105A3
			[DebuggerNonUserCode]
			public void SetKetQua_SAKhac_IdNull()
			{
				base[this.tableSAKHAC.KetQua_SAKhac_IdColumn] = Convert.DBNull;
			}

			// Token: 0x060003DE RID: 990 RVA: 0x000115C0 File Offset: 0x000105C0
			[DebuggerNonUserCode]
			public bool IsSA_KHAC_IdNull()
			{
				return base.IsNull(this.tableSAKHAC.SA_KHAC_IdColumn);
			}

			// Token: 0x060003DF RID: 991 RVA: 0x000115E3 File Offset: 0x000105E3
			[DebuggerNonUserCode]
			public void SetSA_KHAC_IdNull()
			{
				base[this.tableSAKHAC.SA_KHAC_IdColumn] = Convert.DBNull;
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x00011600 File Offset: 0x00010600
			[DebuggerNonUserCode]
			public bool IsBenh_Nhan_IdNull()
			{
				return base.IsNull(this.tableSAKHAC.Benh_Nhan_IdColumn);
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x00011623 File Offset: 0x00010623
			[DebuggerNonUserCode]
			public void SetBenh_Nhan_IdNull()
			{
				base[this.tableSAKHAC.Benh_Nhan_IdColumn] = Convert.DBNull;
			}

			// Token: 0x060003E2 RID: 994 RVA: 0x00011640 File Offset: 0x00010640
			[DebuggerNonUserCode]
			public bool IsY_Te_IdNull()
			{
				return base.IsNull(this.tableSAKHAC.Y_Te_IdColumn);
			}

			// Token: 0x060003E3 RID: 995 RVA: 0x00011663 File Offset: 0x00010663
			[DebuggerNonUserCode]
			public void SetY_Te_IdNull()
			{
				base[this.tableSAKHAC.Y_Te_IdColumn] = Convert.DBNull;
			}

			// Token: 0x060003E4 RID: 996 RVA: 0x00011680 File Offset: 0x00010680
			[DebuggerNonUserCode]
			public bool IsHo_TenNull()
			{
				return base.IsNull(this.tableSAKHAC.Ho_TenColumn);
			}

			// Token: 0x060003E5 RID: 997 RVA: 0x000116A3 File Offset: 0x000106A3
			[DebuggerNonUserCode]
			public void SetHo_TenNull()
			{
				base[this.tableSAKHAC.Ho_TenColumn] = Convert.DBNull;
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x000116C0 File Offset: 0x000106C0
			[DebuggerNonUserCode]
			public bool IsGioi_TinhNull()
			{
				return base.IsNull(this.tableSAKHAC.Gioi_TinhColumn);
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x000116E3 File Offset: 0x000106E3
			[DebuggerNonUserCode]
			public void SetGioi_TinhNull()
			{
				base[this.tableSAKHAC.Gioi_TinhColumn] = Convert.DBNull;
			}

			// Token: 0x060003E8 RID: 1000 RVA: 0x00011700 File Offset: 0x00010700
			[DebuggerNonUserCode]
			public bool IsNam_SinhNull()
			{
				return base.IsNull(this.tableSAKHAC.Nam_SinhColumn);
			}

			// Token: 0x060003E9 RID: 1001 RVA: 0x00011723 File Offset: 0x00010723
			[DebuggerNonUserCode]
			public void SetNam_SinhNull()
			{
				base[this.tableSAKHAC.Nam_SinhColumn] = Convert.DBNull;
			}

			// Token: 0x060003EA RID: 1002 RVA: 0x00011740 File Offset: 0x00010740
			[DebuggerNonUserCode]
			public bool IsDia_ChiNull()
			{
				return base.IsNull(this.tableSAKHAC.Dia_ChiColumn);
			}

			// Token: 0x060003EB RID: 1003 RVA: 0x00011763 File Offset: 0x00010763
			[DebuggerNonUserCode]
			public void SetDia_ChiNull()
			{
				base[this.tableSAKHAC.Dia_ChiColumn] = Convert.DBNull;
			}

			// Token: 0x060003EC RID: 1004 RVA: 0x00011780 File Offset: 0x00010780
			[DebuggerNonUserCode]
			public bool IsNgayNull()
			{
				return base.IsNull(this.tableSAKHAC.NgayColumn);
			}

			// Token: 0x060003ED RID: 1005 RVA: 0x000117A3 File Offset: 0x000107A3
			[DebuggerNonUserCode]
			public void SetNgayNull()
			{
				base[this.tableSAKHAC.NgayColumn] = Convert.DBNull;
			}

			// Token: 0x060003EE RID: 1006 RVA: 0x000117C0 File Offset: 0x000107C0
			[DebuggerNonUserCode]
			public bool IsLam_sangNull()
			{
				return base.IsNull(this.tableSAKHAC.Lam_sangColumn);
			}

			// Token: 0x060003EF RID: 1007 RVA: 0x000117E3 File Offset: 0x000107E3
			[DebuggerNonUserCode]
			public void SetLam_sangNull()
			{
				base[this.tableSAKHAC.Lam_sangColumn] = Convert.DBNull;
			}

			// Token: 0x060003F0 RID: 1008 RVA: 0x00011800 File Offset: 0x00010800
			[DebuggerNonUserCode]
			public bool IsBo_phan_SANull()
			{
				return base.IsNull(this.tableSAKHAC.Bo_phan_SAColumn);
			}

			// Token: 0x060003F1 RID: 1009 RVA: 0x00011823 File Offset: 0x00010823
			[DebuggerNonUserCode]
			public void SetBo_phan_SANull()
			{
				base[this.tableSAKHAC.Bo_phan_SAColumn] = Convert.DBNull;
			}

			// Token: 0x060003F2 RID: 1010 RVA: 0x00011840 File Offset: 0x00010840
			[DebuggerNonUserCode]
			public bool IsTon_ThuongNull()
			{
				return base.IsNull(this.tableSAKHAC.Ton_ThuongColumn);
			}

			// Token: 0x060003F3 RID: 1011 RVA: 0x00011863 File Offset: 0x00010863
			[DebuggerNonUserCode]
			public void SetTon_ThuongNull()
			{
				base[this.tableSAKHAC.Ton_ThuongColumn] = Convert.DBNull;
			}

			// Token: 0x060003F4 RID: 1012 RVA: 0x00011880 File Offset: 0x00010880
			[DebuggerNonUserCode]
			public bool IsKhacNull()
			{
				return base.IsNull(this.tableSAKHAC.KhacColumn);
			}

			// Token: 0x060003F5 RID: 1013 RVA: 0x000118A3 File Offset: 0x000108A3
			[DebuggerNonUserCode]
			public void SetKhacNull()
			{
				base[this.tableSAKHAC.KhacColumn] = Convert.DBNull;
			}

			// Token: 0x060003F6 RID: 1014 RVA: 0x000118C0 File Offset: 0x000108C0
			[DebuggerNonUserCode]
			public bool IsKet_LuanNull()
			{
				return base.IsNull(this.tableSAKHAC.Ket_LuanColumn);
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x000118E3 File Offset: 0x000108E3
			[DebuggerNonUserCode]
			public void SetKet_LuanNull()
			{
				base[this.tableSAKHAC.Ket_LuanColumn] = Convert.DBNull;
			}

			// Token: 0x060003F8 RID: 1016 RVA: 0x00011900 File Offset: 0x00010900
			[DebuggerNonUserCode]
			public bool IsDS_Anh_KQNull()
			{
				return base.IsNull(this.tableSAKHAC.DS_Anh_KQColumn);
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x00011923 File Offset: 0x00010923
			[DebuggerNonUserCode]
			public void SetDS_Anh_KQNull()
			{
				base[this.tableSAKHAC.DS_Anh_KQColumn] = Convert.DBNull;
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x00011940 File Offset: 0x00010940
			[DebuggerNonUserCode]
			public bool IsHo_Ten_BSSANull()
			{
				return base.IsNull(this.tableSAKHAC.Ho_Ten_BSSAColumn);
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x00011963 File Offset: 0x00010963
			[DebuggerNonUserCode]
			public void SetHo_Ten_BSSANull()
			{
				base[this.tableSAKHAC.Ho_Ten_BSSAColumn] = Convert.DBNull;
			}

			// Token: 0x060003FC RID: 1020 RVA: 0x00011980 File Offset: 0x00010980
			[DebuggerNonUserCode]
			public bool IsTrinh_DoNull()
			{
				return base.IsNull(this.tableSAKHAC.Trinh_DoColumn);
			}

			// Token: 0x060003FD RID: 1021 RVA: 0x000119A3 File Offset: 0x000109A3
			[DebuggerNonUserCode]
			public void SetTrinh_DoNull()
			{
				base[this.tableSAKHAC.Trinh_DoColumn] = Convert.DBNull;
			}

			// Token: 0x0400012C RID: 300
			private dsKetQuaSA.SAKHACDataTable tableSAKHAC;
		}

		// Token: 0x02000046 RID: 70
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SASKRow : DataRow
		{
			// Token: 0x060003FE RID: 1022 RVA: 0x000119BD File Offset: 0x000109BD
			[DebuggerNonUserCode]
			internal SASKRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSASK = (dsKetQuaSA.SASKDataTable)base.Table;
			}

			// Token: 0x170001EE RID: 494
			// (get) Token: 0x060003FF RID: 1023 RVA: 0x000119DC File Offset: 0x000109DC
			// (set) Token: 0x06000400 RID: 1024 RVA: 0x00011A24 File Offset: 0x00010A24
			[DebuggerNonUserCode]
			public string KetQua_SASK_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.KetQua_SASK_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'KetQua_SASK_Id' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.KetQua_SASK_IdColumn] = value;
				}
			}

			// Token: 0x170001EF RID: 495
			// (get) Token: 0x06000401 RID: 1025 RVA: 0x00011A3C File Offset: 0x00010A3C
			// (set) Token: 0x06000402 RID: 1026 RVA: 0x00011A84 File Offset: 0x00010A84
			[DebuggerNonUserCode]
			public string SA_SK_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.SA_SK_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'SA_SK_Id' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.SA_SK_IdColumn] = value;
				}
			}

			// Token: 0x170001F0 RID: 496
			// (get) Token: 0x06000403 RID: 1027 RVA: 0x00011A9C File Offset: 0x00010A9C
			// (set) Token: 0x06000404 RID: 1028 RVA: 0x00011AE4 File Offset: 0x00010AE4
			[DebuggerNonUserCode]
			public string Benh_Nhan_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.Benh_Nhan_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Benh_Nhan_Id' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.Benh_Nhan_IdColumn] = value;
				}
			}

			// Token: 0x170001F1 RID: 497
			// (get) Token: 0x06000405 RID: 1029 RVA: 0x00011AFC File Offset: 0x00010AFC
			// (set) Token: 0x06000406 RID: 1030 RVA: 0x00011B44 File Offset: 0x00010B44
			[DebuggerNonUserCode]
			public string Y_Te_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.Y_Te_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Y_Te_Id' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.Y_Te_IdColumn] = value;
				}
			}

			// Token: 0x170001F2 RID: 498
			// (get) Token: 0x06000407 RID: 1031 RVA: 0x00011B5C File Offset: 0x00010B5C
			// (set) Token: 0x06000408 RID: 1032 RVA: 0x00011BA4 File Offset: 0x00010BA4
			[DebuggerNonUserCode]
			public string Ho_Ten
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.Ho_TenColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ho_Ten' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.Ho_TenColumn] = value;
				}
			}

			// Token: 0x170001F3 RID: 499
			// (get) Token: 0x06000409 RID: 1033 RVA: 0x00011BBC File Offset: 0x00010BBC
			// (set) Token: 0x0600040A RID: 1034 RVA: 0x00011C04 File Offset: 0x00010C04
			[DebuggerNonUserCode]
			public string Gioi_Tinh
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.Gioi_TinhColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Gioi_Tinh' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.Gioi_TinhColumn] = value;
				}
			}

			// Token: 0x170001F4 RID: 500
			// (get) Token: 0x0600040B RID: 1035 RVA: 0x00011C1C File Offset: 0x00010C1C
			// (set) Token: 0x0600040C RID: 1036 RVA: 0x00011C64 File Offset: 0x00010C64
			[DebuggerNonUserCode]
			public string Nam_Sinh
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.Nam_SinhColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Nam_Sinh' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.Nam_SinhColumn] = value;
				}
			}

			// Token: 0x170001F5 RID: 501
			// (get) Token: 0x0600040D RID: 1037 RVA: 0x00011C7C File Offset: 0x00010C7C
			// (set) Token: 0x0600040E RID: 1038 RVA: 0x00011CC4 File Offset: 0x00010CC4
			[DebuggerNonUserCode]
			public string Dia_Chi
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.Dia_ChiColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Dia_Chi' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.Dia_ChiColumn] = value;
				}
			}

			// Token: 0x170001F6 RID: 502
			// (get) Token: 0x0600040F RID: 1039 RVA: 0x00011CDC File Offset: 0x00010CDC
			// (set) Token: 0x06000410 RID: 1040 RVA: 0x00011D24 File Offset: 0x00010D24
			[DebuggerNonUserCode]
			public string Ngay
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.NgayColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ngay' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.NgayColumn] = value;
				}
			}

			// Token: 0x170001F7 RID: 503
			// (get) Token: 0x06000411 RID: 1041 RVA: 0x00011D3C File Offset: 0x00010D3C
			// (set) Token: 0x06000412 RID: 1042 RVA: 0x00011D84 File Offset: 0x00010D84
			[DebuggerNonUserCode]
			public string Lam_sang
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.Lam_sangColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Lam_sang' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.Lam_sangColumn] = value;
				}
			}

			// Token: 0x170001F8 RID: 504
			// (get) Token: 0x06000413 RID: 1043 RVA: 0x00011D9C File Offset: 0x00010D9C
			// (set) Token: 0x06000414 RID: 1044 RVA: 0x00011DE4 File Offset: 0x00010DE4
			[DebuggerNonUserCode]
			public string So_Luong
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.So_LuongColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'So_Luong' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.So_LuongColumn] = value;
				}
			}

			// Token: 0x170001F9 RID: 505
			// (get) Token: 0x06000415 RID: 1045 RVA: 0x00011DFC File Offset: 0x00010DFC
			// (set) Token: 0x06000416 RID: 1046 RVA: 0x00011E44 File Offset: 0x00010E44
			[DebuggerNonUserCode]
			public string Tan_So_Tim
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.Tan_So_TimColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Tan_So_Tim' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.Tan_So_TimColumn] = value;
				}
			}

			// Token: 0x170001FA RID: 506
			// (get) Token: 0x06000417 RID: 1047 RVA: 0x00011E5C File Offset: 0x00010E5C
			// (set) Token: 0x06000418 RID: 1048 RVA: 0x00011EA4 File Offset: 0x00010EA4
			[DebuggerNonUserCode]
			public string Cu_Dong
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.Cu_DongColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Cu_Dong' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.Cu_DongColumn] = value;
				}
			}

			// Token: 0x170001FB RID: 507
			// (get) Token: 0x06000419 RID: 1049 RVA: 0x00011EBC File Offset: 0x00010EBC
			// (set) Token: 0x0600041A RID: 1050 RVA: 0x00011F04 File Offset: 0x00010F04
			[DebuggerNonUserCode]
			public string Ngoi
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.NgoiColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ngoi' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.NgoiColumn] = value;
				}
			}

			// Token: 0x170001FC RID: 508
			// (get) Token: 0x0600041B RID: 1051 RVA: 0x00011F1C File Offset: 0x00010F1C
			// (set) Token: 0x0600041C RID: 1052 RVA: 0x00011F64 File Offset: 0x00010F64
			[DebuggerNonUserCode]
			public string GS
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.GSColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'GS' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.GSColumn] = value;
				}
			}

			// Token: 0x170001FD RID: 509
			// (get) Token: 0x0600041D RID: 1053 RVA: 0x00011F7C File Offset: 0x00010F7C
			// (set) Token: 0x0600041E RID: 1054 RVA: 0x00011FC4 File Offset: 0x00010FC4
			[DebuggerNonUserCode]
			public string CRL
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.CRLColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CRL' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.CRLColumn] = value;
				}
			}

			// Token: 0x170001FE RID: 510
			// (get) Token: 0x0600041F RID: 1055 RVA: 0x00011FDC File Offset: 0x00010FDC
			// (set) Token: 0x06000420 RID: 1056 RVA: 0x00012024 File Offset: 0x00011024
			[DebuggerNonUserCode]
			public string BDP
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.BDPColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'BDP' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.BDPColumn] = value;
				}
			}

			// Token: 0x170001FF RID: 511
			// (get) Token: 0x06000421 RID: 1057 RVA: 0x0001203C File Offset: 0x0001103C
			// (set) Token: 0x06000422 RID: 1058 RVA: 0x00012084 File Offset: 0x00011084
			[DebuggerNonUserCode]
			public string FL
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.FLColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'FL' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.FLColumn] = value;
				}
			}

			// Token: 0x17000200 RID: 512
			// (get) Token: 0x06000423 RID: 1059 RVA: 0x0001209C File Offset: 0x0001109C
			// (set) Token: 0x06000424 RID: 1060 RVA: 0x000120E4 File Offset: 0x000110E4
			[DebuggerNonUserCode]
			public string APBD
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.APBDColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'APBD' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.APBDColumn] = value;
				}
			}

			// Token: 0x17000201 RID: 513
			// (get) Token: 0x06000425 RID: 1061 RVA: 0x000120FC File Offset: 0x000110FC
			// (set) Token: 0x06000426 RID: 1062 RVA: 0x00012144 File Offset: 0x00011144
			[DebuggerNonUserCode]
			public string TBD
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.TBDColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'TBD' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.TBDColumn] = value;
				}
			}

			// Token: 0x17000202 RID: 514
			// (get) Token: 0x06000427 RID: 1063 RVA: 0x0001215C File Offset: 0x0001115C
			// (set) Token: 0x06000428 RID: 1064 RVA: 0x000121A4 File Offset: 0x000111A4
			[DebuggerNonUserCode]
			public string CanNang
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.CanNangColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CanNang' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.CanNangColumn] = value;
				}
			}

			// Token: 0x17000203 RID: 515
			// (get) Token: 0x06000429 RID: 1065 RVA: 0x000121BC File Offset: 0x000111BC
			// (set) Token: 0x0600042A RID: 1066 RVA: 0x00012204 File Offset: 0x00011204
			[DebuggerNonUserCode]
			public string Di_Tat
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.Di_TatColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Di_Tat' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.Di_TatColumn] = value;
				}
			}

			// Token: 0x17000204 RID: 516
			// (get) Token: 0x0600042B RID: 1067 RVA: 0x0001221C File Offset: 0x0001121C
			// (set) Token: 0x0600042C RID: 1068 RVA: 0x00012264 File Offset: 0x00011264
			[DebuggerNonUserCode]
			public string Oi
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.OiColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Oi' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.OiColumn] = value;
				}
			}

			// Token: 0x17000205 RID: 517
			// (get) Token: 0x0600042D RID: 1069 RVA: 0x0001227C File Offset: 0x0001127C
			// (set) Token: 0x0600042E RID: 1070 RVA: 0x000122C4 File Offset: 0x000112C4
			[DebuggerNonUserCode]
			public string Ron
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.RonColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ron' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.RonColumn] = value;
				}
			}

			// Token: 0x17000206 RID: 518
			// (get) Token: 0x0600042F RID: 1071 RVA: 0x000122DC File Offset: 0x000112DC
			// (set) Token: 0x06000430 RID: 1072 RVA: 0x00012324 File Offset: 0x00011324
			[DebuggerNonUserCode]
			public string Do_Nhau
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.Do_NhauColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Do_Nhau' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.Do_NhauColumn] = value;
				}
			}

			// Token: 0x17000207 RID: 519
			// (get) Token: 0x06000431 RID: 1073 RVA: 0x0001233C File Offset: 0x0001133C
			// (set) Token: 0x06000432 RID: 1074 RVA: 0x00012384 File Offset: 0x00011384
			[DebuggerNonUserCode]
			public string Vi_Tri_Nhau
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.Vi_Tri_NhauColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Vi_Tri_Nhau' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.Vi_Tri_NhauColumn] = value;
				}
			}

			// Token: 0x17000208 RID: 520
			// (get) Token: 0x06000433 RID: 1075 RVA: 0x0001239C File Offset: 0x0001139C
			// (set) Token: 0x06000434 RID: 1076 RVA: 0x000123E4 File Offset: 0x000113E4
			[DebuggerNonUserCode]
			public string Khac
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.KhacColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Khac' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.KhacColumn] = value;
				}
			}

			// Token: 0x17000209 RID: 521
			// (get) Token: 0x06000435 RID: 1077 RVA: 0x000123FC File Offset: 0x000113FC
			// (set) Token: 0x06000436 RID: 1078 RVA: 0x00012444 File Offset: 0x00011444
			[DebuggerNonUserCode]
			public string Ket_Luan
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.Ket_LuanColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ket_Luan' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.Ket_LuanColumn] = value;
				}
			}

			// Token: 0x1700020A RID: 522
			// (get) Token: 0x06000437 RID: 1079 RVA: 0x0001245C File Offset: 0x0001145C
			// (set) Token: 0x06000438 RID: 1080 RVA: 0x000124A4 File Offset: 0x000114A4
			[DebuggerNonUserCode]
			public string DS_Anh_KQ
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.DS_Anh_KQColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'DS_Anh_KQ' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.DS_Anh_KQColumn] = value;
				}
			}

			// Token: 0x1700020B RID: 523
			// (get) Token: 0x06000439 RID: 1081 RVA: 0x000124BC File Offset: 0x000114BC
			// (set) Token: 0x0600043A RID: 1082 RVA: 0x00012504 File Offset: 0x00011504
			[DebuggerNonUserCode]
			public string Ho_Ten_BSSA
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.Ho_Ten_BSSAColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ho_Ten_BSSA' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.Ho_Ten_BSSAColumn] = value;
				}
			}

			// Token: 0x1700020C RID: 524
			// (get) Token: 0x0600043B RID: 1083 RVA: 0x0001251C File Offset: 0x0001151C
			// (set) Token: 0x0600043C RID: 1084 RVA: 0x00012564 File Offset: 0x00011564
			[DebuggerNonUserCode]
			public string Trinh_Do
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSASK.Trinh_DoColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Trinh_Do' in table 'SASK' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSASK.Trinh_DoColumn] = value;
				}
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x0001257C File Offset: 0x0001157C
			[DebuggerNonUserCode]
			public bool IsKetQua_SASK_IdNull()
			{
				return base.IsNull(this.tableSASK.KetQua_SASK_IdColumn);
			}

			// Token: 0x0600043E RID: 1086 RVA: 0x0001259F File Offset: 0x0001159F
			[DebuggerNonUserCode]
			public void SetKetQua_SASK_IdNull()
			{
				base[this.tableSASK.KetQua_SASK_IdColumn] = Convert.DBNull;
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x000125BC File Offset: 0x000115BC
			[DebuggerNonUserCode]
			public bool IsSA_SK_IdNull()
			{
				return base.IsNull(this.tableSASK.SA_SK_IdColumn);
			}

			// Token: 0x06000440 RID: 1088 RVA: 0x000125DF File Offset: 0x000115DF
			[DebuggerNonUserCode]
			public void SetSA_SK_IdNull()
			{
				base[this.tableSASK.SA_SK_IdColumn] = Convert.DBNull;
			}

			// Token: 0x06000441 RID: 1089 RVA: 0x000125FC File Offset: 0x000115FC
			[DebuggerNonUserCode]
			public bool IsBenh_Nhan_IdNull()
			{
				return base.IsNull(this.tableSASK.Benh_Nhan_IdColumn);
			}

			// Token: 0x06000442 RID: 1090 RVA: 0x0001261F File Offset: 0x0001161F
			[DebuggerNonUserCode]
			public void SetBenh_Nhan_IdNull()
			{
				base[this.tableSASK.Benh_Nhan_IdColumn] = Convert.DBNull;
			}

			// Token: 0x06000443 RID: 1091 RVA: 0x0001263C File Offset: 0x0001163C
			[DebuggerNonUserCode]
			public bool IsY_Te_IdNull()
			{
				return base.IsNull(this.tableSASK.Y_Te_IdColumn);
			}

			// Token: 0x06000444 RID: 1092 RVA: 0x0001265F File Offset: 0x0001165F
			[DebuggerNonUserCode]
			public void SetY_Te_IdNull()
			{
				base[this.tableSASK.Y_Te_IdColumn] = Convert.DBNull;
			}

			// Token: 0x06000445 RID: 1093 RVA: 0x0001267C File Offset: 0x0001167C
			[DebuggerNonUserCode]
			public bool IsHo_TenNull()
			{
				return base.IsNull(this.tableSASK.Ho_TenColumn);
			}

			// Token: 0x06000446 RID: 1094 RVA: 0x0001269F File Offset: 0x0001169F
			[DebuggerNonUserCode]
			public void SetHo_TenNull()
			{
				base[this.tableSASK.Ho_TenColumn] = Convert.DBNull;
			}

			// Token: 0x06000447 RID: 1095 RVA: 0x000126BC File Offset: 0x000116BC
			[DebuggerNonUserCode]
			public bool IsGioi_TinhNull()
			{
				return base.IsNull(this.tableSASK.Gioi_TinhColumn);
			}

			// Token: 0x06000448 RID: 1096 RVA: 0x000126DF File Offset: 0x000116DF
			[DebuggerNonUserCode]
			public void SetGioi_TinhNull()
			{
				base[this.tableSASK.Gioi_TinhColumn] = Convert.DBNull;
			}

			// Token: 0x06000449 RID: 1097 RVA: 0x000126FC File Offset: 0x000116FC
			[DebuggerNonUserCode]
			public bool IsNam_SinhNull()
			{
				return base.IsNull(this.tableSASK.Nam_SinhColumn);
			}

			// Token: 0x0600044A RID: 1098 RVA: 0x0001271F File Offset: 0x0001171F
			[DebuggerNonUserCode]
			public void SetNam_SinhNull()
			{
				base[this.tableSASK.Nam_SinhColumn] = Convert.DBNull;
			}

			// Token: 0x0600044B RID: 1099 RVA: 0x0001273C File Offset: 0x0001173C
			[DebuggerNonUserCode]
			public bool IsDia_ChiNull()
			{
				return base.IsNull(this.tableSASK.Dia_ChiColumn);
			}

			// Token: 0x0600044C RID: 1100 RVA: 0x0001275F File Offset: 0x0001175F
			[DebuggerNonUserCode]
			public void SetDia_ChiNull()
			{
				base[this.tableSASK.Dia_ChiColumn] = Convert.DBNull;
			}

			// Token: 0x0600044D RID: 1101 RVA: 0x0001277C File Offset: 0x0001177C
			[DebuggerNonUserCode]
			public bool IsNgayNull()
			{
				return base.IsNull(this.tableSASK.NgayColumn);
			}

			// Token: 0x0600044E RID: 1102 RVA: 0x0001279F File Offset: 0x0001179F
			[DebuggerNonUserCode]
			public void SetNgayNull()
			{
				base[this.tableSASK.NgayColumn] = Convert.DBNull;
			}

			// Token: 0x0600044F RID: 1103 RVA: 0x000127BC File Offset: 0x000117BC
			[DebuggerNonUserCode]
			public bool IsLam_sangNull()
			{
				return base.IsNull(this.tableSASK.Lam_sangColumn);
			}

			// Token: 0x06000450 RID: 1104 RVA: 0x000127DF File Offset: 0x000117DF
			[DebuggerNonUserCode]
			public void SetLam_sangNull()
			{
				base[this.tableSASK.Lam_sangColumn] = Convert.DBNull;
			}

			// Token: 0x06000451 RID: 1105 RVA: 0x000127FC File Offset: 0x000117FC
			[DebuggerNonUserCode]
			public bool IsSo_LuongNull()
			{
				return base.IsNull(this.tableSASK.So_LuongColumn);
			}

			// Token: 0x06000452 RID: 1106 RVA: 0x0001281F File Offset: 0x0001181F
			[DebuggerNonUserCode]
			public void SetSo_LuongNull()
			{
				base[this.tableSASK.So_LuongColumn] = Convert.DBNull;
			}

			// Token: 0x06000453 RID: 1107 RVA: 0x0001283C File Offset: 0x0001183C
			[DebuggerNonUserCode]
			public bool IsTan_So_TimNull()
			{
				return base.IsNull(this.tableSASK.Tan_So_TimColumn);
			}

			// Token: 0x06000454 RID: 1108 RVA: 0x0001285F File Offset: 0x0001185F
			[DebuggerNonUserCode]
			public void SetTan_So_TimNull()
			{
				base[this.tableSASK.Tan_So_TimColumn] = Convert.DBNull;
			}

			// Token: 0x06000455 RID: 1109 RVA: 0x0001287C File Offset: 0x0001187C
			[DebuggerNonUserCode]
			public bool IsCu_DongNull()
			{
				return base.IsNull(this.tableSASK.Cu_DongColumn);
			}

			// Token: 0x06000456 RID: 1110 RVA: 0x0001289F File Offset: 0x0001189F
			[DebuggerNonUserCode]
			public void SetCu_DongNull()
			{
				base[this.tableSASK.Cu_DongColumn] = Convert.DBNull;
			}

			// Token: 0x06000457 RID: 1111 RVA: 0x000128BC File Offset: 0x000118BC
			[DebuggerNonUserCode]
			public bool IsNgoiNull()
			{
				return base.IsNull(this.tableSASK.NgoiColumn);
			}

			// Token: 0x06000458 RID: 1112 RVA: 0x000128DF File Offset: 0x000118DF
			[DebuggerNonUserCode]
			public void SetNgoiNull()
			{
				base[this.tableSASK.NgoiColumn] = Convert.DBNull;
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x000128FC File Offset: 0x000118FC
			[DebuggerNonUserCode]
			public bool IsGSNull()
			{
				return base.IsNull(this.tableSASK.GSColumn);
			}

			// Token: 0x0600045A RID: 1114 RVA: 0x0001291F File Offset: 0x0001191F
			[DebuggerNonUserCode]
			public void SetGSNull()
			{
				base[this.tableSASK.GSColumn] = Convert.DBNull;
			}

			// Token: 0x0600045B RID: 1115 RVA: 0x0001293C File Offset: 0x0001193C
			[DebuggerNonUserCode]
			public bool IsCRLNull()
			{
				return base.IsNull(this.tableSASK.CRLColumn);
			}

			// Token: 0x0600045C RID: 1116 RVA: 0x0001295F File Offset: 0x0001195F
			[DebuggerNonUserCode]
			public void SetCRLNull()
			{
				base[this.tableSASK.CRLColumn] = Convert.DBNull;
			}

			// Token: 0x0600045D RID: 1117 RVA: 0x0001297C File Offset: 0x0001197C
			[DebuggerNonUserCode]
			public bool IsBDPNull()
			{
				return base.IsNull(this.tableSASK.BDPColumn);
			}

			// Token: 0x0600045E RID: 1118 RVA: 0x0001299F File Offset: 0x0001199F
			[DebuggerNonUserCode]
			public void SetBDPNull()
			{
				base[this.tableSASK.BDPColumn] = Convert.DBNull;
			}

			// Token: 0x0600045F RID: 1119 RVA: 0x000129BC File Offset: 0x000119BC
			[DebuggerNonUserCode]
			public bool IsFLNull()
			{
				return base.IsNull(this.tableSASK.FLColumn);
			}

			// Token: 0x06000460 RID: 1120 RVA: 0x000129DF File Offset: 0x000119DF
			[DebuggerNonUserCode]
			public void SetFLNull()
			{
				base[this.tableSASK.FLColumn] = Convert.DBNull;
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x000129FC File Offset: 0x000119FC
			[DebuggerNonUserCode]
			public bool IsAPBDNull()
			{
				return base.IsNull(this.tableSASK.APBDColumn);
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x00012A1F File Offset: 0x00011A1F
			[DebuggerNonUserCode]
			public void SetAPBDNull()
			{
				base[this.tableSASK.APBDColumn] = Convert.DBNull;
			}

			// Token: 0x06000463 RID: 1123 RVA: 0x00012A3C File Offset: 0x00011A3C
			[DebuggerNonUserCode]
			public bool IsTBDNull()
			{
				return base.IsNull(this.tableSASK.TBDColumn);
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x00012A5F File Offset: 0x00011A5F
			[DebuggerNonUserCode]
			public void SetTBDNull()
			{
				base[this.tableSASK.TBDColumn] = Convert.DBNull;
			}

			// Token: 0x06000465 RID: 1125 RVA: 0x00012A7C File Offset: 0x00011A7C
			[DebuggerNonUserCode]
			public bool IsCanNangNull()
			{
				return base.IsNull(this.tableSASK.CanNangColumn);
			}

			// Token: 0x06000466 RID: 1126 RVA: 0x00012A9F File Offset: 0x00011A9F
			[DebuggerNonUserCode]
			public void SetCanNangNull()
			{
				base[this.tableSASK.CanNangColumn] = Convert.DBNull;
			}

			// Token: 0x06000467 RID: 1127 RVA: 0x00012ABC File Offset: 0x00011ABC
			[DebuggerNonUserCode]
			public bool IsDi_TatNull()
			{
				return base.IsNull(this.tableSASK.Di_TatColumn);
			}

			// Token: 0x06000468 RID: 1128 RVA: 0x00012ADF File Offset: 0x00011ADF
			[DebuggerNonUserCode]
			public void SetDi_TatNull()
			{
				base[this.tableSASK.Di_TatColumn] = Convert.DBNull;
			}

			// Token: 0x06000469 RID: 1129 RVA: 0x00012AFC File Offset: 0x00011AFC
			[DebuggerNonUserCode]
			public bool IsOiNull()
			{
				return base.IsNull(this.tableSASK.OiColumn);
			}

			// Token: 0x0600046A RID: 1130 RVA: 0x00012B1F File Offset: 0x00011B1F
			[DebuggerNonUserCode]
			public void SetOiNull()
			{
				base[this.tableSASK.OiColumn] = Convert.DBNull;
			}

			// Token: 0x0600046B RID: 1131 RVA: 0x00012B3C File Offset: 0x00011B3C
			[DebuggerNonUserCode]
			public bool IsRonNull()
			{
				return base.IsNull(this.tableSASK.RonColumn);
			}

			// Token: 0x0600046C RID: 1132 RVA: 0x00012B5F File Offset: 0x00011B5F
			[DebuggerNonUserCode]
			public void SetRonNull()
			{
				base[this.tableSASK.RonColumn] = Convert.DBNull;
			}

			// Token: 0x0600046D RID: 1133 RVA: 0x00012B7C File Offset: 0x00011B7C
			[DebuggerNonUserCode]
			public bool IsDo_NhauNull()
			{
				return base.IsNull(this.tableSASK.Do_NhauColumn);
			}

			// Token: 0x0600046E RID: 1134 RVA: 0x00012B9F File Offset: 0x00011B9F
			[DebuggerNonUserCode]
			public void SetDo_NhauNull()
			{
				base[this.tableSASK.Do_NhauColumn] = Convert.DBNull;
			}

			// Token: 0x0600046F RID: 1135 RVA: 0x00012BBC File Offset: 0x00011BBC
			[DebuggerNonUserCode]
			public bool IsVi_Tri_NhauNull()
			{
				return base.IsNull(this.tableSASK.Vi_Tri_NhauColumn);
			}

			// Token: 0x06000470 RID: 1136 RVA: 0x00012BDF File Offset: 0x00011BDF
			[DebuggerNonUserCode]
			public void SetVi_Tri_NhauNull()
			{
				base[this.tableSASK.Vi_Tri_NhauColumn] = Convert.DBNull;
			}

			// Token: 0x06000471 RID: 1137 RVA: 0x00012BFC File Offset: 0x00011BFC
			[DebuggerNonUserCode]
			public bool IsKhacNull()
			{
				return base.IsNull(this.tableSASK.KhacColumn);
			}

			// Token: 0x06000472 RID: 1138 RVA: 0x00012C1F File Offset: 0x00011C1F
			[DebuggerNonUserCode]
			public void SetKhacNull()
			{
				base[this.tableSASK.KhacColumn] = Convert.DBNull;
			}

			// Token: 0x06000473 RID: 1139 RVA: 0x00012C3C File Offset: 0x00011C3C
			[DebuggerNonUserCode]
			public bool IsKet_LuanNull()
			{
				return base.IsNull(this.tableSASK.Ket_LuanColumn);
			}

			// Token: 0x06000474 RID: 1140 RVA: 0x00012C5F File Offset: 0x00011C5F
			[DebuggerNonUserCode]
			public void SetKet_LuanNull()
			{
				base[this.tableSASK.Ket_LuanColumn] = Convert.DBNull;
			}

			// Token: 0x06000475 RID: 1141 RVA: 0x00012C7C File Offset: 0x00011C7C
			[DebuggerNonUserCode]
			public bool IsDS_Anh_KQNull()
			{
				return base.IsNull(this.tableSASK.DS_Anh_KQColumn);
			}

			// Token: 0x06000476 RID: 1142 RVA: 0x00012C9F File Offset: 0x00011C9F
			[DebuggerNonUserCode]
			public void SetDS_Anh_KQNull()
			{
				base[this.tableSASK.DS_Anh_KQColumn] = Convert.DBNull;
			}

			// Token: 0x06000477 RID: 1143 RVA: 0x00012CBC File Offset: 0x00011CBC
			[DebuggerNonUserCode]
			public bool IsHo_Ten_BSSANull()
			{
				return base.IsNull(this.tableSASK.Ho_Ten_BSSAColumn);
			}

			// Token: 0x06000478 RID: 1144 RVA: 0x00012CDF File Offset: 0x00011CDF
			[DebuggerNonUserCode]
			public void SetHo_Ten_BSSANull()
			{
				base[this.tableSASK.Ho_Ten_BSSAColumn] = Convert.DBNull;
			}

			// Token: 0x06000479 RID: 1145 RVA: 0x00012CFC File Offset: 0x00011CFC
			[DebuggerNonUserCode]
			public bool IsTrinh_DoNull()
			{
				return base.IsNull(this.tableSASK.Trinh_DoColumn);
			}

			// Token: 0x0600047A RID: 1146 RVA: 0x00012D1F File Offset: 0x00011D1F
			[DebuggerNonUserCode]
			public void SetTrinh_DoNull()
			{
				base[this.tableSASK.Trinh_DoColumn] = Convert.DBNull;
			}

			// Token: 0x0400012D RID: 301
			private dsKetQuaSA.SASKDataTable tableSASK;
		}

		// Token: 0x02000047 RID: 71
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SATGRow : DataRow
		{
			// Token: 0x0600047B RID: 1147 RVA: 0x00012D39 File Offset: 0x00011D39
			[DebuggerNonUserCode]
			internal SATGRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSATG = (dsKetQuaSA.SATGDataTable)base.Table;
			}

			// Token: 0x1700020D RID: 525
			// (get) Token: 0x0600047C RID: 1148 RVA: 0x00012D58 File Offset: 0x00011D58
			// (set) Token: 0x0600047D RID: 1149 RVA: 0x00012DA0 File Offset: 0x00011DA0
			[DebuggerNonUserCode]
			public string KetQua_SATG_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.KetQua_SATG_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'KetQua_SATG_Id' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.KetQua_SATG_IdColumn] = value;
				}
			}

			// Token: 0x1700020E RID: 526
			// (get) Token: 0x0600047E RID: 1150 RVA: 0x00012DB8 File Offset: 0x00011DB8
			// (set) Token: 0x0600047F RID: 1151 RVA: 0x00012E00 File Offset: 0x00011E00
			[DebuggerNonUserCode]
			public string SA_TG_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.SA_TG_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'SA_TG_Id' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.SA_TG_IdColumn] = value;
				}
			}

			// Token: 0x1700020F RID: 527
			// (get) Token: 0x06000480 RID: 1152 RVA: 0x00012E18 File Offset: 0x00011E18
			// (set) Token: 0x06000481 RID: 1153 RVA: 0x00012E60 File Offset: 0x00011E60
			[DebuggerNonUserCode]
			public string Benh_Nhan_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Benh_Nhan_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Benh_Nhan_Id' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Benh_Nhan_IdColumn] = value;
				}
			}

			// Token: 0x17000210 RID: 528
			// (get) Token: 0x06000482 RID: 1154 RVA: 0x00012E78 File Offset: 0x00011E78
			// (set) Token: 0x06000483 RID: 1155 RVA: 0x00012EC0 File Offset: 0x00011EC0
			[DebuggerNonUserCode]
			public string Y_Te_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Y_Te_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Y_Te_Id' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Y_Te_IdColumn] = value;
				}
			}

			// Token: 0x17000211 RID: 529
			// (get) Token: 0x06000484 RID: 1156 RVA: 0x00012ED8 File Offset: 0x00011ED8
			// (set) Token: 0x06000485 RID: 1157 RVA: 0x00012F20 File Offset: 0x00011F20
			[DebuggerNonUserCode]
			public string Ho_Ten
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Ho_TenColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ho_Ten' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Ho_TenColumn] = value;
				}
			}

			// Token: 0x17000212 RID: 530
			// (get) Token: 0x06000486 RID: 1158 RVA: 0x00012F38 File Offset: 0x00011F38
			// (set) Token: 0x06000487 RID: 1159 RVA: 0x00012F80 File Offset: 0x00011F80
			[DebuggerNonUserCode]
			public string Gioi_Tinh
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Gioi_TinhColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Gioi_Tinh' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Gioi_TinhColumn] = value;
				}
			}

			// Token: 0x17000213 RID: 531
			// (get) Token: 0x06000488 RID: 1160 RVA: 0x00012F98 File Offset: 0x00011F98
			// (set) Token: 0x06000489 RID: 1161 RVA: 0x00012FE0 File Offset: 0x00011FE0
			[DebuggerNonUserCode]
			public string Nam_Sinh
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Nam_SinhColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Nam_Sinh' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Nam_SinhColumn] = value;
				}
			}

			// Token: 0x17000214 RID: 532
			// (get) Token: 0x0600048A RID: 1162 RVA: 0x00012FF8 File Offset: 0x00011FF8
			// (set) Token: 0x0600048B RID: 1163 RVA: 0x00013040 File Offset: 0x00012040
			[DebuggerNonUserCode]
			public string Dia_Chi
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Dia_ChiColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Dia_Chi' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Dia_ChiColumn] = value;
				}
			}

			// Token: 0x17000215 RID: 533
			// (get) Token: 0x0600048C RID: 1164 RVA: 0x00013058 File Offset: 0x00012058
			// (set) Token: 0x0600048D RID: 1165 RVA: 0x000130A0 File Offset: 0x000120A0
			[DebuggerNonUserCode]
			public string Ngay
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.NgayColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ngay' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.NgayColumn] = value;
				}
			}

			// Token: 0x17000216 RID: 534
			// (get) Token: 0x0600048E RID: 1166 RVA: 0x000130B8 File Offset: 0x000120B8
			// (set) Token: 0x0600048F RID: 1167 RVA: 0x00013100 File Offset: 0x00012100
			[DebuggerNonUserCode]
			public string Lam_sang
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Lam_sangColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Lam_sang' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Lam_sangColumn] = value;
				}
			}

			// Token: 0x17000217 RID: 535
			// (get) Token: 0x06000490 RID: 1168 RVA: 0x00013118 File Offset: 0x00012118
			// (set) Token: 0x06000491 RID: 1169 RVA: 0x00013160 File Offset: 0x00012160
			[DebuggerNonUserCode]
			public string Eo
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.EoColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Eo' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.EoColumn] = value;
				}
			}

			// Token: 0x17000218 RID: 536
			// (get) Token: 0x06000492 RID: 1170 RVA: 0x00013178 File Offset: 0x00012178
			// (set) Token: 0x06000493 RID: 1171 RVA: 0x000131C0 File Offset: 0x000121C0
			[DebuggerNonUserCode]
			public string Dai_P
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Dai_PColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Dai_P' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Dai_PColumn] = value;
				}
			}

			// Token: 0x17000219 RID: 537
			// (get) Token: 0x06000494 RID: 1172 RVA: 0x000131D8 File Offset: 0x000121D8
			// (set) Token: 0x06000495 RID: 1173 RVA: 0x00013220 File Offset: 0x00012220
			[DebuggerNonUserCode]
			public string Rong_P
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Rong_PColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Rong_P' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Rong_PColumn] = value;
				}
			}

			// Token: 0x1700021A RID: 538
			// (get) Token: 0x06000496 RID: 1174 RVA: 0x00013238 File Offset: 0x00012238
			// (set) Token: 0x06000497 RID: 1175 RVA: 0x00013280 File Offset: 0x00012280
			[DebuggerNonUserCode]
			public string Day_P
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Day_PColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Day_P' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Day_PColumn] = value;
				}
			}

			// Token: 0x1700021B RID: 539
			// (get) Token: 0x06000498 RID: 1176 RVA: 0x00013298 File Offset: 0x00012298
			// (set) Token: 0x06000499 RID: 1177 RVA: 0x000132E0 File Offset: 0x000122E0
			[DebuggerNonUserCode]
			public string Dai_T
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Dai_TColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Dai_T' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Dai_TColumn] = value;
				}
			}

			// Token: 0x1700021C RID: 540
			// (get) Token: 0x0600049A RID: 1178 RVA: 0x000132F8 File Offset: 0x000122F8
			// (set) Token: 0x0600049B RID: 1179 RVA: 0x00013340 File Offset: 0x00012340
			[DebuggerNonUserCode]
			public string Rong_T
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Rong_TColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Rong_T' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Rong_TColumn] = value;
				}
			}

			// Token: 0x1700021D RID: 541
			// (get) Token: 0x0600049C RID: 1180 RVA: 0x00013358 File Offset: 0x00012358
			// (set) Token: 0x0600049D RID: 1181 RVA: 0x000133A0 File Offset: 0x000123A0
			[DebuggerNonUserCode]
			public string Day_T
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Day_TColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Day_T' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Day_TColumn] = value;
				}
			}

			// Token: 0x1700021E RID: 542
			// (get) Token: 0x0600049E RID: 1182 RVA: 0x000133B8 File Offset: 0x000123B8
			// (set) Token: 0x0600049F RID: 1183 RVA: 0x00013400 File Offset: 0x00012400
			[DebuggerNonUserCode]
			public string Ton_Thuong
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Ton_ThuongColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ton_Thuong' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Ton_ThuongColumn] = value;
				}
			}

			// Token: 0x1700021F RID: 543
			// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00013418 File Offset: 0x00012418
			// (set) Token: 0x060004A1 RID: 1185 RVA: 0x00013460 File Offset: 0x00012460
			[DebuggerNonUserCode]
			public string Cau_Truc
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Cau_TrucColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Cau_Truc' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Cau_TrucColumn] = value;
				}
			}

			// Token: 0x17000220 RID: 544
			// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00013478 File Offset: 0x00012478
			// (set) Token: 0x060004A3 RID: 1187 RVA: 0x000134C0 File Offset: 0x000124C0
			[DebuggerNonUserCode]
			public string Hach
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.HachColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Hach' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.HachColumn] = value;
				}
			}

			// Token: 0x17000221 RID: 545
			// (get) Token: 0x060004A4 RID: 1188 RVA: 0x000134D8 File Offset: 0x000124D8
			// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00013520 File Offset: 0x00012520
			[DebuggerNonUserCode]
			public string Khac
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.KhacColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Khac' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.KhacColumn] = value;
				}
			}

			// Token: 0x17000222 RID: 546
			// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00013538 File Offset: 0x00012538
			// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00013580 File Offset: 0x00012580
			[DebuggerNonUserCode]
			public string Ket_Luan
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Ket_LuanColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ket_Luan' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Ket_LuanColumn] = value;
				}
			}

			// Token: 0x17000223 RID: 547
			// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00013598 File Offset: 0x00012598
			// (set) Token: 0x060004A9 RID: 1193 RVA: 0x000135E0 File Offset: 0x000125E0
			[DebuggerNonUserCode]
			public string DS_Anh_KQ
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.DS_Anh_KQColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'DS_Anh_KQ' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.DS_Anh_KQColumn] = value;
				}
			}

			// Token: 0x17000224 RID: 548
			// (get) Token: 0x060004AA RID: 1194 RVA: 0x000135F8 File Offset: 0x000125F8
			// (set) Token: 0x060004AB RID: 1195 RVA: 0x00013640 File Offset: 0x00012640
			[DebuggerNonUserCode]
			public string Ho_Ten_BSSA
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Ho_Ten_BSSAColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ho_Ten_BSSA' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Ho_Ten_BSSAColumn] = value;
				}
			}

			// Token: 0x17000225 RID: 549
			// (get) Token: 0x060004AC RID: 1196 RVA: 0x00013658 File Offset: 0x00012658
			// (set) Token: 0x060004AD RID: 1197 RVA: 0x000136A0 File Offset: 0x000126A0
			[DebuggerNonUserCode]
			public string Trinh_Do
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATG.Trinh_DoColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Trinh_Do' in table 'SATG' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATG.Trinh_DoColumn] = value;
				}
			}

			// Token: 0x060004AE RID: 1198 RVA: 0x000136B8 File Offset: 0x000126B8
			[DebuggerNonUserCode]
			public bool IsKetQua_SATG_IdNull()
			{
				return base.IsNull(this.tableSATG.KetQua_SATG_IdColumn);
			}

			// Token: 0x060004AF RID: 1199 RVA: 0x000136DB File Offset: 0x000126DB
			[DebuggerNonUserCode]
			public void SetKetQua_SATG_IdNull()
			{
				base[this.tableSATG.KetQua_SATG_IdColumn] = Convert.DBNull;
			}

			// Token: 0x060004B0 RID: 1200 RVA: 0x000136F8 File Offset: 0x000126F8
			[DebuggerNonUserCode]
			public bool IsSA_TG_IdNull()
			{
				return base.IsNull(this.tableSATG.SA_TG_IdColumn);
			}

			// Token: 0x060004B1 RID: 1201 RVA: 0x0001371B File Offset: 0x0001271B
			[DebuggerNonUserCode]
			public void SetSA_TG_IdNull()
			{
				base[this.tableSATG.SA_TG_IdColumn] = Convert.DBNull;
			}

			// Token: 0x060004B2 RID: 1202 RVA: 0x00013738 File Offset: 0x00012738
			[DebuggerNonUserCode]
			public bool IsBenh_Nhan_IdNull()
			{
				return base.IsNull(this.tableSATG.Benh_Nhan_IdColumn);
			}

			// Token: 0x060004B3 RID: 1203 RVA: 0x0001375B File Offset: 0x0001275B
			[DebuggerNonUserCode]
			public void SetBenh_Nhan_IdNull()
			{
				base[this.tableSATG.Benh_Nhan_IdColumn] = Convert.DBNull;
			}

			// Token: 0x060004B4 RID: 1204 RVA: 0x00013778 File Offset: 0x00012778
			[DebuggerNonUserCode]
			public bool IsY_Te_IdNull()
			{
				return base.IsNull(this.tableSATG.Y_Te_IdColumn);
			}

			// Token: 0x060004B5 RID: 1205 RVA: 0x0001379B File Offset: 0x0001279B
			[DebuggerNonUserCode]
			public void SetY_Te_IdNull()
			{
				base[this.tableSATG.Y_Te_IdColumn] = Convert.DBNull;
			}

			// Token: 0x060004B6 RID: 1206 RVA: 0x000137B8 File Offset: 0x000127B8
			[DebuggerNonUserCode]
			public bool IsHo_TenNull()
			{
				return base.IsNull(this.tableSATG.Ho_TenColumn);
			}

			// Token: 0x060004B7 RID: 1207 RVA: 0x000137DB File Offset: 0x000127DB
			[DebuggerNonUserCode]
			public void SetHo_TenNull()
			{
				base[this.tableSATG.Ho_TenColumn] = Convert.DBNull;
			}

			// Token: 0x060004B8 RID: 1208 RVA: 0x000137F8 File Offset: 0x000127F8
			[DebuggerNonUserCode]
			public bool IsGioi_TinhNull()
			{
				return base.IsNull(this.tableSATG.Gioi_TinhColumn);
			}

			// Token: 0x060004B9 RID: 1209 RVA: 0x0001381B File Offset: 0x0001281B
			[DebuggerNonUserCode]
			public void SetGioi_TinhNull()
			{
				base[this.tableSATG.Gioi_TinhColumn] = Convert.DBNull;
			}

			// Token: 0x060004BA RID: 1210 RVA: 0x00013838 File Offset: 0x00012838
			[DebuggerNonUserCode]
			public bool IsNam_SinhNull()
			{
				return base.IsNull(this.tableSATG.Nam_SinhColumn);
			}

			// Token: 0x060004BB RID: 1211 RVA: 0x0001385B File Offset: 0x0001285B
			[DebuggerNonUserCode]
			public void SetNam_SinhNull()
			{
				base[this.tableSATG.Nam_SinhColumn] = Convert.DBNull;
			}

			// Token: 0x060004BC RID: 1212 RVA: 0x00013878 File Offset: 0x00012878
			[DebuggerNonUserCode]
			public bool IsDia_ChiNull()
			{
				return base.IsNull(this.tableSATG.Dia_ChiColumn);
			}

			// Token: 0x060004BD RID: 1213 RVA: 0x0001389B File Offset: 0x0001289B
			[DebuggerNonUserCode]
			public void SetDia_ChiNull()
			{
				base[this.tableSATG.Dia_ChiColumn] = Convert.DBNull;
			}

			// Token: 0x060004BE RID: 1214 RVA: 0x000138B8 File Offset: 0x000128B8
			[DebuggerNonUserCode]
			public bool IsNgayNull()
			{
				return base.IsNull(this.tableSATG.NgayColumn);
			}

			// Token: 0x060004BF RID: 1215 RVA: 0x000138DB File Offset: 0x000128DB
			[DebuggerNonUserCode]
			public void SetNgayNull()
			{
				base[this.tableSATG.NgayColumn] = Convert.DBNull;
			}

			// Token: 0x060004C0 RID: 1216 RVA: 0x000138F8 File Offset: 0x000128F8
			[DebuggerNonUserCode]
			public bool IsLam_sangNull()
			{
				return base.IsNull(this.tableSATG.Lam_sangColumn);
			}

			// Token: 0x060004C1 RID: 1217 RVA: 0x0001391B File Offset: 0x0001291B
			[DebuggerNonUserCode]
			public void SetLam_sangNull()
			{
				base[this.tableSATG.Lam_sangColumn] = Convert.DBNull;
			}

			// Token: 0x060004C2 RID: 1218 RVA: 0x00013938 File Offset: 0x00012938
			[DebuggerNonUserCode]
			public bool IsEoNull()
			{
				return base.IsNull(this.tableSATG.EoColumn);
			}

			// Token: 0x060004C3 RID: 1219 RVA: 0x0001395B File Offset: 0x0001295B
			[DebuggerNonUserCode]
			public void SetEoNull()
			{
				base[this.tableSATG.EoColumn] = Convert.DBNull;
			}

			// Token: 0x060004C4 RID: 1220 RVA: 0x00013978 File Offset: 0x00012978
			[DebuggerNonUserCode]
			public bool IsDai_PNull()
			{
				return base.IsNull(this.tableSATG.Dai_PColumn);
			}

			// Token: 0x060004C5 RID: 1221 RVA: 0x0001399B File Offset: 0x0001299B
			[DebuggerNonUserCode]
			public void SetDai_PNull()
			{
				base[this.tableSATG.Dai_PColumn] = Convert.DBNull;
			}

			// Token: 0x060004C6 RID: 1222 RVA: 0x000139B8 File Offset: 0x000129B8
			[DebuggerNonUserCode]
			public bool IsRong_PNull()
			{
				return base.IsNull(this.tableSATG.Rong_PColumn);
			}

			// Token: 0x060004C7 RID: 1223 RVA: 0x000139DB File Offset: 0x000129DB
			[DebuggerNonUserCode]
			public void SetRong_PNull()
			{
				base[this.tableSATG.Rong_PColumn] = Convert.DBNull;
			}

			// Token: 0x060004C8 RID: 1224 RVA: 0x000139F8 File Offset: 0x000129F8
			[DebuggerNonUserCode]
			public bool IsDay_PNull()
			{
				return base.IsNull(this.tableSATG.Day_PColumn);
			}

			// Token: 0x060004C9 RID: 1225 RVA: 0x00013A1B File Offset: 0x00012A1B
			[DebuggerNonUserCode]
			public void SetDay_PNull()
			{
				base[this.tableSATG.Day_PColumn] = Convert.DBNull;
			}

			// Token: 0x060004CA RID: 1226 RVA: 0x00013A38 File Offset: 0x00012A38
			[DebuggerNonUserCode]
			public bool IsDai_TNull()
			{
				return base.IsNull(this.tableSATG.Dai_TColumn);
			}

			// Token: 0x060004CB RID: 1227 RVA: 0x00013A5B File Offset: 0x00012A5B
			[DebuggerNonUserCode]
			public void SetDai_TNull()
			{
				base[this.tableSATG.Dai_TColumn] = Convert.DBNull;
			}

			// Token: 0x060004CC RID: 1228 RVA: 0x00013A78 File Offset: 0x00012A78
			[DebuggerNonUserCode]
			public bool IsRong_TNull()
			{
				return base.IsNull(this.tableSATG.Rong_TColumn);
			}

			// Token: 0x060004CD RID: 1229 RVA: 0x00013A9B File Offset: 0x00012A9B
			[DebuggerNonUserCode]
			public void SetRong_TNull()
			{
				base[this.tableSATG.Rong_TColumn] = Convert.DBNull;
			}

			// Token: 0x060004CE RID: 1230 RVA: 0x00013AB8 File Offset: 0x00012AB8
			[DebuggerNonUserCode]
			public bool IsDay_TNull()
			{
				return base.IsNull(this.tableSATG.Day_TColumn);
			}

			// Token: 0x060004CF RID: 1231 RVA: 0x00013ADB File Offset: 0x00012ADB
			[DebuggerNonUserCode]
			public void SetDay_TNull()
			{
				base[this.tableSATG.Day_TColumn] = Convert.DBNull;
			}

			// Token: 0x060004D0 RID: 1232 RVA: 0x00013AF8 File Offset: 0x00012AF8
			[DebuggerNonUserCode]
			public bool IsTon_ThuongNull()
			{
				return base.IsNull(this.tableSATG.Ton_ThuongColumn);
			}

			// Token: 0x060004D1 RID: 1233 RVA: 0x00013B1B File Offset: 0x00012B1B
			[DebuggerNonUserCode]
			public void SetTon_ThuongNull()
			{
				base[this.tableSATG.Ton_ThuongColumn] = Convert.DBNull;
			}

			// Token: 0x060004D2 RID: 1234 RVA: 0x00013B38 File Offset: 0x00012B38
			[DebuggerNonUserCode]
			public bool IsCau_TrucNull()
			{
				return base.IsNull(this.tableSATG.Cau_TrucColumn);
			}

			// Token: 0x060004D3 RID: 1235 RVA: 0x00013B5B File Offset: 0x00012B5B
			[DebuggerNonUserCode]
			public void SetCau_TrucNull()
			{
				base[this.tableSATG.Cau_TrucColumn] = Convert.DBNull;
			}

			// Token: 0x060004D4 RID: 1236 RVA: 0x00013B78 File Offset: 0x00012B78
			[DebuggerNonUserCode]
			public bool IsHachNull()
			{
				return base.IsNull(this.tableSATG.HachColumn);
			}

			// Token: 0x060004D5 RID: 1237 RVA: 0x00013B9B File Offset: 0x00012B9B
			[DebuggerNonUserCode]
			public void SetHachNull()
			{
				base[this.tableSATG.HachColumn] = Convert.DBNull;
			}

			// Token: 0x060004D6 RID: 1238 RVA: 0x00013BB8 File Offset: 0x00012BB8
			[DebuggerNonUserCode]
			public bool IsKhacNull()
			{
				return base.IsNull(this.tableSATG.KhacColumn);
			}

			// Token: 0x060004D7 RID: 1239 RVA: 0x00013BDB File Offset: 0x00012BDB
			[DebuggerNonUserCode]
			public void SetKhacNull()
			{
				base[this.tableSATG.KhacColumn] = Convert.DBNull;
			}

			// Token: 0x060004D8 RID: 1240 RVA: 0x00013BF8 File Offset: 0x00012BF8
			[DebuggerNonUserCode]
			public bool IsKet_LuanNull()
			{
				return base.IsNull(this.tableSATG.Ket_LuanColumn);
			}

			// Token: 0x060004D9 RID: 1241 RVA: 0x00013C1B File Offset: 0x00012C1B
			[DebuggerNonUserCode]
			public void SetKet_LuanNull()
			{
				base[this.tableSATG.Ket_LuanColumn] = Convert.DBNull;
			}

			// Token: 0x060004DA RID: 1242 RVA: 0x00013C38 File Offset: 0x00012C38
			[DebuggerNonUserCode]
			public bool IsDS_Anh_KQNull()
			{
				return base.IsNull(this.tableSATG.DS_Anh_KQColumn);
			}

			// Token: 0x060004DB RID: 1243 RVA: 0x00013C5B File Offset: 0x00012C5B
			[DebuggerNonUserCode]
			public void SetDS_Anh_KQNull()
			{
				base[this.tableSATG.DS_Anh_KQColumn] = Convert.DBNull;
			}

			// Token: 0x060004DC RID: 1244 RVA: 0x00013C78 File Offset: 0x00012C78
			[DebuggerNonUserCode]
			public bool IsHo_Ten_BSSANull()
			{
				return base.IsNull(this.tableSATG.Ho_Ten_BSSAColumn);
			}

			// Token: 0x060004DD RID: 1245 RVA: 0x00013C9B File Offset: 0x00012C9B
			[DebuggerNonUserCode]
			public void SetHo_Ten_BSSANull()
			{
				base[this.tableSATG.Ho_Ten_BSSAColumn] = Convert.DBNull;
			}

			// Token: 0x060004DE RID: 1246 RVA: 0x00013CB8 File Offset: 0x00012CB8
			[DebuggerNonUserCode]
			public bool IsTrinh_DoNull()
			{
				return base.IsNull(this.tableSATG.Trinh_DoColumn);
			}

			// Token: 0x060004DF RID: 1247 RVA: 0x00013CDB File Offset: 0x00012CDB
			[DebuggerNonUserCode]
			public void SetTrinh_DoNull()
			{
				base[this.tableSATG.Trinh_DoColumn] = Convert.DBNull;
			}

			// Token: 0x0400012E RID: 302
			private dsKetQuaSA.SATGDataTable tableSATG;
		}

		// Token: 0x02000048 RID: 72
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SATVRow : DataRow
		{
			// Token: 0x060004E0 RID: 1248 RVA: 0x00013CF5 File Offset: 0x00012CF5
			[DebuggerNonUserCode]
			internal SATVRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSATV = (dsKetQuaSA.SATVDataTable)base.Table;
			}

			// Token: 0x17000226 RID: 550
			// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00013D14 File Offset: 0x00012D14
			// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00013D5C File Offset: 0x00012D5C
			[DebuggerNonUserCode]
			public string KetQua_SATV_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.KetQua_SATV_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'KetQua_SATV_Id' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.KetQua_SATV_IdColumn] = value;
				}
			}

			// Token: 0x17000227 RID: 551
			// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00013D74 File Offset: 0x00012D74
			// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00013DBC File Offset: 0x00012DBC
			[DebuggerNonUserCode]
			public string SA_TV_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.SA_TV_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'SA_TV_Id' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.SA_TV_IdColumn] = value;
				}
			}

			// Token: 0x17000228 RID: 552
			// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00013DD4 File Offset: 0x00012DD4
			// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00013E1C File Offset: 0x00012E1C
			[DebuggerNonUserCode]
			public string Benh_Nhan_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.Benh_Nhan_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Benh_Nhan_Id' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.Benh_Nhan_IdColumn] = value;
				}
			}

			// Token: 0x17000229 RID: 553
			// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00013E34 File Offset: 0x00012E34
			// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00013E7C File Offset: 0x00012E7C
			[DebuggerNonUserCode]
			public string Y_Te_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.Y_Te_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Y_Te_Id' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.Y_Te_IdColumn] = value;
				}
			}

			// Token: 0x1700022A RID: 554
			// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00013E94 File Offset: 0x00012E94
			// (set) Token: 0x060004EA RID: 1258 RVA: 0x00013EDC File Offset: 0x00012EDC
			[DebuggerNonUserCode]
			public string Ho_Ten
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.Ho_TenColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ho_Ten' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.Ho_TenColumn] = value;
				}
			}

			// Token: 0x1700022B RID: 555
			// (get) Token: 0x060004EB RID: 1259 RVA: 0x00013EF4 File Offset: 0x00012EF4
			// (set) Token: 0x060004EC RID: 1260 RVA: 0x00013F3C File Offset: 0x00012F3C
			[DebuggerNonUserCode]
			public string Gioi_Tinh
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.Gioi_TinhColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Gioi_Tinh' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.Gioi_TinhColumn] = value;
				}
			}

			// Token: 0x1700022C RID: 556
			// (get) Token: 0x060004ED RID: 1261 RVA: 0x00013F54 File Offset: 0x00012F54
			// (set) Token: 0x060004EE RID: 1262 RVA: 0x00013F9C File Offset: 0x00012F9C
			[DebuggerNonUserCode]
			public string Nam_Sinh
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.Nam_SinhColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Nam_Sinh' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.Nam_SinhColumn] = value;
				}
			}

			// Token: 0x1700022D RID: 557
			// (get) Token: 0x060004EF RID: 1263 RVA: 0x00013FB4 File Offset: 0x00012FB4
			// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00013FFC File Offset: 0x00012FFC
			[DebuggerNonUserCode]
			public string Dia_Chi
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.Dia_ChiColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Dia_Chi' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.Dia_ChiColumn] = value;
				}
			}

			// Token: 0x1700022E RID: 558
			// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00014014 File Offset: 0x00013014
			// (set) Token: 0x060004F2 RID: 1266 RVA: 0x0001405C File Offset: 0x0001305C
			[DebuggerNonUserCode]
			public string Ngay
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.NgayColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ngay' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.NgayColumn] = value;
				}
			}

			// Token: 0x1700022F RID: 559
			// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00014074 File Offset: 0x00013074
			// (set) Token: 0x060004F4 RID: 1268 RVA: 0x000140BC File Offset: 0x000130BC
			[DebuggerNonUserCode]
			public string Lam_sang
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.Lam_sangColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Lam_sang' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.Lam_sangColumn] = value;
				}
			}

			// Token: 0x17000230 RID: 560
			// (get) Token: 0x060004F5 RID: 1269 RVA: 0x000140D4 File Offset: 0x000130D4
			// (set) Token: 0x060004F6 RID: 1270 RVA: 0x0001411C File Offset: 0x0001311C
			[DebuggerNonUserCode]
			public string Vi_Tri_Ton_Thuong
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.Vi_Tri_Ton_ThuongColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Vi_Tri_Ton_Thuong' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.Vi_Tri_Ton_ThuongColumn] = value;
				}
			}

			// Token: 0x17000231 RID: 561
			// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00014134 File Offset: 0x00013134
			// (set) Token: 0x060004F8 RID: 1272 RVA: 0x0001417C File Offset: 0x0001317C
			[DebuggerNonUserCode]
			public string Hach
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.HachColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Hach' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.HachColumn] = value;
				}
			}

			// Token: 0x17000232 RID: 562
			// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00014194 File Offset: 0x00013194
			// (set) Token: 0x060004FA RID: 1274 RVA: 0x000141DC File Offset: 0x000131DC
			[DebuggerNonUserCode]
			public string Cau_Truc
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.Cau_TrucColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Cau_Truc' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.Cau_TrucColumn] = value;
				}
			}

			// Token: 0x17000233 RID: 563
			// (get) Token: 0x060004FB RID: 1275 RVA: 0x000141F4 File Offset: 0x000131F4
			// (set) Token: 0x060004FC RID: 1276 RVA: 0x0001423C File Offset: 0x0001323C
			[DebuggerNonUserCode]
			public string Kich_Thuoc_Buou
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.Kich_Thuoc_BuouColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Kich_Thuoc_Buou' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.Kich_Thuoc_BuouColumn] = value;
				}
			}

			// Token: 0x17000234 RID: 564
			// (get) Token: 0x060004FD RID: 1277 RVA: 0x00014254 File Offset: 0x00013254
			// (set) Token: 0x060004FE RID: 1278 RVA: 0x0001429C File Offset: 0x0001329C
			[DebuggerNonUserCode]
			public string Bo_Buou
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.Bo_BuouColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Bo_Buou' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.Bo_BuouColumn] = value;
				}
			}

			// Token: 0x17000235 RID: 565
			// (get) Token: 0x060004FF RID: 1279 RVA: 0x000142B4 File Offset: 0x000132B4
			// (set) Token: 0x06000500 RID: 1280 RVA: 0x000142FC File Offset: 0x000132FC
			[DebuggerNonUserCode]
			public string Cau_Truc_Buou
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.Cau_Truc_BuouColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Cau_Truc_Buou' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.Cau_Truc_BuouColumn] = value;
				}
			}

			// Token: 0x17000236 RID: 566
			// (get) Token: 0x06000501 RID: 1281 RVA: 0x00014314 File Offset: 0x00013314
			// (set) Token: 0x06000502 RID: 1282 RVA: 0x0001435C File Offset: 0x0001335C
			[DebuggerNonUserCode]
			public string Khac
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.KhacColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Khac' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.KhacColumn] = value;
				}
			}

			// Token: 0x17000237 RID: 567
			// (get) Token: 0x06000503 RID: 1283 RVA: 0x00014374 File Offset: 0x00013374
			// (set) Token: 0x06000504 RID: 1284 RVA: 0x000143BC File Offset: 0x000133BC
			[DebuggerNonUserCode]
			public string Ket_Luan
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.Ket_LuanColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ket_Luan' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.Ket_LuanColumn] = value;
				}
			}

			// Token: 0x17000238 RID: 568
			// (get) Token: 0x06000505 RID: 1285 RVA: 0x000143D4 File Offset: 0x000133D4
			// (set) Token: 0x06000506 RID: 1286 RVA: 0x0001441C File Offset: 0x0001341C
			[DebuggerNonUserCode]
			public string DS_Anh_KQ
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.DS_Anh_KQColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'DS_Anh_KQ' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.DS_Anh_KQColumn] = value;
				}
			}

			// Token: 0x17000239 RID: 569
			// (get) Token: 0x06000507 RID: 1287 RVA: 0x00014434 File Offset: 0x00013434
			// (set) Token: 0x06000508 RID: 1288 RVA: 0x0001447C File Offset: 0x0001347C
			[DebuggerNonUserCode]
			public string Ho_Ten_BSSA
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.Ho_Ten_BSSAColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ho_Ten_BSSA' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.Ho_Ten_BSSAColumn] = value;
				}
			}

			// Token: 0x1700023A RID: 570
			// (get) Token: 0x06000509 RID: 1289 RVA: 0x00014494 File Offset: 0x00013494
			// (set) Token: 0x0600050A RID: 1290 RVA: 0x000144DC File Offset: 0x000134DC
			[DebuggerNonUserCode]
			public string Trinh_Do
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATV.Trinh_DoColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Trinh_Do' in table 'SATV' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATV.Trinh_DoColumn] = value;
				}
			}

			// Token: 0x0600050B RID: 1291 RVA: 0x000144F4 File Offset: 0x000134F4
			[DebuggerNonUserCode]
			public bool IsKetQua_SATV_IdNull()
			{
				return base.IsNull(this.tableSATV.KetQua_SATV_IdColumn);
			}

			// Token: 0x0600050C RID: 1292 RVA: 0x00014517 File Offset: 0x00013517
			[DebuggerNonUserCode]
			public void SetKetQua_SATV_IdNull()
			{
				base[this.tableSATV.KetQua_SATV_IdColumn] = Convert.DBNull;
			}

			// Token: 0x0600050D RID: 1293 RVA: 0x00014534 File Offset: 0x00013534
			[DebuggerNonUserCode]
			public bool IsSA_TV_IdNull()
			{
				return base.IsNull(this.tableSATV.SA_TV_IdColumn);
			}

			// Token: 0x0600050E RID: 1294 RVA: 0x00014557 File Offset: 0x00013557
			[DebuggerNonUserCode]
			public void SetSA_TV_IdNull()
			{
				base[this.tableSATV.SA_TV_IdColumn] = Convert.DBNull;
			}

			// Token: 0x0600050F RID: 1295 RVA: 0x00014574 File Offset: 0x00013574
			[DebuggerNonUserCode]
			public bool IsBenh_Nhan_IdNull()
			{
				return base.IsNull(this.tableSATV.Benh_Nhan_IdColumn);
			}

			// Token: 0x06000510 RID: 1296 RVA: 0x00014597 File Offset: 0x00013597
			[DebuggerNonUserCode]
			public void SetBenh_Nhan_IdNull()
			{
				base[this.tableSATV.Benh_Nhan_IdColumn] = Convert.DBNull;
			}

			// Token: 0x06000511 RID: 1297 RVA: 0x000145B4 File Offset: 0x000135B4
			[DebuggerNonUserCode]
			public bool IsY_Te_IdNull()
			{
				return base.IsNull(this.tableSATV.Y_Te_IdColumn);
			}

			// Token: 0x06000512 RID: 1298 RVA: 0x000145D7 File Offset: 0x000135D7
			[DebuggerNonUserCode]
			public void SetY_Te_IdNull()
			{
				base[this.tableSATV.Y_Te_IdColumn] = Convert.DBNull;
			}

			// Token: 0x06000513 RID: 1299 RVA: 0x000145F4 File Offset: 0x000135F4
			[DebuggerNonUserCode]
			public bool IsHo_TenNull()
			{
				return base.IsNull(this.tableSATV.Ho_TenColumn);
			}

			// Token: 0x06000514 RID: 1300 RVA: 0x00014617 File Offset: 0x00013617
			[DebuggerNonUserCode]
			public void SetHo_TenNull()
			{
				base[this.tableSATV.Ho_TenColumn] = Convert.DBNull;
			}

			// Token: 0x06000515 RID: 1301 RVA: 0x00014634 File Offset: 0x00013634
			[DebuggerNonUserCode]
			public bool IsGioi_TinhNull()
			{
				return base.IsNull(this.tableSATV.Gioi_TinhColumn);
			}

			// Token: 0x06000516 RID: 1302 RVA: 0x00014657 File Offset: 0x00013657
			[DebuggerNonUserCode]
			public void SetGioi_TinhNull()
			{
				base[this.tableSATV.Gioi_TinhColumn] = Convert.DBNull;
			}

			// Token: 0x06000517 RID: 1303 RVA: 0x00014674 File Offset: 0x00013674
			[DebuggerNonUserCode]
			public bool IsNam_SinhNull()
			{
				return base.IsNull(this.tableSATV.Nam_SinhColumn);
			}

			// Token: 0x06000518 RID: 1304 RVA: 0x00014697 File Offset: 0x00013697
			[DebuggerNonUserCode]
			public void SetNam_SinhNull()
			{
				base[this.tableSATV.Nam_SinhColumn] = Convert.DBNull;
			}

			// Token: 0x06000519 RID: 1305 RVA: 0x000146B4 File Offset: 0x000136B4
			[DebuggerNonUserCode]
			public bool IsDia_ChiNull()
			{
				return base.IsNull(this.tableSATV.Dia_ChiColumn);
			}

			// Token: 0x0600051A RID: 1306 RVA: 0x000146D7 File Offset: 0x000136D7
			[DebuggerNonUserCode]
			public void SetDia_ChiNull()
			{
				base[this.tableSATV.Dia_ChiColumn] = Convert.DBNull;
			}

			// Token: 0x0600051B RID: 1307 RVA: 0x000146F4 File Offset: 0x000136F4
			[DebuggerNonUserCode]
			public bool IsNgayNull()
			{
				return base.IsNull(this.tableSATV.NgayColumn);
			}

			// Token: 0x0600051C RID: 1308 RVA: 0x00014717 File Offset: 0x00013717
			[DebuggerNonUserCode]
			public void SetNgayNull()
			{
				base[this.tableSATV.NgayColumn] = Convert.DBNull;
			}

			// Token: 0x0600051D RID: 1309 RVA: 0x00014734 File Offset: 0x00013734
			[DebuggerNonUserCode]
			public bool IsLam_sangNull()
			{
				return base.IsNull(this.tableSATV.Lam_sangColumn);
			}

			// Token: 0x0600051E RID: 1310 RVA: 0x00014757 File Offset: 0x00013757
			[DebuggerNonUserCode]
			public void SetLam_sangNull()
			{
				base[this.tableSATV.Lam_sangColumn] = Convert.DBNull;
			}

			// Token: 0x0600051F RID: 1311 RVA: 0x00014774 File Offset: 0x00013774
			[DebuggerNonUserCode]
			public bool IsVi_Tri_Ton_ThuongNull()
			{
				return base.IsNull(this.tableSATV.Vi_Tri_Ton_ThuongColumn);
			}

			// Token: 0x06000520 RID: 1312 RVA: 0x00014797 File Offset: 0x00013797
			[DebuggerNonUserCode]
			public void SetVi_Tri_Ton_ThuongNull()
			{
				base[this.tableSATV.Vi_Tri_Ton_ThuongColumn] = Convert.DBNull;
			}

			// Token: 0x06000521 RID: 1313 RVA: 0x000147B4 File Offset: 0x000137B4
			[DebuggerNonUserCode]
			public bool IsHachNull()
			{
				return base.IsNull(this.tableSATV.HachColumn);
			}

			// Token: 0x06000522 RID: 1314 RVA: 0x000147D7 File Offset: 0x000137D7
			[DebuggerNonUserCode]
			public void SetHachNull()
			{
				base[this.tableSATV.HachColumn] = Convert.DBNull;
			}

			// Token: 0x06000523 RID: 1315 RVA: 0x000147F4 File Offset: 0x000137F4
			[DebuggerNonUserCode]
			public bool IsCau_TrucNull()
			{
				return base.IsNull(this.tableSATV.Cau_TrucColumn);
			}

			// Token: 0x06000524 RID: 1316 RVA: 0x00014817 File Offset: 0x00013817
			[DebuggerNonUserCode]
			public void SetCau_TrucNull()
			{
				base[this.tableSATV.Cau_TrucColumn] = Convert.DBNull;
			}

			// Token: 0x06000525 RID: 1317 RVA: 0x00014834 File Offset: 0x00013834
			[DebuggerNonUserCode]
			public bool IsKich_Thuoc_BuouNull()
			{
				return base.IsNull(this.tableSATV.Kich_Thuoc_BuouColumn);
			}

			// Token: 0x06000526 RID: 1318 RVA: 0x00014857 File Offset: 0x00013857
			[DebuggerNonUserCode]
			public void SetKich_Thuoc_BuouNull()
			{
				base[this.tableSATV.Kich_Thuoc_BuouColumn] = Convert.DBNull;
			}

			// Token: 0x06000527 RID: 1319 RVA: 0x00014874 File Offset: 0x00013874
			[DebuggerNonUserCode]
			public bool IsBo_BuouNull()
			{
				return base.IsNull(this.tableSATV.Bo_BuouColumn);
			}

			// Token: 0x06000528 RID: 1320 RVA: 0x00014897 File Offset: 0x00013897
			[DebuggerNonUserCode]
			public void SetBo_BuouNull()
			{
				base[this.tableSATV.Bo_BuouColumn] = Convert.DBNull;
			}

			// Token: 0x06000529 RID: 1321 RVA: 0x000148B4 File Offset: 0x000138B4
			[DebuggerNonUserCode]
			public bool IsCau_Truc_BuouNull()
			{
				return base.IsNull(this.tableSATV.Cau_Truc_BuouColumn);
			}

			// Token: 0x0600052A RID: 1322 RVA: 0x000148D7 File Offset: 0x000138D7
			[DebuggerNonUserCode]
			public void SetCau_Truc_BuouNull()
			{
				base[this.tableSATV.Cau_Truc_BuouColumn] = Convert.DBNull;
			}

			// Token: 0x0600052B RID: 1323 RVA: 0x000148F4 File Offset: 0x000138F4
			[DebuggerNonUserCode]
			public bool IsKhacNull()
			{
				return base.IsNull(this.tableSATV.KhacColumn);
			}

			// Token: 0x0600052C RID: 1324 RVA: 0x00014917 File Offset: 0x00013917
			[DebuggerNonUserCode]
			public void SetKhacNull()
			{
				base[this.tableSATV.KhacColumn] = Convert.DBNull;
			}

			// Token: 0x0600052D RID: 1325 RVA: 0x00014934 File Offset: 0x00013934
			[DebuggerNonUserCode]
			public bool IsKet_LuanNull()
			{
				return base.IsNull(this.tableSATV.Ket_LuanColumn);
			}

			// Token: 0x0600052E RID: 1326 RVA: 0x00014957 File Offset: 0x00013957
			[DebuggerNonUserCode]
			public void SetKet_LuanNull()
			{
				base[this.tableSATV.Ket_LuanColumn] = Convert.DBNull;
			}

			// Token: 0x0600052F RID: 1327 RVA: 0x00014974 File Offset: 0x00013974
			[DebuggerNonUserCode]
			public bool IsDS_Anh_KQNull()
			{
				return base.IsNull(this.tableSATV.DS_Anh_KQColumn);
			}

			// Token: 0x06000530 RID: 1328 RVA: 0x00014997 File Offset: 0x00013997
			[DebuggerNonUserCode]
			public void SetDS_Anh_KQNull()
			{
				base[this.tableSATV.DS_Anh_KQColumn] = Convert.DBNull;
			}

			// Token: 0x06000531 RID: 1329 RVA: 0x000149B4 File Offset: 0x000139B4
			[DebuggerNonUserCode]
			public bool IsHo_Ten_BSSANull()
			{
				return base.IsNull(this.tableSATV.Ho_Ten_BSSAColumn);
			}

			// Token: 0x06000532 RID: 1330 RVA: 0x000149D7 File Offset: 0x000139D7
			[DebuggerNonUserCode]
			public void SetHo_Ten_BSSANull()
			{
				base[this.tableSATV.Ho_Ten_BSSAColumn] = Convert.DBNull;
			}

			// Token: 0x06000533 RID: 1331 RVA: 0x000149F4 File Offset: 0x000139F4
			[DebuggerNonUserCode]
			public bool IsTrinh_DoNull()
			{
				return base.IsNull(this.tableSATV.Trinh_DoColumn);
			}

			// Token: 0x06000534 RID: 1332 RVA: 0x00014A17 File Offset: 0x00013A17
			[DebuggerNonUserCode]
			public void SetTrinh_DoNull()
			{
				base[this.tableSATV.Trinh_DoColumn] = Convert.DBNull;
			}

			// Token: 0x0400012F RID: 303
			private dsKetQuaSA.SATVDataTable tableSATV;
		}

		// Token: 0x02000049 RID: 73
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SATQRow : DataRow
		{
			// Token: 0x06000535 RID: 1333 RVA: 0x00014A31 File Offset: 0x00013A31
			[DebuggerNonUserCode]
			internal SATQRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSATQ = (dsKetQuaSA.SATQDataTable)base.Table;
			}

			// Token: 0x1700023B RID: 571
			// (get) Token: 0x06000536 RID: 1334 RVA: 0x00014A50 File Offset: 0x00013A50
			// (set) Token: 0x06000537 RID: 1335 RVA: 0x00014A98 File Offset: 0x00013A98
			[DebuggerNonUserCode]
			public string KetQua_SATQ_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.KetQua_SATQ_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'KetQua_SATQ_Id' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.KetQua_SATQ_IdColumn] = value;
				}
			}

			// Token: 0x1700023C RID: 572
			// (get) Token: 0x06000538 RID: 1336 RVA: 0x00014AB0 File Offset: 0x00013AB0
			// (set) Token: 0x06000539 RID: 1337 RVA: 0x00014AF8 File Offset: 0x00013AF8
			[DebuggerNonUserCode]
			public string SA_TQ_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.SA_TQ_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'SA_TQ_Id' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.SA_TQ_IdColumn] = value;
				}
			}

			// Token: 0x1700023D RID: 573
			// (get) Token: 0x0600053A RID: 1338 RVA: 0x00014B10 File Offset: 0x00013B10
			// (set) Token: 0x0600053B RID: 1339 RVA: 0x00014B58 File Offset: 0x00013B58
			[DebuggerNonUserCode]
			public string BenhNhan_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.BenhNhan_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'BenhNhan_Id' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.BenhNhan_IdColumn] = value;
				}
			}

			// Token: 0x1700023E RID: 574
			// (get) Token: 0x0600053C RID: 1340 RVA: 0x00014B70 File Offset: 0x00013B70
			// (set) Token: 0x0600053D RID: 1341 RVA: 0x00014BB8 File Offset: 0x00013BB8
			[DebuggerNonUserCode]
			public string Y_Te_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.Y_Te_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Y_Te_Id' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.Y_Te_IdColumn] = value;
				}
			}

			// Token: 0x1700023F RID: 575
			// (get) Token: 0x0600053E RID: 1342 RVA: 0x00014BD0 File Offset: 0x00013BD0
			// (set) Token: 0x0600053F RID: 1343 RVA: 0x00014C18 File Offset: 0x00013C18
			[DebuggerNonUserCode]
			public string Ho_Ten
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.Ho_TenColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ho_Ten' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.Ho_TenColumn] = value;
				}
			}

			// Token: 0x17000240 RID: 576
			// (get) Token: 0x06000540 RID: 1344 RVA: 0x00014C30 File Offset: 0x00013C30
			// (set) Token: 0x06000541 RID: 1345 RVA: 0x00014C78 File Offset: 0x00013C78
			[DebuggerNonUserCode]
			public string Gioi_Tinh
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.Gioi_TinhColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Gioi_Tinh' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.Gioi_TinhColumn] = value;
				}
			}

			// Token: 0x17000241 RID: 577
			// (get) Token: 0x06000542 RID: 1346 RVA: 0x00014C90 File Offset: 0x00013C90
			// (set) Token: 0x06000543 RID: 1347 RVA: 0x00014CD8 File Offset: 0x00013CD8
			[DebuggerNonUserCode]
			public string Nam_Sinh
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.Nam_SinhColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Nam_Sinh' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.Nam_SinhColumn] = value;
				}
			}

			// Token: 0x17000242 RID: 578
			// (get) Token: 0x06000544 RID: 1348 RVA: 0x00014CF0 File Offset: 0x00013CF0
			// (set) Token: 0x06000545 RID: 1349 RVA: 0x00014D38 File Offset: 0x00013D38
			[DebuggerNonUserCode]
			public string Dia_Chi
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.Dia_ChiColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Dia_Chi' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.Dia_ChiColumn] = value;
				}
			}

			// Token: 0x17000243 RID: 579
			// (get) Token: 0x06000546 RID: 1350 RVA: 0x00014D50 File Offset: 0x00013D50
			// (set) Token: 0x06000547 RID: 1351 RVA: 0x00014D98 File Offset: 0x00013D98
			[DebuggerNonUserCode]
			public string Ngay
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.NgayColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ngay' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.NgayColumn] = value;
				}
			}

			// Token: 0x17000244 RID: 580
			// (get) Token: 0x06000548 RID: 1352 RVA: 0x00014DB0 File Offset: 0x00013DB0
			// (set) Token: 0x06000549 RID: 1353 RVA: 0x00014DF8 File Offset: 0x00013DF8
			[DebuggerNonUserCode]
			public string Lam_Sang
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.Lam_SangColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Lam_Sang' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.Lam_SangColumn] = value;
				}
			}

			// Token: 0x17000245 RID: 581
			// (get) Token: 0x0600054A RID: 1354 RVA: 0x00014E10 File Offset: 0x00013E10
			// (set) Token: 0x0600054B RID: 1355 RVA: 0x00014E58 File Offset: 0x00013E58
			[DebuggerNonUserCode]
			public string Gan
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.GanColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Gan' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.GanColumn] = value;
				}
			}

			// Token: 0x17000246 RID: 582
			// (get) Token: 0x0600054C RID: 1356 RVA: 0x00014E70 File Offset: 0x00013E70
			// (set) Token: 0x0600054D RID: 1357 RVA: 0x00014EB8 File Offset: 0x00013EB8
			[DebuggerNonUserCode]
			public string Mat
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.MatColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Mat' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.MatColumn] = value;
				}
			}

			// Token: 0x17000247 RID: 583
			// (get) Token: 0x0600054E RID: 1358 RVA: 0x00014ED0 File Offset: 0x00013ED0
			// (set) Token: 0x0600054F RID: 1359 RVA: 0x00014F18 File Offset: 0x00013F18
			[DebuggerNonUserCode]
			public string Tuy
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.TuyColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Tuy' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.TuyColumn] = value;
				}
			}

			// Token: 0x17000248 RID: 584
			// (get) Token: 0x06000550 RID: 1360 RVA: 0x00014F30 File Offset: 0x00013F30
			// (set) Token: 0x06000551 RID: 1361 RVA: 0x00014F78 File Offset: 0x00013F78
			[DebuggerNonUserCode]
			public string Lach
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.LachColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Lach' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.LachColumn] = value;
				}
			}

			// Token: 0x17000249 RID: 585
			// (get) Token: 0x06000552 RID: 1362 RVA: 0x00014F90 File Offset: 0x00013F90
			// (set) Token: 0x06000553 RID: 1363 RVA: 0x00014FD8 File Offset: 0x00013FD8
			[DebuggerNonUserCode]
			public string ThanP
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.ThanPColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ThanP' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.ThanPColumn] = value;
				}
			}

			// Token: 0x1700024A RID: 586
			// (get) Token: 0x06000554 RID: 1364 RVA: 0x00014FF0 File Offset: 0x00013FF0
			// (set) Token: 0x06000555 RID: 1365 RVA: 0x00015038 File Offset: 0x00014038
			[DebuggerNonUserCode]
			public string ThanT
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.ThanTColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ThanT' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.ThanTColumn] = value;
				}
			}

			// Token: 0x1700024B RID: 587
			// (get) Token: 0x06000556 RID: 1366 RVA: 0x00015050 File Offset: 0x00014050
			// (set) Token: 0x06000557 RID: 1367 RVA: 0x00015098 File Offset: 0x00014098
			[DebuggerNonUserCode]
			public string DMCBung
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.DMCBungColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'DMCBung' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.DMCBungColumn] = value;
				}
			}

			// Token: 0x1700024C RID: 588
			// (get) Token: 0x06000558 RID: 1368 RVA: 0x000150B0 File Offset: 0x000140B0
			// (set) Token: 0x06000559 RID: 1369 RVA: 0x000150F8 File Offset: 0x000140F8
			[DebuggerNonUserCode]
			public string TLT
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.TLTColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'TLT' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.TLTColumn] = value;
				}
			}

			// Token: 0x1700024D RID: 589
			// (get) Token: 0x0600055A RID: 1370 RVA: 0x00015110 File Offset: 0x00014110
			// (set) Token: 0x0600055B RID: 1371 RVA: 0x00015158 File Offset: 0x00014158
			[DebuggerNonUserCode]
			public string TuCung
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.TuCungColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'TuCung' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.TuCungColumn] = value;
				}
			}

			// Token: 0x1700024E RID: 590
			// (get) Token: 0x0600055C RID: 1372 RVA: 0x00015170 File Offset: 0x00014170
			// (set) Token: 0x0600055D RID: 1373 RVA: 0x000151B8 File Offset: 0x000141B8
			[DebuggerNonUserCode]
			public string BuongTrung
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.BuongTrungColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'BuongTrung' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.BuongTrungColumn] = value;
				}
			}

			// Token: 0x1700024F RID: 591
			// (get) Token: 0x0600055E RID: 1374 RVA: 0x000151D0 File Offset: 0x000141D0
			// (set) Token: 0x0600055F RID: 1375 RVA: 0x00015218 File Offset: 0x00014218
			[DebuggerNonUserCode]
			public string Bang_Quang
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.Bang_QuangColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Bang_Quang' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.Bang_QuangColumn] = value;
				}
			}

			// Token: 0x17000250 RID: 592
			// (get) Token: 0x06000560 RID: 1376 RVA: 0x00015230 File Offset: 0x00014230
			// (set) Token: 0x06000561 RID: 1377 RVA: 0x00015278 File Offset: 0x00014278
			[DebuggerNonUserCode]
			public string Khac
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.KhacColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Khac' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.KhacColumn] = value;
				}
			}

			// Token: 0x17000251 RID: 593
			// (get) Token: 0x06000562 RID: 1378 RVA: 0x00015290 File Offset: 0x00014290
			// (set) Token: 0x06000563 RID: 1379 RVA: 0x000152D8 File Offset: 0x000142D8
			[DebuggerNonUserCode]
			public string Ket_Luan
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.Ket_LuanColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ket_Luan' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.Ket_LuanColumn] = value;
				}
			}

			// Token: 0x17000252 RID: 594
			// (get) Token: 0x06000564 RID: 1380 RVA: 0x000152F0 File Offset: 0x000142F0
			// (set) Token: 0x06000565 RID: 1381 RVA: 0x00015338 File Offset: 0x00014338
			[DebuggerNonUserCode]
			public string DS_Anh_KQ
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.DS_Anh_KQColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'DS_Anh_KQ' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.DS_Anh_KQColumn] = value;
				}
			}

			// Token: 0x17000253 RID: 595
			// (get) Token: 0x06000566 RID: 1382 RVA: 0x00015350 File Offset: 0x00014350
			// (set) Token: 0x06000567 RID: 1383 RVA: 0x00015398 File Offset: 0x00014398
			[DebuggerNonUserCode]
			public string Ho_Ten_BSSA
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.Ho_Ten_BSSAColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ho_Ten_BSSA' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.Ho_Ten_BSSAColumn] = value;
				}
			}

			// Token: 0x17000254 RID: 596
			// (get) Token: 0x06000568 RID: 1384 RVA: 0x000153B0 File Offset: 0x000143B0
			// (set) Token: 0x06000569 RID: 1385 RVA: 0x000153F8 File Offset: 0x000143F8
			[DebuggerNonUserCode]
			public string Trinh_Do
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATQ.Trinh_DoColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Trinh_Do' in table 'SATQ' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATQ.Trinh_DoColumn] = value;
				}
			}

			// Token: 0x0600056A RID: 1386 RVA: 0x00015410 File Offset: 0x00014410
			[DebuggerNonUserCode]
			public bool IsKetQua_SATQ_IdNull()
			{
				return base.IsNull(this.tableSATQ.KetQua_SATQ_IdColumn);
			}

			// Token: 0x0600056B RID: 1387 RVA: 0x00015433 File Offset: 0x00014433
			[DebuggerNonUserCode]
			public void SetKetQua_SATQ_IdNull()
			{
				base[this.tableSATQ.KetQua_SATQ_IdColumn] = Convert.DBNull;
			}

			// Token: 0x0600056C RID: 1388 RVA: 0x00015450 File Offset: 0x00014450
			[DebuggerNonUserCode]
			public bool IsSA_TQ_IdNull()
			{
				return base.IsNull(this.tableSATQ.SA_TQ_IdColumn);
			}

			// Token: 0x0600056D RID: 1389 RVA: 0x00015473 File Offset: 0x00014473
			[DebuggerNonUserCode]
			public void SetSA_TQ_IdNull()
			{
				base[this.tableSATQ.SA_TQ_IdColumn] = Convert.DBNull;
			}

			// Token: 0x0600056E RID: 1390 RVA: 0x00015490 File Offset: 0x00014490
			[DebuggerNonUserCode]
			public bool IsBenhNhan_IdNull()
			{
				return base.IsNull(this.tableSATQ.BenhNhan_IdColumn);
			}

			// Token: 0x0600056F RID: 1391 RVA: 0x000154B3 File Offset: 0x000144B3
			[DebuggerNonUserCode]
			public void SetBenhNhan_IdNull()
			{
				base[this.tableSATQ.BenhNhan_IdColumn] = Convert.DBNull;
			}

			// Token: 0x06000570 RID: 1392 RVA: 0x000154D0 File Offset: 0x000144D0
			[DebuggerNonUserCode]
			public bool IsY_Te_IdNull()
			{
				return base.IsNull(this.tableSATQ.Y_Te_IdColumn);
			}

			// Token: 0x06000571 RID: 1393 RVA: 0x000154F3 File Offset: 0x000144F3
			[DebuggerNonUserCode]
			public void SetY_Te_IdNull()
			{
				base[this.tableSATQ.Y_Te_IdColumn] = Convert.DBNull;
			}

			// Token: 0x06000572 RID: 1394 RVA: 0x00015510 File Offset: 0x00014510
			[DebuggerNonUserCode]
			public bool IsHo_TenNull()
			{
				return base.IsNull(this.tableSATQ.Ho_TenColumn);
			}

			// Token: 0x06000573 RID: 1395 RVA: 0x00015533 File Offset: 0x00014533
			[DebuggerNonUserCode]
			public void SetHo_TenNull()
			{
				base[this.tableSATQ.Ho_TenColumn] = Convert.DBNull;
			}

			// Token: 0x06000574 RID: 1396 RVA: 0x00015550 File Offset: 0x00014550
			[DebuggerNonUserCode]
			public bool IsGioi_TinhNull()
			{
				return base.IsNull(this.tableSATQ.Gioi_TinhColumn);
			}

			// Token: 0x06000575 RID: 1397 RVA: 0x00015573 File Offset: 0x00014573
			[DebuggerNonUserCode]
			public void SetGioi_TinhNull()
			{
				base[this.tableSATQ.Gioi_TinhColumn] = Convert.DBNull;
			}

			// Token: 0x06000576 RID: 1398 RVA: 0x00015590 File Offset: 0x00014590
			[DebuggerNonUserCode]
			public bool IsNam_SinhNull()
			{
				return base.IsNull(this.tableSATQ.Nam_SinhColumn);
			}

			// Token: 0x06000577 RID: 1399 RVA: 0x000155B3 File Offset: 0x000145B3
			[DebuggerNonUserCode]
			public void SetNam_SinhNull()
			{
				base[this.tableSATQ.Nam_SinhColumn] = Convert.DBNull;
			}

			// Token: 0x06000578 RID: 1400 RVA: 0x000155D0 File Offset: 0x000145D0
			[DebuggerNonUserCode]
			public bool IsDia_ChiNull()
			{
				return base.IsNull(this.tableSATQ.Dia_ChiColumn);
			}

			// Token: 0x06000579 RID: 1401 RVA: 0x000155F3 File Offset: 0x000145F3
			[DebuggerNonUserCode]
			public void SetDia_ChiNull()
			{
				base[this.tableSATQ.Dia_ChiColumn] = Convert.DBNull;
			}

			// Token: 0x0600057A RID: 1402 RVA: 0x00015610 File Offset: 0x00014610
			[DebuggerNonUserCode]
			public bool IsNgayNull()
			{
				return base.IsNull(this.tableSATQ.NgayColumn);
			}

			// Token: 0x0600057B RID: 1403 RVA: 0x00015633 File Offset: 0x00014633
			[DebuggerNonUserCode]
			public void SetNgayNull()
			{
				base[this.tableSATQ.NgayColumn] = Convert.DBNull;
			}

			// Token: 0x0600057C RID: 1404 RVA: 0x00015650 File Offset: 0x00014650
			[DebuggerNonUserCode]
			public bool IsLam_SangNull()
			{
				return base.IsNull(this.tableSATQ.Lam_SangColumn);
			}

			// Token: 0x0600057D RID: 1405 RVA: 0x00015673 File Offset: 0x00014673
			[DebuggerNonUserCode]
			public void SetLam_SangNull()
			{
				base[this.tableSATQ.Lam_SangColumn] = Convert.DBNull;
			}

			// Token: 0x0600057E RID: 1406 RVA: 0x00015690 File Offset: 0x00014690
			[DebuggerNonUserCode]
			public bool IsGanNull()
			{
				return base.IsNull(this.tableSATQ.GanColumn);
			}

			// Token: 0x0600057F RID: 1407 RVA: 0x000156B3 File Offset: 0x000146B3
			[DebuggerNonUserCode]
			public void SetGanNull()
			{
				base[this.tableSATQ.GanColumn] = Convert.DBNull;
			}

			// Token: 0x06000580 RID: 1408 RVA: 0x000156D0 File Offset: 0x000146D0
			[DebuggerNonUserCode]
			public bool IsMatNull()
			{
				return base.IsNull(this.tableSATQ.MatColumn);
			}

			// Token: 0x06000581 RID: 1409 RVA: 0x000156F3 File Offset: 0x000146F3
			[DebuggerNonUserCode]
			public void SetMatNull()
			{
				base[this.tableSATQ.MatColumn] = Convert.DBNull;
			}

			// Token: 0x06000582 RID: 1410 RVA: 0x00015710 File Offset: 0x00014710
			[DebuggerNonUserCode]
			public bool IsTuyNull()
			{
				return base.IsNull(this.tableSATQ.TuyColumn);
			}

			// Token: 0x06000583 RID: 1411 RVA: 0x00015733 File Offset: 0x00014733
			[DebuggerNonUserCode]
			public void SetTuyNull()
			{
				base[this.tableSATQ.TuyColumn] = Convert.DBNull;
			}

			// Token: 0x06000584 RID: 1412 RVA: 0x00015750 File Offset: 0x00014750
			[DebuggerNonUserCode]
			public bool IsLachNull()
			{
				return base.IsNull(this.tableSATQ.LachColumn);
			}

			// Token: 0x06000585 RID: 1413 RVA: 0x00015773 File Offset: 0x00014773
			[DebuggerNonUserCode]
			public void SetLachNull()
			{
				base[this.tableSATQ.LachColumn] = Convert.DBNull;
			}

			// Token: 0x06000586 RID: 1414 RVA: 0x00015790 File Offset: 0x00014790
			[DebuggerNonUserCode]
			public bool IsThanPNull()
			{
				return base.IsNull(this.tableSATQ.ThanPColumn);
			}

			// Token: 0x06000587 RID: 1415 RVA: 0x000157B3 File Offset: 0x000147B3
			[DebuggerNonUserCode]
			public void SetThanPNull()
			{
				base[this.tableSATQ.ThanPColumn] = Convert.DBNull;
			}

			// Token: 0x06000588 RID: 1416 RVA: 0x000157D0 File Offset: 0x000147D0
			[DebuggerNonUserCode]
			public bool IsThanTNull()
			{
				return base.IsNull(this.tableSATQ.ThanTColumn);
			}

			// Token: 0x06000589 RID: 1417 RVA: 0x000157F3 File Offset: 0x000147F3
			[DebuggerNonUserCode]
			public void SetThanTNull()
			{
				base[this.tableSATQ.ThanTColumn] = Convert.DBNull;
			}

			// Token: 0x0600058A RID: 1418 RVA: 0x00015810 File Offset: 0x00014810
			[DebuggerNonUserCode]
			public bool IsDMCBungNull()
			{
				return base.IsNull(this.tableSATQ.DMCBungColumn);
			}

			// Token: 0x0600058B RID: 1419 RVA: 0x00015833 File Offset: 0x00014833
			[DebuggerNonUserCode]
			public void SetDMCBungNull()
			{
				base[this.tableSATQ.DMCBungColumn] = Convert.DBNull;
			}

			// Token: 0x0600058C RID: 1420 RVA: 0x00015850 File Offset: 0x00014850
			[DebuggerNonUserCode]
			public bool IsTLTNull()
			{
				return base.IsNull(this.tableSATQ.TLTColumn);
			}

			// Token: 0x0600058D RID: 1421 RVA: 0x00015873 File Offset: 0x00014873
			[DebuggerNonUserCode]
			public void SetTLTNull()
			{
				base[this.tableSATQ.TLTColumn] = Convert.DBNull;
			}

			// Token: 0x0600058E RID: 1422 RVA: 0x00015890 File Offset: 0x00014890
			[DebuggerNonUserCode]
			public bool IsTuCungNull()
			{
				return base.IsNull(this.tableSATQ.TuCungColumn);
			}

			// Token: 0x0600058F RID: 1423 RVA: 0x000158B3 File Offset: 0x000148B3
			[DebuggerNonUserCode]
			public void SetTuCungNull()
			{
				base[this.tableSATQ.TuCungColumn] = Convert.DBNull;
			}

			// Token: 0x06000590 RID: 1424 RVA: 0x000158D0 File Offset: 0x000148D0
			[DebuggerNonUserCode]
			public bool IsBuongTrungNull()
			{
				return base.IsNull(this.tableSATQ.BuongTrungColumn);
			}

			// Token: 0x06000591 RID: 1425 RVA: 0x000158F3 File Offset: 0x000148F3
			[DebuggerNonUserCode]
			public void SetBuongTrungNull()
			{
				base[this.tableSATQ.BuongTrungColumn] = Convert.DBNull;
			}

			// Token: 0x06000592 RID: 1426 RVA: 0x00015910 File Offset: 0x00014910
			[DebuggerNonUserCode]
			public bool IsBang_QuangNull()
			{
				return base.IsNull(this.tableSATQ.Bang_QuangColumn);
			}

			// Token: 0x06000593 RID: 1427 RVA: 0x00015933 File Offset: 0x00014933
			[DebuggerNonUserCode]
			public void SetBang_QuangNull()
			{
				base[this.tableSATQ.Bang_QuangColumn] = Convert.DBNull;
			}

			// Token: 0x06000594 RID: 1428 RVA: 0x00015950 File Offset: 0x00014950
			[DebuggerNonUserCode]
			public bool IsKhacNull()
			{
				return base.IsNull(this.tableSATQ.KhacColumn);
			}

			// Token: 0x06000595 RID: 1429 RVA: 0x00015973 File Offset: 0x00014973
			[DebuggerNonUserCode]
			public void SetKhacNull()
			{
				base[this.tableSATQ.KhacColumn] = Convert.DBNull;
			}

			// Token: 0x06000596 RID: 1430 RVA: 0x00015990 File Offset: 0x00014990
			[DebuggerNonUserCode]
			public bool IsKet_LuanNull()
			{
				return base.IsNull(this.tableSATQ.Ket_LuanColumn);
			}

			// Token: 0x06000597 RID: 1431 RVA: 0x000159B3 File Offset: 0x000149B3
			[DebuggerNonUserCode]
			public void SetKet_LuanNull()
			{
				base[this.tableSATQ.Ket_LuanColumn] = Convert.DBNull;
			}

			// Token: 0x06000598 RID: 1432 RVA: 0x000159D0 File Offset: 0x000149D0
			[DebuggerNonUserCode]
			public bool IsDS_Anh_KQNull()
			{
				return base.IsNull(this.tableSATQ.DS_Anh_KQColumn);
			}

			// Token: 0x06000599 RID: 1433 RVA: 0x000159F3 File Offset: 0x000149F3
			[DebuggerNonUserCode]
			public void SetDS_Anh_KQNull()
			{
				base[this.tableSATQ.DS_Anh_KQColumn] = Convert.DBNull;
			}

			// Token: 0x0600059A RID: 1434 RVA: 0x00015A10 File Offset: 0x00014A10
			[DebuggerNonUserCode]
			public bool IsHo_Ten_BSSANull()
			{
				return base.IsNull(this.tableSATQ.Ho_Ten_BSSAColumn);
			}

			// Token: 0x0600059B RID: 1435 RVA: 0x00015A33 File Offset: 0x00014A33
			[DebuggerNonUserCode]
			public void SetHo_Ten_BSSANull()
			{
				base[this.tableSATQ.Ho_Ten_BSSAColumn] = Convert.DBNull;
			}

			// Token: 0x0600059C RID: 1436 RVA: 0x00015A50 File Offset: 0x00014A50
			[DebuggerNonUserCode]
			public bool IsTrinh_DoNull()
			{
				return base.IsNull(this.tableSATQ.Trinh_DoColumn);
			}

			// Token: 0x0600059D RID: 1437 RVA: 0x00015A73 File Offset: 0x00014A73
			[DebuggerNonUserCode]
			public void SetTrinh_DoNull()
			{
				base[this.tableSATQ.Trinh_DoColumn] = Convert.DBNull;
			}

			// Token: 0x04000130 RID: 304
			private dsKetQuaSA.SATQDataTable tableSATQ;
		}

		// Token: 0x0200004A RID: 74
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SATIMRow : DataRow
		{
			// Token: 0x0600059E RID: 1438 RVA: 0x00015A8D File Offset: 0x00014A8D
			[DebuggerNonUserCode]
			internal SATIMRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSATIM = (dsKetQuaSA.SATIMDataTable)base.Table;
			}

			// Token: 0x17000255 RID: 597
			// (get) Token: 0x0600059F RID: 1439 RVA: 0x00015AAC File Offset: 0x00014AAC
			// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00015AF4 File Offset: 0x00014AF4
			[DebuggerNonUserCode]
			public uint KetQua_SATM_Id
			{
				get
				{
					uint result;
					try
					{
						result = (uint)base[this.tableSATIM.KetQua_SATM_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'KetQua_SATM_Id' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.KetQua_SATM_IdColumn] = value;
				}
			}

			// Token: 0x17000256 RID: 598
			// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00015B10 File Offset: 0x00014B10
			// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00015B58 File Offset: 0x00014B58
			[DebuggerNonUserCode]
			public string SA_TM_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.SA_TM_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'SA_TM_Id' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.SA_TM_IdColumn] = value;
				}
			}

			// Token: 0x17000257 RID: 599
			// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00015B70 File Offset: 0x00014B70
			// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00015BB8 File Offset: 0x00014BB8
			[DebuggerNonUserCode]
			public string BenhNhan_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.BenhNhan_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'BenhNhan_Id' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.BenhNhan_IdColumn] = value;
				}
			}

			// Token: 0x17000258 RID: 600
			// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00015BD0 File Offset: 0x00014BD0
			// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00015C18 File Offset: 0x00014C18
			[DebuggerNonUserCode]
			public string Y_Te_Id
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.Y_Te_IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Y_Te_Id' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.Y_Te_IdColumn] = value;
				}
			}

			// Token: 0x17000259 RID: 601
			// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00015C30 File Offset: 0x00014C30
			// (set) Token: 0x060005A8 RID: 1448 RVA: 0x00015C78 File Offset: 0x00014C78
			[DebuggerNonUserCode]
			public string Ho_Ten
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.Ho_TenColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ho_Ten' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.Ho_TenColumn] = value;
				}
			}

			// Token: 0x1700025A RID: 602
			// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00015C90 File Offset: 0x00014C90
			// (set) Token: 0x060005AA RID: 1450 RVA: 0x00015CD8 File Offset: 0x00014CD8
			[DebuggerNonUserCode]
			public string Gioi_Tinh
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.Gioi_TinhColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Gioi_Tinh' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.Gioi_TinhColumn] = value;
				}
			}

			// Token: 0x1700025B RID: 603
			// (get) Token: 0x060005AB RID: 1451 RVA: 0x00015CF0 File Offset: 0x00014CF0
			// (set) Token: 0x060005AC RID: 1452 RVA: 0x00015D38 File Offset: 0x00014D38
			[DebuggerNonUserCode]
			public string Nam_Sinh
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.Nam_SinhColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Nam_Sinh' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.Nam_SinhColumn] = value;
				}
			}

			// Token: 0x1700025C RID: 604
			// (get) Token: 0x060005AD RID: 1453 RVA: 0x00015D50 File Offset: 0x00014D50
			// (set) Token: 0x060005AE RID: 1454 RVA: 0x00015D98 File Offset: 0x00014D98
			[DebuggerNonUserCode]
			public string Dia_Chi
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.Dia_ChiColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Dia_Chi' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.Dia_ChiColumn] = value;
				}
			}

			// Token: 0x1700025D RID: 605
			// (get) Token: 0x060005AF RID: 1455 RVA: 0x00015DB0 File Offset: 0x00014DB0
			// (set) Token: 0x060005B0 RID: 1456 RVA: 0x00015DF8 File Offset: 0x00014DF8
			[DebuggerNonUserCode]
			public string Huyen_Tinh
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.Huyen_TinhColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Huyen_Tinh' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.Huyen_TinhColumn] = value;
				}
			}

			// Token: 0x1700025E RID: 606
			// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00015E10 File Offset: 0x00014E10
			// (set) Token: 0x060005B2 RID: 1458 RVA: 0x00015E58 File Offset: 0x00014E58
			[DebuggerNonUserCode]
			public string Ngay
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.NgayColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ngay' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.NgayColumn] = value;
				}
			}

			// Token: 0x1700025F RID: 607
			// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00015E70 File Offset: 0x00014E70
			// (set) Token: 0x060005B4 RID: 1460 RVA: 0x00015EB8 File Offset: 0x00014EB8
			[DebuggerNonUserCode]
			public string Lam_Sang
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.Lam_SangColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Lam_Sang' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.Lam_SangColumn] = value;
				}
			}

			// Token: 0x17000260 RID: 608
			// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00015ED0 File Offset: 0x00014ED0
			// (set) Token: 0x060005B6 RID: 1462 RVA: 0x00015F18 File Offset: 0x00014F18
			[DebuggerNonUserCode]
			public string Khac
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.KhacColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Khac' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.KhacColumn] = value;
				}
			}

			// Token: 0x17000261 RID: 609
			// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00015F30 File Offset: 0x00014F30
			// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00015F78 File Offset: 0x00014F78
			[DebuggerNonUserCode]
			public string Ket_Luan
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.Ket_LuanColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ket_Luan' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.Ket_LuanColumn] = value;
				}
			}

			// Token: 0x17000262 RID: 610
			// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00015F90 File Offset: 0x00014F90
			// (set) Token: 0x060005BA RID: 1466 RVA: 0x00015FD8 File Offset: 0x00014FD8
			[DebuggerNonUserCode]
			public string DS_Anh_KQ
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.DS_Anh_KQColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'DS_Anh_KQ' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.DS_Anh_KQColumn] = value;
				}
			}

			// Token: 0x17000263 RID: 611
			// (get) Token: 0x060005BB RID: 1467 RVA: 0x00015FF0 File Offset: 0x00014FF0
			// (set) Token: 0x060005BC RID: 1468 RVA: 0x00016038 File Offset: 0x00015038
			[DebuggerNonUserCode]
			public string Trinh_Do
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.Trinh_DoColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Trinh_Do' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.Trinh_DoColumn] = value;
				}
			}

			// Token: 0x17000264 RID: 612
			// (get) Token: 0x060005BD RID: 1469 RVA: 0x00016050 File Offset: 0x00015050
			// (set) Token: 0x060005BE RID: 1470 RVA: 0x00016098 File Offset: 0x00015098
			[DebuggerNonUserCode]
			public string Ho_Ten_BSSA
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.Ho_Ten_BSSAColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ho_Ten_BSSA' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.Ho_Ten_BSSAColumn] = value;
				}
			}

			// Token: 0x17000265 RID: 613
			// (get) Token: 0x060005BF RID: 1471 RVA: 0x000160B0 File Offset: 0x000150B0
			// (set) Token: 0x060005C0 RID: 1472 RVA: 0x000160F8 File Offset: 0x000150F8
			[DebuggerNonUserCode]
			public string Can_Nang
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.Can_NangColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Can_Nang' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.Can_NangColumn] = value;
				}
			}

			// Token: 0x17000266 RID: 614
			// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00016110 File Offset: 0x00015110
			// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00016158 File Offset: 0x00015158
			[DebuggerNonUserCode]
			public string Chieu_Cao
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.Chieu_CaoColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Chieu_Cao' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.Chieu_CaoColumn] = value;
				}
			}

			// Token: 0x17000267 RID: 615
			// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00016170 File Offset: 0x00015170
			// (set) Token: 0x060005C4 RID: 1476 RVA: 0x000161B8 File Offset: 0x000151B8
			[DebuggerNonUserCode]
			public string BSA
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.BSAColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'BSA' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.BSAColumn] = value;
				}
			}

			// Token: 0x17000268 RID: 616
			// (get) Token: 0x060005C5 RID: 1477 RVA: 0x000161D0 File Offset: 0x000151D0
			// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00016218 File Offset: 0x00015218
			[DebuggerNonUserCode]
			public string Nhip_Tim
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.Nhip_TimColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Nhip_Tim' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.Nhip_TimColumn] = value;
				}
			}

			// Token: 0x17000269 RID: 617
			// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00016230 File Offset: 0x00015230
			// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00016278 File Offset: 0x00015278
			[DebuggerNonUserCode]
			public string Huyet_Ap
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM.Huyet_ApColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Huyet_Ap' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM.Huyet_ApColumn] = value;
				}
			}

			// Token: 0x1700026A RID: 618
			// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00016290 File Offset: 0x00015290
			// (set) Token: 0x060005CA RID: 1482 RVA: 0x000162D8 File Offset: 0x000152D8
			[DebuggerNonUserCode]
			public string _2_TM_IVSd
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_TM_IVSdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_TM_IVSd' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_TM_IVSdColumn] = value;
				}
			}

			// Token: 0x1700026B RID: 619
			// (get) Token: 0x060005CB RID: 1483 RVA: 0x000162F0 File Offset: 0x000152F0
			// (set) Token: 0x060005CC RID: 1484 RVA: 0x00016338 File Offset: 0x00015338
			[DebuggerNonUserCode]
			public string _2_TM_LVDd
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_TM_LVDdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_TM_LVDd' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_TM_LVDdColumn] = value;
				}
			}

			// Token: 0x1700026C RID: 620
			// (get) Token: 0x060005CD RID: 1485 RVA: 0x00016350 File Offset: 0x00015350
			// (set) Token: 0x060005CE RID: 1486 RVA: 0x00016398 File Offset: 0x00015398
			[DebuggerNonUserCode]
			public string _2_TM_PLVW
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_TM_PLVWColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_TM_PLVW' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_TM_PLVWColumn] = value;
				}
			}

			// Token: 0x1700026D RID: 621
			// (get) Token: 0x060005CF RID: 1487 RVA: 0x000163B0 File Offset: 0x000153B0
			// (set) Token: 0x060005D0 RID: 1488 RVA: 0x000163F8 File Offset: 0x000153F8
			[DebuggerNonUserCode]
			public string _2_TM_IVSs
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_TM_IVSsColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_TM_IVSs' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_TM_IVSsColumn] = value;
				}
			}

			// Token: 0x1700026E RID: 622
			// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00016410 File Offset: 0x00015410
			// (set) Token: 0x060005D2 RID: 1490 RVA: 0x00016458 File Offset: 0x00015458
			[DebuggerNonUserCode]
			public string _2_TM_LVDs
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_TM_LVDsColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_TM_LVDs' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_TM_LVDsColumn] = value;
				}
			}

			// Token: 0x1700026F RID: 623
			// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00016470 File Offset: 0x00015470
			// (set) Token: 0x060005D4 RID: 1492 RVA: 0x000164B8 File Offset: 0x000154B8
			[DebuggerNonUserCode]
			public string _2_TM_PLVWs
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_TM_PLVWsColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_TM_PLVWs' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_TM_PLVWsColumn] = value;
				}
			}

			// Token: 0x17000270 RID: 624
			// (get) Token: 0x060005D5 RID: 1493 RVA: 0x000164D0 File Offset: 0x000154D0
			// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00016518 File Offset: 0x00015518
			[DebuggerNonUserCode]
			public string _2_TM_SF
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_TM_SFColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_TM_SF' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_TM_SFColumn] = value;
				}
			}

			// Token: 0x17000271 RID: 625
			// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00016530 File Offset: 0x00015530
			// (set) Token: 0x060005D8 RID: 1496 RVA: 0x00016578 File Offset: 0x00015578
			[DebuggerNonUserCode]
			public string _2_TM_EF
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_TM_EFColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_TM_EF' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_TM_EFColumn] = value;
				}
			}

			// Token: 0x17000272 RID: 626
			// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00016590 File Offset: 0x00015590
			// (set) Token: 0x060005DA RID: 1498 RVA: 0x000165D8 File Offset: 0x000155D8
			[DebuggerNonUserCode]
			public string _2_TM_RVd
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_TM_RVdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_TM_RVd' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_TM_RVdColumn] = value;
				}
			}

			// Token: 0x17000273 RID: 627
			// (get) Token: 0x060005DB RID: 1499 RVA: 0x000165F0 File Offset: 0x000155F0
			// (set) Token: 0x060005DC RID: 1500 RVA: 0x00016638 File Offset: 0x00015638
			[DebuggerNonUserCode]
			public string _2_TM_Ao
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_TM_AoColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_TM_Ao' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_TM_AoColumn] = value;
				}
			}

			// Token: 0x17000274 RID: 628
			// (get) Token: 0x060005DD RID: 1501 RVA: 0x00016650 File Offset: 0x00015650
			// (set) Token: 0x060005DE RID: 1502 RVA: 0x00016698 File Offset: 0x00015698
			[DebuggerNonUserCode]
			public string _2_TM_LA
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_TM_LAColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_TM_LA' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_TM_LAColumn] = value;
				}
			}

			// Token: 0x17000275 RID: 629
			// (get) Token: 0x060005DF RID: 1503 RVA: 0x000166B0 File Offset: 0x000156B0
			// (set) Token: 0x060005E0 RID: 1504 RVA: 0x000166F8 File Offset: 0x000156F8
			[DebuggerNonUserCode]
			public string _2_TM_AVo
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_TM_AVoColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_TM_AVo' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_TM_AVoColumn] = value;
				}
			}

			// Token: 0x17000276 RID: 630
			// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00016710 File Offset: 0x00015710
			// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00016758 File Offset: 0x00015758
			[DebuggerNonUserCode]
			public string _2_2D_Situs
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_SitusColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_Situs' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_SitusColumn] = value;
				}
			}

			// Token: 0x17000277 RID: 631
			// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00016770 File Offset: 0x00015770
			// (set) Token: 0x060005E4 RID: 1508 RVA: 0x000167B8 File Offset: 0x000157B8
			[DebuggerNonUserCode]
			public string _2_2D_VEINS
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_VEINSColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_VEINS' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_VEINSColumn] = value;
				}
			}

			// Token: 0x17000278 RID: 632
			// (get) Token: 0x060005E5 RID: 1509 RVA: 0x000167D0 File Offset: 0x000157D0
			// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00016818 File Offset: 0x00015818
			[DebuggerNonUserCode]
			public string _2_2D_Atrium
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_AtriumColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_Atrium' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_AtriumColumn] = value;
				}
			}

			// Token: 0x17000279 RID: 633
			// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00016830 File Offset: 0x00015830
			// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00016878 File Offset: 0x00015878
			[DebuggerNonUserCode]
			public string _2_2D_Ventricle
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_VentricleColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_Ventricle' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_VentricleColumn] = value;
				}
			}

			// Token: 0x1700027A RID: 634
			// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00016890 File Offset: 0x00015890
			// (set) Token: 0x060005EA RID: 1514 RVA: 0x000168D8 File Offset: 0x000158D8
			[DebuggerNonUserCode]
			public string _2_2D_DaiDongMach
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_DaiDongMachColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_DaiDongMach' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_DaiDongMachColumn] = value;
				}
			}

			// Token: 0x1700027B RID: 635
			// (get) Token: 0x060005EB RID: 1515 RVA: 0x000168F0 File Offset: 0x000158F0
			// (set) Token: 0x060005EC RID: 1516 RVA: 0x00016938 File Offset: 0x00015938
			[DebuggerNonUserCode]
			public string _2_2D_MangNgoaiTim
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_MangNgoaiTimColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_MangNgoaiTim' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_MangNgoaiTimColumn] = value;
				}
			}

			// Token: 0x1700027C RID: 636
			// (get) Token: 0x060005ED RID: 1517 RVA: 0x00016950 File Offset: 0x00015950
			// (set) Token: 0x060005EE RID: 1518 RVA: 0x00016998 File Offset: 0x00015998
			[DebuggerNonUserCode]
			public string _2_2D_IVC
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_IVCColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_IVC' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_IVCColumn] = value;
				}
			}

			// Token: 0x1700027D RID: 637
			// (get) Token: 0x060005EF RID: 1519 RVA: 0x000169B0 File Offset: 0x000159B0
			// (set) Token: 0x060005F0 RID: 1520 RVA: 0x000169F8 File Offset: 0x000159F8
			[DebuggerNonUserCode]
			public string _2_2D_LSVC
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_LSVCColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_LSVC' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_LSVCColumn] = value;
				}
			}

			// Token: 0x1700027E RID: 638
			// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00016A10 File Offset: 0x00015A10
			// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00016A58 File Offset: 0x00015A58
			[DebuggerNonUserCode]
			public string _2_2D_Valves
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_ValvesColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_Valves' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_ValvesColumn] = value;
				}
			}

			// Token: 0x1700027F RID: 639
			// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00016A70 File Offset: 0x00015A70
			// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00016AB8 File Offset: 0x00015AB8
			[DebuggerNonUserCode]
			public string _2_2D_DMCAo
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_DMCAoColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_DMCAo' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_DMCAoColumn] = value;
				}
			}

			// Token: 0x17000280 RID: 640
			// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00016AD0 File Offset: 0x00015AD0
			// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00016B18 File Offset: 0x00015B18
			[DebuggerNonUserCode]
			public string _2_2D_DMPPA
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_DMPPAColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_DMPPA' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_DMPPAColumn] = value;
				}
			}

			// Token: 0x17000281 RID: 641
			// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00016B30 File Offset: 0x00015B30
			// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00016B78 File Offset: 0x00015B78
			[DebuggerNonUserCode]
			public string _2_2D_Ann
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_AnnColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_Ann' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_AnnColumn] = value;
				}
			}

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00016B90 File Offset: 0x00015B90
			// (set) Token: 0x060005FA RID: 1530 RVA: 0x00016BD8 File Offset: 0x00015BD8
			[DebuggerNonUserCode]
			public string _2_2D_RSVC
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_RSVCColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_RSVC' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_RSVCColumn] = value;
				}
			}

			// Token: 0x17000283 RID: 643
			// (get) Token: 0x060005FB RID: 1531 RVA: 0x00016BF0 File Offset: 0x00015BF0
			// (set) Token: 0x060005FC RID: 1532 RVA: 0x00016C38 File Offset: 0x00015C38
			[DebuggerNonUserCode]
			public string _2_2D_PulmVeins
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_PulmVeinsColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_PulmVeins' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_PulmVeinsColumn] = value;
				}
			}

			// Token: 0x17000284 RID: 644
			// (get) Token: 0x060005FD RID: 1533 RVA: 0x00016C50 File Offset: 0x00015C50
			// (set) Token: 0x060005FE RID: 1534 RVA: 0x00016C98 File Offset: 0x00015C98
			[DebuggerNonUserCode]
			public string _2_2D_TricAnn
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_TricAnnColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_TricAnn' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_TricAnnColumn] = value;
				}
			}

			// Token: 0x17000285 RID: 645
			// (get) Token: 0x060005FF RID: 1535 RVA: 0x00016CB0 File Offset: 0x00015CB0
			// (set) Token: 0x06000600 RID: 1536 RVA: 0x00016CF8 File Offset: 0x00015CF8
			[DebuggerNonUserCode]
			public string _2_2D_D2
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_D2Column];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_D2' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_D2Column] = value;
				}
			}

			// Token: 0x17000286 RID: 646
			// (get) Token: 0x06000601 RID: 1537 RVA: 0x00016D10 File Offset: 0x00015D10
			// (set) Token: 0x06000602 RID: 1538 RVA: 0x00016D58 File Offset: 0x00015D58
			[DebuggerNonUserCode]
			public string _2_2D_PATrunk
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_PATrunkColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_PATrunk' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_PATrunkColumn] = value;
				}
			}

			// Token: 0x17000287 RID: 647
			// (get) Token: 0x06000603 RID: 1539 RVA: 0x00016D70 File Offset: 0x00015D70
			// (set) Token: 0x06000604 RID: 1540 RVA: 0x00016DB8 File Offset: 0x00015DB8
			[DebuggerNonUserCode]
			public string _2_2D_InnVein
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_InnVeinColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_InnVein' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_InnVeinColumn] = value;
				}
			}

			// Token: 0x17000288 RID: 648
			// (get) Token: 0x06000605 RID: 1541 RVA: 0x00016DD0 File Offset: 0x00015DD0
			// (set) Token: 0x06000606 RID: 1542 RVA: 0x00016E18 File Offset: 0x00015E18
			[DebuggerNonUserCode]
			public string _2_2D_Azygos
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_AzygosColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_Azygos' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_AzygosColumn] = value;
				}
			}

			// Token: 0x17000289 RID: 649
			// (get) Token: 0x06000607 RID: 1543 RVA: 0x00016E30 File Offset: 0x00015E30
			// (set) Token: 0x06000608 RID: 1544 RVA: 0x00016E78 File Offset: 0x00015E78
			[DebuggerNonUserCode]
			public string _2_2D_MitAnn
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_MitAnnColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_MitAnn' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_MitAnnColumn] = value;
				}
			}

			// Token: 0x1700028A RID: 650
			// (get) Token: 0x06000609 RID: 1545 RVA: 0x00016E90 File Offset: 0x00015E90
			// (set) Token: 0x0600060A RID: 1546 RVA: 0x00016ED8 File Offset: 0x00015ED8
			[DebuggerNonUserCode]
			public string _2_2D_LPA
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_LPAColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_LPA' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_LPAColumn] = value;
				}
			}

			// Token: 0x1700028B RID: 651
			// (get) Token: 0x0600060B RID: 1547 RVA: 0x00016EF0 File Offset: 0x00015EF0
			// (set) Token: 0x0600060C RID: 1548 RVA: 0x00016F38 File Offset: 0x00015F38
			[DebuggerNonUserCode]
			public string _2_2D_RPA
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_2D_RPAColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_2D_RPA' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_2D_RPAColumn] = value;
				}
			}

			// Token: 0x1700028C RID: 652
			// (get) Token: 0x0600060D RID: 1549 RVA: 0x00016F50 File Offset: 0x00015F50
			// (set) Token: 0x0600060E RID: 1550 RVA: 0x00016F98 File Offset: 0x00015F98
			[DebuggerNonUserCode]
			public string _2_Khac
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._2_KhacColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2_Khac' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._2_KhacColumn] = value;
				}
			}

			// Token: 0x1700028D RID: 653
			// (get) Token: 0x0600060F RID: 1551 RVA: 0x00016FB0 File Offset: 0x00015FB0
			// (set) Token: 0x06000610 RID: 1552 RVA: 0x00016FF8 File Offset: 0x00015FF8
			[DebuggerNonUserCode]
			public string _3_2la_Vmax
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_2la_VmaxColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_2la_Vmax' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_2la_VmaxColumn] = value;
				}
			}

			// Token: 0x1700028E RID: 654
			// (get) Token: 0x06000611 RID: 1553 RVA: 0x00017010 File Offset: 0x00016010
			// (set) Token: 0x06000612 RID: 1554 RVA: 0x00017058 File Offset: 0x00016058
			[DebuggerNonUserCode]
			public string _3_2la_MaxGd
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_2la_MaxGdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_2la_MaxGd' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_2la_MaxGdColumn] = value;
				}
			}

			// Token: 0x1700028F RID: 655
			// (get) Token: 0x06000613 RID: 1555 RVA: 0x00017070 File Offset: 0x00016070
			// (set) Token: 0x06000614 RID: 1556 RVA: 0x000170B8 File Offset: 0x000160B8
			[DebuggerNonUserCode]
			public string _3_2la_Stenosis
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_2la_StenosisColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_2la_Stenosis' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_2la_StenosisColumn] = value;
				}
			}

			// Token: 0x17000290 RID: 656
			// (get) Token: 0x06000615 RID: 1557 RVA: 0x000170D0 File Offset: 0x000160D0
			// (set) Token: 0x06000616 RID: 1558 RVA: 0x00017118 File Offset: 0x00016118
			[DebuggerNonUserCode]
			public string _3_2la_MeanGd
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_2la_MeanGdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_2la_MeanGd' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_2la_MeanGdColumn] = value;
				}
			}

			// Token: 0x17000291 RID: 657
			// (get) Token: 0x06000617 RID: 1559 RVA: 0x00017130 File Offset: 0x00016130
			// (set) Token: 0x06000618 RID: 1560 RVA: 0x00017178 File Offset: 0x00016178
			[DebuggerNonUserCode]
			public string _3_2la_PHT
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_2la_PHTColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_2la_PHT' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_2la_PHTColumn] = value;
				}
			}

			// Token: 0x17000292 RID: 658
			// (get) Token: 0x06000619 RID: 1561 RVA: 0x00017190 File Offset: 0x00016190
			// (set) Token: 0x0600061A RID: 1562 RVA: 0x000171D8 File Offset: 0x000161D8
			[DebuggerNonUserCode]
			public string _3_2la_Ho
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_2la_HoColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_2la_Ho' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_2la_HoColumn] = value;
				}
			}

			// Token: 0x17000293 RID: 659
			// (get) Token: 0x0600061B RID: 1563 RVA: 0x000171F0 File Offset: 0x000161F0
			// (set) Token: 0x0600061C RID: 1564 RVA: 0x00017238 File Offset: 0x00016238
			[DebuggerNonUserCode]
			public string _3_2la_Degree
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_2la_DegreeColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_2la_Degree' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_2la_DegreeColumn] = value;
				}
			}

			// Token: 0x17000294 RID: 660
			// (get) Token: 0x0600061D RID: 1565 RVA: 0x00017250 File Offset: 0x00016250
			// (set) Token: 0x0600061E RID: 1566 RVA: 0x00017298 File Offset: 0x00016298
			[DebuggerNonUserCode]
			public string _3_DMC_Vmax
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMC_VmaxColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMC_Vmax' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMC_VmaxColumn] = value;
				}
			}

			// Token: 0x17000295 RID: 661
			// (get) Token: 0x0600061F RID: 1567 RVA: 0x000172B0 File Offset: 0x000162B0
			// (set) Token: 0x06000620 RID: 1568 RVA: 0x000172F8 File Offset: 0x000162F8
			[DebuggerNonUserCode]
			public string _3_DMC_MaxGd
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMC_MaxGdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMC_MaxGd' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMC_MaxGdColumn] = value;
				}
			}

			// Token: 0x17000296 RID: 662
			// (get) Token: 0x06000621 RID: 1569 RVA: 0x00017310 File Offset: 0x00016310
			// (set) Token: 0x06000622 RID: 1570 RVA: 0x00017358 File Offset: 0x00016358
			[DebuggerNonUserCode]
			public string _3_DMC_Stenosis
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMC_StenosisColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMC_Stenosis' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMC_StenosisColumn] = value;
				}
			}

			// Token: 0x17000297 RID: 663
			// (get) Token: 0x06000623 RID: 1571 RVA: 0x00017370 File Offset: 0x00016370
			// (set) Token: 0x06000624 RID: 1572 RVA: 0x000173B8 File Offset: 0x000163B8
			[DebuggerNonUserCode]
			public string _3_DMC_MeanGd
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMC_MeanGdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMC_MeanGd' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMC_MeanGdColumn] = value;
				}
			}

			// Token: 0x17000298 RID: 664
			// (get) Token: 0x06000625 RID: 1573 RVA: 0x000173D0 File Offset: 0x000163D0
			// (set) Token: 0x06000626 RID: 1574 RVA: 0x00017418 File Offset: 0x00016418
			[DebuggerNonUserCode]
			public string _3_DMC_Edc
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMC_EdcColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMC_Edc' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMC_EdcColumn] = value;
				}
			}

			// Token: 0x17000299 RID: 665
			// (get) Token: 0x06000627 RID: 1575 RVA: 0x00017430 File Offset: 0x00016430
			// (set) Token: 0x06000628 RID: 1576 RVA: 0x00017478 File Offset: 0x00016478
			[DebuggerNonUserCode]
			public string _3_DMC_Ho
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMC_HoColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMC_Ho' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMC_HoColumn] = value;
				}
			}

			// Token: 0x1700029A RID: 666
			// (get) Token: 0x06000629 RID: 1577 RVA: 0x00017490 File Offset: 0x00016490
			// (set) Token: 0x0600062A RID: 1578 RVA: 0x000174D8 File Offset: 0x000164D8
			[DebuggerNonUserCode]
			public string _3_DMC_PHT
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMC_PHTColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMC_PHT' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMC_PHTColumn] = value;
				}
			}

			// Token: 0x1700029B RID: 667
			// (get) Token: 0x0600062B RID: 1579 RVA: 0x000174F0 File Offset: 0x000164F0
			// (set) Token: 0x0600062C RID: 1580 RVA: 0x00017538 File Offset: 0x00016538
			[DebuggerNonUserCode]
			public string _3_DMC_EDTD
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMC_EDTDColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMC_EDTD' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMC_EDTDColumn] = value;
				}
			}

			// Token: 0x1700029C RID: 668
			// (get) Token: 0x0600062D RID: 1581 RVA: 0x00017550 File Offset: 0x00016550
			// (set) Token: 0x0600062E RID: 1582 RVA: 0x00017598 File Offset: 0x00016598
			[DebuggerNonUserCode]
			public string _3_DMC_Degree
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMC_DegreeColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMC_Degree' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMC_DegreeColumn] = value;
				}
			}

			// Token: 0x1700029D RID: 669
			// (get) Token: 0x0600062F RID: 1583 RVA: 0x000175B0 File Offset: 0x000165B0
			// (set) Token: 0x06000630 RID: 1584 RVA: 0x000175F8 File Offset: 0x000165F8
			[DebuggerNonUserCode]
			public string _3_DMC_DFO
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMC_DFOColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMC_DFO' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMC_DFOColumn] = value;
				}
			}

			// Token: 0x1700029E RID: 670
			// (get) Token: 0x06000631 RID: 1585 RVA: 0x00017610 File Offset: 0x00016610
			// (set) Token: 0x06000632 RID: 1586 RVA: 0x00017658 File Offset: 0x00016658
			[DebuggerNonUserCode]
			public string _3_DMC_DoLan
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMC_DoLanColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMC_DoLan' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMC_DoLanColumn] = value;
				}
			}

			// Token: 0x1700029F RID: 671
			// (get) Token: 0x06000633 RID: 1587 RVA: 0x00017670 File Offset: 0x00016670
			// (set) Token: 0x06000634 RID: 1588 RVA: 0x000176B8 File Offset: 0x000166B8
			[DebuggerNonUserCode]
			public string _3_3la_Vmax
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_3la_VmaxColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_3la_Vmax' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_3la_VmaxColumn] = value;
				}
			}

			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x06000635 RID: 1589 RVA: 0x000176D0 File Offset: 0x000166D0
			// (set) Token: 0x06000636 RID: 1590 RVA: 0x00017718 File Offset: 0x00016718
			[DebuggerNonUserCode]
			public string _3_3la_Ho
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_3la_HoColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_3la_Ho' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_3la_HoColumn] = value;
				}
			}

			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x06000637 RID: 1591 RVA: 0x00017730 File Offset: 0x00016730
			// (set) Token: 0x06000638 RID: 1592 RVA: 0x00017778 File Offset: 0x00016778
			[DebuggerNonUserCode]
			public string _3_3la_MaxGd
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_3la_MaxGdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_3la_MaxGd' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_3la_MaxGdColumn] = value;
				}
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x06000639 RID: 1593 RVA: 0x00017790 File Offset: 0x00016790
			// (set) Token: 0x0600063A RID: 1594 RVA: 0x000177D8 File Offset: 0x000167D8
			[DebuggerNonUserCode]
			public string _3_3la_ALDMPTT
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_3la_ALDMPTTColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_3la_ALDMPTT' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_3la_ALDMPTTColumn] = value;
				}
			}

			// Token: 0x170002A3 RID: 675
			// (get) Token: 0x0600063B RID: 1595 RVA: 0x000177F0 File Offset: 0x000167F0
			// (set) Token: 0x0600063C RID: 1596 RVA: 0x00017838 File Offset: 0x00016838
			[DebuggerNonUserCode]
			public string _3_3la_MeanGd
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_3la_MeanGdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_3la_MeanGd' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_3la_MeanGdColumn] = value;
				}
			}

			// Token: 0x170002A4 RID: 676
			// (get) Token: 0x0600063D RID: 1597 RVA: 0x00017850 File Offset: 0x00016850
			// (set) Token: 0x0600063E RID: 1598 RVA: 0x00017898 File Offset: 0x00016898
			[DebuggerNonUserCode]
			public string _3_DMP_Vmax
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMP_VmaxColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMP_Vmax' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMP_VmaxColumn] = value;
				}
			}

			// Token: 0x170002A5 RID: 677
			// (get) Token: 0x0600063F RID: 1599 RVA: 0x000178B0 File Offset: 0x000168B0
			// (set) Token: 0x06000640 RID: 1600 RVA: 0x000178F8 File Offset: 0x000168F8
			[DebuggerNonUserCode]
			public string _3_DMP_MaxGd
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMP_MaxGdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMP_MaxGd' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMP_MaxGdColumn] = value;
				}
			}

			// Token: 0x170002A6 RID: 678
			// (get) Token: 0x06000641 RID: 1601 RVA: 0x00017910 File Offset: 0x00016910
			// (set) Token: 0x06000642 RID: 1602 RVA: 0x00017958 File Offset: 0x00016958
			[DebuggerNonUserCode]
			public string _3_DMP_HoDMP
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMP_HoDMPColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMP_HoDMP' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMP_HoDMPColumn] = value;
				}
			}

			// Token: 0x170002A7 RID: 679
			// (get) Token: 0x06000643 RID: 1603 RVA: 0x00017970 File Offset: 0x00016970
			// (set) Token: 0x06000644 RID: 1604 RVA: 0x000179B8 File Offset: 0x000169B8
			[DebuggerNonUserCode]
			public string _3_DMP_QpQs
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMP_QpQsColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMP_QpQs' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMP_QpQsColumn] = value;
				}
			}

			// Token: 0x170002A8 RID: 680
			// (get) Token: 0x06000645 RID: 1605 RVA: 0x000179D0 File Offset: 0x000169D0
			// (set) Token: 0x06000646 RID: 1606 RVA: 0x00017A18 File Offset: 0x00016A18
			[DebuggerNonUserCode]
			public string _3_DMP_MeanGd
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMP_MeanGdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMP_MeanGd' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMP_MeanGdColumn] = value;
				}
			}

			// Token: 0x170002A9 RID: 681
			// (get) Token: 0x06000647 RID: 1607 RVA: 0x00017A30 File Offset: 0x00016A30
			// (set) Token: 0x06000648 RID: 1608 RVA: 0x00017A78 File Offset: 0x00016A78
			[DebuggerNonUserCode]
			public string _3_DMP_ALDMPTB
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMP_ALDMPTBColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMP_ALDMPTB' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMP_ALDMPTBColumn] = value;
				}
			}

			// Token: 0x170002AA RID: 682
			// (get) Token: 0x06000649 RID: 1609 RVA: 0x00017A90 File Offset: 0x00016A90
			// (set) Token: 0x0600064A RID: 1610 RVA: 0x00017AD8 File Offset: 0x00016AD8
			[DebuggerNonUserCode]
			public string _3_DMP_ALDMPTTr
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_DMP_ALDMPTTrColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_DMP_ALDMPTTr' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_DMP_ALDMPTTrColumn] = value;
				}
			}

			// Token: 0x170002AB RID: 683
			// (get) Token: 0x0600064B RID: 1611 RVA: 0x00017AF0 File Offset: 0x00016AF0
			// (set) Token: 0x0600064C RID: 1612 RVA: 0x00017B38 File Offset: 0x00016B38
			[DebuggerNonUserCode]
			public string _3_Khac
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSATIM._3_KhacColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3_Khac' in table 'SATIM' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSATIM._3_KhacColumn] = value;
				}
			}

			// Token: 0x0600064D RID: 1613 RVA: 0x00017B50 File Offset: 0x00016B50
			[DebuggerNonUserCode]
			public bool IsKetQua_SATM_IdNull()
			{
				return base.IsNull(this.tableSATIM.KetQua_SATM_IdColumn);
			}

			// Token: 0x0600064E RID: 1614 RVA: 0x00017B73 File Offset: 0x00016B73
			[DebuggerNonUserCode]
			public void SetKetQua_SATM_IdNull()
			{
				base[this.tableSATIM.KetQua_SATM_IdColumn] = Convert.DBNull;
			}

			// Token: 0x0600064F RID: 1615 RVA: 0x00017B90 File Offset: 0x00016B90
			[DebuggerNonUserCode]
			public bool IsSA_TM_IdNull()
			{
				return base.IsNull(this.tableSATIM.SA_TM_IdColumn);
			}

			// Token: 0x06000650 RID: 1616 RVA: 0x00017BB3 File Offset: 0x00016BB3
			[DebuggerNonUserCode]
			public void SetSA_TM_IdNull()
			{
				base[this.tableSATIM.SA_TM_IdColumn] = Convert.DBNull;
			}

			// Token: 0x06000651 RID: 1617 RVA: 0x00017BD0 File Offset: 0x00016BD0
			[DebuggerNonUserCode]
			public bool IsBenhNhan_IdNull()
			{
				return base.IsNull(this.tableSATIM.BenhNhan_IdColumn);
			}

			// Token: 0x06000652 RID: 1618 RVA: 0x00017BF3 File Offset: 0x00016BF3
			[DebuggerNonUserCode]
			public void SetBenhNhan_IdNull()
			{
				base[this.tableSATIM.BenhNhan_IdColumn] = Convert.DBNull;
			}

			// Token: 0x06000653 RID: 1619 RVA: 0x00017C10 File Offset: 0x00016C10
			[DebuggerNonUserCode]
			public bool IsY_Te_IdNull()
			{
				return base.IsNull(this.tableSATIM.Y_Te_IdColumn);
			}

			// Token: 0x06000654 RID: 1620 RVA: 0x00017C33 File Offset: 0x00016C33
			[DebuggerNonUserCode]
			public void SetY_Te_IdNull()
			{
				base[this.tableSATIM.Y_Te_IdColumn] = Convert.DBNull;
			}

			// Token: 0x06000655 RID: 1621 RVA: 0x00017C50 File Offset: 0x00016C50
			[DebuggerNonUserCode]
			public bool IsHo_TenNull()
			{
				return base.IsNull(this.tableSATIM.Ho_TenColumn);
			}

			// Token: 0x06000656 RID: 1622 RVA: 0x00017C73 File Offset: 0x00016C73
			[DebuggerNonUserCode]
			public void SetHo_TenNull()
			{
				base[this.tableSATIM.Ho_TenColumn] = Convert.DBNull;
			}

			// Token: 0x06000657 RID: 1623 RVA: 0x00017C90 File Offset: 0x00016C90
			[DebuggerNonUserCode]
			public bool IsGioi_TinhNull()
			{
				return base.IsNull(this.tableSATIM.Gioi_TinhColumn);
			}

			// Token: 0x06000658 RID: 1624 RVA: 0x00017CB3 File Offset: 0x00016CB3
			[DebuggerNonUserCode]
			public void SetGioi_TinhNull()
			{
				base[this.tableSATIM.Gioi_TinhColumn] = Convert.DBNull;
			}

			// Token: 0x06000659 RID: 1625 RVA: 0x00017CD0 File Offset: 0x00016CD0
			[DebuggerNonUserCode]
			public bool IsNam_SinhNull()
			{
				return base.IsNull(this.tableSATIM.Nam_SinhColumn);
			}

			// Token: 0x0600065A RID: 1626 RVA: 0x00017CF3 File Offset: 0x00016CF3
			[DebuggerNonUserCode]
			public void SetNam_SinhNull()
			{
				base[this.tableSATIM.Nam_SinhColumn] = Convert.DBNull;
			}

			// Token: 0x0600065B RID: 1627 RVA: 0x00017D10 File Offset: 0x00016D10
			[DebuggerNonUserCode]
			public bool IsDia_ChiNull()
			{
				return base.IsNull(this.tableSATIM.Dia_ChiColumn);
			}

			// Token: 0x0600065C RID: 1628 RVA: 0x00017D33 File Offset: 0x00016D33
			[DebuggerNonUserCode]
			public void SetDia_ChiNull()
			{
				base[this.tableSATIM.Dia_ChiColumn] = Convert.DBNull;
			}

			// Token: 0x0600065D RID: 1629 RVA: 0x00017D50 File Offset: 0x00016D50
			[DebuggerNonUserCode]
			public bool IsHuyen_TinhNull()
			{
				return base.IsNull(this.tableSATIM.Huyen_TinhColumn);
			}

			// Token: 0x0600065E RID: 1630 RVA: 0x00017D73 File Offset: 0x00016D73
			[DebuggerNonUserCode]
			public void SetHuyen_TinhNull()
			{
				base[this.tableSATIM.Huyen_TinhColumn] = Convert.DBNull;
			}

			// Token: 0x0600065F RID: 1631 RVA: 0x00017D90 File Offset: 0x00016D90
			[DebuggerNonUserCode]
			public bool IsNgayNull()
			{
				return base.IsNull(this.tableSATIM.NgayColumn);
			}

			// Token: 0x06000660 RID: 1632 RVA: 0x00017DB3 File Offset: 0x00016DB3
			[DebuggerNonUserCode]
			public void SetNgayNull()
			{
				base[this.tableSATIM.NgayColumn] = Convert.DBNull;
			}

			// Token: 0x06000661 RID: 1633 RVA: 0x00017DD0 File Offset: 0x00016DD0
			[DebuggerNonUserCode]
			public bool IsLam_SangNull()
			{
				return base.IsNull(this.tableSATIM.Lam_SangColumn);
			}

			// Token: 0x06000662 RID: 1634 RVA: 0x00017DF3 File Offset: 0x00016DF3
			[DebuggerNonUserCode]
			public void SetLam_SangNull()
			{
				base[this.tableSATIM.Lam_SangColumn] = Convert.DBNull;
			}

			// Token: 0x06000663 RID: 1635 RVA: 0x00017E10 File Offset: 0x00016E10
			[DebuggerNonUserCode]
			public bool IsKhacNull()
			{
				return base.IsNull(this.tableSATIM.KhacColumn);
			}

			// Token: 0x06000664 RID: 1636 RVA: 0x00017E33 File Offset: 0x00016E33
			[DebuggerNonUserCode]
			public void SetKhacNull()
			{
				base[this.tableSATIM.KhacColumn] = Convert.DBNull;
			}

			// Token: 0x06000665 RID: 1637 RVA: 0x00017E50 File Offset: 0x00016E50
			[DebuggerNonUserCode]
			public bool IsKet_LuanNull()
			{
				return base.IsNull(this.tableSATIM.Ket_LuanColumn);
			}

			// Token: 0x06000666 RID: 1638 RVA: 0x00017E73 File Offset: 0x00016E73
			[DebuggerNonUserCode]
			public void SetKet_LuanNull()
			{
				base[this.tableSATIM.Ket_LuanColumn] = Convert.DBNull;
			}

			// Token: 0x06000667 RID: 1639 RVA: 0x00017E90 File Offset: 0x00016E90
			[DebuggerNonUserCode]
			public bool IsDS_Anh_KQNull()
			{
				return base.IsNull(this.tableSATIM.DS_Anh_KQColumn);
			}

			// Token: 0x06000668 RID: 1640 RVA: 0x00017EB3 File Offset: 0x00016EB3
			[DebuggerNonUserCode]
			public void SetDS_Anh_KQNull()
			{
				base[this.tableSATIM.DS_Anh_KQColumn] = Convert.DBNull;
			}

			// Token: 0x06000669 RID: 1641 RVA: 0x00017ED0 File Offset: 0x00016ED0
			[DebuggerNonUserCode]
			public bool IsTrinh_DoNull()
			{
				return base.IsNull(this.tableSATIM.Trinh_DoColumn);
			}

			// Token: 0x0600066A RID: 1642 RVA: 0x00017EF3 File Offset: 0x00016EF3
			[DebuggerNonUserCode]
			public void SetTrinh_DoNull()
			{
				base[this.tableSATIM.Trinh_DoColumn] = Convert.DBNull;
			}

			// Token: 0x0600066B RID: 1643 RVA: 0x00017F10 File Offset: 0x00016F10
			[DebuggerNonUserCode]
			public bool IsHo_Ten_BSSANull()
			{
				return base.IsNull(this.tableSATIM.Ho_Ten_BSSAColumn);
			}

			// Token: 0x0600066C RID: 1644 RVA: 0x00017F33 File Offset: 0x00016F33
			[DebuggerNonUserCode]
			public void SetHo_Ten_BSSANull()
			{
				base[this.tableSATIM.Ho_Ten_BSSAColumn] = Convert.DBNull;
			}

			// Token: 0x0600066D RID: 1645 RVA: 0x00017F50 File Offset: 0x00016F50
			[DebuggerNonUserCode]
			public bool IsCan_NangNull()
			{
				return base.IsNull(this.tableSATIM.Can_NangColumn);
			}

			// Token: 0x0600066E RID: 1646 RVA: 0x00017F73 File Offset: 0x00016F73
			[DebuggerNonUserCode]
			public void SetCan_NangNull()
			{
				base[this.tableSATIM.Can_NangColumn] = Convert.DBNull;
			}

			// Token: 0x0600066F RID: 1647 RVA: 0x00017F90 File Offset: 0x00016F90
			[DebuggerNonUserCode]
			public bool IsChieu_CaoNull()
			{
				return base.IsNull(this.tableSATIM.Chieu_CaoColumn);
			}

			// Token: 0x06000670 RID: 1648 RVA: 0x00017FB3 File Offset: 0x00016FB3
			[DebuggerNonUserCode]
			public void SetChieu_CaoNull()
			{
				base[this.tableSATIM.Chieu_CaoColumn] = Convert.DBNull;
			}

			// Token: 0x06000671 RID: 1649 RVA: 0x00017FD0 File Offset: 0x00016FD0
			[DebuggerNonUserCode]
			public bool IsBSANull()
			{
				return base.IsNull(this.tableSATIM.BSAColumn);
			}

			// Token: 0x06000672 RID: 1650 RVA: 0x00017FF3 File Offset: 0x00016FF3
			[DebuggerNonUserCode]
			public void SetBSANull()
			{
				base[this.tableSATIM.BSAColumn] = Convert.DBNull;
			}

			// Token: 0x06000673 RID: 1651 RVA: 0x00018010 File Offset: 0x00017010
			[DebuggerNonUserCode]
			public bool IsNhip_TimNull()
			{
				return base.IsNull(this.tableSATIM.Nhip_TimColumn);
			}

			// Token: 0x06000674 RID: 1652 RVA: 0x00018033 File Offset: 0x00017033
			[DebuggerNonUserCode]
			public void SetNhip_TimNull()
			{
				base[this.tableSATIM.Nhip_TimColumn] = Convert.DBNull;
			}

			// Token: 0x06000675 RID: 1653 RVA: 0x00018050 File Offset: 0x00017050
			[DebuggerNonUserCode]
			public bool IsHuyet_ApNull()
			{
				return base.IsNull(this.tableSATIM.Huyet_ApColumn);
			}

			// Token: 0x06000676 RID: 1654 RVA: 0x00018073 File Offset: 0x00017073
			[DebuggerNonUserCode]
			public void SetHuyet_ApNull()
			{
				base[this.tableSATIM.Huyet_ApColumn] = Convert.DBNull;
			}

			// Token: 0x06000677 RID: 1655 RVA: 0x00018090 File Offset: 0x00017090
			[DebuggerNonUserCode]
			public bool Is_2_TM_IVSdNull()
			{
				return base.IsNull(this.tableSATIM._2_TM_IVSdColumn);
			}

			// Token: 0x06000678 RID: 1656 RVA: 0x000180B3 File Offset: 0x000170B3
			[DebuggerNonUserCode]
			public void Set_2_TM_IVSdNull()
			{
				base[this.tableSATIM._2_TM_IVSdColumn] = Convert.DBNull;
			}

			// Token: 0x06000679 RID: 1657 RVA: 0x000180D0 File Offset: 0x000170D0
			[DebuggerNonUserCode]
			public bool Is_2_TM_LVDdNull()
			{
				return base.IsNull(this.tableSATIM._2_TM_LVDdColumn);
			}

			// Token: 0x0600067A RID: 1658 RVA: 0x000180F3 File Offset: 0x000170F3
			[DebuggerNonUserCode]
			public void Set_2_TM_LVDdNull()
			{
				base[this.tableSATIM._2_TM_LVDdColumn] = Convert.DBNull;
			}

			// Token: 0x0600067B RID: 1659 RVA: 0x00018110 File Offset: 0x00017110
			[DebuggerNonUserCode]
			public bool Is_2_TM_PLVWNull()
			{
				return base.IsNull(this.tableSATIM._2_TM_PLVWColumn);
			}

			// Token: 0x0600067C RID: 1660 RVA: 0x00018133 File Offset: 0x00017133
			[DebuggerNonUserCode]
			public void Set_2_TM_PLVWNull()
			{
				base[this.tableSATIM._2_TM_PLVWColumn] = Convert.DBNull;
			}

			// Token: 0x0600067D RID: 1661 RVA: 0x00018150 File Offset: 0x00017150
			[DebuggerNonUserCode]
			public bool Is_2_TM_IVSsNull()
			{
				return base.IsNull(this.tableSATIM._2_TM_IVSsColumn);
			}

			// Token: 0x0600067E RID: 1662 RVA: 0x00018173 File Offset: 0x00017173
			[DebuggerNonUserCode]
			public void Set_2_TM_IVSsNull()
			{
				base[this.tableSATIM._2_TM_IVSsColumn] = Convert.DBNull;
			}

			// Token: 0x0600067F RID: 1663 RVA: 0x00018190 File Offset: 0x00017190
			[DebuggerNonUserCode]
			public bool Is_2_TM_LVDsNull()
			{
				return base.IsNull(this.tableSATIM._2_TM_LVDsColumn);
			}

			// Token: 0x06000680 RID: 1664 RVA: 0x000181B3 File Offset: 0x000171B3
			[DebuggerNonUserCode]
			public void Set_2_TM_LVDsNull()
			{
				base[this.tableSATIM._2_TM_LVDsColumn] = Convert.DBNull;
			}

			// Token: 0x06000681 RID: 1665 RVA: 0x000181D0 File Offset: 0x000171D0
			[DebuggerNonUserCode]
			public bool Is_2_TM_PLVWsNull()
			{
				return base.IsNull(this.tableSATIM._2_TM_PLVWsColumn);
			}

			// Token: 0x06000682 RID: 1666 RVA: 0x000181F3 File Offset: 0x000171F3
			[DebuggerNonUserCode]
			public void Set_2_TM_PLVWsNull()
			{
				base[this.tableSATIM._2_TM_PLVWsColumn] = Convert.DBNull;
			}

			// Token: 0x06000683 RID: 1667 RVA: 0x00018210 File Offset: 0x00017210
			[DebuggerNonUserCode]
			public bool Is_2_TM_SFNull()
			{
				return base.IsNull(this.tableSATIM._2_TM_SFColumn);
			}

			// Token: 0x06000684 RID: 1668 RVA: 0x00018233 File Offset: 0x00017233
			[DebuggerNonUserCode]
			public void Set_2_TM_SFNull()
			{
				base[this.tableSATIM._2_TM_SFColumn] = Convert.DBNull;
			}

			// Token: 0x06000685 RID: 1669 RVA: 0x00018250 File Offset: 0x00017250
			[DebuggerNonUserCode]
			public bool Is_2_TM_EFNull()
			{
				return base.IsNull(this.tableSATIM._2_TM_EFColumn);
			}

			// Token: 0x06000686 RID: 1670 RVA: 0x00018273 File Offset: 0x00017273
			[DebuggerNonUserCode]
			public void Set_2_TM_EFNull()
			{
				base[this.tableSATIM._2_TM_EFColumn] = Convert.DBNull;
			}

			// Token: 0x06000687 RID: 1671 RVA: 0x00018290 File Offset: 0x00017290
			[DebuggerNonUserCode]
			public bool Is_2_TM_RVdNull()
			{
				return base.IsNull(this.tableSATIM._2_TM_RVdColumn);
			}

			// Token: 0x06000688 RID: 1672 RVA: 0x000182B3 File Offset: 0x000172B3
			[DebuggerNonUserCode]
			public void Set_2_TM_RVdNull()
			{
				base[this.tableSATIM._2_TM_RVdColumn] = Convert.DBNull;
			}

			// Token: 0x06000689 RID: 1673 RVA: 0x000182D0 File Offset: 0x000172D0
			[DebuggerNonUserCode]
			public bool Is_2_TM_AoNull()
			{
				return base.IsNull(this.tableSATIM._2_TM_AoColumn);
			}

			// Token: 0x0600068A RID: 1674 RVA: 0x000182F3 File Offset: 0x000172F3
			[DebuggerNonUserCode]
			public void Set_2_TM_AoNull()
			{
				base[this.tableSATIM._2_TM_AoColumn] = Convert.DBNull;
			}

			// Token: 0x0600068B RID: 1675 RVA: 0x00018310 File Offset: 0x00017310
			[DebuggerNonUserCode]
			public bool Is_2_TM_LANull()
			{
				return base.IsNull(this.tableSATIM._2_TM_LAColumn);
			}

			// Token: 0x0600068C RID: 1676 RVA: 0x00018333 File Offset: 0x00017333
			[DebuggerNonUserCode]
			public void Set_2_TM_LANull()
			{
				base[this.tableSATIM._2_TM_LAColumn] = Convert.DBNull;
			}

			// Token: 0x0600068D RID: 1677 RVA: 0x00018350 File Offset: 0x00017350
			[DebuggerNonUserCode]
			public bool Is_2_TM_AVoNull()
			{
				return base.IsNull(this.tableSATIM._2_TM_AVoColumn);
			}

			// Token: 0x0600068E RID: 1678 RVA: 0x00018373 File Offset: 0x00017373
			[DebuggerNonUserCode]
			public void Set_2_TM_AVoNull()
			{
				base[this.tableSATIM._2_TM_AVoColumn] = Convert.DBNull;
			}

			// Token: 0x0600068F RID: 1679 RVA: 0x00018390 File Offset: 0x00017390
			[DebuggerNonUserCode]
			public bool Is_2_2D_SitusNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_SitusColumn);
			}

			// Token: 0x06000690 RID: 1680 RVA: 0x000183B3 File Offset: 0x000173B3
			[DebuggerNonUserCode]
			public void Set_2_2D_SitusNull()
			{
				base[this.tableSATIM._2_2D_SitusColumn] = Convert.DBNull;
			}

			// Token: 0x06000691 RID: 1681 RVA: 0x000183D0 File Offset: 0x000173D0
			[DebuggerNonUserCode]
			public bool Is_2_2D_VEINSNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_VEINSColumn);
			}

			// Token: 0x06000692 RID: 1682 RVA: 0x000183F3 File Offset: 0x000173F3
			[DebuggerNonUserCode]
			public void Set_2_2D_VEINSNull()
			{
				base[this.tableSATIM._2_2D_VEINSColumn] = Convert.DBNull;
			}

			// Token: 0x06000693 RID: 1683 RVA: 0x00018410 File Offset: 0x00017410
			[DebuggerNonUserCode]
			public bool Is_2_2D_AtriumNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_AtriumColumn);
			}

			// Token: 0x06000694 RID: 1684 RVA: 0x00018433 File Offset: 0x00017433
			[DebuggerNonUserCode]
			public void Set_2_2D_AtriumNull()
			{
				base[this.tableSATIM._2_2D_AtriumColumn] = Convert.DBNull;
			}

			// Token: 0x06000695 RID: 1685 RVA: 0x00018450 File Offset: 0x00017450
			[DebuggerNonUserCode]
			public bool Is_2_2D_VentricleNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_VentricleColumn);
			}

			// Token: 0x06000696 RID: 1686 RVA: 0x00018473 File Offset: 0x00017473
			[DebuggerNonUserCode]
			public void Set_2_2D_VentricleNull()
			{
				base[this.tableSATIM._2_2D_VentricleColumn] = Convert.DBNull;
			}

			// Token: 0x06000697 RID: 1687 RVA: 0x00018490 File Offset: 0x00017490
			[DebuggerNonUserCode]
			public bool Is_2_2D_DaiDongMachNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_DaiDongMachColumn);
			}

			// Token: 0x06000698 RID: 1688 RVA: 0x000184B3 File Offset: 0x000174B3
			[DebuggerNonUserCode]
			public void Set_2_2D_DaiDongMachNull()
			{
				base[this.tableSATIM._2_2D_DaiDongMachColumn] = Convert.DBNull;
			}

			// Token: 0x06000699 RID: 1689 RVA: 0x000184D0 File Offset: 0x000174D0
			[DebuggerNonUserCode]
			public bool Is_2_2D_MangNgoaiTimNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_MangNgoaiTimColumn);
			}

			// Token: 0x0600069A RID: 1690 RVA: 0x000184F3 File Offset: 0x000174F3
			[DebuggerNonUserCode]
			public void Set_2_2D_MangNgoaiTimNull()
			{
				base[this.tableSATIM._2_2D_MangNgoaiTimColumn] = Convert.DBNull;
			}

			// Token: 0x0600069B RID: 1691 RVA: 0x00018510 File Offset: 0x00017510
			[DebuggerNonUserCode]
			public bool Is_2_2D_IVCNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_IVCColumn);
			}

			// Token: 0x0600069C RID: 1692 RVA: 0x00018533 File Offset: 0x00017533
			[DebuggerNonUserCode]
			public void Set_2_2D_IVCNull()
			{
				base[this.tableSATIM._2_2D_IVCColumn] = Convert.DBNull;
			}

			// Token: 0x0600069D RID: 1693 RVA: 0x00018550 File Offset: 0x00017550
			[DebuggerNonUserCode]
			public bool Is_2_2D_LSVCNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_LSVCColumn);
			}

			// Token: 0x0600069E RID: 1694 RVA: 0x00018573 File Offset: 0x00017573
			[DebuggerNonUserCode]
			public void Set_2_2D_LSVCNull()
			{
				base[this.tableSATIM._2_2D_LSVCColumn] = Convert.DBNull;
			}

			// Token: 0x0600069F RID: 1695 RVA: 0x00018590 File Offset: 0x00017590
			[DebuggerNonUserCode]
			public bool Is_2_2D_ValvesNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_ValvesColumn);
			}

			// Token: 0x060006A0 RID: 1696 RVA: 0x000185B3 File Offset: 0x000175B3
			[DebuggerNonUserCode]
			public void Set_2_2D_ValvesNull()
			{
				base[this.tableSATIM._2_2D_ValvesColumn] = Convert.DBNull;
			}

			// Token: 0x060006A1 RID: 1697 RVA: 0x000185D0 File Offset: 0x000175D0
			[DebuggerNonUserCode]
			public bool Is_2_2D_DMCAoNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_DMCAoColumn);
			}

			// Token: 0x060006A2 RID: 1698 RVA: 0x000185F3 File Offset: 0x000175F3
			[DebuggerNonUserCode]
			public void Set_2_2D_DMCAoNull()
			{
				base[this.tableSATIM._2_2D_DMCAoColumn] = Convert.DBNull;
			}

			// Token: 0x060006A3 RID: 1699 RVA: 0x00018610 File Offset: 0x00017610
			[DebuggerNonUserCode]
			public bool Is_2_2D_DMPPANull()
			{
				return base.IsNull(this.tableSATIM._2_2D_DMPPAColumn);
			}

			// Token: 0x060006A4 RID: 1700 RVA: 0x00018633 File Offset: 0x00017633
			[DebuggerNonUserCode]
			public void Set_2_2D_DMPPANull()
			{
				base[this.tableSATIM._2_2D_DMPPAColumn] = Convert.DBNull;
			}

			// Token: 0x060006A5 RID: 1701 RVA: 0x00018650 File Offset: 0x00017650
			[DebuggerNonUserCode]
			public bool Is_2_2D_AnnNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_AnnColumn);
			}

			// Token: 0x060006A6 RID: 1702 RVA: 0x00018673 File Offset: 0x00017673
			[DebuggerNonUserCode]
			public void Set_2_2D_AnnNull()
			{
				base[this.tableSATIM._2_2D_AnnColumn] = Convert.DBNull;
			}

			// Token: 0x060006A7 RID: 1703 RVA: 0x00018690 File Offset: 0x00017690
			[DebuggerNonUserCode]
			public bool Is_2_2D_RSVCNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_RSVCColumn);
			}

			// Token: 0x060006A8 RID: 1704 RVA: 0x000186B3 File Offset: 0x000176B3
			[DebuggerNonUserCode]
			public void Set_2_2D_RSVCNull()
			{
				base[this.tableSATIM._2_2D_RSVCColumn] = Convert.DBNull;
			}

			// Token: 0x060006A9 RID: 1705 RVA: 0x000186D0 File Offset: 0x000176D0
			[DebuggerNonUserCode]
			public bool Is_2_2D_PulmVeinsNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_PulmVeinsColumn);
			}

			// Token: 0x060006AA RID: 1706 RVA: 0x000186F3 File Offset: 0x000176F3
			[DebuggerNonUserCode]
			public void Set_2_2D_PulmVeinsNull()
			{
				base[this.tableSATIM._2_2D_PulmVeinsColumn] = Convert.DBNull;
			}

			// Token: 0x060006AB RID: 1707 RVA: 0x00018710 File Offset: 0x00017710
			[DebuggerNonUserCode]
			public bool Is_2_2D_TricAnnNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_TricAnnColumn);
			}

			// Token: 0x060006AC RID: 1708 RVA: 0x00018733 File Offset: 0x00017733
			[DebuggerNonUserCode]
			public void Set_2_2D_TricAnnNull()
			{
				base[this.tableSATIM._2_2D_TricAnnColumn] = Convert.DBNull;
			}

			// Token: 0x060006AD RID: 1709 RVA: 0x00018750 File Offset: 0x00017750
			[DebuggerNonUserCode]
			public bool Is_2_2D_D2Null()
			{
				return base.IsNull(this.tableSATIM._2_2D_D2Column);
			}

			// Token: 0x060006AE RID: 1710 RVA: 0x00018773 File Offset: 0x00017773
			[DebuggerNonUserCode]
			public void Set_2_2D_D2Null()
			{
				base[this.tableSATIM._2_2D_D2Column] = Convert.DBNull;
			}

			// Token: 0x060006AF RID: 1711 RVA: 0x00018790 File Offset: 0x00017790
			[DebuggerNonUserCode]
			public bool Is_2_2D_PATrunkNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_PATrunkColumn);
			}

			// Token: 0x060006B0 RID: 1712 RVA: 0x000187B3 File Offset: 0x000177B3
			[DebuggerNonUserCode]
			public void Set_2_2D_PATrunkNull()
			{
				base[this.tableSATIM._2_2D_PATrunkColumn] = Convert.DBNull;
			}

			// Token: 0x060006B1 RID: 1713 RVA: 0x000187D0 File Offset: 0x000177D0
			[DebuggerNonUserCode]
			public bool Is_2_2D_InnVeinNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_InnVeinColumn);
			}

			// Token: 0x060006B2 RID: 1714 RVA: 0x000187F3 File Offset: 0x000177F3
			[DebuggerNonUserCode]
			public void Set_2_2D_InnVeinNull()
			{
				base[this.tableSATIM._2_2D_InnVeinColumn] = Convert.DBNull;
			}

			// Token: 0x060006B3 RID: 1715 RVA: 0x00018810 File Offset: 0x00017810
			[DebuggerNonUserCode]
			public bool Is_2_2D_AzygosNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_AzygosColumn);
			}

			// Token: 0x060006B4 RID: 1716 RVA: 0x00018833 File Offset: 0x00017833
			[DebuggerNonUserCode]
			public void Set_2_2D_AzygosNull()
			{
				base[this.tableSATIM._2_2D_AzygosColumn] = Convert.DBNull;
			}

			// Token: 0x060006B5 RID: 1717 RVA: 0x00018850 File Offset: 0x00017850
			[DebuggerNonUserCode]
			public bool Is_2_2D_MitAnnNull()
			{
				return base.IsNull(this.tableSATIM._2_2D_MitAnnColumn);
			}

			// Token: 0x060006B6 RID: 1718 RVA: 0x00018873 File Offset: 0x00017873
			[DebuggerNonUserCode]
			public void Set_2_2D_MitAnnNull()
			{
				base[this.tableSATIM._2_2D_MitAnnColumn] = Convert.DBNull;
			}

			// Token: 0x060006B7 RID: 1719 RVA: 0x00018890 File Offset: 0x00017890
			[DebuggerNonUserCode]
			public bool Is_2_2D_LPANull()
			{
				return base.IsNull(this.tableSATIM._2_2D_LPAColumn);
			}

			// Token: 0x060006B8 RID: 1720 RVA: 0x000188B3 File Offset: 0x000178B3
			[DebuggerNonUserCode]
			public void Set_2_2D_LPANull()
			{
				base[this.tableSATIM._2_2D_LPAColumn] = Convert.DBNull;
			}

			// Token: 0x060006B9 RID: 1721 RVA: 0x000188D0 File Offset: 0x000178D0
			[DebuggerNonUserCode]
			public bool Is_2_2D_RPANull()
			{
				return base.IsNull(this.tableSATIM._2_2D_RPAColumn);
			}

			// Token: 0x060006BA RID: 1722 RVA: 0x000188F3 File Offset: 0x000178F3
			[DebuggerNonUserCode]
			public void Set_2_2D_RPANull()
			{
				base[this.tableSATIM._2_2D_RPAColumn] = Convert.DBNull;
			}

			// Token: 0x060006BB RID: 1723 RVA: 0x00018910 File Offset: 0x00017910
			[DebuggerNonUserCode]
			public bool Is_2_KhacNull()
			{
				return base.IsNull(this.tableSATIM._2_KhacColumn);
			}

			// Token: 0x060006BC RID: 1724 RVA: 0x00018933 File Offset: 0x00017933
			[DebuggerNonUserCode]
			public void Set_2_KhacNull()
			{
				base[this.tableSATIM._2_KhacColumn] = Convert.DBNull;
			}

			// Token: 0x060006BD RID: 1725 RVA: 0x00018950 File Offset: 0x00017950
			[DebuggerNonUserCode]
			public bool Is_3_2la_VmaxNull()
			{
				return base.IsNull(this.tableSATIM._3_2la_VmaxColumn);
			}

			// Token: 0x060006BE RID: 1726 RVA: 0x00018973 File Offset: 0x00017973
			[DebuggerNonUserCode]
			public void Set_3_2la_VmaxNull()
			{
				base[this.tableSATIM._3_2la_VmaxColumn] = Convert.DBNull;
			}

			// Token: 0x060006BF RID: 1727 RVA: 0x00018990 File Offset: 0x00017990
			[DebuggerNonUserCode]
			public bool Is_3_2la_MaxGdNull()
			{
				return base.IsNull(this.tableSATIM._3_2la_MaxGdColumn);
			}

			// Token: 0x060006C0 RID: 1728 RVA: 0x000189B3 File Offset: 0x000179B3
			[DebuggerNonUserCode]
			public void Set_3_2la_MaxGdNull()
			{
				base[this.tableSATIM._3_2la_MaxGdColumn] = Convert.DBNull;
			}

			// Token: 0x060006C1 RID: 1729 RVA: 0x000189D0 File Offset: 0x000179D0
			[DebuggerNonUserCode]
			public bool Is_3_2la_StenosisNull()
			{
				return base.IsNull(this.tableSATIM._3_2la_StenosisColumn);
			}

			// Token: 0x060006C2 RID: 1730 RVA: 0x000189F3 File Offset: 0x000179F3
			[DebuggerNonUserCode]
			public void Set_3_2la_StenosisNull()
			{
				base[this.tableSATIM._3_2la_StenosisColumn] = Convert.DBNull;
			}

			// Token: 0x060006C3 RID: 1731 RVA: 0x00018A10 File Offset: 0x00017A10
			[DebuggerNonUserCode]
			public bool Is_3_2la_MeanGdNull()
			{
				return base.IsNull(this.tableSATIM._3_2la_MeanGdColumn);
			}

			// Token: 0x060006C4 RID: 1732 RVA: 0x00018A33 File Offset: 0x00017A33
			[DebuggerNonUserCode]
			public void Set_3_2la_MeanGdNull()
			{
				base[this.tableSATIM._3_2la_MeanGdColumn] = Convert.DBNull;
			}

			// Token: 0x060006C5 RID: 1733 RVA: 0x00018A50 File Offset: 0x00017A50
			[DebuggerNonUserCode]
			public bool Is_3_2la_PHTNull()
			{
				return base.IsNull(this.tableSATIM._3_2la_PHTColumn);
			}

			// Token: 0x060006C6 RID: 1734 RVA: 0x00018A73 File Offset: 0x00017A73
			[DebuggerNonUserCode]
			public void Set_3_2la_PHTNull()
			{
				base[this.tableSATIM._3_2la_PHTColumn] = Convert.DBNull;
			}

			// Token: 0x060006C7 RID: 1735 RVA: 0x00018A90 File Offset: 0x00017A90
			[DebuggerNonUserCode]
			public bool Is_3_2la_HoNull()
			{
				return base.IsNull(this.tableSATIM._3_2la_HoColumn);
			}

			// Token: 0x060006C8 RID: 1736 RVA: 0x00018AB3 File Offset: 0x00017AB3
			[DebuggerNonUserCode]
			public void Set_3_2la_HoNull()
			{
				base[this.tableSATIM._3_2la_HoColumn] = Convert.DBNull;
			}

			// Token: 0x060006C9 RID: 1737 RVA: 0x00018AD0 File Offset: 0x00017AD0
			[DebuggerNonUserCode]
			public bool Is_3_2la_DegreeNull()
			{
				return base.IsNull(this.tableSATIM._3_2la_DegreeColumn);
			}

			// Token: 0x060006CA RID: 1738 RVA: 0x00018AF3 File Offset: 0x00017AF3
			[DebuggerNonUserCode]
			public void Set_3_2la_DegreeNull()
			{
				base[this.tableSATIM._3_2la_DegreeColumn] = Convert.DBNull;
			}

			// Token: 0x060006CB RID: 1739 RVA: 0x00018B10 File Offset: 0x00017B10
			[DebuggerNonUserCode]
			public bool Is_3_DMC_VmaxNull()
			{
				return base.IsNull(this.tableSATIM._3_DMC_VmaxColumn);
			}

			// Token: 0x060006CC RID: 1740 RVA: 0x00018B33 File Offset: 0x00017B33
			[DebuggerNonUserCode]
			public void Set_3_DMC_VmaxNull()
			{
				base[this.tableSATIM._3_DMC_VmaxColumn] = Convert.DBNull;
			}

			// Token: 0x060006CD RID: 1741 RVA: 0x00018B50 File Offset: 0x00017B50
			[DebuggerNonUserCode]
			public bool Is_3_DMC_MaxGdNull()
			{
				return base.IsNull(this.tableSATIM._3_DMC_MaxGdColumn);
			}

			// Token: 0x060006CE RID: 1742 RVA: 0x00018B73 File Offset: 0x00017B73
			[DebuggerNonUserCode]
			public void Set_3_DMC_MaxGdNull()
			{
				base[this.tableSATIM._3_DMC_MaxGdColumn] = Convert.DBNull;
			}

			// Token: 0x060006CF RID: 1743 RVA: 0x00018B90 File Offset: 0x00017B90
			[DebuggerNonUserCode]
			public bool Is_3_DMC_StenosisNull()
			{
				return base.IsNull(this.tableSATIM._3_DMC_StenosisColumn);
			}

			// Token: 0x060006D0 RID: 1744 RVA: 0x00018BB3 File Offset: 0x00017BB3
			[DebuggerNonUserCode]
			public void Set_3_DMC_StenosisNull()
			{
				base[this.tableSATIM._3_DMC_StenosisColumn] = Convert.DBNull;
			}

			// Token: 0x060006D1 RID: 1745 RVA: 0x00018BD0 File Offset: 0x00017BD0
			[DebuggerNonUserCode]
			public bool Is_3_DMC_MeanGdNull()
			{
				return base.IsNull(this.tableSATIM._3_DMC_MeanGdColumn);
			}

			// Token: 0x060006D2 RID: 1746 RVA: 0x00018BF3 File Offset: 0x00017BF3
			[DebuggerNonUserCode]
			public void Set_3_DMC_MeanGdNull()
			{
				base[this.tableSATIM._3_DMC_MeanGdColumn] = Convert.DBNull;
			}

			// Token: 0x060006D3 RID: 1747 RVA: 0x00018C10 File Offset: 0x00017C10
			[DebuggerNonUserCode]
			public bool Is_3_DMC_EdcNull()
			{
				return base.IsNull(this.tableSATIM._3_DMC_EdcColumn);
			}

			// Token: 0x060006D4 RID: 1748 RVA: 0x00018C33 File Offset: 0x00017C33
			[DebuggerNonUserCode]
			public void Set_3_DMC_EdcNull()
			{
				base[this.tableSATIM._3_DMC_EdcColumn] = Convert.DBNull;
			}

			// Token: 0x060006D5 RID: 1749 RVA: 0x00018C50 File Offset: 0x00017C50
			[DebuggerNonUserCode]
			public bool Is_3_DMC_HoNull()
			{
				return base.IsNull(this.tableSATIM._3_DMC_HoColumn);
			}

			// Token: 0x060006D6 RID: 1750 RVA: 0x00018C73 File Offset: 0x00017C73
			[DebuggerNonUserCode]
			public void Set_3_DMC_HoNull()
			{
				base[this.tableSATIM._3_DMC_HoColumn] = Convert.DBNull;
			}

			// Token: 0x060006D7 RID: 1751 RVA: 0x00018C90 File Offset: 0x00017C90
			[DebuggerNonUserCode]
			public bool Is_3_DMC_PHTNull()
			{
				return base.IsNull(this.tableSATIM._3_DMC_PHTColumn);
			}

			// Token: 0x060006D8 RID: 1752 RVA: 0x00018CB3 File Offset: 0x00017CB3
			[DebuggerNonUserCode]
			public void Set_3_DMC_PHTNull()
			{
				base[this.tableSATIM._3_DMC_PHTColumn] = Convert.DBNull;
			}

			// Token: 0x060006D9 RID: 1753 RVA: 0x00018CD0 File Offset: 0x00017CD0
			[DebuggerNonUserCode]
			public bool Is_3_DMC_EDTDNull()
			{
				return base.IsNull(this.tableSATIM._3_DMC_EDTDColumn);
			}

			// Token: 0x060006DA RID: 1754 RVA: 0x00018CF3 File Offset: 0x00017CF3
			[DebuggerNonUserCode]
			public void Set_3_DMC_EDTDNull()
			{
				base[this.tableSATIM._3_DMC_EDTDColumn] = Convert.DBNull;
			}

			// Token: 0x060006DB RID: 1755 RVA: 0x00018D10 File Offset: 0x00017D10
			[DebuggerNonUserCode]
			public bool Is_3_DMC_DegreeNull()
			{
				return base.IsNull(this.tableSATIM._3_DMC_DegreeColumn);
			}

			// Token: 0x060006DC RID: 1756 RVA: 0x00018D33 File Offset: 0x00017D33
			[DebuggerNonUserCode]
			public void Set_3_DMC_DegreeNull()
			{
				base[this.tableSATIM._3_DMC_DegreeColumn] = Convert.DBNull;
			}

			// Token: 0x060006DD RID: 1757 RVA: 0x00018D50 File Offset: 0x00017D50
			[DebuggerNonUserCode]
			public bool Is_3_DMC_DFONull()
			{
				return base.IsNull(this.tableSATIM._3_DMC_DFOColumn);
			}

			// Token: 0x060006DE RID: 1758 RVA: 0x00018D73 File Offset: 0x00017D73
			[DebuggerNonUserCode]
			public void Set_3_DMC_DFONull()
			{
				base[this.tableSATIM._3_DMC_DFOColumn] = Convert.DBNull;
			}

			// Token: 0x060006DF RID: 1759 RVA: 0x00018D90 File Offset: 0x00017D90
			[DebuggerNonUserCode]
			public bool Is_3_DMC_DoLanNull()
			{
				return base.IsNull(this.tableSATIM._3_DMC_DoLanColumn);
			}

			// Token: 0x060006E0 RID: 1760 RVA: 0x00018DB3 File Offset: 0x00017DB3
			[DebuggerNonUserCode]
			public void Set_3_DMC_DoLanNull()
			{
				base[this.tableSATIM._3_DMC_DoLanColumn] = Convert.DBNull;
			}

			// Token: 0x060006E1 RID: 1761 RVA: 0x00018DD0 File Offset: 0x00017DD0
			[DebuggerNonUserCode]
			public bool Is_3_3la_VmaxNull()
			{
				return base.IsNull(this.tableSATIM._3_3la_VmaxColumn);
			}

			// Token: 0x060006E2 RID: 1762 RVA: 0x00018DF3 File Offset: 0x00017DF3
			[DebuggerNonUserCode]
			public void Set_3_3la_VmaxNull()
			{
				base[this.tableSATIM._3_3la_VmaxColumn] = Convert.DBNull;
			}

			// Token: 0x060006E3 RID: 1763 RVA: 0x00018E10 File Offset: 0x00017E10
			[DebuggerNonUserCode]
			public bool Is_3_3la_HoNull()
			{
				return base.IsNull(this.tableSATIM._3_3la_HoColumn);
			}

			// Token: 0x060006E4 RID: 1764 RVA: 0x00018E33 File Offset: 0x00017E33
			[DebuggerNonUserCode]
			public void Set_3_3la_HoNull()
			{
				base[this.tableSATIM._3_3la_HoColumn] = Convert.DBNull;
			}

			// Token: 0x060006E5 RID: 1765 RVA: 0x00018E50 File Offset: 0x00017E50
			[DebuggerNonUserCode]
			public bool Is_3_3la_MaxGdNull()
			{
				return base.IsNull(this.tableSATIM._3_3la_MaxGdColumn);
			}

			// Token: 0x060006E6 RID: 1766 RVA: 0x00018E73 File Offset: 0x00017E73
			[DebuggerNonUserCode]
			public void Set_3_3la_MaxGdNull()
			{
				base[this.tableSATIM._3_3la_MaxGdColumn] = Convert.DBNull;
			}

			// Token: 0x060006E7 RID: 1767 RVA: 0x00018E90 File Offset: 0x00017E90
			[DebuggerNonUserCode]
			public bool Is_3_3la_ALDMPTTNull()
			{
				return base.IsNull(this.tableSATIM._3_3la_ALDMPTTColumn);
			}

			// Token: 0x060006E8 RID: 1768 RVA: 0x00018EB3 File Offset: 0x00017EB3
			[DebuggerNonUserCode]
			public void Set_3_3la_ALDMPTTNull()
			{
				base[this.tableSATIM._3_3la_ALDMPTTColumn] = Convert.DBNull;
			}

			// Token: 0x060006E9 RID: 1769 RVA: 0x00018ED0 File Offset: 0x00017ED0
			[DebuggerNonUserCode]
			public bool Is_3_3la_MeanGdNull()
			{
				return base.IsNull(this.tableSATIM._3_3la_MeanGdColumn);
			}

			// Token: 0x060006EA RID: 1770 RVA: 0x00018EF3 File Offset: 0x00017EF3
			[DebuggerNonUserCode]
			public void Set_3_3la_MeanGdNull()
			{
				base[this.tableSATIM._3_3la_MeanGdColumn] = Convert.DBNull;
			}

			// Token: 0x060006EB RID: 1771 RVA: 0x00018F10 File Offset: 0x00017F10
			[DebuggerNonUserCode]
			public bool Is_3_DMP_VmaxNull()
			{
				return base.IsNull(this.tableSATIM._3_DMP_VmaxColumn);
			}

			// Token: 0x060006EC RID: 1772 RVA: 0x00018F33 File Offset: 0x00017F33
			[DebuggerNonUserCode]
			public void Set_3_DMP_VmaxNull()
			{
				base[this.tableSATIM._3_DMP_VmaxColumn] = Convert.DBNull;
			}

			// Token: 0x060006ED RID: 1773 RVA: 0x00018F50 File Offset: 0x00017F50
			[DebuggerNonUserCode]
			public bool Is_3_DMP_MaxGdNull()
			{
				return base.IsNull(this.tableSATIM._3_DMP_MaxGdColumn);
			}

			// Token: 0x060006EE RID: 1774 RVA: 0x00018F73 File Offset: 0x00017F73
			[DebuggerNonUserCode]
			public void Set_3_DMP_MaxGdNull()
			{
				base[this.tableSATIM._3_DMP_MaxGdColumn] = Convert.DBNull;
			}

			// Token: 0x060006EF RID: 1775 RVA: 0x00018F90 File Offset: 0x00017F90
			[DebuggerNonUserCode]
			public bool Is_3_DMP_HoDMPNull()
			{
				return base.IsNull(this.tableSATIM._3_DMP_HoDMPColumn);
			}

			// Token: 0x060006F0 RID: 1776 RVA: 0x00018FB3 File Offset: 0x00017FB3
			[DebuggerNonUserCode]
			public void Set_3_DMP_HoDMPNull()
			{
				base[this.tableSATIM._3_DMP_HoDMPColumn] = Convert.DBNull;
			}

			// Token: 0x060006F1 RID: 1777 RVA: 0x00018FD0 File Offset: 0x00017FD0
			[DebuggerNonUserCode]
			public bool Is_3_DMP_QpQsNull()
			{
				return base.IsNull(this.tableSATIM._3_DMP_QpQsColumn);
			}

			// Token: 0x060006F2 RID: 1778 RVA: 0x00018FF3 File Offset: 0x00017FF3
			[DebuggerNonUserCode]
			public void Set_3_DMP_QpQsNull()
			{
				base[this.tableSATIM._3_DMP_QpQsColumn] = Convert.DBNull;
			}

			// Token: 0x060006F3 RID: 1779 RVA: 0x00019010 File Offset: 0x00018010
			[DebuggerNonUserCode]
			public bool Is_3_DMP_MeanGdNull()
			{
				return base.IsNull(this.tableSATIM._3_DMP_MeanGdColumn);
			}

			// Token: 0x060006F4 RID: 1780 RVA: 0x00019033 File Offset: 0x00018033
			[DebuggerNonUserCode]
			public void Set_3_DMP_MeanGdNull()
			{
				base[this.tableSATIM._3_DMP_MeanGdColumn] = Convert.DBNull;
			}

			// Token: 0x060006F5 RID: 1781 RVA: 0x00019050 File Offset: 0x00018050
			[DebuggerNonUserCode]
			public bool Is_3_DMP_ALDMPTBNull()
			{
				return base.IsNull(this.tableSATIM._3_DMP_ALDMPTBColumn);
			}

			// Token: 0x060006F6 RID: 1782 RVA: 0x00019073 File Offset: 0x00018073
			[DebuggerNonUserCode]
			public void Set_3_DMP_ALDMPTBNull()
			{
				base[this.tableSATIM._3_DMP_ALDMPTBColumn] = Convert.DBNull;
			}

			// Token: 0x060006F7 RID: 1783 RVA: 0x00019090 File Offset: 0x00018090
			[DebuggerNonUserCode]
			public bool Is_3_DMP_ALDMPTTrNull()
			{
				return base.IsNull(this.tableSATIM._3_DMP_ALDMPTTrColumn);
			}

			// Token: 0x060006F8 RID: 1784 RVA: 0x000190B3 File Offset: 0x000180B3
			[DebuggerNonUserCode]
			public void Set_3_DMP_ALDMPTTrNull()
			{
				base[this.tableSATIM._3_DMP_ALDMPTTrColumn] = Convert.DBNull;
			}

			// Token: 0x060006F9 RID: 1785 RVA: 0x000190D0 File Offset: 0x000180D0
			[DebuggerNonUserCode]
			public bool Is_3_KhacNull()
			{
				return base.IsNull(this.tableSATIM._3_KhacColumn);
			}

			// Token: 0x060006FA RID: 1786 RVA: 0x000190F3 File Offset: 0x000180F3
			[DebuggerNonUserCode]
			public void Set_3_KhacNull()
			{
				base[this.tableSATIM._3_KhacColumn] = Convert.DBNull;
			}

			// Token: 0x04000131 RID: 305
			private dsKetQuaSA.SATIMDataTable tableSATIM;
		}

		// Token: 0x0200004B RID: 75
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class ImagesRow : DataRow
		{
			// Token: 0x060006FB RID: 1787 RVA: 0x0001910D File Offset: 0x0001810D
			[DebuggerNonUserCode]
			internal ImagesRow(DataRowBuilder rb) : base(rb)
			{
				this.tableImages = (dsKetQuaSA.ImagesDataTable)base.Table;
			}

			// Token: 0x170002AC RID: 684
			// (get) Token: 0x060006FC RID: 1788 RVA: 0x0001912C File Offset: 0x0001812C
			// (set) Token: 0x060006FD RID: 1789 RVA: 0x00019174 File Offset: 0x00018174
			[DebuggerNonUserCode]
			public byte[] Image1
			{
				get
				{
					byte[] result;
					try
					{
						result = (byte[])base[this.tableImages.Image1Column];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Image1' in table 'Images' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableImages.Image1Column] = value;
				}
			}

			// Token: 0x170002AD RID: 685
			// (get) Token: 0x060006FE RID: 1790 RVA: 0x0001918C File Offset: 0x0001818C
			// (set) Token: 0x060006FF RID: 1791 RVA: 0x000191D4 File Offset: 0x000181D4
			[DebuggerNonUserCode]
			public byte[] Image2
			{
				get
				{
					byte[] result;
					try
					{
						result = (byte[])base[this.tableImages.Image2Column];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Image2' in table 'Images' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableImages.Image2Column] = value;
				}
			}

			// Token: 0x170002AE RID: 686
			// (get) Token: 0x06000700 RID: 1792 RVA: 0x000191EC File Offset: 0x000181EC
			// (set) Token: 0x06000701 RID: 1793 RVA: 0x00019234 File Offset: 0x00018234
			[DebuggerNonUserCode]
			public byte[] Image3
			{
				get
				{
					byte[] result;
					try
					{
						result = (byte[])base[this.tableImages.Image3Column];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Image3' in table 'Images' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableImages.Image3Column] = value;
				}
			}

			// Token: 0x170002AF RID: 687
			// (get) Token: 0x06000702 RID: 1794 RVA: 0x0001924C File Offset: 0x0001824C
			// (set) Token: 0x06000703 RID: 1795 RVA: 0x00019294 File Offset: 0x00018294
			[DebuggerNonUserCode]
			public byte[] Image4
			{
				get
				{
					byte[] result;
					try
					{
						result = (byte[])base[this.tableImages.Image4Column];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Image4' in table 'Images' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableImages.Image4Column] = value;
				}
			}

			// Token: 0x06000704 RID: 1796 RVA: 0x000192AC File Offset: 0x000182AC
			[DebuggerNonUserCode]
			public bool IsImage1Null()
			{
				return base.IsNull(this.tableImages.Image1Column);
			}

			// Token: 0x06000705 RID: 1797 RVA: 0x000192CF File Offset: 0x000182CF
			[DebuggerNonUserCode]
			public void SetImage1Null()
			{
				base[this.tableImages.Image1Column] = Convert.DBNull;
			}

			// Token: 0x06000706 RID: 1798 RVA: 0x000192EC File Offset: 0x000182EC
			[DebuggerNonUserCode]
			public bool IsImage2Null()
			{
				return base.IsNull(this.tableImages.Image2Column);
			}

			// Token: 0x06000707 RID: 1799 RVA: 0x0001930F File Offset: 0x0001830F
			[DebuggerNonUserCode]
			public void SetImage2Null()
			{
				base[this.tableImages.Image2Column] = Convert.DBNull;
			}

			// Token: 0x06000708 RID: 1800 RVA: 0x0001932C File Offset: 0x0001832C
			[DebuggerNonUserCode]
			public bool IsImage3Null()
			{
				return base.IsNull(this.tableImages.Image3Column);
			}

			// Token: 0x06000709 RID: 1801 RVA: 0x0001934F File Offset: 0x0001834F
			[DebuggerNonUserCode]
			public void SetImage3Null()
			{
				base[this.tableImages.Image3Column] = Convert.DBNull;
			}

			// Token: 0x0600070A RID: 1802 RVA: 0x0001936C File Offset: 0x0001836C
			[DebuggerNonUserCode]
			public bool IsImage4Null()
			{
				return base.IsNull(this.tableImages.Image4Column);
			}

			// Token: 0x0600070B RID: 1803 RVA: 0x0001938F File Offset: 0x0001838F
			[DebuggerNonUserCode]
			public void SetImage4Null()
			{
				base[this.tableImages.Image4Column] = Convert.DBNull;
			}

			// Token: 0x04000132 RID: 306
			private dsKetQuaSA.ImagesDataTable tableImages;
		}

		// Token: 0x0200004C RID: 76
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SAKHACRowChangeEvent : EventArgs
		{
			// Token: 0x0600070C RID: 1804 RVA: 0x000193A9 File Offset: 0x000183A9
			[DebuggerNonUserCode]
			public SAKHACRowChangeEvent(dsKetQuaSA.SAKHACRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170002B0 RID: 688
			// (get) Token: 0x0600070D RID: 1805 RVA: 0x000193C4 File Offset: 0x000183C4
			[DebuggerNonUserCode]
			public dsKetQuaSA.SAKHACRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170002B1 RID: 689
			// (get) Token: 0x0600070E RID: 1806 RVA: 0x000193DC File Offset: 0x000183DC
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000133 RID: 307
			private dsKetQuaSA.SAKHACRow eventRow;

			// Token: 0x04000134 RID: 308
			private DataRowAction eventAction;
		}

		// Token: 0x0200004D RID: 77
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SASKRowChangeEvent : EventArgs
		{
			// Token: 0x0600070F RID: 1807 RVA: 0x000193F4 File Offset: 0x000183F4
			[DebuggerNonUserCode]
			public SASKRowChangeEvent(dsKetQuaSA.SASKRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170002B2 RID: 690
			// (get) Token: 0x06000710 RID: 1808 RVA: 0x00019410 File Offset: 0x00018410
			[DebuggerNonUserCode]
			public dsKetQuaSA.SASKRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170002B3 RID: 691
			// (get) Token: 0x06000711 RID: 1809 RVA: 0x00019428 File Offset: 0x00018428
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000135 RID: 309
			private dsKetQuaSA.SASKRow eventRow;

			// Token: 0x04000136 RID: 310
			private DataRowAction eventAction;
		}

		// Token: 0x0200004E RID: 78
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SATGRowChangeEvent : EventArgs
		{
			// Token: 0x06000712 RID: 1810 RVA: 0x00019440 File Offset: 0x00018440
			[DebuggerNonUserCode]
			public SATGRowChangeEvent(dsKetQuaSA.SATGRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170002B4 RID: 692
			// (get) Token: 0x06000713 RID: 1811 RVA: 0x0001945C File Offset: 0x0001845C
			[DebuggerNonUserCode]
			public dsKetQuaSA.SATGRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170002B5 RID: 693
			// (get) Token: 0x06000714 RID: 1812 RVA: 0x00019474 File Offset: 0x00018474
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000137 RID: 311
			private dsKetQuaSA.SATGRow eventRow;

			// Token: 0x04000138 RID: 312
			private DataRowAction eventAction;
		}

		// Token: 0x0200004F RID: 79
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SATVRowChangeEvent : EventArgs
		{
			// Token: 0x06000715 RID: 1813 RVA: 0x0001948C File Offset: 0x0001848C
			[DebuggerNonUserCode]
			public SATVRowChangeEvent(dsKetQuaSA.SATVRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x06000716 RID: 1814 RVA: 0x000194A8 File Offset: 0x000184A8
			[DebuggerNonUserCode]
			public dsKetQuaSA.SATVRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170002B7 RID: 695
			// (get) Token: 0x06000717 RID: 1815 RVA: 0x000194C0 File Offset: 0x000184C0
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000139 RID: 313
			private dsKetQuaSA.SATVRow eventRow;

			// Token: 0x0400013A RID: 314
			private DataRowAction eventAction;
		}

		// Token: 0x02000050 RID: 80
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SATQRowChangeEvent : EventArgs
		{
			// Token: 0x06000718 RID: 1816 RVA: 0x000194D8 File Offset: 0x000184D8
			[DebuggerNonUserCode]
			public SATQRowChangeEvent(dsKetQuaSA.SATQRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170002B8 RID: 696
			// (get) Token: 0x06000719 RID: 1817 RVA: 0x000194F4 File Offset: 0x000184F4
			[DebuggerNonUserCode]
			public dsKetQuaSA.SATQRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170002B9 RID: 697
			// (get) Token: 0x0600071A RID: 1818 RVA: 0x0001950C File Offset: 0x0001850C
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x0400013B RID: 315
			private dsKetQuaSA.SATQRow eventRow;

			// Token: 0x0400013C RID: 316
			private DataRowAction eventAction;
		}

		// Token: 0x02000051 RID: 81
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SATIMRowChangeEvent : EventArgs
		{
			// Token: 0x0600071B RID: 1819 RVA: 0x00019524 File Offset: 0x00018524
			[DebuggerNonUserCode]
			public SATIMRowChangeEvent(dsKetQuaSA.SATIMRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170002BA RID: 698
			// (get) Token: 0x0600071C RID: 1820 RVA: 0x00019540 File Offset: 0x00018540
			[DebuggerNonUserCode]
			public dsKetQuaSA.SATIMRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x0600071D RID: 1821 RVA: 0x00019558 File Offset: 0x00018558
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x0400013D RID: 317
			private dsKetQuaSA.SATIMRow eventRow;

			// Token: 0x0400013E RID: 318
			private DataRowAction eventAction;
		}

		// Token: 0x02000052 RID: 82
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class ImagesRowChangeEvent : EventArgs
		{
			// Token: 0x0600071E RID: 1822 RVA: 0x00019570 File Offset: 0x00018570
			[DebuggerNonUserCode]
			public ImagesRowChangeEvent(dsKetQuaSA.ImagesRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170002BC RID: 700
			// (get) Token: 0x0600071F RID: 1823 RVA: 0x0001958C File Offset: 0x0001858C
			[DebuggerNonUserCode]
			public dsKetQuaSA.ImagesRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170002BD RID: 701
			// (get) Token: 0x06000720 RID: 1824 RVA: 0x000195A4 File Offset: 0x000185A4
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x0400013F RID: 319
			private dsKetQuaSA.ImagesRow eventRow;

			// Token: 0x04000140 RID: 320
			private DataRowAction eventAction;
		}
	}
}
