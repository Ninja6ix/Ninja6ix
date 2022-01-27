using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000011 RID: 17
	[Flags]
	public enum ThreadAccess
	{
		// Token: 0x040002CE RID: 718
		TERMINATE = 1,
		// Token: 0x040002CF RID: 719
		SUSPEND_RESUME = 2,
		// Token: 0x040002D0 RID: 720
		GET_CONTEXT = 8,
		// Token: 0x040002D1 RID: 721
		SET_CONTEXT = 16,
		// Token: 0x040002D2 RID: 722
		SET_INFORMATION = 32,
		// Token: 0x040002D3 RID: 723
		QUERY_INFORMATION = 64,
		// Token: 0x040002D4 RID: 724
		SET_THREAD_TOKEN = 128,
		// Token: 0x040002D5 RID: 725
		IMPERSONATE = 256,
		// Token: 0x040002D6 RID: 726
		DIRECT_IMPERSONATION = 512
	}
}
