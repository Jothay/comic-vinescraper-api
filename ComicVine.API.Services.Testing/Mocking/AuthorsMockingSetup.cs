namespace ComicVine.API.Testing.Mocking
{
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;

    public static class AuthorsMockingSetup
    {
        public static Mock<IAuthorsBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockAuthorsBusinessWorkflow = new Mock<IAuthorsBusinessWorkflow>();
            // Mock Functions
            mockAuthorsBusinessWorkflow.Setup(m => m.Search(It.IsAny<IAuthorSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IAuthorModel>());
            mockAuthorsBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IAuthorModel>().Object);
            mockAuthorsBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IAuthorModel>().Object);
            mockAuthorsBusinessWorkflow.Setup(m => m.Create(It.IsAny<IAuthorModel>())).Returns(() => new Mock<IAuthorModel>().Object);
            mockAuthorsBusinessWorkflow.Setup(m => m.Update(It.IsAny<IAuthorModel>())).Returns(() => new Mock<IAuthorModel>().Object);
            mockAuthorsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockAuthorsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockAuthorsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockAuthorsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockAuthorsBusinessWorkflow;
        }
    }
}
