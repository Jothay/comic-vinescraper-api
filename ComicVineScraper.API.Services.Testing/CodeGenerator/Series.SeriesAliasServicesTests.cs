// <auto-generated>
// <copyright file="Series.ISeriesAliasServicesTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the SeriesAliases ServiceStack Services Tests.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in
// ComicVineScraper.API.Services.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Services//.Series
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class SeriesAliasesMockingSetup
    {
        public static Mock<ISeriesAliasesBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockSeriesAliasesBusinessWorkflow = new Mock<ISeriesAliasesBusinessWorkflow>();
            // Mock Functions
            mockSeriesAliasesBusinessWorkflow.Setup(m => m.Search(It.IsAny<ISeriesAliasSearchModel>(), It.IsAny<bool>())).Returns(() => new List<ISeriesAliasModel>());
            mockSeriesAliasesBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ISeriesAliasModel>().Object);
            mockSeriesAliasesBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ISeriesAliasModel>().Object);
            mockSeriesAliasesBusinessWorkflow.Setup(m => m.Create(It.IsAny<ISeriesAliasModel>())).Returns(() => new Mock<ISeriesAliasModel>().Object);
            mockSeriesAliasesBusinessWorkflow.Setup(m => m.Update(It.IsAny<ISeriesAliasModel>())).Returns(() => new Mock<ISeriesAliasModel>().Object);
            mockSeriesAliasesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockSeriesAliasesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockSeriesAliasesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockSeriesAliasesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockSeriesAliasesBusinessWorkflow;
        }
    }

    //public class SeriesAliasesServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "SeriesAliases")]
        public void Verify_GetSeriesAliases_Should_ReturnAListOfSeriesAliasModels()
        {
            var service = AppHost.Container.Resolve<ISeriesAliasesServices>();
            var response = service.Any(new GetSeriesAliases { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<ISeriesAliasModel>>(response);
        }
        [Fact][Trait("Category", "SeriesAliases")]
        public void Verify_GetSeriesAliasesAsListing_Should_ReturnAListOfSeriesAliasModels()
        {
            var service = AppHost.Container.Resolve<ISeriesAliasesServices>();
            var response = service.Any(new GetSeriesAliasesAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<ISeriesAliasModel>>(response);
        }
        [Fact][Trait("Category", "SeriesAliases")]
        public void Verify_GetSeriesAlias_Should_ReturnAnSeriesAliasModel()
        {
            var service = AppHost.Container.Resolve<ISeriesAliasesServices>();
            var response = service.Any(new GetSeriesAlias { ID = 1 });
            Assert.Equal(nameof(ISeriesAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "SeriesAliases")]
        public void Verify_GetSeriesAliasByKey_Should_ReturnAnSeriesAliasModel()
        {
            var service = AppHost.Container.Resolve<ISeriesAliasesServices>();
            var response = service.Any(new GetSeriesAliasByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(ISeriesAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "SeriesAliases")]
        public void Verify_CreateSeriesAlias_Should_ReturnAnSeriesAliasModel()
        {
            var service = AppHost.Container.Resolve<ISeriesAliasesServices>();
            var response = service.Any(new CreateSeriesAlias { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(ISeriesAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "SeriesAliases")]
        public void Verify_UpdateSeriesAlias_Should_ReturnAnSeriesAliasModel()
        {
            var service = AppHost.Container.Resolve<ISeriesAliasesServices>();
            var response = service.Any(new UpdateSeriesAlias { Id = 1 });
            Assert.Equal(nameof(ISeriesAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "SeriesAliases")]
        public void Verify_DeactivateSeriesAlias_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ISeriesAliasesServices>();
            var response = service.Any(new DeactivateSeriesAlias { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "SeriesAliases")]
        public void Verify_DeactivateSeriesAliasByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ISeriesAliasesServices>();
            var response = service.Any(new DeactivateSeriesAliasByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "SeriesAliases")]
        public void Verify_RemoveSeriesAlias_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ISeriesAliasesServices>();
            var response = service.Any(new RemoveSeriesAlias { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "SeriesAliases")]
        public void Verify_RemoveSeriesAliasByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ISeriesAliasesServices>();
            var response = service.Any(new RemoveSeriesAliasByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}