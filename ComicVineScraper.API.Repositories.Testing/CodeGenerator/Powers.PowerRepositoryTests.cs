// <auto-generated>
// <copyright file="Powers.PowerRepositoryTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the PowersRepositoryTests class.</summary>
// <remarks>This file was auto-generated using RepositoryTestingFileMaster.tt in
// ComicVineScraper.API.Repositories.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Repositories.Powers
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

    public static class PowersMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includePowersData, out Mock<IDbSet<Power>> mockSetPowers, bool markAPowerInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetPowers = new Mock<IDbSet<Power>>();
            var personData = (!includePowersData ? new List<Power>() : new List<Power>
            {
                new Power { Id = 1, Active = !markAPowerInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new Power { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetPowers.As<IQueryable<Power>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetPowers.As<IQueryable<Power>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetPowers.As<IQueryable<Power>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetPowers.As<IQueryable<Power>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.Powers).Returns(mockSetPowers.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class PowersRepositoryTests
    {
        [Fact][Trait("Category", "Powers")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<Power>> mockSetPowers;
            var mockContext = PowersMockingSetup.DoMockingSetupForContext(false, out mockSetPowers);
            var repository = new PowersRepository(mockContext.Object);
            var powers = new Power { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(powers);
            // Assert
            mockSetPowers.Verify(x => x.Add(powers), Times.Once);
        }

        [Fact][Trait("Category", "Powers")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<Power>> mockSetPowers;
            var mockContext = PowersMockingSetup.DoMockingSetupForContext(true, out mockSetPowers);
            var repository = new PowersRepository(mockContext.Object);
            var powers = repository.Get(1);
            // Act
            repository.Remove(powers);
            // Assert
            mockSetPowers.Verify(x => x.Remove((Power)powers), Times.Once);
        }

        [Fact][Trait("Category", "Powers")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<Power>> mockSetPowers;
            var mockContext = PowersMockingSetup.DoMockingSetupForContext(true, out mockSetPowers);
            var repository = new PowersRepository(mockContext.Object);
            var powers = repository.Get(1);
            // Act
            repository.Deactivate(powers);
            // Assert
            Assert.Equal(false, powers.Active);
        }

        [Fact][Trait("Category", "Powers")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<Power>> mockSetPowers;
            var mockContext = PowersMockingSetup.DoMockingSetupForContext(true, out mockSetPowers);
            var repository = new PowersRepository(mockContext.Object);
            var powers = repository.Get(1);
            powers.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(powers);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "Powers")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectPower()
        {
            // Arrange
            Mock<IDbSet<Power>> mockSetPowers;
            var mockContext = PowersMockingSetup.DoMockingSetupForContext(true, out mockSetPowers);
            var repository = new PowersRepository(mockContext.Object);
            // Act
            var powers = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", powers.ApiDetailUrl);
        }

        [Fact][Trait("Category", "Powers")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectPower()
        {
            // Arrange
            Mock<IDbSet<Power>> mockSetPowers;
            var mockContext = PowersMockingSetup.DoMockingSetupForContext(true, out mockSetPowers);
            var repository = new PowersRepository(mockContext.Object);
            // Act
            var powers = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", powers.ApiDetailUrl);
        }

        [Fact][Trait("Category", "Powers")]
        public void Verify_List_Should_ReturnAListOfPowersWithData()
        {
            // Arrange
            Mock<IDbSet<Power>> mockSetPowers;
            var mockContext = PowersMockingSetup.DoMockingSetupForContext(true, out mockSetPowers);
            var repository = new PowersRepository(mockContext.Object);
            // Act
            var powers = repository.List.ToArray();
            // Assert
            Assert.Equal(2, powers.Length);
            Assert.Equal(1, powers[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", powers[0].ApiDetailUrl);
            Assert.Equal(2, powers[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", powers[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "Powers")]
        public void Verify_Search_Should_ReturnAListOfPowersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<Power>> mockSetPowers;
            var mockContext = PowersMockingSetup.DoMockingSetupForContext(true, out mockSetPowers, true);
            var repository = new PowersRepository(mockContext.Object);
            var searchModel = new Mock<IPowerSearchModel>();
            // Act
            var powers = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, powers.Length);
            Assert.Equal(2, powers[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", powers[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "Powers")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<Power>> mockSetPowers;
            var mockContext = PowersMockingSetup.DoMockingSetupForContext(true, out mockSetPowers, true);
            var repository = new PowersRepository(mockContext.Object);
            var searchModel = new Mock<IPowerSearchModel>();
            // Act
            var powers = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, powers.Length);
            Assert.Equal(2, powers[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", powers[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "Powers")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfPowersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<Power>> mockSetPowers;
            var mockContext = PowersMockingSetup.DoMockingSetupForContext(true, out mockSetPowers, true);
            var repository = new PowersRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IPowerSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new PowerSearchModel { ModifiedSince = createDate };
            // Act
            var powers = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, powers.Length);
            Assert.Equal(2, powers[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", powers[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "Powers")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfPowersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<Power>> mockSetPowers;
            var mockContext = PowersMockingSetup.DoMockingSetupForContext(true, out mockSetPowers);
            var repository = new PowersRepository(mockContext.Object);
            var searchModel = new PowerSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var powers = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, powers.Length);
            Assert.Equal(2, powers[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", powers[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}