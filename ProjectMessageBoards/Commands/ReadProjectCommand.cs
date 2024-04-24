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

        public ReadProjectCommand(string project, DateTime time)
        {
            _project = project;
            _time = time;
        }

        public void Execute(MessageRepository inMemoryStorage)
        {
            var messages = inMemoryStorage.GetProjectMessages(_project);
            var currentAuthor = "";
            foreach (var message in messages) 
            { 
                if(currentAuthor != message.User)
                {
                    currentAuthor = message.User;
                    Console.WriteLine(message.User);
                }
                Console.WriteLine(message.Format(_time));
            }
        }
    }
}
