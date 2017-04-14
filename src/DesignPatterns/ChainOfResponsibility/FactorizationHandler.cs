using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class FactorizationHandler
    {
        private readonly FactorizationHandler _nextHandler;

        protected abstract int Value { get; }

        protected FactorizationHandler(FactorizationHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public virtual bool Validate(int nominal)
        {
            var remainder = nominal % Value;
            if (remainder == 0)
            {
                return true;
            }
            return _nextHandler != null && _nextHandler.Validate(remainder);
        }

        public virtual IEnumerable<int> CashOut(int nominal)
        {
            var quotient = nominal / Value;
            var remainder = nominal % Value;
            var result = Enumerable.Repeat(Value, quotient).ToList();
            if (remainder == 0)
            {
                return result;
            }
            result.AddRange(_nextHandler.CashOut(remainder));
            return result;
        }
    }
}