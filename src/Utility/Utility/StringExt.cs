using System;

namespace Utility
{
	// Token: 0x02000007 RID: 7
	public class StringExt
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002380 File Offset: 0x00001380
		public string[] StringSplite(string InputString)
		{
			InputString.Trim();
			string[] array = new string[]
			{
				"",
				""
			};
			string[] array2 = InputString.Split(new char[]
			{
				' ',
				','
			});
			int num = array2.Length;
			string text = "";
			for (int i = 0; i < num - 1; i++)
			{
				text = text + " " + array2[i];
				text = text.Trim();
			}
			array[0] = text;
			array[1] = array2[num - 1];
			return array;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002420 File Offset: 0x00001420
		public string DateTimeNowToStringVN()
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

		// Token: 0x06000017 RID: 23 RVA: 0x000024B4 File Offset: 0x000014B4
		public static string ChuanHoaSo(string s)
		{
			while (s.StartsWith("0"))
			{
				s = s.Remove(0, 1);
			}
			return s;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000024E4 File Offset: 0x000014E4
		public static string StringNull(object intInput)
		{
			string empty = string.Empty;
			string result;
			if (intInput == null)
			{
				result = empty;
			}
			else
			{
				result = intInput.ToString();
			}
			return result;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002514 File Offset: 0x00001514
		public static string StringZero(object intInput)
		{
			string empty = string.Empty;
			string result;
			if (intInput == null || intInput.ToString() == "")
			{
				result = "0";
			}
			else
			{
				result = intInput.ToString();
			}
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000255C File Offset: 0x0000155C
		public static string NumberFormatString(string stringInput)
		{
			string empty = string.Empty;
			return stringInput;
		}
	}
}
