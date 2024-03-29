// <auto-generated>
// <copyright file="Movies.IMovieTeamServicesTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the MovieTeams ServiceStack Services Tests.</summary>
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

    public static class MovieTeamsMockingSetup
    {
        public static Mock<IMovieTeamsBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockMovieTeamsBusinessWorkflow = new Mock<IMovieTeamsBusinessWorkflow>();
            // Mock Functions
            mockMovieTeamsBusinessWorkflow.Setup(m => m.Search(It.IsAny<IMovieTeamSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IMovieTeamModel>());
            mockMovieTeamsBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IMovieTeamModel>().Object);
            mockMovieTeamsBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IMovieTeamModel>().Object);
            mockMovieTeamsBusinessWorkflow.Setup(m => m.Create(It.IsAny<IMovieTeamModel>())).Returns(() => new Mock<IMovieTeamModel>().Object);
            mockMovieTeamsBusinessWorkflow.Setup(m => m.Update(It.IsAny<IMovieTeamModel>())).Returns(() => new Mock<IMovieTeamModel>().Object);
            mockMovieTeamsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockMovieTeamsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockMovieTeamsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockMovieTeamsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockMovieTeamsBusinessWorkflow;
        }
    }

    //public class MovieTeamsServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "MovieTeams")]
        public void Verify_GetMovieTeams_Should_ReturnAListOfMovieTeamModels()
        {
            var service = AppHost.Container.Resolve<IMovieTeamsServices>();
            var response = service.Any(new GetMovieTeams { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IMovieTeamModel>>(response);
        }
        [Fact][Trait("Category", "MovieTeams")]
        public void Verify_GetMovieTeamsAsListing_Should_ReturnAListOfMovieTeamModels()
        {
            var service = AppHost.Container.Resolve<IMovieTeamsServices>();
            var response = service.Any(new GetMovieTeamsAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IMovieTeamModel>>(response);
        }
        [Fact][Trait("Category", "MovieTeams")]
        public void Verify_GetMovieTeam_Should_ReturnAnMovieTeamModel()
        {
            var service = AppHost.Container.Resolve<IMovieTeamsServices>();
            var response = service.Any(new GetMovieTeam { ID = 1 });
            Assert.Equal(nameof(IMovieTeamModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "MovieTeams")]
        public void Verify_GetMovieTeamByKey_Should_ReturnAnMovieTeamModel()
        {
            var service = AppHost.Container.Resolve<IMovieTeamsServices>();
            var response = service.Any(new GetMovieTeamByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IMovieTeamModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "MovieTeams")]
        public void Verify_CreateMovieTeam_Should_ReturnAnMovieTeamModel()
        {
            var service = AppHost.Container.Resolve<IMovieTeamsServices>();
            var response = service.Any(new CreateMovieTeam { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IMovieTeamModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "MovieTeams")]
        public void Verify_UpdateMovieTeam_Should_ReturnAnMovieTeamModel()
        {
            var service = AppHost.Container.Resolve<IMovieTeamsServices>();
            var response = service.Any(new UpdateMovieTeam { Id = 1 });
            Assert.Equal(nameof(IMovieTeamModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "MovieTeams")]
        public void Verify_DeactivateMovieTeam_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IMovieTeamsServices>();
            var response = service.Any(new DeactivateMovieTeam { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "MovieTeams")]
        public void Verify_DeactivateMovieTeamByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IMovieTeamsServices>();
            var response = service.Any(new DeactivateMovieTeamByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "MovieTeams")]
        public void Verify_RemoveMovieTeam_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IMovieTeamsServices>();
            var response = service.Any(new RemoveMovieTeam { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "MovieTeams")]
        public void Verify_RemoveMovieTeamByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IMovieTeamsServices>();
            var response = service.Any(new RemoveMovieTeamByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
