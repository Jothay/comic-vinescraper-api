// <auto-generated>
// <copyright file="Concepts.IConceptMovieServicesTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the ConceptMovies ServiceStack Services Tests.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in
// ComicVineScraper.API.Services.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Services//.Concepts
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class ConceptMoviesMockingSetup
    {
        public static Mock<IConceptMoviesBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockConceptMoviesBusinessWorkflow = new Mock<IConceptMoviesBusinessWorkflow>();
            // Mock Functions
            mockConceptMoviesBusinessWorkflow.Setup(m => m.Search(It.IsAny<IConceptMovieSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IConceptMovieModel>());
            mockConceptMoviesBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IConceptMovieModel>().Object);
            mockConceptMoviesBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IConceptMovieModel>().Object);
            mockConceptMoviesBusinessWorkflow.Setup(m => m.Create(It.IsAny<IConceptMovieModel>())).Returns(() => new Mock<IConceptMovieModel>().Object);
            mockConceptMoviesBusinessWorkflow.Setup(m => m.Update(It.IsAny<IConceptMovieModel>())).Returns(() => new Mock<IConceptMovieModel>().Object);
            mockConceptMoviesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockConceptMoviesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockConceptMoviesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockConceptMoviesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockConceptMoviesBusinessWorkflow;
        }
    }

    //public class ConceptMoviesServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_GetConceptMovies_Should_ReturnAListOfConceptMovieModels()
        {
            var service = AppHost.Container.Resolve<IConceptMoviesServices>();
            var response = service.Any(new GetConceptMovies { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IConceptMovieModel>>(response);
        }
        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_GetConceptMoviesAsListing_Should_ReturnAListOfConceptMovieModels()
        {
            var service = AppHost.Container.Resolve<IConceptMoviesServices>();
            var response = service.Any(new GetConceptMoviesAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IConceptMovieModel>>(response);
        }
        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_GetConceptMovie_Should_ReturnAnConceptMovieModel()
        {
            var service = AppHost.Container.Resolve<IConceptMoviesServices>();
            var response = service.Any(new GetConceptMovie { ID = 1 });
            Assert.Equal(nameof(IConceptMovieModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_GetConceptMovieByKey_Should_ReturnAnConceptMovieModel()
        {
            var service = AppHost.Container.Resolve<IConceptMoviesServices>();
            var response = service.Any(new GetConceptMovieByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IConceptMovieModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_CreateConceptMovie_Should_ReturnAnConceptMovieModel()
        {
            var service = AppHost.Container.Resolve<IConceptMoviesServices>();
            var response = service.Any(new CreateConceptMovie { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IConceptMovieModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_UpdateConceptMovie_Should_ReturnAnConceptMovieModel()
        {
            var service = AppHost.Container.Resolve<IConceptMoviesServices>();
            var response = service.Any(new UpdateConceptMovie { Id = 1 });
            Assert.Equal(nameof(IConceptMovieModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_DeactivateConceptMovie_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IConceptMoviesServices>();
            var response = service.Any(new DeactivateConceptMovie { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_DeactivateConceptMovieByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IConceptMoviesServices>();
            var response = service.Any(new DeactivateConceptMovieByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_RemoveConceptMovie_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IConceptMoviesServices>();
            var response = service.Any(new RemoveConceptMovie { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_RemoveConceptMovieByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IConceptMoviesServices>();
            var response = service.Any(new RemoveConceptMovieByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
