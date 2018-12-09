using System.Collections.Generic;
using Xunit;
using AdventOfCode.Utils;

namespace AdventOfCode.UnitTests
{
    public class Day3Tests
    {
        [Fact]
        public void Test1()
        {
            var claims = new List<Claim>()
            {
                new Claim()
                {
                    MarginLeft = 1,
                    MarginTop = 3,
                    Width = 4,
                    Height = 4,
                },
                new Claim()
                {
                    MarginLeft = 3,
                    MarginTop = 1,
                    Width = 4,
                    Height = 4,
                },
                new Claim()
                {
                    MarginLeft = 5,
                    MarginTop = 5,
                    Width = 2,
                    Height = 2
                }
            };

            var inches = Claimeitor.GetNumberOverlappedClaims(claims);
            Assert.True(4 == inches);
        }
    }
}
