namespace DesignPatterns.ChainOfResponsibility
{
    public class ThousandHandler : FactorizationHandler
    {
        protected override int Value => 1000;

        public ThousandHandler(FactorizationHandler nextHandler) : base(nextHandler)
        { }
    }
}