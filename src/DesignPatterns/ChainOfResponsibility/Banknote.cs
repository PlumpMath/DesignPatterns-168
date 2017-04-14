using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Banknote
    {
        public CurrencyType Currency { get; set; }
        public int Nominal { get; set; }

        public override string ToString()
        {
            switch (Currency)
            {
                case CurrencyType.Eur:
                    return $"{Nominal}€";
                case CurrencyType.Dollar:
                    return $"${Nominal}";
                case CurrencyType.Ruble:
                    return $"{Nominal} рублей";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}