namespace DesignPatterns.State
{
    public interface IState
    {
        void InsertMoney(PrintingMachineContext context, int money);
        void PlaceDocuments(PrintingMachineContext context, string[] docs);
        void ChooseDocument(PrintingMachineContext context, int docId);
        string PrintDocument(PrintingMachineContext context);
        int GetChange(PrintingMachineContext context);
    }
}