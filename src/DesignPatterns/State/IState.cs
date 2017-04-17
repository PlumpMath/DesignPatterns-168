namespace DesignPatterns.State
{
    public interface IState
    {
        IState InsertMoney(int money);
        IState PlaceDocuments(string[] docs);
        IState ChooseDocument(int docId);
        IState PrintDocument(out string printed);
        IState GetChange(out int change);
    }
}