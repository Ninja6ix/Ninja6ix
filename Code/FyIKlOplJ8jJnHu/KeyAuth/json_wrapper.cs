using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000006 RID: 6
	public class json_wrapper
	{
		// Token: 0x06000032 RID: 50 RVA: 0x005A812E File Offset: 0x0059CD2E
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x005AA934 File Offset: 0x0059F534
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x005AA9A8 File Offset: 0x0059F5A8
		public object string_to_object(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x005A815A File Offset: 0x0059CD5A
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x0400000D RID: 13
		private DataContractJsonSerializer serializer;

		// Token: 0x0400000E RID: 14
		private object current_object;
	}
}
