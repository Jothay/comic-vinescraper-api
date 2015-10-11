// <auto-generated>
// <copyright file="Episodes.IEpisodeTeamFirstAppearanceModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeTeamFirstAppearance model interfaces.</summary>
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

    public class EpisodeTeamFirstAppearanceModelBase : NameableEntityModelBase, IEpisodeTeamFirstAppearanceModel
    {
        // EpisodeTeamFirstAppearance Properties
        // <None>
        // Related Objects
        public int EpisodeId { get; set; }
        public IEpisodeModel Episode { get; set; }
        public int TeamId { get; set; }
        public ITeamModel Team { get; set; }
        // Associated Objects
        // <None>
    }
    public class EpisodeTeamFirstAppearanceSearchModelBase : NameableEntitySearchModelBase, IEpisodeTeamFirstAppearanceSearchModel
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

    [Route("/EpisodeTeamFirstAppearances/", "GET", Summary = "Gets All Active EpisodeTeamFirstAppearances")]
    public class GetEpisodeTeamFirstAppearances : EpisodeTeamFirstAppearanceSearchModelBase, IReturn<List<IEpisodeTeamFirstAppearanceModel>> { }

    [Route("/EpisodeTeamFirstAppearances/Listing", "GET", Summary = "Gets All Active EpisodeTeamFirstAppearances with the mininum header information")]
    public class GetEpisodeTeamFirstAppearancesAsListing : EpisodeTeamFirstAppearanceSearchModelBase, IReturn<List<IEpisodeTeamFirstAppearanceModel>> { }

    [Route("/EpisodeTeamFirstAppearances/{ID}", "GET", Summary = "Gets EpisodeTeamFirstAppearance by Identifier")]
    public class GetEpisodeTeamFirstAppearance : ImplementsID, IReturn<IEpisodeTeamFirstAppearanceModel> { }

    [Route("/EpisodeTeamFirstAppearances/{CustomKey}/ByKey", "GET", Summary = "Gets EpisodeTeamFirstAppearance by Key")]
    public class GetEpisodeTeamFirstAppearanceByKey : ImplementsKey, IReturn<IEpisodeTeamFirstAppearanceModel> { }

    //[Authenticate]
    [Route("/EpisodeTeamFirstAppearances/Create", "POST", Summary = "Creates an EpisodeTeamFirstAppearance with these contents")]
    public class CreateEpisodeTeamFirstAppearance : EpisodeTeamFirstAppearanceModelBase, IReturn<IEpisodeTeamFirstAppearanceModel> { }

    //[Authenticate]
    [Route("/EpisodeTeamFirstAppearances/Update", "POST", Summary = "Updates an EpisodeTeamFirstAppearance with new contents")]
    public class UpdateEpisodeTeamFirstAppearance : EpisodeTeamFirstAppearanceModelBase, IReturn<IEpisodeTeamFirstAppearanceModel> { }

    //[Authenticate]
    [Route("/EpisodeTeamFirstAppearances/{ID}/Deactivate", "POST", Summary = "Deactivates an EpisodeTeamFirstAppearance by Identifier")]
    public class DeactivateEpisodeTeamFirstAppearance : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/EpisodeTeamFirstAppearances/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an EpisodeTeamFirstAppearance by Key")]
    public class DeactivateEpisodeTeamFirstAppearanceByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/EpisodeTeamFirstAppearances/{ID}/Remove", "POST", Summary = "Removes an EpisodeTeamFirstAppearance by Identifier")]
    public class RemoveEpisodeTeamFirstAppearance : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/EpisodeTeamFirstAppearances/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an EpisodeTeamFirstAppearance by Key")]
    public class RemoveEpisodeTeamFirstAppearanceByKey : ImplementsKey, IReturn<bool> { }

    public interface IEpisodeTeamFirstAppearancesServices
    {
        List<IEpisodeTeamFirstAppearanceModel> Any(GetEpisodeTeamFirstAppearances request);
        List<IEpisodeTeamFirstAppearanceModel> Any(GetEpisodeTeamFirstAppearancesAsListing request);
        IEpisodeTeamFirstAppearanceModel Any(GetEpisodeTeamFirstAppearance request);
        IEpisodeTeamFirstAppearanceModel Any(GetEpisodeTeamFirstAppearanceByKey request);
        IEpisodeTeamFirstAppearanceModel Any(CreateEpisodeTeamFirstAppearance request);
        IEpisodeTeamFirstAppearanceModel Any(UpdateEpisodeTeamFirstAppearance request);
        bool Any(DeactivateEpisodeTeamFirstAppearance request);
        bool Any(DeactivateEpisodeTeamFirstAppearanceByKey request);
        bool Any(RemoveEpisodeTeamFirstAppearance request);
        bool Any(RemoveEpisodeTeamFirstAppearanceByKey request);
    }

    public class EpisodeTeamFirstAppearancesServices : /*ServicesBase,*/ IEpisodeTeamFirstAppearancesServices
    {
        private readonly IEpisodeTeamFirstAppearancesBusinessWorkflow workflow;

        public EpisodeTeamFirstAppearancesServices(IEpisodeTeamFirstAppearancesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IEpisodeTeamFirstAppearanceModel> Any(GetEpisodeTeamFirstAppearances request) { return workflow.Search(request); }
        public List<IEpisodeTeamFirstAppearanceModel> Any(GetEpisodeTeamFirstAppearancesAsListing request) { return workflow.Search(request, true); }
        public IEpisodeTeamFirstAppearanceModel Any(GetEpisodeTeamFirstAppearance request) { return workflow.Get(request.ID); }
        public IEpisodeTeamFirstAppearanceModel Any(GetEpisodeTeamFirstAppearanceByKey request) { return workflow.Get(request.CustomKey); }
        public IEpisodeTeamFirstAppearanceModel Any(CreateEpisodeTeamFirstAppearance request) { return workflow.Create(request); }
        public IEpisodeTeamFirstAppearanceModel Any(UpdateEpisodeTeamFirstAppearance request) { return workflow.Update(request); }
        public bool Any(DeactivateEpisodeTeamFirstAppearance request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateEpisodeTeamFirstAppearanceByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveEpisodeTeamFirstAppearance request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveEpisodeTeamFirstAppearanceByKey request) { return workflow.Remove(request.CustomKey); }
    }
}