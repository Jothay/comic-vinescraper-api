// <auto-generated>
// <copyright file="Powers.IPowerAliasRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the PowerAliasesRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.Powers
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

    public static class PowerAliasesMockingSetup
    {
        public static Mock<IPowerAliasModel> DoMockingSetupForPowerAliasModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockPowerAliasModel = new Mock<IPowerAliasModel>();
            // Mock Functions
            mockPowerAliasModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockPowerAliasModel.Setup(m => m.Active).Returns(() => true);
            mockPowerAliasModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockPowerAliasModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPowerAliasModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPowerAliasModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockPowerAliasModel.Setup(m => m.UpdatedDate).Returns(() => null);
            mockPowerAliasModel.Setup(m => m.Name).Returns(() => name);
            mockPowerAliasModel.Setup(m => m.ShortDescription).Returns(() => "short");
            mockPowerAliasModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockPowerAliasModel.Setup(m => m.PowerId).Returns(() => 1);
            mockPowerAliasModel.Setup(m => m.Power).Returns(() => new PowerModel());
            // Associated Objects
            // <None>
            // Return
            return mockPowerAliasModel;
        }

        public static Mock<IPowerAlias> DoMockingSetupForPowerAlias(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockPowerAlias = new Mock<IPowerAlias>();
            // Mock Functions
            mockPowerAlias.Setup(m => m.Id).Returns(() => idReturnValue);
            mockPowerAlias.Setup(m => m.Active).Returns(() => true);
            mockPowerAlias.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockPowerAlias.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPowerAlias.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPowerAlias.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockPowerAlias.Setup(m => m.UpdatedDate).Returns(() => null);
            mockPowerAlias.Setup(m => m.Name).Returns(() => name);
            mockPowerAlias.Setup(m => m.ShortDescription).Returns(() => "short");
            mockPowerAlias.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockPowerAlias.Setup(m => m.PowerId).Returns(() => 1);
            mockPowerAlias.Setup(m => m.Power).Returns(() => new Power());
            // Associated Objects
            // <None>
            // Return
            return mockPowerAlias;
        }

        public static Mock<IPowerAliasesRepository> DoMockingSetupForRepository()
        {
            var mockPowerAliasesRepository = new Mock<IPowerAliasesRepository>();
            // Mock Functions
            mockPowerAliasesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IPowerAlias>().Object);
            mockPowerAliasesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IPowerAlias>().Object);
            mockPowerAliasesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IPowerAlias>>().Object);
            mockPowerAliasesRepository.Setup(m => m.Search(It.IsAny<IPowerAliasSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IPowerAlias>>().Object);
            mockPowerAliasesRepository.Setup(m => m.Add(It.IsAny<IPowerAlias>()));
            mockPowerAliasesRepository.Setup(m => m.Remove(It.IsAny<IPowerAlias>()));
            mockPowerAliasesRepository.Setup(m => m.Deactivate(It.IsAny<IPowerAlias>()));
            mockPowerAliasesRepository.Setup(m => m.Update(It.IsAny<IPowerAlias>()));
            // Return
            return mockPowerAliasesRepository;
        }
    }

    public class PowerAliasesBusinessWorkflowsTests
    {
        #region Read
        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockPowerAliasesRepository = PowerAliasesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new PowerAliasesBusinessWorkflow(mockPowerAliasesRepository.Object, new PowerAliasMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<PowerAliasModel>(person);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockPowerAliasesRepository = PowerAliasesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new PowerAliasesBusinessWorkflow(mockPowerAliasesRepository.Object, new PowerAliasMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<PowerAliasModel>(person);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfPowerAliases()
        {
            // Arrange
            var mockPowerAliasesRepository = PowerAliasesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IPowerAliasSearchModel>();
            var mockPowerAliasesMapper = new Mock<IPowerAliasMapper>();
            mockPowerAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IPowerAliasModel>(), It.IsAny<IPowerAlias>())).Returns(() => true);
            var businessWorkflow = new PowerAliasesBusinessWorkflow(mockPowerAliasesRepository.Object, mockPowerAliasesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockPowerAliasesRepository.Verify(m => m.Search(It.IsAny<IPowerAliasSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact]
        public void Verify_Search_AsListing_Should_ReturnAListOfPowerAliasesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockPowerAliasesRepository = PowerAliasesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IPowerAliasSearchModel>();
            var mockPowerAliasesMapper = new Mock<IPowerAliasMapper>();
            mockPowerAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IPowerAliasModel>(), It.IsAny<IPowerAlias>())).Returns(() => true);
            var businessWorkflow = new PowerAliasesBusinessWorkflow(mockPowerAliasesRepository.Object, mockPowerAliasesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockPowerAliasesRepository.Verify(m => m.Search(It.IsAny<IPowerAliasSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockPowerAliasesRepository = PowerAliasesMockingSetup.DoMockingSetupForRepository();
            mockPowerAliasesRepository.Setup(m => m.Search(It.IsAny<IPowerAliasSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IPowerAlias>>().Object);
            var businessWorkflow = new PowerAliasesBusinessWorkflow(mockPowerAliasesRepository.Object, new PowerAliasMapper());
            var model = PowerAliasesMockingSetup.DoMockingSetupForPowerAliasModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockPowerAliasesRepository.Verify(m => m.Add(It.IsAny<IPowerAlias>()), Times.Once);
        }
        [Fact]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockPowerAliasesRepository = PowerAliasesMockingSetup.DoMockingSetupForRepository();
            var mockPowerAlias = PowerAliasesMockingSetup.DoMockingSetupForPowerAlias(1);
            mockPowerAliasesRepository.Setup(m => m.Search(It.IsAny<IPowerAliasSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IPowerAlias> { mockPowerAlias.Object } );
            mockPowerAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockPowerAlias.Object);
            var businessWorkflow = new PowerAliasesBusinessWorkflow(mockPowerAliasesRepository.Object, new PowerAliasMapper());
            var model = PowerAliasesMockingSetup.DoMockingSetupForPowerAliasModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockPowerAliasesRepository.Verify(m => m.Add(It.IsAny<IPowerAlias>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockPowerAlias = PowerAliasesMockingSetup.DoMockingSetupForPowerAlias(1);
            var mockPowerAliasesRepository = PowerAliasesMockingSetup.DoMockingSetupForRepository();
            mockPowerAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockPowerAlias.Object);
            var businessWorkflow = new PowerAliasesBusinessWorkflow(mockPowerAliasesRepository.Object, new PowerAliasMapper());
            var expectedName = "Stephen King (2)";
            var model = PowerAliasesMockingSetup.DoMockingSetupForPowerAliasModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockPowerAlias.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = PowerAliasesMockingSetup.DoMockingSetupForPowerAlias(1);
            var mockPowerAliasesRepository = PowerAliasesMockingSetup.DoMockingSetupForRepository();
            mockPowerAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new PowerAliasesBusinessWorkflow(mockPowerAliasesRepository.Object, new PowerAliasMapper());
            var model = PowerAliasesMockingSetup.DoMockingSetupForPowerAliasModel(1);
            IPowerAliasModel result = null;
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
            var mockPowerAliasesRepository = PowerAliasesMockingSetup.DoMockingSetupForRepository();
            var mockPowerAliasesMapper = new Mock<IPowerAliasMapper>();
            mockPowerAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IPowerAliasModel>(), It.IsAny<IPowerAlias>())).Returns(() => true);
            var businessWorkflow = new PowerAliasesBusinessWorkflow(mockPowerAliasesRepository.Object, mockPowerAliasesMapper.Object);
            mockPowerAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IPowerAlias>().Object);
            mockPowerAliasesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockPowerAliasesRepository.Verify(m => m.Deactivate(It.IsAny<IPowerAlias>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockPowerAliasesRepository = PowerAliasesMockingSetup.DoMockingSetupForRepository();
            var mockPowerAliasesMapper = new Mock<IPowerAliasMapper>();
            mockPowerAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IPowerAliasModel>(), It.IsAny<IPowerAlias>())).Returns(() => true);
            var businessWorkflow = new PowerAliasesBusinessWorkflow(mockPowerAliasesRepository.Object, mockPowerAliasesMapper.Object);
            mockPowerAliasesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IPowerAlias>().Object);
            mockPowerAliasesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockPowerAliasesRepository.Verify(m => m.Deactivate(It.IsAny<IPowerAlias>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockPowerAliasesRepository = PowerAliasesMockingSetup.DoMockingSetupForRepository();
            mockPowerAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockPowerAliasesMapper = new Mock<IPowerAliasMapper>();
            mockPowerAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IPowerAliasModel>(), It.IsAny<IPowerAlias>())).Returns(() => true);
            var businessWorkflow = new PowerAliasesBusinessWorkflow(mockPowerAliasesRepository.Object, mockPowerAliasesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockPowerAliasesRepository = PowerAliasesMockingSetup.DoMockingSetupForRepository();
            mockPowerAliasesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockPowerAliasesMapper = new Mock<IPowerAliasMapper>();
            mockPowerAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IPowerAliasModel>(), It.IsAny<IPowerAlias>())).Returns(() => true);
            var businessWorkflow = new PowerAliasesBusinessWorkflow(mockPowerAliasesRepository.Object, mockPowerAliasesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockPowerAliasesRepository = PowerAliasesMockingSetup.DoMockingSetupForRepository();
            var mockPowerAliasesMapper = new Mock<IPowerAliasMapper>();
            mockPowerAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IPowerAliasModel>(), It.IsAny<IPowerAlias>())).Returns(() => true);
            var businessWorkflow = new PowerAliasesBusinessWorkflow(mockPowerAliasesRepository.Object, mockPowerAliasesMapper.Object);
            mockPowerAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IPowerAlias>().Object);
            mockPowerAliasesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockPowerAliasesRepository.Verify(m => m.Remove(It.IsAny<IPowerAlias>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockPowerAliasesRepository = PowerAliasesMockingSetup.DoMockingSetupForRepository();
            var mockPowerAliasesMapper = new Mock<IPowerAliasMapper>();
            mockPowerAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IPowerAliasModel>(), It.IsAny<IPowerAlias>())).Returns(() => true);
            var businessWorkflow = new PowerAliasesBusinessWorkflow(mockPowerAliasesRepository.Object, mockPowerAliasesMapper.Object);
            mockPowerAliasesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IPowerAlias>().Object);
            mockPowerAliasesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockPowerAliasesRepository.Verify(m => m.Remove(It.IsAny<IPowerAlias>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockPowerAliasesRepository = PowerAliasesMockingSetup.DoMockingSetupForRepository();
            mockPowerAliasesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new PowerAliasesBusinessWorkflow(mockPowerAliasesRepository.Object, new PowerAliasMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}