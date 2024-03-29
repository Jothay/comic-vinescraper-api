// <auto-generated>
// <copyright file="Volumes.IVolumeLocationServicesTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the VolumeLocations ServiceStack Services Tests.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in
// ComicVineScraper.API.Services.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Services//.Volumes
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class VolumeLocationsMockingSetup
    {
        public static Mock<IVolumeLocationsBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockVolumeLocationsBusinessWorkflow = new Mock<IVolumeLocationsBusinessWorkflow>();
            // Mock Functions
            mockVolumeLocationsBusinessWorkflow.Setup(m => m.Search(It.IsAny<IVolumeLocationSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IVolumeLocationModel>());
            mockVolumeLocationsBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IVolumeLocationModel>().Object);
            mockVolumeLocationsBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IVolumeLocationModel>().Object);
            mockVolumeLocationsBusinessWorkflow.Setup(m => m.Create(It.IsAny<IVolumeLocationModel>())).Returns(() => new Mock<IVolumeLocationModel>().Object);
            mockVolumeLocationsBusinessWorkflow.Setup(m => m.Update(It.IsAny<IVolumeLocationModel>())).Returns(() => new Mock<IVolumeLocationModel>().Object);
            mockVolumeLocationsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockVolumeLocationsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockVolumeLocationsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockVolumeLocationsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockVolumeLocationsBusinessWorkflow;
        }
    }

    //public class VolumeLocationsServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "VolumeLocations")]
        public void Verify_GetVolumeLocations_Should_ReturnAListOfVolumeLocationModels()
        {
            var service = AppHost.Container.Resolve<IVolumeLocationsServices>();
            var response = service.Any(new GetVolumeLocations { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IVolumeLocationModel>>(response);
        }
        [Fact][Trait("Category", "VolumeLocations")]
        public void Verify_GetVolumeLocationsAsListing_Should_ReturnAListOfVolumeLocationModels()
        {
            var service = AppHost.Container.Resolve<IVolumeLocationsServices>();
            var response = service.Any(new GetVolumeLocationsAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IVolumeLocationModel>>(response);
        }
        [Fact][Trait("Category", "VolumeLocations")]
        public void Verify_GetVolumeLocation_Should_ReturnAnVolumeLocationModel()
        {
            var service = AppHost.Container.Resolve<IVolumeLocationsServices>();
            var response = service.Any(new GetVolumeLocation { ID = 1 });
            Assert.Equal(nameof(IVolumeLocationModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "VolumeLocations")]
        public void Verify_GetVolumeLocationByKey_Should_ReturnAnVolumeLocationModel()
        {
            var service = AppHost.Container.Resolve<IVolumeLocationsServices>();
            var response = service.Any(new GetVolumeLocationByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IVolumeLocationModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "VolumeLocations")]
        public void Verify_CreateVolumeLocation_Should_ReturnAnVolumeLocationModel()
        {
            var service = AppHost.Container.Resolve<IVolumeLocationsServices>();
            var response = service.Any(new CreateVolumeLocation { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IVolumeLocationModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "VolumeLocations")]
        public void Verify_UpdateVolumeLocation_Should_ReturnAnVolumeLocationModel()
        {
            var service = AppHost.Container.Resolve<IVolumeLocationsServices>();
            var response = service.Any(new UpdateVolumeLocation { Id = 1 });
            Assert.Equal(nameof(IVolumeLocationModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "VolumeLocations")]
        public void Verify_DeactivateVolumeLocation_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IVolumeLocationsServices>();
            var response = service.Any(new DeactivateVolumeLocation { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "VolumeLocations")]
        public void Verify_DeactivateVolumeLocationByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IVolumeLocationsServices>();
            var response = service.Any(new DeactivateVolumeLocationByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "VolumeLocations")]
        public void Verify_RemoveVolumeLocation_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IVolumeLocationsServices>();
            var response = service.Any(new RemoveVolumeLocation { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "VolumeLocations")]
        public void Verify_RemoveVolumeLocationByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IVolumeLocationsServices>();
            var response = service.Any(new RemoveVolumeLocationByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
