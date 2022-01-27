using System;
using System.IO;

// Token: 0x0200002A RID: 42
internal class Class35
{
	// Token: 0x0600019E RID: 414 RVA: 0x005B5624 File Offset: 0x005AA224
	public void method_0(Stream stream_1)
	{
		this.stream_0 = stream_1;
		this.uint_3 = 0U;
		this.uint_2 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			this.uint_3 = (this.uint_3 << 8 | (uint)((byte)this.stream_0.ReadByte()));
		}
	}

	// Token: 0x0600019F RID: 415 RVA: 0x005A85E7 File Offset: 0x0059D1E7
	public void method_1()
	{
		this.stream_0 = null;
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x005B56A8 File Offset: 0x005AA2A8
	public uint method_2(int int_0)
	{
		uint num = this.uint_2;
		uint num2 = this.uint_3;
		uint num3 = 0U;
		for (int i = int_0; i > 0; i--)
		{
			num >>= 1;
			uint num4 = num2 - num >> 31;
			num2 -= (num & num4 - 1U);
			num3 = (num3 << 1 | 1U - num4);
			if (num < 16777216U)
			{
				num2 = (num2 << 8 | (uint)((byte)this.stream_0.ReadByte()));
				num <<= 8;
			}
		}
		this.uint_2 = num;
		this.uint_3 = num2;
		return num3;
	}

	// Token: 0x0400033A RID: 826
	private uint uint_0 = 1U;

	// Token: 0x0400033B RID: 827
	public const uint uint_1 = 16777216U;

	// Token: 0x0400033C RID: 828
	public uint uint_2;

	// Token: 0x0400033D RID: 829
	public uint uint_3;

	// Token: 0x0400033E RID: 830
	public Stream stream_0;
}
