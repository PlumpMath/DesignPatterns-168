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

        public abstract IState InsertMoney(int money);

        public abstract IState PlaceDocuments(string[] docs);

        public abstract IState ChooseDocument(int docId);

        public abstract IState PrintDocument(out string printed);

        public IState GetChange(out int change)
        {
            change = MoneyLeft;
            MoneyLeft = 0;
            return new InitState(this);
        }
    }
}