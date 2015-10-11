// <auto-generated>
// <copyright file="StoryArcs.IStoryArcIssueModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the StoryArcIssue model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.StoryArcs
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;

    public class StoryArcIssueModelBase : NameableEntityModelBase, IStoryArcIssueModel
    {
        // StoryArcIssue Properties
        // <None>
        // Related Objects
        public int StoryArcId { get; set; }
        public IStoryArcModel StoryArc { get; set; }
        public int IssueId { get; set; }
        public IIssueModel Issue { get; set; }
        // Associated Objects
        // <None>
    }
    public class StoryArcIssueSearchModelBase : NameableEntitySearchModelBase, IStoryArcIssueSearchModel
    {
        [ApiMember(Name = "StoryArcId", IsRequired = false, Description = "Filter by the Related StoryArcId")]
        public int? StoryArcId { get; set; }

        [ApiMember(Name = "StoryArcCustomKey", IsRequired = false, Description = "Filter by the Related StoryArc CustomKey (Equals, Case-Insensitive)")]
        public string StoryArcCustomKey { get; set; }

        [ApiMember(Name = "StoryArcApiDetailUrl", IsRequired = false, Description = "Filter by the Related StoryArc Api Detail Url (Contains, Case-Insensitive)")]
        public string StoryArcApiDetailUrl { get; set; }

        [ApiMember(Name = "StoryArcSiteDetailUrl", IsRequired = false, Description = "Filter by the Related StoryArc Site Detail Url (Contains, Case-Insensitive)")]
        public string StoryArcSiteDetailUrl { get; set; }

        [ApiMember(Name = "StoryArcName", IsRequired = false, Description = "Filter by the Related StoryArc Name (Contains, Case-Insensitive)")]
        public string StoryArcName { get; set; }

        [ApiMember(Name = "StoryArcShortDescription", IsRequired = false, Description = "Filter by the Related StoryArc Short Description (Contains, Case-Insensitive)")]
        public string StoryArcShortDescription { get; set; }

        [ApiMember(Name = "StoryArcDescription", IsRequired = false, Description = "Filter by the Related StoryArc Description (Contains, Case-Insensitive)")]
        public string StoryArcDescription { get; set; }

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

    }

    [Route("/StoryArcIssues/", "GET", Summary = "Gets All Active StoryArcIssues")]
    public class GetStoryArcIssues : StoryArcIssueSearchModelBase, IReturn<List<IStoryArcIssueModel>> { }

    [Route("/StoryArcIssues/Listing", "GET", Summary = "Gets All Active StoryArcIssues with the mininum header information")]
    public class GetStoryArcIssuesAsListing : StoryArcIssueSearchModelBase, IReturn<List<IStoryArcIssueModel>> { }

    [Route("/StoryArcIssues/{ID}", "GET", Summary = "Gets StoryArcIssue by Identifier")]
    public class GetStoryArcIssue : ImplementsID, IReturn<IStoryArcIssueModel> { }

    [Route("/StoryArcIssues/{CustomKey}/ByKey", "GET", Summary = "Gets StoryArcIssue by Key")]
    public class GetStoryArcIssueByKey : ImplementsKey, IReturn<IStoryArcIssueModel> { }

    //[Authenticate]
    [Route("/StoryArcIssues/Create", "POST", Summary = "Creates an StoryArcIssue with these contents")]
    public class CreateStoryArcIssue : StoryArcIssueModelBase, IReturn<IStoryArcIssueModel> { }

    //[Authenticate]
    [Route("/StoryArcIssues/Update", "POST", Summary = "Updates an StoryArcIssue with new contents")]
    public class UpdateStoryArcIssue : StoryArcIssueModelBase, IReturn<IStoryArcIssueModel> { }

    //[Authenticate]
    [Route("/StoryArcIssues/{ID}/Deactivate", "POST", Summary = "Deactivates an StoryArcIssue by Identifier")]
    public class DeactivateStoryArcIssue : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/StoryArcIssues/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an StoryArcIssue by Key")]
    public class DeactivateStoryArcIssueByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/StoryArcIssues/{ID}/Remove", "POST", Summary = "Removes an StoryArcIssue by Identifier")]
    public class RemoveStoryArcIssue : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/StoryArcIssues/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an StoryArcIssue by Key")]
    public class RemoveStoryArcIssueByKey : ImplementsKey, IReturn<bool> { }

    public interface IStoryArcIssuesServices
    {
        List<IStoryArcIssueModel> Any(GetStoryArcIssues request);
        List<IStoryArcIssueModel> Any(GetStoryArcIssuesAsListing request);
        IStoryArcIssueModel Any(GetStoryArcIssue request);
        IStoryArcIssueModel Any(GetStoryArcIssueByKey request);
        IStoryArcIssueModel Any(CreateStoryArcIssue request);
        IStoryArcIssueModel Any(UpdateStoryArcIssue request);
        bool Any(DeactivateStoryArcIssue request);
        bool Any(DeactivateStoryArcIssueByKey request);
        bool Any(RemoveStoryArcIssue request);
        bool Any(RemoveStoryArcIssueByKey request);
    }

    public class StoryArcIssuesServices : /*ServicesBase,*/ IStoryArcIssuesServices
    {
        private readonly IStoryArcIssuesBusinessWorkflow workflow;

        public StoryArcIssuesServices(IStoryArcIssuesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IStoryArcIssueModel> Any(GetStoryArcIssues request) { return workflow.Search(request); }
        public List<IStoryArcIssueModel> Any(GetStoryArcIssuesAsListing request) { return workflow.Search(request, true); }
        public IStoryArcIssueModel Any(GetStoryArcIssue request) { return workflow.Get(request.ID); }
        public IStoryArcIssueModel Any(GetStoryArcIssueByKey request) { return workflow.Get(request.CustomKey); }
        public IStoryArcIssueModel Any(CreateStoryArcIssue request) { return workflow.Create(request); }
        public IStoryArcIssueModel Any(UpdateStoryArcIssue request) { return workflow.Update(request); }
        public bool Any(DeactivateStoryArcIssue request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateStoryArcIssueByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveStoryArcIssue request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveStoryArcIssueByKey request) { return workflow.Remove(request.CustomKey); }
    }
}