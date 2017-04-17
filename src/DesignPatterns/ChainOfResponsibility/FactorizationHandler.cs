using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class FactorizationHandler
    {
        private readonly FactorizationHandler _nextHandler;

        protected abstract int Value { get; }

        protected abstract CurrencyType[] AcceptableCurrencies { get; }

        protected FactorizationHandler(FactorizationHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        protected bool IsAvailable(Banknote banknote)
        {
            return AcceptableCurrencies.Contains(banknote.Currency);
        }

        public virtual bool Validate(Banknote banknote)
        {
            if (!IsAvailable(banknote))
            {
                return _nextHandler != null && _nextHandler.Validate(banknote);
            }
            var remainder = banknote.Nominal % Value;
            if (remainder == 0)
            {
                return true;
            }
            var transformed = new Banknote
            {
                Currency = banknote.Currency,
                Nominal = remainder
            };
            return _nextHandler != null && _nextHandler.Validate(transformed);
        }

        public virtual IEnumerable<int> CashOut(Banknote banknote)
        {
            if (!IsAvailable(banknote))
            {
                foreach (var banknoteObject in _nextHandler.CashOut(banknote))
                {
                    yield return banknoteObject;
                }
                yield break;
            }
            var nominal = banknote.Nominal;
            var quotient = nominal/Value;
            var remainder = nominal%Value;
            foreach (var banknoteObject in Enumerable.Repeat(Value, quotient))
            {
                yield return banknoteObject;
            }
            if (remainder == 0)
            {
                yield break;
            }
            foreach (var banknoteObject in _nextHandler.CashOut(new Banknote
            {
                Currency = banknote.Currency,
                Nominal = remainder
            }))
            {
                yield return banknoteObject;
            }
        }
    }
}