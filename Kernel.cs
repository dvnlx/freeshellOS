using System;
using Sys = Cosmos.System;

namespace freeshellOS
{
	public class Kernel : Sys.Kernel
	{

		protected override void BeforeRun()
		{
			Console.WriteLine("FreeshellOS!");
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
