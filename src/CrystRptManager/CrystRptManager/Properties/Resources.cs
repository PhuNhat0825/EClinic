using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace CrystRptManager.Properties
{
	// Token: 0x0200005B RID: 91
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x0600075A RID: 1882 RVA: 0x0001A54B File Offset: 0x0001954B
		internal Resources()
		{
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x0001A558 File Offset: 0x00019558
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("CrystRptManager.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x0001A5A4 File Offset: 0x000195A4
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x0001A5BB File Offset: 0x000195BB
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x0400014D RID: 333
		private static ResourceManager resourceMan;

		// Token: 0x0400014E RID: 334
		private static CultureInfo resourceCulture;
	}
}
