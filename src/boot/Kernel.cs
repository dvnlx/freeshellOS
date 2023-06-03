using Sys = Cosmos.System;
using System.Threading;
using System.IO;
using Console = System.Console;
using Cosmos.System.Graphics;

namespace freeshellOS.boot
{
	public class Kernel : Sys.Kernel
    {
		Canvas canvas;

		public string username = "root";
        public string pcname = "fs.os";

        protected override void BeforeRun()
        {
            Console.WriteLine("Starting Up...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Welcome to freeshellOS 0.2 / NVGKRNL");
            var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
			canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(640, 480, ColorDepth.ColorDepth32));
			canvas.Clear();
		}

        protected override void Run()
        {
			//var cfgFile = @"0:\sys\system.cfg";
			//if (!File.Exists(cfgFile))
			//{
				//oobe.init();
			//}
			string root = "0:\\";
                shell.createInstance(username, pcname, root);

        }
    }
}
