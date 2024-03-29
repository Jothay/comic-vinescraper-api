// <auto-generated>
// <copyright file="Movies.IMovieLocationServicesTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the MovieLocations ServiceStack Services Tests.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in
// ComicVineScraper.API.Services.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Services//.Movies
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class MovieLocationsMockingSetup
    {
        public static Mock<IMovieLocationsBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockMovieLocationsBusinessWorkflow = new Mock<IMovieLocationsBusinessWorkflow>();
            // Mock Functions
            mockMovieLocationsBusinessWorkflow.Setup(m => m.Search(It.IsAny<IMovieLocationSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IMovieLocationModel>());
            mockMovieLocationsBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IMovieLocationModel>().Object);
            mockMovieLocationsBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IMovieLocationModel>().Object);
            mockMovieLocationsBusinessWorkflow.Setup(m => m.Create(It.IsAny<IMovieLocationModel>())).Returns(() => new Mock<IMovieLocationModel>().Object);
            mockMovieLocationsBusinessWorkflow.Setup(m => m.Update(It.IsAny<IMovieLocationModel>())).Returns(() => new Mock<IMovieLocationModel>().Object);
            mockMovieLocationsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockMovieLocationsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockMovieLocationsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockMovieLocationsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockMovieLocationsBusinessWorkflow;
        }
    }

    //public class MovieLocationsServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "MovieLocations")]
        public void Verify_GetMovieLocations_Should_ReturnAListOfMovieLocationModels()
        {
            var service = AppHost.Container.Resolve<IMovieLocationsServices>();
            var response = service.Any(new GetMovieLocations { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IMovieLocationModel>>(response);
        }
        [Fact][Trait("Category", "MovieLocations")]
        public void Verify_GetMovieLocationsAsListing_Should_ReturnAListOfMovieLocationModels()
        {
            var service = AppHost.Container.Resolve<IMovieLocationsServices>();
            var response = service.Any(new GetMovieLocationsAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IMovieLocationModel>>(response);
        }
        [Fact][Trait("Category", "MovieLocations")]
        public void Verify_GetMovieLocation_Should_ReturnAnMovieLocationModel()
        {
            var service = AppHost.Container.Resolve<IMovieLocationsServices>();
            var response = service.Any(new GetMovieLocation { ID = 1 });
            Assert.Equal(nameof(IMovieLocationModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "MovieLocations")]
        public void Verify_GetMovieLocationByKey_Should_ReturnAnMovieLocationModel()
        {
            var service = AppHost.Container.Resolve<IMovieLocationsServices>();
            var response = service.Any(new GetMovieLocationByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IMovieLocationModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "MovieLocations")]
        public void Verify_CreateMovieLocation_Should_ReturnAnMovieLocationModel()
        {
            var service = AppHost.Container.Resolve<IMovieLocationsServices>();
            var response = service.Any(new CreateMovieLocation { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IMovieLocationModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "MovieLocations")]
        public void Verify_UpdateMovieLocation_Should_ReturnAnMovieLocationModel()
        {
            var service = AppHost.Container.Resolve<IMovieLocationsServices>();
            var response = service.Any(new UpdateMovieLocation { Id = 1 });
            Assert.Equal(nameof(IMovieLocationModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "MovieLocations")]
        public void Verify_DeactivateMovieLocation_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IMovieLocationsServices>();
            var response = service.Any(new DeactivateMovieLocation { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "MovieLocations")]
        public void Verify_DeactivateMovieLocationByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IMovieLocationsServices>();
            var response = service.Any(new DeactivateMovieLocationByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "MovieLocations")]
        public void Verify_RemoveMovieLocation_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IMovieLocationsServices>();
            var response = service.Any(new RemoveMovieLocation { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "MovieLocations")]
        public void Verify_RemoveMovieLocationByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IMovieLocationsServices>();
            var response = service.Any(new RemoveMovieLocationByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
