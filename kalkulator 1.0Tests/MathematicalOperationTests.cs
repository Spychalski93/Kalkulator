using Microsoft.VisualStudio.TestTools.UnitTesting;
using kalkulator_1._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator_1._0.Tests
{
    [TestClass()]
    public class MathematicalOperationTests
    {
        [TestMethod()]
        public void AdditionTest()
        {
            float score;
            score = MathematicalOperation.Addition(10, 5);
            Assert.AreEqual(15,score);
        }

        [TestMethod()]
        public void SubtractionTest()
        {
            float score;
            score = MathematicalOperation.Subtraction(10, 5);
            Assert.AreEqual(5, score);
        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            float score;
            score = MathematicalOperation.Multiplication(10, 5);
            Assert.AreEqual(50, score);
        }

        [TestMethod()]
        public void DivisionTest()
        {
            float score;
            score = MathematicalOperation.Division(10, 5);
            Assert.AreEqual(2, score);
        }
    }
}