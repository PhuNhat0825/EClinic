using System;
using System.Security.Cryptography;
using System.Text;

namespace Utility
{
	// Token: 0x02000009 RID: 9
	public class Hash
	{
		// Token: 0x06000021 RID: 33 RVA: 0x000026CC File Offset: 0x000016CC
		public static string GetHash(string strPlain, Hash.HashType hshType)
		{
			string result;
			switch (hshType)
			{
			case Hash.HashType.MD5:
				result = Hash.GetMD5(strPlain);
				break;
			case Hash.HashType.SHA1:
				result = Hash.GetSHA1(strPlain);
				break;
			case Hash.HashType.SHA256:
				result = Hash.GetSHA256(strPlain);
				break;
			case Hash.HashType.SHA384:
				result = Hash.GetSHA384(strPlain);
				break;
			case Hash.HashType.SHA512:
				result = Hash.GetSHA512(strPlain);
				break;
			default:
				result = "Invalid HashType";
				break;
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002734 File Offset: 0x00001734
		public static bool CheckHash(string strOriginal, string strHash, Hash.HashType hshType)
		{
			string hash = Hash.GetHash(strOriginal, hshType);
			return hash == strHash;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002758 File Offset: 0x00001758
		private static string GetMD5(string strPlain)
		{
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			byte[] bytes = unicodeEncoding.GetBytes(strPlain);
			MD5 md = new MD5CryptoServiceProvider();
			string text = "";
			byte[] array = md.ComputeHash(bytes);
			foreach (byte b in array)
			{
				text += string.Format("{0:x2}", b);
			}
			return text;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000027D4 File Offset: 0x000017D4
		private static string GetSHA1(string strPlain)
		{
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			byte[] bytes = unicodeEncoding.GetBytes(strPlain);
			SHA1Managed sha1Managed = new SHA1Managed();
			string text = "";
			byte[] array = sha1Managed.ComputeHash(bytes);
			foreach (byte b in array)
			{
				text += string.Format("{0:x2}", b);
			}
			return text;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002850 File Offset: 0x00001850
		private static string GetSHA256(string strPlain)
		{
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			byte[] bytes = unicodeEncoding.GetBytes(strPlain);
			SHA256Managed sha256Managed = new SHA256Managed();
			string text = "";
			byte[] array = sha256Managed.ComputeHash(bytes);
			foreach (byte b in array)
			{
				text += string.Format("{0:x2}", b);
			}
			return text;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000028CC File Offset: 0x000018CC
		private static string GetSHA384(string strPlain)
		{
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			byte[] bytes = unicodeEncoding.GetBytes(strPlain);
			SHA384Managed sha384Managed = new SHA384Managed();
			string text = "";
			byte[] array = sha384Managed.ComputeHash(bytes);
			foreach (byte b in array)
			{
				text += string.Format("{0:x2}", b);
			}
			return text;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002948 File Offset: 0x00001948
		private static string GetSHA512(string strPlain)
		{
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			byte[] bytes = unicodeEncoding.GetBytes(strPlain);
			SHA512Managed sha512Managed = new SHA512Managed();
			string text = "";
			byte[] array = sha512Managed.ComputeHash(bytes);
			foreach (byte b in array)
			{
				text += string.Format("{0:x2}", b);
			}
			return text;
		}

		// Token: 0x0200000A RID: 10
		public enum HashType
		{
			// Token: 0x0400000B RID: 11
			MD5,
			// Token: 0x0400000C RID: 12
			SHA1,
			// Token: 0x0400000D RID: 13
			SHA256,
			// Token: 0x0400000E RID: 14
			SHA384,
			// Token: 0x0400000F RID: 15
			SHA512
		}
	}
}
