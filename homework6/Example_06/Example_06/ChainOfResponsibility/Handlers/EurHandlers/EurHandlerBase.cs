namespace Example_06.ChainOfResponsibility.Handlers.EurHandlers
{
    public abstract class EurHandlerBase : BanknoteHandler
    {
        public override bool Validate(string banknote)
        {
            return banknote.Equals($"{Value} Euro") || base.Validate(banknote);
        }


        public override IBanknote GetBanknote(int expectedMoney)
        {
            var value = Withdraw(expectedMoney);
            return new Banknote(CurrencyType.Eur, value);
        }

        protected EurHandlerBase(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }
    }
}