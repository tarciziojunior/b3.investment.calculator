using b3.investment.calculator.Server.Domain.InvestmentTax;
using b3.investment.calculator.Server.Request;
using b3.investment.calculator.Server.Service.Interface;

namespace b3.investment.calculator.Server.Service
{
    public class InterestCalculatorService : IInterestCalculatorService
    {
        private const decimal CDI = 0.009m;
        private const decimal TB = 1.08m;

        public InvestmentResponse InterestCalculator(decimal monetary, int months)
        {
            return new InvestmentResponse
            {
                Gross = GetGrossProfitability(monetary, months),
                Net = GetNetIncome(monetary, months)
            };
        }
        public static decimal GetGrossProfitability(decimal monetary, int months)
        {
            // Fórmula: A = P * (1 + i) ^ n           
            return monetary * Convert.ToDecimal(Math.Pow((double)(1 + GetTax()), months)); 

        }
        public static decimal GetNetIncome(decimal monetary, int months)
        {
            ITaxRate taxRate = TaxRateFactory.CreateTaxRate(months);
            var aux = GetGrossProfitability(monetary, months) - monetary;
            return monetary + taxRate.CalculateTax(aux);
        }

        public static decimal GetTax()
        {          
            return CDI * TB;
        }
    }
}
