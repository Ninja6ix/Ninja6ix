using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Anti_DebugNET.Utils;
using Anti_DebugNET.Utils.WinStructs;

namespace Anti_DebugNET.AntiDebug
{
	// Token: 0x02000016 RID: 22
	internal class DebugProtect3
	{
		// Token: 0x060000C9 RID: 201
		[DllImport("ntdll.dll")]
		internal static extern NtStatus NtSetInformationThread(IntPtr ThreadHandle, ThreadInformationClass ThreadInformationClass, IntPtr ThreadInformation, int ThreadInformationLength);

		// Token: 0x060000CA RID: 202
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

		// Token: 0x060000CB RID: 203
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr hThread);

		// Token: 0x060000CC RID: 204
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr hThread);

		// Token: 0x060000CD RID: 205
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CloseHandle(IntPtr handle);

		// Token: 0x060000CE RID: 206 RVA: 0x005AF598 File Offset: 0x005A4198
		public static void HideOSThreads()
		{
			ProcessThreadCollection threads = Process.GetCurrentProcess().Threads;
			foreach (object obj in threads)
			{
				ProcessThread processThread = (ProcessThread)obj;
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("[GetOSThreads]: thread.Id {0:X}", processThread.Id);
				IntPtr intPtr = DebugProtect3.OpenThread(ThreadAccess.SET_INFORMATION, false, (uint)processThread.Id);
				if (intPtr == IntPtr.Zero)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("[GetOSThreads]: skipped thread.Id {0:X}", processThread.Id);
				}
				else
				{
					if (DebugProtect3.HideFromDebugger(intPtr))
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("[GetOSThreads]: thread.Id {0:X} hidden from debbuger.", processThread.Id);
					}
					DebugProtect3.CloseHandle(intPtr);
				}
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x005AF6C0 File Offset: 0x005A42C0
		public static bool HideFromDebugger(IntPtr Handle)
		{
			NtStatus ntStatus = DebugProtect3.NtSetInformationThread(Handle, ThreadInformationClass.ThreadHideFromDebugger, IntPtr.Zero, 0);
			return ntStatus == NtStatus.Success;
		}
	}
}
