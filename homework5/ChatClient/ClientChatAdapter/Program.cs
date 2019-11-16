using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var testMessage = new Message
            {
                Author = "auth",
                Context = "SomeMessage",
                Destination = "SomeDest"
            };

            var simpleChatClient = new SimpleImMemoryChatClient();
            simpleChatClient.Send(testMessage);
            var simpleResponse = simpleChatClient.GetMessage();


            var encodeDestinationClient = new EncodeUsersChatClient(simpleChatClient);
            encodeDestinationClient.Send(testMessage);
            var encodedUsersMessage = encodeDestinationClient.GetMessage();

            var encodeTextClient = new EncodeTextMessageChatClient(simpleChatClient);
            encodeTextClient.Send(testMessage);
            var encodingTextMessage = encodeTextClient.GetMessage();

            var encodeDestinationAndText = new EncodeUsersChatClient(encodeTextClient);
            encodeDestinationAndText.Send(testMessage);
            var composeEncoding = encodeDestinationAndText.GetMessage();
        }
    }
}