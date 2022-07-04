namespace PercentageCalculator
{
    public static class Percentage
    {
        private const double PercentageParam = 100;

        /// <summary>Returns the percentage equivalent to X percent of Y.</summary>
        /// <param name="x">A number greater than 0. representing percentage </param>
        /// <param name="y">A number greater than 0</param>
        public static double CalcPercentageXOfY(double x, double y)
        {
            return x * y / PercentageParam;
        }

        /// <summary>Returns the percentage equivalent to X over Y.</summary>
        /// <param name="x">A number greater than 0.</param>
        /// <param name="y">A number greater than 0.</param>
        public static double CalcPercentOfXOverY(double x, double y)
        {
            return x / y * PercentageParam;
        }

        /// <summary>Returns the percentage equivalent to the increase from X to Y</summary>
        /// <param name="x">A number greater than 0.</param>
        /// <param name="y">A number greater than 0.</param>
        public static double CalcPercentIncreaseXToY(double x, double y)
        {
            return (y - x) / x * PercentageParam;
        }

        /// <summary>Returns the equivalent of increasing X percent of Y</summary>
        /// <param name="x">A number greater than 0.</param>
        /// <param name="y">A number greater than 0.</param>
        public static double CalcPercentDecreaseXToY(double x, double y)
        {
            return Math.Abs(CalcPercentIncreaseXToY(x, y));
        }

        /// <summary>Returns the equivalent of increasing X percent of Y</summary>
        /// <param name="x">A number greater than 0. representing percentage </param>
        /// <param name="y">A number greater than 0.</param>
        public static double CalcIncreaseXPercentOfY(double x, double y)
        {
            return x + CalcPercentageYOfX(x, y);
        }

        /// <summary>Returns the equivalent of decreasing X percent of Y</summary>
        /// <param name="x">A number greater than 0. representing percentage </param>
        /// <param name="y">A number greater than 0.</param>
        public static double CalcDecreaseXPercentOfY(double x, double y)
        {
            return x - CalcPercentageYOfX(x, y);
        }

        private static double CalcPercentageYOfX(double x, double y)
        {
            return y / PercentageParam * x;
        }
    }
}
