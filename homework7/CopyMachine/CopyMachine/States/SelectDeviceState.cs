namespace CopyMachine.States
{
    public class SelectDeviceState : BaseState, IState
    {
        public SelectDeviceState(Context context) : base(context)
        {
        }

        public new void AddDevice(string device)
        {
            if (device != "wifi" && device != "flesh")
            {
                Context = Error.GetError(Context, "invalid device");
                return;
            }

            Context.Device = device;
            Context.ChangeState(new SelectDocumentState(Context));
        }
    }
}