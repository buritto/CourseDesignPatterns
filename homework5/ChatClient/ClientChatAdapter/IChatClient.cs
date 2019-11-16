namespace ConsoleApp1
{
    public interface IChatClient
    {
        void Send(Message message);
        Message GetMessage();
    }
}