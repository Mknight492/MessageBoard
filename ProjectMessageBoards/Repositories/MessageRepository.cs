using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMessageBoards.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private List<Message> _messages = new List<Message>();
        private List<Follows> _follows = new List<Follows>();

        public void AddMessage(string username, string project, string message, DateTime time)
        {
            var newMessage = new Message { User = username, Project = project, MessageContent = message, Time = time };
            _messages.Add(newMessage);
        }

        public void AddFollow(string username, string project)
        {
            var newFollow = new Follows { User = username, Project = project };
            _follows.Add(newFollow);
        }

        public List<Message> GetProjectMessages(string project)
        {
            var projectMessages = _messages.Where(message => message.Project == project).ToList();
            return projectMessages;
        }

        public List<Message> GetWallMessages(string user)
        {
            var userProjects = _follows.Where(follow => follow.User == user)
                .Select(follow => follow.Project)
                .ToList();

            var wallMessages = _messages.Where(message => userProjects.Contains(message.Project)).ToList();

            return wallMessages;
        }

    }
}
