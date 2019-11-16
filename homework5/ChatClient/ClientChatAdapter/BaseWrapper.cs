namespace ConsoleApp1
{
    public class BaseWrapper
    {
        private readonly IChatClient _baseClient;

        protected BaseWrapper(IChatClient baseClient)
        {
            _baseClient = baseClient;
        }

        protected void SendInternal(Message message)
        {
            _baseClient.Send(message);
        }

        protected Message GetMessageInternal()
        {
            return _baseClient.GetMessage();
        }
    }
}