using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    /// <summary>
    /// Solution for day 5:
    /// https://adventofcode.com/2020/day/5
    /// </summary>
    [Common.SolutionClass(Day = 5)]
    public class Day05
    {
        /// <summary>
        /// Converts a string containing rows and columns to an
        /// integer position.
        /// </summary>
        /// <param name="searchString">The string describing the position.</param>
        /// <returns>The position.</returns>
        public int GetPositionFromString(String searchString)
        {
            var binaryString = searchString
                .Replace('F', '0')
                .Replace('B', '1')
                .Replace('L', '0')
                .Replace('R', '1');

            return Convert.ToInt32(binaryString, 2);
        }

        /// <summary>
        /// Gets the seat position from a string.
        /// </summary>
        /// <param name="seat">The string describing the position.</param>
        /// <returns>The seat position giving row/column.</returns>
        public Tuple<int, int> GetSeatPosition(String seat)
        {
            int row = GetPositionFromString(seat.Substring(0, 7));
            int column = GetPositionFromString(seat.Substring(7, 3));

            return new Tuple<int, int>(row, column);
        }

        /// <summary>
        /// Gets the seat ID for a given seat string.
        /// Te seat id is given by row * 8 + column.
        /// </summary>
        /// <param name="seat">The string describing the seat position.</param>
        /// <returns>The seat id.</returns>
        public int GetSeatID(String seat)
        {
            var seatPosition = GetSeatPosition(seat);

            return seatPosition.Item1 * 8 + seatPosition.Item2;
        }

        /// <summary>
        /// Gets the maximum seat ID from the given input.
        /// </summary>
        /// <returns>The maximum seat ID.</returns>
        public int GetMaximumSeatID()
        {
            var input = System.IO.File.ReadLines("Day05/Input.txt");

            return input.Max(x => GetSeatID(x));
        }

        /// <summary>
        /// Gets the missing seat ID from the list of inputs.
        /// The input may be missing front or rear seats, so
        /// the missing seat is guaranteed to be adjacent to
        /// other seats.
        /// </summary>
        /// <returns>The missing seat id.</returns>
        public long GetMissingSeat()
        {
            int minSeatID = GetSeatID("FFFFFFFLLL");
            int maxSeatID = GetSeatID("BBBBBBBRRR");

            var boardingPasses = System.IO.File.ReadLines("Day05/Input.txt")
                .ToDictionary(x => GetSeatID(x));

            for (int i = minSeatID; i <= maxSeatID; ++i)
            {
                if (!boardingPasses.ContainsKey(i)
                    && boardingPasses.ContainsKey(i - 1)
                    && boardingPasses.ContainsKey(i + 1))
                {
                    return i;
                }
            }

            return 0;
        }

        [Common.SolutionMethod(Type = SolutionType.Main, Part = 1)]
        public void Part1()
        {
           Console.WriteLine("The answer is {0}", GetMaximumSeatID());
        }

        [Common.SolutionMethod(Part = 2)]
        public void Part2()
        {
            Console.WriteLine("The answer is {0}", GetMissingSeat());
        }
    }
}
