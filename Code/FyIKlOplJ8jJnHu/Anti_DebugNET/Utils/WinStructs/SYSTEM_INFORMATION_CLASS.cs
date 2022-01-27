using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x0200000F RID: 15
	public enum SYSTEM_INFORMATION_CLASS
	{
		// Token: 0x04000207 RID: 519
		SystemBasicInformation,
		// Token: 0x04000208 RID: 520
		SystemProcessorInformation,
		// Token: 0x04000209 RID: 521
		SystemPerformanceInformation,
		// Token: 0x0400020A RID: 522
		SystemTimeOfDayInformation,
		// Token: 0x0400020B RID: 523
		SystemPathInformation,
		// Token: 0x0400020C RID: 524
		SystemProcessInformation,
		// Token: 0x0400020D RID: 525
		SystemCallCountInformation,
		// Token: 0x0400020E RID: 526
		SystemDeviceInformation,
		// Token: 0x0400020F RID: 527
		SystemProcessorPerformanceInformation,
		// Token: 0x04000210 RID: 528
		SystemFlagsInformation,
		// Token: 0x04000211 RID: 529
		SystemCallTimeInformation,
		// Token: 0x04000212 RID: 530
		SystemModuleInformation,
		// Token: 0x04000213 RID: 531
		SystemLocksInformation,
		// Token: 0x04000214 RID: 532
		SystemStackTraceInformation,
		// Token: 0x04000215 RID: 533
		SystemPagedPoolInformation,
		// Token: 0x04000216 RID: 534
		SystemNonPagedPoolInformation,
		// Token: 0x04000217 RID: 535
		SystemHandleInformation,
		// Token: 0x04000218 RID: 536
		SystemObjectInformation,
		// Token: 0x04000219 RID: 537
		SystemPageFileInformation,
		// Token: 0x0400021A RID: 538
		SystemVdmInstemulInformation,
		// Token: 0x0400021B RID: 539
		SystemVdmBopInformation,
		// Token: 0x0400021C RID: 540
		SystemFileCacheInformation,
		// Token: 0x0400021D RID: 541
		SystemPoolTagInformation,
		// Token: 0x0400021E RID: 542
		SystemInterruptInformation,
		// Token: 0x0400021F RID: 543
		SystemDpcBehaviorInformation,
		// Token: 0x04000220 RID: 544
		SystemFullMemoryInformation,
		// Token: 0x04000221 RID: 545
		SystemLoadGdiDriverInformation,
		// Token: 0x04000222 RID: 546
		SystemUnloadGdiDriverInformation,
		// Token: 0x04000223 RID: 547
		SystemTimeAdjustmentInformation,
		// Token: 0x04000224 RID: 548
		SystemSummaryMemoryInformation,
		// Token: 0x04000225 RID: 549
		SystemMirrorMemoryInformation,
		// Token: 0x04000226 RID: 550
		SystemPerformanceTraceInformation,
		// Token: 0x04000227 RID: 551
		SystemObsolete0,
		// Token: 0x04000228 RID: 552
		SystemExceptionInformation,
		// Token: 0x04000229 RID: 553
		SystemCrashDumpStateInformation,
		// Token: 0x0400022A RID: 554
		SystemKernelDebuggerInformation,
		// Token: 0x0400022B RID: 555
		SystemContextSwitchInformation,
		// Token: 0x0400022C RID: 556
		SystemRegistryQuotaInformation,
		// Token: 0x0400022D RID: 557
		SystemExtendServiceTableInformation,
		// Token: 0x0400022E RID: 558
		SystemPrioritySeperation,
		// Token: 0x0400022F RID: 559
		SystemVerifierAddDriverInformation,
		// Token: 0x04000230 RID: 560
		SystemVerifierRemoveDriverInformation,
		// Token: 0x04000231 RID: 561
		SystemProcessorIdleInformation,
		// Token: 0x04000232 RID: 562
		SystemLegacyDriverInformation,
		// Token: 0x04000233 RID: 563
		SystemCurrentTimeZoneInformation,
		// Token: 0x04000234 RID: 564
		SystemLookasideInformation,
		// Token: 0x04000235 RID: 565
		SystemTimeSlipNotification,
		// Token: 0x04000236 RID: 566
		SystemSessionCreate,
		// Token: 0x04000237 RID: 567
		SystemSessionDetach,
		// Token: 0x04000238 RID: 568
		SystemSessionInformation,
		// Token: 0x04000239 RID: 569
		SystemRangeStartInformation,
		// Token: 0x0400023A RID: 570
		SystemVerifierInformation,
		// Token: 0x0400023B RID: 571
		SystemVerifierThunkExtend,
		// Token: 0x0400023C RID: 572
		SystemSessionProcessInformation,
		// Token: 0x0400023D RID: 573
		SystemLoadGdiDriverInSystemSpace,
		// Token: 0x0400023E RID: 574
		SystemNumaProcessorMap,
		// Token: 0x0400023F RID: 575
		SystemPrefetcherInformation,
		// Token: 0x04000240 RID: 576
		SystemExtendedProcessInformation,
		// Token: 0x04000241 RID: 577
		SystemRecommendedSharedDataAlignment,
		// Token: 0x04000242 RID: 578
		SystemComPlusPackage,
		// Token: 0x04000243 RID: 579
		SystemNumaAvailableMemory,
		// Token: 0x04000244 RID: 580
		SystemProcessorPowerInformation,
		// Token: 0x04000245 RID: 581
		SystemEmulationBasicInformation,
		// Token: 0x04000246 RID: 582
		SystemEmulationProcessorInformation,
		// Token: 0x04000247 RID: 583
		SystemExtendedHandleInformation,
		// Token: 0x04000248 RID: 584
		SystemLostDelayedWriteInformation,
		// Token: 0x04000249 RID: 585
		SystemBigPoolInformation,
		// Token: 0x0400024A RID: 586
		SystemSessionPoolTagInformation,
		// Token: 0x0400024B RID: 587
		SystemSessionMappedViewInformation,
		// Token: 0x0400024C RID: 588
		SystemHotpatchInformation,
		// Token: 0x0400024D RID: 589
		SystemObjectSecurityMode,
		// Token: 0x0400024E RID: 590
		SystemWatchdogTimerHandler,
		// Token: 0x0400024F RID: 591
		SystemWatchdogTimerInformation,
		// Token: 0x04000250 RID: 592
		SystemLogicalProcessorInformation,
		// Token: 0x04000251 RID: 593
		SystemWow64SharedInformationObsolete,
		// Token: 0x04000252 RID: 594
		SystemRegisterFirmwareTableInformationHandler,
		// Token: 0x04000253 RID: 595
		SystemFirmwareTableInformation,
		// Token: 0x04000254 RID: 596
		SystemModuleInformationEx,
		// Token: 0x04000255 RID: 597
		SystemVerifierTriageInformation,
		// Token: 0x04000256 RID: 598
		SystemSuperfetchInformation,
		// Token: 0x04000257 RID: 599
		SystemMemoryListInformation,
		// Token: 0x04000258 RID: 600
		SystemFileCacheInformationEx,
		// Token: 0x04000259 RID: 601
		SystemThreadPriorityClientIdInformation,
		// Token: 0x0400025A RID: 602
		SystemProcessorIdleCycleTimeInformation,
		// Token: 0x0400025B RID: 603
		SystemVerifierCancellationInformation,
		// Token: 0x0400025C RID: 604
		SystemProcessorPowerInformationEx,
		// Token: 0x0400025D RID: 605
		SystemRefTraceInformation,
		// Token: 0x0400025E RID: 606
		SystemSpecialPoolInformation,
		// Token: 0x0400025F RID: 607
		SystemProcessIdInformation,
		// Token: 0x04000260 RID: 608
		SystemErrorPortInformation,
		// Token: 0x04000261 RID: 609
		SystemBootEnvironmentInformation,
		// Token: 0x04000262 RID: 610
		SystemHypervisorInformation,
		// Token: 0x04000263 RID: 611
		SystemVerifierInformationEx,
		// Token: 0x04000264 RID: 612
		SystemTimeZoneInformation,
		// Token: 0x04000265 RID: 613
		SystemImageFileExecutionOptionsInformation,
		// Token: 0x04000266 RID: 614
		SystemCoverageInformation,
		// Token: 0x04000267 RID: 615
		SystemPrefetchPatchInformation,
		// Token: 0x04000268 RID: 616
		SystemVerifierFaultsInformation,
		// Token: 0x04000269 RID: 617
		SystemSystemPartitionInformation,
		// Token: 0x0400026A RID: 618
		SystemSystemDiskInformation,
		// Token: 0x0400026B RID: 619
		SystemProcessorPerformanceDistribution,
		// Token: 0x0400026C RID: 620
		SystemNumaProximityNodeInformation,
		// Token: 0x0400026D RID: 621
		SystemDynamicTimeZoneInformation,
		// Token: 0x0400026E RID: 622
		SystemCodeIntegrityInformation,
		// Token: 0x0400026F RID: 623
		SystemProcessorMicrocodeUpdateInformation,
		// Token: 0x04000270 RID: 624
		SystemProcessorBrandString,
		// Token: 0x04000271 RID: 625
		SystemVirtualAddressInformation,
		// Token: 0x04000272 RID: 626
		SystemLogicalProcessorAndGroupInformation,
		// Token: 0x04000273 RID: 627
		SystemProcessorCycleTimeInformation,
		// Token: 0x04000274 RID: 628
		SystemStoreInformation,
		// Token: 0x04000275 RID: 629
		SystemRegistryAppendString,
		// Token: 0x04000276 RID: 630
		SystemAitSamplingValue,
		// Token: 0x04000277 RID: 631
		SystemVhdBootInformation,
		// Token: 0x04000278 RID: 632
		SystemCpuQuotaInformation,
		// Token: 0x04000279 RID: 633
		SystemNativeBasicInformation,
		// Token: 0x0400027A RID: 634
		SystemSpare1,
		// Token: 0x0400027B RID: 635
		SystemLowPriorityIoInformation,
		// Token: 0x0400027C RID: 636
		SystemTpmBootEntropyInformation,
		// Token: 0x0400027D RID: 637
		SystemVerifierCountersInformation,
		// Token: 0x0400027E RID: 638
		SystemPagedPoolInformationEx,
		// Token: 0x0400027F RID: 639
		SystemSystemPtesInformationEx,
		// Token: 0x04000280 RID: 640
		SystemNodeDistanceInformation,
		// Token: 0x04000281 RID: 641
		SystemAcpiAuditInformation,
		// Token: 0x04000282 RID: 642
		SystemBasicPerformanceInformation,
		// Token: 0x04000283 RID: 643
		SystemQueryPerformanceCounterInformation,
		// Token: 0x04000284 RID: 644
		SystemSessionBigPoolInformation,
		// Token: 0x04000285 RID: 645
		SystemBootGraphicsInformation,
		// Token: 0x04000286 RID: 646
		SystemScrubPhysicalMemoryInformation,
		// Token: 0x04000287 RID: 647
		SystemBadPageInformation,
		// Token: 0x04000288 RID: 648
		SystemProcessorProfileControlArea,
		// Token: 0x04000289 RID: 649
		SystemCombinePhysicalMemoryInformation,
		// Token: 0x0400028A RID: 650
		SystemEntropyInterruptTimingCallback,
		// Token: 0x0400028B RID: 651
		SystemConsoleInformation,
		// Token: 0x0400028C RID: 652
		SystemPlatformBinaryInformation,
		// Token: 0x0400028D RID: 653
		SystemThrottleNotificationInformation,
		// Token: 0x0400028E RID: 654
		SystemHypervisorProcessorCountInformation,
		// Token: 0x0400028F RID: 655
		SystemDeviceDataInformation,
		// Token: 0x04000290 RID: 656
		SystemDeviceDataEnumerationInformation,
		// Token: 0x04000291 RID: 657
		SystemMemoryTopologyInformation,
		// Token: 0x04000292 RID: 658
		SystemMemoryChannelInformation,
		// Token: 0x04000293 RID: 659
		SystemBootLogoInformation,
		// Token: 0x04000294 RID: 660
		SystemProcessorPerformanceInformationEx,
		// Token: 0x04000295 RID: 661
		SystemSpare0,
		// Token: 0x04000296 RID: 662
		SystemSecureBootPolicyInformation,
		// Token: 0x04000297 RID: 663
		SystemPageFileInformationEx,
		// Token: 0x04000298 RID: 664
		SystemSecureBootInformation,
		// Token: 0x04000299 RID: 665
		SystemEntropyInterruptTimingRawInformation,
		// Token: 0x0400029A RID: 666
		SystemPortableWorkspaceEfiLauncherInformation,
		// Token: 0x0400029B RID: 667
		SystemFullProcessInformation,
		// Token: 0x0400029C RID: 668
		SystemKernelDebuggerInformationEx,
		// Token: 0x0400029D RID: 669
		SystemBootMetadataInformation,
		// Token: 0x0400029E RID: 670
		SystemSoftRebootInformation,
		// Token: 0x0400029F RID: 671
		SystemElamCertificateInformation,
		// Token: 0x040002A0 RID: 672
		SystemOfflineDumpConfigInformation,
		// Token: 0x040002A1 RID: 673
		SystemProcessorFeaturesInformation,
		// Token: 0x040002A2 RID: 674
		SystemRegistryReconciliationInformation,
		// Token: 0x040002A3 RID: 675
		SystemEdidInformation,
		// Token: 0x040002A4 RID: 676
		MaxSystemInfoClass
	}
}
