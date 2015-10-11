// <auto-generated>
// <copyright file="Episodes.IEpisodeTeamModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeTeam model interfaces.</summary>
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

    public class EpisodeTeamModelBase : NameableEntityModelBase, IEpisodeTeamModel
    {
        // EpisodeTeam Properties
        // <None>
        // Related Objects
        public int EpisodeId { get; set; }
        public IEpisodeModel Episode { get; set; }
        public int TeamId { get; set; }
        public ITeamModel Team { get; set; }
        // Associated Objects
        // <None>
    }
    public class EpisodeTeamSearchModelBase : NameableEntitySearchModelBase, IEpisodeTeamSearchModel
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

    }

    [Route("/EpisodeTeams/", "GET", Summary = "Gets All Active EpisodeTeams")]
    public class GetEpisodeTeams : EpisodeTeamSearchModelBase, IReturn<List<IEpisodeTeamModel>> { }

    [Route("/EpisodeTeams/Listing", "GET", Summary = "Gets All Active EpisodeTeams with the mininum header information")]
    public class GetEpisodeTeamsAsListing : EpisodeTeamSearchModelBase, IReturn<List<IEpisodeTeamModel>> { }

    [Route("/EpisodeTeams/{ID}", "GET", Summary = "Gets EpisodeTeam by Identifier")]
    public class GetEpisodeTeam : ImplementsID, IReturn<IEpisodeTeamModel> { }

    [Route("/EpisodeTeams/{CustomKey}/ByKey", "GET", Summary = "Gets EpisodeTeam by Key")]
    public class GetEpisodeTeamByKey : ImplementsKey, IReturn<IEpisodeTeamModel> { }

    //[Authenticate]
    [Route("/EpisodeTeams/Create", "POST", Summary = "Creates an EpisodeTeam with these contents")]
    public class CreateEpisodeTeam : EpisodeTeamModelBase, IReturn<IEpisodeTeamModel> { }

    //[Authenticate]
    [Route("/EpisodeTeams/Update", "POST", Summary = "Updates an EpisodeTeam with new contents")]
    public class UpdateEpisodeTeam : EpisodeTeamModelBase, IReturn<IEpisodeTeamModel> { }

    //[Authenticate]
    [Route("/EpisodeTeams/{ID}/Deactivate", "POST", Summary = "Deactivates an EpisodeTeam by Identifier")]
    public class DeactivateEpisodeTeam : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/EpisodeTeams/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an EpisodeTeam by Key")]
    public class DeactivateEpisodeTeamByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/EpisodeTeams/{ID}/Remove", "POST", Summary = "Removes an EpisodeTeam by Identifier")]
    public class RemoveEpisodeTeam : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/EpisodeTeams/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an EpisodeTeam by Key")]
    public class RemoveEpisodeTeamByKey : ImplementsKey, IReturn<bool> { }

    public interface IEpisodeTeamsServices
    {
        List<IEpisodeTeamModel> Any(GetEpisodeTeams request);
        List<IEpisodeTeamModel> Any(GetEpisodeTeamsAsListing request);
        IEpisodeTeamModel Any(GetEpisodeTeam request);
        IEpisodeTeamModel Any(GetEpisodeTeamByKey request);
        IEpisodeTeamModel Any(CreateEpisodeTeam request);
        IEpisodeTeamModel Any(UpdateEpisodeTeam request);
        bool Any(DeactivateEpisodeTeam request);
        bool Any(DeactivateEpisodeTeamByKey request);
        bool Any(RemoveEpisodeTeam request);
        bool Any(RemoveEpisodeTeamByKey request);
    }

    public class EpisodeTeamsServices : /*ServicesBase,*/ IEpisodeTeamsServices
    {
        private readonly IEpisodeTeamsBusinessWorkflow workflow;

        public EpisodeTeamsServices(IEpisodeTeamsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IEpisodeTeamModel> Any(GetEpisodeTeams request) { return workflow.Search(request); }
        public List<IEpisodeTeamModel> Any(GetEpisodeTeamsAsListing request) { return workflow.Search(request, true); }
        public IEpisodeTeamModel Any(GetEpisodeTeam request) { return workflow.Get(request.ID); }
        public IEpisodeTeamModel Any(GetEpisodeTeamByKey request) { return workflow.Get(request.CustomKey); }
        public IEpisodeTeamModel Any(CreateEpisodeTeam request) { return workflow.Create(request); }
        public IEpisodeTeamModel Any(UpdateEpisodeTeam request) { return workflow.Update(request); }
        public bool Any(DeactivateEpisodeTeam request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateEpisodeTeamByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveEpisodeTeam request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveEpisodeTeamByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
