using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace EchoAdmin.Properties
{
	// Token: 0x0200000D RID: 13
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x06000072 RID: 114 RVA: 0x0000B459 File Offset: 0x0000A459
		internal Resources()
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000B464 File Offset: 0x0000A464
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("EchoAdmin.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000B4B0 File Offset: 0x0000A4B0
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0000B4C7 File Offset: 0x0000A4C7
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

		// Token: 0x040000A3 RID: 163
		private static ResourceManager resourceMan;

		// Token: 0x040000A4 RID: 164
		private static CultureInfo resourceCulture;
	}
}
