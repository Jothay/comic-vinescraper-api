// <auto-generated>
// <copyright file="Locations.ILocationIssueServices.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the LocationIssue ServiceStack DTOs and Handlers.</summary>
// <remarks>This file was auto-generated using ServiceFileMaster.tt in
// ComicVineScraper.API.Services\Framework\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Services//.Locations
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class LocationIssueModelBase : NameableEntityModelBase, ILocationIssueModel
    {
        // LocationIssue Properties
        // <None>
        // Related Objects
        public int LocationId { get; set; }
        public ILocationModel Location { get; set; }
        public int IssueId { get; set; }
        public IIssueModel Issue { get; set; }
        // Associated Objects
        // <None>
    }
    public class LocationIssueSearchModelBase : NameableEntitySearchModelBase, ILocationIssueSearchModel
    {
        [ApiMember(Name = "LocationId", IsRequired = false, Description = "Filter by the Related LocationId")]
        public int? LocationId { get; set; }

        [ApiMember(Name = "LocationCustomKey", IsRequired = false, Description = "Filter by the Related Location CustomKey (Equals, Case-Insensitive)")]
        public string LocationCustomKey { get; set; }

        [ApiMember(Name = "LocationApiDetailUrl", IsRequired = false, Description = "Filter by the Related Location Api Detail Url (Contains, Case-Insensitive)")]
        public string LocationApiDetailUrl { get; set; }

        [ApiMember(Name = "LocationSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Location Site Detail Url (Contains, Case-Insensitive)")]
        public string LocationSiteDetailUrl { get; set; }

        [ApiMember(Name = "LocationName", IsRequired = false, Description = "Filter by the Related Location Name (Contains, Case-Insensitive)")]
        public string LocationName { get; set; }

        [ApiMember(Name = "LocationShortDescription", IsRequired = false, Description = "Filter by the Related Location Short Description (Contains, Case-Insensitive)")]
        public string LocationShortDescription { get; set; }

        [ApiMember(Name = "LocationDescription", IsRequired = false, Description = "Filter by the Related Location Description (Contains, Case-Insensitive)")]
        public string LocationDescription { get; set; }

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

    [Route("/LocationIssues/", "GET", Summary = "Gets All Active LocationIssues")]
    public class GetLocationIssues : LocationIssueSearchModelBase, IReturn<List<ILocationIssueModel>> { }

    [Route("/LocationIssues/Listing", "GET", Summary = "Gets All Active LocationIssues with the mininum header information")]
    public class GetLocationIssuesAsListing : LocationIssueSearchModelBase, IReturn<List<ILocationIssueModel>> { }

    [Route("/LocationIssues/{ID}", "GET", Summary = "Gets LocationIssue by Identifier")]
    public class GetLocationIssue : ImplementsID, IReturn<ILocationIssueModel> { }

    [Route("/LocationIssues/{CustomKey}/ByKey", "GET", Summary = "Gets LocationIssue by Key")]
    public class GetLocationIssueByKey : ImplementsKey, IReturn<ILocationIssueModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/LocationIssues/Create", "POST", Summary = "Creates an LocationIssue with these contents")]
    public class CreateLocationIssue : LocationIssueModelBase, IReturn<ILocationIssueModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/LocationIssues/Update", "POST", Summary = "Updates an LocationIssue with new contents")]
    public class UpdateLocationIssue : LocationIssueModelBase, IReturn<ILocationIssueModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/LocationIssues/{ID}/Deactivate", "POST", Summary = "Deactivates an LocationIssue by Identifier")]
    public class DeactivateLocationIssue : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/LocationIssues/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an LocationIssue by Key")]
    public class DeactivateLocationIssueByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/LocationIssues/{ID}/Remove", "POST", Summary = "Removes an LocationIssue by Identifier")]
    public class RemoveLocationIssue : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/LocationIssues/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an LocationIssue by Key")]
    public class RemoveLocationIssueByKey : ImplementsKey, IReturn<bool> { }

    public interface ILocationIssuesServices
    {
        List<ILocationIssueModel> Any(GetLocationIssues request);
        List<ILocationIssueModel> Any(GetLocationIssuesAsListing request);
        ILocationIssueModel Any(GetLocationIssue request);
        ILocationIssueModel Any(GetLocationIssueByKey request);
        ILocationIssueModel Any(CreateLocationIssue request);
        ILocationIssueModel Any(UpdateLocationIssue request);
        bool Any(DeactivateLocationIssue request);
        bool Any(DeactivateLocationIssueByKey request);
        bool Any(RemoveLocationIssue request);
        bool Any(RemoveLocationIssueByKey request);
    }

    public class LocationIssuesServices : Service, ILocationIssuesServices
    {
        private readonly ILocationIssuesBusinessWorkflow workflow;

        public LocationIssuesServices(ILocationIssuesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ILocationIssueModel> Any(GetLocationIssues request) { return workflow.Search(request); }
        public List<ILocationIssueModel> Any(GetLocationIssuesAsListing request) { return workflow.Search(request, true); }
        public ILocationIssueModel Any(GetLocationIssue request) { return workflow.Get(request.ID); }
        public ILocationIssueModel Any(GetLocationIssueByKey request) { return workflow.Get(request.CustomKey); }
        public ILocationIssueModel Any(CreateLocationIssue request) { return workflow.Create(request); }
        public ILocationIssueModel Any(UpdateLocationIssue request) { return workflow.Update(request); }
        public bool Any(DeactivateLocationIssue request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateLocationIssueByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveLocationIssue request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveLocationIssueByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
