using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    using Pair = Tuple<int, int>;
    using Triple = Tuple<int, int, int>;

    /// <summary>
    /// Solution for day 1:
    /// https://adventofcode.com/2020/day/1
    /// </summary>
    public class Day01 : ISolution
    {
        public void Part1()
        {
            var numbers = Common.IO.ReadNumbers("Input/Day1.txt").ToList();

            var pair = GetPairs(numbers)
                .First(x => x.Item1 + x.Item2 == 2020);

            Console.WriteLine("The answer is {0}", pair.Item1 * pair.Item2);
        }

        public void Part2()
        {
            var numbers = Common.IO.ReadNumbers("Input/Day1.txt").ToList();

            var pair = GetTriples(numbers)
                .First(x => x.Item1 + x.Item2 + x.Item3 == 2020);

            Console.WriteLine("The answer is {0}", pair.Item1 * pair.Item2 * pair.Item3);
        }

        /// <summary>
        /// Gets all pairs of numbers from the list.
        /// </summary>
        /// <param name="list">The list of numbers.</param>
        /// <returns>The collection of pairs.</returns>
        private IEnumerable<Pair> GetPairs(List<int> list)
        {
            for (int x = 0; x < list.Count; ++x)
            {
                for (int y = 0; y < list.Count; ++y)
                {
                    if (x == y)
                    {
                        continue;
                    }

                    yield return Tuple.Create(list[x], list[y]);
                }
            }
        }

        /// <summary>
        /// Gets all triples of numbers from the list.
        /// </summary>
        /// <param name="list">The list of numbers.</param>
        /// <returns>The collection of triples.</returns>
        private IEnumerable<Triple> GetTriples(List<int> list)
        {
            for (int x = 0; x < list.Count; ++x)
            {
                for (int y = 0; y < list.Count; ++y)
                {
                    for (int z = 0; z < list.Count; ++z)
                    {
                        if (x == y || x == z || y == z)
                        {
                            continue;
                        }

                        yield return Tuple.Create(list[x], list[y], list[z]);
                    }
                }
            }
        }
    }
}
