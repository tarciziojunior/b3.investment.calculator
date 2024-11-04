using b3.investment.calculator.Server.Request;

namespace b3.investment.calculator.Server.Service.Interface
{
    public interface IInterestCalculatorService
    {
        InvestmentResponse InterestCalculator(decimal monetary, int months);
    }
}
