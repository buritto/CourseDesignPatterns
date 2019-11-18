namespace Example_06.ChainOfResponsibility.Handlers.EurHandlers
{
    public class TwoEurHandler : EurHandlerBase
    {
        public TwoEurHandler(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }

        protected override int Value => 2;
    }
}