namespace CopyMachine.States
{
    public interface IState
    {
        void AddMoney(int money);

        void AddDevice(string device);

        void SelectDocument(string documentName);

        void Print(bool repeat);

        int GetRemain();
    }
}