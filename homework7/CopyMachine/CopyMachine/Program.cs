using System;
using CopyMachine.States;

namespace CopyMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            var im = new InputMoneyState(context);
            context.ChangeState(im);

            context.AddMoney(11);
            context.AddDevice("wifi");
            context.SelectDocument("doc");
            context.Print(false);
            var remain = context.GetRemain();
            Console.WriteLine($"remain: {remain}");

            var errorContext = new Context();
            var im2 = new InputMoneyState(errorContext);
            errorContext.ChangeState(im2);

            errorContext.AddMoney(-1);
            Console.WriteLine($"Error: {errorContext.Error.ErrorMessage}");
        }
    }
}