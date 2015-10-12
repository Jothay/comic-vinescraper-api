// <auto-generated>
// <copyright file="Issues.IIssueWriterServices.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the IssueWritersRepository Class.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in ComicVine.API.Services.Testing\Services\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Services//.Issues
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class IssueWritersMockingSetup
    {
        public static Mock<IIssueWritersBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockIssueWritersBusinessWorkflow = new Mock<IIssueWritersBusinessWorkflow>();
            // Mock Functions
            mockIssueWritersBusinessWorkflow.Setup(m => m.Search(It.IsAny<IIssueWriterSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IIssueWriterModel>());
            mockIssueWritersBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IIssueWriterModel>().Object);
            mockIssueWritersBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IIssueWriterModel>().Object);
            mockIssueWritersBusinessWorkflow.Setup(m => m.Create(It.IsAny<IIssueWriterModel>())).Returns(() => new Mock<IIssueWriterModel>().Object);
            mockIssueWritersBusinessWorkflow.Setup(m => m.Update(It.IsAny<IIssueWriterModel>())).Returns(() => new Mock<IIssueWriterModel>().Object);
            mockIssueWritersBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockIssueWritersBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockIssueWritersBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockIssueWritersBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockIssueWritersBusinessWorkflow;
        }
    }

    //public class IssueWritersServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "IssueWriters")]
        public void Verify_GetIssueWriters_Should_ReturnAListOfIssueWriterModels()
        {
            var service = AppHost.Container.Resolve<IIssueWritersServices>();
            var response = service.Any(new GetIssueWriters { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IIssueWriterModel>>(response);
        }
        [Fact][Trait("Category", "IssueWriters")]
        public void Verify_GetIssueWritersAsListing_Should_ReturnAListOfIssueWriterModels()
        {
            var service = AppHost.Container.Resolve<IIssueWritersServices>();
            var response = service.Any(new GetIssueWritersAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IIssueWriterModel>>(response);
        }
        [Fact][Trait("Category", "IssueWriters")]
        public void Verify_GetIssueWriter_Should_ReturnAnIssueWriterModel()
        {
            var service = AppHost.Container.Resolve<IIssueWritersServices>();
            var response = service.Any(new GetIssueWriter { ID = 1 });
            Assert.Equal(nameof(IIssueWriterModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "IssueWriters")]
        public void Verify_GetIssueWriterByKey_Should_ReturnAnIssueWriterModel()
        {
            var service = AppHost.Container.Resolve<IIssueWritersServices>();
            var response = service.Any(new GetIssueWriterByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IIssueWriterModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "IssueWriters")]
        public void Verify_CreateIssueWriter_Should_ReturnAnIssueWriterModel()
        {
            var service = AppHost.Container.Resolve<IIssueWritersServices>();
            var response = service.Any(new CreateIssueWriter { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IIssueWriterModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "IssueWriters")]
        public void Verify_UpdateIssueWriter_Should_ReturnAnIssueWriterModel()
        {
            var service = AppHost.Container.Resolve<IIssueWritersServices>();
            var response = service.Any(new UpdateIssueWriter { Id = 1 });
            Assert.Equal(nameof(IIssueWriterModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "IssueWriters")]
        public void Verify_DeactivateIssueWriter_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IIssueWritersServices>();
            var response = service.Any(new DeactivateIssueWriter { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "IssueWriters")]
        public void Verify_DeactivateIssueWriterByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IIssueWritersServices>();
            var response = service.Any(new DeactivateIssueWriterByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "IssueWriters")]
        public void Verify_RemoveIssueWriter_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IIssueWritersServices>();
            var response = service.Any(new RemoveIssueWriter { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "IssueWriters")]
        public void Verify_RemoveIssueWriterByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IIssueWritersServices>();
            var response = service.Any(new RemoveIssueWriterByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
