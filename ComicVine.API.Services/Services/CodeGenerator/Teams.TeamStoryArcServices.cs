// <auto-generated>
// <copyright file="Teams.ITeamStoryArcModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamStoryArc model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Teams
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;

    public class TeamStoryArcModelBase : NameableEntityModelBase, ITeamStoryArcModel
    {
        // TeamStoryArc Properties
        // <None>
        // Related Objects
        public int TeamId { get; set; }
        public ITeamModel Team { get; set; }
        public int StoryArcId { get; set; }
        public IStoryArcModel StoryArc { get; set; }
        // Associated Objects
        // <None>
    }
    public class TeamStoryArcSearchModelBase : NameableEntitySearchModelBase, ITeamStoryArcSearchModel
    {
        [ApiMember(Name = "TeamId", IsRequired = false, Description = "Filter by the Related TeamId")]
        public int? TeamId { get; set; }

        [ApiMember(Name = "TeamCustomKey", IsRequired = false, Description = "Filter by the Related Team CustomKey (Equals, Case-Insensitive)")]
        public string TeamCustomKey { get; set; }

        [ApiMember(Name = "TeamApiDetailUrl", IsRequired = false, Description = "Filter by the Related Team Api Detail Url (Contains, Case-Insensitive)")]
        public string TeamApiDetailUrl { get; set; }

        [ApiMember(Name = "TeamSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Team Site Detail Url (Contains, Case-Insensitive)")]
        public string TeamSiteDetailUrl { get; set; }

        [ApiMember(Name = "TeamName", IsRequired = false, Description = "Filter by the Related Team Name (Contains, Case-Insensitive)")]
        public string TeamName { get; set; }

        [ApiMember(Name = "TeamShortDescription", IsRequired = false, Description = "Filter by the Related Team Short Description (Contains, Case-Insensitive)")]
        public string TeamShortDescription { get; set; }

        [ApiMember(Name = "TeamDescription", IsRequired = false, Description = "Filter by the Related Team Description (Contains, Case-Insensitive)")]
        public string TeamDescription { get; set; }

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

    [Route("/TeamStoryArcs/", "GET", Summary = "Gets All Active TeamStoryArcs")]
    public class GetTeamStoryArcs : TeamStoryArcSearchModelBase, IReturn<List<ITeamStoryArcModel>> { }

    [Route("/TeamStoryArcs/Listing", "GET", Summary = "Gets All Active TeamStoryArcs with the mininum header information")]
    public class GetTeamStoryArcsAsListing : TeamStoryArcSearchModelBase, IReturn<List<ITeamStoryArcModel>> { }

    [Route("/TeamStoryArcs/{ID}", "GET", Summary = "Gets TeamStoryArc by Identifier")]
    public class GetTeamStoryArc : ImplementsID, IReturn<ITeamStoryArcModel> { }

    [Route("/TeamStoryArcs/{CustomKey}/ByKey", "GET", Summary = "Gets TeamStoryArc by Key")]
    public class GetTeamStoryArcByKey : ImplementsKey, IReturn<ITeamStoryArcModel> { }

    //[Authenticate]
    [Route("/TeamStoryArcs/Create", "POST", Summary = "Creates an TeamStoryArc with these contents")]
    public class CreateTeamStoryArc : TeamStoryArcModelBase, IReturn<ITeamStoryArcModel> { }

    //[Authenticate]
    [Route("/TeamStoryArcs/Update", "POST", Summary = "Updates an TeamStoryArc with new contents")]
    public class UpdateTeamStoryArc : TeamStoryArcModelBase, IReturn<ITeamStoryArcModel> { }

    //[Authenticate]
    [Route("/TeamStoryArcs/{ID}/Deactivate", "POST", Summary = "Deactivates an TeamStoryArc by Identifier")]
    public class DeactivateTeamStoryArc : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/TeamStoryArcs/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an TeamStoryArc by Key")]
    public class DeactivateTeamStoryArcByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/TeamStoryArcs/{ID}/Remove", "POST", Summary = "Removes an TeamStoryArc by Identifier")]
    public class RemoveTeamStoryArc : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/TeamStoryArcs/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an TeamStoryArc by Key")]
    public class RemoveTeamStoryArcByKey : ImplementsKey, IReturn<bool> { }

    public interface ITeamStoryArcsServices
    {
        List<ITeamStoryArcModel> Any(GetTeamStoryArcs request);
        List<ITeamStoryArcModel> Any(GetTeamStoryArcsAsListing request);
        ITeamStoryArcModel Any(GetTeamStoryArc request);
        ITeamStoryArcModel Any(GetTeamStoryArcByKey request);
        ITeamStoryArcModel Any(CreateTeamStoryArc request);
        ITeamStoryArcModel Any(UpdateTeamStoryArc request);
        bool Any(DeactivateTeamStoryArc request);
        bool Any(DeactivateTeamStoryArcByKey request);
        bool Any(RemoveTeamStoryArc request);
        bool Any(RemoveTeamStoryArcByKey request);
    }

    public class TeamStoryArcsServices : Service, ITeamStoryArcsServices
    {
        private readonly ITeamStoryArcsBusinessWorkflow workflow;

        public TeamStoryArcsServices(ITeamStoryArcsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ITeamStoryArcModel> Any(GetTeamStoryArcs request) { return workflow.Search(request); }
        public List<ITeamStoryArcModel> Any(GetTeamStoryArcsAsListing request) { return workflow.Search(request, true); }
        public ITeamStoryArcModel Any(GetTeamStoryArc request) { return workflow.Get(request.ID); }
        public ITeamStoryArcModel Any(GetTeamStoryArcByKey request) { return workflow.Get(request.CustomKey); }
        public ITeamStoryArcModel Any(CreateTeamStoryArc request) { return workflow.Create(request); }
        public ITeamStoryArcModel Any(UpdateTeamStoryArc request) { return workflow.Update(request); }
        public bool Any(DeactivateTeamStoryArc request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateTeamStoryArcByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveTeamStoryArc request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveTeamStoryArcByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
