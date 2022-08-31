using ButterflySystems.Services.Contracts;

namespace ButterflySystems.Services.Concretes
{
    public class CalculateService : ICalculateService
    {
        //Add two numbers
        public decimal CalculateAdd(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        //Subtract two numbers
        public decimal CalculateSubtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        //Multiply two numbers
        public decimal CalculateMultiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        //Divide two numbers
        public decimal CalculateDivide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
    }
}
