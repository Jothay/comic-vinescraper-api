// <auto-generated>
// <copyright file="Powers.IPowerServices.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the PowersRepository Class.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in ComicVine.API.Services.Testing\Services\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Services//.Powers
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class PowersMockingSetup
    {
        public static Mock<IPowersBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockPowersBusinessWorkflow = new Mock<IPowersBusinessWorkflow>();
            // Mock Functions
            mockPowersBusinessWorkflow.Setup(m => m.Search(It.IsAny<IPowerSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IPowerModel>());
            mockPowersBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IPowerModel>().Object);
            mockPowersBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IPowerModel>().Object);
            mockPowersBusinessWorkflow.Setup(m => m.Create(It.IsAny<IPowerModel>())).Returns(() => new Mock<IPowerModel>().Object);
            mockPowersBusinessWorkflow.Setup(m => m.Update(It.IsAny<IPowerModel>())).Returns(() => new Mock<IPowerModel>().Object);
            mockPowersBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockPowersBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockPowersBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockPowersBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockPowersBusinessWorkflow;
        }
    }

    //public class PowersServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "Powers")]
        public void Verify_GetPowers_Should_ReturnAListOfPowerModels()
        {
            var service = AppHost.Container.Resolve<IPowersServices>();
            var response = service.Any(new GetPowers { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = null, ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IPowerModel>>(response);
        }
        [Fact][Trait("Category", "Powers")]
        public void Verify_GetPowersAsListing_Should_ReturnAListOfPowerModels()
        {
            var service = AppHost.Container.Resolve<IPowersServices>();
            var response = service.Any(new GetPowersAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = "famous", ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IPowerModel>>(response);
        }
        [Fact][Trait("Category", "Powers")]
        public void Verify_GetPower_Should_ReturnAnPowerModel()
        {
            var service = AppHost.Container.Resolve<IPowersServices>();
            var response = service.Any(new GetPower { ID = 1 });
            Assert.Equal(nameof(IPowerModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Powers")]
        public void Verify_GetPowerByKey_Should_ReturnAnPowerModel()
        {
            var service = AppHost.Container.Resolve<IPowersServices>();
            var response = service.Any(new GetPowerByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IPowerModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Powers")]
        public void Verify_CreatePower_Should_ReturnAnPowerModel()
        {
            var service = AppHost.Container.Resolve<IPowersServices>();
            var response = service.Any(new CreatePower { Name = "Stephen King", CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IPowerModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Powers")]
        public void Verify_UpdatePower_Should_ReturnAnPowerModel()
        {
            var service = AppHost.Container.Resolve<IPowersServices>();
            var response = service.Any(new UpdatePower { Id = 1 });
            Assert.Equal(nameof(IPowerModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Powers")]
        public void Verify_DeactivatePower_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IPowersServices>();
            var response = service.Any(new DeactivatePower { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Powers")]
        public void Verify_DeactivatePowerByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IPowersServices>();
            var response = service.Any(new DeactivatePowerByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Powers")]
        public void Verify_RemovePower_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IPowersServices>();
            var response = service.Any(new RemovePower { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Powers")]
        public void Verify_RemovePowerByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IPowersServices>();
            var response = service.Any(new RemovePowerByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
