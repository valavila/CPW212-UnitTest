using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW212_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        double result; 
        
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            //Arrange 
            result = num1 + num2;

            //Act
            double sum = SimpleMath.Add(num1, num2);

            //Assert

            Assert.AreEqual(result, sum);

        }

        [TestMethod]
        [DataRow(1, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -1)]
        [DataRow(0, -0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            result = num1 * num2;

            double product = SimpleMath.Multiply(num1, num2);

            Assert.AreEqual(result, product);


        }

        [TestMethod]
        [DataRow(4, -0)]
        [DataRow(7, 0)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            Assert.ThrowsException<ArgumentException> ( () => SimpleMath.Divide(num1, num2) );
        }

        [TestMethod]
        [DataRow(1, 20)]
        [DataRow(0, 10)]
        [DataRow(-1, -10)]
        public void Divide_TwoValidNumberss_ReturnsQuotient(double num1, double num2)
        {
           result = num1 / num2;

            double quotient = SimpleMath.Divide(num1, num2);

            Assert.AreEqual(result, quotient);
        }

        [TestMethod()]
        [DataRow(1, 10)]
        [DataRow(0, 10)]
        [DataRow(-1, -1)]
        public void Subtract_TwoNumbers_ReturnsDifference(double num1, double num2)
        {
            result = num1 - num2;

            double difference = SimpleMath.Subtract(num1, num2);

            Assert.AreEqual(result, difference);
        }
    }
}