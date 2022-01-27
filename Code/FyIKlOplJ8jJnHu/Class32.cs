using System;

// Token: 0x02000028 RID: 40
internal abstract class Class32
{
	// Token: 0x06000195 RID: 405 RVA: 0x005A85C2 File Offset: 0x0059D1C2
	public static uint smethod_0(uint uint_9)
	{
		uint_9 -= 2U;
		if (uint_9 < 4U)
		{
			return uint_9;
		}
		return 3U;
	}

	// Token: 0x04000318 RID: 792
	public const uint uint_0 = 12U;

	// Token: 0x04000319 RID: 793
	public const int int_0 = 6;

	// Token: 0x0400031A RID: 794
	private const int int_1 = 2;

	// Token: 0x0400031B RID: 795
	public const uint uint_1 = 4U;

	// Token: 0x0400031C RID: 796
	public const uint uint_2 = 2U;

	// Token: 0x0400031D RID: 797
	public const int int_2 = 4;

	// Token: 0x0400031E RID: 798
	public const uint uint_3 = 4U;

	// Token: 0x0400031F RID: 799
	public const uint uint_4 = 14U;

	// Token: 0x04000320 RID: 800
	public const uint uint_5 = 128U;

	// Token: 0x04000321 RID: 801
	public const int int_3 = 4;

	// Token: 0x04000322 RID: 802
	public const uint uint_6 = 16U;

	// Token: 0x04000323 RID: 803
	public const int int_4 = 3;

	// Token: 0x04000324 RID: 804
	public const int int_5 = 3;

	// Token: 0x04000325 RID: 805
	public const int int_6 = 8;

	// Token: 0x04000326 RID: 806
	public const uint uint_7 = 8U;

	// Token: 0x04000327 RID: 807
	public const uint uint_8 = 8U;

	// Token: 0x02000050 RID: 80
	public struct Struct3
	{
		// Token: 0x0600032F RID: 815 RVA: 0x005A8677 File Offset: 0x0059D277
		public void method_0()
		{
			this.uint_0 = 0U;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x005B898C File Offset: 0x005AD58C
		public void method_1()
		{
			if (this.uint_0 < 4U)
			{
				this.uint_0 = 0U;
				return;
			}
			if (this.uint_0 < 10U)
			{
				this.uint_0 -= 3U;
				return;
			}
			this.uint_0 -= 6U;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x005A8687 File Offset: 0x0059D287
		public void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 7U : 10U);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x005A86AE File Offset: 0x0059D2AE
		public void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 8U : 11U);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x005A86D5 File Offset: 0x0059D2D5
		public void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 9U : 11U);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x005A86FC File Offset: 0x0059D2FC
		public bool method_5()
		{
			return this.uint_0 < 7U;
		}

		// Token: 0x04000383 RID: 899
		public uint uint_0;
	}
}
