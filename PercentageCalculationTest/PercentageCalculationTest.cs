using PercentageCalculator;
using PercentageCalculator.Interfaces;

namespace PercentageCalculationTest
{
    public class Tests
    {
        private IPercentageCalculator _percentageCalculator;
        [SetUp]
        public void Setup()
        {
            _percentageCalculator = new PercentageCalculator.Services.PercentageCalculator();
        }

        [Test]
        public void Test1()
        {
            double result = _percentageCalculator.CalcXPercentageOfY(10, 100);
            Assert.AreEqual(10,result);
        }

        [Test]
        public void Test2()
        {
            double result = _percentageCalculator.CalcPercentOfXOverY(10, 100);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Test3()
        {
            double result = _percentageCalculator.CalcPercentIncreaseXToY(10, 100);
            Assert.AreEqual(900, result);
        }

        [Test]
        public void Test4()
        {
            double result = _percentageCalculator.CalcPercentDecreaseXToY(100, 10);
            Assert.AreEqual(90, result);
        }

        [Test]
        public void Test5()
        {
            double result = _percentageCalculator.CalcIncreaseXPercentOfY(100, 10);
            Assert.AreEqual(110, result);
        }

        [Test]
        public void Test6()
        {
            double result = _percentageCalculator.CalcDecreaseXPercentOfY(100, 10);
            Assert.AreEqual(90, result);
        }
    }
}