using System.Collections.Generic;
using Xunit;

namespace AdventOfCode.UnitTests
{
    public class Day6Tests
    {
        [Fact]
        public void Test1()
        {
            var coordinates = BuildCoordinates();
            var result = Coordinator.GetLargestArea(coordinates);
            Assert.True(17 == result);
        }

        [Fact]
        public void Test2()
        {
            var result = Coordinator.GetTaxicabDistance(2, 1, 2, 0);
            Assert.True(3 == result);
        }

        private List<string> BuildCoordinates()
        {
            return new List<string>()
            {
                "1, 1",
                "1, 6",
                "8, 3",
                "3, 4",
                "5, 5",
                "8, 9",
            };
        }
    }
}
