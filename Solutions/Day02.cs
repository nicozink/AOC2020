using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    /// <summary>
    /// Solution for day 2:
    /// https://adventofcode.com/2020/day/2
    /// </summary>
    public class Day02 : ISolution
    {
        private class PasswordRule
        {
            public int MinLetter;
            public int MaxLetter;

            public char Letter;

            public String Password;
        }

        public void Part1()
        {
            var passwords = ParsePasswordRules();

            int validPasswords = passwords.Count(x => IsPasswordValidRule1(x));

            Console.WriteLine("The answer is {0}", validPasswords);
        }

        public void Part2()
        {
            var passwords = ParsePasswordRules();

            int validPasswords = passwords.Count(x => IsPasswordValidRule2(x));

            Console.WriteLine("The answer is {0}", validPasswords);
        }

        /// <summary>
        /// Checks whether a password is valid under rule 1.
        /// The password must contain the reuired character
        /// between the min and max number of times.
        /// </summary>
        /// <param name="passwordRule">The password to check.</param>
        /// <returns>True if the password matches.</returns>
        private bool IsPasswordValidRule1(PasswordRule passwordRule)
        {
            char letter = passwordRule.Letter;
            String password = passwordRule.Password;

            int letterCount = password.Count(x => x == letter);

            return letterCount >= passwordRule.MinLetter
                && letterCount <= passwordRule.MaxLetter;
        }

        /// <summary>
        /// Checks whether a password is valid under rule 2.
        /// The password must have the character at either
        /// the min and max positions.
        /// </summary>
        /// <param name="passwordRule">The password rule.</param>
        /// <returns>True if the password matches.</returns>
        private bool IsPasswordValidRule2(PasswordRule passwordRule)
        {
            char letter = passwordRule.Letter;
            String password = passwordRule.Password;

            int minLetterPosition = passwordRule.MinLetter;
            int maxLetterPosition = passwordRule.MaxLetter;

            bool matches1 = password[minLetterPosition - 1] == letter;
            bool matches2 = password[maxLetterPosition - 1] == letter;

            return (matches1 && !matches2)
                || (matches2 && !matches1);
        }

        /// <summary>
        /// Reads a list of passwords from the file.
        /// Passwords are stored in the format:
        /// min-max letter: password.
        /// Examples:
        /// 1-3 a: abcde
        /// 1-3 b: cdefg
        /// 2-9 c: ccccccccc
        /// </summary>
        /// <returns>The password rules.</returns>
        private IEnumerable<PasswordRule> ParsePasswordRules()
        {
            foreach (var input in System.IO.File.ReadLines("Input/Day02.txt"))
            {
                var stringItems = input.Split(' ');

                var minMax = stringItems[0].Split('-');

                yield return new PasswordRule()
                {
                    MinLetter = int.Parse(minMax[0]),
                    MaxLetter = int.Parse(minMax[1]),
                    Letter = stringItems[1][0],
                    Password = stringItems[2]
                };
            }
        }
    }
}
