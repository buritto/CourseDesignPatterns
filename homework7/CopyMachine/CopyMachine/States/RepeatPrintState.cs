using System.Threading;

namespace CopyMachine.States
{
    public class RepeatPrintState : BaseState, IState
    {
        private const int Cost = 10;

        public RepeatPrintState(Context context) : base(context)
        {
        }

        public new void Print(bool repeat)
        {
            if (Context.Balance > Cost)
            {
                Context.Balance = Context.Balance - Cost;
                Thread.Sleep(1000);
                Context.ChangeState(new GetRemainState(Context));
                if (repeat)
                {
                    Context.ChangeState(this);
                }

                return;
            }


            Context = Error.GetError(Context, $"Current balance {Context.Balance} but copy cost {Cost}");
        }
    }
}