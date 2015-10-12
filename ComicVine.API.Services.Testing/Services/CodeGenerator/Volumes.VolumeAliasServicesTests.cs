// <auto-generated>
// <copyright file="Volumes.IVolumeAliasServices.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VolumeAliasesRepository Class.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in ComicVine.API.Services.Testing\Services\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Services//.Volumes
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class VolumeAliasesMockingSetup
    {
        public static Mock<IVolumeAliasesBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockVolumeAliasesBusinessWorkflow = new Mock<IVolumeAliasesBusinessWorkflow>();
            // Mock Functions
            mockVolumeAliasesBusinessWorkflow.Setup(m => m.Search(It.IsAny<IVolumeAliasSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IVolumeAliasModel>());
            mockVolumeAliasesBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IVolumeAliasModel>().Object);
            mockVolumeAliasesBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IVolumeAliasModel>().Object);
            mockVolumeAliasesBusinessWorkflow.Setup(m => m.Create(It.IsAny<IVolumeAliasModel>())).Returns(() => new Mock<IVolumeAliasModel>().Object);
            mockVolumeAliasesBusinessWorkflow.Setup(m => m.Update(It.IsAny<IVolumeAliasModel>())).Returns(() => new Mock<IVolumeAliasModel>().Object);
            mockVolumeAliasesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockVolumeAliasesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockVolumeAliasesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockVolumeAliasesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockVolumeAliasesBusinessWorkflow;
        }
    }

    //public class VolumeAliasesServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_GetVolumeAliases_Should_ReturnAListOfVolumeAliasModels()
        {
            var service = AppHost.Container.Resolve<IVolumeAliasesServices>();
            var response = service.Any(new GetVolumeAliases { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = null, ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IVolumeAliasModel>>(response);
        }
        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_GetVolumeAliasesAsListing_Should_ReturnAListOfVolumeAliasModels()
        {
            var service = AppHost.Container.Resolve<IVolumeAliasesServices>();
            var response = service.Any(new GetVolumeAliasesAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = "famous", ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IVolumeAliasModel>>(response);
        }
        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_GetVolumeAlias_Should_ReturnAnVolumeAliasModel()
        {
            var service = AppHost.Container.Resolve<IVolumeAliasesServices>();
            var response = service.Any(new GetVolumeAlias { ID = 1 });
            Assert.Equal(nameof(IVolumeAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_GetVolumeAliasByKey_Should_ReturnAnVolumeAliasModel()
        {
            var service = AppHost.Container.Resolve<IVolumeAliasesServices>();
            var response = service.Any(new GetVolumeAliasByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IVolumeAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_CreateVolumeAlias_Should_ReturnAnVolumeAliasModel()
        {
            var service = AppHost.Container.Resolve<IVolumeAliasesServices>();
            var response = service.Any(new CreateVolumeAlias { Name = "Stephen King", CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IVolumeAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_UpdateVolumeAlias_Should_ReturnAnVolumeAliasModel()
        {
            var service = AppHost.Container.Resolve<IVolumeAliasesServices>();
            var response = service.Any(new UpdateVolumeAlias { Id = 1 });
            Assert.Equal(nameof(IVolumeAliasModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_DeactivateVolumeAlias_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IVolumeAliasesServices>();
            var response = service.Any(new DeactivateVolumeAlias { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_DeactivateVolumeAliasByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IVolumeAliasesServices>();
            var response = service.Any(new DeactivateVolumeAliasByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_RemoveVolumeAlias_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IVolumeAliasesServices>();
            var response = service.Any(new RemoveVolumeAlias { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_RemoveVolumeAliasByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IVolumeAliasesServices>();
            var response = service.Any(new RemoveVolumeAliasByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
