namespace DesignPatterns.State
{
    public abstract class StateBase : IState
    {
        protected int PrintingPrice => 10;
        protected int MoneyLeft { get; set; }
        protected string[] Documents { get; set; }
        protected int SelectedDocumentId { get; set; }

        protected StateBase() { }

        protected StateBase(StateBase state)
        {
            MoneyLeft = state.MoneyLeft;
            Documents = state.Documents;
            SelectedDocumentId = state.SelectedDocumentId;
        }

        public abstract void InsertMoney(PrintingMachineContext context, int money);

        public abstract void PlaceDocuments(PrintingMachineContext context, string[] docs);

        public abstract void ChooseDocument(PrintingMachineContext context, int docId);

        public abstract string PrintDocument(PrintingMachineContext context);

        public int GetChange(PrintingMachineContext context)
        {
            var result = MoneyLeft;
            MoneyLeft = 0;
            context.State = new InitState(this);
            return result;
        }
    }
}