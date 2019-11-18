namespace Example_06.ChainOfResponsibility.Handlers.DollarsHandlers
{
    public class TenDollarHandler : DollarHandlerBase
    {
        protected override int Value => 10;

        public TenDollarHandler(DollarHandlerBase nextHandler) : base(nextHandler)
        { }
    }
}