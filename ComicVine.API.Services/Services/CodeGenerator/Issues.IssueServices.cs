// <auto-generated>
// <copyright file="Issues.IIssueModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Issue model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Issues
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;

    public class IssueModelBase : NameableEntityModelBase, IIssueModel
    {
        // Issue Properties
        public bool HasStaffReview { get; set; }
        public DateTime? CoverDate { get; set; }
        public DateTime? StoreDate { get; set; }
        public string IssueNumber { get; set; }
        // Related Objects
        public int? PrimaryImageFileId { get; set; }
        public IImageFileModel PrimaryImageFile { get; set; }
        public int? VolumeId { get; set; }
        public IVolumeModel Volume { get; set; }
        // Associated Objects
        public List<IIssueAliasModel> IssueAliases { get; set; }
        public List<IStoryArcIssueModel> IssueStoryArcs { get; set; }
        public List<IIssueWriterModel> IssueWriters { get; set; }
    }
    public class IssueSearchModelBase : NameableEntitySearchModelBase, IIssueSearchModel
    {
        [ApiMember(Name = "PrimaryImageFileId", IsRequired = false, Description = "Filter by the Related PrimaryImageFileId")]
        public int? PrimaryImageFileId { get; set; }

        [ApiMember(Name = "PrimaryImageFileCustomKey", IsRequired = false, Description = "Filter by the Related PrimaryImageFile CustomKey (Equals, Case-Insensitive)")]
        public string PrimaryImageFileCustomKey { get; set; }

        [ApiMember(Name = "PrimaryImageFileApiDetailUrl", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Api Detail Url (Contains, Case-Insensitive)")]
        public string PrimaryImageFileApiDetailUrl { get; set; }

        [ApiMember(Name = "PrimaryImageFileSiteDetailUrl", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Site Detail Url (Contains, Case-Insensitive)")]
        public string PrimaryImageFileSiteDetailUrl { get; set; }

        [ApiMember(Name = "PrimaryImageFileName", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Name (Contains, Case-Insensitive)")]
        public string PrimaryImageFileName { get; set; }

        [ApiMember(Name = "PrimaryImageFileShortDescription", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Short Description (Contains, Case-Insensitive)")]
        public string PrimaryImageFileShortDescription { get; set; }

        [ApiMember(Name = "PrimaryImageFileDescription", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Description (Contains, Case-Insensitive)")]
        public string PrimaryImageFileDescription { get; set; }

        [ApiMember(Name = "VolumeId", IsRequired = false, Description = "Filter by the Related VolumeId")]
        public int? VolumeId { get; set; }

        [ApiMember(Name = "VolumeCustomKey", IsRequired = false, Description = "Filter by the Related Volume CustomKey (Equals, Case-Insensitive)")]
        public string VolumeCustomKey { get; set; }

        [ApiMember(Name = "VolumeApiDetailUrl", IsRequired = false, Description = "Filter by the Related Volume Api Detail Url (Contains, Case-Insensitive)")]
        public string VolumeApiDetailUrl { get; set; }

        [ApiMember(Name = "VolumeSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Volume Site Detail Url (Contains, Case-Insensitive)")]
        public string VolumeSiteDetailUrl { get; set; }

        [ApiMember(Name = "VolumeName", IsRequired = false, Description = "Filter by the Related Volume Name (Contains, Case-Insensitive)")]
        public string VolumeName { get; set; }

        [ApiMember(Name = "VolumeShortDescription", IsRequired = false, Description = "Filter by the Related Volume Short Description (Contains, Case-Insensitive)")]
        public string VolumeShortDescription { get; set; }

        [ApiMember(Name = "VolumeDescription", IsRequired = false, Description = "Filter by the Related Volume Description (Contains, Case-Insensitive)")]
        public string VolumeDescription { get; set; }

        [ApiMember(Name = "HasStaffReview", IsRequired = false, Description = "The HasStaffReview to search by.")]
        public bool? HasStaffReview { get; set; }

    }

    [Route("/Issues/", "GET", Summary = "Gets All Active Issues")]
    public class GetIssues : IssueSearchModelBase, IReturn<List<IIssueModel>> { }

    [Route("/Issues/Listing", "GET", Summary = "Gets All Active Issues with the mininum header information")]
    public class GetIssuesAsListing : IssueSearchModelBase, IReturn<List<IIssueModel>> { }

    [Route("/Issues/{ID}", "GET", Summary = "Gets Issue by Identifier")]
    public class GetIssue : ImplementsID, IReturn<IIssueModel> { }

    [Route("/Issues/{CustomKey}/ByKey", "GET", Summary = "Gets Issue by Key")]
    public class GetIssueByKey : ImplementsKey, IReturn<IIssueModel> { }

    //[Authenticate]
    [Route("/Issues/Create", "POST", Summary = "Creates an Issue with these contents")]
    public class CreateIssue : IssueModelBase, IReturn<IIssueModel> { }

    //[Authenticate]
    [Route("/Issues/Update", "POST", Summary = "Updates an Issue with new contents")]
    public class UpdateIssue : IssueModelBase, IReturn<IIssueModel> { }

    //[Authenticate]
    [Route("/Issues/{ID}/Deactivate", "POST", Summary = "Deactivates an Issue by Identifier")]
    public class DeactivateIssue : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/Issues/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an Issue by Key")]
    public class DeactivateIssueByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/Issues/{ID}/Remove", "POST", Summary = "Removes an Issue by Identifier")]
    public class RemoveIssue : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/Issues/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an Issue by Key")]
    public class RemoveIssueByKey : ImplementsKey, IReturn<bool> { }

    public interface IIssuesServices
    {
        List<IIssueModel> Any(GetIssues request);
        List<IIssueModel> Any(GetIssuesAsListing request);
        IIssueModel Any(GetIssue request);
        IIssueModel Any(GetIssueByKey request);
        IIssueModel Any(CreateIssue request);
        IIssueModel Any(UpdateIssue request);
        bool Any(DeactivateIssue request);
        bool Any(DeactivateIssueByKey request);
        bool Any(RemoveIssue request);
        bool Any(RemoveIssueByKey request);
    }

    public class IssuesServices : /*ServicesBase,*/ IIssuesServices
    {
        private readonly IIssuesBusinessWorkflow workflow;

        public IssuesServices(IIssuesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IIssueModel> Any(GetIssues request) { return workflow.Search(request); }
        public List<IIssueModel> Any(GetIssuesAsListing request) { return workflow.Search(request, true); }
        public IIssueModel Any(GetIssue request) { return workflow.Get(request.ID); }
        public IIssueModel Any(GetIssueByKey request) { return workflow.Get(request.CustomKey); }
        public IIssueModel Any(CreateIssue request) { return workflow.Create(request); }
        public IIssueModel Any(UpdateIssue request) { return workflow.Update(request); }
        public bool Any(DeactivateIssue request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateIssueByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveIssue request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveIssueByKey request) { return workflow.Remove(request.CustomKey); }
    }
}