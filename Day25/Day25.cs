using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    /// <summary>
    /// Solution for day 25:
    /// https://adventofcode.com/2020/day/25
    /// </summary>
    [Common.SolutionClass(Day = 25)]
    public class Day25
    {
        /// <summary>
        /// Transforms the value based on the subject number.
        /// </summary>
        /// <param name="value">The starting value.</param>
        /// <param name="subjectNumber">The subject number.</param>
        /// <returns>The transformed value.</returns>
        private long Transform(long value, long subjectNumber)
        {
            long product = value * subjectNumber;
            value = product % 20201227;

            return value;
        }

        /// <summary>
        /// Gets the loop size for the public key provided.
        /// </summary>
        /// <param name="publicKey">The public key.</param>
        /// <returns>The loop size.</returns>
        private int GetLoopSize(int publicKey)
        {
            int loopCount = 0;
            long value = 1;

            while (value != publicKey)
            {
                value = Transform(value, 7);

                ++loopCount;
            }

            return loopCount;
        }

        /// <summary>
        /// Calculates the encryption key based on the two
        /// public keys provided.
        /// </summary>
        /// <param name="publicKey1">The first public key.</param>
        /// <param name="publicKey2">The second public key.</param>
        /// <returns>The encryption key.</returns>
        public long GetSolution(int publicKey1, int publicKey2)
        {
            int loopSize1 = GetLoopSize(publicKey1);

            long encryptionKey = 1;
            for (int i = 0; i < loopSize1; ++i)
            {
                encryptionKey = Transform(encryptionKey, publicKey2);
            }

            return encryptionKey;
        }

        [Common.SolutionMethod(Type = SolutionType.Main, Part = 1)]
        public void Part1()
        {
           Console.WriteLine("The answer is {0}", GetSolution(18499292, 8790390));
        }
    }
}
