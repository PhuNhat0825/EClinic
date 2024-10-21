using System;
using System.Windows.Forms;

namespace MainProject
{
	// Token: 0x0200000D RID: 13
	internal static class Program
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00008E78 File Offset: 0x00007E78
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MessageBoxManager.Register();
			LoginForm loginForm = new LoginForm();
			loginForm.ShowDialog();
			if (loginForm.DialogResult == DialogResult.OK)
			{
				loginForm.Close();
				Application.Run(new MDIeClinic());
			}
			else
			{
				loginForm.Close();
			}
			MessageBoxManager.Unregister();
		}
	}
}
