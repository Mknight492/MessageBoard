using ProjectMessageBoards.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMessageBoards.Logger
{
    public class MessagesLogger : IMessagesLogger
    {
        public void OutputProjectMessages(IEnumerable<Message> messages, DateTime time)
        {
            var currentAuthor = "";
            foreach (var message in messages)
            {
                if (currentAuthor != message.User)
                {
                    currentAuthor = message.User;
                    Console.WriteLine(message.User);
                }
                Console.WriteLine(message.Format(time));
            }
        }

        public void OutPutWallMessages(IEnumerable<Message> messages, DateTime time)
        {
            foreach (var message in messages)
            {
                Console.WriteLine($"{message.Project} - {message.User}: {message.MessageContent} {message.TimeAgoFormated(time)}");
            }
        }

    }
}
