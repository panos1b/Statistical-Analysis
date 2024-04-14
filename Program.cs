using System;
class Program {
	static void Main(string[] args)
	{
		if (args.Length == 0 ) 
		{
			Console.WriteLine("You need to provide arguments. Type -h or --help for help");
			return;
		}

		if ("-h".Equals(args[0]) || "--help".Equals(args[0]))
		{
			Console.WriteLine("This programm performs statistical analysis for a set of integers");
			Console.WriteLine("usage: Program [--min] [--max] [--mode] [--mean] [--median] [integer1 integer2 ...]");
			return;
		}

		List<int> ints = new List<int>();
		bool min = false, max = false, modeFlag = false, meanFlag = false, medianFlag = false;
		
		foreach (string arg in args)
		{
			try
			{
				ints.Add(int.Parse(arg));
			}
			catch
			{
				switch(arg)
				{
					case "--min":
						min = true;
						break;
					case "--max":
						max = true;
						break;
					case "--mode":
						modeFlag = true;
						break;
					case "--mean":
						meanFlag = true;
						break;
					case "--median":
						medianFlag = true;
						break;
					default:
						Console.WriteLine("Invalid Argument. Type -h or --help for help");
						return;
				}
			}
		}
	
		double median, mode = 0;

		if (min) 
		{
			Console.WriteLine($"The minimum is: {ints.Min()} ");
		}

		if (max) 
		{
			Console.WriteLine($"The maximum is: {ints.Max()} ");
		}

		if (meanFlag)
		{
			Console.WriteLine($"The mean is: {ints.Average()}");
		}

		if (medianFlag)
		{
			ints.Sort();
			if (ints.Count % 2 == 0)
			{
				median = (ints[ints.Count / 2 - 1] + ints[ints.Count / 2]) / 2.0;
			}
			else 
			{
				median = ints[ints.Count / 2];
			}
			Console.WriteLine($"The median is: {median}");
		}

		if (modeFlag) 
		{
			int maxCount = 0;

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
			Console.WriteLine($"The mode is: {mode}");
		}
	}
 }
