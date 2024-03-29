// <auto-generated>
// <copyright file="Locations.ILocationVolumeServicesTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the LocationVolumes ServiceStack Services Tests.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in
// ComicVineScraper.API.Services.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Services//.Locations
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class LocationVolumesMockingSetup
    {
        public static Mock<ILocationVolumesBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockLocationVolumesBusinessWorkflow = new Mock<ILocationVolumesBusinessWorkflow>();
            // Mock Functions
            mockLocationVolumesBusinessWorkflow.Setup(m => m.Search(It.IsAny<ILocationVolumeSearchModel>(), It.IsAny<bool>())).Returns(() => new List<ILocationVolumeModel>());
            mockLocationVolumesBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ILocationVolumeModel>().Object);
            mockLocationVolumesBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ILocationVolumeModel>().Object);
            mockLocationVolumesBusinessWorkflow.Setup(m => m.Create(It.IsAny<ILocationVolumeModel>())).Returns(() => new Mock<ILocationVolumeModel>().Object);
            mockLocationVolumesBusinessWorkflow.Setup(m => m.Update(It.IsAny<ILocationVolumeModel>())).Returns(() => new Mock<ILocationVolumeModel>().Object);
            mockLocationVolumesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockLocationVolumesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockLocationVolumesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockLocationVolumesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockLocationVolumesBusinessWorkflow;
        }
    }

    //public class LocationVolumesServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "LocationVolumes")]
        public void Verify_GetLocationVolumes_Should_ReturnAListOfLocationVolumeModels()
        {
            var service = AppHost.Container.Resolve<ILocationVolumesServices>();
            var response = service.Any(new GetLocationVolumes { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<ILocationVolumeModel>>(response);
        }
        [Fact][Trait("Category", "LocationVolumes")]
        public void Verify_GetLocationVolumesAsListing_Should_ReturnAListOfLocationVolumeModels()
        {
            var service = AppHost.Container.Resolve<ILocationVolumesServices>();
            var response = service.Any(new GetLocationVolumesAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<ILocationVolumeModel>>(response);
        }
        [Fact][Trait("Category", "LocationVolumes")]
        public void Verify_GetLocationVolume_Should_ReturnAnLocationVolumeModel()
        {
            var service = AppHost.Container.Resolve<ILocationVolumesServices>();
            var response = service.Any(new GetLocationVolume { ID = 1 });
            Assert.Equal(nameof(ILocationVolumeModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "LocationVolumes")]
        public void Verify_GetLocationVolumeByKey_Should_ReturnAnLocationVolumeModel()
        {
            var service = AppHost.Container.Resolve<ILocationVolumesServices>();
            var response = service.Any(new GetLocationVolumeByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(ILocationVolumeModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "LocationVolumes")]
        public void Verify_CreateLocationVolume_Should_ReturnAnLocationVolumeModel()
        {
            var service = AppHost.Container.Resolve<ILocationVolumesServices>();
            var response = service.Any(new CreateLocationVolume { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(ILocationVolumeModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "LocationVolumes")]
        public void Verify_UpdateLocationVolume_Should_ReturnAnLocationVolumeModel()
        {
            var service = AppHost.Container.Resolve<ILocationVolumesServices>();
            var response = service.Any(new UpdateLocationVolume { Id = 1 });
            Assert.Equal(nameof(ILocationVolumeModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "LocationVolumes")]
        public void Verify_DeactivateLocationVolume_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ILocationVolumesServices>();
            var response = service.Any(new DeactivateLocationVolume { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "LocationVolumes")]
        public void Verify_DeactivateLocationVolumeByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ILocationVolumesServices>();
            var response = service.Any(new DeactivateLocationVolumeByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "LocationVolumes")]
        public void Verify_RemoveLocationVolume_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ILocationVolumesServices>();
            var response = service.Any(new RemoveLocationVolume { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "LocationVolumes")]
        public void Verify_RemoveLocationVolumeByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ILocationVolumesServices>();
            var response = service.Any(new RemoveLocationVolumeByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
