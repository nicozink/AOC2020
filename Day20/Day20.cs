using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    /// <summary>
    /// Solution for day 20:
    /// https://adventofcode.com/2020/day/20
    /// </summary>
    [Common.SolutionClass(Day = 20)]
    public class Day20
    {
        public int GetSolution1(String path)
        {
            return 0;
        }

        public long GetSolution2(String path)
        {
            return 0;
        }

        [Common.SolutionMethod(Type = SolutionType.Main, Part = 1)]
        public void Part1()
        {
           Console.WriteLine("The answer is {0}", GetSolution1("Day20/Input.txt"));
        }

        [Common.SolutionMethod(Part = 2)]
        public void Part2()
        {
            Console.WriteLine("The answer is {0}", GetSolution2("Day20/Input.txt"));
        }
    }
}
