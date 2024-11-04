using FluentValidation;

namespace b3.investment.calculator.Server.Request
{
    public class InvestmentRequestValidator : AbstractValidator<InvestmentRequest>
    {
        public InvestmentRequestValidator()
        {
            RuleFor(request => request.Monetary)
                .GreaterThan(0).WithMessage(Messages.MSG_01);

            RuleFor(request => request.Period)
                .GreaterThan(0).WithMessage(Messages.MSG_02);
        }
    }
}
