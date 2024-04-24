namespace ProjectMessageBoards.Commands
{
    public interface ICommandParser
    {
        ICommand ParseCommand(string input);
    }
}