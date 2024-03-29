// <auto-generated>
// <copyright file="Characters.ICharacterAliasServicesTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the CharacterAliases ServiceStack Services Tests.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in
// ComicVineScraper.API.Services.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Services//.Characters
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class CharacterAliasesMockingSetup
    {
        public static Mock<ICharacterAliasesBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockCharacterAliasesBusinessWorkflow = new Mock<ICharacterAliasesBusinessWorkflow>();
            // Mock Functions
            mockCharacterAliasesBusinessWorkflow.Setup(m => m.Search(It.IsAny<ICharacterAliasSearchModel>(), It.IsAny<bool>())).Returns(() => new List<ICharacterAliasModel>());
            mockCharacterAliasesBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ICharacterAliasModel>().Object);
            mockCharacterAliasesBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ICharacterAliasModel>().Object);
            mockCharacterAliasesBusinessWorkflow.Setup(m => m.Create(It.IsAny<ICharacterAliasModel>())).Returns(() => new Mock<ICharacterAliasModel>().Object);
            mockCharacterAliasesBusinessWorkflow.Setup(m => m.Update(It.IsAny<ICharacterAliasModel>())).Returns(() => new Mock<ICharacterAliasModel>().Object);
            mockCharacterAliasesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockCharacterAliasesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockCharacterAliasesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockCharacterAliasesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockCharacterAliasesBusinessWorkflow;
        }
    }

    //public class CharacterAliasesServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_GetCharacterAliases_Should_ReturnAListOfCharacterAliasModels()
        {
            var service = AppHost.Container.Resolve<ICharacterAliasesServices>();
            var response = service.Any(new GetCharacterAliases { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<ICharacterAliasModel>>(response);
        }
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_GetCharacterAliasesAsListing_Should_ReturnAListOfCharacterAliasModels()
        {
            var service = AppHost.Container.Resolve<ICharacterAliasesServices>();
            var response = service.Any(new GetCharacterAliasesAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<ICharacterAliasModel>>(response);
        }
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_GetCharacterAlias_Should_ReturnAnCharacterAliasModel()
        {
            var service = AppHost.Container.Resolve<ICharacterAliasesServices>();
            var response = service.Any(new GetCharacterAlias { ID = 1 });
            Assert.Equal(nameof(ICharacterAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_GetCharacterAliasByKey_Should_ReturnAnCharacterAliasModel()
        {
            var service = AppHost.Container.Resolve<ICharacterAliasesServices>();
            var response = service.Any(new GetCharacterAliasByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(ICharacterAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_CreateCharacterAlias_Should_ReturnAnCharacterAliasModel()
        {
            var service = AppHost.Container.Resolve<ICharacterAliasesServices>();
            var response = service.Any(new CreateCharacterAlias { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(ICharacterAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_UpdateCharacterAlias_Should_ReturnAnCharacterAliasModel()
        {
            var service = AppHost.Container.Resolve<ICharacterAliasesServices>();
            var response = service.Any(new UpdateCharacterAlias { Id = 1 });
            Assert.Equal(nameof(ICharacterAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_DeactivateCharacterAlias_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ICharacterAliasesServices>();
            var response = service.Any(new DeactivateCharacterAlias { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_DeactivateCharacterAliasByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ICharacterAliasesServices>();
            var response = service.Any(new DeactivateCharacterAliasByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_RemoveCharacterAlias_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ICharacterAliasesServices>();
            var response = service.Any(new RemoveCharacterAlias { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_RemoveCharacterAliasByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<ICharacterAliasesServices>();
            var response = service.Any(new RemoveCharacterAliasByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
