namespace Example_06.ChainOfResponsibility.Handlers.DollarsHandlers
{
    public abstract class DollarHandlerBase : BanknoteHandler
    {
        public override bool Validate(string banknote)
        {
            return banknote.Equals($"{Value}$") || base.Validate(banknote);
        }

        public override IBanknote GetBanknote(int expectedMoney)
        {
            var value = Withdraw(expectedMoney);
            return new Banknote(CurrencyType.Dollar, value);
        }
        

        

        protected DollarHandlerBase(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }
    }
}