// <auto-generated>
// <copyright file="Episodes.IEpisodeRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Episodes
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class EpisodesMockingSetup
    {
        public static Mock<IEpisodeModel> DoMockingSetupForEpisodeModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeModel = new Mock<IEpisodeModel>();
            // Mock Functions
            mockEpisodeModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeModel.Setup(m => m.Active).Returns(() => true);
            mockEpisodeModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodeModel.Setup(m => m.Name).Returns(() => name);
            //mockEpisodeModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodeModel.Setup(m => m.Description).Returns(() => "long");
            mockEpisodeModel.Setup(m => m.HasStaffReview).Returns(() => true);
            mockEpisodeModel.Setup(m => m.AirDate).Returns(() => new System.DateTime());
            mockEpisodeModel.Setup(m => m.EpisodeCode).Returns(() => "EpisodeCode");
            mockEpisodeModel.Setup(m => m.SeasonNumber).Returns(() => 2000);
            mockEpisodeModel.Setup(m => m.EpisodeNumber).Returns(() => 2000);
            // Related Objects
            mockEpisodeModel.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockEpisodeModel.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFileModel());
            mockEpisodeModel.Setup(m => m.SeriesId).Returns(() => 1);
            mockEpisodeModel.Setup(m => m.Series).Returns(() => new SeriesModel());
            // Associated Objects
            mockEpisodeModel.Setup(m => m.EpisodeAliases).Returns(() => new List<IEpisodeAliasModel>());
            mockEpisodeModel.Setup(m => m.EpisodeCharacters).Returns(() => new List<IEpisodeCharacterModel>());
            mockEpisodeModel.Setup(m => m.EpisodeCharactersDied).Returns(() => new List<IEpisodeCharacterDiedModel>());
            mockEpisodeModel.Setup(m => m.EpisodeCharacterFirstAppearances).Returns(() => new List<IEpisodeCharacterFirstAppearanceModel>());
            mockEpisodeModel.Setup(m => m.EpisodeConcepts).Returns(() => new List<IEpisodeConceptModel>());
            mockEpisodeModel.Setup(m => m.EpisodeConceptFirstAppearances).Returns(() => new List<IEpisodeConceptFirstAppearanceModel>());
            mockEpisodeModel.Setup(m => m.EpisodeLocations).Returns(() => new List<IEpisodeLocationModel>());
            mockEpisodeModel.Setup(m => m.EpisodeLocationFirstAppearances).Returns(() => new List<IEpisodeLocationFirstAppearanceModel>());
            mockEpisodeModel.Setup(m => m.EpisodeObjects).Returns(() => new List<IEpisodeObjectModel>());
            mockEpisodeModel.Setup(m => m.EpisodeObjectFirstAppearances).Returns(() => new List<IEpisodeObjectFirstAppearanceModel>());
            mockEpisodeModel.Setup(m => m.EpisodePeople).Returns(() => new List<IEpisodePersonModel>());
            mockEpisodeModel.Setup(m => m.EpisodeStoryArcs).Returns(() => new List<IEpisodeStoryArcModel>());
            mockEpisodeModel.Setup(m => m.EpisodeStoryArcFirstAppearances).Returns(() => new List<IEpisodeStoryArcFirstAppearanceModel>());
            mockEpisodeModel.Setup(m => m.EpisodeTeams).Returns(() => new List<IEpisodeTeamModel>());
            mockEpisodeModel.Setup(m => m.EpisodeTeamFirstAppearances).Returns(() => new List<IEpisodeTeamFirstAppearanceModel>());
            // Return
            return mockEpisodeModel;
        }

        public static Mock<IEpisode> DoMockingSetupForEpisode(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisode = new Mock<IEpisode>();
            // Mock Functions
            mockEpisode.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisode.Setup(m => m.Active).Returns(() => true);
            mockEpisode.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisode.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisode.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisode.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisode.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisode.Setup(m => m.Name).Returns(() => name);
            //mockEpisode.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisode.Setup(m => m.Description).Returns(() => "long");
            mockEpisode.Setup(m => m.HasStaffReview).Returns(() => true);
            mockEpisode.Setup(m => m.AirDate).Returns(() => new System.DateTime());
            mockEpisode.Setup(m => m.EpisodeCode).Returns(() => "EpisodeCode");
            mockEpisode.Setup(m => m.SeasonNumber).Returns(() => 2000);
            mockEpisode.Setup(m => m.EpisodeNumber).Returns(() => 2000);
            // Related Objects
            mockEpisode.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockEpisode.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFile());
            mockEpisode.Setup(m => m.SeriesId).Returns(() => 1);
            mockEpisode.Setup(m => m.Series).Returns(() => new Series());
            // Associated Objects
            mockEpisode.Setup(m => m.EpisodeAliases).Returns(() => new List<IEpisodeAlias>());
            mockEpisode.Setup(m => m.EpisodeCharacters).Returns(() => new List<IEpisodeCharacter>());
            mockEpisode.Setup(m => m.EpisodeCharactersDied).Returns(() => new List<IEpisodeCharacterDied>());
            mockEpisode.Setup(m => m.EpisodeCharacterFirstAppearances).Returns(() => new List<IEpisodeCharacterFirstAppearance>());
            mockEpisode.Setup(m => m.EpisodeConcepts).Returns(() => new List<IEpisodeConcept>());
            mockEpisode.Setup(m => m.EpisodeConceptFirstAppearances).Returns(() => new List<IEpisodeConceptFirstAppearance>());
            mockEpisode.Setup(m => m.EpisodeLocations).Returns(() => new List<IEpisodeLocation>());
            mockEpisode.Setup(m => m.EpisodeLocationFirstAppearances).Returns(() => new List<IEpisodeLocationFirstAppearance>());
            mockEpisode.Setup(m => m.EpisodeObjects).Returns(() => new List<IEpisodeObject>());
            mockEpisode.Setup(m => m.EpisodeObjectFirstAppearances).Returns(() => new List<IEpisodeObjectFirstAppearance>());
            mockEpisode.Setup(m => m.EpisodePeople).Returns(() => new List<IEpisodePerson>());
            mockEpisode.Setup(m => m.EpisodeStoryArcs).Returns(() => new List<IEpisodeStoryArc>());
            mockEpisode.Setup(m => m.EpisodeStoryArcFirstAppearances).Returns(() => new List<IEpisodeStoryArcFirstAppearance>());
            mockEpisode.Setup(m => m.EpisodeTeams).Returns(() => new List<IEpisodeTeam>());
            mockEpisode.Setup(m => m.EpisodeTeamFirstAppearances).Returns(() => new List<IEpisodeTeamFirstAppearance>());
            // Return
            return mockEpisode;
        }
    }

    public class EpisodeMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodeModel>()));
            var mockModel = EpisodesMockingSetup.DoMockingSetupForEpisodeModel(1);
            EpisodeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodeModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<EpisodeMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodeModel>(), ref It.IsAny<IEpisode>()));
        //    var mockModel = EpisodesMockingSetup.DoMockingSetupForEpisodeModel(1);
        //    var mockEntity = EpisodesMockingSetup.DoMockingSetupForEpisode(1);
        //    EpisodeMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodeModel>(), ref It.IsAny<IEpisode>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IEpisode>()));
            var mockEntity = EpisodesMockingSetup.DoMockingSetupForEpisode(1);
            EpisodeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IEpisode>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IEpisode>()));
            var mockEntity = EpisodesMockingSetup.DoMockingSetupForEpisode(1);
            EpisodeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IEpisode>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IEpisode>()));
            var mockEntity = EpisodesMockingSetup.DoMockingSetupForEpisode(1);
            EpisodeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IEpisode>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IEpisodeModel>()));
            var mockModel = EpisodesMockingSetup.DoMockingSetupForEpisodeModel(1);
            EpisodeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IEpisodeModel>()), Times.Once);
        }

        public static Mock<IEpisode> DoMockingSetupForEpisode(int idReturnValue = 0)
        {
            var mockEpisode = new Mock<IEpisode>();
            // Mock Functions
            mockEpisode.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisode.Setup(m => m.Active).Returns(() => true);
            mockEpisode.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisode.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisode.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisode.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisode.Setup(m => m.UpdatedDate).Returns(() => null);
            mockEpisode.Setup(m => m.HasStaffReview).Returns(() => true);
            mockEpisode.Setup(m => m.AirDate).Returns(() => new System.DateTime());
            mockEpisode.Setup(m => m.EpisodeCode).Returns(() => "EpisodeCode");
            mockEpisode.Setup(m => m.SeasonNumber).Returns(() => 2000);
            mockEpisode.Setup(m => m.EpisodeNumber).Returns(() => 2000);
            // Related Objects
            mockEpisode.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockEpisode.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFile());
            mockEpisode.Setup(m => m.SeriesId).Returns(() => 1);
            mockEpisode.Setup(m => m.Series).Returns(() => new Series());
            // Associated Objects
            mockEpisode.Setup(m => m.EpisodeAliases).Returns(() => new List<IEpisodeAlias>());
            mockEpisode.Setup(m => m.EpisodeCharacters).Returns(() => new List<IEpisodeCharacter>());
            mockEpisode.Setup(m => m.EpisodeCharactersDied).Returns(() => new List<IEpisodeCharacterDied>());
            mockEpisode.Setup(m => m.EpisodeCharacterFirstAppearances).Returns(() => new List<IEpisodeCharacterFirstAppearance>());
            mockEpisode.Setup(m => m.EpisodeConcepts).Returns(() => new List<IEpisodeConcept>());
            mockEpisode.Setup(m => m.EpisodeConceptFirstAppearances).Returns(() => new List<IEpisodeConceptFirstAppearance>());
            mockEpisode.Setup(m => m.EpisodeLocations).Returns(() => new List<IEpisodeLocation>());
            mockEpisode.Setup(m => m.EpisodeLocationFirstAppearances).Returns(() => new List<IEpisodeLocationFirstAppearance>());
            mockEpisode.Setup(m => m.EpisodeObjects).Returns(() => new List<IEpisodeObject>());
            mockEpisode.Setup(m => m.EpisodeObjectFirstAppearances).Returns(() => new List<IEpisodeObjectFirstAppearance>());
            mockEpisode.Setup(m => m.EpisodePeople).Returns(() => new List<IEpisodePerson>());
            mockEpisode.Setup(m => m.EpisodeStoryArcs).Returns(() => new List<IEpisodeStoryArc>());
            mockEpisode.Setup(m => m.EpisodeStoryArcFirstAppearances).Returns(() => new List<IEpisodeStoryArcFirstAppearance>());
            mockEpisode.Setup(m => m.EpisodeTeams).Returns(() => new List<IEpisodeTeam>());
            mockEpisode.Setup(m => m.EpisodeTeamFirstAppearances).Returns(() => new List<IEpisodeTeamFirstAppearance>());
            // Return
            return mockEpisode;
        }
    }

    public class EpisodesMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsEpisodeProperties()
        {
            // Arrange
            var mapper = new EpisodeMapper();
            var model = EpisodesMockingSetup.DoMockingSetupForEpisodeModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            Assert.Equal(model.Object.HasStaffReview, entity.HasStaffReview);
            Assert.Equal(model.Object.AirDate, entity.AirDate);
            Assert.Equal(model.Object.EpisodeCode, entity.EpisodeCode);
            Assert.Equal(model.Object.SeasonNumber, entity.SeasonNumber);
            Assert.Equal(model.Object.EpisodeNumber, entity.EpisodeNumber);
            // Related Objects
            Assert.Equal(model.Object.PrimaryImageFileId, entity.PrimaryImageFileId);
            Assert.Equal(model.Object.SeriesId, entity.SeriesId);
            // Associated Objects
            //Assert.Equal(model.Object.EpisodeAliases?.Count, entity.EpisodeAliases?.Count);
            model.VerifyGet(x => x.EpisodeAliases, Times.Once);
            //Assert.Equal(model.Object.EpisodeCharacters?.Count, entity.EpisodeCharacters?.Count);
            model.VerifyGet(x => x.EpisodeCharacters, Times.Once);
            //Assert.Equal(model.Object.EpisodeCharactersDied?.Count, entity.EpisodeCharactersDied?.Count);
            model.VerifyGet(x => x.EpisodeCharactersDied, Times.Once);
            //Assert.Equal(model.Object.EpisodeCharacterFirstAppearances?.Count, entity.EpisodeCharacterFirstAppearances?.Count);
            model.VerifyGet(x => x.EpisodeCharacterFirstAppearances, Times.Once);
            //Assert.Equal(model.Object.EpisodeConcepts?.Count, entity.EpisodeConcepts?.Count);
            model.VerifyGet(x => x.EpisodeConcepts, Times.Once);
            //Assert.Equal(model.Object.EpisodeConceptFirstAppearances?.Count, entity.EpisodeConceptFirstAppearances?.Count);
            model.VerifyGet(x => x.EpisodeConceptFirstAppearances, Times.Once);
            //Assert.Equal(model.Object.EpisodeLocations?.Count, entity.EpisodeLocations?.Count);
            model.VerifyGet(x => x.EpisodeLocations, Times.Once);
            //Assert.Equal(model.Object.EpisodeLocationFirstAppearances?.Count, entity.EpisodeLocationFirstAppearances?.Count);
            model.VerifyGet(x => x.EpisodeLocationFirstAppearances, Times.Once);
            //Assert.Equal(model.Object.EpisodeObjects?.Count, entity.EpisodeObjects?.Count);
            model.VerifyGet(x => x.EpisodeObjects, Times.Once);
            //Assert.Equal(model.Object.EpisodeObjectFirstAppearances?.Count, entity.EpisodeObjectFirstAppearances?.Count);
            model.VerifyGet(x => x.EpisodeObjectFirstAppearances, Times.Once);
            //Assert.Equal(model.Object.EpisodePeople?.Count, entity.EpisodePeople?.Count);
            model.VerifyGet(x => x.EpisodePeople, Times.Once);
            //Assert.Equal(model.Object.EpisodeStoryArcs?.Count, entity.EpisodeStoryArcs?.Count);
            model.VerifyGet(x => x.EpisodeStoryArcs, Times.Once);
            //Assert.Equal(model.Object.EpisodeStoryArcFirstAppearances?.Count, entity.EpisodeStoryArcFirstAppearances?.Count);
            model.VerifyGet(x => x.EpisodeStoryArcFirstAppearances, Times.Once);
            //Assert.Equal(model.Object.EpisodeTeams?.Count, entity.EpisodeTeams?.Count);
            model.VerifyGet(x => x.EpisodeTeams, Times.Once);
            //Assert.Equal(model.Object.EpisodeTeamFirstAppearances?.Count, entity.EpisodeTeamFirstAppearances?.Count);
            model.VerifyGet(x => x.EpisodeTeamFirstAppearances, Times.Once);
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsEpisodeProperties()
        {
            // Arrange
            var mapper = new EpisodeMapper();
            var model = EpisodesMockingSetup.DoMockingSetupForEpisodeModel();
            // Act
            IEpisode existingEntity = new Episode { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            Assert.Equal(model.Object.HasStaffReview, existingEntity.HasStaffReview);
            Assert.Equal(model.Object.AirDate, existingEntity.AirDate);
            Assert.Equal(model.Object.EpisodeCode, existingEntity.EpisodeCode);
            Assert.Equal(model.Object.SeasonNumber, existingEntity.SeasonNumber);
            Assert.Equal(model.Object.EpisodeNumber, existingEntity.EpisodeNumber);
            // Related Objects
            Assert.Equal(model.Object.PrimaryImageFileId, existingEntity.PrimaryImageFileId);
            Assert.Equal(model.Object.SeriesId, existingEntity.SeriesId);
            // Associated Objects
            model.VerifyGet(x => x.EpisodeAliases, Times.Once);
            //Assert.Equal(model.Object.EpisodeAliases?.Count, existingEntity.EpisodeAliases?.Count);
            model.VerifyGet(x => x.EpisodeCharacters, Times.Once);
            //Assert.Equal(model.Object.EpisodeCharacters?.Count, existingEntity.EpisodeCharacters?.Count);
            model.VerifyGet(x => x.EpisodeCharactersDied, Times.Once);
            //Assert.Equal(model.Object.EpisodeCharactersDied?.Count, existingEntity.EpisodeCharactersDied?.Count);
            model.VerifyGet(x => x.EpisodeCharacterFirstAppearances, Times.Once);
            //Assert.Equal(model.Object.EpisodeCharacterFirstAppearances?.Count, existingEntity.EpisodeCharacterFirstAppearances?.Count);
            model.VerifyGet(x => x.EpisodeConcepts, Times.Once);
            //Assert.Equal(model.Object.EpisodeConcepts?.Count, existingEntity.EpisodeConcepts?.Count);
            model.VerifyGet(x => x.EpisodeConceptFirstAppearances, Times.Once);
            //Assert.Equal(model.Object.EpisodeConceptFirstAppearances?.Count, existingEntity.EpisodeConceptFirstAppearances?.Count);
            model.VerifyGet(x => x.EpisodeLocations, Times.Once);
            //Assert.Equal(model.Object.EpisodeLocations?.Count, existingEntity.EpisodeLocations?.Count);
            model.VerifyGet(x => x.EpisodeLocationFirstAppearances, Times.Once);
            //Assert.Equal(model.Object.EpisodeLocationFirstAppearances?.Count, existingEntity.EpisodeLocationFirstAppearances?.Count);
            model.VerifyGet(x => x.EpisodeObjects, Times.Once);
            //Assert.Equal(model.Object.EpisodeObjects?.Count, existingEntity.EpisodeObjects?.Count);
            model.VerifyGet(x => x.EpisodeObjectFirstAppearances, Times.Once);
            //Assert.Equal(model.Object.EpisodeObjectFirstAppearances?.Count, existingEntity.EpisodeObjectFirstAppearances?.Count);
            model.VerifyGet(x => x.EpisodePeople, Times.Once);
            //Assert.Equal(model.Object.EpisodePeople?.Count, existingEntity.EpisodePeople?.Count);
            model.VerifyGet(x => x.EpisodeStoryArcs, Times.Once);
            //Assert.Equal(model.Object.EpisodeStoryArcs?.Count, existingEntity.EpisodeStoryArcs?.Count);
            model.VerifyGet(x => x.EpisodeStoryArcFirstAppearances, Times.Once);
            //Assert.Equal(model.Object.EpisodeStoryArcFirstAppearances?.Count, existingEntity.EpisodeStoryArcFirstAppearances?.Count);
            model.VerifyGet(x => x.EpisodeTeams, Times.Once);
            //Assert.Equal(model.Object.EpisodeTeams?.Count, existingEntity.EpisodeTeams?.Count);
            model.VerifyGet(x => x.EpisodeTeamFirstAppearances, Times.Once);
            //Assert.Equal(model.Object.EpisodeTeamFirstAppearances?.Count, existingEntity.EpisodeTeamFirstAppearances?.Count);
        }

        [Fact]
        public void Verify_MapToModel_AssignsEpisodeProperties()
        {
            // Arrange
            var mapper = new EpisodeMapper();
            var entity = EpisodesMockingSetup.DoMockingSetupForEpisode();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            Assert.Equal(entity.Object.HasStaffReview, model.HasStaffReview);
            Assert.Equal(entity.Object.AirDate, model.AirDate);
            Assert.Equal(entity.Object.EpisodeCode, model.EpisodeCode);
            Assert.Equal(entity.Object.SeasonNumber, model.SeasonNumber);
            Assert.Equal(entity.Object.EpisodeNumber, model.EpisodeNumber);
            // Related Objects
            Assert.Equal(entity.Object.PrimaryImageFileId, model.PrimaryImageFileId);
            Assert.Equal(entity.Object.SeriesId, model.SeriesId);
            // Associated Objects
            Assert.Equal(entity.Object.EpisodeAliases?.Count, model.EpisodeAliases?.Count);
            Assert.Equal(entity.Object.EpisodeCharacters?.Count, model.EpisodeCharacters?.Count);
            Assert.Equal(entity.Object.EpisodeCharactersDied?.Count, model.EpisodeCharactersDied?.Count);
            Assert.Equal(entity.Object.EpisodeCharacterFirstAppearances?.Count, model.EpisodeCharacterFirstAppearances?.Count);
            Assert.Equal(entity.Object.EpisodeConcepts?.Count, model.EpisodeConcepts?.Count);
            Assert.Equal(entity.Object.EpisodeConceptFirstAppearances?.Count, model.EpisodeConceptFirstAppearances?.Count);
            Assert.Equal(entity.Object.EpisodeLocations?.Count, model.EpisodeLocations?.Count);
            Assert.Equal(entity.Object.EpisodeLocationFirstAppearances?.Count, model.EpisodeLocationFirstAppearances?.Count);
            Assert.Equal(entity.Object.EpisodeObjects?.Count, model.EpisodeObjects?.Count);
            Assert.Equal(entity.Object.EpisodeObjectFirstAppearances?.Count, model.EpisodeObjectFirstAppearances?.Count);
            Assert.Equal(entity.Object.EpisodePeople?.Count, model.EpisodePeople?.Count);
            Assert.Equal(entity.Object.EpisodeStoryArcs?.Count, model.EpisodeStoryArcs?.Count);
            Assert.Equal(entity.Object.EpisodeStoryArcFirstAppearances?.Count, model.EpisodeStoryArcFirstAppearances?.Count);
            Assert.Equal(entity.Object.EpisodeTeams?.Count, model.EpisodeTeams?.Count);
            Assert.Equal(entity.Object.EpisodeTeamFirstAppearances?.Count, model.EpisodeTeamFirstAppearances?.Count);
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyEpisodeProperties()
        {
            // Arrange
            var mapper = new EpisodeMapper();
            var entity = EpisodesMockingSetup.DoMockingSetupForEpisode();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            Assert.Equal(entity.Object.HasStaffReview, model.HasStaffReview);
            Assert.Equal(entity.Object.AirDate, model.AirDate);
            Assert.Equal(entity.Object.EpisodeCode, model.EpisodeCode);
            Assert.Equal(entity.Object.SeasonNumber, model.SeasonNumber);
            Assert.Equal(entity.Object.EpisodeNumber, model.EpisodeNumber);
            // Related Objects
            Assert.Equal(entity.Object.PrimaryImageFileId, model.PrimaryImageFileId);
            Assert.Equal(entity.Object.SeriesId, model.SeriesId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyEpisodeProperties()
        {
            // Arrange
            var mapper = new EpisodeMapper();
            var entity = EpisodesMockingSetup.DoMockingSetupForEpisode();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            Assert.Equal(entity.Object.HasStaffReview, model.HasStaffReview);
            Assert.Equal(entity.Object.AirDate, model.AirDate);
            Assert.Equal(entity.Object.EpisodeCode, model.EpisodeCode);
            Assert.Equal(entity.Object.SeasonNumber, model.SeasonNumber);
            Assert.Equal(entity.Object.EpisodeNumber, model.EpisodeNumber);
            // Related Objects
            Assert.Equal(entity.Object.PrimaryImageFileId, model.PrimaryImageFileId);
            Assert.Equal(entity.Object.SeriesId, model.SeriesId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsEpisodeSearchProperties()
        {
            // Arrange
            var mapper = new EpisodeMapper();
            var model = EpisodesMockingSetup.DoMockingSetupForEpisodeModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.PrimaryImageFileId, searchModel.PrimaryImageFileId);
            Assert.Equal(model.Object.PrimaryImageFile?.CustomKey, searchModel.PrimaryImageFileCustomKey);
            Assert.Equal(model.Object.PrimaryImageFile?.ApiDetailUrl, searchModel.PrimaryImageFileApiDetailUrl);
            Assert.Equal(model.Object.PrimaryImageFile?.SiteDetailUrl, searchModel.PrimaryImageFileSiteDetailUrl);
            Assert.Equal(model.Object.PrimaryImageFile?.Name, searchModel.PrimaryImageFileName);
            Assert.Equal(model.Object.PrimaryImageFile?.ShortDescription, searchModel.PrimaryImageFileShortDescription);
            Assert.Equal(model.Object.PrimaryImageFile?.Description, searchModel.PrimaryImageFileDescription);
            Assert.Equal(model.Object.SeriesId, searchModel.SeriesId);
            Assert.Equal(model.Object.Series?.CustomKey, searchModel.SeriesCustomKey);
            Assert.Equal(model.Object.Series?.ApiDetailUrl, searchModel.SeriesApiDetailUrl);
            Assert.Equal(model.Object.Series?.SiteDetailUrl, searchModel.SeriesSiteDetailUrl);
            Assert.Equal(model.Object.Series?.Name, searchModel.SeriesName);
            Assert.Equal(model.Object.Series?.ShortDescription, searchModel.SeriesShortDescription);
            Assert.Equal(model.Object.Series?.Description, searchModel.SeriesDescription);
            Assert.Equal(model.Object.HasStaffReview, searchModel.HasStaffReview);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new EpisodeMapper();
            var model = EpisodesMockingSetup.DoMockingSetupForEpisodeModel(1);
            var entity = EpisodesMockingSetup.DoMockingSetupForEpisode(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new EpisodeMapper();
            var model = EpisodesMockingSetup.DoMockingSetupForEpisodeModel(1);
            var entity = EpisodesMockingSetup.DoMockingSetupForEpisode(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
