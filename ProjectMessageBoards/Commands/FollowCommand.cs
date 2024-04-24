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

        public FollowCommand(string userName, string project, DateTime time)
        {
            throw new NotImplementedException();
            _userName = userName;
        }

        public void Execute()
        {
            // Logic to add a user
            Console.WriteLine($"Adding user {_userName}");
        }
    }
}
