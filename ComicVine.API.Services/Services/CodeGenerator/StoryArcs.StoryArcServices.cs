// <auto-generated>
// <copyright file="StoryArcs.IStoryArcModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the StoryArc model interfaces.</summary>
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
    using ServiceStack.DataAnnotations;

    public class StoryArcModelBase : NameableEntityModelBase, IStoryArcModel
    {
        // StoryArc Properties
        // <None>
        // Related Objects
        public int PrimaryImageFileId { get; set; }
        public IImageFileModel PrimaryImageFile { get; set; }
        public int FirstIssueAppearanceId { get; set; }
        public IIssueModel FirstIssueAppearance { get; set; }
        public int PublisherId { get; set; }
        public IPublisherModel Publisher { get; set; }
        // Associated Objects
        public List<IMovieStoryArcModel> MovieStoryArcs { get; set; }
        public List<IStoryArcAliasModel> StoryArcAliases { get; set; }
        public List<IStoryArcIssueModel> StoryArcIssues { get; set; }
        public List<IStoryArcWriterModel> StoryArcsWritten { get; set; }
    }
    public class StoryArcSearchModelBase : NameableEntitySearchModelBase, IStoryArcSearchModel
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

        [ApiMember(Name = "FirstIssueAppearanceId", IsRequired = false, Description = "Filter by the Related FirstIssueAppearanceId")]
        public int? FirstIssueAppearanceId { get; set; }

        [ApiMember(Name = "FirstIssueAppearanceCustomKey", IsRequired = false, Description = "Filter by the Related FirstIssueAppearance CustomKey (Equals, Case-Insensitive)")]
        public string FirstIssueAppearanceCustomKey { get; set; }

        [ApiMember(Name = "FirstIssueAppearanceApiDetailUrl", IsRequired = false, Description = "Filter by the Related FirstIssueAppearance Api Detail Url (Contains, Case-Insensitive)")]
        public string FirstIssueAppearanceApiDetailUrl { get; set; }

        [ApiMember(Name = "FirstIssueAppearanceSiteDetailUrl", IsRequired = false, Description = "Filter by the Related FirstIssueAppearance Site Detail Url (Contains, Case-Insensitive)")]
        public string FirstIssueAppearanceSiteDetailUrl { get; set; }

        [ApiMember(Name = "FirstIssueAppearanceName", IsRequired = false, Description = "Filter by the Related FirstIssueAppearance Name (Contains, Case-Insensitive)")]
        public string FirstIssueAppearanceName { get; set; }

        [ApiMember(Name = "FirstIssueAppearanceShortDescription", IsRequired = false, Description = "Filter by the Related FirstIssueAppearance Short Description (Contains, Case-Insensitive)")]
        public string FirstIssueAppearanceShortDescription { get; set; }

        [ApiMember(Name = "FirstIssueAppearanceDescription", IsRequired = false, Description = "Filter by the Related FirstIssueAppearance Description (Contains, Case-Insensitive)")]
        public string FirstIssueAppearanceDescription { get; set; }

        [ApiMember(Name = "PublisherId", IsRequired = false, Description = "Filter by the Related PublisherId")]
        public int? PublisherId { get; set; }

        [ApiMember(Name = "PublisherCustomKey", IsRequired = false, Description = "Filter by the Related Publisher CustomKey (Equals, Case-Insensitive)")]
        public string PublisherCustomKey { get; set; }

        [ApiMember(Name = "PublisherApiDetailUrl", IsRequired = false, Description = "Filter by the Related Publisher Api Detail Url (Contains, Case-Insensitive)")]
        public string PublisherApiDetailUrl { get; set; }

        [ApiMember(Name = "PublisherSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Publisher Site Detail Url (Contains, Case-Insensitive)")]
        public string PublisherSiteDetailUrl { get; set; }

        [ApiMember(Name = "PublisherName", IsRequired = false, Description = "Filter by the Related Publisher Name (Contains, Case-Insensitive)")]
        public string PublisherName { get; set; }

        [ApiMember(Name = "PublisherShortDescription", IsRequired = false, Description = "Filter by the Related Publisher Short Description (Contains, Case-Insensitive)")]
        public string PublisherShortDescription { get; set; }

        [ApiMember(Name = "PublisherDescription", IsRequired = false, Description = "Filter by the Related Publisher Description (Contains, Case-Insensitive)")]
        public string PublisherDescription { get; set; }

    }

    [Route("/StoryArcs/", "GET", Summary = "Gets All Active StoryArcs")]
    public class GetStoryArcs : StoryArcSearchModelBase, IReturn<List<IStoryArcModel>> { }

    [Route("/StoryArcs/Listing", "GET", Summary = "Gets All Active StoryArcs with the mininum header information")]
    public class GetStoryArcsAsListing : StoryArcSearchModelBase, IReturn<List<IStoryArcModel>> { }

    [Route("/StoryArcs/{ID}", "GET", Summary = "Gets StoryArc by Identifier")]
    public class GetStoryArc : ImplementsID, IReturn<IStoryArcModel> { }

    [Route("/StoryArcs/{CustomKey}/ByKey", "GET", Summary = "Gets StoryArc by Key")]
    public class GetStoryArcByKey : ImplementsKey, IReturn<IStoryArcModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/StoryArcs/Create", "POST", Summary = "Creates an StoryArc with these contents")]
    public class CreateStoryArc : StoryArcModelBase, IReturn<IStoryArcModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/StoryArcs/Update", "POST", Summary = "Updates an StoryArc with new contents")]
    public class UpdateStoryArc : StoryArcModelBase, IReturn<IStoryArcModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/StoryArcs/{ID}/Deactivate", "POST", Summary = "Deactivates an StoryArc by Identifier")]
    public class DeactivateStoryArc : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/StoryArcs/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an StoryArc by Key")]
    public class DeactivateStoryArcByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/StoryArcs/{ID}/Remove", "POST", Summary = "Removes an StoryArc by Identifier")]
    public class RemoveStoryArc : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/StoryArcs/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an StoryArc by Key")]
    public class RemoveStoryArcByKey : ImplementsKey, IReturn<bool> { }

    public interface IStoryArcsServices
    {
        List<IStoryArcModel> Any(GetStoryArcs request);
        List<IStoryArcModel> Any(GetStoryArcsAsListing request);
        IStoryArcModel Any(GetStoryArc request);
        IStoryArcModel Any(GetStoryArcByKey request);
        IStoryArcModel Any(CreateStoryArc request);
        IStoryArcModel Any(UpdateStoryArc request);
        bool Any(DeactivateStoryArc request);
        bool Any(DeactivateStoryArcByKey request);
        bool Any(RemoveStoryArc request);
        bool Any(RemoveStoryArcByKey request);
    }

    public class StoryArcsServices : Service, IStoryArcsServices
    {
        private readonly IStoryArcsBusinessWorkflow workflow;

        public StoryArcsServices(IStoryArcsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IStoryArcModel> Any(GetStoryArcs request) { return workflow.Search(request); }
        public List<IStoryArcModel> Any(GetStoryArcsAsListing request) { return workflow.Search(request, true); }
        public IStoryArcModel Any(GetStoryArc request) { return workflow.Get(request.ID); }
        public IStoryArcModel Any(GetStoryArcByKey request) { return workflow.Get(request.CustomKey); }
        public IStoryArcModel Any(CreateStoryArc request) { return workflow.Create(request); }
        public IStoryArcModel Any(UpdateStoryArc request) { return workflow.Update(request); }
        public bool Any(DeactivateStoryArc request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateStoryArcByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveStoryArc request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveStoryArcByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
