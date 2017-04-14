using System;

namespace DesignPatterns.State
{
    public class PlaceDocumentState : StateBase
    {
        public PlaceDocumentState(StateBase state) : base(state)
        {
        }

        public override void InsertMoney(PrintingMachineContext context, int money)
        {
            MoneyLeft += money;
        }

        public override void PlaceDocuments(PrintingMachineContext context, string[] docs)
        {
            Documents = docs;
            context.State = new ChooseDocumentState(this);
        }

        public override void ChooseDocument(PrintingMachineContext context, int docId)
        {
            throw new Exception("Place documents first");
        }

        public override string PrintDocument(PrintingMachineContext context)
        {
            throw new Exception("Something went wrong");
        }
    }
}