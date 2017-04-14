using System;

namespace DesignPatterns.State
{
    public class PrintDocumentState : StateBase
    {
        public PrintDocumentState(StateBase state) : base(state)
        {
        }

        public override void InsertMoney(PrintingMachineContext context, int money)
        {
            throw new Exception("Something went wrong");
        }

        public override void PlaceDocuments(PrintingMachineContext context, string[] docs)
        {
            throw new Exception("You have alreade inserted data storage");
        }

        public override void ChooseDocument(PrintingMachineContext context, int docId)
        {
            SelectedDocumentId = docId;
            context.State = new PrintDocumentState(this);
        }

        public override string PrintDocument(PrintingMachineContext context)
        {
            MoneyLeft -= PrintingPrice;
            var selected = Documents[SelectedDocumentId];
            Console.WriteLine($"I am printing document {selected}");
            if (MoneyLeft < PrintingPrice)
            {
                context.State = new InitState(this);
            }
            else
            {
                context.State = new ChooseDocumentState(this);
            }
            return selected;
        }
    }
}