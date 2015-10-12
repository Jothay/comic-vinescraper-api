// <auto-generated>
// <copyright file="Objects.IObjectMovieServices.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectMoviesRepository Class.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in ComicVine.API.Services.Testing\Services\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Services//.Objects
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class ObjectMoviesMockingSetup
    {
        public static Mock<IObjectMoviesBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockObjectMoviesBusinessWorkflow = new Mock<IObjectMoviesBusinessWorkflow>();
            // Mock Functions
            mockObjectMoviesBusinessWorkflow.Setup(m => m.Search(It.IsAny<IObjectMovieSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IObjectMovieModel>());
            mockObjectMoviesBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IObjectMovieModel>().Object);
            mockObjectMoviesBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IObjectMovieModel>().Object);
            mockObjectMoviesBusinessWorkflow.Setup(m => m.Create(It.IsAny<IObjectMovieModel>())).Returns(() => new Mock<IObjectMovieModel>().Object);
            mockObjectMoviesBusinessWorkflow.Setup(m => m.Update(It.IsAny<IObjectMovieModel>())).Returns(() => new Mock<IObjectMovieModel>().Object);
            mockObjectMoviesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockObjectMoviesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockObjectMoviesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockObjectMoviesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockObjectMoviesBusinessWorkflow;
        }
    }

    //public class ObjectMoviesServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_GetObjectMovies_Should_ReturnAListOfObjectMovieModels()
        {
            var service = AppHost.Container.Resolve<IObjectMoviesServices>();
            var response = service.Any(new GetObjectMovies { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IObjectMovieModel>>(response);
        }
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_GetObjectMoviesAsListing_Should_ReturnAListOfObjectMovieModels()
        {
            var service = AppHost.Container.Resolve<IObjectMoviesServices>();
            var response = service.Any(new GetObjectMoviesAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IObjectMovieModel>>(response);
        }
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_GetObjectMovie_Should_ReturnAnObjectMovieModel()
        {
            var service = AppHost.Container.Resolve<IObjectMoviesServices>();
            var response = service.Any(new GetObjectMovie { ID = 1 });
            Assert.Equal(nameof(IObjectMovieModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_GetObjectMovieByKey_Should_ReturnAnObjectMovieModel()
        {
            var service = AppHost.Container.Resolve<IObjectMoviesServices>();
            var response = service.Any(new GetObjectMovieByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IObjectMovieModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_CreateObjectMovie_Should_ReturnAnObjectMovieModel()
        {
            var service = AppHost.Container.Resolve<IObjectMoviesServices>();
            var response = service.Any(new CreateObjectMovie { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IObjectMovieModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_UpdateObjectMovie_Should_ReturnAnObjectMovieModel()
        {
            var service = AppHost.Container.Resolve<IObjectMoviesServices>();
            var response = service.Any(new UpdateObjectMovie { Id = 1 });
            Assert.Equal(nameof(IObjectMovieModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_DeactivateObjectMovie_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IObjectMoviesServices>();
            var response = service.Any(new DeactivateObjectMovie { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_DeactivateObjectMovieByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IObjectMoviesServices>();
            var response = service.Any(new DeactivateObjectMovieByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_RemoveObjectMovie_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IObjectMoviesServices>();
            var response = service.Any(new RemoveObjectMovie { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_RemoveObjectMovieByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IObjectMoviesServices>();
            var response = service.Any(new RemoveObjectMovieByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
