namespace Example_06.ChainOfResponsibility.Handlers.RublesHandlers
{
    public class HundredRublesHandler : RublesHandlerBase
    {
        public HundredRublesHandler(RublesHandlerBase nextHandler) : base(nextHandler)
        {
        }


        protected override int Value => 100;
    }
}