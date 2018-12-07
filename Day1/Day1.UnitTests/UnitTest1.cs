using System.Collections.Generic;
using Xunit;

namespace Day1.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var frequencyChanges = new List<int>() { 1, 1, 1 };

            Assert.True(3 == GetResultingFrequency(frequencyChanges));
        }

        [Fact]
        public void Test2()
        {
            var frequencyChanges = new List<int>() { 1, 1, -2 };

            Assert.True(0 == GetResultingFrequency(frequencyChanges));
        }

        [Fact]
        public void Test3()
        {
            var frequencyChanges = new List<int>() { -1, -2, -3 };

            Assert.True(-6 == GetResultingFrequency(frequencyChanges));
        }

        private int GetResultingFrequency(List<int> frequencyChanges)
        {
            return Frequenceitor.GetResultingFrequency(frequencyChanges);
        }
    }
}
