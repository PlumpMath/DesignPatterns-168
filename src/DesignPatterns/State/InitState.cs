using System;

namespace DesignPatterns.State
{
    public class InitState : StateBase
    {
        public InitState(){}

        public InitState(StateBase state) : base(state)
        {
        }

        public override IState InsertMoney(int money)
        {
            MoneyLeft += money;
            if (MoneyLeft >= PrintingPrice)
            {
                return new PlaceDocumentState(this);
            }
            return this;
        }

        public override IState PlaceDocuments(string[] docs)
        {
            throw new Exception("Please, insert money");
        }

        public override IState ChooseDocument(int docId)
        {
            throw new Exception("Something went wrong");
        }

        public override IState PrintDocument(out string printed)
        {
            throw new Exception("Something went wrong");
        }
    }
}