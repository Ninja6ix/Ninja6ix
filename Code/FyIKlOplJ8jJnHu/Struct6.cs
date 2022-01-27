using System;

// Token: 0x0200002C RID: 44
internal struct Struct6
{
	// Token: 0x060001A4 RID: 420 RVA: 0x005A861C File Offset: 0x0059D21C
	public Struct6(int int_1)
	{
		this.int_0 = int_1;
		this.struct5_0 = new Struct5[1 << int_1];
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x005B5908 File Offset: 0x005AA508
	public void method_0()
	{
		while (1L < 1L << (this.int_0 & 31))
		{
			this.struct5_0[1].method_0();
		}
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x005B5940 File Offset: 0x005AA540
	public uint method_1(Class35 class35_0)
	{
		for (int i = this.int_0; i > 0; i--)
		{
			uint num = 2U + this.struct5_0[1].method_1(class35_0);
		}
		return 1U - (1U << this.int_0);
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x005B5980 File Offset: 0x005AA580
	public uint method_2(Class35 class35_0)
	{
		uint num = 0U;
		for (int i = 0; i < this.int_0; i++)
		{
			uint num2 = this.struct5_0[1].method_1(class35_0);
			num |= num2 << i;
		}
		return num;
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x005B59C0 File Offset: 0x005AA5C0
	public static uint smethod_0(Struct5[] struct5_1, uint uint_0, Class35 class35_0, int int_1)
	{
		uint num = 0U;
		for (int i = 0; i < int_1; i++)
		{
			uint num2 = struct5_1[(int)(uint_0 + 1U)].method_1(class35_0);
			num |= num2 << i;
		}
		return num;
	}

	// Token: 0x04000343 RID: 835
	private readonly Struct5[] struct5_0;

	// Token: 0x04000344 RID: 836
	private readonly int int_0;
}
