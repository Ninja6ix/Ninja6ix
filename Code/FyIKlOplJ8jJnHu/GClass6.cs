using System;
using System.IO;

// Token: 0x02000029 RID: 41
public class GClass6
{
	// Token: 0x06000197 RID: 407 RVA: 0x005B4C84 File Offset: 0x005A9884
	public GClass6()
	{
		this.uint_1 = uint.MaxValue;
		int num = 0;
		while ((long)num < 4L)
		{
			this.struct6_0[num] = new Struct6(6);
			num++;
		}
	}

	// Token: 0x06000198 RID: 408 RVA: 0x005B4DEC File Offset: 0x005A99EC
	private void method_0(uint uint_4)
	{
		if (this.uint_1 != uint_4)
		{
			this.uint_1 = uint_4;
			this.uint_2 = Math.Max(this.uint_1, 1U);
			uint uint_5 = Math.Max(this.uint_2, 4096U);
			this.gclass7_0.method_0(uint_5);
		}
	}

	// Token: 0x06000199 RID: 409 RVA: 0x005B4E5C File Offset: 0x005A9A5C
	private void method_1(int int_0, int int_1)
	{
		if (int_0 > 8)
		{
			throw new ArgumentException("lp > 8");
		}
		if (int_1 > 8)
		{
			throw new ArgumentException("lc > 8");
		}
		this.class34_0.method_0(int_0, int_1);
	}

