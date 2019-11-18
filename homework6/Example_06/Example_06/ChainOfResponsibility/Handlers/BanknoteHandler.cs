using System;

namespace Example_06.ChainOfResponsibility.Handlers
{
    public abstract class BanknoteHandler

    {
        private readonly BanknoteHandler _nextHandler;

        protected BanknoteHandler(BanknoteHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        protected string Withdraw(int expectedMoney)
        {
            if (expectedMoney < Value)
                return _nextHandler.Withdraw(expectedMoney);

            var balance = expectedMoney;
            var count = 0;
            while (balance >= Value)
            {
                count++;
                balance -= Value;
            }

            if (balance == 0)
                return $"{Value}x{count}";

            if (_nextHandler is null)
            {
                throw new InvalidOperationException($"no banknotes less than or equal {balance}");
            }

            return $"{Value}x{count} + {_nextHandler.Withdraw(balance)}";
        }


        public virtual bool Validate(string banknote)
        {
            return _nextHandler != null && _nextHandler.Validate(banknote);
        }

        public abstract IBanknote GetBanknote(int expectedMoney);

        protected abstract int Value { get; }
    }
}