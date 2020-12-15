using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solutions
{
    /// <summary>
    /// Solution for day 15:
    /// https://adventofcode.com/2020/day/15
    /// </summary>
    [Common.SolutionClass(Day = 15)]
    public class Day15
    {
        /// <summary>
        /// Gets the nth number, based on the starting numbers.
        /// </summary>
        /// <param name="starting">The starting numbers.</param>
        /// <param name="n">The turn n.</param>
        /// <returns>The nth number.</returns>
        public int GetNthNumber(List<int> starting, int n)
        {
            // We process the starting numbers by putting them in a dictionary
            // that stores the last turn. We exclude the last number, since that
            // will need to be processed the same way we handle new numbers.
            var history = starting.GetRange(0, starting.Count - 1)
                .Select((num, index) => new Tuple<int, int>(num, index + 1))
                .ToDictionary(tuple => tuple.Item1, tuple => tuple.Item2);

            var lastNumber = starting.Last();
            var lastTurn = starting.Count();

            while (true)
            {
                var nextNumber = 0;

                // We get the next number based on the last number, and
                // the previous history based on the last turn.
                if (history.ContainsKey(lastNumber))
                {
                    nextNumber = lastTurn - history[lastNumber];
                }

                // We needed the history of the last number before the
                // last turn, but it's safe to update the hitory now.
                history[lastNumber] = lastTurn;

                var nextTurn = lastTurn + 1;
                if (nextTurn == n)
                {
                    return nextNumber;
                }

                lastNumber = nextNumber;
                lastTurn = nextTurn;
            }
        }

        [Common.SolutionMethod(Type = SolutionType.Main, Part = 1)]
        public void Part1()
        {
           Console.WriteLine("The answer is {0}", GetNthNumber(new List<int> { 2, 0, 1, 7, 4, 14, 18 }, 2020));
        }

        [Common.SolutionMethod(Part = 2)]
        public void Part2()
        {
            Console.WriteLine("The answer is {0}", GetNthNumber(new List<int> { 2, 0, 1, 7, 4, 14, 18 }, 30000000));
        }
    }
}
