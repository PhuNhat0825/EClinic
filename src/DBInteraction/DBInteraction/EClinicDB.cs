using CryptoDBSystem;
using DBInteraction;
using MySql.Data.MySqlClient;
using SKCDExtCtrl;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Utility;
using VersionControl;

// Token: 0x02000002 RID: 2
public static class EClinicDB
{
    static EClinicDB()
    {
        EClinicDB.OpenConnection();
        if (EClinicDB.conn != null)
        {
            EClinicDB.cmd = new MySqlCommand(EClinicDB.ConnectionString, EClinicDB.conn)
            {
                CommandType = CommandType.Text
            };
        }
    }

    // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
    public static int ExecuteNonQuery(string sSQL, ArrayList arFieldNames, ArrayList arFieldValues)
    {
        string tableNamesFromSQLQuery = EClinicDB.GetTableNamesFromSQLQuery(sSQL);
        int result;
        if (tableNamesFromSQLQuery == "")
        {
            result = -1;
        }
        else
        {
            MySqlCommand mySQLCmd = EClinicDB.CreateMySqlCmdCrypto(sSQL, tableNamesFromSQLQuery, arFieldNames, arFieldValues);
            int num = EClinicDB.ExecuteCmd(mySQLCmd);
            result = num;
        }
        return result;
    }

    // Token: 0x06000002 RID: 2 RVA: 0x00002094 File Offset: 0x00001094
    public static int ExecuteNonQuery(string sSQL, string[] asFieldNames, string[] asFieldValues)
    {
        int result;
        if (asFieldNames.Length != asFieldValues.Length)
        {
            result = -1;
        }
        else
        {
            ArrayList arrayList = new ArrayList();
            ArrayList arrayList2 = new ArrayList();
            for (int i = 0; i < asFieldNames.Length; i++)
            {
                arrayList.Add(asFieldNames[i]);
                arrayList2.Add(asFieldValues[i]);
            }
            string tableNamesFromSQLQuery = EClinicDB.GetTableNamesFromSQLQuery(sSQL);
            if (tableNamesFromSQLQuery == "")
            {
                result = -1;
            }
            else
            {
                MySqlCommand mySQLCmd = EClinicDB.CreateMySqlCmdCrypto(sSQL, tableNamesFromSQLQuery, arrayList, arrayList2);
                int num = EClinicDB.ExecuteCmd(mySQLCmd);
                result = num;
            }
        }
        return result;
    }

