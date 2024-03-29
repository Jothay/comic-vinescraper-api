// <auto-generated>
// <copyright file="Teams.ITeamServicesTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the Teams ServiceStack Services Tests.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in
// ComicVineScraper.API.Services.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Services//.Teams
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class TeamsMockingSetup
    {
        public static Mock<ITeamsBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockTeamsBusinessWorkflow = new Mock<ITeamsBusinessWorkflow>();
            // Mock Functions
            mockTeamsBusinessWorkflow.Setup(m => m.Search(It.IsAny<ITeamSearchModel>(), It.IsAny<bool>())).Returns(() => new List<ITeamModel>());
            mockTeamsBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ITeamModel>().Object);
            mockTeamsBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ITeamModel>().Object);
            mockTeamsBusinessWorkflow.Setup(m => m.Create(It.IsAny<ITeamModel>())).Returns(() => new Mock<ITeamModel>().Object);
            mockTeamsBusinessWorkflow.Setup(m => m.Update(It.IsAny<ITeamModel>())).Returns(() => new Mock<ITeamModel>().Object);
            mockTeamsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockTeamsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockTeamsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockTeamsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockTeamsBusinessWorkflow;
        }
    }

    //public class TeamsServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "Teams")]
        public void Verify_GetTeams_Should_ReturnAListOfTeamModels()
        {
            var service = AppHost.Container.Resolve<ITeamsServices>();
            var response = service.Any(new GetTeams { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<ITeamModel>>(response);
        }
        [Fact][Trait("Category", "Teams")]
        public void Verify_GetTeamsAsListing_Should_ReturnAListOfTeamModels()
        {
            var service = AppHost.Container.Resolve<ITeamsServices>();
            var response = service.Any(new GetTeamsAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<ITeamModel>>(response);
        }
        [Fact][Trait("Category", "Teams")]
        public void Verify_GetTeam_Should_ReturnAnTeamModel()
        {
            var service = AppHost.Container.Resolve<ITeamsServices>();
            var response = service.Any(new GetTeam { ID = 1 });
            Assert.Equal(nameof(ITeamModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Teams")]
        public void Verify_GetTeamByKey_Should_ReturnAnTeamModel()
        {
            var service = AppHost.Container.Resolve<ITeamsServices>();
            var response = service.Any(new GetTeamByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(ITeamModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Teams")]
        public void Verify_CreateTeam_Should_ReturnAnTeamModel()
        {
            var service = AppHost.Container.Resolve<ITeamsServices>();
            var response = service.Any(new CreateTeam { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(ITeamModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Teams")]
        public void Verify_UpdateTeam_Should_ReturnAnTeamModel()
        {
            var service = AppHost.Container.Resolve<ITeamsServices>();
            var response = service.Any(new UpdateTeam { Id = 1 });
            Assert.Equal(nameof(ITeamModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Teams")]
        public void Verify_DeactivateTeam_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ITeamsServices>();
            var response = service.Any(new DeactivateTeam { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Teams")]
        public void Verify_DeactivateTeamByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ITeamsServices>();
            var response = service.Any(new DeactivateTeamByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Teams")]
        public void Verify_RemoveTeam_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ITeamsServices>();
            var response = service.Any(new RemoveTeam { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Teams")]
        public void Verify_RemoveTeamByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ITeamsServices>();
            var response = service.Any(new RemoveTeamByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
