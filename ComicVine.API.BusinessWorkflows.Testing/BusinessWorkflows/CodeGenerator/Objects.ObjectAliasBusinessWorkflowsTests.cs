// <auto-generated>
// <copyright file="Objects.IObjectAliasRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectAliasesRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.Objects
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

    public static class ObjectAliasesMockingSetup
    {
        public static Mock<IObjectAliasModel> DoMockingSetupForObjectAliasModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockObjectAliasModel = new Mock<IObjectAliasModel>();
            // Mock Functions
            mockObjectAliasModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockObjectAliasModel.Setup(m => m.Active).Returns(() => true);
            mockObjectAliasModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockObjectAliasModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectAliasModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectAliasModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockObjectAliasModel.Setup(m => m.UpdatedDate).Returns(() => null);
            mockObjectAliasModel.Setup(m => m.Name).Returns(() => name);
            mockObjectAliasModel.Setup(m => m.ShortDescription).Returns(() => "short");
            mockObjectAliasModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockObjectAliasModel.Setup(m => m.ObjectId).Returns(() => 1);
            mockObjectAliasModel.Setup(m => m.Object).Returns(() => new ObjectModel());
            // Associated Objects
            // <None>
            // Return
            return mockObjectAliasModel;
        }

        public static Mock<IObjectAlias> DoMockingSetupForObjectAlias(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockObjectAlias = new Mock<IObjectAlias>();
            // Mock Functions
            mockObjectAlias.Setup(m => m.Id).Returns(() => idReturnValue);
            mockObjectAlias.Setup(m => m.Active).Returns(() => true);
            mockObjectAlias.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockObjectAlias.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectAlias.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectAlias.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockObjectAlias.Setup(m => m.UpdatedDate).Returns(() => null);
            mockObjectAlias.Setup(m => m.Name).Returns(() => name);
            mockObjectAlias.Setup(m => m.ShortDescription).Returns(() => "short");
            mockObjectAlias.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockObjectAlias.Setup(m => m.ObjectId).Returns(() => 1);
            mockObjectAlias.Setup(m => m.Object).Returns(() => new Object());
            // Associated Objects
            // <None>
            // Return
            return mockObjectAlias;
        }

        public static Mock<IObjectAliasesRepository> DoMockingSetupForRepository()
        {
            var mockObjectAliasesRepository = new Mock<IObjectAliasesRepository>();
            // Mock Functions
            mockObjectAliasesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IObjectAlias>().Object);
            mockObjectAliasesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IObjectAlias>().Object);
            mockObjectAliasesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IObjectAlias>>().Object);
            mockObjectAliasesRepository.Setup(m => m.Search(It.IsAny<IObjectAliasSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IObjectAlias>>().Object);
            mockObjectAliasesRepository.Setup(m => m.Add(It.IsAny<IObjectAlias>()));
            mockObjectAliasesRepository.Setup(m => m.Remove(It.IsAny<IObjectAlias>()));
            mockObjectAliasesRepository.Setup(m => m.Deactivate(It.IsAny<IObjectAlias>()));
            mockObjectAliasesRepository.Setup(m => m.Update(It.IsAny<IObjectAlias>()));
            // Return
            return mockObjectAliasesRepository;
        }
    }

    public class ObjectAliasesBusinessWorkflowsTests
    {
        #region Read
        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockObjectAliasesRepository = ObjectAliasesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new ObjectAliasesBusinessWorkflow(mockObjectAliasesRepository.Object, new ObjectAliasMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<ObjectAliasModel>(person);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockObjectAliasesRepository = ObjectAliasesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new ObjectAliasesBusinessWorkflow(mockObjectAliasesRepository.Object, new ObjectAliasMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<ObjectAliasModel>(person);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfObjectAliases()
        {
            // Arrange
            var mockObjectAliasesRepository = ObjectAliasesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IObjectAliasSearchModel>();
            var mockObjectAliasesMapper = new Mock<IObjectAliasMapper>();
            mockObjectAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectAliasModel>(), It.IsAny<IObjectAlias>())).Returns(() => true);
            var businessWorkflow = new ObjectAliasesBusinessWorkflow(mockObjectAliasesRepository.Object, mockObjectAliasesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockObjectAliasesRepository.Verify(m => m.Search(It.IsAny<IObjectAliasSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact]
        public void Verify_Search_AsListing_Should_ReturnAListOfObjectAliasesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockObjectAliasesRepository = ObjectAliasesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IObjectAliasSearchModel>();
            var mockObjectAliasesMapper = new Mock<IObjectAliasMapper>();
            mockObjectAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectAliasModel>(), It.IsAny<IObjectAlias>())).Returns(() => true);
            var businessWorkflow = new ObjectAliasesBusinessWorkflow(mockObjectAliasesRepository.Object, mockObjectAliasesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockObjectAliasesRepository.Verify(m => m.Search(It.IsAny<IObjectAliasSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockObjectAliasesRepository = ObjectAliasesMockingSetup.DoMockingSetupForRepository();
            mockObjectAliasesRepository.Setup(m => m.Search(It.IsAny<IObjectAliasSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IObjectAlias>>().Object);
            var businessWorkflow = new ObjectAliasesBusinessWorkflow(mockObjectAliasesRepository.Object, new ObjectAliasMapper());
            var model = ObjectAliasesMockingSetup.DoMockingSetupForObjectAliasModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockObjectAliasesRepository.Verify(m => m.Add(It.IsAny<IObjectAlias>()), Times.Once);
        }
        [Fact]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockObjectAliasesRepository = ObjectAliasesMockingSetup.DoMockingSetupForRepository();
            var mockObjectAlias = ObjectAliasesMockingSetup.DoMockingSetupForObjectAlias(1);
            mockObjectAliasesRepository.Setup(m => m.Search(It.IsAny<IObjectAliasSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IObjectAlias> { mockObjectAlias.Object } );
            mockObjectAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockObjectAlias.Object);
            var businessWorkflow = new ObjectAliasesBusinessWorkflow(mockObjectAliasesRepository.Object, new ObjectAliasMapper());
            var model = ObjectAliasesMockingSetup.DoMockingSetupForObjectAliasModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockObjectAliasesRepository.Verify(m => m.Add(It.IsAny<IObjectAlias>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockObjectAlias = ObjectAliasesMockingSetup.DoMockingSetupForObjectAlias(1);
            var mockObjectAliasesRepository = ObjectAliasesMockingSetup.DoMockingSetupForRepository();
            mockObjectAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockObjectAlias.Object);
            var businessWorkflow = new ObjectAliasesBusinessWorkflow(mockObjectAliasesRepository.Object, new ObjectAliasMapper());
            var expectedName = "Stephen King (2)";
            var model = ObjectAliasesMockingSetup.DoMockingSetupForObjectAliasModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockObjectAlias.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = ObjectAliasesMockingSetup.DoMockingSetupForObjectAlias(1);
            var mockObjectAliasesRepository = ObjectAliasesMockingSetup.DoMockingSetupForRepository();
            mockObjectAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new ObjectAliasesBusinessWorkflow(mockObjectAliasesRepository.Object, new ObjectAliasMapper());
            var model = ObjectAliasesMockingSetup.DoMockingSetupForObjectAliasModel(1);
            IObjectAliasModel result = null;
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
        [Fact]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockObjectAliasesRepository = ObjectAliasesMockingSetup.DoMockingSetupForRepository();
            var mockObjectAliasesMapper = new Mock<IObjectAliasMapper>();
            mockObjectAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectAliasModel>(), It.IsAny<IObjectAlias>())).Returns(() => true);
            var businessWorkflow = new ObjectAliasesBusinessWorkflow(mockObjectAliasesRepository.Object, mockObjectAliasesMapper.Object);
            mockObjectAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IObjectAlias>().Object);
            mockObjectAliasesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockObjectAliasesRepository.Verify(m => m.Deactivate(It.IsAny<IObjectAlias>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockObjectAliasesRepository = ObjectAliasesMockingSetup.DoMockingSetupForRepository();
            var mockObjectAliasesMapper = new Mock<IObjectAliasMapper>();
            mockObjectAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectAliasModel>(), It.IsAny<IObjectAlias>())).Returns(() => true);
            var businessWorkflow = new ObjectAliasesBusinessWorkflow(mockObjectAliasesRepository.Object, mockObjectAliasesMapper.Object);
            mockObjectAliasesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IObjectAlias>().Object);
            mockObjectAliasesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockObjectAliasesRepository.Verify(m => m.Deactivate(It.IsAny<IObjectAlias>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockObjectAliasesRepository = ObjectAliasesMockingSetup.DoMockingSetupForRepository();
            mockObjectAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockObjectAliasesMapper = new Mock<IObjectAliasMapper>();
            mockObjectAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectAliasModel>(), It.IsAny<IObjectAlias>())).Returns(() => true);
            var businessWorkflow = new ObjectAliasesBusinessWorkflow(mockObjectAliasesRepository.Object, mockObjectAliasesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockObjectAliasesRepository = ObjectAliasesMockingSetup.DoMockingSetupForRepository();
            mockObjectAliasesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockObjectAliasesMapper = new Mock<IObjectAliasMapper>();
            mockObjectAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectAliasModel>(), It.IsAny<IObjectAlias>())).Returns(() => true);
            var businessWorkflow = new ObjectAliasesBusinessWorkflow(mockObjectAliasesRepository.Object, mockObjectAliasesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockObjectAliasesRepository = ObjectAliasesMockingSetup.DoMockingSetupForRepository();
            var mockObjectAliasesMapper = new Mock<IObjectAliasMapper>();
            mockObjectAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectAliasModel>(), It.IsAny<IObjectAlias>())).Returns(() => true);
            var businessWorkflow = new ObjectAliasesBusinessWorkflow(mockObjectAliasesRepository.Object, mockObjectAliasesMapper.Object);
            mockObjectAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IObjectAlias>().Object);
            mockObjectAliasesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockObjectAliasesRepository.Verify(m => m.Remove(It.IsAny<IObjectAlias>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockObjectAliasesRepository = ObjectAliasesMockingSetup.DoMockingSetupForRepository();
            var mockObjectAliasesMapper = new Mock<IObjectAliasMapper>();
            mockObjectAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectAliasModel>(), It.IsAny<IObjectAlias>())).Returns(() => true);
            var businessWorkflow = new ObjectAliasesBusinessWorkflow(mockObjectAliasesRepository.Object, mockObjectAliasesMapper.Object);
            mockObjectAliasesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IObjectAlias>().Object);
            mockObjectAliasesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockObjectAliasesRepository.Verify(m => m.Remove(It.IsAny<IObjectAlias>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockObjectAliasesRepository = ObjectAliasesMockingSetup.DoMockingSetupForRepository();
            mockObjectAliasesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new ObjectAliasesBusinessWorkflow(mockObjectAliasesRepository.Object, new ObjectAliasMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
