using FluentValidation.TestHelper;
using b3.investment.calculator.Server.Request;
using b3.investment.calculator.Server;

namespace b3.investment.calculator.test.Request
{
    [TestFixture]
    public class InvestmentRequestValidatorTests
    {
        private InvestmentRequestValidator _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new InvestmentRequestValidator();
        }

        [Test]
        public void Should_Have_Error_When_Monetary_Is_Less_Than_Or_Equal_To_Zero()
        {
            // Arrange
            var request = new InvestmentRequest { Monetary = 0, Period = 12 };

            // Act
            var result = _validator.TestValidate(request);

            // Assert            
            Assert.That(result.Errors[0].ErrorMessage, Is.EqualTo(Messages.MSG_01));
        }

        [Test]
        public void Should_Have_Error_When_Months_Are_Less_Than_Or_Equal_To_Zero()
        {
            // Arrange
            var request = new InvestmentRequest { Monetary = 1000, Period = 0 };

            // Act
            var result = _validator.TestValidate(request);

            // Assert                        
            Assert.That(result.Errors[0].ErrorMessage, Is.EqualTo(Messages.MSG_02));
            
        }

        [Test]
        public void Should_Not_Have_Error_When_Valid_Request()
        {
            // Arrange
            var request = new InvestmentRequest { Monetary = 1000, Period = 12 };

            // Act
            var result = _validator.TestValidate(request);

            // Assert
            result.ShouldNotHaveAnyValidationErrors();
        }
    }
}