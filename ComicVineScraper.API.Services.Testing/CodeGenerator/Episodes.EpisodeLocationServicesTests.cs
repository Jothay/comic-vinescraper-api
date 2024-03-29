// <auto-generated>
// <copyright file="Episodes.IEpisodeLocationServicesTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the EpisodeLocations ServiceStack Services Tests.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in
// ComicVineScraper.API.Services.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Services//.Episodes
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class EpisodeLocationsMockingSetup
    {
        public static Mock<IEpisodeLocationsBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockEpisodeLocationsBusinessWorkflow = new Mock<IEpisodeLocationsBusinessWorkflow>();
            // Mock Functions
            mockEpisodeLocationsBusinessWorkflow.Setup(m => m.Search(It.IsAny<IEpisodeLocationSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IEpisodeLocationModel>());
            mockEpisodeLocationsBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IEpisodeLocationModel>().Object);
            mockEpisodeLocationsBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IEpisodeLocationModel>().Object);
            mockEpisodeLocationsBusinessWorkflow.Setup(m => m.Create(It.IsAny<IEpisodeLocationModel>())).Returns(() => new Mock<IEpisodeLocationModel>().Object);
            mockEpisodeLocationsBusinessWorkflow.Setup(m => m.Update(It.IsAny<IEpisodeLocationModel>())).Returns(() => new Mock<IEpisodeLocationModel>().Object);
            mockEpisodeLocationsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockEpisodeLocationsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockEpisodeLocationsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockEpisodeLocationsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockEpisodeLocationsBusinessWorkflow;
        }
    }

    //public class EpisodeLocationsServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_GetEpisodeLocations_Should_ReturnAListOfEpisodeLocationModels()
        {
            var service = AppHost.Container.Resolve<IEpisodeLocationsServices>();
            var response = service.Any(new GetEpisodeLocations { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IEpisodeLocationModel>>(response);
        }
        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_GetEpisodeLocationsAsListing_Should_ReturnAListOfEpisodeLocationModels()
        {
            var service = AppHost.Container.Resolve<IEpisodeLocationsServices>();
            var response = service.Any(new GetEpisodeLocationsAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IEpisodeLocationModel>>(response);
        }
        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_GetEpisodeLocation_Should_ReturnAnEpisodeLocationModel()
        {
            var service = AppHost.Container.Resolve<IEpisodeLocationsServices>();
            var response = service.Any(new GetEpisodeLocation { ID = 1 });
            Assert.Equal(nameof(IEpisodeLocationModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_GetEpisodeLocationByKey_Should_ReturnAnEpisodeLocationModel()
        {
            var service = AppHost.Container.Resolve<IEpisodeLocationsServices>();
            var response = service.Any(new GetEpisodeLocationByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IEpisodeLocationModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_CreateEpisodeLocation_Should_ReturnAnEpisodeLocationModel()
        {
            var service = AppHost.Container.Resolve<IEpisodeLocationsServices>();
            var response = service.Any(new CreateEpisodeLocation { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IEpisodeLocationModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_UpdateEpisodeLocation_Should_ReturnAnEpisodeLocationModel()
        {
            var service = AppHost.Container.Resolve<IEpisodeLocationsServices>();
            var response = service.Any(new UpdateEpisodeLocation { Id = 1 });
            Assert.Equal(nameof(IEpisodeLocationModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_DeactivateEpisodeLocation_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IEpisodeLocationsServices>();
            var response = service.Any(new DeactivateEpisodeLocation { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_DeactivateEpisodeLocationByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IEpisodeLocationsServices>();
            var response = service.Any(new DeactivateEpisodeLocationByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_RemoveEpisodeLocation_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IEpisodeLocationsServices>();
            var response = service.Any(new RemoveEpisodeLocation { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_RemoveEpisodeLocationByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IEpisodeLocationsServices>();
            var response = service.Any(new RemoveEpisodeLocationByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
