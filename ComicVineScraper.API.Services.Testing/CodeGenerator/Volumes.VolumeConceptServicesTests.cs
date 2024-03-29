// <auto-generated>
// <copyright file="Volumes.IVolumeConceptServicesTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the VolumeConcepts ServiceStack Services Tests.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in
// ComicVineScraper.API.Services.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Services//.Volumes
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class VolumeConceptsMockingSetup
    {
        public static Mock<IVolumeConceptsBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockVolumeConceptsBusinessWorkflow = new Mock<IVolumeConceptsBusinessWorkflow>();
            // Mock Functions
            mockVolumeConceptsBusinessWorkflow.Setup(m => m.Search(It.IsAny<IVolumeConceptSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IVolumeConceptModel>());
            mockVolumeConceptsBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IVolumeConceptModel>().Object);
            mockVolumeConceptsBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IVolumeConceptModel>().Object);
            mockVolumeConceptsBusinessWorkflow.Setup(m => m.Create(It.IsAny<IVolumeConceptModel>())).Returns(() => new Mock<IVolumeConceptModel>().Object);
            mockVolumeConceptsBusinessWorkflow.Setup(m => m.Update(It.IsAny<IVolumeConceptModel>())).Returns(() => new Mock<IVolumeConceptModel>().Object);
            mockVolumeConceptsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockVolumeConceptsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockVolumeConceptsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockVolumeConceptsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockVolumeConceptsBusinessWorkflow;
        }
    }

    //public class VolumeConceptsServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_GetVolumeConcepts_Should_ReturnAListOfVolumeConceptModels()
        {
            var service = AppHost.Container.Resolve<IVolumeConceptsServices>();
            var response = service.Any(new GetVolumeConcepts { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IVolumeConceptModel>>(response);
        }
        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_GetVolumeConceptsAsListing_Should_ReturnAListOfVolumeConceptModels()
        {
            var service = AppHost.Container.Resolve<IVolumeConceptsServices>();
            var response = service.Any(new GetVolumeConceptsAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IVolumeConceptModel>>(response);
        }
        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_GetVolumeConcept_Should_ReturnAnVolumeConceptModel()
        {
            var service = AppHost.Container.Resolve<IVolumeConceptsServices>();
            var response = service.Any(new GetVolumeConcept { ID = 1 });
            Assert.Equal(nameof(IVolumeConceptModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_GetVolumeConceptByKey_Should_ReturnAnVolumeConceptModel()
        {
            var service = AppHost.Container.Resolve<IVolumeConceptsServices>();
            var response = service.Any(new GetVolumeConceptByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IVolumeConceptModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_CreateVolumeConcept_Should_ReturnAnVolumeConceptModel()
        {
            var service = AppHost.Container.Resolve<IVolumeConceptsServices>();
            var response = service.Any(new CreateVolumeConcept { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IVolumeConceptModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_UpdateVolumeConcept_Should_ReturnAnVolumeConceptModel()
        {
            var service = AppHost.Container.Resolve<IVolumeConceptsServices>();
            var response = service.Any(new UpdateVolumeConcept { Id = 1 });
            Assert.Equal(nameof(IVolumeConceptModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_DeactivateVolumeConcept_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IVolumeConceptsServices>();
            var response = service.Any(new DeactivateVolumeConcept { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_DeactivateVolumeConceptByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IVolumeConceptsServices>();
            var response = service.Any(new DeactivateVolumeConceptByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_RemoveVolumeConcept_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IVolumeConceptsServices>();
            var response = service.Any(new RemoveVolumeConcept { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_RemoveVolumeConceptByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IVolumeConceptsServices>();
            var response = service.Any(new RemoveVolumeConceptByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
