using ProjectMessageBoards.Repositories;

namespace ProjectMessageBoards.Logger
{
    public interface IMessagesLogger
    {
        void OutputProjectMessages(IEnumerable<Message> messages, DateTime time);
        void OutPutWallMessages(IEnumerable<Message> messages, DateTime time);
    }
}