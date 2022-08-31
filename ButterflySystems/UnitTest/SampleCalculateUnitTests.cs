using ButterflySystems.Services.Concretes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ButterflySystems.UnitTest
{
    [TestClass]
    public class SampleCalculateUnitTests
    {
        private readonly CalculateService _calculateService;

        [TestInitialize]
        public void Init()
        {
            // put code in here that you want to have run before each test
        }

        [TestMethod]
        public void AddTwoNumbers_CalculatesSumSuccessfully()
        {
            // Arrange
            var answer = 8.0m;

            // Act
            var result = _calculateService.CalculateAdd(5.0m, 3.0m);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(answer, result);
        }

        [TestMethod]
        public void SubtractTwoNumbers_CalculatesDifferenceSuccessfully()
        {
            // Arrange
            var answer = 8.0m;

            // Act
            var result = _calculateService.CalculateSubtract(5.0m, 3.0m);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(answer, result);
        }

        [TestMethod]
        public void MultiplyTwoNumbers_CalculatesProductSuccessfully()
        {
            // Arrange
            var answer = 8.0m;

            // Act
            var result = _calculateService.CalculateMultiply(5.0m, 3.0m);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(answer, result);
        }

        [TestMethod]
        public void DivideTwoNumbers_CalculatesQuotientSuccessfully()
        {
            // Arrange
            var answer = 8.0m;

            // Act
            var result = _calculateService.CalculateDivide(5.0m, 3.0m);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(answer, result);
        }
    }
}
