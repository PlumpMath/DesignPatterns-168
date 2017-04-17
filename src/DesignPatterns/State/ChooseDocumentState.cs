using System;

namespace DesignPatterns.State
{
    public class ChooseDocumentState : StateBase
    {
        public ChooseDocumentState(StateBase state) : base(state)
        {
        }

        public override IState InsertMoney(int money)
        {
            throw new Exception("Something went wrong");
        }

        public override IState PlaceDocuments(string[] docs)
        {
            throw new Exception("You have already inserted your data storage");
        }

        public override IState ChooseDocument(int docId)
        {
            SelectedDocumentId = docId;
            return new PrintDocumentState(this);
        }

        public override IState PrintDocument(out string printed)
        {
            throw new Exception("No document chosen");
        }
    }
}