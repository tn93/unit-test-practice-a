using System;
using Xunit;
using calculator;
namespace Calculator_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calculator = new Calculator();
            var result = calculator.Add(10, 11);
            var expected = 21;
            Assert.Equal(expected,result);

        }
    }
}
