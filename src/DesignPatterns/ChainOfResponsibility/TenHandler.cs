namespace DesignPatterns.ChainOfResponsibility
{
    public class TenHandler : FactorizationHandler
    {
        protected override int Value => 10;

        public TenHandler(FactorizationHandler nextHandler) : base(nextHandler)
        { }
    }
}