using Moq;
using ProjectMessageBoards.Commands;
using ProjectMessageBoards.Commands.ProjectMessageBoards.Commands;
using ProjectMessageBoards.Logger;
using ProjectMessageBoards.Repositories;
using System.Reflection;

namespace ProjectMessageBoards.Test
{
    public class UnitTest1
    {
        [Fact]
        public void CommandParser_Generates_AddPostCommand_When_Passed_A_Post_String()
        {
            //arrange
            var messageRepositoryMock = new Mock<IMessageRepository>();
            var messagesLoggerMock = new Mock<IMessagesLogger>();

            var sut = new CommandParser(messageRepositoryMock.Object, messagesLoggerMock.Object);

            //act
            var command = sut.ParseCommand("Alice -> @Moonshot I'm working on the log on screen");

            //assert
            Assert.IsAssignableFrom<AddPostCommand>(command);
            
        }

        [Fact]
        public void CommandParser_Generates_FollowCommand_When_Passed_A_Follow_String()
        {
            var messageRepositoryMock = new Mock<IMessageRepository>();
            var messagesLoggerMock = new Mock<IMessagesLogger>();

            var sut = new CommandParser(messageRepositoryMock.Object, messagesLoggerMock.Object);

            var command = sut.ParseCommand("Charlie follows Apollo");

            Assert.IsAssignableFrom<FollowCommand>(command);
        }

        [Fact]
        public void CommandParser_Generates_PostWallCommand_When_Passed_A_Wall_String()
        {
            var messageRepositoryMock = new Mock<IMessageRepository>();
            var messagesLoggerMock = new Mock<IMessagesLogger>();

            var sut = new CommandParser(messageRepositoryMock.Object, messagesLoggerMock.Object);

            var command = sut.ParseCommand("Charlie wall");

            Assert.IsAssignableFrom<PostWallCommand>(command);
        }

        [Fact]
        public void CommandParser_Generates_ReadProjectCommand_When_Passed_A_Project_String()
        {
            var messageRepositoryMock = new Mock<IMessageRepository>();
            var messagesLoggerMock = new Mock<IMessagesLogger>();

            var sut = new CommandParser(messageRepositoryMock.Object, messagesLoggerMock.Object);

            var command = sut.ParseCommand("Moonshot");

            Assert.IsAssignableFrom<ReadProjectCommand>(command);
        }

        //todo add testing to make sure the excute functions call the logger/repository as expected
    }
}