using System;
using System.Drawing;
using System.Diagnostics;
using Color = System.ConsoleColor;
using Sys = Cosmos.System;
using System.Threading;
using Cosmos.System;
using Cosmos.System.ScanMaps;
using System.IO;
using Console = System.Console;
using freeshellOS.commands;

namespace freeshellOS
{
	internal class shell
	{
		public static void createInstance(string name, string pcname, string filePath)
		{
			bool commands = true;
			while (commands)
			{	if (!string.IsNullOrEmpty(filePath)) {
					Console.Write($"( {name}@{pcname} at {filePath})");
				}
				else
				{
					Console.Write($"( {name}@{pcname} no path)");
				}
				Console.Write("> ");
				Console.Write("> ");
				Console.Write("§ ");
				string? input = Console.ReadLine();
				if (!string.IsNullOrEmpty(input))
				{

					switch (input)
					{
						case "help":
							Console.WriteLine("freeshellOS v0.2 Help");
							Console.WriteLine("hello: Shows Hello World (for testing)");
							Console.WriteLine("shutdown: shuts the system down");
							Console.WriteLine("reboot: reboots the system");
							Console.WriteLine("color -s: changes color: all colors: blue, cyan, gray, green, magenta, red and yellow. \n EXAMPLE: color -s red");
							Console.WriteLine("color -r: resets color to white");
							Console.WriteLine("clcon: clears console");
							Console.WriteLine("ls root -F: shows all files in root (0:\\)");
							Console.WriteLine("ls root -f: shows all folders in root (0:\\)");
							Console.WriteLine("dskinf: shows info about the disk");
							Console.WriteLine("kbdmap -s: changes Keyboard Mapping \n All options: de, en-us and fr. \n EXAMPLE: kbdmap -s de");
							Console.WriteLine("kbdmap -c: shows current keyboard mapping.");
							break;
						case "hello":
							System.Console.WriteLine("Hello World!");
							break;
						case "shutdown":
							Console.Clear();
							System.Console.WriteLine("Goodbye!");
							Thread.Sleep(1000);
							Cosmos.System.Power.Shutdown();
							break;
						case "reboot":
							Console.Clear();
							Console.WriteLine("Rebooting...");
							Thread.Sleep(1000);
							Cosmos.System.Power.Shutdown();
							break;
						case var str when str.StartsWith("color -s"):
							input = input.Replace("color -s ", "");
							color.Run(input);
							break;
						case "color -r":
							color.resetColor();
							break;
						case "clcon":
							Console.Clear();
							break;
						case "ls root -F":
							var fileList = Directory.GetFiles("0:\\");
							Console.WriteLine("listing all files in root (0:\\)");
							foreach (var directoryEntry in fileList)
							{
								Console.WriteLine(directoryEntry);
							}
							break;
						case "ls root -f":
							var directoryList = Directory.GetFiles("0:\\");
							Console.WriteLine("listing all folders in root (0:\\)");
							foreach (var directoryEntry in directoryList)
							{
								Console.WriteLine(directoryEntry);
							}
							break;
						case "dskinf":
							Console.WriteLine("Disk Info");
							long availableSpace = Sys.FileSystem.VFS.VFSManager.GetAvailableFreeSpace("0:\\");
							Console.WriteLine("Available Free Space (In Bytes): " + availableSpace);
							string fsType = Sys.FileSystem.VFS.VFSManager.GetFileSystemType("0:\\");
							Console.WriteLine("File System Type: " + fsType);
							break;
						case var str when str.StartsWith("kbdmap -s"):
							input = input.Replace("kbdmap -s ", "");
							kbdmap.setKBD(input);
							break;
						case "kbdmap -c":
							kbdmap.getCurrentKBD();
							break;
						case "sysinfo":
							sysinfo.showinfo();
							break;
						default:
							Console.WriteLine($"{input} Not Found. Type help for help. (FS01)");
							break;
					}
				}
				else
				{
					System.Console.WriteLine("No command entered (FS05)");
				}
			}
		}
	}
}
