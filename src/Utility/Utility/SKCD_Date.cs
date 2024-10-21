using System;

namespace Utility
{
	// Token: 0x02000006 RID: 6
	public static class SKCD_Date
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002228 File Offset: 0x00001228
		public static DateTime BeginDayOfMonthWorking()
		{
			DateTime dateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
			return dateTime.Date;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002264 File Offset: 0x00001264
		public static DateTime DayMonthOfWorking()
		{
			return SKCD_Date._dtToday.Date;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002280 File Offset: 0x00001280
		public static int DayOfWorking()
		{
			return SKCD_Date._dtToday.Day;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000229C File Offset: 0x0000129C
		public static int MonthOfWorking()
		{
			return SKCD_Date._dtToday.Month;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000022B8 File Offset: 0x000012B8
		public static int YearOfWorking()
		{
			return SKCD_Date._dtToday.Year;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000022D4 File Offset: 0x000012D4
		public static string DateTimeNowToStringVN()
		{
			string str = string.Empty;
			str = string.Concat(new object[]
			{
				DateTime.Now.Day,
				"/",
				DateTime.Now.Month,
				"/",
				DateTime.Now.Year,
				" "
			});
			return str + DateTime.Now.ToLongTimeString();
		}

		// Token: 0x04000007 RID: 7
		private static DateTime _dtToday = DateTime.Today;
	}
}
