// See https://aka.ms/new-console-template for more information
using ProjectMessageBoards.Commands;

Console.WriteLine("Hello, World!");


var parser = new CommandParser();

while (true)
{
    // take input from the user
    // each new line should be treated as a new input
    string input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        break;
    }
    var command = parser.ParseCommand(input);
    command.Execute();

}