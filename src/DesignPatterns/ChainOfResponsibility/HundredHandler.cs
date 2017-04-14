namespace DesignPatterns.ChainOfResponsibility
{
    public class HundredHandler : FactorizationHandler
    {
        protected override int Value => 100;

        public HundredHandler(FactorizationHandler nextHandler) : base(nextHandler)
        { }
    }
}