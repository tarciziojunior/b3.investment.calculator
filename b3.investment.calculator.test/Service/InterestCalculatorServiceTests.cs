using b3.investment.calculator.Server.Domain.InvestmentTax;
using b3.investment.calculator.Server.Request;
using b3.investment.calculator.Server.Service;

namespace b3.investment.calculator.test.Service
{
    [TestFixture]
    public class InterestCalculatorServiceTests
    {
        private InterestCalculatorService _interestCalculatorService;

        [SetUp]
        public void Setup()
        {
            _interestCalculatorService = new InterestCalculatorService();
        }

        [Test]
        public void InterestCalculator_ShouldCalculateGrossAndNetIncome_Correctly()
        {
            // Arrange
            decimal monetary = 1000m; // Valor monetário
            int months = 12; // Meses

            // Act
            InvestmentResponse response = _interestCalculatorService.InterestCalculator(monetary, months);

            // Assert
            Assert.That(response, Is.Not.Null, "The InvestmentResponse should not be null.");
            Assert.That(response.Gross, Is.GreaterThan(0), "Gross profitability should be greater than zero.");
            Assert.That(response.Net, Is.GreaterThan(0), "Net income should be greater than zero.");
        }

        [Test]
        public void GetGrossProfitability_ShouldReturnCorrectValue()
        {
            // Arrange
            decimal monetary = 1000m; // Valor monetário
            int months = 12; // Meses
            decimal expectedGrossProfitability = monetary * (decimal)Math.Pow((double)(1 + InterestCalculatorService.GetTax()), months);

            // Act
            decimal result = InterestCalculatorService.GetGrossProfitability(monetary, months);

            // Assert
            Assert.That(result, Is.EqualTo(expectedGrossProfitability), "Gross profitability calculation is incorrect.");
        }

        [Test]
        public void GetNetIncome_ShouldReturnCorrectValue()
        {
            // Arrange
            decimal monetary = 1000m; // Valor monetário
            int months = 12; // Meses
            ITaxRate taxRate = TaxRateFactory.CreateTaxRate(months);
            decimal grossProfit = InterestCalculatorService.GetGrossProfitability(monetary, months) - monetary;
            decimal expectedNetIncome = monetary + taxRate.CalculateTax(grossProfit);

            // Act
            decimal result = InterestCalculatorService.GetNetIncome(monetary, months);

            // Assert
            Assert.That(result, Is.EqualTo(expectedNetIncome), "Net income calculation is incorrect.");
        }
    }
}
