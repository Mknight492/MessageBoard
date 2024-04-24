using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMessageBoards.Commands
{
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

            public PostWallCommand(string userName, DateTime time)
            {
                throw new NotFiniteNumberException();
                _userName = userName;
            }

            public void Execute()
            {
                // Logic to add a user
                Console.WriteLine($"Adding user {_userName}");
            }
        }
    }

}
