using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    /// <summary>
    /// Solution for day 6:
    /// https://adventofcode.com/2020/day/6
    /// </summary>
    [Common.SolutionClass(Day = 6)]
    public class Day06
    {
        /// <summary>
        /// Reads each group of answers from the input.
        /// Each group of answers is seperated by a blank
        /// newline.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <returns>The grouped answers.</returns>
        IEnumerable<List<String>> ReadGroupAnswers(String path)
        {
            List<String> groupAnswers = new List<string>();

            var input = System.IO.File.ReadLines(path);
            foreach (var line in input)
            {
                if (line == "")
                {
                    yield return groupAnswers;

                    groupAnswers.Clear();
                }
                else
                {
                    groupAnswers.Add(line);
                }
            }

            yield return groupAnswers;
        }

        /// <summary>
        /// Reads the distint answers for each group. These are
        /// all of the answers that anyone in the group answered.
        /// </summary>
        /// <param name="path">The data for each group.</param>
        /// <returns>The distinct answers.</returns>
        IEnumerable<String> ReadDistinctGroupAnswers(String path)
        {
            var groupedAnswers = ReadGroupAnswers(path);

            foreach (var groupedAnswer in groupedAnswers)
            {
                var allAnswers = "";

                groupedAnswer.ForEach(answer => {
                    allAnswers += answer;
                });

                var distinctCharacters = allAnswers.Distinct().OrderBy(x => x);
                yield return new String(distinctCharacters.ToArray());
            }
        }

        /// <summary>
        /// Reads the intersected answers for each group. These are
        /// all of the answers that everyone in the group answered.
        /// </summary>
        /// <param name="path">The data for each group.</param>
        /// <returns>The distinct answers.</returns>
        IEnumerable<String> ReadIntersectedGroupAnswers(String path)
        {
            var groupedAnswers = ReadGroupAnswers(path);

            foreach (var groupedAnswer in groupedAnswers)
            {
                var allAnswers = groupedAnswer.FirstOrDefault();

                groupedAnswer.ForEach(answer => {
                    var commonCharacters = allAnswers.Intersect(answer).OrderBy(x => x);
                    allAnswers = new String(commonCharacters.ToArray());
                });

                yield return allAnswers;
            }
        }

        public int GetSolution1(String path)
        {
            var answers = ReadDistinctGroupAnswers(path);
            return answers.Sum(x => x.Length);
        }

		public int GetSolution2(String path)
        {
            var answers = ReadIntersectedGroupAnswers(path);
            return answers.Sum(x => x.Length);
        }

        [Common.SolutionMethod(Type = SolutionType.Main, Part = 1)]
        public void Part1()
        {
           Console.WriteLine("The answer is {0}", GetSolution1("Day06/Input.txt"));
        }

        [Common.SolutionMethod(Part = 2)]
        public void Part2()
        {
            Console.WriteLine("The answer is {0}", GetSolution2("Day06/Input.txt"));
        }
    }
}
