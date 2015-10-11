// <auto-generated>
// <copyright file="Teams.ITeamModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Team model interfaces.</summary>
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

    public class TeamModelBase : NameableEntityModelBase, ITeamModel
    {
        // Team Properties
        // <None>
        // Related Objects
        public int PrimaryImageFileId { get; set; }
        public IImageFileModel PrimaryImageFile { get; set; }
        public int FirstIssueAppearanceId { get; set; }
        public IIssueModel FirstIssueAppearance { get; set; }
        public int PublisherId { get; set; }
        public IPublisherModel Publisher { get; set; }
        // Associated Objects
        public List<ITeamAliasModel> TeamAliases { get; set; }
        public List<ITeamCharacterEnemyModel> TeamCharacterEnemies { get; set; }
        public List<ITeamCharacterFriendModel> TeamCharacterFriends { get; set; }
        public List<ITeamAppearedInIssueModel> TeamIssuesAppearedIn { get; set; }
        public List<ITeamDisbandedInIssueModel> TeamIssuesDisbandedIn { get; set; }
        public List<ITeamIssueModel> TeamIssues { get; set; }
        public List<ITeamMemberModel> TeamMembers { get; set; }
        public List<ITeamMovieModel> TeamMovies { get; set; }
        public List<ITeamStoryArcModel> TeamStoryArcs { get; set; }
        public List<ITeamVolumeModel> TeamVolumes { get; set; }
    }
    public class TeamSearchModelBase : NameableEntitySearchModelBase, ITeamSearchModel
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

    [Route("/Teams/", "GET", Summary = "Gets All Active Teams")]
    public class GetTeams : TeamSearchModelBase, IReturn<List<ITeamModel>> { }

    [Route("/Teams/Listing", "GET", Summary = "Gets All Active Teams with the mininum header information")]
    public class GetTeamsAsListing : TeamSearchModelBase, IReturn<List<ITeamModel>> { }

    [Route("/Teams/{ID}", "GET", Summary = "Gets Team by Identifier")]
    public class GetTeam : ImplementsID, IReturn<ITeamModel> { }

    [Route("/Teams/{CustomKey}/ByKey", "GET", Summary = "Gets Team by Key")]
    public class GetTeamByKey : ImplementsKey, IReturn<ITeamModel> { }

    //[Authenticate]
    [Route("/Teams/Create", "POST", Summary = "Creates an Team with these contents")]
    public class CreateTeam : TeamModelBase, IReturn<ITeamModel> { }

    //[Authenticate]
    [Route("/Teams/Update", "POST", Summary = "Updates an Team with new contents")]
    public class UpdateTeam : TeamModelBase, IReturn<ITeamModel> { }

    //[Authenticate]
    [Route("/Teams/{ID}/Deactivate", "POST", Summary = "Deactivates an Team by Identifier")]
    public class DeactivateTeam : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/Teams/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an Team by Key")]
    public class DeactivateTeamByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/Teams/{ID}/Remove", "POST", Summary = "Removes an Team by Identifier")]
    public class RemoveTeam : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/Teams/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an Team by Key")]
    public class RemoveTeamByKey : ImplementsKey, IReturn<bool> { }

    public interface ITeamsServices
    {
        List<ITeamModel> Any(GetTeams request);
        List<ITeamModel> Any(GetTeamsAsListing request);
        ITeamModel Any(GetTeam request);
        ITeamModel Any(GetTeamByKey request);
        ITeamModel Any(CreateTeam request);
        ITeamModel Any(UpdateTeam request);
        bool Any(DeactivateTeam request);
        bool Any(DeactivateTeamByKey request);
        bool Any(RemoveTeam request);
        bool Any(RemoveTeamByKey request);
    }

    public class TeamsServices : /*ServicesBase,*/ ITeamsServices
    {
        private readonly ITeamsBusinessWorkflow workflow;

        public TeamsServices(ITeamsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ITeamModel> Any(GetTeams request) { return workflow.Search(request); }
        public List<ITeamModel> Any(GetTeamsAsListing request) { return workflow.Search(request, true); }
        public ITeamModel Any(GetTeam request) { return workflow.Get(request.ID); }
        public ITeamModel Any(GetTeamByKey request) { return workflow.Get(request.CustomKey); }
        public ITeamModel Any(CreateTeam request) { return workflow.Create(request); }
        public ITeamModel Any(UpdateTeam request) { return workflow.Update(request); }
        public bool Any(DeactivateTeam request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateTeamByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveTeam request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveTeamByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
