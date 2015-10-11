// <auto-generated>
// <copyright file="Powers.IPowerRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the PowersRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Powers
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class PowersMockingSetup
    {
        public static Mock<IPowerModel> DoMockingSetupForPowerModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockPowerModel = new Mock<IPowerModel>();
            // Mock Functions
            mockPowerModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockPowerModel.Setup(m => m.Active).Returns(() => true);
            mockPowerModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockPowerModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPowerModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPowerModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockPowerModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockPowerModel.Setup(m => m.Name).Returns(() => name);
            //mockPowerModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockPowerModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockPowerModel.Setup(m => m.CharacterPowers).Returns(() => new List<ICharacterPowerModel>());
            mockPowerModel.Setup(m => m.PowerAliases).Returns(() => new List<IPowerAliasModel>());
            // Return
            return mockPowerModel;
        }

        public static Mock<IPower> DoMockingSetupForPower(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockPower = new Mock<IPower>();
            // Mock Functions
            mockPower.Setup(m => m.Id).Returns(() => idReturnValue);
            mockPower.Setup(m => m.Active).Returns(() => true);
            mockPower.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockPower.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPower.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPower.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockPower.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockPower.Setup(m => m.Name).Returns(() => name);
            //mockPower.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockPower.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockPower.Setup(m => m.CharacterPowers).Returns(() => new List<ICharacterPower>());
            mockPower.Setup(m => m.PowerAliases).Returns(() => new List<IPowerAlias>());
            // Return
            return mockPower;
        }
    }

    public class PowerMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<PowerMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IPowerModel>()));
            var mockModel = PowersMockingSetup.DoMockingSetupForPowerModel(1);
            PowerMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IPowerModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<PowerMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IPowerModel>(), ref It.IsAny<IPower>()));
        //    var mockModel = PowersMockingSetup.DoMockingSetupForPowerModel(1);
        //    var mockEntity = PowersMockingSetup.DoMockingSetupForPower(1);
        //    PowerMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IPowerModel>(), ref It.IsAny<IPower>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<PowerMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IPower>()));
            var mockEntity = PowersMockingSetup.DoMockingSetupForPower(1);
            PowerMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IPower>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<PowerMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IPower>()));
            var mockEntity = PowersMockingSetup.DoMockingSetupForPower(1);
            PowerMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IPower>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<PowerMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IPower>()));
            var mockEntity = PowersMockingSetup.DoMockingSetupForPower(1);
            PowerMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IPower>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<PowerMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IPowerModel>()));
            var mockModel = PowersMockingSetup.DoMockingSetupForPowerModel(1);
            PowerMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IPowerModel>()), Times.Once);
        }

        public static Mock<IPower> DoMockingSetupForPower(int idReturnValue = 0)
        {
            var mockPower = new Mock<IPower>();
            // Mock Functions
            mockPower.Setup(m => m.Id).Returns(() => idReturnValue);
            mockPower.Setup(m => m.Active).Returns(() => true);
            mockPower.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockPower.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPower.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPower.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockPower.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockPower.Setup(m => m.CharacterPowers).Returns(() => new List<ICharacterPower>());
            mockPower.Setup(m => m.PowerAliases).Returns(() => new List<IPowerAlias>());
            // Return
            return mockPower;
        }
    }

    public class PowersMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsPowerProperties()
        {
            // Arrange
            var mapper = new PowerMapper();
            var model = PowersMockingSetup.DoMockingSetupForPowerModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            //Assert.Equal(model.Object.CharacterPowers?.Count, entity.CharacterPowers?.Count);
            model.VerifyGet(x => x.CharacterPowers, Times.Once);
            //Assert.Equal(model.Object.PowerAliases?.Count, entity.PowerAliases?.Count);
            model.VerifyGet(x => x.PowerAliases, Times.Once);
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsPowerProperties()
        {
            // Arrange
            var mapper = new PowerMapper();
            var model = PowersMockingSetup.DoMockingSetupForPowerModel();
            // Act
            IPower existingEntity = new Power { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            model.VerifyGet(x => x.CharacterPowers, Times.Once);
            //Assert.Equal(model.Object.CharacterPowers?.Count, existingEntity.CharacterPowers?.Count);
            model.VerifyGet(x => x.PowerAliases, Times.Once);
            //Assert.Equal(model.Object.PowerAliases?.Count, existingEntity.PowerAliases?.Count);
        }

        [Fact]
        public void Verify_MapToModel_AssignsPowerProperties()
        {
            // Arrange
            var mapper = new PowerMapper();
            var entity = PowersMockingSetup.DoMockingSetupForPower();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            Assert.Equal(entity.Object.CharacterPowers?.Count, model.CharacterPowers?.Count);
            Assert.Equal(entity.Object.PowerAliases?.Count, model.PowerAliases?.Count);
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyPowerProperties()
        {
            // Arrange
            var mapper = new PowerMapper();
            var entity = PowersMockingSetup.DoMockingSetupForPower();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyPowerProperties()
        {
            // Arrange
            var mapper = new PowerMapper();
            var entity = PowersMockingSetup.DoMockingSetupForPower();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsPowerSearchProperties()
        {
            // Arrange
            var mapper = new PowerMapper();
            var model = PowersMockingSetup.DoMockingSetupForPowerModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new PowerMapper();
            var model = PowersMockingSetup.DoMockingSetupForPowerModel(1);
            var entity = PowersMockingSetup.DoMockingSetupForPower(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new PowerMapper();
            var model = PowersMockingSetup.DoMockingSetupForPowerModel(1);
            var entity = PowersMockingSetup.DoMockingSetupForPower(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
