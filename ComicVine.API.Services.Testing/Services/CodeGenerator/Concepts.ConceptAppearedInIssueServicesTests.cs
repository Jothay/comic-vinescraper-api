// <auto-generated>
// <copyright file="Concepts.IConceptAppearedInIssueServices.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ConceptAppearedInIssuesRepository Class.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in ComicVine.API.Services.Testing\Services\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Services//.Concepts
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class ConceptAppearedInIssuesMockingSetup
    {
        public static Mock<IConceptAppearedInIssuesBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockConceptAppearedInIssuesBusinessWorkflow = new Mock<IConceptAppearedInIssuesBusinessWorkflow>();
            // Mock Functions
            mockConceptAppearedInIssuesBusinessWorkflow.Setup(m => m.Search(It.IsAny<IConceptAppearedInIssueSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IConceptAppearedInIssueModel>());
            mockConceptAppearedInIssuesBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IConceptAppearedInIssueModel>().Object);
            mockConceptAppearedInIssuesBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IConceptAppearedInIssueModel>().Object);
            mockConceptAppearedInIssuesBusinessWorkflow.Setup(m => m.Create(It.IsAny<IConceptAppearedInIssueModel>())).Returns(() => new Mock<IConceptAppearedInIssueModel>().Object);
            mockConceptAppearedInIssuesBusinessWorkflow.Setup(m => m.Update(It.IsAny<IConceptAppearedInIssueModel>())).Returns(() => new Mock<IConceptAppearedInIssueModel>().Object);
            mockConceptAppearedInIssuesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockConceptAppearedInIssuesBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockConceptAppearedInIssuesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockConceptAppearedInIssuesBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockConceptAppearedInIssuesBusinessWorkflow;
        }
    }

    //public class ConceptAppearedInIssuesServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "ConceptAppearedInIssues")]
        public void Verify_GetConceptAppearedInIssues_Should_ReturnAListOfConceptAppearedInIssueModels()
        {
            var service = AppHost.Container.Resolve<IConceptAppearedInIssuesServices>();
            var response = service.Any(new GetConceptAppearedInIssues { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IConceptAppearedInIssueModel>>(response);
        }
        [Fact][Trait("Category", "ConceptAppearedInIssues")]
        public void Verify_GetConceptAppearedInIssuesAsListing_Should_ReturnAListOfConceptAppearedInIssueModels()
        {
            var service = AppHost.Container.Resolve<IConceptAppearedInIssuesServices>();
            var response = service.Any(new GetConceptAppearedInIssuesAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IConceptAppearedInIssueModel>>(response);
        }
        [Fact][Trait("Category", "ConceptAppearedInIssues")]
        public void Verify_GetConceptAppearedInIssue_Should_ReturnAnConceptAppearedInIssueModel()
        {
            var service = AppHost.Container.Resolve<IConceptAppearedInIssuesServices>();
            var response = service.Any(new GetConceptAppearedInIssue { ID = 1 });
            Assert.Equal(nameof(IConceptAppearedInIssueModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "ConceptAppearedInIssues")]
        public void Verify_GetConceptAppearedInIssueByKey_Should_ReturnAnConceptAppearedInIssueModel()
        {
            var service = AppHost.Container.Resolve<IConceptAppearedInIssuesServices>();
            var response = service.Any(new GetConceptAppearedInIssueByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IConceptAppearedInIssueModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "ConceptAppearedInIssues")]
        public void Verify_CreateConceptAppearedInIssue_Should_ReturnAnConceptAppearedInIssueModel()
        {
            var service = AppHost.Container.Resolve<IConceptAppearedInIssuesServices>();
            var response = service.Any(new CreateConceptAppearedInIssue { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IConceptAppearedInIssueModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "ConceptAppearedInIssues")]
        public void Verify_UpdateConceptAppearedInIssue_Should_ReturnAnConceptAppearedInIssueModel()
        {
            var service = AppHost.Container.Resolve<IConceptAppearedInIssuesServices>();
            var response = service.Any(new UpdateConceptAppearedInIssue { Id = 1 });
            Assert.Equal(nameof(IConceptAppearedInIssueModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "ConceptAppearedInIssues")]
        public void Verify_DeactivateConceptAppearedInIssue_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IConceptAppearedInIssuesServices>();
            var response = service.Any(new DeactivateConceptAppearedInIssue { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "ConceptAppearedInIssues")]
        public void Verify_DeactivateConceptAppearedInIssueByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IConceptAppearedInIssuesServices>();
            var response = service.Any(new DeactivateConceptAppearedInIssueByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "ConceptAppearedInIssues")]
        public void Verify_RemoveConceptAppearedInIssue_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IConceptAppearedInIssuesServices>();
            var response = service.Any(new RemoveConceptAppearedInIssue { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "ConceptAppearedInIssues")]
        public void Verify_RemoveConceptAppearedInIssueByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IConceptAppearedInIssuesServices>();
            var response = service.Any(new RemoveConceptAppearedInIssueByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
