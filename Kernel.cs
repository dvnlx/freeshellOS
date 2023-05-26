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
						case var str when str.StartsWith("color -s"):
							input = input.Replace("color -s", "");
							color(input);
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
		public static void color(string? argcol)
		{
			if (!string.IsNullOrEmpty(argcol))
			{
				try
				{
					ConsoleColor parsedColor;
					if (Enum.TryParse(argcol, true, out parsedColor))
					{
						Console.ForegroundColor = parsedColor;
						Console.WriteLine($"Set to {argcol}");
					}
					else
					{
						Console.WriteLine("Invalid color (FS02)");
					}
				}
				catch
				{
					Console.WriteLine("Invalid color (FS02)");
				}
			}
			else
			{
				Console.WriteLine("Input color is empty (FS03)");
			}
		}
	}
}
