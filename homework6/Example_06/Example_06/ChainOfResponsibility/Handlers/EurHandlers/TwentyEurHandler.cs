namespace Example_06.ChainOfResponsibility.Handlers.EurHandlers
{
    public class TwentyEurHandler : EurHandlerBase
    {
        public TwentyEurHandler(EurHandlerBase nextHandler) : base(nextHandler)
        {
        }

        protected override int Value => 20;
    }
}