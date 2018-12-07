using System.Collections.Generic;

namespace Day1
{
    public static class Frequenceitor
    {
        public static int GetResultingFrequency(List<int> frequencyChanges)
        {
            var start = 0;

            foreach (var item in frequencyChanges)
            {
                start += item;
            }

            return start;
        }
    }
}
