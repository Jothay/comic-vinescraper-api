// <auto-generated>
// <copyright file="Episodes.IEpisodeStoryArcServices.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeStoryArcsRepository Class.</summary>
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

    public static class EpisodeStoryArcsMockingSetup
    {
        public static Mock<IEpisodeStoryArcsBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockEpisodeStoryArcsBusinessWorkflow = new Mock<IEpisodeStoryArcsBusinessWorkflow>();
            // Mock Functions
            mockEpisodeStoryArcsBusinessWorkflow.Setup(m => m.Search(It.IsAny<IEpisodeStoryArcSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IEpisodeStoryArcModel>());
            mockEpisodeStoryArcsBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IEpisodeStoryArcModel>().Object);
            mockEpisodeStoryArcsBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IEpisodeStoryArcModel>().Object);
            mockEpisodeStoryArcsBusinessWorkflow.Setup(m => m.Create(It.IsAny<IEpisodeStoryArcModel>())).Returns(() => new Mock<IEpisodeStoryArcModel>().Object);
            mockEpisodeStoryArcsBusinessWorkflow.Setup(m => m.Update(It.IsAny<IEpisodeStoryArcModel>())).Returns(() => new Mock<IEpisodeStoryArcModel>().Object);
            mockEpisodeStoryArcsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockEpisodeStoryArcsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockEpisodeStoryArcsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockEpisodeStoryArcsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockEpisodeStoryArcsBusinessWorkflow;
        }
    }

    //public class EpisodeStoryArcsServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "EpisodeStoryArcs")]
        public void Verify_GetEpisodeStoryArcs_Should_ReturnAListOfEpisodeStoryArcModels()
        {
            var service = AppHost.Container.Resolve<IEpisodeStoryArcsServices>();
            var response = service.Any(new GetEpisodeStoryArcs { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IEpisodeStoryArcModel>>(response);
        }
        [Fact][Trait("Category", "EpisodeStoryArcs")]
        public void Verify_GetEpisodeStoryArcsAsListing_Should_ReturnAListOfEpisodeStoryArcModels()
        {
            var service = AppHost.Container.Resolve<IEpisodeStoryArcsServices>();
            var response = service.Any(new GetEpisodeStoryArcsAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IEpisodeStoryArcModel>>(response);
        }
        [Fact][Trait("Category", "EpisodeStoryArcs")]
        public void Verify_GetEpisodeStoryArc_Should_ReturnAnEpisodeStoryArcModel()
        {
            var service = AppHost.Container.Resolve<IEpisodeStoryArcsServices>();
            var response = service.Any(new GetEpisodeStoryArc { ID = 1 });
            Assert.Equal(nameof(IEpisodeStoryArcModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "EpisodeStoryArcs")]
        public void Verify_GetEpisodeStoryArcByKey_Should_ReturnAnEpisodeStoryArcModel()
        {
            var service = AppHost.Container.Resolve<IEpisodeStoryArcsServices>();
            var response = service.Any(new GetEpisodeStoryArcByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IEpisodeStoryArcModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "EpisodeStoryArcs")]
        public void Verify_CreateEpisodeStoryArc_Should_ReturnAnEpisodeStoryArcModel()
        {
            var service = AppHost.Container.Resolve<IEpisodeStoryArcsServices>();
            var response = service.Any(new CreateEpisodeStoryArc { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IEpisodeStoryArcModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "EpisodeStoryArcs")]
        public void Verify_UpdateEpisodeStoryArc_Should_ReturnAnEpisodeStoryArcModel()
        {
            var service = AppHost.Container.Resolve<IEpisodeStoryArcsServices>();
            var response = service.Any(new UpdateEpisodeStoryArc { Id = 1 });
            Assert.Equal(nameof(IEpisodeStoryArcModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "EpisodeStoryArcs")]
        public void Verify_DeactivateEpisodeStoryArc_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IEpisodeStoryArcsServices>();
            var response = service.Any(new DeactivateEpisodeStoryArc { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "EpisodeStoryArcs")]
        public void Verify_DeactivateEpisodeStoryArcByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IEpisodeStoryArcsServices>();
            var response = service.Any(new DeactivateEpisodeStoryArcByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "EpisodeStoryArcs")]
        public void Verify_RemoveEpisodeStoryArc_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IEpisodeStoryArcsServices>();
            var response = service.Any(new RemoveEpisodeStoryArc { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "EpisodeStoryArcs")]
        public void Verify_RemoveEpisodeStoryArcByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IEpisodeStoryArcsServices>();
            var response = service.Any(new RemoveEpisodeStoryArcByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
