using Microsoft.VisualStudio.TestTools.UnitTesting;
using API.Calc.Mgr;

namespace API.Calc.Test
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void AssertIfNullFirstNumberPassed_WillReturnSumOfSoleNumber()
        {
            CalculateMgr calcMgr = new CalculateMgr();
            int Result = calcMgr.Add(null, 1);
            Assert.AreEqual(1, Result);
        }

        [TestMethod]
        public void AssertIfNullSecondNumberPassed_WillReturnSumOfSoleNumber()
        {
            CalculateMgr calcMgr = new CalculateMgr();
            int Result = calcMgr.Add(1, null);
            Assert.AreEqual(1, Result);
        }

        [TestMethod]
        public void AssertIfNullBothNumberPassed_WillReturnSumOfSoleNumber()
        {
            CalculateMgr calcMgr = new CalculateMgr();
            int Result = calcMgr.Add(null, null);
            Assert.AreEqual(0, Result);
        }

        [TestMethod]
        public void AssertIfNullFirstNumberPassed_WillReturnSubOfSoleNumber()
        {
            CalculateMgr calcMgr = new CalculateMgr();
            int Result = calcMgr.Subtract(null, 1);
            Assert.AreEqual(-1, Result);
        }

        [TestMethod]
        public void AssertIfNullSecondNumberPassed_WillReturnSubOfSoleNumber()
        {
            CalculateMgr calcMgr = new CalculateMgr();
            int Result = calcMgr.Subtract(1, null);
            Assert.AreEqual(1, Result);
        }

        [TestMethod]
        public void AssertIfNullBothNumberPassed_WillReturnSubOfSoleNumber()
        {
            CalculateMgr calcMgr = new CalculateMgr();
            int Result = calcMgr.Subtract(null, null);
            Assert.AreEqual(0, Result);
        }

        [TestMethod]
        public void AssertIfNullFirstNumberPassed_WillReturnMultiplication()
        {
            CalculateMgr calcMgr = new CalculateMgr();
            int Result = calcMgr.Multiply(null, 1);
            Assert.AreEqual(0, Result);
        }

        [TestMethod]
        public void AssertIfNullSecondNumberPassed_WillReturnMultiplication()
        {
            CalculateMgr calcMgr = new CalculateMgr();
            int Result = calcMgr.Multiply(1, null);
            Assert.AreEqual(0, Result);
        }

        [TestMethod]
        public void AssertIfNullBothNumberPassed_WillReturnMultiplication()
        {
            CalculateMgr calcMgr = new CalculateMgr();
            int Result = calcMgr.Multiply(null, null);
            Assert.AreEqual(0, Result);
        }

        [TestMethod]
        public void AssertIfNullFirstNumberPassed_WillReturnDivision()
        {
            CalculateMgr calcMgr = new CalculateMgr();
            int Result = calcMgr.Divide(null, 1);
            Assert.AreEqual(0, Result);
        }

        [TestMethod]
        public void AssertIfNullSecondNumberPassed_WillReturnDivision()
        {
            CalculateMgr calcMgr = new CalculateMgr();
            int Result = calcMgr.Divide(1, null);
            Assert.AreEqual(1, Result);
        }

        [TestMethod]
        public void AssertIfNullBothNumberPassed_WillReturnDivision()
        {
            CalculateMgr calcMgr = new CalculateMgr();
            int Result = calcMgr.Divide(null, null);
            Assert.AreEqual(0, Result);
        }
    }

}