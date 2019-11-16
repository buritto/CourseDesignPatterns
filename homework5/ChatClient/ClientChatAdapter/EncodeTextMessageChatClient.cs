namespace ConsoleApp1
{
    public class EncodeTextMessageChatClient : BaseWrapper, IChatClient
    {
        public EncodeTextMessageChatClient(IChatClient baseClient) : base(baseClient)
        {
        }

        public void Send(Message message)
        {
            var newMessage = EncodeContent(message);
            SendInternal(newMessage);
        }

        public Message GetMessage()
        {
            var baseMessage = GetMessageInternal();
            return EncodeContent(baseMessage);
        }

        private Message EncodeContent(Message inputMessage)
        {
            return new Message
            {
                Author = inputMessage.Author,
                Destination = inputMessage.Destination,
                Context = $"Encode({inputMessage.Context})"
            };
        }
    }
}