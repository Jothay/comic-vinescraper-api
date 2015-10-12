// <auto-generated>
// <copyright file="People.IGenderRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the GendersRepository Class.</summary>
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

    public static class GendersMockingSetup
    {
        public static Mock<IGenderModel> DoMockingSetupForGenderModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockGenderModel = new Mock<IGenderModel>();
            // Mock Functions
            mockGenderModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockGenderModel.Setup(m => m.Active).Returns(() => true);
            mockGenderModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockGenderModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockGenderModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockGenderModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockGenderModel.Setup(m => m.UpdatedDate).Returns(() => null);
            mockGenderModel.Setup(m => m.Name).Returns(() => name);
            mockGenderModel.Setup(m => m.ShortDescription).Returns(() => "short");
            mockGenderModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockGenderModel.Setup(m => m.Characters).Returns(() => new List<ICharacterModel>());
            mockGenderModel.Setup(m => m.People).Returns(() => new List<IPersonModel>());
            // Return
            return mockGenderModel;
        }

        public static Mock<IGender> DoMockingSetupForGender(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockGender = new Mock<IGender>();
            // Mock Functions
            mockGender.Setup(m => m.Id).Returns(() => idReturnValue);
            mockGender.Setup(m => m.Active).Returns(() => true);
            mockGender.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockGender.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockGender.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockGender.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockGender.Setup(m => m.UpdatedDate).Returns(() => null);
            mockGender.Setup(m => m.Name).Returns(() => name);
            mockGender.Setup(m => m.ShortDescription).Returns(() => "short");
            mockGender.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockGender.Setup(m => m.Characters).Returns(() => new List<ICharacter>());
            mockGender.Setup(m => m.People).Returns(() => new List<IPerson>());
            // Return
            return mockGender;
        }

        public static Mock<IGendersRepository> DoMockingSetupForRepository()
        {
            var mockGendersRepository = new Mock<IGendersRepository>();
            // Mock Functions
            mockGendersRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IGender>().Object);
            mockGendersRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IGender>().Object);
            mockGendersRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IGender>>().Object);
            mockGendersRepository.Setup(m => m.Search(It.IsAny<IGenderSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IGender>>().Object);
            mockGendersRepository.Setup(m => m.Add(It.IsAny<IGender>()));
            mockGendersRepository.Setup(m => m.Remove(It.IsAny<IGender>()));
            mockGendersRepository.Setup(m => m.Deactivate(It.IsAny<IGender>()));
            mockGendersRepository.Setup(m => m.Update(It.IsAny<IGender>()));
            // Return
            return mockGendersRepository;
        }
    }

    public class GendersBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "Genders")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockGendersRepository = GendersMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new GendersBusinessWorkflow(mockGendersRepository.Object, new GenderMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<GenderModel>(person);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockGendersRepository = GendersMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new GendersBusinessWorkflow(mockGendersRepository.Object, new GenderMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<GenderModel>(person);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Search_Should_ReturnAListOfGenders()
        {
            // Arrange
            var mockGendersRepository = GendersMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IGenderSearchModel>();
            var mockGendersMapper = new Mock<IGenderMapper>();
            mockGendersMapper.Setup(m => m.AreEqual(It.IsAny<IGenderModel>(), It.IsAny<IGender>())).Returns(() => true);
            var businessWorkflow = new GendersBusinessWorkflow(mockGendersRepository.Object, mockGendersMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockGendersRepository.Verify(m => m.Search(It.IsAny<IGenderSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Search_AsListing_Should_ReturnAListOfGendersWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockGendersRepository = GendersMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IGenderSearchModel>();
            var mockGendersMapper = new Mock<IGenderMapper>();
            mockGendersMapper.Setup(m => m.AreEqual(It.IsAny<IGenderModel>(), It.IsAny<IGender>())).Returns(() => true);
            var businessWorkflow = new GendersBusinessWorkflow(mockGendersRepository.Object, mockGendersMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockGendersRepository.Verify(m => m.Search(It.IsAny<IGenderSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "Genders")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockGendersRepository = GendersMockingSetup.DoMockingSetupForRepository();
            mockGendersRepository.Setup(m => m.Search(It.IsAny<IGenderSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IGender>>().Object);
            var businessWorkflow = new GendersBusinessWorkflow(mockGendersRepository.Object, new GenderMapper());
            var model = GendersMockingSetup.DoMockingSetupForGenderModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockGendersRepository.Verify(m => m.Add(It.IsAny<IGender>()), Times.Once);
        }
        [Fact][Trait("Category", "Genders")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockGendersRepository = GendersMockingSetup.DoMockingSetupForRepository();
            var mockGender = GendersMockingSetup.DoMockingSetupForGender(1);
            mockGendersRepository.Setup(m => m.Search(It.IsAny<IGenderSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IGender> { mockGender.Object } );
            mockGendersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockGender.Object);
            var businessWorkflow = new GendersBusinessWorkflow(mockGendersRepository.Object, new GenderMapper());
            var model = GendersMockingSetup.DoMockingSetupForGenderModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockGendersRepository.Verify(m => m.Add(It.IsAny<IGender>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "Genders")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockGender = GendersMockingSetup.DoMockingSetupForGender(1);
            var mockGendersRepository = GendersMockingSetup.DoMockingSetupForRepository();
            mockGendersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockGender.Object);
            var businessWorkflow = new GendersBusinessWorkflow(mockGendersRepository.Object, new GenderMapper());
            var expectedName = "Stephen King (2)";
            var model = GendersMockingSetup.DoMockingSetupForGenderModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockGender.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "Genders")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = GendersMockingSetup.DoMockingSetupForGender(1);
            var mockGendersRepository = GendersMockingSetup.DoMockingSetupForRepository();
            mockGendersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new GendersBusinessWorkflow(mockGendersRepository.Object, new GenderMapper());
            var model = GendersMockingSetup.DoMockingSetupForGenderModel(1);
            IGenderModel result = null;
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
        [Fact][Trait("Category", "Genders")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockGendersRepository = GendersMockingSetup.DoMockingSetupForRepository();
            var mockGendersMapper = new Mock<IGenderMapper>();
            mockGendersMapper.Setup(m => m.AreEqual(It.IsAny<IGenderModel>(), It.IsAny<IGender>())).Returns(() => true);
            var businessWorkflow = new GendersBusinessWorkflow(mockGendersRepository.Object, mockGendersMapper.Object);
            mockGendersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IGender>().Object);
            mockGendersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockGendersRepository.Verify(m => m.Deactivate(It.IsAny<IGender>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockGendersRepository = GendersMockingSetup.DoMockingSetupForRepository();
            var mockGendersMapper = new Mock<IGenderMapper>();
            mockGendersMapper.Setup(m => m.AreEqual(It.IsAny<IGenderModel>(), It.IsAny<IGender>())).Returns(() => true);
            var businessWorkflow = new GendersBusinessWorkflow(mockGendersRepository.Object, mockGendersMapper.Object);
            mockGendersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IGender>().Object);
            mockGendersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockGendersRepository.Verify(m => m.Deactivate(It.IsAny<IGender>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockGendersRepository = GendersMockingSetup.DoMockingSetupForRepository();
            mockGendersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockGendersMapper = new Mock<IGenderMapper>();
            mockGendersMapper.Setup(m => m.AreEqual(It.IsAny<IGenderModel>(), It.IsAny<IGender>())).Returns(() => true);
            var businessWorkflow = new GendersBusinessWorkflow(mockGendersRepository.Object, mockGendersMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockGendersRepository = GendersMockingSetup.DoMockingSetupForRepository();
            mockGendersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockGendersMapper = new Mock<IGenderMapper>();
            mockGendersMapper.Setup(m => m.AreEqual(It.IsAny<IGenderModel>(), It.IsAny<IGender>())).Returns(() => true);
            var businessWorkflow = new GendersBusinessWorkflow(mockGendersRepository.Object, mockGendersMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "Genders")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockGendersRepository = GendersMockingSetup.DoMockingSetupForRepository();
            var mockGendersMapper = new Mock<IGenderMapper>();
            mockGendersMapper.Setup(m => m.AreEqual(It.IsAny<IGenderModel>(), It.IsAny<IGender>())).Returns(() => true);
            var businessWorkflow = new GendersBusinessWorkflow(mockGendersRepository.Object, mockGendersMapper.Object);
            mockGendersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IGender>().Object);
            mockGendersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockGendersRepository.Verify(m => m.Remove(It.IsAny<IGender>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockGendersRepository = GendersMockingSetup.DoMockingSetupForRepository();
            var mockGendersMapper = new Mock<IGenderMapper>();
            mockGendersMapper.Setup(m => m.AreEqual(It.IsAny<IGenderModel>(), It.IsAny<IGender>())).Returns(() => true);
            var businessWorkflow = new GendersBusinessWorkflow(mockGendersRepository.Object, mockGendersMapper.Object);
            mockGendersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IGender>().Object);
            mockGendersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockGendersRepository.Verify(m => m.Remove(It.IsAny<IGender>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockGendersRepository = GendersMockingSetup.DoMockingSetupForRepository();
            mockGendersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new GendersBusinessWorkflow(mockGendersRepository.Object, new GenderMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
