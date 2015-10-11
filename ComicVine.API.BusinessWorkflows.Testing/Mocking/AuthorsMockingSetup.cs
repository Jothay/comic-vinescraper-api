namespace ComicVine.API.Testing.Mocking
{
    using System;
    using System.Collections.Generic;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;
    using Moq;

    public static class PeopleMockingSetup
    {
        public static Mock<IPersonModel> DoMockingSetupForPersonModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockPersonModel = new Mock<IPersonModel>();
            // Mock Functions
            mockPersonModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockPersonModel.Setup(m => m.Active).Returns(() => true);
            mockPersonModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockPersonModel.Setup(m => m.CreatedDate).Returns(() => new DateTime(2015, 10, 1));
            mockPersonModel.Setup(m => m.UpdatedDate).Returns(() => null);
            mockPersonModel.Setup(m => m.Name).Returns(() => name);
            // Return
            return mockPersonModel;
        }

        public static Mock<IPerson> DoMockingSetupForPerson(int idReturnValue = 0)
        {
            var mockPerson = new Mock<IPerson>();
            // Mock Functions
            mockPerson.Setup(m => m.Id).Returns(() => idReturnValue);
            mockPerson.Setup(m => m.Active).Returns(() => true);
            mockPerson.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockPerson.Setup(m => m.CreatedDate).Returns(() => new DateTime(2015, 10, 1));
            mockPerson.Setup(m => m.UpdatedDate).Returns(() => null);
            mockPerson.Setup(m => m.Name).Returns(() => "Stephen King");
            // Return
            return mockPerson;
        }

        public static Mock<IPeopleRepository> DoMockingSetupForRepository()
        {
            var mockPeopleRepository = new Mock<IPeopleRepository>();
            // Mock Functions
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IPerson>().Object);
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IPerson>().Object);
            mockPeopleRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IPerson>>().Object);
            mockPeopleRepository.Setup(m => m.Search(It.IsAny<IPersonSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IPerson>>().Object);
            mockPeopleRepository.Setup(m => m.Add(It.IsAny<IPerson>()));
            mockPeopleRepository.Setup(m => m.Remove(It.IsAny<IPerson>()));
            mockPeopleRepository.Setup(m => m.Deactivate(It.IsAny<IPerson>()));
            mockPeopleRepository.Setup(m => m.Update(It.IsAny<IPerson>()));
            // Return
            return mockPeopleRepository;
        }
    }
}
