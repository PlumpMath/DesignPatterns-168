using System;

namespace DesignPatterns.State
{
    public class ChooseDocumentState : StateBase
    {
        public ChooseDocumentState(StateBase state) : base(state)
        {
        }

        public override void InsertMoney(PrintingMachineContext context, int money)
        {
            throw new Exception("Something went wrong");
        }

        public override void PlaceDocuments(PrintingMachineContext context, string[] docs)
        {
            throw new Exception("You have already inserted your data storage");
        }

        public override void ChooseDocument(PrintingMachineContext context, int docId)
        {
            SelectedDocumentId = docId;
            context.State = new PrintDocumentState(this);
        }

        public override string PrintDocument(PrintingMachineContext context)
        {
            throw new Exception("No document chosen");
        }
    }
}