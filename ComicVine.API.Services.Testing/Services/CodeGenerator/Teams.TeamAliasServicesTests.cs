// <auto-generated>
// <copyright file="Teams.ITeamAliasServices.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamAliasesRepository Class.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in ComicVine.API.Services.Testing\Services\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Services//.Teams
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class TeamAliasesMockingSetup
    {
        public static Mock<ITeamAliasesBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockTeamAliasesBusinessWorkflow = new Mock<ITeamAliasesBusinessWorkflow>();
            // Mock Functions
            mockTeamAliasesBusinessWorkflow.Setup(m => m.Search(It.IsAny<ITeamAliasSearchModel>(), It.IsAny<bool>())).Returns(() => new List<ITeamAliasModel>());
            mockTeamAliasesBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ITeamAliasModel>().Object);
            mockTeamAliasesBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ITeamAliasModel>().Object);
            mockTeamAliasesBusinessWorkflow.Setup(m => m.Create(It.IsAny<ITeamAliasModel>())).Returns(() => new Mock<ITeamAliasModel>().Object);
            mockTeamAliasesBusinessWorkflow.Setup(m => m.Update(It.IsAny<ITeamAliasModel>())).Returns(() => new Mock<ITeamAliasModel>().Object);
            mockTeamAliasesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockTeamAliasesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockTeamAliasesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockTeamAliasesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockTeamAliasesBusinessWorkflow;
        }
    }

    //public class TeamAliasesServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_GetTeamAliases_Should_ReturnAListOfTeamAliasModels()
        {
            var service = AppHost.Container.Resolve<ITeamAliasesServices>();
            var response = service.Any(new GetTeamAliases { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = null, ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<ITeamAliasModel>>(response);
        }
        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_GetTeamAliasesAsListing_Should_ReturnAListOfTeamAliasModels()
        {
            var service = AppHost.Container.Resolve<ITeamAliasesServices>();
            var response = service.Any(new GetTeamAliasesAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = "famous", ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<ITeamAliasModel>>(response);
        }
        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_GetTeamAlias_Should_ReturnAnTeamAliasModel()
        {
            var service = AppHost.Container.Resolve<ITeamAliasesServices>();
            var response = service.Any(new GetTeamAlias { ID = 1 });
            Assert.Equal(nameof(ITeamAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_GetTeamAliasByKey_Should_ReturnAnTeamAliasModel()
        {
            var service = AppHost.Container.Resolve<ITeamAliasesServices>();
            var response = service.Any(new GetTeamAliasByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(ITeamAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_CreateTeamAlias_Should_ReturnAnTeamAliasModel()
        {
            var service = AppHost.Container.Resolve<ITeamAliasesServices>();
            var response = service.Any(new CreateTeamAlias { Name = "Stephen King", CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(ITeamAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_UpdateTeamAlias_Should_ReturnAnTeamAliasModel()
        {
            var service = AppHost.Container.Resolve<ITeamAliasesServices>();
            var response = service.Any(new UpdateTeamAlias { Id = 1 });
            Assert.Equal(nameof(ITeamAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_DeactivateTeamAlias_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ITeamAliasesServices>();
            var response = service.Any(new DeactivateTeamAlias { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_DeactivateTeamAliasByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ITeamAliasesServices>();
            var response = service.Any(new DeactivateTeamAliasByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_RemoveTeamAlias_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ITeamAliasesServices>();
            var response = service.Any(new RemoveTeamAlias { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_RemoveTeamAliasByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ITeamAliasesServices>();
            var response = service.Any(new RemoveTeamAliasByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