    // Token: 0x06000003 RID: 3 RVA: 0x00002128 File Offset: 0x00001128
    public static DataSet DecryptDataset(DataSet ds, string sTableList)
    {
        DataSet result;
        if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
        {
            result = ds;
        }
        else
        {
            ArrayList ar = EClinicDB.EncryptFieldNames(sTableList);
            int count = ds.Tables[0].Columns.Count;
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < count; i++)
            {
                DataColumn dataColumn = ds.Tables[0].Columns[i];
                if (EClinicDB.IsInList(dataColumn.ColumnName, ar))
                {
                    arrayList.Add(i);
                    EClinicDB.CopyNewColToDataSetCrypto(ref ds, dataColumn);
                }
                else
                {
                    arrayList.Add(i);
                    EClinicDB.CopyNewColToDataSet(ref ds, dataColumn);
                }
            }
            arrayList.Reverse();
            while (arrayList.Count > 0)
            {
                ds.Tables[0].Columns.RemoveAt((int)arrayList[0]);
                arrayList.RemoveAt(0);
            }
            result = ds;
        }
        return result;
    }

    // Token: 0x06000004 RID: 4 RVA: 0x0000225C File Offset: 0x0000125C
    public static DataSet DecryptDataset(DataSet ds)
    {
        return EClinicDB.DecryptDataset(ds, ds.Tables[0].TableName);
    }

    // Token: 0x06000005 RID: 5 RVA: 0x00002288 File Offset: 0x00001288
    public static DataSet FillDataset(string sSQL, ArrayList arSelectFields, ArrayList arCondFields, ArrayList arCondValues)
    {
        string tableNamesFromSQLQuery = EClinicDB.GetTableNamesFromSQLQuery(sSQL);
        ArrayList arrayList = EClinicDB.EncryptFieldNames(tableNamesFromSQLQuery);
        MySqlCommand mySqlCommand = EClinicDB.CreateMySqlCmdCrypto(sSQL, arrayList, arCondFields, arCondValues);
        DataSet dataSet = EClinicDB.FillDataset(mySqlCommand);
        DataSet result;
        if (dataSet == null || dataSet.Tables.Count == 0)
        {
            result = dataSet;
        }
        else
        {
            int count = dataSet.Tables[0].Columns.Count;
            ArrayList arrayList2 = new ArrayList();
            for (int i = 0; i < count; i++)
            {
                DataColumn dataColumn = dataSet.Tables[0].Columns[i];
                if (EClinicDB.IsInList(dataColumn.ColumnName, arrayList))
                {
                    arrayList2.Add(i);
                    EClinicDB.CopyNewColToDataSetCrypto(ref dataSet, dataColumn);
                }
                else
                {
                    arrayList2.Add(i);
                    EClinicDB.CopyNewColToDataSet(ref dataSet, dataColumn);
                }
            }
            arrayList2.Reverse();
            while (arrayList2.Count > 0)
            {
                dataSet.Tables[0].Columns.RemoveAt((int)arrayList2[0]);
                arrayList2.RemoveAt(0);
            }
            result = dataSet;
        }
        return result;
    }

    // Token: 0x06000006 RID: 6 RVA: 0x000023CC File Offset: 0x000013CC
    public static DataSet FillDataset(string sTableList, MySqlCommand cmd)
    {
        ArrayList ar = EClinicDB.EncryptFieldNames(sTableList);
        DataSet dataSet = EClinicDB.FillDataset(cmd);
        DataSet result;
        if (dataSet == null || dataSet.Tables.Count == 0)
        {
            result = dataSet;
        }
        else
        {
            int count = dataSet.Tables[0].Columns.Count;
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < count; i++)
            {
                DataColumn dataColumn = dataSet.Tables[0].Columns[i];
                if (EClinicDB.IsInList(dataColumn.ColumnName, ar))
                {
                    arrayList.Add(i);
                    EClinicDB.CopyNewColToDataSetCrypto(ref dataSet, dataColumn);
                }
                else
                {
                    arrayList.Add(i);
                    EClinicDB.CopyNewColToDataSet(ref dataSet, dataColumn);
                }
            }
            arrayList.Reverse();
            while (arrayList.Count > 0)
            {
                dataSet.Tables[0].Columns.RemoveAt((int)arrayList[0]);
                arrayList.RemoveAt(0);
            }
            result = dataSet;
        }
        return result;
    }

    // Token: 0x06000007 RID: 7 RVA: 0x000024F4 File Offset: 0x000014F4
    public static DataSet FillDatasetDecrypt(string commandText)
    {
        return EClinicDB.FillDataset(commandText, null, null, null);
    }

    // Token: 0x06000008 RID: 8 RVA: 0x00002510 File Offset: 0x00001510
    public static DataSet FillDatasetDecrypt(MySqlCommand cmd, string sTableList)
    {
        ArrayList ar = EClinicDB.EncryptFieldNames(sTableList);
        DataSet dataSet = EClinicDB.FillDataset(cmd);
        DataSet result;
        if (dataSet == null || dataSet.Tables.Count == 0)
        {
            result = dataSet;
        }
        else
        {
            int count = dataSet.Tables[0].Columns.Count;
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < count; i++)
            {
                DataColumn dataColumn = dataSet.Tables[0].Columns[i];
                if (EClinicDB.IsInList(dataColumn.ColumnName, ar))
                {
                    arrayList.Add(i);
                    EClinicDB.CopyNewColToDataSetCrypto(ref dataSet, dataColumn);
                }
                else
                {
                    arrayList.Add(i);
                    EClinicDB.CopyNewColToDataSet(ref dataSet, dataColumn);
                }
            }
            arrayList.Reverse();
            while (arrayList.Count > 0)
            {
                dataSet.Tables[0].Columns.RemoveAt((int)arrayList[0]);
                arrayList.RemoveAt(0);
            }
            result = dataSet;
        }
        return result;
    }

    // Token: 0x06000009 RID: 9 RVA: 0x00002638 File Offset: 0x00001638
    public static DataSet FillDatasetDecrypt(string commandText, CommandType commandType, string sTableList)
    {
        return EClinicDB.FillDatasetDecrypt(new MySqlCommand(commandText, EClinicDB.EClinicDBConnection)
        {
            CommandType = commandType
        }, sTableList);
    }

    // Token: 0x0600000A RID: 10 RVA: 0x00002668 File Offset: 0x00001668
    public static DataSet FillDatasetDecrypt(string sStoreProcedueName, ParamCollection paraCollections, string sTableList)
    {
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(sStoreProcedueName, EClinicDB.conn);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                if (paraCollections != null)
                {
                    mySqlCommand.Parameters.Clear();
                    foreach (object obj in ((IEnumerable)paraCollections.Collection))
                    {
                        MySqlParameter value = (MySqlParameter)obj;
                        mySqlCommand.Parameters.Add(value);
                    }
                }
                return EClinicDB.FillDatasetDecrypt(mySqlCommand, sTableList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        return null;
    }

    // Token: 0x0600000B RID: 11 RVA: 0x00002788 File Offset: 0x00001788
    private static ArrayList EncryptFieldNames(string szTableNames)
    {
        string[] array = szTableNames.Split(new char[]
        {
            ','
        });
        string text = "";
        if (array.Length == 1)
        {
            text = "'" + EClinicDB.GetRealNameFromAlias(array[0]) + "'";
        }
        else
        {
            int i;
            for (i = 0; i < array.Length - 1; i++)
            {
                text = text + "'" + EClinicDB.GetRealNameFromAlias(array[i].Trim()) + "',";
            }
            text = text + "'" + EClinicDB.GetRealNameFromAlias(array[i].Trim()) + "'";
        }
        string text2 = "";
        text2 += " SELECT Field_Name ";
        text2 += " FROM crypto_db_fields AS cf, crypto_db_table AS ct";
        text2 = text2 + " WHERE (ct.Table_Name in (" + text + "))";
        text2 += " AND (cf.Crypto_Table_Id = ct.Crypto_Table_Id)";
        DataSet dataSet = EClinicDB.FillDataset(text2);
        ArrayList arrayList = new ArrayList();
        if (dataSet != null && dataSet.Tables.Count != 0)
        {
            foreach (object obj in dataSet.Tables[0].Rows)
            {
                DataRow dataRow = (DataRow)obj;
                arrayList.Add(dataRow[0].ToString().ToLower());
            }
        }
        return arrayList;
    }

    // Token: 0x0600000C RID: 12 RVA: 0x00002928 File Offset: 0x00001928
    private static string GetRealNameFromAlias(string sAlias)
    {
        string[] array = sAlias.Split(new char[]
        {
            ' '
        });
        string result;
        if (array.Length == 0)
        {
            result = sAlias.Trim();
        }
        else
        {
            result = array[0].Trim();
        }
        return result;
    }

    // Token: 0x0600000D RID: 13 RVA: 0x0000296C File Offset: 0x0000196C
    private static bool IsInList(object o, ArrayList ar)
    {
        o = ((string)o).ToLower();
        return ar.IndexOf(o) != -1;
    }

    // Token: 0x0600000E RID: 14 RVA: 0x000029A0 File Offset: 0x000019A0
    private static MySqlCommand CreateMySqlCmdCrypto(string sql, ArrayList arEncryptFields, ArrayList arFields, ArrayList arValues)
    {
        MySqlCommand mySqlCommand = EClinicDB.CreateMySqlCmd(sql);
        MySqlParameter param = new MySqlParameter();
        int num = (arValues == null) ? 0 : arValues.Count;
        if (arEncryptFields.Count == 0)
        {
            for (int i = 0; i < num; i++)
            {
                sql = sql.Replace("?" + i.ToString(), "'" + arValues[i].ToString() + "'");
            }
        }
        else
        {
            for (int i = 0; i < num; i++)
            {
                if (EClinicDB.IsInList(arFields[i], arEncryptFields))
                {
                    byte[] array = CryptoDB.Encryption(arValues[i].ToString());
                    string text = "?" + arFields[i];
                    EClinicDB.AddParamToMySqlCmd(mySqlCommand, param, text, MySqlDbType.Blob, array.Length, array);
                    sql = sql.Replace("?" + i.ToString(), text);
                }
                else
                {
                    sql = sql.Replace("?" + i.ToString(), "'" + arValues[i].ToString() + "'");
                }
            }
        }
        mySqlCommand.CommandText = sql;
        return mySqlCommand;
    }

    // Token: 0x0600000F RID: 15 RVA: 0x00002B00 File Offset: 0x00001B00
    private static MySqlCommand CreateMySqlCmdCrypto(string sql, string szTables, ArrayList arFields, ArrayList arValues)
    {
        ArrayList arEncryptFields = EClinicDB.EncryptFieldNames(szTables);
        return EClinicDB.CreateMySqlCmdCrypto(sql, arEncryptFields, arFields, arValues);
    }

    // Token: 0x06000010 RID: 16 RVA: 0x00002B24 File Offset: 0x00001B24
    private static void CopyNewColToDataSetCrypto(ref DataSet ds, DataColumn dcOld)
    {
        string columnName = dcOld.ColumnName;
        dcOld.ColumnName = columnName + "_";
        DataColumn column = new DataColumn(columnName, Type.GetType("System.String"));
        ds.Tables[0].Columns.Add(column);
        foreach (object obj in ds.Tables[0].Rows)
        {
            DataRow dataRow = (DataRow)obj;
            if (dataRow[dcOld].ToString() != "")
            {
                dataRow[column] = CryptoDB.Decryption((byte[])dataRow[dcOld]);
            }
        }
    }

    // Token: 0x06000011 RID: 17 RVA: 0x00002C14 File Offset: 0x00001C14
    private static void CopyNewColToDataSet(ref DataSet ds, DataColumn dcOld)
    {
        string columnName = dcOld.ColumnName;
        dcOld.ColumnName = columnName + "_";

        DataColumn column = new DataColumn(columnName, dcOld.DataType);
        ds.Tables[0].Columns.Add(column);
        foreach (object obj in ds.Tables[0].Rows)
        {
            DataRow dataRow = (DataRow)obj;

            if (dcOld.DataType.Name == "Byte[]")
            {
                dataRow[column] = dataRow[dcOld];
            }
            else
            if (dataRow[dcOld].ToString() != "")
            {
                dataRow[column] = dataRow[dcOld].ToString();
            }
        }
    }

    // Token: 0x06000012 RID: 18 RVA: 0x00002CFC File Offset: 0x00001CFC
    public static void LoadDatasetIntoComboBox(ref ComboBox comboBox, string stringDataGroup, string stringFormatDisplay, string stringFiltParam1, string stringFiltParam2, bool boolRequireInput)
    {
        ParamCollection paramCollection = new ParamCollection();
        paramCollection.Add("DataGroup", DbDataType.VarString, 50, stringDataGroup);
        paramCollection.Add("FiltParam1", DbDataType.VarString, 200, stringFiltParam1);
        paramCollection.Add("FiltParam2", DbDataType.VarString, 200, stringFiltParam2);
        DataSet dataSet = EClinicDB.FillDataset("sp_Sys_GetListComboData", CommandType.StoredProcedure, paramCollection);
        comboBox.DataSource = dataSet.Tables[0];
        comboBox.DisplayMember = "FieldName";
        comboBox.ValueMember = "FIeldCode";
        if (boolRequireInput)
        {
            comboBox.BackColor = Color.Khaki;
        }
    }

    // Token: 0x06000013 RID: 19 RVA: 0x00002D9D File Offset: 0x00001D9D
    public static void LoadDatasetIntoComboBox(ref ComboBox comboBox, string stringDataGroup, string stringFormatDisplay, string stringFiltParam1, string stringFiltParam2)
    {
        EClinicDB.LoadDatasetIntoComboBox(ref comboBox, stringDataGroup, stringFormatDisplay, stringFiltParam1, stringFiltParam2, false);
    }

    // Token: 0x06000014 RID: 20 RVA: 0x00002DAD File Offset: 0x00001DAD
    public static void LoadDatasetIntoComboBox(ref ComboBox comboBox, string stringDataGroup, string stringFormatDisplay, bool boolRequireInput)
    {
        EClinicDB.LoadDatasetIntoComboBox(ref comboBox, stringDataGroup, stringFormatDisplay, string.Empty, string.Empty, boolRequireInput);
    }

    // Token: 0x06000015 RID: 21 RVA: 0x00002DC4 File Offset: 0x00001DC4
    public static void LoadDatasetIntoComboBox(ref ComboBox comboBox, string stringDataGroup)
    {
        EClinicDB.LoadDatasetIntoComboBox(ref comboBox, stringDataGroup, string.Empty, string.Empty, string.Empty, false);
    }

    // Token: 0x06000016 RID: 22 RVA: 0x00002DDF File Offset: 0x00001DDF
    public static void LoadDatasetIntoComboBox(ref ComboBox comboBox, string stringDataGroup, string stringFormatDisplay)
    {
        EClinicDB.LoadDatasetIntoComboBox(ref comboBox, stringDataGroup, stringFormatDisplay, string.Empty, string.Empty, false);
    }

    // Token: 0x06000017 RID: 23 RVA: 0x00002DF8 File Offset: 0x00001DF8
    public static void LoadDatasetIntoDataGridView(ref DataGridView dataGridView, string stringDataGroup, string stringFormatDisplay, string stringFiltData)
    {
        ParamCollection paramCollection = new ParamCollection();
        paramCollection.Add("DataGroup", DbDataType.VarString, 50, stringDataGroup);
        paramCollection.Add("FiltData", DbDataType.VarString, 250, stringFiltData);
        DataSet dataSet = EClinicDB.FillDataset("sp_Sys_GetListDataGridView", CommandType.StoredProcedure, paramCollection);
        dataGridView.DataSource = dataSet;
        dataGridView.DataMember = dataSet.Tables[0].TableName;
    }

    // Token: 0x06000018 RID: 24 RVA: 0x00002E60 File Offset: 0x00001E60
    public static void LoadDatasetIntoDataGridView(ref DataGridView dataGridView, string stringDataGroup, string stringFormatDisplay)
    {
        EClinicDB.LoadDatasetIntoDataGridView(ref dataGridView, stringDataGroup, stringFormatDisplay, string.Empty);
    }

    // Token: 0x06000019 RID: 25 RVA: 0x00002E71 File Offset: 0x00001E71
    public static void LoadDatasetIntoDataGridView(ref DataGridView dataGridView, string stringDataGroup)
    {
        EClinicDB.LoadDatasetIntoDataGridView(ref dataGridView, stringDataGroup, string.Empty, string.Empty);
    }

    // Token: 0x0600001A RID: 26 RVA: 0x00002E88 File Offset: 0x00001E88
    public static void LoadDatasetIntoDataGridView(ref DataGridViewExt dataGridViewExt, string stringDataGroup, string stringFormatDisplay, string stringFiltData)
    {
        ParamCollection paramCollection = new ParamCollection();
        paramCollection.Add("DataGroup", DbDataType.VarString, 50, stringDataGroup);
        paramCollection.Add("FiltData", DbDataType.VarString, 250, stringFiltData);
        DataSet dataSet = EClinicDB.FillDataset("sp_Sys_GetListDataGridView", CommandType.StoredProcedure, paramCollection);
        dataGridViewExt.DataSource = dataSet;
        dataGridViewExt.DataMember = dataSet.Tables[0].TableName;
    }

    // Token: 0x0600001B RID: 27 RVA: 0x00002EF0 File Offset: 0x00001EF0
    public static void LoadDatasetIntoDataGridView(ref DataGridViewExt dataGridViewExt, string stringDataGroup, string stringFormatDisplay)
    {
        EClinicDB.LoadDatasetIntoDataGridView(ref dataGridViewExt, stringDataGroup, stringFormatDisplay, string.Empty);
    }

    // Token: 0x0600001C RID: 28 RVA: 0x00002F01 File Offset: 0x00001F01
    public static void LoadDatasetIntoDataGridView(ref DataGridViewExt dataGridViewExt, string stringDataGroup)
    {
        EClinicDB.LoadDatasetIntoDataGridView(ref dataGridViewExt, stringDataGroup, string.Empty, string.Empty);
    }

    // Token: 0x0600001D RID: 29 RVA: 0x00002F18 File Offset: 0x00001F18
    public static void LoadDatasetEncryptedIntoDataGridView(ref DataGridView dataGridView, string stringEncryptTableName, string stringDataGroup, string stringFormatDisplay, string stringFiltData)
    {
        ParamCollection paramCollection = new ParamCollection();
        paramCollection.Add("DataGroup", DbDataType.VarString, 50, stringDataGroup);
        paramCollection.Add("FiltData", DbDataType.VarString, 250, stringFiltData);
        DataSet dataSet = EClinicDB.FillDatasetDecrypt("sp_Sys_GetListDataGridView", paramCollection, stringEncryptTableName);
        dataGridView.DataSource = dataSet;
        dataGridView.DataMember = dataSet.Tables[0].TableName;
    }

    // Token: 0x0600001E RID: 30 RVA: 0x00002F81 File Offset: 0x00001F81
    public static void LoadDatasetEncryptedIntoDataGridView(ref DataGridView dataGridView, string stringEncryptTableName, string stringDataGroup, string stringFormatDisplay)
    {
        EClinicDB.LoadDatasetEncryptedIntoDataGridView(ref dataGridView, stringEncryptTableName, stringDataGroup, stringFormatDisplay, string.Empty);
    }

    // Token: 0x0600001F RID: 31 RVA: 0x00002F93 File Offset: 0x00001F93
    public static void LoadDatasetEncryptedIntoDataGridView(ref DataGridView dataGridView, string stringEncryptTableName, string stringDataGroup)
    {
        EClinicDB.LoadDatasetEncryptedIntoDataGridView(ref dataGridView, stringEncryptTableName, stringDataGroup, string.Empty, string.Empty);
    }

    // Token: 0x06000020 RID: 32 RVA: 0x00002FAC File Offset: 0x00001FAC
    public static void LoadDatasetEncryptedIntoDataGridView(ref DataGridViewExt dataGridViewExt, string stringEncryptTableName, string stringDataGroup, string stringFormatDisplay, string stringFiltData)
    {
        ParamCollection paramCollection = new ParamCollection();
        paramCollection.Add("DataGroup", DbDataType.VarString, 50, stringDataGroup);
        paramCollection.Add("FiltData", DbDataType.VarString, 250, stringFiltData);
        DataSet dataSet = EClinicDB.FillDatasetDecrypt("sp_Sys_GetListDataGridView", paramCollection, stringEncryptTableName);
        dataGridViewExt.DataSource = dataSet;
        dataGridViewExt.DataMember = dataSet.Tables[0].TableName;
    }

    // Token: 0x06000021 RID: 33 RVA: 0x00003015 File Offset: 0x00002015
    public static void LoadDatasetEncryptedIntoDataGridView(ref DataGridViewExt dataGridViewExt, string stringEncryptTableName, string stringDataGroup, string stringFormatDisplay)
    {
        EClinicDB.LoadDatasetEncryptedIntoDataGridView(ref dataGridViewExt, stringEncryptTableName, stringDataGroup, stringFormatDisplay, string.Empty);
    }

    // Token: 0x06000022 RID: 34 RVA: 0x00003027 File Offset: 0x00002027
    public static void LoadDatasetEncryptedIntoDataGridView(ref DataGridViewExt dataGridViewExt, string stringEncryptTableName, string stringDataGroup)
    {
        EClinicDB.LoadDatasetEncryptedIntoDataGridView(ref dataGridViewExt, stringEncryptTableName, stringDataGroup, string.Empty, string.Empty);
    }

    // Token: 0x06000023 RID: 35 RVA: 0x00003040 File Offset: 0x00002040
    public static void LoadDatasetIntoListBox(ref ListBox listBox, string stringDataGroup, string stringFormatDisplay, string stringFiltParam1, string stringFiltParam2, bool boolRequireInput)
    {
        ParamCollection paramCollection = new ParamCollection();
        paramCollection.Add("DataGroup", DbDataType.VarString, 50, stringDataGroup);
        paramCollection.Add("FiltParam1", DbDataType.VarString, 200, stringFiltParam1);
        paramCollection.Add("FiltParam2", DbDataType.VarString, 200, stringFiltParam2);
        DataSet dataSet = EClinicDB.FillDataset("sp_Sys_GetListComboData", CommandType.StoredProcedure, paramCollection);
        listBox.DataSource = dataSet.Tables[0];
        listBox.DisplayMember = "FieldName";
        if (boolRequireInput)
        {
            listBox.BackColor = Color.Khaki;
        }
    }

    // Token: 0x06000024 RID: 36 RVA: 0x000030D4 File Offset: 0x000020D4
    public static void LoadDatasetIntoListBox(ref ListBox listBox, string stringDataGroup, string stringFormatDisplay, string stringFiltParam1, string stringFiltParam2)
    {
        EClinicDB.LoadDatasetIntoListBox(ref listBox, stringDataGroup, stringFormatDisplay, stringFiltParam1, stringFiltParam2, false);
    }

    // Token: 0x06000025 RID: 37 RVA: 0x000030E4 File Offset: 0x000020E4
    public static void LoadDatasetIntoListBox(ref ListBox listBox, string stringDataGroup, string stringFormatDisplay, bool boolRequireInput)
    {
        EClinicDB.LoadDatasetIntoListBox(ref listBox, stringDataGroup, stringFormatDisplay, string.Empty, string.Empty, boolRequireInput);
    }

    // Token: 0x06000026 RID: 38 RVA: 0x000030FB File Offset: 0x000020FB
    public static void LoadDatasetIntoListBox(ref ListBox listBox, string stringDataGroup)
    {
        EClinicDB.LoadDatasetIntoListBox(ref listBox, stringDataGroup, string.Empty, string.Empty, string.Empty, false);
    }

    // Token: 0x06000027 RID: 39 RVA: 0x00003116 File Offset: 0x00002116
    public static void LoadDatasetIntoListBox(ref ListBox listBox, string stringDataGroup, string stringFormatDisplay)
    {
        EClinicDB.LoadDatasetIntoListBox(ref listBox, stringDataGroup, stringFormatDisplay, string.Empty, string.Empty, false);
    }

    // Token: 0x17000001 RID: 1
    // (get) Token: 0x06000029 RID: 41 RVA: 0x00003138 File Offset: 0x00002138
    // (set) Token: 0x06000028 RID: 40 RVA: 0x0000312D File Offset: 0x0000212D
    public static string ConnectionString
    {
        get
        {
            return EClinicDB._connectionString;
        }
        set
        {
            EClinicDB._connectionString = value;
        }
    }

    // Token: 0x0600002B RID: 43 RVA: 0x000031B0 File Offset: 0x000021B0
    public static bool Init()
    {
        return EClinicDB._finishedLoadDB;
    }

    // Token: 0x17000002 RID: 2
    // (get) Token: 0x0600002D RID: 45 RVA: 0x000031D0 File Offset: 0x000021D0
    // (set) Token: 0x0600002C RID: 44 RVA: 0x000031C7 File Offset: 0x000021C7
    public static MySqlConnection EClinicDBConnection
    {
        get
        {
            return EClinicDB.conn;
        }
        set
        {
            EClinicDB.conn = value;
        }
    }

    // Token: 0x0600002E RID: 46 RVA: 0x000031E7 File Offset: 0x000021E7
    public static void Dispose()
    {
        EClinicDB.CloseConnection();
    }

    // Token: 0x0600002F RID: 47 RVA: 0x000031F0 File Offset: 0x000021F0
    public static void OpenConnection()
    {
        if (CopyRight.RegisterMe())
        {
            if (EClinicDB.conn != null)
            {
                EClinicDB.conn.Close();
            }
            try
            {
                EClinicDB.conn = new MySqlConnection(EClinicDB.ConnectionString);
                EClinicDB.conn.Open();
                EClinicDB._finishedLoadDB = true;
            }
            catch
            {
                EClinicDB.conn = null;
                MessageBox.Show(__.T("Không thực hiện kết nối được!"));
            }
        }
    }

    // Token: 0x06000030 RID: 48 RVA: 0x00003274 File Offset: 0x00002274
    public static bool CloseConnection()
    {
        if (EClinicDB.conn != null)
        {
            try
            {
                if (EClinicDB.conn.State != ConnectionState.Closed)
                {
                    EClinicDB.conn.Close();
                }
                return true;
            }
            catch
            {
                MessageBox.Show(__.T("Không đóng kết nối được!"));
                return false;
            }
        }
        return false;
    }

    // Token: 0x06000031 RID: 49 RVA: 0x000032DC File Offset: 0x000022DC
    private static int ExecuteCmd(MySqlCommand mySQLCmd)
    {
        int result;
        try
        {
            if (mySQLCmd.Connection == null)
            {
                mySQLCmd.Connection = EClinicDB.conn;
            }
            result = mySQLCmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
            result = -1;
        }
        return result;
    }

    // Token: 0x06000032 RID: 50 RVA: 0x00003334 File Offset: 0x00002334
    public static int ExecuteNonQuery(string sCommand)
    {
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open)
        {
            EClinicDB.cmd.CommandText = sCommand;
            EClinicDB.cmd.CommandType = CommandType.Text;
            try
            {
                return EClinicDB.cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        return -1;
    }

    // Token: 0x06000033 RID: 51 RVA: 0x000033D0 File Offset: 0x000023D0
    public static int ExecuteNonQuery(MySqlCommand cmd)
    {
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open && cmd != null)
        {
            try
            {
                cmd.Connection = EClinicDB.conn;
                return cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        return -1;
    }

    // Token: 0x06000034 RID: 52 RVA: 0x0000345C File Offset: 0x0000245C
    public static int ExecuteNonQuery(string sCmdText, DbCommandType dbType, ParamCollection para)
    {
        MySqlCommand mySqlCommand = new MySqlCommand(sCmdText);
        if (dbType != DbCommandType.StoreProcedure)
        {
            mySqlCommand.CommandType = CommandType.Text;
        }
        else
        {
            mySqlCommand.CommandType = CommandType.StoredProcedure;
        }
        if (para != null)
        {
            EClinicDB.ConvertToMySQLParaCollection(ref mySqlCommand, para);
        }
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open && mySqlCommand != null)
        {
            try
            {
                mySqlCommand.Connection = EClinicDB.conn;
                return mySqlCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        return -1;
    }

    // Token: 0x06000035 RID: 53 RVA: 0x00003524 File Offset: 0x00002524
    public static int ExecuteNonQuery(string sSQLCmd, string szDBKey)
    {
        int result = -1;
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open)
        {
            MySqlCommand mySqlCommand = EClinicDB.CreateMySqlCmd(sSQLCmd);
            MySqlParameter param = new MySqlParameter();
            EClinicDB.AddParamToMySqlCmd(mySqlCommand, param, "?keyDB", MySqlDbType.VarChar, szDBKey.Length, szDBKey);
            result = EClinicDB.ExecuteCmd(mySqlCommand);
        }
        return result;
    }

    // Token: 0x06000036 RID: 54 RVA: 0x000035AC File Offset: 0x000025AC
    public static int ExecuteNonQuery(string sStoreName, MySqlParameterCollection paraCollections)
    {
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open)
        {
            EClinicDB.cmd.CommandText = sStoreName;
            EClinicDB.cmd.CommandType = CommandType.StoredProcedure;
            if (paraCollections != null)
            {
                EClinicDB.cmd.Parameters.Clear();
                foreach (object obj in ((IEnumerable)paraCollections))
                {
                    MySqlParameter value = (MySqlParameter)obj;
                    EClinicDB.cmd.Parameters.Add(value);
                }
            }
            try
            {
                return EClinicDB.cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        return -1;
    }

    // Token: 0x06000037 RID: 55 RVA: 0x000036C4 File Offset: 0x000026C4
    public static int ExecuteNonQuery(string sCommand, CommandType tCommand, ParamCollection paraCollections)
    {
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        int result;
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open)
        {
            EClinicDB.cmd.CommandText = sCommand;
            EClinicDB.cmd.CommandType = tCommand;
            if (paraCollections != null)
            {
                EClinicDB.cmd.Parameters.Clear();
                foreach (object obj in ((IEnumerable)paraCollections.Collection))
                {
                    MySqlParameter value = (MySqlParameter)obj;
                    EClinicDB.cmd.Parameters.Add(value);
                }
            }
            result = EClinicDB.cmd.ExecuteNonQuery();
        }
        else
        {
            result = -1;
        }
        return result;
    }

    // Token: 0x06000038 RID: 56 RVA: 0x000037BC File Offset: 0x000027BC
    public static MySqlDataAdapter CreateMySqlDataAdapter(string sCommand)
    {
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open)
        {
            try
            {
                MySqlCommand selectCommand = new MySqlCommand(sCommand, EClinicDB.conn);
                return new MySqlDataAdapter(selectCommand);
            }
            catch
            {
                return null;
            }
        }
        return null;
    }

    // Token: 0x06000039 RID: 57 RVA: 0x0000383C File Offset: 0x0000283C
    public static MySqlDataReader ExecuteReader(string sCommand)
    {
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        MySqlDataReader result;
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open)
        {
            EClinicDB.cmd.CommandText = sCommand;
            EClinicDB.cmd.CommandType = CommandType.Text;
            result = EClinicDB.cmd.ExecuteReader();
        }
        else
        {
            result = null;
        }
        return result;
    }

    // Token: 0x0600003A RID: 58 RVA: 0x000038B4 File Offset: 0x000028B4
    public static MySqlDataReader ExecuteReader(MySqlCommand sCommand)
    {
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        MySqlDataReader result;
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open)
        {
            sCommand.Connection = EClinicDB.conn;
            result = sCommand.ExecuteReader();
        }
        else
        {
            result = null;
        }
        return result;
    }

    // Token: 0x0600003B RID: 59 RVA: 0x0000391C File Offset: 0x0000291C
    public static MySqlDataReader ExecuteReader(string sCommand, CommandType tCommand)
    {
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        MySqlDataReader result;
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open)
        {
            EClinicDB.cmd.CommandText = sCommand;
            EClinicDB.cmd.CommandType = tCommand;
            result = EClinicDB.cmd.ExecuteReader();
        }
        else
        {
            result = null;
        }
        return result;
    }

    // Token: 0x0600003C RID: 60 RVA: 0x00003994 File Offset: 0x00002994
    public static MySqlDataReader ExecuteReader(string sCommand, CommandType tCommand, ParamCollection paraCollections)
    {
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        MySqlDataReader result;
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open)
        {
            EClinicDB.cmd.CommandText = sCommand;
            EClinicDB.cmd.CommandType = tCommand;
            if (paraCollections != null)
            {
                EClinicDB.cmd.Parameters.Clear();
                foreach (object obj in ((IEnumerable)paraCollections.Collection))
                {
                    MySqlParameter value = (MySqlParameter)obj;
                    EClinicDB.cmd.Parameters.Add(value);
                }
            }
            result = EClinicDB.cmd.ExecuteReader();
        }
        else
        {
            result = null;
        }
        return result;
    }

    // Token: 0x0600003D RID: 61 RVA: 0x00003A8C File Offset: 0x00002A8C
    public static object ExecuteScalar(string commandText, CommandType commandType, ParamCollection paraCollections)
    {
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        object result;
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open)
        {
            EClinicDB.cmd.CommandText = commandText;
            EClinicDB.cmd.CommandType = ((commandType != CommandType.Text) ? commandType : CommandType.Text);
            if (paraCollections != null)
            {
                EClinicDB.cmd.Parameters.Clear();
                foreach (object obj in ((IEnumerable)paraCollections.Collection))
                {
                    MySqlParameter value = (MySqlParameter)obj;
                    EClinicDB.cmd.Parameters.Add(value);
                }
            }
            object obj2 = EClinicDB.cmd.ExecuteScalar();
            result = obj2;
        }
        else
        {
            result = null;
        }
        return result;
    }

    // Token: 0x0600003E RID: 62 RVA: 0x00003B90 File Offset: 0x00002B90
    public static object ExecuteScalar(string commandText, CommandType commandType)
    {
        return EClinicDB.ExecuteScalar(commandText, commandType, null);
    }

    // Token: 0x0600003F RID: 63 RVA: 0x00003BAC File Offset: 0x00002BAC
    public static object ExecuteScalar(string commandText)
    {
        return EClinicDB.ExecuteScalar(commandText, CommandType.Text, null);
    }

    // Token: 0x06000040 RID: 64 RVA: 0x00003BC8 File Offset: 0x00002BC8
    public static DataSet FillDataset(string sCommand)
    {
        DataSet result = null;
        EClinicDB.FillDataset(ref result, sCommand, "table1");
        return result;
    }

    // Token: 0x06000041 RID: 65 RVA: 0x00003BEC File Offset: 0x00002BEC
    public static void FillDataset(ref DataSet refDS, string sCommand, CommandType cmdType, ParamCollection paramCollection, string sTableName)
    {
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open)
        {
            try
            {
                EClinicDB.cmd.CommandText = sCommand;
                EClinicDB.cmd.CommandType = cmdType;
                if (paramCollection != null)
                {
                    EClinicDB.cmd.Parameters.Clear();
                    foreach (object obj in ((IEnumerable)paramCollection.Collection))
                    {
                        MySqlParameter value = (MySqlParameter)obj;
                        EClinicDB.cmd.Parameters.Add(value);
                    }
                }
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(EClinicDB.cmd);
                if (refDS == null)
                {
                    refDS = new DataSet();
                }
                mySqlDataAdapter.Fill(refDS, sTableName);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.Source);
                refDS = null;
            }
        }
    }

    // Token: 0x06000042 RID: 66 RVA: 0x00003D38 File Offset: 0x00002D38
    public static void FillDataset(ref DataSet refDS, string sCommand, ParamCollection paramCollection, string sTableName)
    {
        EClinicDB.FillDataset(ref refDS, sCommand, CommandType.Text, paramCollection, sTableName);
    }

    // Token: 0x06000043 RID: 67 RVA: 0x00003D46 File Offset: 0x00002D46
    public static void FillDataset(ref DataSet refDS, string sCommand, string sTableName)
    {
        EClinicDB.FillDataset(ref refDS, sCommand, CommandType.Text, null, sTableName);
    }

    // Token: 0x06000044 RID: 68 RVA: 0x00003D54 File Offset: 0x00002D54
    public static DataSet FillDataset(string sCommand, bool isDecrypted)
    {
        DataSet result;
        if (isDecrypted)
        {
            result = EClinicDB.FillDataset(sCommand, null, null, null);
        }
        else
        {
            result = EClinicDB.FillDataset(sCommand);
        }
        return result;
    }

    // Token: 0x06000045 RID: 69 RVA: 0x00003D80 File Offset: 0x00002D80
    private static DataSet FillDataset(MySqlCommand cmd)
    {
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        DataSet result;
        if (EClinicDB.conn == null || EClinicDB.conn.State != ConnectionState.Open || cmd == null)
        {
            result = null;
        }
        else
        {
            DataSet dataSet;
            try
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
                dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);
            }
            catch
            {
                return null;
            }
            result = dataSet;
        }
        return result;
    }

    // Token: 0x06000046 RID: 70 RVA: 0x00003E0C File Offset: 0x00002E0C
    public static DataSet FillDataset(string cmdString, CommandType cmdType)
    {
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open)
        {
            try
            {
                EClinicDB.cmd.CommandText = cmdString;
                EClinicDB.cmd.CommandType = cmdType;
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(EClinicDB.cmd);
                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);
                mySqlDataAdapter.Dispose();
                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        return null;
    }

    // Token: 0x06000047 RID: 71 RVA: 0x00003EC4 File Offset: 0x00002EC4
    public static DataSet FillDataset(string sStoreName, CommandType cmdType, ParamCollection paraCollections)
    {
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open)
        {
            try
            {
                EClinicDB.cmd.CommandText = sStoreName;
                EClinicDB.cmd.CommandType = cmdType;
                if (paraCollections != null)
                {
                    EClinicDB.cmd.Parameters.Clear();
                    foreach (object obj in ((IEnumerable)paraCollections.Collection))
                    {
                        MySqlParameter value = (MySqlParameter)obj;
                        EClinicDB.cmd.Parameters.Add(value);
                    }
                }
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(EClinicDB.cmd);
                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);
                mySqlDataAdapter.Dispose();
                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        return null;
    }

    // Token: 0x06000048 RID: 72 RVA: 0x00004004 File Offset: 0x00003004
    public static DataSet FillDataset(string sStoreName, ParamCollection paraCollections)
    {
        if (EClinicDB.conn.State == ConnectionState.Closed)
        {
            EClinicDB.conn.Open();
        }
        if (EClinicDB.conn != null && EClinicDB.conn.State == ConnectionState.Open)
        {
            try
            {
                EClinicDB.cmd.CommandText = sStoreName;
                EClinicDB.cmd.CommandType = CommandType.StoredProcedure;
                if (paraCollections != null)
                {
                    EClinicDB.cmd.Parameters.Clear();
                    foreach (object obj in ((IEnumerable)paraCollections.Collection))
                    {
                        MySqlParameter value = (MySqlParameter)obj;
                        EClinicDB.cmd.Parameters.Add(value);
                    }
                }
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(EClinicDB.cmd);
                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);
                mySqlDataAdapter.Dispose();
                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        return null;
    }

    // Token: 0x06000049 RID: 73 RVA: 0x00004144 File Offset: 0x00003144
    public static string GetLastAutoIncID(string sTableName)
    {
        return EClinicDB.ExecuteScalar("SELECT MAX(" + sTableName + "_Id) FROM " + sTableName, CommandType.Text).ToString();
    }

    // Token: 0x0600004A RID: 74 RVA: 0x00004174 File Offset: 0x00003174
    public static int GetIndexByCode(string sCode)
    {
        int result;
        if (sCode == null || sCode == "")
        {
            result = -1;
        }
        else
        {
            string sCommand = "SELECT List_Id FROM LIST_DICHVU WHERE (Enable = '1') and (List_Name = '" + sCode + "')";
            DataSet dataSet = new DataSet();
            dataSet = EClinicDB.FillDataset(sCommand);
            if (dataSet == null || dataSet.Tables.Count == 0 || dataSet.Tables[0].Rows.Count == 0)
            {
                result = -1;
            }
            else
            {
                result = (int)dataSet.Tables[0].Rows[0][0];
            }
        }
        return result;
    }

    // Token: 0x0600004B RID: 75 RVA: 0x0000421C File Offset: 0x0000321C
    private static MySqlCommand CreateMySqlCmd(string sql)
    {
        return new MySqlCommand(sql, EClinicDB.conn)
        {
            CommandType = CommandType.Text
        };
    }

    // Token: 0x0600004C RID: 76 RVA: 0x00004243 File Offset: 0x00003243
    private static void AddParamToMySqlCmd(MySqlCommand Command, MySqlParameter Param, string szParamName, MySqlDbType ParamType, int ParamSize, object Value)
    {
        Param = Command.Parameters.Add(szParamName, ParamType, ParamSize);
        Param.Value = Value;
    }

    // Token: 0x0600004D RID: 77 RVA: 0x00004260 File Offset: 0x00003260
    private static void ConvertToMySQLParaCollection(ref MySqlCommand cmd, ParamCollection paraCollection)
    {
        if (paraCollection != null)
        {
            cmd.Parameters.Clear();
            foreach (object obj in ((IEnumerable)paraCollection.Collection))
            {
                MySqlParameter value = (MySqlParameter)obj;
                cmd.Parameters.Add(value);
            }
        }
    }

    // Token: 0x0600004E RID: 78 RVA: 0x000042E4 File Offset: 0x000032E4
    private static string GetTableNamesFromSQLQuery(string sSQL)
    {
        sSQL = sSQL.Replace("  ", " ");
        sSQL = sSQL.ToLower();
        string queryType = EClinicDB.GetQueryType(sSQL);
        string text = queryType;
        if (text != null)
        {
            if (text == "select")
            {
                return EClinicDB.GetTableNameFromSelect(sSQL);
            }
            if (text == "insert")
            {
                return EClinicDB.GetTableNameFromInsert(sSQL);
            }
            if (text == "delete")
            {
                return EClinicDB.GetTableNameFromDelete(sSQL);
            }
            if (text == "update")
            {
                return EClinicDB.GetTableNameFromUpdate(sSQL);
            }
        }
        return "";
    }

    // Token: 0x0600004F RID: 79 RVA: 0x0000437C File Offset: 0x0000337C
    private static string GetQueryType(string sSQL)
    {
        string result;
        if (sSQL.IndexOf("select") != -1)
        {
            result = "select";
        }
        else if (sSQL.IndexOf("insert") != -1)
        {
            result = "insert";
        }
        else if (sSQL.IndexOf("update") != -1)
        {
            result = "update";
        }
        else if (sSQL.IndexOf("delete") != -1)
        {
            result = "delete";
        }
        else
        {
            result = "";
        }
        return result;
    }

    // Token: 0x06000050 RID: 80 RVA: 0x000043FC File Offset: 0x000033FC
    private static string GetTableNameFromSelect(string sSQL)
    {
        int num = sSQL.IndexOf("from");
        string result;
        if (num == -1)
        {
            result = "";
        }
        else
        {
            num += 5;
            int num2 = sSQL.IndexOf("where");
            if (num2 == -1)
            {
                num2 = sSQL.IndexOf("order by");
                if (num2 == -1)
                {
                    num2 = sSQL.IndexOf("group by");
                    if (num2 == -1)
                    {
                        num2 = sSQL.Length;
                    }
                }
            }
            num2--;
            result = sSQL.Substring(num, num2 - num + 1).Trim();
        }
        return result;
    }

    // Token: 0x06000051 RID: 81 RVA: 0x0000449C File Offset: 0x0000349C
    private static string GetTableNameFromInsert(string sSQL)
    {
        int num = sSQL.IndexOf("into");
        string result;
        if (num == -1)
        {
            result = "";
        }
        else
        {
            num += 5;
            int num2 = sSQL.IndexOf("values");
            int num3 = sSQL.IndexOf("(");
            int num4;
            if (num2 != -1 && num3 != -1)
            {
                num4 = ((num2 > num3) ? num3 : num2);
            }
            else
            {
                if (num2 == -1 && num3 == -1)
                {
                    return "";
                }
                if (num2 == -1)
                {
                    num4 = num3;
                }
                else
                {
                    num4 = num2;
                }
            }
            num4--;
            result = sSQL.Substring(num, num4 - num + 1).Trim();
        }
        return result;
    }

    // Token: 0x06000052 RID: 82 RVA: 0x00004564 File Offset: 0x00003564
    private static string GetTableNameFromDelete(string sSQL)
    {
        int num = sSQL.IndexOf("from");
        string result;
        if (num == -1)
        {
            result = "";
        }
        else
        {
            num += 5;
            int num2 = sSQL.IndexOf("where");
            if (num2 == -1)
            {
                num2 = sSQL.Length;
            }
            num2--;
            result = sSQL.Substring(num, num2 - num + 1).Trim();
        }
        return result;
    }

    // Token: 0x06000053 RID: 83 RVA: 0x000045D0 File Offset: 0x000035D0
    private static string GetTableNameFromUpdate(string sSQL)
    {
        int num = sSQL.IndexOf("update");
        string result;
        if (num == -1)
        {
            result = "";
        }
        else
        {
            num += 7;
            int num2 = sSQL.IndexOf("set");
            if (num2 == -1)
            {
                result = "";
            }
            else
            {
                num2--;
                result = sSQL.Substring(num, num2 - num + 1).Trim();
            }
        }
        return result;
    }

    // Token: 0x06000054 RID: 84 RVA: 0x00004640 File Offset: 0x00003640
    public static void MakeConnection(string sCnnStr)
    {
        EClinicDB.OpenConnection();
        if (EClinicDB.conn != null)
        {
            EClinicDB.cmd = new MySqlCommand("", EClinicDB.conn);
            EClinicDB.cmd.CommandType = CommandType.Text;
        }
    }

    // Token: 0x06000055 RID: 85 RVA: 0x00004684 File Offset: 0x00003684
    public static void MakeDefaultConnection()
    {
        EClinicDB.OpenConnection();
        if (EClinicDB.conn != null)
        {
            EClinicDB.cmd = new MySqlCommand("", EClinicDB.conn);
            EClinicDB.cmd.CommandType = CommandType.Text;
        }
    }

    private static MySqlConnection conn = null;

    // Token: 0x04000002 RID: 2
    private static MySqlCommand cmd = null;

    // Token: 0x04000003 RID: 3
    private static bool _finishedLoadDB = false;

    // Token: 0x04000004 RID: 4
    private static string _connectionString = EClinicConfig.ConnectionString;
}
