// <auto-generated>
// <copyright file="Episodes.IEpisodeCharacterDiedServices.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeCharactersDiedRepository Class.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in ComicVine.API.Services.Testing\Services\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Services//.Episodes
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class EpisodeCharactersDiedMockingSetup
    {
        public static Mock<IEpisodeCharactersDiedBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockEpisodeCharactersDiedBusinessWorkflow = new Mock<IEpisodeCharactersDiedBusinessWorkflow>();
            // Mock Functions
            mockEpisodeCharactersDiedBusinessWorkflow.Setup(m => m.Search(It.IsAny<IEpisodeCharacterDiedSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IEpisodeCharacterDiedModel>());
            mockEpisodeCharactersDiedBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IEpisodeCharacterDiedModel>().Object);
            mockEpisodeCharactersDiedBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IEpisodeCharacterDiedModel>().Object);
            mockEpisodeCharactersDiedBusinessWorkflow.Setup(m => m.Create(It.IsAny<IEpisodeCharacterDiedModel>())).Returns(() => new Mock<IEpisodeCharacterDiedModel>().Object);
            mockEpisodeCharactersDiedBusinessWorkflow.Setup(m => m.Update(It.IsAny<IEpisodeCharacterDiedModel>())).Returns(() => new Mock<IEpisodeCharacterDiedModel>().Object);
            mockEpisodeCharactersDiedBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockEpisodeCharactersDiedBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockEpisodeCharactersDiedBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockEpisodeCharactersDiedBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockEpisodeCharactersDiedBusinessWorkflow;
        }
    }

    //public class EpisodeCharactersDiedServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "EpisodeCharactersDied")]
        public void Verify_GetEpisodeCharactersDied_Should_ReturnAListOfEpisodeCharacterDiedModels()
        {
            var service = AppHost.Container.Resolve<IEpisodeCharactersDiedServices>();
            var response = service.Any(new GetEpisodeCharactersDied { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IEpisodeCharacterDiedModel>>(response);
        }
        [Fact][Trait("Category", "EpisodeCharactersDied")]
        public void Verify_GetEpisodeCharactersDiedAsListing_Should_ReturnAListOfEpisodeCharacterDiedModels()
        {
            var service = AppHost.Container.Resolve<IEpisodeCharactersDiedServices>();
            var response = service.Any(new GetEpisodeCharactersDiedAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IEpisodeCharacterDiedModel>>(response);
        }
        [Fact][Trait("Category", "EpisodeCharactersDied")]
        public void Verify_GetEpisodeCharacterDied_Should_ReturnAnEpisodeCharacterDiedModel()
        {
            var service = AppHost.Container.Resolve<IEpisodeCharactersDiedServices>();
            var response = service.Any(new GetEpisodeCharacterDied { ID = 1 });
            Assert.Equal(nameof(IEpisodeCharacterDiedModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "EpisodeCharactersDied")]
        public void Verify_GetEpisodeCharacterDiedByKey_Should_ReturnAnEpisodeCharacterDiedModel()
        {
            var service = AppHost.Container.Resolve<IEpisodeCharactersDiedServices>();
            var response = service.Any(new GetEpisodeCharacterDiedByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IEpisodeCharacterDiedModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "EpisodeCharactersDied")]
        public void Verify_CreateEpisodeCharacterDied_Should_ReturnAnEpisodeCharacterDiedModel()
        {
            var service = AppHost.Container.Resolve<IEpisodeCharactersDiedServices>();
            var response = service.Any(new CreateEpisodeCharacterDied { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IEpisodeCharacterDiedModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "EpisodeCharactersDied")]
        public void Verify_UpdateEpisodeCharacterDied_Should_ReturnAnEpisodeCharacterDiedModel()
        {
            var service = AppHost.Container.Resolve<IEpisodeCharactersDiedServices>();
            var response = service.Any(new UpdateEpisodeCharacterDied { Id = 1 });
            Assert.Equal(nameof(IEpisodeCharacterDiedModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "EpisodeCharactersDied")]
        public void Verify_DeactivateEpisodeCharacterDied_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IEpisodeCharactersDiedServices>();
            var response = service.Any(new DeactivateEpisodeCharacterDied { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "EpisodeCharactersDied")]
        public void Verify_DeactivateEpisodeCharacterDiedByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IEpisodeCharactersDiedServices>();
            var response = service.Any(new DeactivateEpisodeCharacterDiedByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "EpisodeCharactersDied")]
        public void Verify_RemoveEpisodeCharacterDied_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IEpisodeCharactersDiedServices>();
            var response = service.Any(new RemoveEpisodeCharacterDied { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "EpisodeCharactersDied")]
        public void Verify_RemoveEpisodeCharacterDiedByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IEpisodeCharactersDiedServices>();
            var response = service.Any(new RemoveEpisodeCharacterDiedByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
