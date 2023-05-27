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
		public static void createInstance(string name, string pcname)
		{
			bool commands = true;
			while (commands)
			{
				Console.Write($"( {name}@{pcname} )");
				Console.Write("> ");
				Console.Write("> ");
				Console.Write("§ ");
				string? input = Console.ReadLine();
				if (!string.IsNullOrEmpty(input))
				{

					switch (input)
					{
						case "help":
							Console.WriteLine("freeshellOS v0.1 Help");
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
