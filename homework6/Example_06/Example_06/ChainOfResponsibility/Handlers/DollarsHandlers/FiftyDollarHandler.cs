namespace Example_06.ChainOfResponsibility.Handlers.DollarsHandlers
{
    public class FiftyDollarHandler : DollarHandlerBase
    {
        protected override int Value => 50;

        public FiftyDollarHandler(DollarHandlerBase nextHandler) : base(nextHandler)
        {
        }
    }
}