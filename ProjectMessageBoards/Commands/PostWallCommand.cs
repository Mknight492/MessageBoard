using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMessageBoards.Commands
{
    using global::ProjectMessageBoards.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ProjectMessageBoards.Commands
    {
        public class PostWallCommand : ICommand
        {
            private string _userName;
            private DateTime _time;

            public PostWallCommand(string userName, DateTime time)
            {
                _userName = userName;
                _time = time;
            }


            //have the command directly writing to the console couples the two things together so it would be better to have an abstraction to handle the side effect of writing to the console much like the 
            public void Execute(MessageRepository inMemoryStorage)
            {
                var messages = inMemoryStorage.GetWallMessages(_userName);

                foreach (var message in messages)
                {
                    Console.WriteLine($"{message.Project} - {message.User}: {message.MessageContent} {message.TimeAgoFormated(_time)}");
                }
            }
        }
    }

}
