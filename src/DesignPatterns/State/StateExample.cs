using System;

namespace DesignPatterns.State
{
    public static class StateExample
    {
        public static void Introduce()
        {
            var context = new PrintingMachineContext();
            context.InsertMoney(5);
            context.InsertMoney(5);
            context.InsertMoney(5);
            context.InsertMoney(5);
            context.InsertMoney(5);
            context.PlaceDocument(new []{ "123", "456" });
            context.ChooseDocument(1);
            context.ChooseDocument(0);
            context.PrintDocument();
            context.ChooseDocument(1);
            context.PrintDocument();
            var change = context.GetChange();

            Console.WriteLine(change);
        }
    }
}
