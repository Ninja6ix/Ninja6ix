using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FyIKlOplJ8jJnHu.Properties
{
	// Token: 0x02000003 RID: 3
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.3.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x005A8870 File Offset: 0x0059D470
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x005A888C File Offset: 0x0059D48C
		// (set) Token: 0x06000009 RID: 9 RVA: 0x005A8071 File Offset: 0x0059CC71
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Login
		{
			get
			{
				return (string)this["Login"];
			}
			set
			{
				this["Login"] = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10 RVA: 0x005A88B4 File Offset: 0x0059D4B4
		// (set) Token: 0x0600000B RID: 11 RVA: 0x005A8085 File Offset: 0x0059CC85
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Password
		{
			get
			{
				return (string)this["Password"];
			}
			set
			{
				this["Password"] = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x005A88DC File Offset: 0x0059D4DC
		// (set) Token: 0x0600000D RID: 13 RVA: 0x005A8099 File Offset: 0x0059CC99
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Directory
		{
			get
			{
				return (string)this["Directory"];
			}
			set
			{
				this["Directory"] = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x005A8904 File Offset: 0x0059D504
		// (set) Token: 0x0600000F RID: 15 RVA: 0x005A80AD File Offset: 0x0059CCAD
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Clearlog
		{
			get
			{
				return (string)this["Clearlog"];
			}
			set
			{
				this["Clearlog"] = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000010 RID: 16 RVA: 0x005A892C File Offset: 0x0059D52C
		// (set) Token: 0x06000011 RID: 17 RVA: 0x005A80C1 File Offset: 0x0059CCC1
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string NorecoilDirectory
		{
			get
			{
				return (string)this["NorecoilDirectory"];
			}
			set
			{
				this["NorecoilDirectory"] = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000012 RID: 18 RVA: 0x005A8954 File Offset: 0x0059D554
		// (set) Token: 0x06000013 RID: 19 RVA: 0x005A80D5 File Offset: 0x0059CCD5
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool CheckBox
		{
			get
			{
				return (bool)this["CheckBox"];
			}
			set
			{
				this["CheckBox"] = value;
			}
		}

		// Token: 0x04000003 RID: 3
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
