using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freeshellOS.boot
{
	internal class oobe
	{
		public static void init()
		{
			// File.Create(syscfg);
			Console.Clear();
			Console.SetCursorPosition((Console.WindowWidth - 30) / 2, (Console.WindowHeight - 10) / 2);

			Console.BackgroundColor = ConsoleColor.Blue;

			for (int y = 0; y < 10; y++)
			{
				Console.SetCursorPosition((Console.WindowWidth - 30) / 2, ((Console.WindowHeight - 10) / 2) + y);
				Console.Write("                              ");
			}
		}
	}
}
