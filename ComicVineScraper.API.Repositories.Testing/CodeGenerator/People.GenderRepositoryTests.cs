// <auto-generated>
// <copyright file="People.GenderRepositoryTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the GendersRepositoryTests class.</summary>
// <remarks>This file was auto-generated using RepositoryTestingFileMaster.tt in
// ComicVineScraper.API.Repositories.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Repositories.People
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

    public static class GendersMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeGendersData, out Mock<IDbSet<Gender>> mockSetGenders, bool markAGenderInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetGenders = new Mock<IDbSet<Gender>>();
            var personData = (!includeGendersData ? new List<Gender>() : new List<Gender>
            {
                new Gender { Id = 1, Active = !markAGenderInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new Gender { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetGenders.As<IQueryable<Gender>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetGenders.As<IQueryable<Gender>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetGenders.As<IQueryable<Gender>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetGenders.As<IQueryable<Gender>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.Genders).Returns(mockSetGenders.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class GendersRepositoryTests
    {
        [Fact][Trait("Category", "Genders")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<Gender>> mockSetGenders;
            var mockContext = GendersMockingSetup.DoMockingSetupForContext(false, out mockSetGenders);
            var repository = new GendersRepository(mockContext.Object);
            var genders = new Gender { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(genders);
            // Assert
            mockSetGenders.Verify(x => x.Add(genders), Times.Once);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<Gender>> mockSetGenders;
            var mockContext = GendersMockingSetup.DoMockingSetupForContext(true, out mockSetGenders);
            var repository = new GendersRepository(mockContext.Object);
            var genders = repository.Get(1);
            // Act
            repository.Remove(genders);
            // Assert
            mockSetGenders.Verify(x => x.Remove((Gender)genders), Times.Once);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<Gender>> mockSetGenders;
            var mockContext = GendersMockingSetup.DoMockingSetupForContext(true, out mockSetGenders);
            var repository = new GendersRepository(mockContext.Object);
            var genders = repository.Get(1);
            // Act
            repository.Deactivate(genders);
            // Assert
            Assert.Equal(false, genders.Active);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<Gender>> mockSetGenders;
            var mockContext = GendersMockingSetup.DoMockingSetupForContext(true, out mockSetGenders);
            var repository = new GendersRepository(mockContext.Object);
            var genders = repository.Get(1);
            genders.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(genders);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectGender()
        {
            // Arrange
            Mock<IDbSet<Gender>> mockSetGenders;
            var mockContext = GendersMockingSetup.DoMockingSetupForContext(true, out mockSetGenders);
            var repository = new GendersRepository(mockContext.Object);
            // Act
            var genders = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", genders.ApiDetailUrl);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectGender()
        {
            // Arrange
            Mock<IDbSet<Gender>> mockSetGenders;
            var mockContext = GendersMockingSetup.DoMockingSetupForContext(true, out mockSetGenders);
            var repository = new GendersRepository(mockContext.Object);
            // Act
            var genders = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", genders.ApiDetailUrl);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_List_Should_ReturnAListOfGendersWithData()
        {
            // Arrange
            Mock<IDbSet<Gender>> mockSetGenders;
            var mockContext = GendersMockingSetup.DoMockingSetupForContext(true, out mockSetGenders);
            var repository = new GendersRepository(mockContext.Object);
            // Act
            var genders = repository.List.ToArray();
            // Assert
            Assert.Equal(2, genders.Length);
            Assert.Equal(1, genders[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", genders[0].ApiDetailUrl);
            Assert.Equal(2, genders[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", genders[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Search_Should_ReturnAListOfGendersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<Gender>> mockSetGenders;
            var mockContext = GendersMockingSetup.DoMockingSetupForContext(true, out mockSetGenders, true);
            var repository = new GendersRepository(mockContext.Object);
            var searchModel = new Mock<IGenderSearchModel>();
            // Act
            var genders = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, genders.Length);
            Assert.Equal(2, genders[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", genders[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<Gender>> mockSetGenders;
            var mockContext = GendersMockingSetup.DoMockingSetupForContext(true, out mockSetGenders, true);
            var repository = new GendersRepository(mockContext.Object);
            var searchModel = new Mock<IGenderSearchModel>();
            // Act
            var genders = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, genders.Length);
            Assert.Equal(2, genders[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", genders[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfGendersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<Gender>> mockSetGenders;
            var mockContext = GendersMockingSetup.DoMockingSetupForContext(true, out mockSetGenders, true);
            var repository = new GendersRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IGenderSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new GenderSearchModel { ModifiedSince = createDate };
            // Act
            var genders = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, genders.Length);
            Assert.Equal(2, genders[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", genders[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfGendersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<Gender>> mockSetGenders;
            var mockContext = GendersMockingSetup.DoMockingSetupForContext(true, out mockSetGenders);
            var repository = new GendersRepository(mockContext.Object);
            var searchModel = new GenderSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var genders = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, genders.Length);
            Assert.Equal(2, genders[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", genders[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