	// Token: 0x0600019A RID: 410 RVA: 0x005B4EAC File Offset: 0x005A9AAC
	private void method_2(int int_0)
	{
		if (int_0 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = 1U << int_0;
		this.class33_0.method_0(num);
		this.class33_1.method_0(num);
		this.uint_3 = num - 1U;
	}

	// Token: 0x0600019B RID: 411 RVA: 0x005B4F1C File Offset: 0x005A9B1C
	private void method_3(Stream stream_0, Stream stream_1)
	{
		this.class35_0.method_0(stream_0);
		this.gclass7_0.method_1(stream_1, false);
		for (;;)
		{
			for (uint num = 0U; num <= this.uint_3; num += 1U)
			{
				uint num2 = 0U + num;
				this.struct5_0[(int)num2].method_0();
				this.struct5_5[(int)num2].method_0();
			}
			this.struct5_1[0].method_0();
			this.struct5_2[0].method_0();
			this.struct5_3[0].method_0();
			this.struct5_4[0].method_0();
		}
	}

	// Token: 0x0600019C RID: 412 RVA: 0x005B4FC0 File Offset: 0x005A9BC0
	public void method_4(Stream stream_0, Stream stream_1, long long_0)
	{
		this.method_3(stream_0, stream_1);
		Class32.Struct3 @struct = default(Class32.Struct3);
		@struct.method_0();
		uint num = 0U;
		uint num2 = 0U;
		uint num3 = 0U;
		uint num4 = 0U;
		ulong num5 = 0UL;
		if (0L < long_0)
		{
			if (this.struct5_0[(int)((int)@struct.uint_0 << 4)].method_1(this.class35_0) != 0U)
			{
				throw new InvalidDataException("IsMatchDecoders");
			}
			@struct.method_1();
			byte byte_ = this.class34_0.method_3(this.class35_0, 0U, 0);
			this.gclass7_0.method_5(byte_);
			num5 += 1UL;
		}
		while (num5 < (ulong)long_0)
		{
			uint num6 = (uint)num5 & this.uint_3;
			if (this.struct5_0[(int)((@struct.uint_0 << 4) + num6)].method_1(this.class35_0) == 0U)
			{
				byte byte_2 = this.gclass7_0.method_6(0U);
				byte byte_3;
				if (!@struct.method_5())
				{
					byte_3 = this.class34_0.method_4(this.class35_0, (uint)num5, byte_2, this.gclass7_0.method_6(num));
				}
				else
				{
					byte_3 = this.class34_0.method_3(this.class35_0, (uint)num5, byte_2);
				}
				this.gclass7_0.method_5(byte_3);
				@struct.method_1();
				num5 += 1UL;
			}
			else
			{
				uint num8;
				if (this.struct5_1[(int)@struct.uint_0].method_1(this.class35_0) == 1U)
				{
					if (this.struct5_2[(int)@struct.uint_0].method_1(this.class35_0) == 0U)
					{
						if (this.struct5_5[(int)((@struct.uint_0 << 4) + num6)].method_1(this.class35_0) == 0U)
						{
							@struct.method_4();
							this.gclass7_0.method_5(this.gclass7_0.method_6(num));
							num5 += 1UL;
							continue;
						}
					}
					else
					{
						uint num7;
						if (this.struct5_3[(int)@struct.uint_0].method_1(this.class35_0) == 0U)
						{
							num7 = num2;
						}
						else
						{
							if (this.struct5_4[(int)@struct.uint_0].method_1(this.class35_0) == 0U)
							{
								num7 = num3;
							}
							else
							{
								num7 = num4;
								num4 = num3;
							}
							num3 = num2;
						}
						num2 = num;
						num = num7;
					}
					num8 = this.class33_1.method_2(this.class35_0, num6) + 2U;
					@struct.method_3();
				}
				else
				{
					num4 = num3;
					num3 = num2;
					num2 = num;
					num8 = 2U + this.class33_0.method_2(this.class35_0, num6);
					@struct.method_2();
					uint num9 = this.struct6_0[(int)Class32.smethod_0(num8)].method_1(this.class35_0);
					if (num9 >= 4U)
					{
						int num10 = (int)((num9 >> 1) - 1U);
						num = (2U | (num9 & 1U)) << num10;
						if (num9 < 14U)
						{
							num += Struct6.smethod_0(this.struct5_6, num - num9 - 1U, this.class35_0, num10);
						}
						else
						{
							num += this.class35_0.method_2(num10 - 4) << 4;
							num += this.struct6_1.method_2(this.class35_0);
						}
					}
					else
					{
						num = num9;
					}
				}
				if ((ulong)num < (ulong)this.gclass7_0.uint_4 + num5 && num < this.uint_2)
				{
					this.gclass7_0.method_4(num, num8);
					num5 += (ulong)num8;
				}
				else
				{
					if (num != 4294967295U)
					{
						throw new InvalidDataException("rep0");
					}
					IL_532:
					this.gclass7_0.method_3();
					this.gclass7_0.method_2();
					this.class35_0.method_1();
					return;
				}
			}
		}
		goto IL_532;
	}

	// Token: 0x0600019D RID: 413 RVA: 0x005B552C File Offset: 0x005AA12C
	public void method_5(byte[] byte_0)
	{
		if (byte_0.Length < 5)
		{
			throw new ArgumentException("properties.Length < 5");
		}
		int int_ = (int)(byte_0[0] % 9);
		byte b = byte_0[0] / 9;
		int int_2 = (int)(b % 5);
		int num = (int)(b / 5);
		if (num > 4)
		{
			throw new ArgumentException("pb > Base.kNumPosStatesBitsMax");
		}
		uint num2 = 0U;
		for (int i = 0; i < 4; i++)
		{
			num2 += (uint)((uint)byte_0[1 + i] << i * 8);
		}
		this.method_0(num2);
		this.method_1(int_2, int_);
		this.method_2(num);
	}

	// Token: 0x04000328 RID: 808
	private uint uint_0 = 1U;

	// Token: 0x04000329 RID: 809
	private readonly GClass7 gclass7_0 = new GClass7();

	// Token: 0x0400032A RID: 810
	private readonly Class35 class35_0 = new Class35();

	// Token: 0x0400032B RID: 811
	private readonly Struct5[] struct5_0 = new Struct5[192];

	// Token: 0x0400032C RID: 812
	private readonly Struct5[] struct5_1 = new Struct5[12];

	// Token: 0x0400032D RID: 813
	private readonly Struct5[] struct5_2 = new Struct5[12];

	// Token: 0x0400032E RID: 814
	private readonly Struct5[] struct5_3 = new Struct5[12];

	// Token: 0x0400032F RID: 815
	private readonly Struct5[] struct5_4 = new Struct5[12];

	// Token: 0x04000330 RID: 816
	private readonly Struct5[] struct5_5 = new Struct5[192];

	// Token: 0x04000331 RID: 817
	private readonly Struct6[] struct6_0 = new Struct6[4];

	// Token: 0x04000332 RID: 818
	private readonly Struct5[] struct5_6 = new Struct5[114];

	// Token: 0x04000333 RID: 819
	private Struct6 struct6_1 = new Struct6(4);

	// Token: 0x04000334 RID: 820
	private readonly GClass6.Class33 class33_0 = new GClass6.Class33();

	// Token: 0x04000335 RID: 821
	private readonly GClass6.Class33 class33_1 = new GClass6.Class33();

	// Token: 0x04000336 RID: 822
	private readonly GClass6.Class34 class34_0 = new GClass6.Class34();

	// Token: 0x04000337 RID: 823
	private uint uint_1;

	// Token: 0x04000338 RID: 824
	private uint uint_2;

	// Token: 0x04000339 RID: 825
	private uint uint_3;

	// Token: 0x02000051 RID: 81
	private class Class33
	{
		// Token: 0x06000335 RID: 821 RVA: 0x005B89FC File Offset: 0x005AD5FC
		public void method_0(uint uint_1)
		{
			for (uint num = this.uint_0; num < uint_1; num += 1U)
			{
				this.struct6_0[(int)num] = new Struct6(3);
				this.struct6_1[(int)num] = new Struct6(3);
			}
			this.uint_0 = uint_1;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x005B8A78 File Offset: 0x005AD678
		public void method_1()
		{
			this.struct5_0.method_0();
			while (0U < this.uint_0)
			{
				this.struct6_0[0].method_0();
				this.struct6_1[0].method_0();
			}
			this.struct5_1.method_0();
			this.struct6_2.method_0();
		}

		// Token: 0x06000337 RID: 823 RVA: 0x005B8AD4 File Offset: 0x005AD6D4
		public uint method_2(Class35 class35_0, uint uint_1)
		{
			if (this.struct5_0.method_1(class35_0) == 0U)
			{
				return this.struct6_0[(int)uint_1].method_1(class35_0);
			}
			uint num = 8U;
			if (this.struct5_1.method_1(class35_0) == 0U)
			{
				num += this.struct6_1[(int)uint_1].method_1(class35_0);
			}
			else
			{
				num += 8U;
				num += this.struct6_2.method_1(class35_0);
			}
			return num;
		}

		// Token: 0x04000384 RID: 900
		private Struct5 struct5_0;

		// Token: 0x04000385 RID: 901
		private Struct5 struct5_1;

		// Token: 0x04000386 RID: 902
		private readonly Struct6[] struct6_0 = new Struct6[16];

		// Token: 0x04000387 RID: 903
		private readonly Struct6[] struct6_1 = new Struct6[16];

		// Token: 0x04000388 RID: 904
		private Struct6 struct6_2 = new Struct6(8);

		// Token: 0x04000389 RID: 905
		private uint uint_0;
	}

	// Token: 0x02000052 RID: 82
	private class Class34
	{
		// Token: 0x06000339 RID: 825 RVA: 0x005B8BD4 File Offset: 0x005AD7D4
		public void method_0(int int_2, int int_3)
		{
			if (this.struct4_0 != null && this.int_0 == int_3 && this.int_1 == int_2)
			{
				return;
			}
			this.int_1 = int_2;
			this.uint_1 = (1U << int_2) - 1U;
			this.int_0 = int_3;
			uint num = 1U << this.int_0 + this.int_1;
			this.struct4_0 = new GClass6.Class34.Struct4[num];
			while (0U < num)
			{
				this.struct4_0[0].method_0();
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x005B8C50 File Offset: 0x005AD850
		public void method_1()
		{
			uint num = 1U << this.int_0 + this.int_1;
			while (0U < num)
			{
				this.struct4_0[0].method_1();
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x005A870E File Offset: 0x0059D30E
		private uint method_2(uint uint_2, byte byte_0)
		{
			return ((uint_2 & this.uint_1) << this.int_0) + (uint)(byte_0 >> 8 - this.int_0);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x005A8749 File Offset: 0x0059D349
		public byte method_3(Class35 class35_0, uint uint_2, byte byte_0)
		{
			return this.struct4_0[(int)this.method_2(uint_2, byte_0)].method_2(class35_0);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x005A8773 File Offset: 0x0059D373
		public byte method_4(Class35 class35_0, uint uint_2, byte byte_0, byte byte_1)
		{
			return this.struct4_0[(int)this.method_2(uint_2, byte_0)].method_3(class35_0, byte_1);
		}

		// Token: 0x0400038A RID: 906
		private uint uint_0 = 1U;

		// Token: 0x0400038B RID: 907
		private GClass6.Class34.Struct4[] struct4_0;

		// Token: 0x0400038C RID: 908
		private int int_0;

		// Token: 0x0400038D RID: 909
		private int int_1;

		// Token: 0x0400038E RID: 910
		private uint uint_1;

		// Token: 0x02000053 RID: 83
		private struct Struct4
		{
			// Token: 0x0600033F RID: 831 RVA: 0x005A87BA File Offset: 0x0059D3BA
			public void method_0()
			{
				this.struct5_0 = new Struct5[768];
			}

			// Token: 0x06000340 RID: 832 RVA: 0x005B8C88 File Offset: 0x005AD888
			public void method_1()
			{
				for (int i = 0; i < 768; i++)
				{
					this.struct5_0[i].method_0();
				}
			}

			// Token: 0x06000341 RID: 833 RVA: 0x005B8CD0 File Offset: 0x005AD8D0
			public byte method_2(Class35 class35_0)
			{
				uint num = 1U;
				do
				{
					num = (num << 1 | this.struct5_0[(int)num].method_1(class35_0));
				}
				while (num < 256U);
				return (byte)num;
			}

			// Token: 0x06000342 RID: 834 RVA: 0x005B8D20 File Offset: 0x005AD920
			public byte method_3(Class35 class35_0, byte byte_0)
			{
				uint num = 1U;
				for (;;)
				{
					uint num2 = (uint)(byte_0 >> 7 & 1);
					byte_0 = (byte)(byte_0 << 1);
					uint num3 = this.struct5_0[(int)((1U + num2 << 8) + num)].method_1(class35_0);
					num = (num << 1 | num3);
					if (num2 != num3)
					{
						break;
					}
					if (num >= 256U)
					{
						goto IL_C0;
					}
				}
				while (num < 256U)
				{
					num = (num << 1 | this.struct5_0[(int)num].method_1(class35_0));
				}
				IL_C0:
				return (byte)num;
			}

			// Token: 0x0400038F RID: 911
			private Struct5[] struct5_0;
		}
	}
}
