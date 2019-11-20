using System;

namespace CopyMachine.States
{
    public class BaseState : IState
    {
        protected Context Context;

        public BaseState(Context context)
        {
            Context = context;
        }

        public void AddMoney(int money)
        {
        }

        public void AddDevice(string device)
        {
        }

        public void SelectDocument(string documentName)
        {
        }

        public void Print(bool repeat)
        {
            return;
        }


        public int GetRemain()
        {
            return Context.Balance;
        }
    }
}