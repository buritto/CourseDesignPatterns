using Example_06.ChainOfResponsibility.Handlers.RublesHandlers;

namespace Example_06.ChainOfResponsibility.Handlers.FactoriesHandlers
{
    public static class RublesHandlersFactory
    {
        public static RublesHandlerBase Create()
        {
            var thousandRublesHandler = new TenRubleHandler(null);
            var hundredRublesHandler = new HundredRublesHandler(thousandRublesHandler);
            return new ThousandRublesHandler(hundredRublesHandler);
        }
    }
}