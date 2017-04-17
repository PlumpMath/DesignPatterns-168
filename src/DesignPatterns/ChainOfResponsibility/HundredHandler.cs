namespace DesignPatterns.ChainOfResponsibility
{
    public class HundredHandler : FactorizationHandler
    {
        protected override int Value => 100;
        protected override CurrencyType[] AcceptableCurrencies => new [] { CurrencyType.Ruble, CurrencyType.Eur };

        public HundredHandler(FactorizationHandler nextHandler) : base(nextHandler)
        { }
    }
}