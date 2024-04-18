using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Docker.scr
{
	internal class Statistics
	{
		public static List<int> GetInts(String[] arguments)
		{
			List<int> ints = [];
			foreach (string arg in arguments)
			{
				try
				{
					ints.Add(int.Parse(arg));
				}
				catch
				{
					// If this fails we know its a flag argument
				}
			}
			return ints;
		}

		public static  Dictionary<String, bool> GetOperations(String[] arguments) 
		{
			Dictionary<String, bool> operations = [];
			operations["min"] = false; operations["max"] = false; operations["mode"] = false; operations["mean"] = false; operations["median"]= false;
			foreach (string arg in arguments)
			{
				try
				{
					int.Parse(arg);
				}
				// If this fails we know its a flag argument
				catch
				{
					switch (arg)
					{
						case "--min":
							operations["min"] = true;
							break;
						case "--max":
							operations["max"] = true;
							break;
						case "--mode":
							operations["mode"] = true;
							break;
						case "--mean":
							operations["mean"] = true;
							break;
						case "--median":
							operations["median"] = true;
							break;
						default:
							// This means they gave neither a flag neither an integer
							throw new IllegalArgumentExeption("Invalid Argument. Type -h or --help for help");
					}
				}
			}
			return operations;
		}

		public static double GetMedian(List<int> ints) 
		{
			double median;
			// To find the median we first sort
			ints.Sort();
			if (ints.Count % 2 == 0) // If there is an even amount of integers we take the two in the midle and divide them. By 2.0 to get a Double not an int
			{
				median = (ints[ints.Count / 2 - 1] + ints[ints.Count / 2]) / 2.0;
			}
			else // There is a center element as they are odd
			{
				median = ints[ints.Count / 2];
			}
			return median;
			
		}

		//Mode calculations are done by going through the repository from start to finnish and from finish to start and counting equallities
		public static double GetMode(List<int> ints)  
		{
			ints.Sort();
			int maxCount = 0;
			double mode = 0;

			for (int i = 0; i < ints.Count; i++)
			{
				int count = 0;
				for (int j = 0; j < ints.Count; j++)
				{
					if (ints[j] == ints[i])
						count++;
				}
				if (count > maxCount)
				{
					maxCount = count;
					mode = ints[i];
				}
			}
			return mode;
		}
	}
}

[Serializable]
public class IllegalArgumentExeption : Exception
{
	public IllegalArgumentExeption() : base() { }
	public IllegalArgumentExeption(string message) : base(message) { }
	public IllegalArgumentExeption(string message, Exception inner) : base(message, inner) { }
}