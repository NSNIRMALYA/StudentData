using StudentLogic;
using System;
using Xunit;

namespace unitTesting
{
    public class UnitTest1
    {
        [Fact(DisplayName ="Testing if the method returns summation of two numbers")]
        public void Test1()
        {
            BusinessLogicL bl = new BusinessLogicL();
            var result = bl.AddTwoNumber(5, 6);
            Assert.Equal(11, result);
        }
        [Fact(DisplayName ="Test if The multiplication method works")]

        public void Test2()
        {
            BusinessLogicL b2 = new BusinessLogicL();
            var result = b2.MultiplyTwoNumber(4, 8);
            Assert.Equal(32, result);
        }
    }
}
