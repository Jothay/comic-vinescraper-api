// <auto-generated>
// <copyright file="Issues.IIssueWriterServices.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the IssueWriter ServiceStack DTOs and Handlers.</summary>
// <remarks>This file was auto-generated using ServiceFileMaster.tt in
// ComicVineScraper.API.Services\Framework\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Services//.Issues
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class IssueWriterModelBase : NameableEntityModelBase, IIssueWriterModel
    {
        // IssueWriter Properties
        // <None>
        // Related Objects
        public int IssueId { get; set; }
        public IIssueModel Issue { get; set; }
        public int WriterId { get; set; }
        public IPersonModel Writer { get; set; }
        // Associated Objects
        // <None>
    }
    public class IssueWriterSearchModelBase : NameableEntitySearchModelBase, IIssueWriterSearchModel
    {
        [ApiMember(Name = "IssueId", IsRequired = false, Description = "Filter by the Related IssueId")]
        public int? IssueId { get; set; }

        [ApiMember(Name = "IssueCustomKey", IsRequired = false, Description = "Filter by the Related Issue CustomKey (Equals, Case-Insensitive)")]
        public string IssueCustomKey { get; set; }

        [ApiMember(Name = "IssueApiDetailUrl", IsRequired = false, Description = "Filter by the Related Issue Api Detail Url (Contains, Case-Insensitive)")]
        public string IssueApiDetailUrl { get; set; }

        [ApiMember(Name = "IssueSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Issue Site Detail Url (Contains, Case-Insensitive)")]
        public string IssueSiteDetailUrl { get; set; }

        [ApiMember(Name = "IssueName", IsRequired = false, Description = "Filter by the Related Issue Name (Contains, Case-Insensitive)")]
        public string IssueName { get; set; }

        [ApiMember(Name = "IssueShortDescription", IsRequired = false, Description = "Filter by the Related Issue Short Description (Contains, Case-Insensitive)")]
        public string IssueShortDescription { get; set; }

        [ApiMember(Name = "IssueDescription", IsRequired = false, Description = "Filter by the Related Issue Description (Contains, Case-Insensitive)")]
        public string IssueDescription { get; set; }

        [ApiMember(Name = "WriterId", IsRequired = false, Description = "Filter by the Related WriterId")]
        public int? WriterId { get; set; }

        [ApiMember(Name = "WriterCustomKey", IsRequired = false, Description = "Filter by the Related Writer CustomKey (Equals, Case-Insensitive)")]
        public string WriterCustomKey { get; set; }

        [ApiMember(Name = "WriterApiDetailUrl", IsRequired = false, Description = "Filter by the Related Writer Api Detail Url (Contains, Case-Insensitive)")]
        public string WriterApiDetailUrl { get; set; }

        [ApiMember(Name = "WriterSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Writer Site Detail Url (Contains, Case-Insensitive)")]
        public string WriterSiteDetailUrl { get; set; }

        [ApiMember(Name = "WriterName", IsRequired = false, Description = "Filter by the Related Writer Name (Contains, Case-Insensitive)")]
        public string WriterName { get; set; }

        [ApiMember(Name = "WriterShortDescription", IsRequired = false, Description = "Filter by the Related Writer Short Description (Contains, Case-Insensitive)")]
        public string WriterShortDescription { get; set; }

        [ApiMember(Name = "WriterDescription", IsRequired = false, Description = "Filter by the Related Writer Description (Contains, Case-Insensitive)")]
        public string WriterDescription { get; set; }

    }

    [Route("/IssueWriters/", "GET", Summary = "Gets All Active IssueWriters")]
    public class GetIssueWriters : IssueWriterSearchModelBase, IReturn<List<IIssueWriterModel>> { }

    [Route("/IssueWriters/Listing", "GET", Summary = "Gets All Active IssueWriters with the mininum header information")]
    public class GetIssueWritersAsListing : IssueWriterSearchModelBase, IReturn<List<IIssueWriterModel>> { }

    [Route("/IssueWriters/{ID}", "GET", Summary = "Gets IssueWriter by Identifier")]
    public class GetIssueWriter : ImplementsID, IReturn<IIssueWriterModel> { }

    [Route("/IssueWriters/{CustomKey}/ByKey", "GET", Summary = "Gets IssueWriter by Key")]
    public class GetIssueWriterByKey : ImplementsKey, IReturn<IIssueWriterModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/IssueWriters/Create", "POST", Summary = "Creates an IssueWriter with these contents")]
    public class CreateIssueWriter : IssueWriterModelBase, IReturn<IIssueWriterModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/IssueWriters/Update", "POST", Summary = "Updates an IssueWriter with new contents")]
    public class UpdateIssueWriter : IssueWriterModelBase, IReturn<IIssueWriterModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/IssueWriters/{ID}/Deactivate", "POST", Summary = "Deactivates an IssueWriter by Identifier")]
    public class DeactivateIssueWriter : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/IssueWriters/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an IssueWriter by Key")]
    public class DeactivateIssueWriterByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/IssueWriters/{ID}/Remove", "POST", Summary = "Removes an IssueWriter by Identifier")]
    public class RemoveIssueWriter : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/IssueWriters/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an IssueWriter by Key")]
    public class RemoveIssueWriterByKey : ImplementsKey, IReturn<bool> { }

    public interface IIssueWritersServices
    {
        List<IIssueWriterModel> Any(GetIssueWriters request);
        List<IIssueWriterModel> Any(GetIssueWritersAsListing request);
        IIssueWriterModel Any(GetIssueWriter request);
        IIssueWriterModel Any(GetIssueWriterByKey request);
        IIssueWriterModel Any(CreateIssueWriter request);
        IIssueWriterModel Any(UpdateIssueWriter request);
        bool Any(DeactivateIssueWriter request);
        bool Any(DeactivateIssueWriterByKey request);
        bool Any(RemoveIssueWriter request);
        bool Any(RemoveIssueWriterByKey request);
    }

    public class IssueWritersServices : Service, IIssueWritersServices
    {
        private readonly IIssueWritersBusinessWorkflow workflow;

        public IssueWritersServices(IIssueWritersBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IIssueWriterModel> Any(GetIssueWriters request) { return workflow.Search(request); }
        public List<IIssueWriterModel> Any(GetIssueWritersAsListing request) { return workflow.Search(request, true); }
        public IIssueWriterModel Any(GetIssueWriter request) { return workflow.Get(request.ID); }
        public IIssueWriterModel Any(GetIssueWriterByKey request) { return workflow.Get(request.CustomKey); }
        public IIssueWriterModel Any(CreateIssueWriter request) { return workflow.Create(request); }
        public IIssueWriterModel Any(UpdateIssueWriter request) { return workflow.Update(request); }
        public bool Any(DeactivateIssueWriter request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateIssueWriterByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveIssueWriter request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveIssueWriterByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
