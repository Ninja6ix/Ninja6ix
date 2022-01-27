using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace KeyAuth
{
	// Token: 0x02000008 RID: 8
	public partial class Main : Form
	{
		// Token: 0x06000068 RID: 104 RVA: 0x005A8228 File Offset: 0x0059CE28
		public Main()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x005A818C File Offset: 0x0059CD8C
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void Main_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x005ACFE8 File Offset: 0x005A1BE8
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void subscription_Click(object sender, EventArgs e)
		{
		}
	}
}
