using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    /// <summary>
	/// A solution for a specific day.
	/// </summary>
	public interface ISolution
	{
		/// <summary>
		/// Solves part 1 of the challenge.
		/// </summary>
		void Part1();

		/// <summary>
		/// Solves part 2 of the challenge.
		/// </summary>
		void Part2();
	}
}
