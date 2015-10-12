// <auto-generated>
// <copyright file="Locations.ILocationAliasServices.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the LocationAliasesRepository Class.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in ComicVine.API.Services.Testing\Services\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Services//.Locations
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class LocationAliasesMockingSetup
    {
        public static Mock<ILocationAliasesBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockLocationAliasesBusinessWorkflow = new Mock<ILocationAliasesBusinessWorkflow>();
            // Mock Functions
            mockLocationAliasesBusinessWorkflow.Setup(m => m.Search(It.IsAny<ILocationAliasSearchModel>(), It.IsAny<bool>())).Returns(() => new List<ILocationAliasModel>());
            mockLocationAliasesBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ILocationAliasModel>().Object);
            mockLocationAliasesBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ILocationAliasModel>().Object);
            mockLocationAliasesBusinessWorkflow.Setup(m => m.Create(It.IsAny<ILocationAliasModel>())).Returns(() => new Mock<ILocationAliasModel>().Object);
            mockLocationAliasesBusinessWorkflow.Setup(m => m.Update(It.IsAny<ILocationAliasModel>())).Returns(() => new Mock<ILocationAliasModel>().Object);
            mockLocationAliasesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockLocationAliasesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockLocationAliasesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockLocationAliasesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockLocationAliasesBusinessWorkflow;
        }
    }

    //public class LocationAliasesServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "LocationAliases")]
        public void Verify_GetLocationAliases_Should_ReturnAListOfLocationAliasModels()
        {
            var service = AppHost.Container.Resolve<ILocationAliasesServices>();
            var response = service.Any(new GetLocationAliases { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = null, ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<ILocationAliasModel>>(response);
        }
        [Fact][Trait("Category", "LocationAliases")]
        public void Verify_GetLocationAliasesAsListing_Should_ReturnAListOfLocationAliasModels()
        {
            var service = AppHost.Container.Resolve<ILocationAliasesServices>();
            var response = service.Any(new GetLocationAliasesAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = "famous", ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<ILocationAliasModel>>(response);
        }
        [Fact][Trait("Category", "LocationAliases")]
        public void Verify_GetLocationAlias_Should_ReturnAnLocationAliasModel()
        {
            var service = AppHost.Container.Resolve<ILocationAliasesServices>();
            var response = service.Any(new GetLocationAlias { ID = 1 });
            Assert.Equal(nameof(ILocationAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "LocationAliases")]
        public void Verify_GetLocationAliasByKey_Should_ReturnAnLocationAliasModel()
        {
            var service = AppHost.Container.Resolve<ILocationAliasesServices>();
            var response = service.Any(new GetLocationAliasByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(ILocationAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "LocationAliases")]
        public void Verify_CreateLocationAlias_Should_ReturnAnLocationAliasModel()
        {
            var service = AppHost.Container.Resolve<ILocationAliasesServices>();
            var response = service.Any(new CreateLocationAlias { Name = "Stephen King", CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(ILocationAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "LocationAliases")]
        public void Verify_UpdateLocationAlias_Should_ReturnAnLocationAliasModel()
        {
            var service = AppHost.Container.Resolve<ILocationAliasesServices>();
            var response = service.Any(new UpdateLocationAlias { Id = 1 });
            Assert.Equal(nameof(ILocationAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "LocationAliases")]
        public void Verify_DeactivateLocationAlias_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ILocationAliasesServices>();
            var response = service.Any(new DeactivateLocationAlias { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "LocationAliases")]
        public void Verify_DeactivateLocationAliasByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ILocationAliasesServices>();
            var response = service.Any(new DeactivateLocationAliasByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "LocationAliases")]
        public void Verify_RemoveLocationAlias_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ILocationAliasesServices>();
            var response = service.Any(new RemoveLocationAlias { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "LocationAliases")]
        public void Verify_RemoveLocationAliasByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ILocationAliasesServices>();
            var response = service.Any(new RemoveLocationAliasByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
