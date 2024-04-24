using ProjectMessageBoards.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMessageBoards.Commands
{
    public class FollowCommand : ICommand
    {
        private string _userName;
        private string _project;
        private IMessageRepository _messageRepository;

        public FollowCommand(string userName, string project, IMessageRepository messageRepository)
        {
            _userName = userName;
            _project = project;
            _messageRepository = messageRepository;
        }

        public void Execute()
        {
            _messageRepository.AddFollow(_userName, _project);
        }
    }
}
