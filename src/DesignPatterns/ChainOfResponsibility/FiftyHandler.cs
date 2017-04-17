namespace DesignPatterns.ChainOfResponsibility
{
    public class FiftyHandler : FactorizationHandler
    {
        protected override int Value => 50;

        protected override CurrencyType[] AcceptableCurrencies => new[] {CurrencyType.Ruble, CurrencyType.Dollar, CurrencyType.Eur };

        public FiftyHandler(FactorizationHandler nextHandler) : base(nextHandler)
        { }
    }
}