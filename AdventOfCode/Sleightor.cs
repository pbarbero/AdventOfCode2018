using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode
{
    public static class Sleightor
    {
        private static List<Tuple<char, char>> Steps;

        public static string GetOrderToBuildSleight(List<string> lines)
        {
            Steps = ParseData(lines);
            var orderedLetters = GetOrderedLetters();
            return string.Join(string.Empty, orderedLetters);
        }

        public static List<char> GetOrderedLetters()
        {
            var result = new List<char>();

            var pendingChars = InitPendingChars(ref result, Steps[0].Item1);

            while (pendingChars.Count > 0)
            {
                var charToAdd = GetAndRemoveFirstChar(ref pendingChars);
                result.Add(charToAdd);

                var prerequisites = GetLettersWithPrerequiste(charToAdd);

                if (prerequisites.Any())
                {
                    AddElementsToStack(ref pendingChars, prerequisites);
                }
            }

            return result;
        }

        private static char GetAndRemoveFirstChar(ref List<char> pendingChars)
        {
            var firstChar = pendingChars.First();
            pendingChars.RemoveAt(0);
            return firstChar;
        }

        private static List<char> InitPendingChars(ref List<char> result, char initialChar)
        {
            var pending = new List<char>();
            var prerrequisiteChar = initialChar;
            result.Add(prerrequisiteChar);
            var prerequisites = GetLettersWithPrerequiste(prerrequisiteChar);
            AddElementsToStack(ref pending, prerequisites);

            return pending;
        }

        private static void AddElementsToStack(ref List<char> pendingChars, List<char> elements)
        {
            foreach (var element in elements)
            {
                if (!pendingChars.Contains(element))
                {
                    pendingChars.Add(element);
                }
            }

            pendingChars = pendingChars.OrderByDescending(c => c).ToList();
        }

        private static List<char> GetLettersWithPrerequiste(char c)
        {
            return Steps.Where(x => x.Item1 == c).Select(y => y.Item1).OrderByDescending(z => z).ToList();
        }

        private static List<Tuple<char,char>> ParseData(List<string> lines)
        {
            var data = new List<Tuple<char, char>>();

            foreach(var line in lines)
            {
                var upperChars = line.ToList().Where(x => char.IsUpper(x)).ToArray();
                var step = new Tuple<char, char>
                (
                    upperChars[1],
                    upperChars[2]
                );
                data.Add(step);
            }

            return data;
        }
    }
}
