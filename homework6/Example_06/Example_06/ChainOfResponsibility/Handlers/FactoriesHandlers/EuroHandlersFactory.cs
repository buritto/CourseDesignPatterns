using Example_06.ChainOfResponsibility.Handlers.EurHandlers;

namespace Example_06.ChainOfResponsibility.Handlers.FactoriesHandlers
{
    public static class EuroHandlersFactory
    {
        public static EurHandlerBase Create()
        {
            var twentyEurHandler = new TwentyEurHandler(null);
            var twoEurHandler = new TwoEurHandler(twentyEurHandler);
            return new OneEurHandler(twoEurHandler);
        }
    }
}