using System;

namespace DesignPatterns.State
{
    public class PlaceDocumentState : StateBase
    {
        public PlaceDocumentState(StateBase state) : base(state)
        {
        }

        public override IState InsertMoney(int money)
        {
            MoneyLeft += money;
            return this;
        }

        public override IState PlaceDocuments(string[] docs)
        {
            Documents = docs;
            return new ChooseDocumentState(this);
        }

        public override IState ChooseDocument(int docId)
        {
            throw new Exception("Place documents first");
        }

        public override IState PrintDocument(out string printed)
        {
            throw new Exception("Something went wrong");
        }
    }
}