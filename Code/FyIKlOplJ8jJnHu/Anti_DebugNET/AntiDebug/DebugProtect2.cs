using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Anti_DebugNET.Utils;
using Anti_DebugNET.Utils.WinStructs;

namespace Anti_DebugNET.AntiDebug
{
	// Token: 0x02000015 RID: 21
	internal class DebugProtect2
	{
		// Token: 0x060000BE RID: 190
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtQueryInformationProcess([In] IntPtr ProcessHandle, [In] PROCESSINFOCLASS ProcessInformationClass, out IntPtr ProcessInformation, [In] int ProcessInformationLength, [Optional] out int ReturnLength);

		// Token: 0x060000BF RID: 191
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtClose([In] IntPtr Handle);

		// Token: 0x060000C0 RID: 192
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtRemoveProcessDebug(IntPtr ProcessHandle, IntPtr DebugObjectHandle);

		// Token: 0x060000C1 RID: 193
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtSetInformationDebugObject([In] IntPtr DebugObjectHandle, [In] DebugObjectInformationClass DebugObjectInformationClass, [In] IntPtr DebugObjectInformation, [In] int DebugObjectInformationLength, [Optional] out int ReturnLength);

		// Token: 0x060000C2 RID: 194
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtQuerySystemInformation([In] SYSTEM_INFORMATION_CLASS SystemInformationClass, IntPtr SystemInformation, [In] int SystemInformationLength, [Optional] out int ReturnLength);

		// Token: 0x060000C3 RID: 195 RVA: 0x005AF2F0 File Offset: 0x005A3EF0
		public static int PerformChecks()
		{
			int result;
			if (DebugProtect2.CheckDebugPort() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebugPort: HIT");
				result = 1;
			}
			else if (DebugProtect2.CheckKernelDebugInformation())
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckKernelDebugInformation: HIT");
				result = 1;
			}
			else if (DebugProtect2.DetachFromDebuggerProcess())
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("DetachFromDebuggerProcess: HIT");
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x005AF384 File Offset: 0x005A3F84
		private static int CheckDebugPort()
		{
			IntPtr intPtr = new IntPtr(0);
			int num;
			NtStatus ntStatus = DebugProtect2.NtQueryInformationProcess(Process.GetCurrentProcess().Handle, PROCESSINFOCLASS.ProcessDebugPort, out intPtr, Marshal.SizeOf<IntPtr>(intPtr), out num);
			int result;
			if (ntStatus == NtStatus.Success && intPtr == new IntPtr(-1))
			{
				Console.WriteLine("DebugPort : {0:X}", intPtr);
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x005AF418 File Offset: 0x005A4018
		private unsafe static bool DetachFromDebuggerProcess()
		{
			IntPtr invalid_HANDLE_VALUE = DebugProtect2.INVALID_HANDLE_VALUE;
			uint structure = 0U;
			int num;
			NtStatus ntStatus = DebugProtect2.NtQueryInformationProcess(Process.GetCurrentProcess().Handle, PROCESSINFOCLASS.ProcessDebugObjectHandle, out invalid_HANDLE_VALUE, IntPtr.Size, out num);
			bool result;
			if (ntStatus > NtStatus.Success)
			{
				result = false;
			}
			else
			{
				int num2;
				ntStatus = DebugProtect2.NtSetInformationDebugObject(invalid_HANDLE_VALUE, DebugObjectInformationClass.DebugObjectFlags, new IntPtr((void*)(&structure)), Marshal.SizeOf<uint>(structure), out num2);
				if (ntStatus > NtStatus.Success)
				{
					result = false;
				}
				else
				{
					ntStatus = DebugProtect2.NtRemoveProcessDebug(Process.GetCurrentProcess().Handle, invalid_HANDLE_VALUE);
					if (ntStatus > NtStatus.Success)
					{
						result = false;
					}
					else
					{
						ntStatus = DebugProtect2.NtClose(invalid_HANDLE_VALUE);
						result = (ntStatus <= NtStatus.Success);
					}
				}
			}
			return result;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x005AF51C File Offset: 0x005A411C
		private unsafe static bool CheckKernelDebugInformation()
		{
			SYSTEM_KERNEL_DEBUGGER_INFORMATION system_KERNEL_DEBUGGER_INFORMATION;
			int num;
			NtStatus ntStatus = DebugProtect2.NtQuerySystemInformation(SYSTEM_INFORMATION_CLASS.SystemKernelDebuggerInformation, new IntPtr((void*)(&system_KERNEL_DEBUGGER_INFORMATION)), Marshal.SizeOf<SYSTEM_KERNEL_DEBUGGER_INFORMATION>(system_KERNEL_DEBUGGER_INFORMATION), out num);
			return ntStatus == NtStatus.Success && (system_KERNEL_DEBUGGER_INFORMATION.KernelDebuggerEnabled && !system_KERNEL_DEBUGGER_INFORMATION.KernelDebuggerNotPresent);
		}

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
	}
}
