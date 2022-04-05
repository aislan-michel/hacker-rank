using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class LonelyIntegerTests
    {
        [Fact]
        public void Test1()
        {
            var input = new List<int>(3) { 1, 1, 2 };

            var result = LonelyInteger.Result.Lonelyinteger(input);

            Assert.Equal(2, result);
        }
    }
}
