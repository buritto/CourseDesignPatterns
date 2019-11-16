namespace ConsoleApp1
{
    public class EncodeUsersChatClient : BaseWrapper, IChatClient
    {
        public EncodeUsersChatClient(IChatClient baseClient)
            : base(baseClient)
        {
        }


        public void Send(Message message)
        {
            var encodeMessage = EncodeUsers(message);
            SendInternal(encodeMessage);
        }

        public Message GetMessage()
        {
            var baseMessage = GetMessageInternal();
            return EncodeUsers(baseMessage);
        }

        private Message EncodeUsers(Message inputMessage)
        {
            var encodeDestination = $"Encode({inputMessage.Destination})";
            var encodeAuthor = $"Encode({inputMessage.Author})";

            return new Message
            {
                Author = encodeAuthor,
                Destination = encodeDestination,
                Context = inputMessage.Context
            };
        }
    }
}