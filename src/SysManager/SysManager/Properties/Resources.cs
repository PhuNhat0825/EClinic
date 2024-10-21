using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace SysManager.Properties
{
	// Token: 0x02000007 RID: 7
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00005731 File Offset: 0x00004731
		internal Resources()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000573C File Offset: 0x0000473C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("SysManager.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00005788 File Offset: 0x00004788
		// (set) Token: 0x0600003A RID: 58 RVA: 0x0000579F File Offset: 0x0000479F
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

		// Token: 0x0400003E RID: 62
		private static ResourceManager resourceMan;

		// Token: 0x0400003F RID: 63
		private static CultureInfo resourceCulture;
	}
}
