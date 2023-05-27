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
							inBuiltPrograms.color(input);
							break;
						case "color -r":
							inBuiltPrograms.resetColor();
							break;
						case "clcon":
							Console.Clear();
							break;
						case "ls root":
							var directoryList = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing("0:\\");
                                Console.WriteLine("listing all files in root (0:\\)");
							foreach (var directoryEntry in directoryList)
							{
                                Console.WriteLine(directoryEntry.mName);
							}
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
