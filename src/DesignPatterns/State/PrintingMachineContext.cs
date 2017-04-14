namespace DesignPatterns.State
{
    public class PrintingMachineContext
    {
        public IState State { get; set; }

        public PrintingMachineContext()
        {
            State = new InitState();
        }

        public void InsertMoney(int money)
        {
            State.InsertMoney(this, money);
        }

        public void PlaceDocument(string[] documents)
        {
            State.PlaceDocuments(this, documents);
        }

        public void ChooseDocument(int documentId)
        {
            State.ChooseDocument(this, documentId);
        }

        public string PrintDocument()
        {
            return State.PrintDocument(this);
        }

        public int GetChange()
        {
            return State.GetChange(this);
        }
    }
}
