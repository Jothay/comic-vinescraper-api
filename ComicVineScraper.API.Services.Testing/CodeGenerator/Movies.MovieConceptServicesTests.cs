// <auto-generated>
// <copyright file="Movies.IMovieConceptServicesTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the MovieConcepts ServiceStack Services Tests.</summary>
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

    public static class MovieConceptsMockingSetup
    {
        public static Mock<IMovieConceptsBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockMovieConceptsBusinessWorkflow = new Mock<IMovieConceptsBusinessWorkflow>();
            // Mock Functions
            mockMovieConceptsBusinessWorkflow.Setup(m => m.Search(It.IsAny<IMovieConceptSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IMovieConceptModel>());
            mockMovieConceptsBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IMovieConceptModel>().Object);
            mockMovieConceptsBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IMovieConceptModel>().Object);
            mockMovieConceptsBusinessWorkflow.Setup(m => m.Create(It.IsAny<IMovieConceptModel>())).Returns(() => new Mock<IMovieConceptModel>().Object);
            mockMovieConceptsBusinessWorkflow.Setup(m => m.Update(It.IsAny<IMovieConceptModel>())).Returns(() => new Mock<IMovieConceptModel>().Object);
            mockMovieConceptsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockMovieConceptsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockMovieConceptsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockMovieConceptsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockMovieConceptsBusinessWorkflow;
        }
    }

    //public class MovieConceptsServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_GetMovieConcepts_Should_ReturnAListOfMovieConceptModels()
        {
            var service = AppHost.Container.Resolve<IMovieConceptsServices>();
            var response = service.Any(new GetMovieConcepts { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IMovieConceptModel>>(response);
        }
        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_GetMovieConceptsAsListing_Should_ReturnAListOfMovieConceptModels()
        {
            var service = AppHost.Container.Resolve<IMovieConceptsServices>();
            var response = service.Any(new GetMovieConceptsAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IMovieConceptModel>>(response);
        }
        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_GetMovieConcept_Should_ReturnAnMovieConceptModel()
        {
            var service = AppHost.Container.Resolve<IMovieConceptsServices>();
            var response = service.Any(new GetMovieConcept { ID = 1 });
            Assert.Equal(nameof(IMovieConceptModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_GetMovieConceptByKey_Should_ReturnAnMovieConceptModel()
        {
            var service = AppHost.Container.Resolve<IMovieConceptsServices>();
            var response = service.Any(new GetMovieConceptByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IMovieConceptModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_CreateMovieConcept_Should_ReturnAnMovieConceptModel()
        {
            var service = AppHost.Container.Resolve<IMovieConceptsServices>();
            var response = service.Any(new CreateMovieConcept { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IMovieConceptModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_UpdateMovieConcept_Should_ReturnAnMovieConceptModel()
        {
            var service = AppHost.Container.Resolve<IMovieConceptsServices>();
            var response = service.Any(new UpdateMovieConcept { Id = 1 });
            Assert.Equal(nameof(IMovieConceptModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_DeactivateMovieConcept_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IMovieConceptsServices>();
            var response = service.Any(new DeactivateMovieConcept { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_DeactivateMovieConceptByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IMovieConceptsServices>();
            var response = service.Any(new DeactivateMovieConceptByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_RemoveMovieConcept_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IMovieConceptsServices>();
            var response = service.Any(new RemoveMovieConcept { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_RemoveMovieConceptByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IMovieConceptsServices>();
            var response = service.Any(new RemoveMovieConceptByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
