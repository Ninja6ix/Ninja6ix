using System;
using System.Runtime.InteropServices;

// Token: 0x02000027 RID: 39
internal static class Class31
{
	// Token: 0x0600018A RID: 394
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, int int_5, int int_6, IntPtr intptr_3, int int_7, int int_8, IntPtr intptr_4);

	// Token: 0x0600018B RID: 395
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFileMapping(IntPtr intptr_3, IntPtr intptr_4, Class31.Enum0 enum0_0, int int_5, int int_6, string string_0);

	// Token: 0x0600018C RID: 396
	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr MapViewOfFile(IntPtr intptr_3, Class31.Enum1 enum1_0, int int_5, int int_6, IntPtr intptr_4);

	// Token: 0x0600018D RID: 397
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool UnmapViewOfFile(IntPtr intptr_3);

	// Token: 0x0600018E RID: 398
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_3);

	// Token: 0x0600018F RID: 399
	[DllImport("kernel32", SetLastError = true)]
	public static extern uint GetFileSize(IntPtr intptr_3, IntPtr intptr_4);

	// Token: 0x06000190 RID: 400
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool VirtualProtect(IntPtr intptr_3, UIntPtr uintptr_0, Class31.Enum0 enum0_0, out Class31.Enum0 enum0_1);

	// Token: 0x06000191 RID: 401
	[DllImport("kernel32")]
	public static extern bool IsDebuggerPresent();

	// Token: 0x06000192 RID: 402
	[DllImport("kernel32")]
	public static extern bool CheckRemoteDebuggerPresent();

	// Token: 0x06000193 RID: 403
	[DllImport("ntdll")]
	public static extern int NtQueryInformationProcess(IntPtr intptr_3, int int_5, byte[] byte_0, uint uint_0, out uint uint_1);

	// Token: 0x04000310 RID: 784
	public const int int_0 = -2147483648;

	// Token: 0x04000311 RID: 785
	public const int int_1 = 3;

	// Token: 0x04000312 RID: 786
	public const int int_2 = 128;

	// Token: 0x04000313 RID: 787
	public const int int_3 = 1;

	// Token: 0x04000314 RID: 788
	public const int int_4 = 2;

	// Token: 0x04000315 RID: 789
	public static readonly IntPtr intptr_0 = new IntPtr(-1);

	// Token: 0x04000316 RID: 790
	public static readonly IntPtr intptr_1 = IntPtr.Zero;

	// Token: 0x04000317 RID: 791
	public static readonly IntPtr intptr_2 = new IntPtr(-1);

	// Token: 0x0200004E RID: 78
	public enum Enum0 : uint
	{
		// Token: 0x04000376 RID: 886
		const_0 = 1U,
		// Token: 0x04000377 RID: 887
		const_1,
		// Token: 0x04000378 RID: 888
		const_2 = 4U,
		// Token: 0x04000379 RID: 889
		const_3 = 8U,
		// Token: 0x0400037A RID: 890
		const_4 = 16U,
		// Token: 0x0400037B RID: 891
		const_5 = 32U,
		// Token: 0x0400037C RID: 892
		const_6 = 64U,
		// Token: 0x0400037D RID: 893
		const_7 = 256U
	}

	// Token: 0x0200004F RID: 79
	public enum Enum1 : uint
	{
		// Token: 0x0400037F RID: 895
		const_0 = 1U,
		// Token: 0x04000380 RID: 896
		const_1,
		// Token: 0x04000381 RID: 897
		const_2 = 4U,
		// Token: 0x04000382 RID: 898
		const_3 = 31U
	}
}
