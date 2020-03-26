namespace CShp_UnitTestMoq
{
    public interface ICalculator
    {
        (string op, double result) Calculate(string op, double a, double b);
    }
}
