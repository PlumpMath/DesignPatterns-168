using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public static class ChainOfResponsibilityExample
    {
        public static void Introduce()
        {
            var atm = new Atm();

            CashOut(atm, "$3550");

            CashOut(atm, "20€");

            CashOut(atm, "1230 рублей");

            Console.WriteLine();
        }

        private static void CashOut(Atm atm, string value)
        {
            var money = atm.CashOut(value);

            Console.WriteLine(string.Join(", ", money));
        }
    }
}
