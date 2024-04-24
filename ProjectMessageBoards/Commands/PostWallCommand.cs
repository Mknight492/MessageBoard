using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMessageBoards.Commands
{
    using global::ProjectMessageBoards.Logger;
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
            private IMessageRepository _messageRepository;
            private IMessagesLogger _messagesLogger;

            public PostWallCommand(string userName, DateTime time, IMessageRepository messageRepository, IMessagesLogger messagesLogger)
            {
                _userName = userName;
                _time = time;
                _messageRepository = messageRepository;
                _messagesLogger = messagesLogger;
            }


            //have the command directly writing to the console couples the two things together so it would be better to have an abstraction to handle the side effect of writing to the console much like the 
            public void Execute()
            {
                var messages = _messageRepository.GetWallMessages(_userName);

                _messagesLogger.OutPutWallMessages(messages, _time);
            }
        }
    }

}
