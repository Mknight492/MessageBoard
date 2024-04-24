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

        public ReadProjectCommand(string project, DateTime time)
        {
            throw new NotFiniteNumberException();
            _project = project;
        }

        public void Execute()
        {
            // Logic to add a user
            Console.WriteLine($"Adding user {_project}");
        }
    }
}
