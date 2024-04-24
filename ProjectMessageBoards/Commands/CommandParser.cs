using ProjectMessageBoards.Commands.ProjectMessageBoards.Commands;
using ProjectMessageBoards.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMessageBoards.Commands
{
    public class CommandParser
    {
        private string POSTING_DELIMITER = " -> @";
        private string FOLLOWING_DELIMITER = "follows";
        public ICommand ParseCommand(string input)
        {
  
            var time = DateTime.Now;

      
            
            if (input.EndsWith(" wall"))
            {
                var userName = input.RemoveLastOccurrence(" wall");
                return new PostWallCommand(userName, time);
            }
            else if(input.Contains(POSTING_DELIMITER))
            {
               
                var userName = input.Split(POSTING_DELIMITER)[0].Trim();
                var projectNameAndMessage = input.Split(POSTING_DELIMITER)[1].Trim();
                var (project, message) = projectNameAndMessage.SplitSentenceIntoFirstWordAndRestOfScentence();

                return new AddPostCommand(userName, project, message, time);
            }
            else if(input.Contains(FOLLOWING_DELIMITER)) 
            {
                var userName = input.Split(FOLLOWING_DELIMITER)[0].Trim();
                var project = input.Split(FOLLOWING_DELIMITER)[1].Trim();

                return new FollowCommand(userName, project);
            }
            else
            {
                //reading command
                var project = input.Trim();
                return new ReadProjectCommand(project, time);

            }
            
        }
    }
}
