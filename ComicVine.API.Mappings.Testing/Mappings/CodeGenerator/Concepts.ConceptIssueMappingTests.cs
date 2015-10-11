// <auto-generated>
// <copyright file="Concepts.IConceptIssueRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ConceptIssuesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Concepts
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class ConceptIssuesMockingSetup
    {
        public static Mock<IConceptIssueModel> DoMockingSetupForConceptIssueModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockConceptIssueModel = new Mock<IConceptIssueModel>();
            // Mock Functions
            mockConceptIssueModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockConceptIssueModel.Setup(m => m.Active).Returns(() => true);
            mockConceptIssueModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockConceptIssueModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptIssueModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptIssueModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockConceptIssueModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockConceptIssueModel.Setup(m => m.Name).Returns(() => name);
            //mockConceptIssueModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockConceptIssueModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockConceptIssueModel.Setup(m => m.ConceptId).Returns(() => 1);
            mockConceptIssueModel.Setup(m => m.Concept).Returns(() => new ConceptModel());
            mockConceptIssueModel.Setup(m => m.IssueId).Returns(() => 1);
            mockConceptIssueModel.Setup(m => m.Issue).Returns(() => new IssueModel());
            // Associated Objects
            // <None>
            // Return
            return mockConceptIssueModel;
        }

        public static Mock<IConceptIssue> DoMockingSetupForConceptIssue(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockConceptIssue = new Mock<IConceptIssue>();
            // Mock Functions
            mockConceptIssue.Setup(m => m.Id).Returns(() => idReturnValue);
            mockConceptIssue.Setup(m => m.Active).Returns(() => true);
            mockConceptIssue.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockConceptIssue.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptIssue.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptIssue.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockConceptIssue.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockConceptIssue.Setup(m => m.Name).Returns(() => name);
            //mockConceptIssue.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockConceptIssue.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockConceptIssue.Setup(m => m.ConceptId).Returns(() => 1);
            mockConceptIssue.Setup(m => m.Concept).Returns(() => new Concept());
            mockConceptIssue.Setup(m => m.IssueId).Returns(() => 1);
            mockConceptIssue.Setup(m => m.Issue).Returns(() => new Issue());
            // Associated Objects
            // <None>
            // Return
            return mockConceptIssue;
        }
    }

    public class ConceptIssueMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<ConceptIssueMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IConceptIssueModel>()));
            var mockModel = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssueModel(1);
            ConceptIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IConceptIssueModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<ConceptIssueMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IConceptIssueModel>(), ref It.IsAny<IConceptIssue>()));
        //    var mockModel = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssueModel(1);
        //    var mockEntity = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssue(1);
        //    ConceptIssueMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IConceptIssueModel>(), ref It.IsAny<IConceptIssue>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ConceptIssueMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IConceptIssue>()));
            var mockEntity = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssue(1);
            ConceptIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IConceptIssue>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ConceptIssueMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IConceptIssue>()));
            var mockEntity = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssue(1);
            ConceptIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IConceptIssue>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ConceptIssueMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IConceptIssue>()));
            var mockEntity = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssue(1);
            ConceptIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IConceptIssue>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ConceptIssueMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IConceptIssueModel>()));
            var mockModel = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssueModel(1);
            ConceptIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IConceptIssueModel>()), Times.Once);
        }

        [Fact]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<ConceptIssueMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IConceptIssueModel>(), It.IsAny<IConceptIssue>()));
            ConceptIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssueModel(1);
            var mockEntity = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssue(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IConceptIssueModel>(), It.IsAny<IConceptIssue>()), Times.Once);
        }
    }

    public class ConceptIssuesMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsConceptIssueProperties()
        {
            // Arrange
            var mapper = new ConceptIssueMapper();
            var model = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssueModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.ConceptId, entity.ConceptId);
            Assert.Equal(model.Object.IssueId, entity.IssueId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsConceptIssueProperties()
        {
            // Arrange
            var mapper = new ConceptIssueMapper();
            var model = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssueModel();
            // Act
            IConceptIssue existingEntity = new ConceptIssue { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.ConceptId, existingEntity.ConceptId);
            Assert.Equal(model.Object.IssueId, existingEntity.IssueId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsConceptIssueProperties()
        {
            // Arrange
            var mapper = new ConceptIssueMapper();
            var entity = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssue();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ConceptId, model.ConceptId);
            Assert.Equal(entity.Object.IssueId, model.IssueId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyConceptIssueProperties()
        {
            // Arrange
            var mapper = new ConceptIssueMapper();
            var entity = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssue();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ConceptId, model.ConceptId);
            Assert.Equal(entity.Object.IssueId, model.IssueId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyConceptIssueProperties()
        {
            // Arrange
            var mapper = new ConceptIssueMapper();
            var entity = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssue();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ConceptId, model.ConceptId);
            Assert.Equal(entity.Object.IssueId, model.IssueId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsConceptIssueSearchProperties()
        {
            // Arrange
            var mapper = new ConceptIssueMapper();
            var model = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssueModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.ConceptId, searchModel.ConceptId);
            Assert.Equal(model.Object.Concept?.CustomKey, searchModel.ConceptCustomKey);
            Assert.Equal(model.Object.Concept?.ApiDetailUrl, searchModel.ConceptApiDetailUrl);
            Assert.Equal(model.Object.Concept?.SiteDetailUrl, searchModel.ConceptSiteDetailUrl);
            Assert.Equal(model.Object.Concept?.Name, searchModel.ConceptName);
            Assert.Equal(model.Object.Concept?.ShortDescription, searchModel.ConceptShortDescription);
            Assert.Equal(model.Object.Concept?.Description, searchModel.ConceptDescription);
            Assert.Equal(model.Object.IssueId, searchModel.IssueId);
            Assert.Equal(model.Object.Issue?.CustomKey, searchModel.IssueCustomKey);
            Assert.Equal(model.Object.Issue?.ApiDetailUrl, searchModel.IssueApiDetailUrl);
            Assert.Equal(model.Object.Issue?.SiteDetailUrl, searchModel.IssueSiteDetailUrl);
            Assert.Equal(model.Object.Issue?.Name, searchModel.IssueName);
            Assert.Equal(model.Object.Issue?.ShortDescription, searchModel.IssueShortDescription);
            Assert.Equal(model.Object.Issue?.Description, searchModel.IssueDescription);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new ConceptIssueMapper();
            var model = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssueModel(1);
            var entity = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssue(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new ConceptIssueMapper();
            var model = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssueModel(1);
            var entity = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssue(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}