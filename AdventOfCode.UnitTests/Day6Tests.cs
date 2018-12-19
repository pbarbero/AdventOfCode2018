using System;
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

        [Fact]
        public void Test3()
        {
            var mainCoordinates = BuildMainCoordinates();
            var coordinate = BuildCoordinate();
            var result = Coordinator.GetClosestCoordinate(coordinate, mainCoordinates);
            Assert.True("1" == result);
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

        private List<Tuple<int, int, string>> BuildMainCoordinates()
        {
            return new List<Tuple<int, int, string>>()
            {
                new Tuple<int, int, string>(1,1, "1"),
                new Tuple<int, int, string>(1,6, "2"),
            };
        }

        private Tuple<int, int> BuildCoordinate()
        {
            return new Tuple<int, int>(0, 0);
        }
    }
}
