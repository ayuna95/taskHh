using AreaFigure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calc = new AreaClass();
            double arg1 = 2;
            double expected1 = 12.56;

            double result = calc.CircleS(arg1);
            Assert.AreEqual(expected1, result);

        }
        [TestMethod]
        public void TestMethod2()
        {
            var calc = new AreaClass();
            double arg2 = 8, arg3 = 10, arg4 = 6;
            double expected2 = 24;

            double result2 = calc.TriangleSThreeSides(arg2, arg3, arg4);
            Assert.AreEqual(expected2, result2);
        }
    }
}
