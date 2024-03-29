// <auto-generated>
// <copyright file="Publishers.IPublisherServicesTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the Publishers ServiceStack Services Tests.</summary>
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

    public static class PublishersMockingSetup
    {
        public static Mock<IPublishersBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockPublishersBusinessWorkflow = new Mock<IPublishersBusinessWorkflow>();
            // Mock Functions
            mockPublishersBusinessWorkflow.Setup(m => m.Search(It.IsAny<IPublisherSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IPublisherModel>());
            mockPublishersBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IPublisherModel>().Object);
            mockPublishersBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IPublisherModel>().Object);
            mockPublishersBusinessWorkflow.Setup(m => m.Create(It.IsAny<IPublisherModel>())).Returns(() => new Mock<IPublisherModel>().Object);
            mockPublishersBusinessWorkflow.Setup(m => m.Update(It.IsAny<IPublisherModel>())).Returns(() => new Mock<IPublisherModel>().Object);
            mockPublishersBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockPublishersBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockPublishersBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockPublishersBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockPublishersBusinessWorkflow;
        }
    }

    //public class PublishersServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "Publishers")]
        public void Verify_GetPublishers_Should_ReturnAListOfPublisherModels()
        {
            var service = AppHost.Container.Resolve<IPublishersServices>();
            var response = service.Any(new GetPublishers { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IPublisherModel>>(response);
        }
        [Fact][Trait("Category", "Publishers")]
        public void Verify_GetPublishersAsListing_Should_ReturnAListOfPublisherModels()
        {
            var service = AppHost.Container.Resolve<IPublishersServices>();
            var response = service.Any(new GetPublishersAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IPublisherModel>>(response);
        }
        [Fact][Trait("Category", "Publishers")]
        public void Verify_GetPublisher_Should_ReturnAnPublisherModel()
        {
            var service = AppHost.Container.Resolve<IPublishersServices>();
            var response = service.Any(new GetPublisher { ID = 1 });
            Assert.Equal(nameof(IPublisherModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Publishers")]
        public void Verify_GetPublisherByKey_Should_ReturnAnPublisherModel()
        {
            var service = AppHost.Container.Resolve<IPublishersServices>();
            var response = service.Any(new GetPublisherByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IPublisherModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Publishers")]
        public void Verify_CreatePublisher_Should_ReturnAnPublisherModel()
        {
            var service = AppHost.Container.Resolve<IPublishersServices>();
            var response = service.Any(new CreatePublisher { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IPublisherModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Publishers")]
        public void Verify_UpdatePublisher_Should_ReturnAnPublisherModel()
        {
            var service = AppHost.Container.Resolve<IPublishersServices>();
            var response = service.Any(new UpdatePublisher { Id = 1 });
            Assert.Equal(nameof(IPublisherModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Publishers")]
        public void Verify_DeactivatePublisher_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IPublishersServices>();
            var response = service.Any(new DeactivatePublisher { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Publishers")]
        public void Verify_DeactivatePublisherByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IPublishersServices>();
            var response = service.Any(new DeactivatePublisherByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Publishers")]
        public void Verify_RemovePublisher_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IPublishersServices>();
            var response = service.Any(new RemovePublisher { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Publishers")]
        public void Verify_RemovePublisherByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IPublishersServices>();
            var response = service.Any(new RemovePublisherByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
