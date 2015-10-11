// <auto-generated>
// <copyright file="Locations.ILocationAliasRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the LocationAliasesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Repositories.Locations
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using API.Repositories;
    using DataModel.Schema;
    using Interfaces.SearchModels;
    using Moq;
    using SearchModels;
    using Xunit;

    public static class LocationAliasesMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeLocationAliasesData, out Mock<IDbSet<LocationAlias>> mockSetLocationAliases, bool markALocationAliasInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetLocationAliases = new Mock<IDbSet<LocationAlias>>();
            var personData = (!includeLocationAliasesData ? new List<LocationAlias>() : new List<LocationAlias>
            {
                new LocationAlias { Id = 1, Active = !markALocationAliasInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = "a famous novelist" },
                new LocationAlias { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", Name = "Larry Niven", Description = "a novelist" }
            }).AsQueryable();
            mockSetLocationAliases.As<IQueryable<LocationAlias>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetLocationAliases.As<IQueryable<LocationAlias>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetLocationAliases.As<IQueryable<LocationAlias>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetLocationAliases.As<IQueryable<LocationAlias>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.LocationAliases).Returns(mockSetLocationAliases.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class LocationAliasesRepositoryTests
    {
        [Fact]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<LocationAlias>> mockSetLocationAliases;
            var mockContext = LocationAliasesMockingSetup.DoMockingSetupForContext(false, out mockSetLocationAliases);
            var repository = new LocationAliasesRepository(mockContext.Object);
            var locationAliases = new LocationAlias { Active = true, CustomKey = "SALVATORE-RAA", Name = "R.A.A Salvatore", Description = "a novelist" };
            // Act
            repository.Add(locationAliases);
            // Assert
            mockSetLocationAliases.Verify(x => x.Add(locationAliases), Times.Once);
        }

        [Fact]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<LocationAlias>> mockSetLocationAliases;
            var mockContext = LocationAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationAliases);
            var repository = new LocationAliasesRepository(mockContext.Object);
            var locationAliases = repository.Get(1);
            // Act
            repository.Remove(locationAliases);
            // Assert
            mockSetLocationAliases.Verify(x => x.Remove((LocationAlias)locationAliases), Times.Once);
        }

        [Fact]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<LocationAlias>> mockSetLocationAliases;
            var mockContext = LocationAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationAliases);
            var repository = new LocationAliasesRepository(mockContext.Object);
            var locationAliases = repository.Get(1);
            // Act
            repository.Deactivate(locationAliases);
            // Assert
            Assert.Equal(false, locationAliases.Active);
        }

        [Fact]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<LocationAlias>> mockSetLocationAliases;
            var mockContext = LocationAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationAliases);
            var repository = new LocationAliasesRepository(mockContext.Object);
            var locationAliases = repository.Get(1);
            locationAliases.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(locationAliases);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectLocationAlias()
        {
            // Arrange
            Mock<IDbSet<LocationAlias>> mockSetLocationAliases;
            var mockContext = LocationAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationAliases);
            var repository = new LocationAliasesRepository(mockContext.Object);
            // Act
            var locationAliases = repository.Get(1);
            // Assert
            Assert.Equal("Stephen King", locationAliases.Name);            Assert.Equal("/TEST/KING-STEPHEN", locationAliases.ApiDetailUrl);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectLocationAlias()
        {
            // Arrange
            Mock<IDbSet<LocationAlias>> mockSetLocationAliases;
            var mockContext = LocationAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationAliases);
            var repository = new LocationAliasesRepository(mockContext.Object);
            // Act
            var locationAliases = repository.Get("KING-STEPHEN");
            // Assert
            Assert.Equal("Stephen King", locationAliases.Name);            Assert.Equal("/TEST/KING-STEPHEN", locationAliases.ApiDetailUrl);
        }

        [Fact]
        public void Verify_List_Should_ReturnAListOfLocationAliasesWithData()
        {
            // Arrange
            Mock<IDbSet<LocationAlias>> mockSetLocationAliases;
            var mockContext = LocationAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationAliases);
            var repository = new LocationAliasesRepository(mockContext.Object);
            // Act
            var locationAliases = repository.List.ToArray();
            // Assert
            Assert.Equal(2, locationAliases.Length);
            Assert.Equal(1, locationAliases[0].Id);
            Assert.Equal("Stephen King", locationAliases[0].Name);            Assert.Equal("/TEST/KING-STEPHEN", locationAliases[0].ApiDetailUrl);
            Assert.Equal(2, locationAliases[1].Id);
            Assert.Equal("Larry Niven", locationAliases[1].Name);            Assert.Equal("/TEST/NIVEN-LARRY", locationAliases[1].ApiDetailUrl);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfLocationAliasesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<LocationAlias>> mockSetLocationAliases;
            var mockContext = LocationAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationAliases, true);
            var repository = new LocationAliasesRepository(mockContext.Object);
            var searchModel = new Mock<ILocationAliasSearchModel>();
            // Act
            var locationAliases = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, locationAliases.Length);
            Assert.Equal(2, locationAliases[0].Id);
            Assert.Equal("Larry Niven", locationAliases[0].Name);            Assert.Equal("/TEST/NIVEN-LARRY", locationAliases[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<LocationAlias>> mockSetLocationAliases;
            var mockContext = LocationAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationAliases, true);
            var repository = new LocationAliasesRepository(mockContext.Object);
            var searchModel = new Mock<ILocationAliasSearchModel>();
            // Act
            var locationAliases = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl, MyName = i.Name }).ToArray();
            // Assert
            Assert.Equal(1, locationAliases.Length);
            Assert.Equal(2, locationAliases[0].Id);
            Assert.Equal("Larry Niven", locationAliases[0].MyName);            Assert.Equal("/TEST/NIVEN-LARRY", locationAliases[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfLocationAliasesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<LocationAlias>> mockSetLocationAliases;
            var mockContext = LocationAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationAliases, true);
            var repository = new LocationAliasesRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<ILocationAliasSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new LocationAliasSearchModel { ModifiedSince = createDate };
            // Act
            var locationAliases = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, locationAliases.Length);
            Assert.Equal(2, locationAliases[0].Id);
            Assert.Equal("Larry Niven", locationAliases[0].Name);            Assert.Equal("/TEST/NIVEN-LARRY", locationAliases[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact]
        public void Verify_Search_WithPaging_Should_ReturnAListOfLocationAliasesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<LocationAlias>> mockSetLocationAliases;
            var mockContext = LocationAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationAliases);
            var repository = new LocationAliasesRepository(mockContext.Object);
            var searchModel = new LocationAliasSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var locationAliases = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, locationAliases.Length);
            Assert.Equal(2, locationAliases[0].Id);
            Assert.Equal("Larry Niven", locationAliases[0].Name);            Assert.Equal("/TEST/NIVEN-LARRY", locationAliases[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
