namespace Example_06.ChainOfResponsibility.Handlers.RublesHandlers
{
    public class TenRubleHandler : RublesHandlerBase
    {
        protected override int Value => 10;

        public TenRubleHandler(RublesHandlerBase nextHandler) : base(nextHandler)
        {
        }
    }
}