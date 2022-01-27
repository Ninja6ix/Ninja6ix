using System;
using System.Runtime.InteropServices;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000012 RID: 18
	public struct SYSTEM_KERNEL_DEBUGGER_INFORMATION
	{
		// Token: 0x040002D7 RID: 727
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerEnabled;

		// Token: 0x040002D8 RID: 728
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerNotPresent;
	}
}
