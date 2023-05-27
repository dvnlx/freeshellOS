using System;
using System.Drawing;
using System.Diagnostics;
using Color = System.ConsoleColor;
using Sys = Cosmos.System;
using System.Threading;
using Cosmos.System;
using Cosmos.System.ScanMaps;
using System.IO;

namespace freeshellOS
{
	public class Kernel : Sys.Kernel
	{

		protected override void BeforeRun()
		{
            System.Console.WriteLine("Welcome to freeshellOS 0.1 / NVGKRNL");
			//var fs = new Sys.FileSystem.CosmosVFS();
			//Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
		}

		protected override void Run()
		{
			shell.createInstance("dvnlx","vmware");
		}
	}
}
