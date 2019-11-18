using System.Collections;
using Example_06.ChainOfResponsibility.Handlers;

namespace Example_06.ChainOfResponsibility
{
    public class Bancomat
    {
        private readonly BanknoteHandler _handler;

        public Bancomat(BanknoteHandler banknoteHandler)
        {
            _handler = banknoteHandler;
        }

        public bool Validate(string banknote)
        {
            return _handler.Validate(banknote);
        }

        public IBanknote WithdrawMoney(int expectedMoney)
        {
            return _handler.GetBanknote(expectedMoney);
        }
    }
}