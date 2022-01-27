using System;
using System.IO;

// Token: 0x0200002D RID: 45
public class GClass7
{
	// Token: 0x060001A9 RID: 425 RVA: 0x005B59F8 File Offset: 0x005AA5F8
	public void method_0(uint uint_5)
	{
		if (this.uint_1 != uint_5)
		{
			this.byte_0 = new byte[uint_5];
		}
		this.uint_1 = uint_5;
		this.uint_0 = 0U;
		this.uint_2 = 0U;
	}

	// Token: 0x060001AA RID: 426 RVA: 0x005B5A50 File Offset: 0x005AA650
	public void method_1(Stream stream_1, bool bool_0)
	{
		this.method_2();
		this.stream_0 = stream_1;
		if (!bool_0)
		{
			this.uint_2 = 0U;
			this.uint_0 = 0U;
			this.uint_4 = 0U;
		}
	}

	// Token: 0x060001AB RID: 427 RVA: 0x005A8649 File Offset: 0x0059D249
	public void method_2()
	{
		this.method_3();
		this.stream_0 = null;
	}

	// Token: 0x060001AC RID: 428 RVA: 0x005B5AA4 File Offset: 0x005AA6A4
	public void method_3()
	{
		uint num = this.uint_0 - this.uint_2;
		if (num == 0U)
		{
			return;
		}
		this.stream_0.Write(this.byte_0, (int)this.uint_2, (int)num);
		if (this.uint_0 >= this.uint_1)
		{
			this.uint_0 = 0U;
		}
		this.uint_2 = this.uint_0;
	}

	// Token: 0x060001AD RID: 429 RVA: 0x005B5B28 File Offset: 0x005AA728
	public void method_4(uint uint_5, uint uint_6)
	{
		uint num = this.uint_0 - uint_5 - 1U;
		if (num >= this.uint_1)
		{
			num += this.uint_1;
		}
		while (uint_6 > 0U)
		{
			if (num >= this.uint_1)
			{
				num = 0U;
			}
			byte[] array = this.byte_0;
			uint num2 = this.uint_0;
			this.uint_0 = num2 + 1U;
			array[(int)num2] = this.byte_0[(int)num++];
			if (this.uint_0 >= this.uint_1)
			{
				this.method_3();
			}
			uint_6 -= 1U;
		}
	}

	// Token: 0x060001AE RID: 430 RVA: 0x005B5C10 File Offset: 0x005AA810
	public void method_5(byte byte_1)
	{
		byte[] array = this.byte_0;
		uint num = this.uint_0;
		this.uint_0 = num + 1U;
		array[(int)num] = byte_1;
		if (this.uint_0 >= this.uint_1)
		{
			this.method_3();
		}
	}

	// Token: 0x060001AF RID: 431 RVA: 0x005B5C6C File Offset: 0x005AA86C
	public byte method_6(uint uint_5)
	{
		uint num = this.uint_0 - uint_5 - 1U;
		if (num >= this.uint_1)
		{
			num += this.uint_1;
		}
		return this.byte_0[(int)num];
	}

	// Token: 0x04000345 RID: 837
	private byte[] byte_0;

	// Token: 0x04000346 RID: 838
	private uint uint_0;

	// Token: 0x04000347 RID: 839
	private uint uint_1;

	// Token: 0x04000348 RID: 840
	private uint uint_2;

	// Token: 0x04000349 RID: 841
	private Stream stream_0;

	// Token: 0x0400034A RID: 842
	private uint uint_3 = 1U;

	// Token: 0x0400034B RID: 843
	public uint uint_4;
}
