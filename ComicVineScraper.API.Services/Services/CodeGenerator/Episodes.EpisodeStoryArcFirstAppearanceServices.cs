// <auto-generated>
// <copyright file="Episodes.IEpisodeStoryArcFirstAppearanceModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeStoryArcFirstAppearance model interfaces.</summary>
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

    public class EpisodeStoryArcFirstAppearanceModelBase : NameableEntityModelBase, IEpisodeStoryArcFirstAppearanceModel
    {
        // EpisodeStoryArcFirstAppearance Properties
        // <None>
        // Related Objects
        public int EpisodeId { get; set; }
        public IEpisodeModel Episode { get; set; }
        public int StoryArcId { get; set; }
        public IStoryArcModel StoryArc { get; set; }
        // Associated Objects
        // <None>
    }
    public class EpisodeStoryArcFirstAppearanceSearchModelBase : NameableEntitySearchModelBase, IEpisodeStoryArcFirstAppearanceSearchModel
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

    [Route("/EpisodeStoryArcFirstAppearances/", "GET", Summary = "Gets All Active EpisodeStoryArcFirstAppearances")]
    public class GetEpisodeStoryArcFirstAppearances : EpisodeStoryArcFirstAppearanceSearchModelBase, IReturn<List<IEpisodeStoryArcFirstAppearanceModel>> { }

    [Route("/EpisodeStoryArcFirstAppearances/Listing", "GET", Summary = "Gets All Active EpisodeStoryArcFirstAppearances with the mininum header information")]
    public class GetEpisodeStoryArcFirstAppearancesAsListing : EpisodeStoryArcFirstAppearanceSearchModelBase, IReturn<List<IEpisodeStoryArcFirstAppearanceModel>> { }

    [Route("/EpisodeStoryArcFirstAppearances/{ID}", "GET", Summary = "Gets EpisodeStoryArcFirstAppearance by Identifier")]
    public class GetEpisodeStoryArcFirstAppearance : ImplementsID, IReturn<IEpisodeStoryArcFirstAppearanceModel> { }

    [Route("/EpisodeStoryArcFirstAppearances/{CustomKey}/ByKey", "GET", Summary = "Gets EpisodeStoryArcFirstAppearance by Key")]
    public class GetEpisodeStoryArcFirstAppearanceByKey : ImplementsKey, IReturn<IEpisodeStoryArcFirstAppearanceModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeStoryArcFirstAppearances/Create", "POST", Summary = "Creates an EpisodeStoryArcFirstAppearance with these contents")]
    public class CreateEpisodeStoryArcFirstAppearance : EpisodeStoryArcFirstAppearanceModelBase, IReturn<IEpisodeStoryArcFirstAppearanceModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeStoryArcFirstAppearances/Update", "POST", Summary = "Updates an EpisodeStoryArcFirstAppearance with new contents")]
    public class UpdateEpisodeStoryArcFirstAppearance : EpisodeStoryArcFirstAppearanceModelBase, IReturn<IEpisodeStoryArcFirstAppearanceModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeStoryArcFirstAppearances/{ID}/Deactivate", "POST", Summary = "Deactivates an EpisodeStoryArcFirstAppearance by Identifier")]
    public class DeactivateEpisodeStoryArcFirstAppearance : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeStoryArcFirstAppearances/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an EpisodeStoryArcFirstAppearance by Key")]
    public class DeactivateEpisodeStoryArcFirstAppearanceByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeStoryArcFirstAppearances/{ID}/Remove", "POST", Summary = "Removes an EpisodeStoryArcFirstAppearance by Identifier")]
    public class RemoveEpisodeStoryArcFirstAppearance : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeStoryArcFirstAppearances/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an EpisodeStoryArcFirstAppearance by Key")]
    public class RemoveEpisodeStoryArcFirstAppearanceByKey : ImplementsKey, IReturn<bool> { }

    public interface IEpisodeStoryArcFirstAppearancesServices
    {
        List<IEpisodeStoryArcFirstAppearanceModel> Any(GetEpisodeStoryArcFirstAppearances request);
        List<IEpisodeStoryArcFirstAppearanceModel> Any(GetEpisodeStoryArcFirstAppearancesAsListing request);
        IEpisodeStoryArcFirstAppearanceModel Any(GetEpisodeStoryArcFirstAppearance request);
        IEpisodeStoryArcFirstAppearanceModel Any(GetEpisodeStoryArcFirstAppearanceByKey request);
        IEpisodeStoryArcFirstAppearanceModel Any(CreateEpisodeStoryArcFirstAppearance request);
        IEpisodeStoryArcFirstAppearanceModel Any(UpdateEpisodeStoryArcFirstAppearance request);
        bool Any(DeactivateEpisodeStoryArcFirstAppearance request);
        bool Any(DeactivateEpisodeStoryArcFirstAppearanceByKey request);
        bool Any(RemoveEpisodeStoryArcFirstAppearance request);
        bool Any(RemoveEpisodeStoryArcFirstAppearanceByKey request);
    }

    public class EpisodeStoryArcFirstAppearancesServices : Service, IEpisodeStoryArcFirstAppearancesServices
    {
        private readonly IEpisodeStoryArcFirstAppearancesBusinessWorkflow workflow;

        public EpisodeStoryArcFirstAppearancesServices(IEpisodeStoryArcFirstAppearancesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IEpisodeStoryArcFirstAppearanceModel> Any(GetEpisodeStoryArcFirstAppearances request) { return workflow.Search(request); }
        public List<IEpisodeStoryArcFirstAppearanceModel> Any(GetEpisodeStoryArcFirstAppearancesAsListing request) { return workflow.Search(request, true); }
        public IEpisodeStoryArcFirstAppearanceModel Any(GetEpisodeStoryArcFirstAppearance request) { return workflow.Get(request.ID); }
        public IEpisodeStoryArcFirstAppearanceModel Any(GetEpisodeStoryArcFirstAppearanceByKey request) { return workflow.Get(request.CustomKey); }
        public IEpisodeStoryArcFirstAppearanceModel Any(CreateEpisodeStoryArcFirstAppearance request) { return workflow.Create(request); }
        public IEpisodeStoryArcFirstAppearanceModel Any(UpdateEpisodeStoryArcFirstAppearance request) { return workflow.Update(request); }
        public bool Any(DeactivateEpisodeStoryArcFirstAppearance request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateEpisodeStoryArcFirstAppearanceByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveEpisodeStoryArcFirstAppearance request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveEpisodeStoryArcFirstAppearanceByKey request) { return workflow.Remove(request.CustomKey); }
    }
}