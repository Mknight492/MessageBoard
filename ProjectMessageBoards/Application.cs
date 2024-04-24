using ProjectMessageBoards.Commands;
using ProjectMessageBoards.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMessageBoards
{
    // Main application class
    public class MyApplication
    {
        private ICommandParser _commandParser;

        private IMessageRepository _messageRepository;
        public MyApplication(ICommandParser commandParser, IMessageRepository messageRepository)
        {
            _commandParser = commandParser;
            _messageRepository = messageRepository;
        }
        public void Run()
        {
            while (true)
            {
                // take input from the user
                // each new line should be treated as a new input
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                var command = _commandParser.ParseCommand(input);
                //ideally would use an interface and potentially a DI framework for adding the reference to the data access layer
                command.Execute(_messageRepository);

            }
        }
    }
}
