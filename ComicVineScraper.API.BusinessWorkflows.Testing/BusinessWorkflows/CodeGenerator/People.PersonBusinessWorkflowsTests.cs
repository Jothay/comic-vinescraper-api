// <auto-generated>
// <copyright file="People.IPersonRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the PeopleRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.People
{
    using System.Collections.Generic;
    using API.BusinessWorkflows;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Mappers;
    using Interfaces.Models;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;
    using Models;
    using Moq;
    using Xunit;

    public static class PeopleMockingSetup
    {
        public static Mock<IPersonModel> DoMockingSetupForPersonModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockPersonModel = new Mock<IPersonModel>();
            // Mock Functions
            mockPersonModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockPersonModel.Setup(m => m.Active).Returns(() => true);
            mockPersonModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockPersonModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPersonModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPersonModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockPersonModel.Setup(m => m.UpdatedDate).Returns(() => null);
            mockPersonModel.Setup(m => m.Name).Returns(() => name);
            mockPersonModel.Setup(m => m.ShortDescription).Returns(() => "short");
            mockPersonModel.Setup(m => m.Description).Returns(() => "long");
            mockPersonModel.Setup(m => m.Hometown).Returns(() => "Hometown");
            mockPersonModel.Setup(m => m.Country).Returns(() => "Country");
            mockPersonModel.Setup(m => m.Email).Returns(() => "Email");
            mockPersonModel.Setup(m => m.Website).Returns(() => "Website");
            mockPersonModel.Setup(m => m.BirthDate).Returns(() => new System.DateTime());
            mockPersonModel.Setup(m => m.DeathDate).Returns(() => new System.DateTime());
            // Related Objects
            mockPersonModel.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockPersonModel.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFileModel());
            mockPersonModel.Setup(m => m.GenderId).Returns(() => 1);
            mockPersonModel.Setup(m => m.Gender).Returns(() => new GenderModel());
            // Associated Objects
            mockPersonModel.Setup(m => m.CharactersCreated).Returns(() => new List<ICreatorCharacterModel>());
            mockPersonModel.Setup(m => m.PersonAliases).Returns(() => new List<IPersonAliasModel>());
            mockPersonModel.Setup(m => m.IssuesWritten).Returns(() => new List<IIssueWriterModel>());
            mockPersonModel.Setup(m => m.MoviesProduced).Returns(() => new List<IMovieProducerModel>());
            mockPersonModel.Setup(m => m.MoviesWritten).Returns(() => new List<IMovieWriterModel>());
            mockPersonModel.Setup(m => m.PromosWritten).Returns(() => new List<IPromoModel>());
            mockPersonModel.Setup(m => m.StoryArcsWritten).Returns(() => new List<IStoryArcWriterModel>());
            mockPersonModel.Setup(m => m.VolumesWritten).Returns(() => new List<IVolumeWriterModel>());
            // Return
            return mockPersonModel;
        }

        public static Mock<IPerson> DoMockingSetupForPerson(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockPerson = new Mock<IPerson>();
            // Mock Functions
            mockPerson.Setup(m => m.Id).Returns(() => idReturnValue);
            mockPerson.Setup(m => m.Active).Returns(() => true);
            mockPerson.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockPerson.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPerson.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPerson.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockPerson.Setup(m => m.UpdatedDate).Returns(() => null);
            mockPerson.Setup(m => m.Name).Returns(() => name);
            mockPerson.Setup(m => m.ShortDescription).Returns(() => "short");
            mockPerson.Setup(m => m.Description).Returns(() => "long");
            mockPerson.Setup(m => m.Hometown).Returns(() => "Hometown");
            mockPerson.Setup(m => m.Country).Returns(() => "Country");
            mockPerson.Setup(m => m.Email).Returns(() => "Email");
            mockPerson.Setup(m => m.Website).Returns(() => "Website");
            mockPerson.Setup(m => m.BirthDate).Returns(() => new System.DateTime());
            mockPerson.Setup(m => m.DeathDate).Returns(() => new System.DateTime());
            // Related Objects
            mockPerson.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockPerson.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFile());
            mockPerson.Setup(m => m.GenderId).Returns(() => 1);
            mockPerson.Setup(m => m.Gender).Returns(() => new Gender());
            // Associated Objects
            mockPerson.Setup(m => m.CharactersCreated).Returns(() => new List<ICreatorCharacter>());
            mockPerson.Setup(m => m.PersonAliases).Returns(() => new List<IPersonAlias>());
            mockPerson.Setup(m => m.IssuesWritten).Returns(() => new List<IIssueWriter>());
            mockPerson.Setup(m => m.MoviesProduced).Returns(() => new List<IMovieProducer>());
            mockPerson.Setup(m => m.MoviesWritten).Returns(() => new List<IMovieWriter>());
            mockPerson.Setup(m => m.PromosWritten).Returns(() => new List<IPromo>());
            mockPerson.Setup(m => m.StoryArcsWritten).Returns(() => new List<IStoryArcWriter>());
            mockPerson.Setup(m => m.VolumesWritten).Returns(() => new List<IVolumeWriter>());
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

    public class PeopleBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "People")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, new PersonMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<PersonModel>(person);
        }

        [Fact][Trait("Category", "People")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, new PersonMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<PersonModel>(person);
        }

        [Fact][Trait("Category", "People")]
        public void Verify_Search_Should_ReturnAListOfPeople()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IPersonSearchModel>();
            var mockPeopleMapper = new Mock<IPersonMapper>();
            mockPeopleMapper.Setup(m => m.AreEqual(It.IsAny<IPersonModel>(), It.IsAny<IPerson>())).Returns(() => true);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, mockPeopleMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockPeopleRepository.Verify(m => m.Search(It.IsAny<IPersonSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "People")]
        public void Verify_Search_AsListing_Should_ReturnAListOfPeopleWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IPersonSearchModel>();
            var mockPeopleMapper = new Mock<IPersonMapper>();
            mockPeopleMapper.Setup(m => m.AreEqual(It.IsAny<IPersonModel>(), It.IsAny<IPerson>())).Returns(() => true);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, mockPeopleMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockPeopleRepository.Verify(m => m.Search(It.IsAny<IPersonSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "People")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            mockPeopleRepository.Setup(m => m.Search(It.IsAny<IPersonSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IPerson>>().Object);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, new PersonMapper());
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockPeopleRepository.Verify(m => m.Add(It.IsAny<IPerson>()), Times.Once);
        }
        [Fact][Trait("Category", "People")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var mockPerson = PeopleMockingSetup.DoMockingSetupForPerson(1);
            mockPeopleRepository.Setup(m => m.Search(It.IsAny<IPersonSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IPerson> { mockPerson.Object } );
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockPerson.Object);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, new PersonMapper());
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockPeopleRepository.Verify(m => m.Add(It.IsAny<IPerson>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "People")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockPerson = PeopleMockingSetup.DoMockingSetupForPerson(1);
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockPerson.Object);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, new PersonMapper());
            var expectedName = "Stephen King (2)";
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockPerson.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "People")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = PeopleMockingSetup.DoMockingSetupForPerson(1);
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, new PersonMapper());
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel(1);
            IPersonModel result = null;
            // Act
            try { result = businessWorkflow.Update(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            Assert.NotNull(result);
            Assert.Equal("Stephen King", result.Name);
            Assert.Equal("/TEST/KING-STEPHEN", result.ApiDetailUrl);
            Assert.Null(result.UpdatedDate);
        }
        #endregion
        #region Deactivate
        [Fact][Trait("Category", "People")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var mockPeopleMapper = new Mock<IPersonMapper>();
            mockPeopleMapper.Setup(m => m.AreEqual(It.IsAny<IPersonModel>(), It.IsAny<IPerson>())).Returns(() => true);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, mockPeopleMapper.Object);
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IPerson>().Object);
            mockPeopleRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockPeopleRepository.Verify(m => m.Deactivate(It.IsAny<IPerson>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "People")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var mockPeopleMapper = new Mock<IPersonMapper>();
            mockPeopleMapper.Setup(m => m.AreEqual(It.IsAny<IPersonModel>(), It.IsAny<IPerson>())).Returns(() => true);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, mockPeopleMapper.Object);
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IPerson>().Object);
            mockPeopleRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockPeopleRepository.Verify(m => m.Deactivate(It.IsAny<IPerson>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "People")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockPeopleMapper = new Mock<IPersonMapper>();
            mockPeopleMapper.Setup(m => m.AreEqual(It.IsAny<IPersonModel>(), It.IsAny<IPerson>())).Returns(() => true);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, mockPeopleMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "People")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockPeopleMapper = new Mock<IPersonMapper>();
            mockPeopleMapper.Setup(m => m.AreEqual(It.IsAny<IPersonModel>(), It.IsAny<IPerson>())).Returns(() => true);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, mockPeopleMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "People")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var mockPeopleMapper = new Mock<IPersonMapper>();
            mockPeopleMapper.Setup(m => m.AreEqual(It.IsAny<IPersonModel>(), It.IsAny<IPerson>())).Returns(() => true);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, mockPeopleMapper.Object);
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IPerson>().Object);
            mockPeopleRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockPeopleRepository.Verify(m => m.Remove(It.IsAny<IPerson>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "People")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var mockPeopleMapper = new Mock<IPersonMapper>();
            mockPeopleMapper.Setup(m => m.AreEqual(It.IsAny<IPersonModel>(), It.IsAny<IPerson>())).Returns(() => true);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, mockPeopleMapper.Object);
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IPerson>().Object);
            mockPeopleRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockPeopleRepository.Verify(m => m.Remove(It.IsAny<IPerson>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "People")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, new PersonMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}