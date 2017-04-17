namespace DesignPatterns.ChainOfResponsibility
{
    public class TenHandler : FactorizationHandler
    {
        protected override int Value => 10;

        protected override CurrencyType[] AcceptableCurrencies => new[] {CurrencyType.Ruble, CurrencyType.Eur, CurrencyType.Dollar};

        public TenHandler(FactorizationHandler nextHandler) : base(nextHandler)
        { }
    }
}