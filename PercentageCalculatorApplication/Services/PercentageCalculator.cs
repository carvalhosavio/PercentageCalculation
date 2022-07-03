using PercentageCalculator.Interfaces;

namespace PercentageCalculator.Services
{
    public class PercentageCalculator : IPercentageCalculator
    {
        private const double PercentageParam = 100;
        public double CalcXPercentageOfY(double x, double y)
        {
            return ((x * y) / PercentageParam);
        }

        public double CalcPercentOfXOverY(double x, double y)
        {
            return ((x / y) * PercentageParam);
        }

        public double CalcPercentIncreaseXToY(double x, double y)
        {
            return ((y - x) / x) * PercentageParam;
        }

        public double CalcPercentDecreaseXToY(double x, double y)
        {
            return Math.Abs(CalcPercentIncreaseXToY(x,y));
        }

        public double CalcIncreaseXPercentOfY(double x, double y)
        {
            return x + CalcPercentageYOfX(x ,y );
        }
        public double CalcDecreaseXPercentOfY(double x, double y)
        {
            return x - CalcPercentageYOfX(x, y);
        }

        private static double CalcPercentageYOfX(double x, double y)
        {
            return ((y / PercentageParam) * x);
        }
    }
}
