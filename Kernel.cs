using System;
using Sys = Cosmos.System;
using Figgle;

namespace freeshellOS
{
	public class Kernel : Sys.Kernel
	{

		protected override void BeforeRun()
		{
			string welcome = FiggleFonts.Banner3D.Render("Free.shell();");
			Console.WriteLine(welcome);
		}

		protected override void Run()
		{
			Console.Write("Input: ");
			var input = Console.ReadLine();
			Console.Write("Text typed: ");
			Console.WriteLine(input);
		}
	}
}
