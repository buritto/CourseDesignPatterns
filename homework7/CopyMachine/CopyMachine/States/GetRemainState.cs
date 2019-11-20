namespace CopyMachine.States
{
    public class GetRemainState : BaseState, IState
    {
        public GetRemainState(Context context) : base(context)
        {
        }

        public new int GetRemain()
        {
            Context.ChangeState(new ProfitState(Context));
            return Context.Balance;
        }
    }
}