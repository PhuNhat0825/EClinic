using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace EchoAdmin
{
	// Token: 0x02000007 RID: 7
	internal partial class AboutBox : Form
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00003BAC File Offset: 0x00002BAC
		public AboutBox()
		{
			this.InitializeComponent();
			this.Text = string.Format("About {0}", this.AssemblyTitle);
			this.labelProductName.Text = this.AssemblyProduct;
			this.labelVersion.Text = string.Format("Version {0}", this.AssemblyVersion);
			this.labelCopyright.Text = this.AssemblyCopyright;
			this.labelCompanyName.Text = this.AssemblyCompany;
			this.textBoxDescription.Text = this.AssemblyDescription;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00003C4C File Offset: 0x00002C4C
		public string AssemblyTitle
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
				if (customAttributes.Length > 0)
				{
					AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)customAttributes[0];
					if (assemblyTitleAttribute.Title != "")
					{
						return assemblyTitleAttribute.Title;
					}
				}
				return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003CBC File Offset: 0x00002CBC
		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00003CE4 File Offset: 0x00002CE4
		public string AssemblyDescription
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
				string result;
				if (customAttributes.Length == 0)
				{
					result = "";
				}
				else
				{
					result = ((AssemblyDescriptionAttribute)customAttributes[0]).Description;
				}
				return result;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003D30 File Offset: 0x00002D30
		public string AssemblyProduct
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				string result;
				if (customAttributes.Length == 0)
				{
					result = "";
				}
				else
				{
					result = ((AssemblyProductAttribute)customAttributes[0]).Product;
				}
				return result;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003D7C File Offset: 0x00002D7C
		public string AssemblyCopyright
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
				string result;
				if (customAttributes.Length == 0)
				{
					result = "";
				}
				else
				{
					result = ((AssemblyCopyrightAttribute)customAttributes[0]).Copyright;
				}
				return result;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003DC8 File Offset: 0x00002DC8
		public string AssemblyCompany
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
				string result;
				if (customAttributes.Length == 0)
				{
					result = "";
				}
				else
				{
					result = ((AssemblyCompanyAttribute)customAttributes[0]).Company;
				}
				return result;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003E12 File Offset: 0x00002E12
		private void okButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
