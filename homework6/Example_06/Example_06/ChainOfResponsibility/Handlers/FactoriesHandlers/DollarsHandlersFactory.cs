using Example_06.ChainOfResponsibility.Handlers.DollarsHandlers;

namespace Example_06.ChainOfResponsibility.Handlers.FactoriesHandlers
{
    public static class DollarsHandlersFactory
    {
        public static DollarHandlerBase Create()
        {
            var hundredDollarHandler = new TenDollarHandler(null);
            var fiftyDollarHandler = new FiftyDollarHandler(hundredDollarHandler);
            return new HundredDollarHandler(fiftyDollarHandler);
        }
    }
}