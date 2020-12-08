using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    using Instruction = Tuple<String, int>;

    /// <summary>
    /// Reads a program into memory, and then executes it.
    /// Valid commands are the following:
    /// acc increases or decreases a global accumulator
    /// jmp jumps ahead or behind
    /// nop does nothin
    /// </summary>
    internal class Interpreter
    {
        /// <summary>
        /// Creates a new interpreter by reading a program from a file.
        /// </summary>
        /// <param name="path">The input path.</param>
        public Interpreter(String path)
        {
            program = new List<Instruction>();

            foreach (var line in System.IO.File.ReadLines(path))
            {
                var parts = line.Split(' ');

                var operation = new Instruction(parts[0], Int32.Parse(parts[1]));
                program.Add(operation);
            }
        }

        /// <summary>
        /// Resets the state of the interpreter so that it can execute again.
        /// </summary>
        public void Reset()
        {
            history.Clear();
            currentPosition = 0;
            accumulator = 0;
        }

        /// <summary>
        /// Execute the program, but terminate at the first sign of a repeat.
        /// </summary>
        /// <returns>The value of the accumulator.</returns>
        public int RunUntilRepeats()
        {
            while (true)
            {
                // We return if we detect a repeat, or if we reach the end of the program.
                if (history.Contains(currentPosition) || (currentPosition == program.Count))
                {
                    return accumulator;
                }

                // Add the current position to the history, so we can detect if execution
                // returns here.
                history.Add(currentPosition);

                // Execute the next instruction

                var operation = program[currentPosition];

                if (operation.Item1 == "acc")
                {
                    // acc adds the value to the accumulator, and continues to the next line.

                    accumulator += operation.Item2;
                    ++currentPosition;
                }
                else if (operation.Item1 == "jmp")
                {
                    // jmp sets the next instruction relative to the current one.

                    currentPosition += operation.Item2;
                }
                else
                {
                    // nop does nothing, and execution continues on the next line.

                    ++currentPosition;
                }
            }
        }

        /// <summary>
        /// We go through the program, and switch jmp and nop instructions,
        /// until we find a program that reaches the end without getting into
        /// an infinite loop.
        /// </summary>
        /// <returns>The accumulator at the end of a valid program.</returns>
        public int FixAndRun()
        {
            while (true)
            {
                for (int i = 0; i < program.Count; ++i)
                {
                    var operation = program[i];

                    // Try to switch a jmp instruction to nop, or vice versa.
                    if (program[i].Item1 == "nop")
                    {
                        program[i] = new Instruction("jmp", operation.Item2);
                    }
                    else if (program[i].Item1 == "jmp")
                    {
                        program[i] = new Instruction("nop", operation.Item2);
                    }

                    Reset();
                    RunUntilRepeats();

                    // Check whether the program ended correctly.
                    if (currentPosition == program.Count)
                    {
                        return accumulator;
                    }

                    // If that didn't work, we switch it back.
                    program[i] = operation;
                }
            }
        }

        /// <summary>
        /// A global value that instruction of the program can modify.
        /// </summary>
        private int accumulator = 0;

        /// <summary>
        /// Stores the current line of execution.
        /// </summary>
        private int currentPosition = 0;

        /// <summary>
        /// Stores the history, which is a list of positions that have been executed.
        /// </summary>
        private List<int> history = new List<int>();

        /// <summary>
        /// The actual program, represented as a list of instructions.
        /// </summary>
        private List<Instruction> program;
    }

    /// <summary>
    /// Solution for day 8:
    /// https://adventofcode.com/2020/day/8
    /// </summary>
    [Common.SolutionClass(Day = 8)]
    public class Day08
    {
        
        public int GetSolution1(String path)
        {
            var program = new Interpreter(path);
            return program.RunUntilRepeats();
        }

		public int GetSolution2(String path)
        {
            var program = new Interpreter(path);
            return program.FixAndRun();
        }

        [Common.SolutionMethod(Type = SolutionType.Main, Part = 1)]
        public void Part1()
        {
           Console.WriteLine("The answer is {0}", GetSolution1("Day08/Input.txt"));
        }

        [Common.SolutionMethod(Part = 2)]
        public void Part2()
        {
            Console.WriteLine("The answer is {0}", GetSolution2("Day08/Input.txt"));
        }
    }
}
