using System;

// Token: 0x02000022 RID: 34
public class GClass1
{
	// Token: 0x06000111 RID: 273 RVA: 0x005A8555 File Offset: 0x0059D155
	public GClass1()
	{
		this.uint_0 = 896891984U;
	}

	// Token: 0x06000112 RID: 274 RVA: 0x005AFCC8 File Offset: 0x005A48C8
	public uint method_0(uint uint_1)
	{
		uint num = uint_1 ^ this.uint_0;
		this.uint_0 = (GClass2.smethod_0(this.uint_0, 7) ^ num);
		return num;
	}

	// Token: 0x040002FE RID: 766
	private uint uint_0;
}
