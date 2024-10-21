using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace MainProject
{
	// Token: 0x02000006 RID: 6
	internal partial class AboutBox : Form
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000069B0 File Offset: 0x000059B0
		public AboutBox()
		{
			this.InitializeComponent();
			this.Text = string.Format("About {0}", this.AssemblyTitle);
			this.labelProductName.Text = "QUẢN LÝ PHÒNG KHÁM TỔNG THỂ";
			this.labelVersion.Text = string.Format("Version {0}", this.AssemblyVersion);
			this.labelCopyright.Text = this.AssemblyCopyright;
			this.labelCompanyName.Text = this.AssemblyCompany;
			this.textBoxDescription.Text = this.AssemblyDescription;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00006A50 File Offset: 0x00005A50
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

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00006AC0 File Offset: 0x00005AC0
		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00006AE8 File Offset: 0x00005AE8
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

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00006B34 File Offset: 0x00005B34
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

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00006B80 File Offset: 0x00005B80
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

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00006BCC File Offset: 0x00005BCC
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

		// Token: 0x06000057 RID: 87 RVA: 0x00006C16 File Offset: 0x00005C16
		private void AboutBox_Load(object sender, EventArgs e)
		{
		}
	}
}
