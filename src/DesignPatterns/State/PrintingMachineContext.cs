namespace DesignPatterns.State
{
    public class PrintingMachineContext
    {
        private IState State { get; set; }

        public PrintingMachineContext()
        {
            State = new InitState();
        }

        public void InsertMoney(int money)
        {
            State = State.InsertMoney(money);
        }

        public void PlaceDocument(string[] documents)
        {
            State = State.PlaceDocuments(documents);
        }

        public void ChooseDocument(int documentId)
        {
            State = State.ChooseDocument(documentId);
        }

        public string PrintDocument()
        {
            string printedDocument;
            State = State.PrintDocument(out printedDocument);
            return printedDocument;
        }

        public int GetChange()
        {
            int change;
            State =  State.GetChange(out change);
            return change;
        }
    }
}
