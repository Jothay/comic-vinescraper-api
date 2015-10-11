namespace ComicVine.API.Testing.Mocking
{
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;

    public static class PeopleMockingSetup
    {
        public static Mock<IPeopleBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockPeopleBusinessWorkflow = new Mock<IPeopleBusinessWorkflow>();
            // Mock Functions
            mockPeopleBusinessWorkflow.Setup(m => m.Search(It.IsAny<IPersonSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IPersonModel>());
            mockPeopleBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IPersonModel>().Object);
            mockPeopleBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IPersonModel>().Object);
            mockPeopleBusinessWorkflow.Setup(m => m.Create(It.IsAny<IPersonModel>())).Returns(() => new Mock<IPersonModel>().Object);
            mockPeopleBusinessWorkflow.Setup(m => m.Update(It.IsAny<IPersonModel>())).Returns(() => new Mock<IPersonModel>().Object);
            mockPeopleBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockPeopleBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockPeopleBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockPeopleBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockPeopleBusinessWorkflow;
        }
    }
}
