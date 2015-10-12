// <auto-generated>
// <copyright file="Issues.IIssueServices.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the IssuesRepository Class.</summary>
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

    public static class IssuesMockingSetup
    {
        public static Mock<IIssuesBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockIssuesBusinessWorkflow = new Mock<IIssuesBusinessWorkflow>();
            // Mock Functions
            mockIssuesBusinessWorkflow.Setup(m => m.Search(It.IsAny<IIssueSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IIssueModel>());
            mockIssuesBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IIssueModel>().Object);
            mockIssuesBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IIssueModel>().Object);
            mockIssuesBusinessWorkflow.Setup(m => m.Create(It.IsAny<IIssueModel>())).Returns(() => new Mock<IIssueModel>().Object);
            mockIssuesBusinessWorkflow.Setup(m => m.Update(It.IsAny<IIssueModel>())).Returns(() => new Mock<IIssueModel>().Object);
            mockIssuesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockIssuesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockIssuesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockIssuesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockIssuesBusinessWorkflow;
        }
    }

    //public class IssuesServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "Issues")]
        public void Verify_GetIssues_Should_ReturnAListOfIssueModels()
        {
            var service = AppHost.Container.Resolve<IIssuesServices>();
            var response = service.Any(new GetIssues { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = null, ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IIssueModel>>(response);
        }
        [Fact][Trait("Category", "Issues")]
        public void Verify_GetIssuesAsListing_Should_ReturnAListOfIssueModels()
        {
            var service = AppHost.Container.Resolve<IIssuesServices>();
            var response = service.Any(new GetIssuesAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = "famous", ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IIssueModel>>(response);
        }
        [Fact][Trait("Category", "Issues")]
        public void Verify_GetIssue_Should_ReturnAnIssueModel()
        {
            var service = AppHost.Container.Resolve<IIssuesServices>();
            var response = service.Any(new GetIssue { ID = 1 });
            Assert.Equal(nameof(IIssueModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Issues")]
        public void Verify_GetIssueByKey_Should_ReturnAnIssueModel()
        {
            var service = AppHost.Container.Resolve<IIssuesServices>();
            var response = service.Any(new GetIssueByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IIssueModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Issues")]
        public void Verify_CreateIssue_Should_ReturnAnIssueModel()
        {
            var service = AppHost.Container.Resolve<IIssuesServices>();
            var response = service.Any(new CreateIssue { Name = "Stephen King", CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IIssueModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Issues")]
        public void Verify_UpdateIssue_Should_ReturnAnIssueModel()
        {
            var service = AppHost.Container.Resolve<IIssuesServices>();
            var response = service.Any(new UpdateIssue { Id = 1 });
            Assert.Equal(nameof(IIssueModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Issues")]
        public void Verify_DeactivateIssue_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IIssuesServices>();
            var response = service.Any(new DeactivateIssue { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Issues")]
        public void Verify_DeactivateIssueByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IIssuesServices>();
            var response = service.Any(new DeactivateIssueByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Issues")]
        public void Verify_RemoveIssue_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IIssuesServices>();
            var response = service.Any(new RemoveIssue { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Issues")]
        public void Verify_RemoveIssueByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IIssuesServices>();
            var response = service.Any(new RemoveIssueByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}