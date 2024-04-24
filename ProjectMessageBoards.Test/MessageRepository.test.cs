using Moq;
using ProjectMessageBoards.Commands;
using ProjectMessageBoards.Commands.ProjectMessageBoards.Commands;
using ProjectMessageBoards.Logger;
using ProjectMessageBoards.Repositories;
using System.Reflection;

namespace ProjectMessageBoards.Test
{
    public class MessageRepositoryTest
    {
        [Fact]
        public void MessageRepository_Stores_And_Retrieves_A_Single_Project_Message()
        {
            //arrange
            var messageRepository = new MessageRepository();

            //act
            messageRepository.AddMessage("username", "project1", "message1", new DateTime(2019, 05, 09, 9, 15, 0));

            var project1Messages = messageRepository.GetProjectMessages("project1");

            //assert
            Assert.Equal(1, project1Messages.Count);    
        }

        [Fact]
        public void MessageRepository_Stores_And_Retrieves_Multiple_Project_Message()
        {
            //arrange
            var messageRepository = new MessageRepository();

            //act
            messageRepository.AddMessage("username", "project1", "message1", new DateTime(2019, 05, 09, 9, 15, 0));
            messageRepository.AddMessage("username", "project1", "message2", new DateTime(2019, 05, 09, 9, 15, 0));

            var project1Messages = messageRepository.GetProjectMessages("project1");

            //assert
            Assert.Equal(2, project1Messages.Count);
        }

        [Fact]
        public void MessageRepository_Stores_And_Retrieves_Only_Messages_From_A_Single_Project()
        {
            //arrange
            var messageRepository = new MessageRepository();

            //act
            messageRepository.AddMessage("username", "project1", "message1", new DateTime(2019, 05, 09, 9, 15, 0));
            messageRepository.AddMessage("username", "project1", "message2", new DateTime(2019, 05, 09, 9, 15, 0));
            messageRepository.AddMessage("username", "project2", "message2", new DateTime(2019, 05, 09, 9, 15, 0));

            var project1Messages = messageRepository.GetProjectMessages("project1");

            //assert
            Assert.Equal(2, project1Messages.Count);
        }

        
        //todo add testing for adding followings and walls

    }
}