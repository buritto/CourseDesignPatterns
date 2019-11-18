namespace Example_06.ChainOfResponsibility.Handlers.RublesHandlers
{
    public abstract class RublesHandlerBase : BanknoteHandler
    {
        public override bool Validate(string banknote)
        {
            return banknote.Equals($"{Value} Рублей$") || base.Validate(banknote);
        }

        public override IBanknote GetBanknote(int expectedMoney)
        {
            var value = Withdraw(expectedMoney);
            return new Banknote(CurrencyType.Ruble, value);
        }


        protected RublesHandlerBase(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }
    }
}