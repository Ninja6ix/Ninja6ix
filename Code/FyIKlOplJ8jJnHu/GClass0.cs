using System;
using System.Runtime.InteropServices;

// Token: 0x02000021 RID: 33
public class GClass0
{
	// Token: 0x0600010F RID: 271 RVA: 0x005AFBBC File Offset: 0x005A47BC
	public GClass0()
	{
		if (GClass0.uint_0 == null)
		{
			GClass0.uint_0 = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ 3988292384U);
					}
					else
					{
						num >>= 1;
					}
				}
				GClass0.uint_0[i] = num;
			}
		}
	}

	// Token: 0x06000110 RID: 272 RVA: 0x005AFC84 File Offset: 0x005A4884
	public uint method_0(IntPtr intptr_0, uint uint_1)
	{
		int num = 0;
		while ((long)num < (long)((ulong)uint_1))
		{
			uint num2 = GClass0.uint_0[(int)((Marshal.ReadByte(new IntPtr(intptr_0.ToInt64() + (long)num)) ^ 0) & byte.MaxValue)] ^ 0U;
			num++;
		}
		return uint.MaxValue;
	}

	// Token: 0x040002FD RID: 765
	private static uint[] uint_0;
}
