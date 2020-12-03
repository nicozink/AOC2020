using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	/// <summary>
	/// Runs the solutions for each day. Takes parameters to run
	/// a specific solution or part solution - e.g. 1, 3-1, 5-2.
	/// </summary>
	/// <param name="args">The command line arguments.</param>
	static void Main(string[] args)
	{
		Console.WriteLine("Welcome to Advent of Code 2020!");
		Console.WriteLine();

		var solutions = new List<Common.ISolution>()
		{
			new Solutions.Day01(),
			new Solutions.Day02()
		};

		if (args.Length == 1)
		{
			// Take the parameters, and split them into parts.
			// E.g. 3-1 means run part 1 of day 3.

			var parts = args[0]
				.Split('-')
				.Select(x => int.Parse(x))
				.ToList();

			int selectedDay = parts[0];
			int selectedIndex = selectedDay - 1;

			var solution = solutions[selectedIndex];

			int? selectedPart = null;
			if (parts.Count() == 2)
			{
				selectedPart = parts[1];
			}

			if (!selectedPart.HasValue || selectedPart == 1)
			{
				solution.Part1();
			}

			if (!selectedPart.HasValue || selectedPart == 2)
			{
				solution.Part2();
			}
		}
		else
		{
			// If we don't have any parameters, run all solutions.

			for (int i = 0; i < solutions.Count; ++i)
			{
				Console.WriteLine("Day {0}", i + 1);

				var solution = solutions[i];
				solution.Part1();
				solution.Part2();

				Console.WriteLine();
			}
		}
	}
}
