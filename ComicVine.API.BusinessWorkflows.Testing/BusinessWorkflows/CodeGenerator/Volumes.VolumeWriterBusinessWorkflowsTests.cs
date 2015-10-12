// <auto-generated>
// <copyright file="Volumes.IVolumeWriterRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VolumeWritersRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.Volumes
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

    public static class VolumeWritersMockingSetup
    {
        public static Mock<IVolumeWriterModel> DoMockingSetupForVolumeWriterModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockVolumeWriterModel = new Mock<IVolumeWriterModel>();
            // Mock Functions
            mockVolumeWriterModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockVolumeWriterModel.Setup(m => m.Active).Returns(() => true);
            mockVolumeWriterModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockVolumeWriterModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeWriterModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeWriterModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockVolumeWriterModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockVolumeWriterModel.Setup(m => m.VolumeId).Returns(() => 1);
            mockVolumeWriterModel.Setup(m => m.Volume).Returns(() => new VolumeModel());
            mockVolumeWriterModel.Setup(m => m.WriterId).Returns(() => 1);
            mockVolumeWriterModel.Setup(m => m.Writer).Returns(() => new PersonModel());
            // Associated Objects
            // <None>
            // Return
            return mockVolumeWriterModel;
        }

        public static Mock<IVolumeWriter> DoMockingSetupForVolumeWriter(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockVolumeWriter = new Mock<IVolumeWriter>();
            // Mock Functions
            mockVolumeWriter.Setup(m => m.Id).Returns(() => idReturnValue);
            mockVolumeWriter.Setup(m => m.Active).Returns(() => true);
            mockVolumeWriter.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockVolumeWriter.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeWriter.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeWriter.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockVolumeWriter.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockVolumeWriter.Setup(m => m.VolumeId).Returns(() => 1);
            mockVolumeWriter.Setup(m => m.Volume).Returns(() => new Volume());
            mockVolumeWriter.Setup(m => m.WriterId).Returns(() => 1);
            mockVolumeWriter.Setup(m => m.Writer).Returns(() => new Person());
            // Associated Objects
            // <None>
            // Return
            return mockVolumeWriter;
        }

        public static Mock<IVolumeWritersRepository> DoMockingSetupForRepository()
        {
            var mockVolumeWritersRepository = new Mock<IVolumeWritersRepository>();
            // Mock Functions
            mockVolumeWritersRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IVolumeWriter>().Object);
            mockVolumeWritersRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IVolumeWriter>().Object);
            mockVolumeWritersRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IVolumeWriter>>().Object);
            mockVolumeWritersRepository.Setup(m => m.Search(It.IsAny<IVolumeWriterSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IVolumeWriter>>().Object);
            mockVolumeWritersRepository.Setup(m => m.Add(It.IsAny<IVolumeWriter>()));
            mockVolumeWritersRepository.Setup(m => m.Remove(It.IsAny<IVolumeWriter>()));
            mockVolumeWritersRepository.Setup(m => m.Deactivate(It.IsAny<IVolumeWriter>()));
            mockVolumeWritersRepository.Setup(m => m.Update(It.IsAny<IVolumeWriter>()));
            // Return
            return mockVolumeWritersRepository;
        }
    }

    public class VolumeWritersBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "VolumeWriters")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockVolumeWritersRepository = VolumeWritersMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new VolumeWritersBusinessWorkflow(mockVolumeWritersRepository.Object, new VolumeWriterMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<VolumeWriterModel>(person);
        }

        [Fact][Trait("Category", "VolumeWriters")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockVolumeWritersRepository = VolumeWritersMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new VolumeWritersBusinessWorkflow(mockVolumeWritersRepository.Object, new VolumeWriterMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<VolumeWriterModel>(person);
        }

        [Fact][Trait("Category", "VolumeWriters")]
        public void Verify_Search_Should_ReturnAListOfVolumeWriters()
        {
            // Arrange
            var mockVolumeWritersRepository = VolumeWritersMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IVolumeWriterSearchModel>();
            var mockVolumeWritersMapper = new Mock<IVolumeWriterMapper>();
            mockVolumeWritersMapper.Setup(m => m.AreEqual(It.IsAny<IVolumeWriterModel>(), It.IsAny<IVolumeWriter>())).Returns(() => true);
            var businessWorkflow = new VolumeWritersBusinessWorkflow(mockVolumeWritersRepository.Object, mockVolumeWritersMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockVolumeWritersRepository.Verify(m => m.Search(It.IsAny<IVolumeWriterSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "VolumeWriters")]
        public void Verify_Search_AsListing_Should_ReturnAListOfVolumeWritersWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockVolumeWritersRepository = VolumeWritersMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IVolumeWriterSearchModel>();
            var mockVolumeWritersMapper = new Mock<IVolumeWriterMapper>();
            mockVolumeWritersMapper.Setup(m => m.AreEqual(It.IsAny<IVolumeWriterModel>(), It.IsAny<IVolumeWriter>())).Returns(() => true);
            var businessWorkflow = new VolumeWritersBusinessWorkflow(mockVolumeWritersRepository.Object, mockVolumeWritersMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockVolumeWritersRepository.Verify(m => m.Search(It.IsAny<IVolumeWriterSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "VolumeWriters")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockVolumeWritersRepository = VolumeWritersMockingSetup.DoMockingSetupForRepository();
            mockVolumeWritersRepository.Setup(m => m.Search(It.IsAny<IVolumeWriterSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IVolumeWriter>>().Object);
            var businessWorkflow = new VolumeWritersBusinessWorkflow(mockVolumeWritersRepository.Object, new VolumeWriterMapper());
            var model = VolumeWritersMockingSetup.DoMockingSetupForVolumeWriterModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockVolumeWritersRepository.Verify(m => m.Add(It.IsAny<IVolumeWriter>()), Times.Once);
        }
        [Fact][Trait("Category", "VolumeWriters")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockVolumeWritersRepository = VolumeWritersMockingSetup.DoMockingSetupForRepository();
            var mockVolumeWriter = VolumeWritersMockingSetup.DoMockingSetupForVolumeWriter(1);
            mockVolumeWritersRepository.Setup(m => m.Search(It.IsAny<IVolumeWriterSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IVolumeWriter> { mockVolumeWriter.Object } );
            mockVolumeWritersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockVolumeWriter.Object);
            var businessWorkflow = new VolumeWritersBusinessWorkflow(mockVolumeWritersRepository.Object, new VolumeWriterMapper());
            var model = VolumeWritersMockingSetup.DoMockingSetupForVolumeWriterModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockVolumeWritersRepository.Verify(m => m.Add(It.IsAny<IVolumeWriter>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "VolumeWriters")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockVolumeWriter = VolumeWritersMockingSetup.DoMockingSetupForVolumeWriter(1);
            var mockVolumeWritersRepository = VolumeWritersMockingSetup.DoMockingSetupForRepository();
            mockVolumeWritersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockVolumeWriter.Object);
            var businessWorkflow = new VolumeWritersBusinessWorkflow(mockVolumeWritersRepository.Object, new VolumeWriterMapper());
            var expectedName = "Stephen King (2)";
            var model = VolumeWritersMockingSetup.DoMockingSetupForVolumeWriterModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockVolumeWriter.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "VolumeWriters")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = VolumeWritersMockingSetup.DoMockingSetupForVolumeWriter(1);
            var mockVolumeWritersRepository = VolumeWritersMockingSetup.DoMockingSetupForRepository();
            mockVolumeWritersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new VolumeWritersBusinessWorkflow(mockVolumeWritersRepository.Object, new VolumeWriterMapper());
            var model = VolumeWritersMockingSetup.DoMockingSetupForVolumeWriterModel(1);
            IVolumeWriterModel result = null;
            // Act
            try { result = businessWorkflow.Update(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            Assert.NotNull(result);
            Assert.Equal("/TEST/KING-STEPHEN", result.ApiDetailUrl);
            Assert.Null(result.UpdatedDate);
        }
        #endregion
        #region Deactivate
        [Fact][Trait("Category", "VolumeWriters")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockVolumeWritersRepository = VolumeWritersMockingSetup.DoMockingSetupForRepository();
            var mockVolumeWritersMapper = new Mock<IVolumeWriterMapper>();
            mockVolumeWritersMapper.Setup(m => m.AreEqual(It.IsAny<IVolumeWriterModel>(), It.IsAny<IVolumeWriter>())).Returns(() => true);
            var businessWorkflow = new VolumeWritersBusinessWorkflow(mockVolumeWritersRepository.Object, mockVolumeWritersMapper.Object);
            mockVolumeWritersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IVolumeWriter>().Object);
            mockVolumeWritersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockVolumeWritersRepository.Verify(m => m.Deactivate(It.IsAny<IVolumeWriter>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "VolumeWriters")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockVolumeWritersRepository = VolumeWritersMockingSetup.DoMockingSetupForRepository();
            var mockVolumeWritersMapper = new Mock<IVolumeWriterMapper>();
            mockVolumeWritersMapper.Setup(m => m.AreEqual(It.IsAny<IVolumeWriterModel>(), It.IsAny<IVolumeWriter>())).Returns(() => true);
            var businessWorkflow = new VolumeWritersBusinessWorkflow(mockVolumeWritersRepository.Object, mockVolumeWritersMapper.Object);
            mockVolumeWritersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IVolumeWriter>().Object);
            mockVolumeWritersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockVolumeWritersRepository.Verify(m => m.Deactivate(It.IsAny<IVolumeWriter>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "VolumeWriters")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockVolumeWritersRepository = VolumeWritersMockingSetup.DoMockingSetupForRepository();
            mockVolumeWritersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockVolumeWritersMapper = new Mock<IVolumeWriterMapper>();
            mockVolumeWritersMapper.Setup(m => m.AreEqual(It.IsAny<IVolumeWriterModel>(), It.IsAny<IVolumeWriter>())).Returns(() => true);
            var businessWorkflow = new VolumeWritersBusinessWorkflow(mockVolumeWritersRepository.Object, mockVolumeWritersMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "VolumeWriters")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockVolumeWritersRepository = VolumeWritersMockingSetup.DoMockingSetupForRepository();
            mockVolumeWritersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockVolumeWritersMapper = new Mock<IVolumeWriterMapper>();
            mockVolumeWritersMapper.Setup(m => m.AreEqual(It.IsAny<IVolumeWriterModel>(), It.IsAny<IVolumeWriter>())).Returns(() => true);
            var businessWorkflow = new VolumeWritersBusinessWorkflow(mockVolumeWritersRepository.Object, mockVolumeWritersMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "VolumeWriters")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockVolumeWritersRepository = VolumeWritersMockingSetup.DoMockingSetupForRepository();
            var mockVolumeWritersMapper = new Mock<IVolumeWriterMapper>();
            mockVolumeWritersMapper.Setup(m => m.AreEqual(It.IsAny<IVolumeWriterModel>(), It.IsAny<IVolumeWriter>())).Returns(() => true);
            var businessWorkflow = new VolumeWritersBusinessWorkflow(mockVolumeWritersRepository.Object, mockVolumeWritersMapper.Object);
            mockVolumeWritersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IVolumeWriter>().Object);
            mockVolumeWritersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockVolumeWritersRepository.Verify(m => m.Remove(It.IsAny<IVolumeWriter>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "VolumeWriters")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockVolumeWritersRepository = VolumeWritersMockingSetup.DoMockingSetupForRepository();
            var mockVolumeWritersMapper = new Mock<IVolumeWriterMapper>();
            mockVolumeWritersMapper.Setup(m => m.AreEqual(It.IsAny<IVolumeWriterModel>(), It.IsAny<IVolumeWriter>())).Returns(() => true);
            var businessWorkflow = new VolumeWritersBusinessWorkflow(mockVolumeWritersRepository.Object, mockVolumeWritersMapper.Object);
            mockVolumeWritersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IVolumeWriter>().Object);
            mockVolumeWritersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockVolumeWritersRepository.Verify(m => m.Remove(It.IsAny<IVolumeWriter>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "VolumeWriters")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockVolumeWritersRepository = VolumeWritersMockingSetup.DoMockingSetupForRepository();
            mockVolumeWritersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new VolumeWritersBusinessWorkflow(mockVolumeWritersRepository.Object, new VolumeWriterMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
