using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    /// <summary>
    /// Solution for day 3:
    /// https://adventofcode.com/2020/day/3
    /// </summary>
    [Common.SolutionClass(Day = 3)]
    public class Day03
    {
        public int GetSolution1(String path)
        {
            var tobogganGrid = ReadGrid(path);

            return RunDownSlope(tobogganGrid, 1, 3).Count(x => x == '#');
        }

        [Common.SolutionMethod(Part = 1)]
        public void Part1()
        {
           Console.WriteLine("The answer is {0}", GetSolution1("Day03/Input.txt"));
        }

        public long GetSolution2(String path)
        {
            var tobogganGrid = ReadGrid(path);

            long trees_1 = RunDownSlope(tobogganGrid, 1, 1).Count(x => x == '#');
            long trees_2 = RunDownSlope(tobogganGrid, 1, 3).Count(x => x == '#');
            long trees_3 = RunDownSlope(tobogganGrid, 1, 5).Count(x => x == '#');
            long trees_4 = RunDownSlope(tobogganGrid, 1, 7).Count(x => x == '#');
            long trees_5 = RunDownSlope(tobogganGrid, 2, 1).Count(x => x == '#');

            long result = trees_1 * trees_2 * trees_3 * trees_4 * trees_5;
            return result;
        }

        [Common.SolutionMethod(Part = 2)]
        public void Part2()
        {
            Console.WriteLine("The answer is {0}", GetSolution2("Day03/Input.txt"));
        }

        /// <summary>
        /// Reads the grid from the input, and returns a list
        /// of strings.
        /// </summary>
        /// <param name="path">The input path.</param>
        /// <returns>The list of strings.</returns>
        private List<String> ReadGrid(String path)
        {
            return System.IO.File.ReadLines(path).ToList();
        }

        /// <summary>
        /// Run down the slope, at an angle given by the input.
        /// </summary>
        /// <param name="grid">The grid</param>
        /// <param name="delta_row">The row delta</param>
        /// <param name="delta_column">The column delta</param>
        /// <returns>The collection of grid items on the way</returns>
        private IEnumerable<char> RunDownSlope(List<String> grid, int delta_row, int delta_column)
        {
            int width = grid[0].Length;
            int height = grid.Count;

            int col = 0;
            for (int row = 0; row < height; row += delta_row)
            {
                yield return grid[row][col % width];

                col += delta_column;
            }
        }
    }
}
