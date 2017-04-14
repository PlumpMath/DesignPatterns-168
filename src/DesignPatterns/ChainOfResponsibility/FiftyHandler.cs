namespace DesignPatterns.ChainOfResponsibility
{
    public class FiftyHandler : FactorizationHandler
    {
        protected override int Value => 50;

        public FiftyHandler(FactorizationHandler nextHandler) : base(nextHandler)
        { }
    }
}