using DotNet.Docker.scr;
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
			Help.PrintHelp();
			return;
		}

		//We now start reading arguments. We will accept them in random possitions and mixed to make the programm more vercetile
		List<int> ints = Statistics.GetInts(args); //CRUD creation
		Dictionary<String, bool> operations = []; //CRUD creation

		try
		{
			operations = Statistics.GetOperations(args); //CRUD updating
		} 
		catch(IllegalArgumentExeption ex) 
		{ 
			Console.WriteLine(ex.Message);
			return;
		}

		// Depending on which flags are active we do the required computations
		if (operations["individual"]) 
		{
			ints = Statistics.KeepUniqueValues(ints); //CRUD deleting
		}

		if (operations["min"]) 
		{
			Console.WriteLine($"The minimum is: {ints.Min()} "); //CRUD reading
		}

		if (operations["max"]) 
		{
			Console.WriteLine($"The maximum is: {ints.Max()} "); //CRUD reading
		}

		if (operations["mean"])
		{
			Console.WriteLine($"The mean is: {ints.Average()}"); //CRUD reading
		}

		if (operations["median"])
		{
			Console.WriteLine($"The median is: {Statistics.GetMedian(ints)}");
		}

		if (operations["mode"]) 
		{
			Console.WriteLine($"The mode is: {Statistics.GetMode(ints)}");
		}
	}
 }
