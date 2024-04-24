using ProjectMessageBoards.Commands.ProjectMessageBoards.Commands;
using ProjectMessageBoards.Logger;
using ProjectMessageBoards.Repositories;
using ProjectMessageBoards.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMessageBoards.Commands
{
    public class CommandParser : ICommandParser
    {
        private IMessageRepository _messageRepository;
        private IMessagesLogger _messagesLogger;
        public CommandParser(IMessageRepository messageRepository, IMessagesLogger messagesLogger)
        {
            _messageRepository = messageRepository;
            _messagesLogger = messagesLogger;
        }
        private string POSTING_DELIMITER = " -> @";
        private string FOLLOWING_DELIMITER = "follows";
        public ICommand ParseCommand(string input)
        {

            var time = DateTime.Now;


            //this is probably the biggest issue with the code so far as there are lots of edge cases with the parsing into commands that still need to be tested.
            if (input.EndsWith(" wall"))
            {
                var userName = input.RemoveLastOccurrence(" wall");
                return new PostWallCommand(userName, time, _messageRepository, _messagesLogger);
            }
            else if (input.Contains(POSTING_DELIMITER))
            {
                var userName = input.Split(POSTING_DELIMITER)[0].Trim();
                var projectNameAndMessage = input.Split(POSTING_DELIMITER)[1].Trim();
                var (project, message) = projectNameAndMessage.SplitSentenceIntoFirstWordAndRestOfScentence();

                return new AddPostCommand(userName, project, message, time, _messageRepository);
            }
            else if (input.Contains(FOLLOWING_DELIMITER))
            {
                var userName = input.Split(FOLLOWING_DELIMITER)[0].Trim();
                var project = input.Split(FOLLOWING_DELIMITER)[1].Trim();

                return new FollowCommand(userName, project, _messageRepository);
            }
            else
            {
                //reading command
                var project = input.Trim();
                return new ReadProjectCommand(project, time, _messageRepository, _messagesLogger);

            }

        }
    }
}
