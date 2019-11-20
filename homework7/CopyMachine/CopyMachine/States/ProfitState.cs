namespace CopyMachine.States
{
    public class ProfitState : BaseState, IState
    {
        public ProfitState(Context context) : base(context)
        {
            Context.EndPrinting = true;
        }
    }
}