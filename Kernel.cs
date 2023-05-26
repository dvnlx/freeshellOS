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
			shell.createInstance();
		}
	}
}
