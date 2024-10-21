using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace DBInteraction
{
	// Token: 0x02000008 RID: 8
	public class ParamCollection
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00006D95 File Offset: 0x00005D95
		public ParamCollection()
		{
			this.paraColection = new List<MySqlParameter>();
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00006DAC File Offset: 0x00005DAC
		public List<MySqlParameter> Collection
		{
			get
			{
				return this.paraColection;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00006DC4 File Offset: 0x00005DC4
		public int Count
		{
			get
			{
				return this.paraColection.Count;
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00006DE1 File Offset: 0x00005DE1
		public void Clear()
		{
			this.paraColection.Clear();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00006DF0 File Offset: 0x00005DF0
		public void Remove(object value)
		{
			this.paraColection.Remove((MySqlParameter)value);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00006E00 File Offset: 0x00005E00
		public void RemoveAt(int index)
		{
			this.paraColection.RemoveAt(index);
		}

		// Token: 0x17000005 RID: 5
		public MySqlParameter this[int index]
		{
			get
			{
				MySqlParameter result;
				if (index < 0 || index >= this.Count)
				{
					result = null;
				}
				else
				{
					result = this.paraColection[index];
				}
				return result;
			}
			set
			{
				if (index >= 0 && index < this.Count)
				{
					this.paraColection[index] = value;
				}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00006E8C File Offset: 0x00005E8C
		public void Add(string paraName, DbDataType dataType, int nDataSize, object values)
		{
			MySqlParameter mySqlParameter = new MySqlParameter("?" + paraName, this.GetMySQLDbType(dataType), nDataSize);
			mySqlParameter.Value = values;
			this.paraColection.Add(mySqlParameter);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00006ECC File Offset: 0x00005ECC
		public void Add(string paraName, DbDataType dataType, int nDataSize, object values, ParameterDirection direction)
		{
			MySqlParameter mySqlParameter = new MySqlParameter("?" + paraName, this.GetMySQLDbType(dataType), nDataSize);
			mySqlParameter.Value = values;
			mySqlParameter.Direction = direction;
			this.paraColection.Add(mySqlParameter);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00006F14 File Offset: 0x00005F14
		public DbDataType GetDbDataType(string sType)
		{
			sType = sType.ToLower();
			DbDataType result;
			if (sType == DbDataType.Bit.ToString().ToLower())
			{
				result = DbDataType.Bit;
			}
			else if (sType == DbDataType.Blob.ToString().ToLower())
			{
				result = DbDataType.Blob;
			}
			else if (sType == DbDataType.Byte.ToString().ToLower())
			{
				result = DbDataType.Byte;
			}
			else if (sType == DbDataType.Date.ToString().ToLower())
			{
				result = DbDataType.Date;
			}
			else if (sType == DbDataType.DateTime.ToString().ToLower())
			{
				result = DbDataType.DateTime;
			}
			else if (sType == DbDataType.Decimal.ToString().ToLower())
			{
				result = DbDataType.Decimal;
			}
			else if (sType == DbDataType.Double.ToString().ToLower())
			{
				result = DbDataType.Double;
			}
			else if (sType == DbDataType.Enum.ToString().ToLower())
			{
				result = DbDataType.Enum;
			}
			else if (sType == DbDataType.Float.ToString().ToLower())
			{
				result = DbDataType.Float;
			}
			else if (sType == DbDataType.Int16.ToString().ToLower())
			{
				result = DbDataType.Int16;
			}
			else if (sType == DbDataType.Int32.ToString().ToLower() || sType == "int")
			{
				result = DbDataType.Int32;
			}
			else if (sType == DbDataType.Int64.ToString().ToLower())
			{
				result = DbDataType.Int64;
			}
			else if (sType == DbDataType.LongBlob.ToString().ToLower())
			{
				result = DbDataType.LongBlob;
			}
			else if (sType == DbDataType.MediumBlob.ToString().ToLower())
			{
				result = DbDataType.MediumBlob;
			}
			else if (sType == DbDataType.String.ToString().ToLower())
			{
				result = DbDataType.String;
			}
			else if (sType == DbDataType.Time.ToString().ToLower())
			{
				result = DbDataType.Time;
			}
			else if (sType == DbDataType.Timestamp.ToString().ToLower())
			{
				result = DbDataType.Timestamp;
			}
			else if (sType == DbDataType.TinyBlob.ToString().ToLower())
			{
				result = DbDataType.TinyBlob;
			}
			else if (sType == DbDataType.UByte.ToString().ToLower())
			{
				result = DbDataType.UByte;
			}
			else if (sType == DbDataType.UByte16.ToString().ToLower())
			{
				result = DbDataType.UByte16;
			}
			else if (sType == DbDataType.UByte32.ToString().ToLower())
			{
				result = DbDataType.UByte32;
			}
			else if (sType == DbDataType.UByte64.ToString().ToLower())
			{
				result = DbDataType.UByte64;
			}
			else if (sType == "char")
			{
				result = DbDataType.VarChar;
			}
			else if (sType == "varchar")
			{
				result = DbDataType.VarString;
			}
			else if (sType == DbDataType.Year.ToString().ToLower())
			{
				result = DbDataType.Year;
			}
			else
			{
				result = DbDataType.String;
			}
			return result;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000072C0 File Offset: 0x000062C0
		private MySqlDbType GetMySQLDbType(DbDataType dataType)
		{
			switch (dataType)
			{
			case DbDataType.Bit:
				return MySqlDbType.Bit;
			case DbDataType.Blob:
				return MySqlDbType.Blob;
			case DbDataType.Byte:
				return MySqlDbType.Byte;
			case DbDataType.Date:
				return MySqlDbType.Date;
			case DbDataType.DateTime:
				return MySqlDbType.Datetime;
			case DbDataType.Decimal:
				return MySqlDbType.Decimal;
			case DbDataType.Double:
				return MySqlDbType.Double;
			case DbDataType.Enum:
				return MySqlDbType.Enum;
			case DbDataType.Float:
				return MySqlDbType.Float;
			case DbDataType.Int16:
				return MySqlDbType.Int16;
			case DbDataType.Int32:
				return MySqlDbType.Int32;
			case DbDataType.Int64:
				return MySqlDbType.Int64;
			case DbDataType.LongBlob:
				return MySqlDbType.LongBlob;
			case DbDataType.MediumBlob:
				return MySqlDbType.MediumBlob;
			case DbDataType.String:
				return MySqlDbType.String;
			case DbDataType.Time:
				return MySqlDbType.Time;
			case DbDataType.Timestamp:
				return MySqlDbType.Timestamp;
			case DbDataType.TinyBlob:
				return MySqlDbType.TinyBlob;
			case DbDataType.UByte:
				return MySqlDbType.UByte;
			case DbDataType.UByte16:
				return MySqlDbType.UInt16;
			case DbDataType.UByte32:
				return MySqlDbType.UInt32;
			case DbDataType.UByte64:
				return MySqlDbType.UInt64;
			case DbDataType.VarChar:
				return MySqlDbType.VarChar;
			case DbDataType.VarString:
				return MySqlDbType.VarString;
			case DbDataType.Year:
				return MySqlDbType.Year;
			}
			return MySqlDbType.String;
		}

		// Token: 0x04000027 RID: 39
		private List<MySqlParameter> paraColection;
	}
}
