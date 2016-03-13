using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task1;
namespace Task1.Tests
{
    [TestFixture]
    public class MathOperationsTests
    {
        [Test]
        [TestCase(4, 2, Result = 2)]
        [TestCase(27, 3, Result = 3)]
        [TestCase(16, 2, Result = 4)]
        [TestCase(100, 1, Result = 100)]
        public double Sqrt_SimpleNumbersWithZeroEps_ValueReturned(double number, int pow)
        {
            return MathOperations.Sqrt(number, pow, 0);
        }

        [Test]
        [TestCase(0, 10, 0.1)]
        [TestCase(25, 5, 0.1)]
        [TestCase(50, 3, 0.01)]
        [TestCase(1001, 4, 1E-12)]
        [TestCase(2045, 21, 1E-10)]
        public void Sqrt_DifferentEpsWithComparingNumberToPowResult(double number, int pow, double eps)
        {
            double sqrtResult = MathOperations.Sqrt(number, pow, eps);
            double expectedResult = Math.Pow(sqrtResult, pow);
            Assert.AreEqual(number, expectedResult, eps);
        }

        [Test]       
        [TestCase(-20, 3, 0.1,  ExpectedException = typeof(ArgumentException))]
        [TestCase(50, 0, 0, ExpectedException = typeof(ArgumentOutOfRangeException))]
        [TestCase(150, 2, -0.1, ExpectedException = typeof(ArgumentOutOfRangeException))]
        public void Sqrt_IncorrectArguments_ExceptionThrown(double number, int pow, double eps)
        {
            MathOperations.Sqrt(number, pow, eps);
        }



    }
}
