
using PercentageCalculator;

namespace PercentageCalculationTest
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            double result = Percentage.PctXOfY(10, 100);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Test2()
        {
            double result = Percentage.PctOfXOverY(10, 100);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Test3()
        {
            double result = Percentage.PctIncreaseXToY(10, 100);
            Assert.AreEqual(900, result);
        }

        [Test]
        public void Test4()
        {
            double result = Percentage.PctDecreaseXToY(100, 10);
            Assert.AreEqual(90, result);
        }

        [Test]
        public void Test5()
        {
            double result = Percentage.IncreaseXPctOfY(10, 50);
            Assert.AreEqual(55, result);
        }

        [Test]
        public void Test6()
        {
            double result = Percentage.DecreaseXPctOfY(10, 50);
            Assert.AreEqual(45, result);
        }
    }
}