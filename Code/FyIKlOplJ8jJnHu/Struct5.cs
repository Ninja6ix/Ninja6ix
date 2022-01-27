using System;

// Token: 0x0200002B RID: 43
internal struct Struct5
{
	// Token: 0x060001A2 RID: 418 RVA: 0x005A860C File Offset: 0x0059D20C
	public void method_0()
	{
		this.uint_1 = 1024U;
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x005B57A8 File Offset: 0x005AA3A8
	public uint method_1(Class35 class35_0)
	{
		uint num = (class35_0.uint_2 >> 11) * this.uint_1;
		if (class35_0.uint_3 < num)
		{
			class35_0.uint_2 = num;
			this.uint_1 += 2048U - this.uint_1 >> 5;
			if (class35_0.uint_2 < 16777216U)
			{
				class35_0.uint_3 = (class35_0.uint_3 << 8 | (uint)((byte)class35_0.stream_0.ReadByte()));
				class35_0.uint_2 <<= 8;
			}
			return 0U;
		}
		class35_0.uint_2 -= num;
		class35_0.uint_3 -= num;
		this.uint_1 -= this.uint_1 >> 5;
		if (class35_0.uint_2 < 16777216U)
		{
			class35_0.uint_3 = (class35_0.uint_3 << 8 | (uint)((byte)class35_0.stream_0.ReadByte()));
			class35_0.uint_2 <<= 8;
		}
		return 1U;
	}

	// Token: 0x0400033F RID: 831
	private const int int_0 = 11;

	// Token: 0x04000340 RID: 832
	private const uint uint_0 = 2048U;

	// Token: 0x04000341 RID: 833
	private const int int_1 = 5;

	// Token: 0x04000342 RID: 834
	private uint uint_1;
}
