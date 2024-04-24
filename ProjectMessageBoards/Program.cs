// See https://aka.ms/new-console-template for more information
using ProjectMessageBoards.Commands;
using ProjectMessageBoards.Repositories;

var parser = new CommandParser();

var inMemoryStorage = new MessageRepository();

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
    //ideally would use an interface and potentially a DI framework for adding the reference to the data access layer
    command.Execute(inMemoryStorage);

}