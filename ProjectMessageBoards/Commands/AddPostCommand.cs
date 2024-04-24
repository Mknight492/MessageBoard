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

        public AddPostCommand(string userName, string project, string message, DateTime time)
        {
            _userName = userName;
            _project = project;
            _message = message;
            _time = time;
        }

        public void Execute(MessageRepository inMemoryStorage)
        {
            inMemoryStorage.AddMessage(_userName, _project, _message, _time);
        }
    }
}
