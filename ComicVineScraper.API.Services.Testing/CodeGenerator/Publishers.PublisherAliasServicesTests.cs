// <auto-generated>
// <copyright file="Publishers.IPublisherAliasServicesTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the PublisherAliases ServiceStack Services Tests.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in
// ComicVineScraper.API.Services.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Services//.Publishers
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class PublisherAliasesMockingSetup
    {
        public static Mock<IPublisherAliasesBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockPublisherAliasesBusinessWorkflow = new Mock<IPublisherAliasesBusinessWorkflow>();
            // Mock Functions
            mockPublisherAliasesBusinessWorkflow.Setup(m => m.Search(It.IsAny<IPublisherAliasSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IPublisherAliasModel>());
            mockPublisherAliasesBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IPublisherAliasModel>().Object);
            mockPublisherAliasesBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IPublisherAliasModel>().Object);
            mockPublisherAliasesBusinessWorkflow.Setup(m => m.Create(It.IsAny<IPublisherAliasModel>())).Returns(() => new Mock<IPublisherAliasModel>().Object);
            mockPublisherAliasesBusinessWorkflow.Setup(m => m.Update(It.IsAny<IPublisherAliasModel>())).Returns(() => new Mock<IPublisherAliasModel>().Object);
            mockPublisherAliasesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockPublisherAliasesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockPublisherAliasesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockPublisherAliasesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockPublisherAliasesBusinessWorkflow;
        }
    }

    //public class PublisherAliasesServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "PublisherAliases")]
        public void Verify_GetPublisherAliases_Should_ReturnAListOfPublisherAliasModels()
        {
            var service = AppHost.Container.Resolve<IPublisherAliasesServices>();
            var response = service.Any(new GetPublisherAliases { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IPublisherAliasModel>>(response);
        }
        [Fact][Trait("Category", "PublisherAliases")]
        public void Verify_GetPublisherAliasesAsListing_Should_ReturnAListOfPublisherAliasModels()
        {
            var service = AppHost.Container.Resolve<IPublisherAliasesServices>();
            var response = service.Any(new GetPublisherAliasesAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IPublisherAliasModel>>(response);
        }
        [Fact][Trait("Category", "PublisherAliases")]
        public void Verify_GetPublisherAlias_Should_ReturnAnPublisherAliasModel()
        {
            var service = AppHost.Container.Resolve<IPublisherAliasesServices>();
            var response = service.Any(new GetPublisherAlias { ID = 1 });
            Assert.Equal(nameof(IPublisherAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "PublisherAliases")]
        public void Verify_GetPublisherAliasByKey_Should_ReturnAnPublisherAliasModel()
        {
            var service = AppHost.Container.Resolve<IPublisherAliasesServices>();
            var response = service.Any(new GetPublisherAliasByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IPublisherAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "PublisherAliases")]
        public void Verify_CreatePublisherAlias_Should_ReturnAnPublisherAliasModel()
        {
            var service = AppHost.Container.Resolve<IPublisherAliasesServices>();
            var response = service.Any(new CreatePublisherAlias { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IPublisherAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "PublisherAliases")]
        public void Verify_UpdatePublisherAlias_Should_ReturnAnPublisherAliasModel()
        {
            var service = AppHost.Container.Resolve<IPublisherAliasesServices>();
            var response = service.Any(new UpdatePublisherAlias { Id = 1 });
            Assert.Equal(nameof(IPublisherAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "PublisherAliases")]
        public void Verify_DeactivatePublisherAlias_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IPublisherAliasesServices>();
            var response = service.Any(new DeactivatePublisherAlias { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "PublisherAliases")]
        public void Verify_DeactivatePublisherAliasByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IPublisherAliasesServices>();
            var response = service.Any(new DeactivatePublisherAliasByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "PublisherAliases")]
        public void Verify_RemovePublisherAlias_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IPublisherAliasesServices>();
            var response = service.Any(new RemovePublisherAlias { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "PublisherAliases")]
        public void Verify_RemovePublisherAliasByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IPublisherAliasesServices>();
            var response = service.Any(new RemovePublisherAliasByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
