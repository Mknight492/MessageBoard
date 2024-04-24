
namespace ProjectMessageBoards.Repositories
{
    public interface IMessageRepository
    {
        void AddFollow(string username, string project);
        void AddMessage(string username, string project, string message, DateTime time);
        List<Message> GetProjectMessages(string project);
        List<Message> GetWallMessages(string user);
    }
}