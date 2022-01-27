using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace injector
{
	// Token: 0x02000009 RID: 9
	public partial class Help : Form
	{
		// Token: 0x0600006F RID: 111 RVA: 0x005A8246 File Offset: 0x0059CE46
		public Help()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void Help_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x005A8264 File Offset: 0x0059CE64
		private void button3_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
