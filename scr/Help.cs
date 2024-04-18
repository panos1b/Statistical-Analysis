using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Docker.scr
{
	internal class Help
	{
		public static void PrintHelp() 
		{
			Console.WriteLine("This programm performs statistical analysis for a set of integers");
			Console.WriteLine("usage: Program [--min] [--max] [--mode] [--mean] [--median] [integer1 integer2 ...]");
			return;
		}
	}
}
