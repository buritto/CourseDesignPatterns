namespace ConsoleApp1
{
    public class SimpleImMemoryChatClient : IChatClient
    {
        
        public void Send(Message message)
        {
            return;
        }

        public Message GetMessage()
        {
            return new Message
            {
                Author = "author",
                Context = "MessageText",
                Destination = "Dest"
            };
        }
    }
}