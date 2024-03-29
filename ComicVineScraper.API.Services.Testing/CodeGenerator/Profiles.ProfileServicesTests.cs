// <auto-generated>
// <copyright file="Profiles.IProfileServicesTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the Profiles ServiceStack Services Tests.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in
// ComicVineScraper.API.Services.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Services//.Profiles
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class ProfilesMockingSetup
    {
        public static Mock<IProfilesBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockProfilesBusinessWorkflow = new Mock<IProfilesBusinessWorkflow>();
            // Mock Functions
            mockProfilesBusinessWorkflow.Setup(m => m.Search(It.IsAny<IProfileSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IProfileModel>());
            mockProfilesBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IProfileModel>().Object);
            mockProfilesBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IProfileModel>().Object);
            mockProfilesBusinessWorkflow.Setup(m => m.Create(It.IsAny<IProfileModel>())).Returns(() => new Mock<IProfileModel>().Object);
            mockProfilesBusinessWorkflow.Setup(m => m.Update(It.IsAny<IProfileModel>())).Returns(() => new Mock<IProfileModel>().Object);
            mockProfilesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockProfilesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockProfilesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockProfilesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockProfilesBusinessWorkflow;
        }
    }

    //public class ProfilesServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "Profiles")]
        public void Verify_GetProfiles_Should_ReturnAListOfProfileModels()
        {
            var service = AppHost.Container.Resolve<IProfilesServices>();
            var response = service.Any(new GetProfiles { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IProfileModel>>(response);
        }
        [Fact][Trait("Category", "Profiles")]
        public void Verify_GetProfilesAsListing_Should_ReturnAListOfProfileModels()
        {
            var service = AppHost.Container.Resolve<IProfilesServices>();
            var response = service.Any(new GetProfilesAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IProfileModel>>(response);
        }
        [Fact][Trait("Category", "Profiles")]
        public void Verify_GetProfile_Should_ReturnAnProfileModel()
        {
            var service = AppHost.Container.Resolve<IProfilesServices>();
            var response = service.Any(new GetProfile { ID = 1 });
            Assert.Equal(nameof(IProfileModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Profiles")]
        public void Verify_GetProfileByKey_Should_ReturnAnProfileModel()
        {
            var service = AppHost.Container.Resolve<IProfilesServices>();
            var response = service.Any(new GetProfileByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IProfileModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Profiles")]
        public void Verify_CreateProfile_Should_ReturnAnProfileModel()
        {
            var service = AppHost.Container.Resolve<IProfilesServices>();
            var response = service.Any(new CreateProfile { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IProfileModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Profiles")]
        public void Verify_UpdateProfile_Should_ReturnAnProfileModel()
        {
            var service = AppHost.Container.Resolve<IProfilesServices>();
            var response = service.Any(new UpdateProfile { Id = 1 });
            Assert.Equal(nameof(IProfileModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Profiles")]
        public void Verify_DeactivateProfile_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IProfilesServices>();
            var response = service.Any(new DeactivateProfile { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Profiles")]
        public void Verify_DeactivateProfileByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IProfilesServices>();
            var response = service.Any(new DeactivateProfileByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Profiles")]
        public void Verify_RemoveProfile_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IProfilesServices>();
            var response = service.Any(new RemoveProfile { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Profiles")]
        public void Verify_RemoveProfileByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IProfilesServices>();
            var response = service.Any(new RemoveProfileByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
