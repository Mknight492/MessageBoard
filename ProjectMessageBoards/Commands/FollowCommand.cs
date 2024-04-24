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

        public FollowCommand(string userName, string project)
        {
            _userName = userName;
            _project = project;
        }

        public void Execute(MessageRepository inMemoryStorage)
        {
            inMemoryStorage.AddFollow(_userName, _project);
        }
    }
}
