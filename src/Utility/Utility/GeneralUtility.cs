using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Utility
{
	// Token: 0x02000008 RID: 8
	public static class GeneralUtility
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002578 File Offset: 0x00001578
		public static byte[] ReadBitmap2ByteArray(Bitmap image)
		{
			byte[] result;
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				image.Save(memoryStream, ImageFormat.Jpeg);
				result = memoryStream.ToArray();
			}
			finally
			{
				if (image != null)
				{
					((IDisposable)image).Dispose();
				}
			}
			return result;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000025C8 File Offset: 0x000015C8
		public static byte[] ReadBitmap2ByteArray(string imagePath)
		{
			byte[] result;
			using (Bitmap bitmap = new Bitmap(imagePath))
			{
				MemoryStream memoryStream = new MemoryStream();
				bitmap.Save(memoryStream, ImageFormat.Jpeg);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000261C File Offset: 0x0000161C
		public static Bitmap ReadByteArray2Image(byte[] content)
		{
			MemoryStream stream = new MemoryStream(content);
			return new Bitmap(stream);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002640 File Offset: 0x00001640
		public static void DeleteArrayImage()
		{
			foreach (string path in GeneralUtility.ArrayCaptureImagesPath)
			{
				File.Delete(path);
			}
			GeneralUtility.ArrayCaptureImagesPath.Clear();
		}

		// Token: 0x04000008 RID: 8
		public static List<Bitmap> ArrayCaptureImages = new List<Bitmap>();

		// Token: 0x04000009 RID: 9
		public static List<string> ArrayCaptureImagesPath = new List<string>();
	}
}
