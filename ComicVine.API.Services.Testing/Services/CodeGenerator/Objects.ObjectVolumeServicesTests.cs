// <auto-generated>
// <copyright file="Objects.IObjectVolumeServices.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectVolumesRepository Class.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in ComicVine.API.Services.Testing\Services\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Services//.Objects
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class ObjectVolumesMockingSetup
    {
        public static Mock<IObjectVolumesBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockObjectVolumesBusinessWorkflow = new Mock<IObjectVolumesBusinessWorkflow>();
            // Mock Functions
            mockObjectVolumesBusinessWorkflow.Setup(m => m.Search(It.IsAny<IObjectVolumeSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IObjectVolumeModel>());
            mockObjectVolumesBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IObjectVolumeModel>().Object);
            mockObjectVolumesBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IObjectVolumeModel>().Object);
            mockObjectVolumesBusinessWorkflow.Setup(m => m.Create(It.IsAny<IObjectVolumeModel>())).Returns(() => new Mock<IObjectVolumeModel>().Object);
            mockObjectVolumesBusinessWorkflow.Setup(m => m.Update(It.IsAny<IObjectVolumeModel>())).Returns(() => new Mock<IObjectVolumeModel>().Object);
            mockObjectVolumesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockObjectVolumesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockObjectVolumesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockObjectVolumesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockObjectVolumesBusinessWorkflow;
        }
    }

    //public class ObjectVolumesServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "ObjectVolumes")]
        public void Verify_GetObjectVolumes_Should_ReturnAListOfObjectVolumeModels()
        {
            var service = AppHost.Container.Resolve<IObjectVolumesServices>();
            var response = service.Any(new GetObjectVolumes { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IObjectVolumeModel>>(response);
        }
        [Fact][Trait("Category", "ObjectVolumes")]
        public void Verify_GetObjectVolumesAsListing_Should_ReturnAListOfObjectVolumeModels()
        {
            var service = AppHost.Container.Resolve<IObjectVolumesServices>();
            var response = service.Any(new GetObjectVolumesAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IObjectVolumeModel>>(response);
        }
        [Fact][Trait("Category", "ObjectVolumes")]
        public void Verify_GetObjectVolume_Should_ReturnAnObjectVolumeModel()
        {
            var service = AppHost.Container.Resolve<IObjectVolumesServices>();
            var response = service.Any(new GetObjectVolume { ID = 1 });
            Assert.Equal(nameof(IObjectVolumeModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "ObjectVolumes")]
        public void Verify_GetObjectVolumeByKey_Should_ReturnAnObjectVolumeModel()
        {
            var service = AppHost.Container.Resolve<IObjectVolumesServices>();
            var response = service.Any(new GetObjectVolumeByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IObjectVolumeModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "ObjectVolumes")]
        public void Verify_CreateObjectVolume_Should_ReturnAnObjectVolumeModel()
        {
            var service = AppHost.Container.Resolve<IObjectVolumesServices>();
            var response = service.Any(new CreateObjectVolume { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IObjectVolumeModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "ObjectVolumes")]
        public void Verify_UpdateObjectVolume_Should_ReturnAnObjectVolumeModel()
        {
            var service = AppHost.Container.Resolve<IObjectVolumesServices>();
            var response = service.Any(new UpdateObjectVolume { Id = 1 });
            Assert.Equal(nameof(IObjectVolumeModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "ObjectVolumes")]
        public void Verify_DeactivateObjectVolume_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IObjectVolumesServices>();
            var response = service.Any(new DeactivateObjectVolume { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "ObjectVolumes")]
        public void Verify_DeactivateObjectVolumeByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IObjectVolumesServices>();
            var response = service.Any(new DeactivateObjectVolumeByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "ObjectVolumes")]
        public void Verify_RemoveObjectVolume_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IObjectVolumesServices>();
            var response = service.Any(new RemoveObjectVolume { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "ObjectVolumes")]
        public void Verify_RemoveObjectVolumeByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IObjectVolumesServices>();
            var response = service.Any(new RemoveObjectVolumeByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
