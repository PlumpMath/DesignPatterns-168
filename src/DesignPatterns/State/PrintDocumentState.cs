using System;

namespace DesignPatterns.State
{
    public class PrintDocumentState : StateBase
    {
        public PrintDocumentState(StateBase state) : base(state)
        {
        }

        public override IState InsertMoney(int money)
        {
            throw new Exception("Something went wrong");
        }

        public override IState PlaceDocuments(string[] docs)
        {
            throw new Exception("You have alreade inserted data storage");
        }

        public override IState ChooseDocument(int docId)
        {
            SelectedDocumentId = docId;
            return new PrintDocumentState(this);
        }

        public override IState PrintDocument(out string printed)
        {
            MoneyLeft -= PrintingPrice;
            printed = Documents[SelectedDocumentId];
            Console.WriteLine($"I am printing document {printed}");
            if (MoneyLeft < PrintingPrice)
            {
                return new InitState(this);
            }
            return new ChooseDocumentState(this);
        }
    }
}