using System;

namespace DesignPatterns.State
{
    public class InitState : StateBase
    {
        public InitState(){}

        public InitState(StateBase state) : base(state)
        {
        }

        public override void InsertMoney(PrintingMachineContext context, int money)
        {
            MoneyLeft += money;
            if (MoneyLeft >= PrintingPrice)
            {
                context.State = new PlaceDocumentState(this);
            }
        }

        public override void PlaceDocuments(PrintingMachineContext context, string[] docs)
        {
            throw new Exception("Please, insert money");
        }

        public override void ChooseDocument(PrintingMachineContext context, int docId)
        {
            throw new Exception("Something went wrong");
        }

        public override string PrintDocument(PrintingMachineContext context)
        {
            throw new Exception("Something went wrong");
        }
    }
}