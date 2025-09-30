using Calculator;
using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculations calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculations();
        }
         
        [TestCase(7, 4, 11)]     
        [TestCase(10, -6, 4)]    
        [TestCase(-8, -12, -20)] 
        [TestCase(-15, 9, -6)]   
        public void Test_Sum(double a, double b, double expected)
        {
            Assert.AreEqual(expected, calculator.Sum(a, b));
        }

        [TestCase(20, 5, 15)]     
        [TestCase(9, -4, 13)]     
        [TestCase(-14, -6, -8)]  
        [TestCase(-7, 11, -18)]   
        public void Test_Subtract(double a, double b, double expected)
        {
            Assert.AreEqual(expected, calculator.Subtract(a, b));
        }

        [TestCase(3, 6, 18)]      
        [TestCase(12, -2, -24)]   
        [TestCase(-7, -5, 35)]    
        [TestCase(-9, 4, -36)]    
        public void Test_Multiply(double a, double b, double expected)
        {
            Assert.AreEqual(expected, calculator.Multiply(a, b));
        }
        [TestCase(18, 6, 3)]       
        [TestCase(25, -5, -5)]    
        [TestCase(-16, -8, 2)]     
        [TestCase(-49, 7, -7)]     
        public void Test_Divide(double a, double b, double expected)
        {
            Assert.AreEqual(expected, calculator.Divide(a, b));
        }
        [Test]
        public void Test_Divide_ByZero_ShouldThrow()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }


        [TestCase(3, 4, 81)]          
        [TestCase(5, -2, 0.04)]       
        [TestCase(-2, -3, -0.125)]    
        [TestCase(-4, 3, -64)]       
        public void Test_Power(double a, double b, double expected)
        {
            Assert.AreEqual(expected, calculator.Power(a, b));
        }
    }
}
