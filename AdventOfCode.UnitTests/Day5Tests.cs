using Xunit;

namespace AdventOfCode.UnitTests
{
    public class Day5Tests
    {
        [Fact]
        public void Test1()
        {
            var result = Polarizeitor.Scan("dabAcCaCBAcCcaDA");
            Assert.True(10 == result);
        }

        [Fact]
        public void Test2()
        {
            Assert.True(Polarizeitor.Polarize('a', 'A'));
        }


        [Fact]
        public void Test3()
        {
            Assert.False(Polarizeitor.Polarize('a', 'r'));
        }
    }
}
