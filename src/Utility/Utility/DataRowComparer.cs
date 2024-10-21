using System;
using System.Collections;
using System.ComponentModel;
using System.Data;

namespace Utility
{
	// Token: 0x02000002 RID: 2
	public class DataRowComparer : IComparer
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		public DataRowComparer(int columnIndex, ListSortDirection direction)
		{
			this.columnIndex = columnIndex;
			this.direction = direction;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000206C File Offset: 0x0000106C
		public int Compare(object x, object y)
		{
			DataRow dataRow = (DataRow)x;
			DataRow dataRow2 = (DataRow)y;
			return string.Compare(dataRow[this.columnIndex].ToString(), dataRow2[this.columnIndex].ToString()) * ((this.direction == ListSortDirection.Ascending) ? 1 : -1);
		}

		// Token: 0x04000001 RID: 1
		private ListSortDirection direction;

		// Token: 0x04000002 RID: 2
		private int columnIndex;
	}
}
