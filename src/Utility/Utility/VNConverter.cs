using System;

namespace Utility
{
	// Token: 0x02000005 RID: 5
	public class VNConverter
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002168 File Offset: 0x00001168
		public static string ToUnSignedStringNoCase(string s)
		{
			return VNConverter.ToUnSignedString(s.ToLower());
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002188 File Offset: 0x00001188
		public static string ToUnSignedString(string s)
		{
			string text = "";
			int length = s.Length;
			for (int i = 0; i < length; i++)
			{
				int num = VNConverter.m_szSignedChars.IndexOf(s[i]);
				if (num != -1)
				{
					text += VNConverter.m_szUSignedChars[num];
				}
				else
				{
					text += s[i];
				}
			}
			return text;
		}

		// Token: 0x04000005 RID: 5
		private static string m_szSignedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáàảãạăắằẳẵặâấầẩẫậđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬĐÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰ";

		// Token: 0x04000006 RID: 6
		private static string m_szUSignedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZaaaaaaaaaaaaaaaaadeeeeeeeeeeeiiiiiooooooooooooooooouuuuuuuuuuuAAAAAAAAAAAAAAAAADEEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOOOUUUUUUUUUUU";
	}
}
