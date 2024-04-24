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

        public MyApplication(ICommandParser commandParser)
        {
            _commandParser = commandParser;
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
                command.Execute();

            }
        }
    }
}
