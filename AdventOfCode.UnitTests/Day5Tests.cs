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

        [Fact]
        public void Test4()
        {
            var result = Polarizeitor.Scan("ABCDRDFfdrdcba");
            Assert.True(0 == result);            
        }

        [Fact]
        public void Test5()
        {
            var result = Polarizeitor.BestScan("dabAcCaCBAcCcaDA");
            Assert.True(4 == result);
        }

        [Fact]
        public void Test6()
        {
            var result = Polarizeitor.RemoveLetter("dabAcCaCBAcCcaDA", 'a');
            Assert.True("dbcCCBcCcD" == result);
        }
    }
}
