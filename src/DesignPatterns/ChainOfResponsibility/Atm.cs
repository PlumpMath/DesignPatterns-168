using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Atm
    {
        private readonly FactorizationHandler _handler;

        public Atm()
        {
            _handler = new TenHandler(null);
            _handler = new FiftyHandler(_handler);
            _handler = new HundredHandler(_handler);
            _handler = new ThousandHandler(_handler);
        }

        public bool Validate(string banknote)
        {
            var banknoteObject = GetBanknote(banknote);
            return _handler.Validate(banknoteObject);
        }

        public IEnumerable<Banknote> CashOut(string banknote)
        {
            var banknoteObject = GetBanknote(banknote);
            if (!_handler.Validate(banknoteObject))
            {
                throw new ArgumentException();
            }
            var nominals = _handler.CashOut(banknoteObject);
            return nominals.Select(x => new Banknote
            {
                Currency = banknoteObject.Currency,
                Nominal = x
            });
        }

        private Banknote GetBanknote(string banknote)
        {
            var bankNote = new Banknote
            {
                Currency = ParseCurrency(banknote),
                Nominal = ParseValue(banknote)
            };
            return bankNote;
        }

        private int ParseValue(string banknote)
        {
            var match = Regex.Match(banknote, "\\D*(?<number>\\d+)\\D*");
            if (match.Success)
            {
                return int.Parse(match.Groups["number"].Value);
            }
            throw new ArgumentException();
        }

        private CurrencyType ParseCurrency(string banknote)
        {
            if (banknote.Contains("$"))
            {
                return CurrencyType.Dollar;
            }
            if (banknote.Contains("€"))
            {
                return CurrencyType.Eur;
            }
            if (banknote.ToLower().Contains("руб"))
            {
                return CurrencyType.Ruble;
            }
            throw new NotSupportedException("Введённый тип валюты не поддерживается");
        }
    }
}
