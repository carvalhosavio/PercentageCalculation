namespace PercentageCalculator
{
    public static class Percentage
    {
        private const double PercentageParam = 100;

        /// <summary>Returns the percentage equivalent to X percent of Y.</summary>
        public static double PctXOfY(double x, double y)
        {
            return x * y / PercentageParam;
        }

        /// <summary>Returns the percentage equivalent to X over Y.</summary>
        public static double PctOfXOverY(double x, double y)
        {
            return x / y * PercentageParam;
        }

        /// <summary>Returns the percentage equivalent to the increase from X to Y</summary>
        public static double PctIncreaseXToY(double x, double y)
        {
            return (y - x) / x * PercentageParam;
        }

        /// <summary>Returns the percentage equivalent to the decrease from X to Y</summary>
        public static double PctDecreaseXToY(double x, double y)
        {
            return Math.Abs(PctIncreaseXToY(x, y));
        }

        /// <summary>Returns the equivalent of increasing X percent of Y</summary>
        public static double IncreaseXPctOfY(double x, double y)
        {
            return x + PctYOfX(x, y);
        }

        /// <summary>Returns the equivalent of decreasing X percent of Y</summary>
        public static double DecreaseXPctOfY(double x, double y)
        {
            return x - PctYOfX(x, y);
        }

        private static double PctYOfX(double x, double y)
        {
            return y / PercentageParam * x;
        }
    }
}
