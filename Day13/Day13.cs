using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    /// <summary>
    /// Solution for day 13:
    /// https://adventofcode.com/2020/day/13
    /// </summary>
    [Common.SolutionClass(Day = 13)]
    public class Day13
    {
        /// <summary>
        /// Parses an input string to extract all bus ids.
        /// An 'x' is converted to a 1, since those buses
        /// are wildcards - so valid for any minute.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>The bus ids.</returns>
        IEnumerable<int> ReadBusIds(String input)
        {
            foreach (var id in input.Split(','))
            {
                if (id == "x")
                {
                    yield return 1;
                }
                else
                {
                    yield return int.Parse(id);
                }
            }
        }

        /// <summary>
        /// Finds the earliest bus after the given time stamp. The
        /// time stamp is given from the first line. the bus ids are
        /// read from the second line.
        /// </summary>
        /// <param name="path">The input file.</param>
        /// <returns>The product of the earlest bus id and wait time.</returns>
        public int GetSolution1(String path)
        {
            var lines = System.IO.File.ReadAllLines(path).ToList();

            int timeStamp = int.Parse(lines[0]);
            var busIds = lines[1]
                .Split(',')
                .Where(x => x != "x")
                .Select(x => int.Parse(x));

            // Find the earliest bus arrival with the shortest wait time.

            int shortestWait = int.MaxValue;
            int earliestBusID = 0;

            foreach (var currentID in busIds)
            {
                // Find the divisor that gives us the previous bus
                // arrival before the timestamp. We use that to
                // calculate the next arrival time.
                int previousBusFrequency = timeStamp / currentID;
                int nextBusTime = currentID * (previousBusFrequency + 1);

                // Use the current bus id if it is earlier than the previous bus id.
                int waitTime = nextBusTime - timeStamp;
                if (waitTime < shortestWait)
                {
                    shortestWait = waitTime;
                    earliestBusID = currentID;
                }
            }

            return shortestWait * earliestBusID;
        }

        /// <summary>
        /// We find a time stamp, where all bus ids depart at subsequent
        /// minutes in the order they were given.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>The time stamp.</returns>
        public long SolveSubsequentDepartures(String input)
        {
            var busIds = input
                .Split(',')
                .Select(x => x == "x" ? 1 : int.Parse(x))
                .ToList();

            long timeStamp = 0;
            long delta = busIds[0];

            for (int i = 1; i < busIds.Count; ++i)
            {
                // Scan through the timeline until we find a
                // time stamp that is perfectly divisible by
                // the bus id (with the position offset)
                var busId = busIds[i];
                while ((timeStamp + i) % busId != 0)
                {
                    timeStamp += delta;
                }

                // Include the bus id in the delta, to encode
                // the current bus id in all future searches.
                delta *= busId;
            }

            return timeStamp;
        }

        /// <summary>
        /// Reads a file, and finds a starting point where
        /// each bus departs at a subsequent time within a
        /// minute each.
        /// </summary>
        /// <param name="path">The input path.</param>
        /// <returns>The starting time stamp.</returns>
        public long GetSolution2(String path)
        {
            var lines = System.IO.File.ReadAllLines(path).ToList();

            return SolveSubsequentDepartures(lines[1]);
        }

        [Common.SolutionMethod(Type = SolutionType.Main, Part = 1)]
        public void Part1()
        {
           Console.WriteLine("The answer is {0}", GetSolution1("Day13/Input.txt"));
        }

        [Common.SolutionMethod(Part = 2)]
        public void Part2()
        {
            Console.WriteLine("The answer is {0}", GetSolution2("Day13/Input.txt"));
        }
    }
}
