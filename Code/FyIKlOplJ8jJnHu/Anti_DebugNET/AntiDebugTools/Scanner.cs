using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace Anti_DebugNET.AntiDebugTools
{
	// Token: 0x02000017 RID: 23
	internal class Scanner
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x005AF710 File Offset: 0x005A4310
		public static void ScanAndKill()
		{
			if (Scanner.Scan(true) != 0)
			{
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x005AF730 File Offset: 0x005A4330
		private static int Scan(bool KillProcess)
		{
			int result = 0;
			if (Scanner.BadProcessnameList.Count == 0 && Scanner.BadWindowTextList.Count == 0)
			{
				Scanner.Init();
			}
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (Scanner.BadProcessnameList.Contains(process.ProcessName) || Scanner.BadWindowTextList.Contains(process.MainWindowTitle))
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("BAD PROCESS FOUND: " + process.ProcessName);
					result = 1;
					if (KillProcess)
					{
						try
						{
							process.Kill();
						}
						catch (Win32Exception ex)
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.Write("Win32Exception: " + ex.Message);
						}
						catch (NotSupportedException ex2)
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.Write("NotSupportedException: " + ex2.Message);
						}
						catch (InvalidOperationException ex3)
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.Write("InvalidOperationException: " + ex3.Message);
						}
					}
					return result;
				}
			}
			return result;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x005AF8D8 File Offset: 0x005A44D8
		private static int Init()
		{
			int result;
			if (Scanner.BadProcessnameList.Count > 0 && Scanner.BadWindowTextList.Count > 0)
			{
				result = 1;
			}
			else
			{
				Scanner.BadProcessnameList.Add("ollydbg");
				Scanner.BadProcessnameList.Add("ida");
				Scanner.BadProcessnameList.Add("ida64");
				Scanner.BadProcessnameList.Add("idag");
				Scanner.BadProcessnameList.Add("idag64");
				Scanner.BadProcessnameList.Add("idaw");
				Scanner.BadProcessnameList.Add("idaw64");
				Scanner.BadProcessnameList.Add("idaq");
				Scanner.BadProcessnameList.Add("idaq64");
				Scanner.BadProcessnameList.Add("idau");
				Scanner.BadProcessnameList.Add("idau64");
				Scanner.BadProcessnameList.Add("scylla");
				Scanner.BadProcessnameList.Add("scylla_x64");
				Scanner.BadProcessnameList.Add("scylla_x86");
				Scanner.BadProcessnameList.Add("protection_id");
				Scanner.BadProcessnameList.Add("x64dbg");
				Scanner.BadProcessnameList.Add("x32dbg");
				Scanner.BadProcessnameList.Add("windbg");
				Scanner.BadProcessnameList.Add("reshacker");
				Scanner.BadProcessnameList.Add("ImportREC");
				Scanner.BadProcessnameList.Add("IMMUNITYDEBUGGER");
				Scanner.BadProcessnameList.Add("MegaDumper");
				Scanner.BadWindowTextList.Add("HTTPDebuggerUI");
				Scanner.BadWindowTextList.Add("HTTPDebuggerSvc");
				Scanner.BadWindowTextList.Add("HTTP Debugger");
				Scanner.BadWindowTextList.Add("HTTP Debugger (32 bit)");
				Scanner.BadWindowTextList.Add("HTTP Debugger (64 bit)");
				Scanner.BadWindowTextList.Add("OLLYDBG");
				Scanner.BadWindowTextList.Add("ida");
				Scanner.BadWindowTextList.Add("disassembly");
				Scanner.BadWindowTextList.Add("scylla");
				Scanner.BadWindowTextList.Add("Debug");
				Scanner.BadWindowTextList.Add("[CPU");
				Scanner.BadWindowTextList.Add("Immunity");
				Scanner.BadWindowTextList.Add("WinDbg");
				Scanner.BadWindowTextList.Add("x32dbg");
				Scanner.BadWindowTextList.Add("x64dbg");
				Scanner.BadWindowTextList.Add("Import reconstructor");
				Scanner.BadWindowTextList.Add("MegaDumper");
				Scanner.BadWindowTextList.Add("MegaDumper 1.0 by CodeCracker / SnD");
				Scanner.BadWindowTextList.Add("Edge");
				result = 0;
			}
			return result;
		}

		// Token: 0x040002DE RID: 734
		private static HashSet<string> BadProcessnameList = new HashSet<string>();

		// Token: 0x040002DF RID: 735
		private static HashSet<string> BadWindowTextList = new HashSet<string>();
	}
}
