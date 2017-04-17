namespace DesignPatterns.ChainOfResponsibility
{
    public class ThousandHandler : FactorizationHandler
    {
        protected override int Value => 1000;
        protected override CurrencyType[] AcceptableCurrencies => new[] {CurrencyType.Ruble, CurrencyType.Dollar};

        public ThousandHandler(FactorizationHandler nextHandler) : base(nextHandler)
        { }
    }
}