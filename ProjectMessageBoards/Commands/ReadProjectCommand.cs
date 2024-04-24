using ProjectMessageBoards.Logger;
using ProjectMessageBoards.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMessageBoards.Commands
{
    public class ReadProjectCommand : ICommand
    {
        private string _project;
        private DateTime _time;
        private IMessageRepository _messageRepository;
        private IMessagesLogger _messagesLogger;

        public ReadProjectCommand(string project, DateTime time, IMessageRepository messageRepository, IMessagesLogger messagesLogger)
        {
            _project = project;
            _time = time;
            _messageRepository = messageRepository;
            _messagesLogger = messagesLogger;
        }

        public void Execute()
        {
            var messages = _messageRepository.GetProjectMessages(_project);
            _messagesLogger.OutputProjectMessages(messages, _time);
        }
    }
}
