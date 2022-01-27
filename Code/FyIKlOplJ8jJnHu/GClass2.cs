using System;

// Token: 0x02000023 RID: 35
public class GClass2
{
	// Token: 0x06000113 RID: 275 RVA: 0x005AFD0C File Offset: 0x005A490C
	public static uint smethod_0(uint uint_0, int int_1)
	{
		uint num = uint_0 << int_1;
		uint num2 = uint_0 >> 32 - int_1;
		return num | num2;
	}

	// Token: 0x040002FF RID: 767
	public const int int_0 = 32;
}
