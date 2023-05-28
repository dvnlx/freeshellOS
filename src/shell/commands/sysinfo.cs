using Cosmos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freeshellOS.commands
{
	internal class sysinfo
	{
		public static void showinfo() {
            Console.WriteLine("Device Info");
			Console.WriteLine($"CPU: {CPU.GetCPUBrandString()}");
			Console.WriteLine($"RAM: {CPU.GetAmountOfRAM()} MB");
			Console.WriteLine($"Uptime: {CPU.GetCPUUptime()} ms");
		}
	}
}
