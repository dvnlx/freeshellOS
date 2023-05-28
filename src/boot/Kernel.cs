using Sys = Cosmos.System;
using System.Threading;
using System.IO;
using Console = System.Console;

namespace freeshellOS.boot
{
	public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Starting Up...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Welcome to freeshellOS 0.2 / NVGKRNL");
            var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            //var cfgFile = @"0:\sys\system.cfg";
			//if (File.Exists(cfgFile))
			//{
				//oobe.init();
			//}
		}

        protected override void Run()
        {

                string root = "0:\\";
                shell.createInstance("dvnlx", "vmware", root);

        }
    }
}
