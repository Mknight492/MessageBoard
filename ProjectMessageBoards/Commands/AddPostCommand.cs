using ProjectMessageBoards.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMessageBoards.Commands
{
    public class AddPostCommand : ICommand
    {
        private string _userName;
        private string _project;
        private string _message;
        private DateTime _time;
        private IMessageRepository _messageRepository;

        public AddPostCommand(string userName, string project, string message, DateTime time, IMessageRepository messageRepository)
        {
            _userName = userName;
            _project = project;
            _message = message;
            _time = time;
            _messageRepository = messageRepository;
        }

        public void Execute()
        {
            _messageRepository.AddMessage(_userName, _project, _message, _time);
        }
    }
}
