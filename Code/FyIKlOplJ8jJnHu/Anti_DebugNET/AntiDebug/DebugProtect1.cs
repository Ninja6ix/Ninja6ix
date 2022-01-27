using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Anti_DebugNET.AntiDebug
{
	// Token: 0x02000014 RID: 20
	internal class DebugProtect1
	{
		// Token: 0x060000B7 RID: 183
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] ref bool isDebuggerPresent);

		// Token: 0x060000B8 RID: 184
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsDebuggerPresent();

		// Token: 0x060000B9 RID: 185 RVA: 0x005AF1AC File Offset: 0x005A3DAC
		public static int PerformChecks()
		{
			int result;
			if (DebugProtect1.CheckDebuggerManagedPresent() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebuggerManagedPresent: HIT");
				result = 1;
			}
			else if (DebugProtect1.CheckDebuggerUnmanagedPresent() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebuggerUnmanagedPresent: HIT");
				result = 1;
			}
			else if (DebugProtect1.CheckRemoteDebugger() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckRemoteDebugger: HIT");
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x005AF250 File Offset: 0x005A3E50
		private static int CheckDebuggerManagedPresent()
		{
			int result;
			if (Debugger.IsAttached)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x005AF27C File Offset: 0x005A3E7C
		private static int CheckDebuggerUnmanagedPresent()
		{
			int result;
			if (DebugProtect1.IsDebuggerPresent())
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x005AF2A8 File Offset: 0x005A3EA8
		private static int CheckRemoteDebugger()
		{
			bool flag = false;
			int result;
			if (DebugProtect1.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag) && flag)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}
	}
}
