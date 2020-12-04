using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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

		// Get all classes that have the SolutionClass attribute.
		// These hold the solutions for each day.
		var matchingTypes = from t in Assembly.Load("Solutions").GetTypes()
							where SolutionClassAttribute.GetAttribute(t) != null
							orderby SolutionClassAttribute.GetAttribute(t).Day
							select t;

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

			int? selectedPart = null;
			if (parts.Count() == 2)
			{
				selectedPart = parts[1];
			}

			var type = matchingTypes.First(x => SolutionClassAttribute.GetAttribute(x).Day == selectedDay);
			InvokeSolution(type, selectedPart);
		}
		else
		{
			// If we don't have any parameters, run all solutions.

			foreach (var type in matchingTypes)
			{
				InvokeSolution(type, null);

				Console.WriteLine();
			}
		}
	}

	/// <summary>
	/// Invokes the solution for a specific day.
	/// </summary>
	/// <param name="type">The class type for the soltion.</param>
	/// <param name="part">The part of the solution to run, or null to run all</param>
	static void InvokeSolution(Type type, int? part)
    {
		var classAttribute = SolutionClassAttribute.GetAttribute(type);
		Console.WriteLine("Day {0}", classAttribute.Day);

		var instance = Activator.CreateInstance(type);

		var methods = type.GetMethods()
					.Where(m => SolutionMethodAttribute.GetAttribute(m) != null)
					.ToDictionary(x => SolutionMethodAttribute.GetAttribute(x).Part);

		if (!part.HasValue || part == 1)
		{
			methods[1].Invoke(instance, null);
		}

		if (!part.HasValue || part == 2)
		{
			methods[2].Invoke(instance, null);
		}
	}
}
