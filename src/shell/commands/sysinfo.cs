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
            Console.WriteLine("FreeshellOS \n NVGKRNL");
			Console.WriteLine($"CPU: {CPU.GetCPUBrandString}");
        }
	}
}
