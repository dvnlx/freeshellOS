using Cosmos.System;
using Cosmos.System.ScanMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freeshellOS.commands
{
	internal class kbdmap
	{
		public static void setKBD(string kbd) {
			switch(kbd)
			{
				case "de":
					KeyboardManager.SetKeyLayout(new DE_Standard());
				break;
				case "en-us":
					KeyboardManager.SetKeyLayout(new US_Standard());
				break;
				case "fr":
					KeyboardManager.SetKeyLayout(new FR_Standard());
				break;
			}
		}

		public static void getCurrentKBD()
		{
            System.Console.WriteLine(KeyboardManager.GetKeyLayout()); 
		}
	}
}
