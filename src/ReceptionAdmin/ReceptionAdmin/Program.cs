using System;
using System.Windows.Forms;

namespace ReceptionAdmin
{
	// Token: 0x02000002 RID: 2
	internal static class Program
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MessageBoxManager.Register();
			Application.Run(new ReceptionAdmin());
			MessageBoxManager.Unregister();
		}
	}
}
