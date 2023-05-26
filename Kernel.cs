using System;
using System.Drawing;
using System.Diagnostics;
using Color = System.ConsoleColor;
using Sys = Cosmos.System;
using System.Threading;

namespace freeshellOS
{
	public class Kernel : Sys.Kernel
	{

		protected override void BeforeRun()
		{
			Console.WriteLine("Welcome to freeshellOS 0.1");
		}

		protected override void Run()
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
						case "exit":
							Console.ForegroundColor = Color.White;
							Console.WriteLine("Bye!");
							commands = false;
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
