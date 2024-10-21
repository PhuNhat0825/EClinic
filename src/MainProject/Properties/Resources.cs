using System.CodeDom.Compiler;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace MainProject.Properties
{
    // Token: 0x0200000C RID: 12
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources
    {
        internal Resources()
        {
        }

        // Token: 0x1700000D RID: 13
        // (get) Token: 0x06000083 RID: 131 RVA: 0x00008D7C File Offset: 0x00007D7C
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    ResourceManager resourceManager = new ResourceManager("MainProject.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = resourceManager;
                }
                return Resources.resourceMan;
            }
        }

        // Token: 0x1700000E RID: 14
        // (get) Token: 0x06000084 RID: 132 RVA: 0x00008DC8 File Offset: 0x00007DC8
        // (set) Token: 0x06000085 RID: 133 RVA: 0x00008DDF File Offset: 0x00007DDF
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
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

        // Token: 0x1700000F RID: 15
        // (get) Token: 0x06000086 RID: 134 RVA: 0x00008DE8 File Offset: 0x00007DE8
        internal static Bitmap Computer01
        {
            get
            {
                object @object = Resources.ResourceManager.GetObject("Computer01", Resources.resourceCulture);
                return (Bitmap)@object;
            }
        }

        // Token: 0x17000010 RID: 16
        // (get) Token: 0x06000087 RID: 135 RVA: 0x00008E18 File Offset: 0x00007E18
        internal static Bitmap Help
        {
            get
            {
                object @object = Resources.ResourceManager.GetObject("Help", Resources.resourceCulture);
                return (Bitmap)@object;
            }
        }

        // Token: 0x17000011 RID: 17
        // (get) Token: 0x06000088 RID: 136 RVA: 0x00008E48 File Offset: 0x00007E48
        internal static Bitmap Users
        {
            get
            {
                object @object = Resources.ResourceManager.GetObject("Users", Resources.resourceCulture);
                return (Bitmap)@object;
            }
        }

        // Token: 0x04000089 RID: 137
        private static ResourceManager resourceMan;

        // Token: 0x0400008A RID: 138
        private static CultureInfo resourceCulture;
    }
}
