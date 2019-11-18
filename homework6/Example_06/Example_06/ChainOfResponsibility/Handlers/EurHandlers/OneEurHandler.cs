namespace Example_06.ChainOfResponsibility.Handlers.EurHandlers
{
    public class OneEurHandler : EurHandlerBase
    {
        public OneEurHandler(EurHandlerBase nextHandler) : base(nextHandler)
        {
        }

        protected override int Value => 1;
    }
}