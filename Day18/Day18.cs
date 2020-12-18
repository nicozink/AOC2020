using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    /// <summary>
    /// Solution for day 18:
    /// https://adventofcode.com/2020/day/18
    /// </summary>
    [Common.SolutionClass(Day = 18)]
    public class Day18
    {
        /// <summary>
        /// A class that solves an aritmetic expression including numbers,
        /// multiplication, addition and parentheses.
        /// </summary>
        public abstract class Solver
        {
            #region Public Methods

            /// <summary>
            /// Takes an input string and solves it. An example is:
            /// 1 + (2 * 3) + (4 * (5 + 6))
            /// </summary>
            /// <param name="problemString">The input string</param>
            /// <returns>The solution.</returns>
            public long Solve(string problemString)
            {
                // We pad the parentheses with spaces to make
                // Them easier to parse. That means we just
                // need to use split to get the parentheses
                // as tokens.
                var problem = problemString
                    .Replace("(", "( ")
                    .Replace(")", " )")
                    .Split()
                    .ToList();

                return Solve(problem);
            }

            #endregion

            #region Protected Abstract Methods

            /// <summary>
            /// This function takes a list of numbers and
            /// operators, and evaluates it based on an
            /// implementation-specicic set of rules.
            /// </summary>
            /// <param name="problem">The input tokens</param>
            /// <returns>The result</returns>
            protected abstract long Evaluate(List<string> problem);

            #endregion

            #region Protected Methods

            /// <summary>
            /// This function takes a list of tokens, and
            /// solves them.
            /// </summary>
            /// <param name="problem">The list of tokens</param>
            /// <returns>The result</returns>
            protected long Solve(List<string> problem)
            {
                // First, we replace the parentheses by solving them
                // individually.
                ReplaceParens(ref problem);

                // Now we evaluate the raw additions and multiplications.
                return Evaluate(problem);
            }

            /// <summary>
            /// This takes an operator at the specified index, solves
            /// it, and replaces the sub-expression wiht the result.
            /// </summary>
            /// <param name="problem">The tokens.</param>
            /// <param name="index">The operator index.</param>
            protected void ReplaceOperatorAt(ref List<string> problem, int index)
            {
                var firstIndex = index - 1;
                var secondIndex = index + 1;

                var opertor = problem[index];
                var first = long.Parse(problem[firstIndex]);
                var second = long.Parse(problem[secondIndex]);

                // Remove the sub-expression. This will be two operator, and
                // the two numbers on either side.
                problem.RemoveRange(firstIndex, 3);

                // Replace this with the result of the operation.
                if (opertor == "+")
                {
                    problem.Insert(firstIndex, Convert.ToString(first + second));
                }
                else
                {
                    problem.Insert(firstIndex, Convert.ToString(first * second));
                }
            }

            /// <summary>
            /// Finds matching pairs of parentheses, and solves the sub-expression,
            /// and replaces the sub-expression with the result.
            /// </summary>
            /// <param name="problem">The input problem.</param>
            protected void ReplaceParens(ref List<string> problem)
            {
                while (problem.Contains("("))
                {
                    // Find the start and end position of matching parentheses.
                    // These will need to be balanced, so we find the correct
                    // matching pair.
                    
                    var startPosition = problem.IndexOf("(");
                    var endPosition = startPosition;

                    int parenCount = 1;
                    while (parenCount != 0)
                    {
                        ++endPosition;

                        if (problem[endPosition] == "(")
                        {
                            ++parenCount;
                        }
                        else if (problem[endPosition] == ")")
                        {
                            --parenCount;
                        }
                    }

                    // Extract the sub-problem and solve it.

                    var subProblem = problem.GetRange(startPosition + 1, endPosition - startPosition - 1);
                    long result = Solve(subProblem);

                    // Now replace the sub-problem with the result.

                    problem.RemoveRange(startPosition, endPosition - startPosition + 1);
                    problem.Insert(startPosition, Convert.ToString(result));
                }
            }

            #endregion
        }

        /// <summary>
        /// This solves an arithmetic expression by ignoring operator
        /// precedence.
        /// </summary>
        public class LinearSolver : Solver
        {
            #region Protected Override Methods

            protected override long Evaluate(List<string> problem)
            {
                // This always takes the first operator, until none
                // are left.

                while (problem.Count != 1)
                {
                    ReplaceOperatorAt(ref problem, 1);
                }

                return long.Parse(problem[0]);
            }

            #endregion
        }

        /// <summary>
        /// Solves the arithmetic problem by applying operator
        /// precedence. In this case, all '+' operators take
        /// precedence over '*' operators.
        /// </summary>
        public class PrecedenceSolver : Solver
        {
            #region Protected Override Methods

            protected override long Evaluate(List<string> problem)
            {
                // Find each '+' operator, solve it and replace it
                while (problem.Contains("+"))
                {
                    var index = problem.IndexOf("+");
                    ReplaceOperatorAt(ref problem, index);
                }

                // Find each '*' operator, solve it and replace it
                while (problem.Contains("*"))
                {
                    var index = problem.IndexOf("*");
                    ReplaceOperatorAt(ref problem, index);
                }

                return long.Parse(problem[0]);
            }

            #endregion
        }

        public long GetSolution1(String path)
        {
            var input = System.IO.File.ReadLines(path);

            var solver = new LinearSolver();
            return input.Sum(x => (long)solver.Solve(x));
        }

        public long GetSolution2(String path)
        {
            var input = System.IO.File.ReadLines(path);

            var solver = new PrecedenceSolver();
            return input.Sum(x => (long)solver.Solve(x));
        }

        [Common.SolutionMethod(Type = SolutionType.Main, Part = 1)]
        public void Part1()
        {
           Console.WriteLine("The answer is {0}", GetSolution1("Day18/Input.txt"));
        }

        [Common.SolutionMethod(Part = 2)]
        public void Part2()
        {
            Console.WriteLine("The answer is {0}", GetSolution2("Day18/Input.txt"));
        }
    }
}
