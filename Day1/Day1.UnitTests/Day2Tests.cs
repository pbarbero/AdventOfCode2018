using System.Collections.Generic;
using Xunit;

namespace AdventOfCode.UnitTests
{
    public class Day2Tests
    {
        [Fact]
        public void Test1()
        {
            var boxes = new List<string>()
            {
                "abcdef",
                "bababc",
                "abbcde",
                "abcccd",
                "aabcdd",
                "abcdee",
                "ababab",
            };

            Assert.True(12 == Checksumeitor.GetChecksum(boxes));
        }

        [Fact]
        public void Test2()
        {
            var box = "bababc";
            Assert.True(Checksumeitor.HasTwoRepetitions(box));
        }

        [Fact]
        public void Test3()
        {
            var box = "bababc";
            Assert.True(Checksumeitor.HasThreeRepetitions(box));
        }
    }
}
