using CopyMachine.States;

namespace CopyMachine
{
    public class Context
    {
        public bool EndPrinting;
        public ContextError Error;
        public int Balance;
        public string Device;
        private IState _state;


        public void ChangeState(IState state)
        {
            _state = state;
        }

        public void AddMoney(int money)
        {
            _state.AddMoney(money);
        }

        public void AddDevice(string device)
        {
            _state.AddDevice(device);
        }

        public void SelectDocument(string documentName)
        {
            _state.SelectDocument(documentName);
        }

        public void Print(bool repeat)
        {
            _state.Print(repeat);
        }


        public int GetRemain()
        {
            return _state.GetRemain();
        }
    }
}