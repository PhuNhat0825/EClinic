using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace DBInteraction
{
	// Token: 0x02000003 RID: 3
	public sealed class SqlHelper
	{
		// Token: 0x06000056 RID: 86 RVA: 0x000046C6 File Offset: 0x000036C6
		private SqlHelper()
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000046D4 File Offset: 0x000036D4
		private static void AttachParameters(SqlCommand command, SqlParameter[] commandParameters)
		{
			if (command == null)
			{
				throw new ArgumentNullException("command");
			}
			if (commandParameters != null)
			{
				foreach (SqlParameter sqlParameter in commandParameters)
				{
					if (sqlParameter != null)
					{
						if ((sqlParameter.Direction == ParameterDirection.InputOutput || sqlParameter.Direction == ParameterDirection.Input) && sqlParameter.Value == null)
						{
							sqlParameter.Value = DBNull.Value;
						}
						command.Parameters.Add(sqlParameter);
					}
				}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004768 File Offset: 0x00003768
		private static void AssignParameterValues(SqlParameter[] commandParameters, DataRow dataRow)
		{
			if (commandParameters != null && dataRow != null)
			{
				int num = 0;
				foreach (SqlParameter sqlParameter in commandParameters)
				{
					if (sqlParameter.ParameterName == null || sqlParameter.ParameterName.Length <= 1)
					{
						throw new Exception(string.Format("Please provide a valid parameter name on the parameter #{0}, the ParameterName property has the following value: '{1}'.", num, sqlParameter.ParameterName));
					}
					if (dataRow.Table.Columns.IndexOf(sqlParameter.ParameterName.Substring(1)) != -1)
					{
						sqlParameter.Value = dataRow[sqlParameter.ParameterName.Substring(1)];
					}
					num++;
				}
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004830 File Offset: 0x00003830
		private static void AssignParameterValues(SqlParameter[] commandParameters, object[] parameterValues)
		{
			if (commandParameters != null && parameterValues != null)
			{
				if (commandParameters.Length != parameterValues.Length)
				{
					throw new ArgumentException("Parameter count does not match Parameter Value count.");
				}
				int i = 0;
				int num = commandParameters.Length;
				while (i < num)
				{
					if (parameterValues[i] is IDbDataParameter)
					{
						IDbDataParameter dbDataParameter = (IDbDataParameter)parameterValues[i];
						if (dbDataParameter.Value == null)
						{
							commandParameters[i].Value = DBNull.Value;
						}
						else
						{
							commandParameters[i].Value = dbDataParameter.Value;
						}
					}
					else if (parameterValues[i] == null)
					{
						commandParameters[i].Value = DBNull.Value;
					}
					else
					{
						commandParameters[i].Value = parameterValues[i];
					}
					i++;
				}
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004908 File Offset: 0x00003908
		private static void PrepareCommand(SqlCommand command, SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, SqlParameter[] commandParameters, out bool mustCloseConnection)
		{
			if (command == null)
			{
				throw new ArgumentNullException("command");
			}
			if (commandText == null || commandText.Length == 0)
			{
				throw new ArgumentNullException("commandText");
			}
			if (connection.State != ConnectionState.Open)
			{
				mustCloseConnection = true;
				connection.Open();
			}
			else
			{
				mustCloseConnection = false;
			}
			command.Connection = connection;
			command.CommandText = commandText;
			if (transaction != null)
			{
				if (transaction.Connection == null)
				{
					throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
				}
				command.Transaction = transaction;
			}
			command.CommandType = commandType;
			if (commandParameters != null)
			{
				SqlHelper.AttachParameters(command, commandParameters);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000049D4 File Offset: 0x000039D4
		public static int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText)
		{
			return SqlHelper.ExecuteNonQuery(connectionString, commandType, commandText, null);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000049F0 File Offset: 0x000039F0
		public static int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			int result;
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				sqlConnection.Open();
				result = SqlHelper.ExecuteNonQuery(sqlConnection, commandType, commandText, commandParameters);
			}
			return result;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004A5C File Offset: 0x00003A5C
		public static int ExecuteNonQuery(string connectionString, string spName, params object[] parameterValues)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			int result;
			if (parameterValues != null && parameterValues.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
				SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
				result = SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004AEC File Offset: 0x00003AEC
		public static int ExecuteNonQuery(SqlConnection connection, CommandType commandType, string commandText)
		{
			return SqlHelper.ExecuteNonQuery(connection, commandType, commandText, null);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004B08 File Offset: 0x00003B08
		public static int ExecuteNonQuery(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			SqlCommand sqlCommand = new SqlCommand();
			bool flag = false;
			SqlHelper.PrepareCommand(sqlCommand, connection, null, commandType, commandText, commandParameters, out flag);
			int result = sqlCommand.ExecuteNonQuery();
			sqlCommand.Parameters.Clear();
			if (flag)
			{
				connection.Close();
			}
			return result;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004B70 File Offset: 0x00003B70
		public static int ExecuteNonQuery(SqlConnection connection, string spName, params object[] parameterValues)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			int result;
			if (parameterValues != null && parameterValues.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
				result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004BF4 File Offset: 0x00003BF4
		public static int ExecuteNonQuery(SqlTransaction transaction, CommandType commandType, string commandText)
		{
			return SqlHelper.ExecuteNonQuery(transaction, commandType, commandText, null);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004C10 File Offset: 0x00003C10
		public static int ExecuteNonQuery(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
		{
			if (transaction == null)
			{
				throw new ArgumentNullException("transaction");
			}
			if (transaction != null && transaction.Connection == null)
			{
				throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
			}
			SqlCommand sqlCommand = new SqlCommand();
			bool flag = false;
			SqlHelper.PrepareCommand(sqlCommand, transaction.Connection, transaction, commandType, commandText, commandParameters, out flag);
			int result = sqlCommand.ExecuteNonQuery();
			sqlCommand.Parameters.Clear();
			return result;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004C94 File Offset: 0x00003C94
		public static int ExecuteNonQuery(SqlTransaction transaction, string spName, params object[] parameterValues)
		{
			if (transaction == null)
			{
				throw new ArgumentNullException("transaction");
			}
			if (transaction != null && transaction.Connection == null)
			{
				throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			int result;
			if (parameterValues != null && parameterValues.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
				result = SqlHelper.ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004D44 File Offset: 0x00003D44
		public static DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText)
		{
			return SqlHelper.ExecuteDataset(connectionString, commandType, commandText, null);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00004D60 File Offset: 0x00003D60
		public static DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			DataSet result;
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				sqlConnection.Open();
				result = SqlHelper.ExecuteDataset(sqlConnection, commandType, commandText, commandParameters);
			}
			return result;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004DCC File Offset: 0x00003DCC
		public static DataSet ExecuteDataset(string connectionString, string spName, params object[] parameterValues)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			DataSet result;
			if (parameterValues != null && parameterValues.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
				SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
				result = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004E5C File Offset: 0x00003E5C
		public static DataSet ExecuteDataset(SqlConnection connection, CommandType commandType, string commandText)
		{
			return SqlHelper.ExecuteDataset(connection, commandType, commandText, null);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004E78 File Offset: 0x00003E78
		public static DataSet ExecuteDataset(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			SqlCommand sqlCommand = new SqlCommand();
			bool flag = false;
			SqlHelper.PrepareCommand(sqlCommand, connection, null, commandType, commandText, commandParameters, out flag);
			DataSet result;
			using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
			{
				DataSet dataSet = new DataSet();
				sqlDataAdapter.Fill(dataSet);
				sqlCommand.Parameters.Clear();
				if (flag)
				{
					connection.Close();
				}
				result = dataSet;
			}
			return result;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004F14 File Offset: 0x00003F14
		public static DataSet ExecuteDataset(SqlConnection connection, string spName, params object[] parameterValues)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			DataSet result;
			if (parameterValues != null && parameterValues.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
				result = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004F98 File Offset: 0x00003F98
		public static DataSet ExecuteDataset(SqlTransaction transaction, CommandType commandType, string commandText)
		{
			return SqlHelper.ExecuteDataset(transaction, commandType, commandText, null);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004FB4 File Offset: 0x00003FB4
		public static DataSet ExecuteDataset(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
		{
			if (transaction == null)
			{
				throw new ArgumentNullException("transaction");
			}
			if (transaction != null && transaction.Connection == null)
			{
				throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
			}
			SqlCommand sqlCommand = new SqlCommand();
			bool flag = false;
			SqlHelper.PrepareCommand(sqlCommand, transaction.Connection, transaction, commandType, commandText, commandParameters, out flag);
			DataSet result;
			using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
			{
				DataSet dataSet = new DataSet();
				sqlDataAdapter.Fill(dataSet);
				sqlCommand.Parameters.Clear();
				result = dataSet;
			}
			return result;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000506C File Offset: 0x0000406C
		public static DataSet ExecuteDataset(SqlTransaction transaction, string spName, params object[] parameterValues)
		{
			if (transaction == null)
			{
				throw new ArgumentNullException("transaction");
			}
			if (transaction != null && transaction.Connection == null)
			{
				throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			DataSet result;
			if (parameterValues != null && parameterValues.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
				result = SqlHelper.ExecuteDataset(transaction, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteDataset(transaction, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000511C File Offset: 0x0000411C
		private static SqlDataReader ExecuteReader(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, SqlParameter[] commandParameters, SqlHelper.SqlConnectionOwnership connectionOwnership)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			bool flag = false;
			SqlCommand sqlCommand = new SqlCommand();
			SqlDataReader result;
			try
			{
				SqlHelper.PrepareCommand(sqlCommand, connection, transaction, commandType, commandText, commandParameters, out flag);
				SqlDataReader sqlDataReader;
				if (connectionOwnership == SqlHelper.SqlConnectionOwnership.External)
				{
					sqlDataReader = sqlCommand.ExecuteReader();
				}
				else
				{
					sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
				}
				bool flag2 = true;
				foreach (object obj in sqlCommand.Parameters)
				{
					SqlParameter sqlParameter = (SqlParameter)obj;
					if (sqlParameter.Direction != ParameterDirection.Input)
					{
						flag2 = false;
					}
				}
				if (flag2)
				{
					sqlCommand.Parameters.Clear();
				}
				result = sqlDataReader;
			}
			catch
			{
				if (flag)
				{
					connection.Close();
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00005230 File Offset: 0x00004230
		public static SqlDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText)
		{
			return SqlHelper.ExecuteReader(connectionString, commandType, commandText, null);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000524C File Offset: 0x0000424C
		public static SqlDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			SqlConnection sqlConnection = null;
			SqlDataReader result;
			try
			{
				sqlConnection = new SqlConnection(connectionString);
				sqlConnection.Open();
				result = SqlHelper.ExecuteReader(sqlConnection, null, commandType, commandText, commandParameters, SqlHelper.SqlConnectionOwnership.Internal);
			}
			catch
			{
				if (sqlConnection != null)
				{
					sqlConnection.Close();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000052C0 File Offset: 0x000042C0
		public static SqlDataReader ExecuteReader(string connectionString, string spName, params object[] parameterValues)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			SqlDataReader result;
			if (parameterValues != null && parameterValues.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
				SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
				result = SqlHelper.ExecuteReader(connectionString, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteReader(connectionString, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00005350 File Offset: 0x00004350
		public static SqlDataReader ExecuteReader(SqlConnection connection, CommandType commandType, string commandText)
		{
			return SqlHelper.ExecuteReader(connection, commandType, commandText, null);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000536C File Offset: 0x0000436C
		public static SqlDataReader ExecuteReader(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
		{
			return SqlHelper.ExecuteReader(connection, null, commandType, commandText, commandParameters, SqlHelper.SqlConnectionOwnership.External);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000538C File Offset: 0x0000438C
		public static SqlDataReader ExecuteReader(SqlConnection connection, string spName, params object[] parameterValues)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			SqlDataReader result;
			if (parameterValues != null && parameterValues.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
				result = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00005410 File Offset: 0x00004410
		public static SqlDataReader ExecuteReader(SqlTransaction transaction, CommandType commandType, string commandText)
		{
			return SqlHelper.ExecuteReader(transaction, commandType, commandText, null);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000542C File Offset: 0x0000442C
		public static SqlDataReader ExecuteReader(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
		{
			if (transaction == null)
			{
				throw new ArgumentNullException("transaction");
			}
			if (transaction != null && transaction.Connection == null)
			{
				throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
			}
			return SqlHelper.ExecuteReader(transaction.Connection, transaction, commandType, commandText, commandParameters, SqlHelper.SqlConnectionOwnership.External);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000548C File Offset: 0x0000448C
		public static SqlDataReader ExecuteReader(SqlTransaction transaction, string spName, params object[] parameterValues)
		{
			if (transaction == null)
			{
				throw new ArgumentNullException("transaction");
			}
			if (transaction != null && transaction.Connection == null)
			{
				throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			SqlDataReader result;
			if (parameterValues != null && parameterValues.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
				result = SqlHelper.ExecuteReader(transaction, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteReader(transaction, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000553C File Offset: 0x0000453C
		public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText)
		{
			return SqlHelper.ExecuteScalar(connectionString, commandType, commandText, null);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005558 File Offset: 0x00004558
		public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			object result;
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				sqlConnection.Open();
				result = SqlHelper.ExecuteScalar(sqlConnection, commandType, commandText, commandParameters);
			}
			return result;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000055C4 File Offset: 0x000045C4
		public static object ExecuteScalar(string connectionString, string spName, params object[] parameterValues)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			object result;
			if (parameterValues != null && parameterValues.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
				SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
				result = SqlHelper.ExecuteScalar(connectionString, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteScalar(connectionString, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00005654 File Offset: 0x00004654
		public static object ExecuteScalar(SqlConnection connection, CommandType commandType, string commandText)
		{
			return SqlHelper.ExecuteScalar(connection, commandType, commandText, null);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00005670 File Offset: 0x00004670
		public static object ExecuteScalar(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			SqlCommand sqlCommand = new SqlCommand();
			bool flag = false;
			SqlHelper.PrepareCommand(sqlCommand, connection, null, commandType, commandText, commandParameters, out flag);
			object result = sqlCommand.ExecuteScalar();
			sqlCommand.Parameters.Clear();
			if (flag)
			{
				connection.Close();
			}
			return result;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000056D8 File Offset: 0x000046D8
		public static object ExecuteScalar(SqlConnection connection, string spName, params object[] parameterValues)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			object result;
			if (parameterValues != null && parameterValues.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
				result = SqlHelper.ExecuteScalar(connection, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteScalar(connection, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000575C File Offset: 0x0000475C
		public static object ExecuteScalar(SqlTransaction transaction, CommandType commandType, string commandText)
		{
			return SqlHelper.ExecuteScalar(transaction, commandType, commandText, null);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00005778 File Offset: 0x00004778
		public static object ExecuteScalar(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
		{
			if (transaction == null)
			{
				throw new ArgumentNullException("transaction");
			}
			if (transaction != null && transaction.Connection == null)
			{
				throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
			}
			SqlCommand sqlCommand = new SqlCommand();
			bool flag = false;
			SqlHelper.PrepareCommand(sqlCommand, transaction.Connection, transaction, commandType, commandText, commandParameters, out flag);
			object result = sqlCommand.ExecuteScalar();
			sqlCommand.Parameters.Clear();
			return result;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000057FC File Offset: 0x000047FC
		public static object ExecuteScalar(SqlTransaction transaction, string spName, params object[] parameterValues)
		{
			if (transaction == null)
			{
				throw new ArgumentNullException("transaction");
			}
			if (transaction != null && transaction.Connection == null)
			{
				throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			object result;
			if (parameterValues != null && parameterValues.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
				result = SqlHelper.ExecuteScalar(transaction, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteScalar(transaction, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000058AC File Offset: 0x000048AC
		public static XmlReader ExecuteXmlReader(SqlConnection connection, CommandType commandType, string commandText)
		{
			return SqlHelper.ExecuteXmlReader(connection, commandType, commandText, null);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000058C8 File Offset: 0x000048C8
		public static XmlReader ExecuteXmlReader(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			bool flag = false;
			SqlCommand sqlCommand = new SqlCommand();
			XmlReader result;
			try
			{
				SqlHelper.PrepareCommand(sqlCommand, connection, null, commandType, commandText, commandParameters, out flag);
				XmlReader xmlReader = sqlCommand.ExecuteXmlReader();
				sqlCommand.Parameters.Clear();
				result = xmlReader;
			}
			catch
			{
				if (flag)
				{
					connection.Close();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00005944 File Offset: 0x00004944
		public static XmlReader ExecuteXmlReader(SqlConnection connection, string spName, params object[] parameterValues)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			XmlReader result;
			if (parameterValues != null && parameterValues.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
				result = SqlHelper.ExecuteXmlReader(connection, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteXmlReader(connection, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000059C8 File Offset: 0x000049C8
		public static XmlReader ExecuteXmlReader(SqlTransaction transaction, CommandType commandType, string commandText)
		{
			return SqlHelper.ExecuteXmlReader(transaction, commandType, commandText, null);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000059E4 File Offset: 0x000049E4
		public static XmlReader ExecuteXmlReader(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
		{
			if (transaction == null)
			{
				throw new ArgumentNullException("transaction");
			}
			if (transaction != null && transaction.Connection == null)
			{
				throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
			}
			SqlCommand sqlCommand = new SqlCommand();
			bool flag = false;
			SqlHelper.PrepareCommand(sqlCommand, transaction.Connection, transaction, commandType, commandText, commandParameters, out flag);
			XmlReader result = sqlCommand.ExecuteXmlReader();
			sqlCommand.Parameters.Clear();
			return result;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00005A68 File Offset: 0x00004A68
		public static XmlReader ExecuteXmlReader(SqlTransaction transaction, string spName, params object[] parameterValues)
		{
			if (transaction == null)
			{
				throw new ArgumentNullException("transaction");
			}
			if (transaction != null && transaction.Connection == null)
			{
				throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			XmlReader result;
			if (parameterValues != null && parameterValues.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
				result = SqlHelper.ExecuteXmlReader(transaction, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteXmlReader(transaction, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00005B18 File Offset: 0x00004B18
		public static void FillDataset(string connectionString, CommandType commandType, string commandText, DataSet dataSet, string[] tableNames)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			if (dataSet == null)
			{
				throw new ArgumentNullException("dataSet");
			}
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				sqlConnection.Open();
				SqlHelper.FillDataset(sqlConnection, commandType, commandText, dataSet, tableNames);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00005B9C File Offset: 0x00004B9C
		public static void FillDataset(string connectionString, CommandType commandType, string commandText, DataSet dataSet, string[] tableNames, params SqlParameter[] commandParameters)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			if (dataSet == null)
			{
				throw new ArgumentNullException("dataSet");
			}
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				sqlConnection.Open();
				SqlHelper.FillDataset(sqlConnection, commandType, commandText, dataSet, tableNames, commandParameters);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00005C24 File Offset: 0x00004C24
		public static void FillDataset(string connectionString, string spName, DataSet dataSet, string[] tableNames, params object[] parameterValues)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			if (dataSet == null)
			{
				throw new ArgumentNullException("dataSet");
			}
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				sqlConnection.Open();
				SqlHelper.FillDataset(sqlConnection, spName, dataSet, tableNames, parameterValues);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00005CA8 File Offset: 0x00004CA8
		public static void FillDataset(SqlConnection connection, CommandType commandType, string commandText, DataSet dataSet, string[] tableNames)
		{
			SqlHelper.FillDataset(connection, commandType, commandText, dataSet, tableNames, null);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00005CB8 File Offset: 0x00004CB8
		public static void FillDataset(SqlConnection connection, CommandType commandType, string commandText, DataSet dataSet, string[] tableNames, params SqlParameter[] commandParameters)
		{
			SqlHelper.FillDataset(connection, null, commandType, commandText, dataSet, tableNames, commandParameters);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00005CCC File Offset: 0x00004CCC
		public static void FillDataset(SqlConnection connection, string spName, DataSet dataSet, string[] tableNames, params object[] parameterValues)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			if (dataSet == null)
			{
				throw new ArgumentNullException("dataSet");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			if (parameterValues != null && parameterValues.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
				SqlHelper.FillDataset(connection, CommandType.StoredProcedure, spName, dataSet, tableNames, spParameterSet);
			}
			else
			{
				SqlHelper.FillDataset(connection, CommandType.StoredProcedure, spName, dataSet, tableNames);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00005D6A File Offset: 0x00004D6A
		public static void FillDataset(SqlTransaction transaction, CommandType commandType, string commandText, DataSet dataSet, string[] tableNames)
		{
			SqlHelper.FillDataset(transaction, commandType, commandText, dataSet, tableNames, null);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00005D7A File Offset: 0x00004D7A
		public static void FillDataset(SqlTransaction transaction, CommandType commandType, string commandText, DataSet dataSet, string[] tableNames, params SqlParameter[] commandParameters)
		{
			SqlHelper.FillDataset(transaction.Connection, transaction, commandType, commandText, dataSet, tableNames, commandParameters);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00005D94 File Offset: 0x00004D94
		public static void FillDataset(SqlTransaction transaction, string spName, DataSet dataSet, string[] tableNames, params object[] parameterValues)
		{
			if (transaction == null)
			{
				throw new ArgumentNullException("transaction");
			}
			if (transaction != null && transaction.Connection == null)
			{
				throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
			}
			if (dataSet == null)
			{
				throw new ArgumentNullException("dataSet");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			if (parameterValues != null && parameterValues.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
				SqlHelper.FillDataset(transaction, CommandType.StoredProcedure, spName, dataSet, tableNames, spParameterSet);
			}
			else
			{
				SqlHelper.FillDataset(transaction, CommandType.StoredProcedure, spName, dataSet, tableNames);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00005E60 File Offset: 0x00004E60
		private static void FillDataset(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, DataSet dataSet, string[] tableNames, params SqlParameter[] commandParameters)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			if (dataSet == null)
			{
				throw new ArgumentNullException("dataSet");
			}
			SqlCommand sqlCommand = new SqlCommand();
			bool flag = false;
			SqlHelper.PrepareCommand(sqlCommand, connection, transaction, commandType, commandText, commandParameters, out flag);
			using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
			{
				if (tableNames != null && tableNames.Length > 0)
				{
					string text = "Table";
					for (int i = 0; i < tableNames.Length; i++)
					{
						if (tableNames[i] == null || tableNames[i].Length == 0)
						{
							throw new ArgumentException("The tableNames parameter must contain a list of tables, a value was provided as null or empty string.", "tableNames");
						}
						sqlDataAdapter.TableMappings.Add(text, tableNames[i]);
						text += (i + 1).ToString();
					}
				}
				sqlDataAdapter.Fill(dataSet);
				sqlCommand.Parameters.Clear();
			}
			if (flag)
			{
				connection.Close();
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005F9C File Offset: 0x00004F9C
		public static void UpdateDataset(SqlCommand insertCommand, SqlCommand deleteCommand, SqlCommand updateCommand, DataSet dataSet, string tableName)
		{
			if (insertCommand == null)
			{
				throw new ArgumentNullException("insertCommand");
			}
			if (deleteCommand == null)
			{
				throw new ArgumentNullException("deleteCommand");
			}
			if (updateCommand == null)
			{
				throw new ArgumentNullException("updateCommand");
			}
			if (tableName == null || tableName.Length == 0)
			{
				throw new ArgumentNullException("tableName");
			}
			using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
			{
				sqlDataAdapter.UpdateCommand = updateCommand;
				sqlDataAdapter.InsertCommand = insertCommand;
				sqlDataAdapter.DeleteCommand = deleteCommand;
				sqlDataAdapter.Update(dataSet, tableName);
				dataSet.Tables[tableName].AcceptChanges();
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00006070 File Offset: 0x00005070
		public static SqlCommand CreateCommand(SqlConnection connection, string spName, params string[] sourceColumns)
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
			if (sourceColumns != null && sourceColumns.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
				for (int i = 0; i < sourceColumns.Length; i++)
				{
					spParameterSet[i].SourceColumn = sourceColumns[i];
				}
				SqlHelper.AttachParameters(sqlCommand, spParameterSet);
			}
			return sqlCommand;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00006118 File Offset: 0x00005118
		public static int ExecuteNonQueryTypedParams(string connectionString, string spName, DataRow dataRow)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			int result;
			if (dataRow != null && dataRow.ItemArray.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
				SqlHelper.AssignParameterValues(spParameterSet, dataRow);
				result = SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000061AC File Offset: 0x000051AC
		public static int ExecuteNonQueryTypedParams(SqlConnection connection, string spName, DataRow dataRow)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			int result;
			if (dataRow != null && dataRow.ItemArray.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, dataRow);
				result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00006234 File Offset: 0x00005234
		public static int ExecuteNonQueryTypedParams(SqlTransaction transaction, string spName, DataRow dataRow)
		{
			if (transaction == null)
			{
				throw new ArgumentNullException("transaction");
			}
			if (transaction != null && transaction.Connection == null)
			{
				throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			int result;
			if (dataRow != null && dataRow.ItemArray.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, dataRow);
				result = SqlHelper.ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000062E8 File Offset: 0x000052E8
		public static DataSet ExecuteDatasetTypedParams(string connectionString, string spName, DataRow dataRow)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			DataSet result;
			if (dataRow != null && dataRow.ItemArray.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
				SqlHelper.AssignParameterValues(spParameterSet, dataRow);
				result = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000637C File Offset: 0x0000537C
		public static DataSet ExecuteDatasetTypedParams(SqlConnection connection, string spName, DataRow dataRow)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			DataSet result;
			if (dataRow != null && dataRow.ItemArray.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, dataRow);
				result = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00006404 File Offset: 0x00005404
		public static DataSet ExecuteDatasetTypedParams(SqlTransaction transaction, string spName, DataRow dataRow)
		{
			if (transaction == null)
			{
				throw new ArgumentNullException("transaction");
			}
			if (transaction != null && transaction.Connection == null)
			{
				throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			DataSet result;
			if (dataRow != null && dataRow.ItemArray.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, dataRow);
				result = SqlHelper.ExecuteDataset(transaction, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteDataset(transaction, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000064B8 File Offset: 0x000054B8
		public static SqlDataReader ExecuteReaderTypedParams(string connectionString, string spName, DataRow dataRow)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			SqlDataReader result;
			if (dataRow != null && dataRow.ItemArray.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
				SqlHelper.AssignParameterValues(spParameterSet, dataRow);
				result = SqlHelper.ExecuteReader(connectionString, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteReader(connectionString, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000654C File Offset: 0x0000554C
		public static SqlDataReader ExecuteReaderTypedParams(SqlConnection connection, string spName, DataRow dataRow)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			SqlDataReader result;
			if (dataRow != null && dataRow.ItemArray.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, dataRow);
				result = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000065D4 File Offset: 0x000055D4
		public static SqlDataReader ExecuteReaderTypedParams(SqlTransaction transaction, string spName, DataRow dataRow)
		{
			if (transaction == null)
			{
				throw new ArgumentNullException("transaction");
			}
			if (transaction != null && transaction.Connection == null)
			{
				throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			SqlDataReader result;
			if (dataRow != null && dataRow.ItemArray.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, dataRow);
				result = SqlHelper.ExecuteReader(transaction, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteReader(transaction, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00006688 File Offset: 0x00005688
		public static object ExecuteScalarTypedParams(string connectionString, string spName, DataRow dataRow)
		{
			if (connectionString == null || connectionString.Length == 0)
			{
				throw new ArgumentNullException("connectionString");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			object result;
			if (dataRow != null && dataRow.ItemArray.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
				SqlHelper.AssignParameterValues(spParameterSet, dataRow);
				result = SqlHelper.ExecuteScalar(connectionString, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteScalar(connectionString, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000671C File Offset: 0x0000571C
		public static object ExecuteScalarTypedParams(SqlConnection connection, string spName, DataRow dataRow)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			object result;
			if (dataRow != null && dataRow.ItemArray.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, dataRow);
				result = SqlHelper.ExecuteScalar(connection, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteScalar(connection, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000067A4 File Offset: 0x000057A4
		public static object ExecuteScalarTypedParams(SqlTransaction transaction, string spName, DataRow dataRow)
		{
			if (transaction == null)
			{
				throw new ArgumentNullException("transaction");
			}
			if (transaction != null && transaction.Connection == null)
			{
				throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			object result;
			if (dataRow != null && dataRow.ItemArray.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, dataRow);
				result = SqlHelper.ExecuteScalar(transaction, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteScalar(transaction, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00006858 File Offset: 0x00005858
		public static XmlReader ExecuteXmlReaderTypedParams(SqlConnection connection, string spName, DataRow dataRow)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			XmlReader result;
			if (dataRow != null && dataRow.ItemArray.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, dataRow);
				result = SqlHelper.ExecuteXmlReader(connection, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteXmlReader(connection, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000068E0 File Offset: 0x000058E0
		public static XmlReader ExecuteXmlReaderTypedParams(SqlTransaction transaction, string spName, DataRow dataRow)
		{
			if (transaction == null)
			{
				throw new ArgumentNullException("transaction");
			}
			if (transaction != null && transaction.Connection == null)
			{
				throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
			}
			if (spName == null || spName.Length == 0)
			{
				throw new ArgumentNullException("spName");
			}
			XmlReader result;
			if (dataRow != null && dataRow.ItemArray.Length > 0)
			{
				SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
				SqlHelper.AssignParameterValues(spParameterSet, dataRow);
				result = SqlHelper.ExecuteXmlReader(transaction, CommandType.StoredProcedure, spName, spParameterSet);
			}
			else
			{
				result = SqlHelper.ExecuteXmlReader(transaction, CommandType.StoredProcedure, spName);
			}
			return result;
		}

		// Token: 0x02000004 RID: 4
		private enum SqlConnectionOwnership
		{
			// Token: 0x04000006 RID: 6
			Internal,
			// Token: 0x04000007 RID: 7
			External
		}
	}
}
