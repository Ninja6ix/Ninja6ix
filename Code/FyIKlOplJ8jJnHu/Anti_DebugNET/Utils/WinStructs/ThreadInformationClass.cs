using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000010 RID: 16
	public enum ThreadInformationClass
	{
		// Token: 0x040002A6 RID: 678
		ThreadBasicInformation,
		// Token: 0x040002A7 RID: 679
		ThreadTimes,
		// Token: 0x040002A8 RID: 680
		ThreadPriority,
		// Token: 0x040002A9 RID: 681
		ThreadBasePriority,
		// Token: 0x040002AA RID: 682
		ThreadAffinityMask,
		// Token: 0x040002AB RID: 683
		ThreadImpersonationToken,
		// Token: 0x040002AC RID: 684
		ThreadDescriptorTableEntry,
		// Token: 0x040002AD RID: 685
		ThreadEnableAlignmentFaultFixup,
		// Token: 0x040002AE RID: 686
		ThreadEventPair_Reusable,
		// Token: 0x040002AF RID: 687
		ThreadQuerySetWin32StartAddress,
		// Token: 0x040002B0 RID: 688
		ThreadZeroTlsCell,
		// Token: 0x040002B1 RID: 689
		ThreadPerformanceCount,
		// Token: 0x040002B2 RID: 690
		ThreadAmILastThread,
		// Token: 0x040002B3 RID: 691
		ThreadIdealProcessor,
		// Token: 0x040002B4 RID: 692
		ThreadPriorityBoost,
		// Token: 0x040002B5 RID: 693
		ThreadSetTlsArrayAddress,
		// Token: 0x040002B6 RID: 694
		ThreadIsIoPending,
		// Token: 0x040002B7 RID: 695
		ThreadHideFromDebugger,
		// Token: 0x040002B8 RID: 696
		ThreadBreakOnTermination,
		// Token: 0x040002B9 RID: 697
		ThreadSwitchLegacyState,
		// Token: 0x040002BA RID: 698
		ThreadIsTerminated,
		// Token: 0x040002BB RID: 699
		ThreadLastSystemCall,
		// Token: 0x040002BC RID: 700
		ThreadIoPriority,
		// Token: 0x040002BD RID: 701
		ThreadCycleTime,
		// Token: 0x040002BE RID: 702
		ThreadPagePriority,
		// Token: 0x040002BF RID: 703
		ThreadActualBasePriority,
		// Token: 0x040002C0 RID: 704
		ThreadTebInformation,
		// Token: 0x040002C1 RID: 705
		ThreadCSwitchMon,
		// Token: 0x040002C2 RID: 706
		ThreadCSwitchPmu,
		// Token: 0x040002C3 RID: 707
		ThreadWow64Context,
		// Token: 0x040002C4 RID: 708
		ThreadGroupInformation,
		// Token: 0x040002C5 RID: 709
		ThreadUmsInformation,
		// Token: 0x040002C6 RID: 710
		ThreadCounterProfiling,
		// Token: 0x040002C7 RID: 711
		ThreadIdealProcessorEx,
		// Token: 0x040002C8 RID: 712
		ThreadCpuAccountingInformation,
		// Token: 0x040002C9 RID: 713
		ThreadSuspendCount,
		// Token: 0x040002CA RID: 714
		ThreadDescription = 38,
		// Token: 0x040002CB RID: 715
		ThreadActualGroupAffinity = 41,
		// Token: 0x040002CC RID: 716
		ThreadDynamicCodePolicy
	}
}
