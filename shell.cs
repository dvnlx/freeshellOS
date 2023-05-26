using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Color = System.ConsoleColor;

namespace freeshellOS
{
	internal class shell
	{
		public static void createInstance()
		{
			bool commands = true;
			while (commands)
			{
				Console.Write("( ~/ )");
				Console.Write("> ");
				Console.Write("> ");
				Console.Write("§ ");
				string? input = Console.ReadLine();
				if (!string.IsNullOrEmpty(input))
				{

					switch (input)
					{
						case "help":
							Console.WriteLine("W.I.P");
							break;
						case "about":
							Console.WriteLine("FreeshellOS v0.1");
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
