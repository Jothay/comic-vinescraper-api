// <auto-generated>
// <copyright file="Objects.IObjectAppearedInIssueModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectAppearedInIssue model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Objects
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class ObjectAppearedInIssueModelBase : NameableEntityModelBase, IObjectAppearedInIssueModel
    {
        // ObjectAppearedInIssue Properties
        // <None>
        // Related Objects
        public int ObjectId { get; set; }
        public IObjectModel Object { get; set; }
        public int AppearedInIssueId { get; set; }
        public IIssueModel AppearedInIssue { get; set; }
        // Associated Objects
        // <None>
    }
    public class ObjectAppearedInIssueSearchModelBase : NameableEntitySearchModelBase, IObjectAppearedInIssueSearchModel
    {
        [ApiMember(Name = "ObjectId", IsRequired = false, Description = "Filter by the Related ObjectId")]
        public int? ObjectId { get; set; }

        [ApiMember(Name = "ObjectCustomKey", IsRequired = false, Description = "Filter by the Related Object CustomKey (Equals, Case-Insensitive)")]
        public string ObjectCustomKey { get; set; }

        [ApiMember(Name = "ObjectApiDetailUrl", IsRequired = false, Description = "Filter by the Related Object Api Detail Url (Contains, Case-Insensitive)")]
        public string ObjectApiDetailUrl { get; set; }

        [ApiMember(Name = "ObjectSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Object Site Detail Url (Contains, Case-Insensitive)")]
        public string ObjectSiteDetailUrl { get; set; }

        [ApiMember(Name = "ObjectName", IsRequired = false, Description = "Filter by the Related Object Name (Contains, Case-Insensitive)")]
        public string ObjectName { get; set; }

        [ApiMember(Name = "ObjectShortDescription", IsRequired = false, Description = "Filter by the Related Object Short Description (Contains, Case-Insensitive)")]
        public string ObjectShortDescription { get; set; }

        [ApiMember(Name = "ObjectDescription", IsRequired = false, Description = "Filter by the Related Object Description (Contains, Case-Insensitive)")]
        public string ObjectDescription { get; set; }

        [ApiMember(Name = "AppearedInIssueId", IsRequired = false, Description = "Filter by the Related AppearedInIssueId")]
        public int? AppearedInIssueId { get; set; }

        [ApiMember(Name = "AppearedInIssueCustomKey", IsRequired = false, Description = "Filter by the Related AppearedInIssue CustomKey (Equals, Case-Insensitive)")]
        public string AppearedInIssueCustomKey { get; set; }

        [ApiMember(Name = "AppearedInIssueApiDetailUrl", IsRequired = false, Description = "Filter by the Related AppearedInIssue Api Detail Url (Contains, Case-Insensitive)")]
        public string AppearedInIssueApiDetailUrl { get; set; }

        [ApiMember(Name = "AppearedInIssueSiteDetailUrl", IsRequired = false, Description = "Filter by the Related AppearedInIssue Site Detail Url (Contains, Case-Insensitive)")]
        public string AppearedInIssueSiteDetailUrl { get; set; }

        [ApiMember(Name = "AppearedInIssueName", IsRequired = false, Description = "Filter by the Related AppearedInIssue Name (Contains, Case-Insensitive)")]
        public string AppearedInIssueName { get; set; }

        [ApiMember(Name = "AppearedInIssueShortDescription", IsRequired = false, Description = "Filter by the Related AppearedInIssue Short Description (Contains, Case-Insensitive)")]
        public string AppearedInIssueShortDescription { get; set; }

        [ApiMember(Name = "AppearedInIssueDescription", IsRequired = false, Description = "Filter by the Related AppearedInIssue Description (Contains, Case-Insensitive)")]
        public string AppearedInIssueDescription { get; set; }

    }

    [Route("/ObjectAppearedInIssues/", "GET", Summary = "Gets All Active ObjectAppearedInIssues")]
    public class GetObjectAppearedInIssues : ObjectAppearedInIssueSearchModelBase, IReturn<List<IObjectAppearedInIssueModel>> { }

    [Route("/ObjectAppearedInIssues/Listing", "GET", Summary = "Gets All Active ObjectAppearedInIssues with the mininum header information")]
    public class GetObjectAppearedInIssuesAsListing : ObjectAppearedInIssueSearchModelBase, IReturn<List<IObjectAppearedInIssueModel>> { }

    [Route("/ObjectAppearedInIssues/{ID}", "GET", Summary = "Gets ObjectAppearedInIssue by Identifier")]
    public class GetObjectAppearedInIssue : ImplementsID, IReturn<IObjectAppearedInIssueModel> { }

    [Route("/ObjectAppearedInIssues/{CustomKey}/ByKey", "GET", Summary = "Gets ObjectAppearedInIssue by Key")]
    public class GetObjectAppearedInIssueByKey : ImplementsKey, IReturn<IObjectAppearedInIssueModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ObjectAppearedInIssues/Create", "POST", Summary = "Creates an ObjectAppearedInIssue with these contents")]
    public class CreateObjectAppearedInIssue : ObjectAppearedInIssueModelBase, IReturn<IObjectAppearedInIssueModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ObjectAppearedInIssues/Update", "POST", Summary = "Updates an ObjectAppearedInIssue with new contents")]
    public class UpdateObjectAppearedInIssue : ObjectAppearedInIssueModelBase, IReturn<IObjectAppearedInIssueModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ObjectAppearedInIssues/{ID}/Deactivate", "POST", Summary = "Deactivates an ObjectAppearedInIssue by Identifier")]
    public class DeactivateObjectAppearedInIssue : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ObjectAppearedInIssues/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an ObjectAppearedInIssue by Key")]
    public class DeactivateObjectAppearedInIssueByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ObjectAppearedInIssues/{ID}/Remove", "POST", Summary = "Removes an ObjectAppearedInIssue by Identifier")]
    public class RemoveObjectAppearedInIssue : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ObjectAppearedInIssues/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an ObjectAppearedInIssue by Key")]
    public class RemoveObjectAppearedInIssueByKey : ImplementsKey, IReturn<bool> { }

    public interface IObjectAppearedInIssuesServices
    {
        List<IObjectAppearedInIssueModel> Any(GetObjectAppearedInIssues request);
        List<IObjectAppearedInIssueModel> Any(GetObjectAppearedInIssuesAsListing request);
        IObjectAppearedInIssueModel Any(GetObjectAppearedInIssue request);
        IObjectAppearedInIssueModel Any(GetObjectAppearedInIssueByKey request);
        IObjectAppearedInIssueModel Any(CreateObjectAppearedInIssue request);
        IObjectAppearedInIssueModel Any(UpdateObjectAppearedInIssue request);
        bool Any(DeactivateObjectAppearedInIssue request);
        bool Any(DeactivateObjectAppearedInIssueByKey request);
        bool Any(RemoveObjectAppearedInIssue request);
        bool Any(RemoveObjectAppearedInIssueByKey request);
    }

    public class ObjectAppearedInIssuesServices : Service, IObjectAppearedInIssuesServices
    {
        private readonly IObjectAppearedInIssuesBusinessWorkflow workflow;

        public ObjectAppearedInIssuesServices(IObjectAppearedInIssuesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IObjectAppearedInIssueModel> Any(GetObjectAppearedInIssues request) { return workflow.Search(request); }
        public List<IObjectAppearedInIssueModel> Any(GetObjectAppearedInIssuesAsListing request) { return workflow.Search(request, true); }
        public IObjectAppearedInIssueModel Any(GetObjectAppearedInIssue request) { return workflow.Get(request.ID); }
        public IObjectAppearedInIssueModel Any(GetObjectAppearedInIssueByKey request) { return workflow.Get(request.CustomKey); }
        public IObjectAppearedInIssueModel Any(CreateObjectAppearedInIssue request) { return workflow.Create(request); }
        public IObjectAppearedInIssueModel Any(UpdateObjectAppearedInIssue request) { return workflow.Update(request); }
        public bool Any(DeactivateObjectAppearedInIssue request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateObjectAppearedInIssueByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveObjectAppearedInIssue request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveObjectAppearedInIssueByKey request) { return workflow.Remove(request.CustomKey); }
    }
}