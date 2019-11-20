namespace CopyMachine.States
{
    public class InputMoneyState : BaseState, IState
    {
        public new void AddMoney(int money)
        {
            if (money <= 0)
            {
                Context = Error.GetError(Context, $"money should be more then 0, but get {money}");
                return;
            }

            Context.Balance = money;
            Context.ChangeState(new SelectDeviceState(Context));
        }

        public InputMoneyState(Context context) : base(context)
        {
        }
    }
}