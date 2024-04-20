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
			Console.WriteLine("usage: Program [--min] [--max] [--mode] [--mean] [--median] [--individual] [integer1 integer2 ...]");
			Console.WriteLine("For more help on a spesific argument type --help and the argument. Like this: Program --help [--min] [--max] [--mode] [--mean] [--median] [--individual]");
			Console.WriteLine("To print the full help type --help --all");
			return;
		}
		public static void PrintHelp(String argument)
		{
			switch (argument)
			{
				case "--min":
					Console.WriteLine("The --min argument finds the minimum value for a set of integers");
					break;
				case "--max":
					Console.WriteLine("The --max argument finds the maximum value for a set of integers");
					break;
				case "--mode":
					Console.WriteLine("The --mode argument finds the mode value for a set of integers");
					Console.WriteLine("The mode is a measure of central tendency, meaning it's a value that represents a typical or central value within a set of data");
					Console.WriteLine("Multimodal integer sets will return the first mode (which is lowest in value)");
					break;
				case "--mean":
					Console.WriteLine("The --mean argument finds the mean value for a set of integers");
					Console.WriteLine("The mean, often referred to as the average, is a measure of central tendency in statistics");
					break;
				case "--median":
					Console.WriteLine("The --median argument finds the average value for a set of integers");
					Console.WriteLine("The median is another measure of central tendency in statistics.\nThe median is the middle value of a dataset when it's ordered from least to greatest");
					break;
				case "--individual":
					Console.WriteLine("The --individual argument keeps only unique values for a set of integers");
					Console.WriteLine("That means that the passed values '1 2 3' and '1 2 2 2 2 2 2 3' are the same");
					break;
				case "--all":
					// Prints all the helps via a recursive call
					string[] arguments = new string[] { "--min", "--max", "--mode", "--mean", "--median", "--individual" };
					foreach (String arg in arguments)
					{
						Console.WriteLine($"---------------------------------------------\n{arg}:");
						PrintHelp(arg);
					}
					Console.WriteLine($"---------------------------------------------");
					break;
				default:
					// This means they gave a wrong second argument
					throw new IllegalArgumentExeption("Invalid Argument. Type -h or --help for help");
			}
		}
	}
}
