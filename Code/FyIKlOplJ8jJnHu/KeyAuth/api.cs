using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000004 RID: 4
	public class api
	{
		// Token: 0x06000016 RID: 22 RVA: 0x005A8974 File Offset: 0x0059D574
		public api(string name, string ownerid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				api.error("Application not setup correctly. Please watch video link found in Program.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x005A8A28 File Offset: 0x0059D628
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			if (text2 == "KeyAuth_Invalid")
			{
				api.error("Application not found");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (response_structure.success)
			{
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
			}
			else if (response_structure.message == "invalidver")
			{
				Process.Start(response_structure.download);
				Environment.Exit(0);
			}
			else
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x005A8C14 File Offset: 0x0059D814
		public void register(string username, string pass, string key)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
			else
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x005A8E08 File Offset: 0x0059DA08
		public void login(string username, string pass)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
			else
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x005A8FDC File Offset: 0x0059DBDC
		public void upgrade(string username, string key)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x005A9178 File Offset: 0x0059DD78
		public void license(string key)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
			else
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x005A932C File Offset: 0x0059DF2C
		public void setvar(string var, string data)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["data"] = encryption.encrypt(data, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x005A94B8 File Offset: 0x0059E0B8
		public string getvar(string var)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			string result;
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				result = null;
			}
			else
			{
				result = response_structure.response;
			}
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x005A963C File Offset: 0x0059E23C
		public void ban()
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x005A9784 File Offset: 0x0059E384
		public string var(string varid)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			string result;
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				result = null;
			}
			else
			{
				result = response_structure.message;
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x005A9918 File Offset: 0x0059E518
		public List<api.msg> chatget(string channelname)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			List<api.msg> result;
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				result = null;
			}
			else
			{
				result = response_structure.messages;
			}
			return result;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x005A9A9C File Offset: 0x0059E69C
		public bool chatsend(string msg, string channelname)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(msg, this.enckey, text);
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool result;
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x005A9C34 File Offset: 0x0059E834
		public bool checkblack()
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			return response_structure.success;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x005A9DB0 File Offset: 0x0059E9B0
		public void webhook(string webid, string param)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
			nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x005A9F3C File Offset: 0x0059EB3C
		public byte[] download(string fileid)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first. File is empty since no request could be made.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
			return encryption.str_to_byte_arr(response_structure.contents);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x005AA0BC File Offset: 0x0059ECBC
		public void log(string message)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
			nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			api.req(post_data);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x005AA1EC File Offset: 0x0059EDEC
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x005AA290 File Offset: 0x0059EE90
		public static void error(string message)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x005AA2F8 File Offset: 0x0059EEF8
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != (HttpStatusCode)429)
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error("You're connecting too fast to loader, slow down.");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x005AA3E0 File Offset: 0x0059EFE0
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x04000004 RID: 4
		public string name;

		// Token: 0x04000005 RID: 5
		public string ownerid;

		// Token: 0x04000006 RID: 6
		public string secret;

		// Token: 0x04000007 RID: 7
		public string version;

		// Token: 0x04000008 RID: 8
		private string sessionid;

		// Token: 0x04000009 RID: 9
		private string enckey;

		// Token: 0x0400000A RID: 10
		private bool initzalized;

		// Token: 0x0400000B RID: 11
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x0400000C RID: 12
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x02000019 RID: 25
		[DataContract]
		private class response_structure
		{
			// Token: 0x1700000B RID: 11
			// (get) Token: 0x060000D6 RID: 214 RVA: 0x005A82B1 File Offset: 0x0059CEB1
			// (set) Token: 0x060000D7 RID: 215 RVA: 0x005A82BC File Offset: 0x0059CEBC
			[DataMember]
			public bool success { get; set; }

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x060000D8 RID: 216 RVA: 0x005A82CB File Offset: 0x0059CECB
			// (set) Token: 0x060000D9 RID: 217 RVA: 0x005A82D6 File Offset: 0x0059CED6
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x060000DA RID: 218 RVA: 0x005A82E5 File Offset: 0x0059CEE5
			// (set) Token: 0x060000DB RID: 219 RVA: 0x005A82F0 File Offset: 0x0059CEF0
			[DataMember]
			public string contents { get; set; }

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x060000DC RID: 220 RVA: 0x005A82FF File Offset: 0x0059CEFF
			// (set) Token: 0x060000DD RID: 221 RVA: 0x005A830A File Offset: 0x0059CF0A
			[DataMember]
			public string response { get; set; }

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x060000DE RID: 222 RVA: 0x005A8319 File Offset: 0x0059CF19
			// (set) Token: 0x060000DF RID: 223 RVA: 0x005A8324 File Offset: 0x0059CF24
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x005A8333 File Offset: 0x0059CF33
			// (set) Token: 0x060000E1 RID: 225 RVA: 0x005A833E File Offset: 0x0059CF3E
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x005A834D File Offset: 0x0059CF4D
			// (set) Token: 0x060000E3 RID: 227 RVA: 0x005A8358 File Offset: 0x0059CF58
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x005A8367 File Offset: 0x0059CF67
			// (set) Token: 0x060000E5 RID: 229 RVA: 0x005A8372 File Offset: 0x0059CF72
			[DataMember]
			public List<api.msg> messages { get; set; }
		}

		// Token: 0x0200001A RID: 26
		public class msg
		{
			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060000E7 RID: 231 RVA: 0x005A8381 File Offset: 0x0059CF81
			// (set) Token: 0x060000E8 RID: 232 RVA: 0x005A838C File Offset: 0x0059CF8C
			public string message { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060000E9 RID: 233 RVA: 0x005A839B File Offset: 0x0059CF9B
			// (set) Token: 0x060000EA RID: 234 RVA: 0x005A83A6 File Offset: 0x0059CFA6
			public string author { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060000EB RID: 235 RVA: 0x005A83B5 File Offset: 0x0059CFB5
			// (set) Token: 0x060000EC RID: 236 RVA: 0x005A83C0 File Offset: 0x0059CFC0
			public string timestamp { get; set; }
		}

		// Token: 0x0200001B RID: 27
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000016 RID: 22
			// (get) Token: 0x060000EE RID: 238 RVA: 0x005A83CF File Offset: 0x0059CFCF
			// (set) Token: 0x060000EF RID: 239 RVA: 0x005A83DA File Offset: 0x0059CFDA
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x060000F0 RID: 240 RVA: 0x005A83E9 File Offset: 0x0059CFE9
			// (set) Token: 0x060000F1 RID: 241 RVA: 0x005A83F4 File Offset: 0x0059CFF4
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x060000F2 RID: 242 RVA: 0x005A8403 File Offset: 0x0059D003
			// (set) Token: 0x060000F3 RID: 243 RVA: 0x005A840E File Offset: 0x0059D00E
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060000F4 RID: 244 RVA: 0x005A841D File Offset: 0x0059D01D
			// (set) Token: 0x060000F5 RID: 245 RVA: 0x005A8428 File Offset: 0x0059D028
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060000F6 RID: 246 RVA: 0x005A8437 File Offset: 0x0059D037
			// (set) Token: 0x060000F7 RID: 247 RVA: 0x005A8442 File Offset: 0x0059D042
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000F8 RID: 248 RVA: 0x005A8451 File Offset: 0x0059D051
			// (set) Token: 0x060000F9 RID: 249 RVA: 0x005A845C File Offset: 0x0059D05C
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200001C RID: 28
		public class user_data_class
		{
			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000FB RID: 251 RVA: 0x005A846B File Offset: 0x0059D06B
			// (set) Token: 0x060000FC RID: 252 RVA: 0x005A8476 File Offset: 0x0059D076
			public string username { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000FD RID: 253 RVA: 0x005A8485 File Offset: 0x0059D085
			// (set) Token: 0x060000FE RID: 254 RVA: 0x005A8490 File Offset: 0x0059D090
			public string ip { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000FF RID: 255 RVA: 0x005A849F File Offset: 0x0059D09F
			// (set) Token: 0x06000100 RID: 256 RVA: 0x005A84AA File Offset: 0x0059D0AA
			public string hwid { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000101 RID: 257 RVA: 0x005A84B9 File Offset: 0x0059D0B9
			// (set) Token: 0x06000102 RID: 258 RVA: 0x005A84C4 File Offset: 0x0059D0C4
			public string createdate { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000103 RID: 259 RVA: 0x005A84D3 File Offset: 0x0059D0D3
			// (set) Token: 0x06000104 RID: 260 RVA: 0x005A84DE File Offset: 0x0059D0DE
			public string lastlogin { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x06000105 RID: 261 RVA: 0x005A84ED File Offset: 0x0059D0ED
			// (set) Token: 0x06000106 RID: 262 RVA: 0x005A84F8 File Offset: 0x0059D0F8
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200001D RID: 29
		public class Data
		{
			// Token: 0x17000022 RID: 34
			// (get) Token: 0x06000108 RID: 264 RVA: 0x005A8507 File Offset: 0x0059D107
			// (set) Token: 0x06000109 RID: 265 RVA: 0x005A8512 File Offset: 0x0059D112
			public string subscription { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x0600010A RID: 266 RVA: 0x005A8521 File Offset: 0x0059D121
			// (set) Token: 0x0600010B RID: 267 RVA: 0x005A852C File Offset: 0x0059D12C
			public string expiry { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x0600010C RID: 268 RVA: 0x005A853B File Offset: 0x0059D13B
			// (set) Token: 0x0600010D RID: 269 RVA: 0x005A8546 File Offset: 0x0059D146
			public string timeleft { get; set; }
		}
	}
}
