using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GitWpfApplication.Sources;

namespace GitWpfApplicationTest
{
    [TestClass]
    public class CalculatorVMTest
    {
        CalculatorVM calc;

        public CalculatorVMTest()
        {
            calc = new CalculatorVM();
        }

        [TestMethod]
        public void TestMultiplication()
        {            
            calc.Nombre1 = 2;
            calc.Nombre2 = 3;
            calc.Multiplier();
            Assert.AreEqual(6, calc.Result, "La multiplication est fausse");
        }

    }
}
