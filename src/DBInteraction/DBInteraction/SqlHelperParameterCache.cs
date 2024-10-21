using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace DBInteraction
{
	// Token: 0x02000005 RID: 5
	public sealed class SqlHelperParameterCache
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x00006992 File Offset: 0x00005992
		private SqlHelperParameterCache()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000069A0 File Offset: 0x000059A0
		private static SqlParameter[] DiscoverSpParameterSet(SqlConnection connection, string spName, bool includeReturnValueParameter)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			SqlCommand sqlCommand = new SqlCommand(spName, connection);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			connection.Open();
			SqlCommandBuilder.DeriveParameters(sqlCommand);
			connection.Close();
			if (!includeReturnValueParameter)
			{
				sqlCommand.Parameters.RemoveAt(0);
			}
			SqlParameter[] array = new SqlParameter[sqlCommand.Parameters.Count];
			sqlCommand.Parameters.CopyTo(array, 0);
			foreach (SqlParameter sqlParameter in array)
			{
				sqlParameter.Value = DBNull.Value;
			}
			return array;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00006A7C File Offset: 0x00005A7C
		private static SqlParameter[] CloneParameters(SqlParameter[] originalParameters)
		{
			SqlParameter[] array = new SqlParameter[originalParameters.Length];
			int i = 0;
			int num = originalParameters.Length;
			while (i < num)
			{
				array[i] = (SqlParameter)((ICloneable)originalParameters[i]).Clone();
				i++;
			}
			return array;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00006AC0 File Offset: 0x00005AC0
		public static void CacheParameterSet(string connectionString, string commandText, params SqlParameter[] commandParameters)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			if (commandText == null || commandText.Length == 0)
			{
				throw new ArgumentNullException("commandText");
			}
			string key = connectionString + ":" + commandText;
			SqlHelperParameterCache.paramCache[key] = commandParameters;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00006B2C File Offset: 0x00005B2C
		public static SqlParameter[] GetCachedParameterSet(string connectionString, string commandText)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			if (commandText == null || commandText.Length == 0)
			{
				throw new ArgumentNullException("commandText");
			}
			string key = connectionString + ":" + commandText;
			SqlParameter[] array = SqlHelperParameterCache.paramCache[key] as SqlParameter[];
			SqlParameter[] result;
			if (array == null)
			{
				result = null;
			}
			else
			{
				result = SqlHelperParameterCache.CloneParameters(array);
			}
			return result;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00006BB8 File Offset: 0x00005BB8
		public static SqlParameter[] GetSpParameterSet(string connectionString, string spName)
		{
			return SqlHelperParameterCache.GetSpParameterSet(connectionString, spName, false);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00006BD4 File Offset: 0x00005BD4
		public static SqlParameter[] GetSpParameterSet(string connectionString, string spName, bool includeReturnValueParameter)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			SqlParameter[] spParameterSetInternal;
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				spParameterSetInternal = SqlHelperParameterCache.GetSpParameterSetInternal(sqlConnection, spName, includeReturnValueParameter);
			}
			return spParameterSetInternal;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00006C5C File Offset: 0x00005C5C
		internal static SqlParameter[] GetSpParameterSet(SqlConnection connection, string spName)
		{
			return SqlHelperParameterCache.GetSpParameterSet(connection, spName, false);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00006C78 File Offset: 0x00005C78
		internal static SqlParameter[] GetSpParameterSet(SqlConnection connection, string spName, bool includeReturnValueParameter)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			SqlParameter[] spParameterSetInternal;
			using (SqlConnection sqlConnection = (SqlConnection)((ICloneable)connection).Clone())
			{
				spParameterSetInternal = SqlHelperParameterCache.GetSpParameterSetInternal(sqlConnection, spName, includeReturnValueParameter);
			}
			return spParameterSetInternal;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00006CD8 File Offset: 0x00005CD8
		private static SqlParameter[] GetSpParameterSetInternal(SqlConnection connection, string spName, bool includeReturnValueParameter)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			string key = connection.ConnectionString + ":" + spName + (includeReturnValueParameter ? ":include ReturnValue Parameter" : "");
			SqlParameter[] array = SqlHelperParameterCache.paramCache[key] as SqlParameter[];
			if (array == null)
			{
				SqlParameter[] array2 = SqlHelperParameterCache.DiscoverSpParameterSet(connection, spName, includeReturnValueParameter);
				SqlHelperParameterCache.paramCache[key] = array2;
				array = array2;
			}
			return SqlHelperParameterCache.CloneParameters(array);
		}

		// Token: 0x04000008 RID: 8
		private static Hashtable paramCache = Hashtable.Synchronized(new Hashtable());
	}
}
