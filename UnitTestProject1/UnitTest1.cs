using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c;
        [TestInitialize]
        public void Setup()
        {
            c = new Calculation(10, 5);
        }
        [TestMethod]
        public void TestAddOperator()
        {
            int Expected, Actual;
           // Calculation c = new Calculation(10, 5);
            Expected = 15;
            Actual = c.Exectute("+");
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestSubOperator()
        {
            int Expected, Actual;
            // Calculation c = new Calculation(10, 5);
            Expected = 5;
            Actual = c.Exectute("-");
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestMulOperator()
        {
            int Expected, Actual;
            // Calculation c = new Calculation(10, 5);
            Expected = 50;
            Actual = c.Exectute("*");
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestDivOperator()
        {
            int Expected, Actual;
            // Calculation c = new Calculation(10, 5);
            Expected = 2;
            Actual = c.Exectute("/");
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZeroOperator()
        {
            int Expected, Actual;
              c = new Calculation(10, 0);
            
             c.Exectute("/");
         
        }

    }
}
