using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace FyIKlOplJ8jJnHu.Properties
{
	// Token: 0x02000002 RID: 2
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	internal class Resources
	{
		// Token: 0x06000002 RID: 2 RVA: 0x005A805B File Offset: 0x0059CC5B
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x005A87D0 File Offset: 0x0059D3D0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager resourceManager = new ResourceManager("FyIKlOplJ8jJnHu.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x005A881C File Offset: 0x0059D41C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x005A8066 File Offset: 0x0059CC66
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x005A8838 File Offset: 0x0059D438
		internal static byte[] playersuperior
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("playersuperior", Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		// Token: 0x04000001 RID: 1
		private static ResourceManager resourceMan;

		// Token: 0x04000002 RID: 2
		private static CultureInfo resourceCulture;
	}
}
