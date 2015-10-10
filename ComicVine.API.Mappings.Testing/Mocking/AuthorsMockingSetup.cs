namespace ComicVine.API.Testing.Mocking
{
    using System;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;

    public static class AuthorsMockingSetup
    {
        public static Mock<IAuthorModel> DoMockingSetupForAuthorModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockAuthorModel = new Mock<IAuthorModel>();
            // Mock Functions
            mockAuthorModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockAuthorModel.Setup(m => m.Active).Returns(() => true);
            mockAuthorModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockAuthorModel.Setup(m => m.CreatedDate).Returns(() => new DateTime(2015, 10, 1));
            mockAuthorModel.Setup(m => m.UpdatedDate).Returns(() => null);
            mockAuthorModel.Setup(m => m.Name).Returns(() => name);
            // Return
            return mockAuthorModel;
        }

        public static Mock<IAuthor> DoMockingSetupForAuthor(int idReturnValue = 0)
        {
            var mockAuthor = new Mock<IAuthor>();
            // Mock Functions
            mockAuthor.Setup(m => m.Id).Returns(() => idReturnValue);
            mockAuthor.Setup(m => m.Active).Returns(() => true);
            mockAuthor.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockAuthor.Setup(m => m.CreatedDate).Returns(() => new DateTime(2015, 10, 1));
            mockAuthor.Setup(m => m.UpdatedDate).Returns(() => null);
            mockAuthor.Setup(m => m.Name).Returns(() => "Stephen King");
            // Return
            return mockAuthor;
        }
    }
}
