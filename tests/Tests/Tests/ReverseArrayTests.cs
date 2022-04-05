using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class ReverseArrayTests
    {
        [Fact]
        public void Test1()
        {
            var input = new List<int> { 1, 4, 3, 2 };

            var reversedArray = Arrays_DS.Result.ReverseArray(input);

            var expected = new List<int> { 2, 3, 4, 1 };

            Assert.Equal(expected, reversedArray);
        }
    }
}
