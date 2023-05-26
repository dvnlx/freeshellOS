using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freeshellOS
{
	internal class inBuiltPrograms
	{
			private static Dictionary<string, ConsoleColor> colorDictionary;

			public static void color(string? argcol)
			{
				if(!string.IsNullOrEmpty(argcol)) { 
				InitializeColorDictionary();

				if (colorDictionary.ContainsKey(argcol))
				{
					ConsoleColor consoleColor = colorDictionary[argcol];
					Console.ForegroundColor = consoleColor;
					Console.WriteLine($"Set to {argcol!}");
				}
				else
				{
					Console.WriteLine("Invalid color name. (FS02)");
				}
				}
				else
				{
					Console.WriteLine("No color! (FS03)");
				}
			}

			private static void InitializeColorDictionary()
			{
				colorDictionary = new Dictionary<string, ConsoleColor>()
				{
					{ "black", ConsoleColor.Black },
					{ "blue", ConsoleColor.Blue },
					{ "cyan", ConsoleColor.Cyan },
					{ "gray", ConsoleColor.Gray },
					{ "green", ConsoleColor.Green },
					{ "magenta", ConsoleColor.Magenta },
					{ "red", ConsoleColor.Red },
					{ "yellow", ConsoleColor.Yellow }
				};
			}
		public static void resetColor()
		{
			Console.ResetColor();
			Console.WriteLine("Color Reset!");
		}
	}
}
