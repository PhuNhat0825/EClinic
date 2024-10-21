using System;
using System.Windows.Forms;

namespace SysManager
{
	// Token: 0x02000008 RID: 8
	internal static class Program
	{
		// Token: 0x0600003B RID: 59 RVA: 0x000057A8 File Offset: 0x000047A8
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new PhongBanDichVu());
		}
	}
}
