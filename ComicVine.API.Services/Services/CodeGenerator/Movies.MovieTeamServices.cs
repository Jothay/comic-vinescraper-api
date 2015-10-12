// <auto-generated>
// <copyright file="Movies.IMovieTeamModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieTeam model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Movies
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;

    public class MovieTeamModelBase : NameableEntityModelBase, IMovieTeamModel
    {
        // MovieTeam Properties
        // <None>
        // Related Objects
        public int MovieId { get; set; }
        public IMovieModel Movie { get; set; }
        public int TeamId { get; set; }
        public ITeamModel Team { get; set; }
        // Associated Objects
        // <None>
    }
    public class MovieTeamSearchModelBase : NameableEntitySearchModelBase, IMovieTeamSearchModel
    {
        [ApiMember(Name = "MovieId", IsRequired = false, Description = "Filter by the Related MovieId")]
        public int? MovieId { get; set; }

        [ApiMember(Name = "MovieCustomKey", IsRequired = false, Description = "Filter by the Related Movie CustomKey (Equals, Case-Insensitive)")]
        public string MovieCustomKey { get; set; }

        [ApiMember(Name = "MovieApiDetailUrl", IsRequired = false, Description = "Filter by the Related Movie Api Detail Url (Contains, Case-Insensitive)")]
        public string MovieApiDetailUrl { get; set; }

        [ApiMember(Name = "MovieSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Movie Site Detail Url (Contains, Case-Insensitive)")]
        public string MovieSiteDetailUrl { get; set; }

        [ApiMember(Name = "MovieName", IsRequired = false, Description = "Filter by the Related Movie Name (Contains, Case-Insensitive)")]
        public string MovieName { get; set; }

        [ApiMember(Name = "MovieShortDescription", IsRequired = false, Description = "Filter by the Related Movie Short Description (Contains, Case-Insensitive)")]
        public string MovieShortDescription { get; set; }

        [ApiMember(Name = "MovieDescription", IsRequired = false, Description = "Filter by the Related Movie Description (Contains, Case-Insensitive)")]
        public string MovieDescription { get; set; }

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

    [Route("/MovieTeams/", "GET", Summary = "Gets All Active MovieTeams")]
    public class GetMovieTeams : MovieTeamSearchModelBase, IReturn<List<IMovieTeamModel>> { }

    [Route("/MovieTeams/Listing", "GET", Summary = "Gets All Active MovieTeams with the mininum header information")]
    public class GetMovieTeamsAsListing : MovieTeamSearchModelBase, IReturn<List<IMovieTeamModel>> { }

    [Route("/MovieTeams/{ID}", "GET", Summary = "Gets MovieTeam by Identifier")]
    public class GetMovieTeam : ImplementsID, IReturn<IMovieTeamModel> { }

    [Route("/MovieTeams/{CustomKey}/ByKey", "GET", Summary = "Gets MovieTeam by Key")]
    public class GetMovieTeamByKey : ImplementsKey, IReturn<IMovieTeamModel> { }

    //[Authenticate]
    [Route("/MovieTeams/Create", "POST", Summary = "Creates an MovieTeam with these contents")]
    public class CreateMovieTeam : MovieTeamModelBase, IReturn<IMovieTeamModel> { }

    //[Authenticate]
    [Route("/MovieTeams/Update", "POST", Summary = "Updates an MovieTeam with new contents")]
    public class UpdateMovieTeam : MovieTeamModelBase, IReturn<IMovieTeamModel> { }

    //[Authenticate]
    [Route("/MovieTeams/{ID}/Deactivate", "POST", Summary = "Deactivates an MovieTeam by Identifier")]
    public class DeactivateMovieTeam : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/MovieTeams/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an MovieTeam by Key")]
    public class DeactivateMovieTeamByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/MovieTeams/{ID}/Remove", "POST", Summary = "Removes an MovieTeam by Identifier")]
    public class RemoveMovieTeam : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/MovieTeams/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an MovieTeam by Key")]
    public class RemoveMovieTeamByKey : ImplementsKey, IReturn<bool> { }

    public interface IMovieTeamsServices
    {
        List<IMovieTeamModel> Any(GetMovieTeams request);
        List<IMovieTeamModel> Any(GetMovieTeamsAsListing request);
        IMovieTeamModel Any(GetMovieTeam request);
        IMovieTeamModel Any(GetMovieTeamByKey request);
        IMovieTeamModel Any(CreateMovieTeam request);
        IMovieTeamModel Any(UpdateMovieTeam request);
        bool Any(DeactivateMovieTeam request);
        bool Any(DeactivateMovieTeamByKey request);
        bool Any(RemoveMovieTeam request);
        bool Any(RemoveMovieTeamByKey request);
    }

    public class MovieTeamsServices : Service, IMovieTeamsServices
    {
        private readonly IMovieTeamsBusinessWorkflow workflow;

        public MovieTeamsServices(IMovieTeamsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IMovieTeamModel> Any(GetMovieTeams request) { return workflow.Search(request); }
        public List<IMovieTeamModel> Any(GetMovieTeamsAsListing request) { return workflow.Search(request, true); }
        public IMovieTeamModel Any(GetMovieTeam request) { return workflow.Get(request.ID); }
        public IMovieTeamModel Any(GetMovieTeamByKey request) { return workflow.Get(request.CustomKey); }
        public IMovieTeamModel Any(CreateMovieTeam request) { return workflow.Create(request); }
        public IMovieTeamModel Any(UpdateMovieTeam request) { return workflow.Update(request); }
        public bool Any(DeactivateMovieTeam request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateMovieTeamByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveMovieTeam request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveMovieTeamByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
