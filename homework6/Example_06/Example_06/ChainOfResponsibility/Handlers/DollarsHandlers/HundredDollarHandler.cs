namespace Example_06.ChainOfResponsibility.Handlers.DollarsHandlers
{
    public class HundredDollarHandler : DollarHandlerBase
    {
        protected override int Value => 100;

        public HundredDollarHandler(DollarHandlerBase nextHandler) : base(nextHandler)
        { }
    }
}