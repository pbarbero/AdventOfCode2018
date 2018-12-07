using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public static class Checksumeitor
    {
        public static int GetChecksum(List<string> boxes)
        {
            var howMany2 = boxes.Where(x => HasTwoRepetitions(x)).Count();
            var howMany3 = boxes.Where(x => HasThreeRepetitions(x)).Count();

            return howMany2 * howMany3;
        }

        public static bool HasTwoRepetitions(string box)
        {
            var dictionary = box.GroupBy(c => c)
                                .Select(g => new { Letter = g.Key, Count = g.Count() });

            return dictionary.Where(x => x.Count == 2).Any();
        }

        public static bool HasThreeRepetitions(string box)
        {
            var dictionary = box.GroupBy(c => c)
                                .Select(g => new { Letter = g.Key, Count = g.Count() });

            return dictionary.Where(x => x.Count == 3).Any();
        }
    }
}
