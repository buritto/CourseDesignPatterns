namespace Example_06.ChainOfResponsibility.Handlers.RublesHandlers
{
    public class ThousandRublesHandler : RublesHandlerBase
    {
        public ThousandRublesHandler(RublesHandlerBase nextHandler) : base(nextHandler)
        {
        }

        protected override int Value => 1000;
    }
}