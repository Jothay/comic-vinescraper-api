// <auto-generated>
// <copyright file="Episodes.IEpisodeStoryArcModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeStoryArc model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Episodes
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class EpisodeStoryArcModelBase : NameableEntityModelBase, IEpisodeStoryArcModel
    {
        // EpisodeStoryArc Properties
        // <None>
        // Related Objects
        public int EpisodeId { get; set; }
        public IEpisodeModel Episode { get; set; }
        public int StoryArcId { get; set; }
        public IStoryArcModel StoryArc { get; set; }
        // Associated Objects
        // <None>
    }
    public class EpisodeStoryArcSearchModelBase : NameableEntitySearchModelBase, IEpisodeStoryArcSearchModel
    {
        [ApiMember(Name = "EpisodeId", IsRequired = false, Description = "Filter by the Related EpisodeId")]
        public int? EpisodeId { get; set; }

        [ApiMember(Name = "EpisodeCustomKey", IsRequired = false, Description = "Filter by the Related Episode CustomKey (Equals, Case-Insensitive)")]
        public string EpisodeCustomKey { get; set; }

        [ApiMember(Name = "EpisodeApiDetailUrl", IsRequired = false, Description = "Filter by the Related Episode Api Detail Url (Contains, Case-Insensitive)")]
        public string EpisodeApiDetailUrl { get; set; }

        [ApiMember(Name = "EpisodeSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Episode Site Detail Url (Contains, Case-Insensitive)")]
        public string EpisodeSiteDetailUrl { get; set; }

        [ApiMember(Name = "EpisodeName", IsRequired = false, Description = "Filter by the Related Episode Name (Contains, Case-Insensitive)")]
        public string EpisodeName { get; set; }

        [ApiMember(Name = "EpisodeShortDescription", IsRequired = false, Description = "Filter by the Related Episode Short Description (Contains, Case-Insensitive)")]
        public string EpisodeShortDescription { get; set; }

        [ApiMember(Name = "EpisodeDescription", IsRequired = false, Description = "Filter by the Related Episode Description (Contains, Case-Insensitive)")]
        public string EpisodeDescription { get; set; }

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

    }

    [Route("/EpisodeStoryArcs/", "GET", Summary = "Gets All Active EpisodeStoryArcs")]
    public class GetEpisodeStoryArcs : EpisodeStoryArcSearchModelBase, IReturn<List<IEpisodeStoryArcModel>> { }

    [Route("/EpisodeStoryArcs/Listing", "GET", Summary = "Gets All Active EpisodeStoryArcs with the mininum header information")]
    public class GetEpisodeStoryArcsAsListing : EpisodeStoryArcSearchModelBase, IReturn<List<IEpisodeStoryArcModel>> { }

    [Route("/EpisodeStoryArcs/{ID}", "GET", Summary = "Gets EpisodeStoryArc by Identifier")]
    public class GetEpisodeStoryArc : ImplementsID, IReturn<IEpisodeStoryArcModel> { }

    [Route("/EpisodeStoryArcs/{CustomKey}/ByKey", "GET", Summary = "Gets EpisodeStoryArc by Key")]
    public class GetEpisodeStoryArcByKey : ImplementsKey, IReturn<IEpisodeStoryArcModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeStoryArcs/Create", "POST", Summary = "Creates an EpisodeStoryArc with these contents")]
    public class CreateEpisodeStoryArc : EpisodeStoryArcModelBase, IReturn<IEpisodeStoryArcModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeStoryArcs/Update", "POST", Summary = "Updates an EpisodeStoryArc with new contents")]
    public class UpdateEpisodeStoryArc : EpisodeStoryArcModelBase, IReturn<IEpisodeStoryArcModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeStoryArcs/{ID}/Deactivate", "POST", Summary = "Deactivates an EpisodeStoryArc by Identifier")]
    public class DeactivateEpisodeStoryArc : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeStoryArcs/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an EpisodeStoryArc by Key")]
    public class DeactivateEpisodeStoryArcByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeStoryArcs/{ID}/Remove", "POST", Summary = "Removes an EpisodeStoryArc by Identifier")]
    public class RemoveEpisodeStoryArc : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeStoryArcs/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an EpisodeStoryArc by Key")]
    public class RemoveEpisodeStoryArcByKey : ImplementsKey, IReturn<bool> { }

    public interface IEpisodeStoryArcsServices
    {
        List<IEpisodeStoryArcModel> Any(GetEpisodeStoryArcs request);
        List<IEpisodeStoryArcModel> Any(GetEpisodeStoryArcsAsListing request);
        IEpisodeStoryArcModel Any(GetEpisodeStoryArc request);
        IEpisodeStoryArcModel Any(GetEpisodeStoryArcByKey request);
        IEpisodeStoryArcModel Any(CreateEpisodeStoryArc request);
        IEpisodeStoryArcModel Any(UpdateEpisodeStoryArc request);
        bool Any(DeactivateEpisodeStoryArc request);
        bool Any(DeactivateEpisodeStoryArcByKey request);
        bool Any(RemoveEpisodeStoryArc request);
        bool Any(RemoveEpisodeStoryArcByKey request);
    }

    public class EpisodeStoryArcsServices : Service, IEpisodeStoryArcsServices
    {
        private readonly IEpisodeStoryArcsBusinessWorkflow workflow;

        public EpisodeStoryArcsServices(IEpisodeStoryArcsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IEpisodeStoryArcModel> Any(GetEpisodeStoryArcs request) { return workflow.Search(request); }
        public List<IEpisodeStoryArcModel> Any(GetEpisodeStoryArcsAsListing request) { return workflow.Search(request, true); }
        public IEpisodeStoryArcModel Any(GetEpisodeStoryArc request) { return workflow.Get(request.ID); }
        public IEpisodeStoryArcModel Any(GetEpisodeStoryArcByKey request) { return workflow.Get(request.CustomKey); }
        public IEpisodeStoryArcModel Any(CreateEpisodeStoryArc request) { return workflow.Create(request); }
        public IEpisodeStoryArcModel Any(UpdateEpisodeStoryArc request) { return workflow.Update(request); }
        public bool Any(DeactivateEpisodeStoryArc request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateEpisodeStoryArcByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveEpisodeStoryArc request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveEpisodeStoryArcByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
