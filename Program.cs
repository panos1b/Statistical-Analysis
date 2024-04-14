using System;
class Program {
	static void Main(string[] args)
	{
		// If there are no arguments we must produce an error
		if (args.Length == 0 ) 
		{
			Console.WriteLine("You need to provide arguments. Type -h or --help for help");
			return;
		}
		
		// This will display the help for the repository
		if ("-h".Equals(args[0]) || "--help".Equals(args[0]))
		{
			Console.WriteLine("This programm performs statistical analysis for a set of integers");
			Console.WriteLine("usage: Program [--min] [--max] [--mode] [--mean] [--median] [integer1 integer2 ...]");
			return;
		}

		//We now start reading arguments. We will accept them in random possitions and mixed to make the programm more vercetile
		List<int> ints = new List<int>();
		bool min = false, max = false, modeFlag = false, meanFlag = false, medianFlag = false;
		
		foreach (string arg in args)
		{
			try
			{
				ints.Add(int.Parse(arg));
			}
			// If this fails we know its a flag argument
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
						// This means they gave neither a flag neither an integer
						Console.WriteLine("Invalid Argument. Type -h or --help for help");
						return;
				}
			}
		}
	
		double median, mode = 0;
		// Depending on which flags are active we do the required computations
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
			Console.WriteLine($"The median is: {median}");
		}

		if (modeFlag) //Mode calculations are done by going through the repository from start to finnish and from finish to start and counting equallities
		{
			if (!medianFlag) // Dont resort if its already sorted earlier
			{
				ints.Sort();
			}

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
