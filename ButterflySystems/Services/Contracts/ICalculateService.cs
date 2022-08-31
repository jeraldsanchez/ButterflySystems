namespace ButterflySystems.Services.Contracts
{
    public interface ICalculateService
    {
        decimal CalculateAdd(decimal num1, decimal num2);

        decimal CalculateSubtract(decimal num1, decimal num2);

        decimal CalculateMultiply(decimal num1, decimal num2);

        decimal CalculateDivide(decimal num1, decimal num2);
    }
}
