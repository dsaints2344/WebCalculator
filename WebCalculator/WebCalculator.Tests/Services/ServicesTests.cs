using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebCalculator;
using WebCalculator.Controllers;


namespace WebCalculator.Tests.Services
{
    [TestClass]
    public class ServicesTests
    {
        [TestMethod]
        public void SumOnePlusOne()
        {
            CalculatorService.CalculatorService cs = new CalculatorService.CalculatorService();
            double expected = 2;
            OperationResult obj = new OperationResult
            {
                FirstNumber = 1,
                SecondNumber = 1
            };
            obj.Result = cs.Addition(obj.FirstNumber, obj.SecondNumber);
            

            Assert.AreEqual(expected, obj.Result);

        }

        [TestMethod]
        public void SumOnePlusZeroEqualsOne()
        {
            CalculatorService.CalculatorService cs = new CalculatorService.CalculatorService();
            double expected = 1;
            OperationResult obj = new OperationResult
            {
                FirstNumber = 1,
                SecondNumber = 0
            };
            obj.Result = cs.Addition(obj.FirstNumber, obj.SecondNumber);


            Assert.AreEqual(expected, obj.Result);

        }


        [TestMethod]
        public void IsNotFour()
        {
            CalculatorService.CalculatorService cs = new CalculatorService.CalculatorService();
            double notExpected = 4;
            OperationResult obj = new OperationResult
            {
                FirstNumber = 2,
                SecondNumber = 1
            };
            obj.Result = cs.Addition(obj.FirstNumber, obj.SecondNumber);


            Assert.AreNotEqual(notExpected, obj.Result);

        }
        
    }

}
