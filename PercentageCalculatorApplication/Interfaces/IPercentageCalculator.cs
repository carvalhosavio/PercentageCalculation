namespace PercentageCalculator.Interfaces
{
    public interface IPercentageCalculator
    {
        double CalcXPercentageOfY(double x, double y);
        double CalcPercentOfXOverY(double x , double y);
        double CalcPercentIncreaseXToY(double x, double y);
        double CalcPercentDecreaseXToY(double x, double y);
        double CalcIncreaseXPercentOfY(double x, double y);
        double CalcDecreaseXPercentOfY(double x, double y);
    }
}
