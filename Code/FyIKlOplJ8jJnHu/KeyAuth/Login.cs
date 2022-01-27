using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using FyIKlOplJ8jJnHu.Properties;
using injector;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace KeyAuth
{
	// Token: 0x02000007 RID: 7
	public partial class Login : Form
	{
		// Token: 0x06000036 RID: 54 RVA: 0x005A816E File Offset: 0x0059CD6E
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x005A818C File Offset: 0x0059CD8C
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x005AAA10 File Offset: 0x0059F610
		private void Login_Load(object sender, EventArgs e)
		{
			Login.KeyAuthApp.init();
			this.Text = Settings.Default.Login;
			this.username.Text = Settings.Default.Login;
			this.Text = Settings.Default.Password;
			this.password.Text = Settings.Default.Password;
			Login.KeyAuthApp.init();
			if (Login.KeyAuthApp.checkblack())
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x005A8198 File Offset: 0x0059CD98
		private void UpgradeBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.upgrade(this.username.Text, this.license.Text);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x005AAAA0 File Offset: 0x0059F6A0
		private void LoginBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.login(this.username.Text, this.password.Text);
			Visor visor = new Visor();
			visor.Show();
			base.Hide();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x005AAAF0 File Offset: 0x0059F6F0
		private void RgstrBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.register(this.username.Text, this.password.Text, this.license.Text);
			Main main = new Main();
			main.Show();
			base.Hide();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x005A81C0 File Offset: 0x0059CDC0
		private void LicBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.license(this.license.Text);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void key_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void username_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x005AAB4C File Offset: 0x0059F74C
		private void FORBADPEOPLE_Tick(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.ProcessName == "dnSpy")
				{
					process.Kill();
				}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x005AABBC File Offset: 0x0059F7BC
		private void FORLOWKEYCHAMS_Tick(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.ProcessName == "x96dbg")
				{
					process.Kill();
				}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x005AAC2C File Offset: 0x0059F82C
		private void LOWKEYPRITTYASSNGL_Tick(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.ProcessName == "x32dbg")
				{
					process.Kill();
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x005AAC9C File Offset: 0x0059F89C
		private void LowkeyKindaDog_Tick(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.ProcessName == "x64dbg")
				{
					process.Kill();
				}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x005AAD0C File Offset: 0x0059F90C
		private void QWQW_Tick(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.ProcessName == "ILSpy")
				{
					process.Kill();
				}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x005AAD7C File Offset: 0x0059F97C
		private void bum_Tick(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				bool flag = process.ProcessName == "strings";
				bool flag2 = process.ProcessName == "strings64";
				bool flag3 = process.ProcessName == "strings64a";
				bool flag4 = process.ProcessName == "st";
				if (flag && flag2 && flag3 && flag4)
				{
					process.Kill();
				}
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x005A81DC File Offset: 0x0059CDDC
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			Process.Start("https://sellix.io/PServices");
		}

		// Token: 0x06000048 RID: 72 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void siticoneLabel2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void password_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void siticoneLabel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void siticoneLabel3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void password_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void siticoneRoundedTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void label3_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x005AAAF0 File Offset: 0x0059F6F0
		private void RgstrBtn_Click_1(object sender, EventArgs e)
		{
			Login.KeyAuthApp.register(this.username.Text, this.password.Text, this.license.Text);
			Main main = new Main();
			main.Show();
			base.Hide();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void license_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void password_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void pictureBox2_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void license_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void pictureBox4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void panel4_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x005AAE4C File Offset: 0x0059FA4C
		private void LoginBtn_Click_1(object sender, EventArgs e)
		{
			Login.KeyAuthApp.login(this.username.Text, this.password.Text);
			Visor visor = new Visor();
			visor.Show();
			base.Hide();
			Settings.Default.Login = this.username.Text;
			Settings.Default.Save();
			Settings.Default.Password = this.password.Text;
			Settings.Default.Save();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x005AAAF0 File Offset: 0x0059F6F0
		private void RgstrBtn_Click_2(object sender, EventArgs e)
		{
			Login.KeyAuthApp.register(this.username.Text, this.password.Text, this.license.Text);
			Main main = new Main();
			main.Show();
			base.Hide();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void pictureBox3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void password_TextChanged_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x005A81E9 File Offset: 0x0059CDE9
		private void username_MouseClick(object sender, MouseEventArgs e)
		{
			this.username.Text = " ";
		}

		// Token: 0x06000061 RID: 97 RVA: 0x005A81FE File Offset: 0x0059CDFE
		private void password_MouseClick(object sender, MouseEventArgs e)
		{
			this.password.Text = " ";
		}

		// Token: 0x06000062 RID: 98 RVA: 0x005A8213 File Offset: 0x0059CE13
		private void license_MouseClick(object sender, MouseEventArgs e)
		{
			this.license.Text = " ";
		}

		// Token: 0x06000063 RID: 99 RVA: 0x005AAEE0 File Offset: 0x0059FAE0
		private void label2_MouseClick(object sender, MouseEventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("FyIKlOplJ8jJnHu");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x005A81DA File Offset: 0x0059CDDA
		private void label2_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0400000F RID: 15
		private static string name = "NoRecoil";

		// Token: 0x04000010 RID: 16
		private static string ownerid = "Rv0bEfTlyT";

		// Token: 0x04000011 RID: 17
		private static string secret = "74a754f2582f363be10abcd9671ca46b3cf12011ebf52c8d656ab8fd47cc6e89";

		// Token: 0x04000012 RID: 18
		private static string version = "1.0";

		// Token: 0x04000013 RID: 19
		public static api KeyAuthApp = new api(Login.name, Login.ownerid, Login.secret, Login.version);
	}
}
