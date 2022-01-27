using System;
using System.Windows.Forms;
using KeyAuth;

namespace injector
{
	// Token: 0x0200000A RID: 10
	internal static class Program
	{
		// Token: 0x06000075 RID: 117 RVA: 0x005A826F File Offset: 0x0059CE6F
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}

		// Token: 0x04000046 RID: 70
		public static string GameFolder;
	}
}
