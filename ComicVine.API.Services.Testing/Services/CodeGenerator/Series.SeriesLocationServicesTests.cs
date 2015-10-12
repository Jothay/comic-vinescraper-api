// <auto-generated>
// <copyright file="Series.ISeriesLocationServices.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the SeriesLocationsRepository Class.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in ComicVine.API.Services.Testing\Services\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Services//.Series
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class SeriesLocationsMockingSetup
    {
        public static Mock<ISeriesLocationsBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockSeriesLocationsBusinessWorkflow = new Mock<ISeriesLocationsBusinessWorkflow>();
            // Mock Functions
            mockSeriesLocationsBusinessWorkflow.Setup(m => m.Search(It.IsAny<ISeriesLocationSearchModel>(), It.IsAny<bool>())).Returns(() => new List<ISeriesLocationModel>());
            mockSeriesLocationsBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ISeriesLocationModel>().Object);
            mockSeriesLocationsBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ISeriesLocationModel>().Object);
            mockSeriesLocationsBusinessWorkflow.Setup(m => m.Create(It.IsAny<ISeriesLocationModel>())).Returns(() => new Mock<ISeriesLocationModel>().Object);
            mockSeriesLocationsBusinessWorkflow.Setup(m => m.Update(It.IsAny<ISeriesLocationModel>())).Returns(() => new Mock<ISeriesLocationModel>().Object);
            mockSeriesLocationsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockSeriesLocationsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockSeriesLocationsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockSeriesLocationsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockSeriesLocationsBusinessWorkflow;
        }
    }

    //public class SeriesLocationsServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_GetSeriesLocations_Should_ReturnAListOfSeriesLocationModels()
        {
            var service = AppHost.Container.Resolve<ISeriesLocationsServices>();
            var response = service.Any(new GetSeriesLocations { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<ISeriesLocationModel>>(response);
        }
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_GetSeriesLocationsAsListing_Should_ReturnAListOfSeriesLocationModels()
        {
            var service = AppHost.Container.Resolve<ISeriesLocationsServices>();
            var response = service.Any(new GetSeriesLocationsAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<ISeriesLocationModel>>(response);
        }
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_GetSeriesLocation_Should_ReturnAnSeriesLocationModel()
        {
            var service = AppHost.Container.Resolve<ISeriesLocationsServices>();
            var response = service.Any(new GetSeriesLocation { ID = 1 });
            Assert.Equal(nameof(ISeriesLocationModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_GetSeriesLocationByKey_Should_ReturnAnSeriesLocationModel()
        {
            var service = AppHost.Container.Resolve<ISeriesLocationsServices>();
            var response = service.Any(new GetSeriesLocationByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(ISeriesLocationModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_CreateSeriesLocation_Should_ReturnAnSeriesLocationModel()
        {
            var service = AppHost.Container.Resolve<ISeriesLocationsServices>();
            var response = service.Any(new CreateSeriesLocation { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(ISeriesLocationModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_UpdateSeriesLocation_Should_ReturnAnSeriesLocationModel()
        {
            var service = AppHost.Container.Resolve<ISeriesLocationsServices>();
            var response = service.Any(new UpdateSeriesLocation { Id = 1 });
            Assert.Equal(nameof(ISeriesLocationModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_DeactivateSeriesLocation_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ISeriesLocationsServices>();
            var response = service.Any(new DeactivateSeriesLocation { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_DeactivateSeriesLocationByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ISeriesLocationsServices>();
            var response = service.Any(new DeactivateSeriesLocationByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_RemoveSeriesLocation_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ISeriesLocationsServices>();
            var response = service.Any(new RemoveSeriesLocation { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_RemoveSeriesLocationByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ISeriesLocationsServices>();
            var response = service.Any(new RemoveSeriesLocationByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
