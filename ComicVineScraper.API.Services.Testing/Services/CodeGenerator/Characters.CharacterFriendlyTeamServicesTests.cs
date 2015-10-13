// <auto-generated>
// <copyright file="Characters.ICharacterFriendlyTeamServices.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterFriendlyTeamsRepository Class.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in ComicVine.API.Services.Testing\Services\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Services//.Characters
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class CharacterFriendlyTeamsMockingSetup
    {
        public static Mock<ICharacterFriendlyTeamsBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockCharacterFriendlyTeamsBusinessWorkflow = new Mock<ICharacterFriendlyTeamsBusinessWorkflow>();
            // Mock Functions
            mockCharacterFriendlyTeamsBusinessWorkflow.Setup(m => m.Search(It.IsAny<ICharacterFriendlyTeamSearchModel>(), It.IsAny<bool>())).Returns(() => new List<ICharacterFriendlyTeamModel>());
            mockCharacterFriendlyTeamsBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ICharacterFriendlyTeamModel>().Object);
            mockCharacterFriendlyTeamsBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ICharacterFriendlyTeamModel>().Object);
            mockCharacterFriendlyTeamsBusinessWorkflow.Setup(m => m.Create(It.IsAny<ICharacterFriendlyTeamModel>())).Returns(() => new Mock<ICharacterFriendlyTeamModel>().Object);
            mockCharacterFriendlyTeamsBusinessWorkflow.Setup(m => m.Update(It.IsAny<ICharacterFriendlyTeamModel>())).Returns(() => new Mock<ICharacterFriendlyTeamModel>().Object);
            mockCharacterFriendlyTeamsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockCharacterFriendlyTeamsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockCharacterFriendlyTeamsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockCharacterFriendlyTeamsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockCharacterFriendlyTeamsBusinessWorkflow;
        }
    }

    //public class CharacterFriendlyTeamsServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_GetCharacterFriendlyTeams_Should_ReturnAListOfCharacterFriendlyTeamModels()
        {
            var service = AppHost.Container.Resolve<ICharacterFriendlyTeamsServices>();
            var response = service.Any(new GetCharacterFriendlyTeams { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<ICharacterFriendlyTeamModel>>(response);
        }
        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_GetCharacterFriendlyTeamsAsListing_Should_ReturnAListOfCharacterFriendlyTeamModels()
        {
            var service = AppHost.Container.Resolve<ICharacterFriendlyTeamsServices>();
            var response = service.Any(new GetCharacterFriendlyTeamsAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<ICharacterFriendlyTeamModel>>(response);
        }
        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_GetCharacterFriendlyTeam_Should_ReturnAnCharacterFriendlyTeamModel()
        {
            var service = AppHost.Container.Resolve<ICharacterFriendlyTeamsServices>();
            var response = service.Any(new GetCharacterFriendlyTeam { ID = 1 });
            Assert.Equal(nameof(ICharacterFriendlyTeamModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_GetCharacterFriendlyTeamByKey_Should_ReturnAnCharacterFriendlyTeamModel()
        {
            var service = AppHost.Container.Resolve<ICharacterFriendlyTeamsServices>();
            var response = service.Any(new GetCharacterFriendlyTeamByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(ICharacterFriendlyTeamModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_CreateCharacterFriendlyTeam_Should_ReturnAnCharacterFriendlyTeamModel()
        {
            var service = AppHost.Container.Resolve<ICharacterFriendlyTeamsServices>();
            var response = service.Any(new CreateCharacterFriendlyTeam { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(ICharacterFriendlyTeamModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_UpdateCharacterFriendlyTeam_Should_ReturnAnCharacterFriendlyTeamModel()
        {
            var service = AppHost.Container.Resolve<ICharacterFriendlyTeamsServices>();
            var response = service.Any(new UpdateCharacterFriendlyTeam { Id = 1 });
            Assert.Equal(nameof(ICharacterFriendlyTeamModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_DeactivateCharacterFriendlyTeam_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ICharacterFriendlyTeamsServices>();
            var response = service.Any(new DeactivateCharacterFriendlyTeam { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_DeactivateCharacterFriendlyTeamByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ICharacterFriendlyTeamsServices>();
            var response = service.Any(new DeactivateCharacterFriendlyTeamByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_RemoveCharacterFriendlyTeam_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ICharacterFriendlyTeamsServices>();
            var response = service.Any(new RemoveCharacterFriendlyTeam { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_RemoveCharacterFriendlyTeamByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ICharacterFriendlyTeamsServices>();
            var response = service.Any(new RemoveCharacterFriendlyTeamByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}