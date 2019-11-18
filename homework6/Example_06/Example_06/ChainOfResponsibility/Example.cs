using System;
using Example_06.ChainOfResponsibility.Handlers.FactoriesHandlers;

namespace Example_06.ChainOfResponsibility
{
    public class Example
    {
        public void Method()
        {
            var rublesBancomat = new Bancomat(RublesHandlersFactory.Create());
            var result = rublesBancomat.WithdrawMoney(2050);
            Console.WriteLine($"{result.Value} : {result.Currency}");

            try
            {
                var dollarsBancomat = new Bancomat(DollarsHandlersFactory.Create());
                var _ = dollarsBancomat.WithdrawMoney(2033);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}