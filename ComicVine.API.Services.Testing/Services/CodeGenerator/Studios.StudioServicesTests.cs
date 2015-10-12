// <auto-generated>
// <copyright file="Studios.IStudioServices.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the StudiosRepository Class.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in ComicVine.API.Services.Testing\Services\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Services//.Studios
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class StudiosMockingSetup
    {
        public static Mock<IStudiosBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockStudiosBusinessWorkflow = new Mock<IStudiosBusinessWorkflow>();
            // Mock Functions
            mockStudiosBusinessWorkflow.Setup(m => m.Search(It.IsAny<IStudioSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IStudioModel>());
            mockStudiosBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IStudioModel>().Object);
            mockStudiosBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IStudioModel>().Object);
            mockStudiosBusinessWorkflow.Setup(m => m.Create(It.IsAny<IStudioModel>())).Returns(() => new Mock<IStudioModel>().Object);
            mockStudiosBusinessWorkflow.Setup(m => m.Update(It.IsAny<IStudioModel>())).Returns(() => new Mock<IStudioModel>().Object);
            mockStudiosBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockStudiosBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockStudiosBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockStudiosBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockStudiosBusinessWorkflow;
        }
    }

    //public class StudiosServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "Studios")]
        public void Verify_GetStudios_Should_ReturnAListOfStudioModels()
        {
            var service = AppHost.Container.Resolve<IStudiosServices>();
            var response = service.Any(new GetStudios { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = null, ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IStudioModel>>(response);
        }
        [Fact][Trait("Category", "Studios")]
        public void Verify_GetStudiosAsListing_Should_ReturnAListOfStudioModels()
        {
            var service = AppHost.Container.Resolve<IStudiosServices>();
            var response = service.Any(new GetStudiosAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = "famous", ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IStudioModel>>(response);
        }
        [Fact][Trait("Category", "Studios")]
        public void Verify_GetStudio_Should_ReturnAnStudioModel()
        {
            var service = AppHost.Container.Resolve<IStudiosServices>();
            var response = service.Any(new GetStudio { ID = 1 });
            Assert.Equal(nameof(IStudioModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Studios")]
        public void Verify_GetStudioByKey_Should_ReturnAnStudioModel()
        {
            var service = AppHost.Container.Resolve<IStudiosServices>();
            var response = service.Any(new GetStudioByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IStudioModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Studios")]
        public void Verify_CreateStudio_Should_ReturnAnStudioModel()
        {
            var service = AppHost.Container.Resolve<IStudiosServices>();
            var response = service.Any(new CreateStudio { Name = "Stephen King", CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IStudioModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Studios")]
        public void Verify_UpdateStudio_Should_ReturnAnStudioModel()
        {
            var service = AppHost.Container.Resolve<IStudiosServices>();
            var response = service.Any(new UpdateStudio { Id = 1 });
            Assert.Equal(nameof(IStudioModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Studios")]
        public void Verify_DeactivateStudio_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IStudiosServices>();
            var response = service.Any(new DeactivateStudio { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Studios")]
        public void Verify_DeactivateStudioByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IStudiosServices>();
            var response = service.Any(new DeactivateStudioByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Studios")]
        public void Verify_RemoveStudio_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IStudiosServices>();
            var response = service.Any(new RemoveStudio { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Studios")]
        public void Verify_RemoveStudioByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IStudiosServices>();
            var response = service.Any(new RemoveStudioByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}