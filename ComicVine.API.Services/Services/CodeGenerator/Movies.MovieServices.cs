// <auto-generated>
// <copyright file="Movies.IMovieModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Movie model interfaces.</summary>
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

    public class MovieModelBase : NameableEntityModelBase, IMovieModel
    {
        // Movie Properties
        public bool HasStaffReview { get; set; }
        public string Distributor { get; set; }
        public decimal? BoxOfficeRevenue { get; set; }
        public decimal? TotalRevenue { get; set; }
        public decimal? Budget { get; set; }
        public decimal? Rating { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public decimal? RunTime { get; set; }
        // Related Objects
        public int? PrimaryImageFileId { get; set; }
        public IImageFileModel PrimaryImageFile { get; set; }
        // Associated Objects
        public List<IMovieCharacterModel> MovieCharacters { get; set; }
        public List<IMovieConceptModel> MovieConcepts { get; set; }
        public List<IMovieLocationModel> MovieLocations { get; set; }
        public List<IMovieObjectModel> MovieObjects { get; set; }
        public List<IMovieProducerModel> MovieProducers { get; set; }
        public List<IMovieStoryArcModel> MovieStoryArcs { get; set; }
        public List<IMovieStudioModel> MovieStudios { get; set; }
        public List<IMovieTeamModel> MovieTeams { get; set; }
        public List<IMovieWriterModel> MovieWriters { get; set; }
    }
    public class MovieSearchModelBase : NameableEntitySearchModelBase, IMovieSearchModel
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

        [ApiMember(Name = "HasStaffReview", IsRequired = false, Description = "The HasStaffReview to search by.")]
        public bool? HasStaffReview { get; set; }

        [ApiMember(Name = "Distributor", IsRequired = false, Description = "The Distributor to search by. (Contains, Case-Insensitive)")]
        public string Distributor { get; set; }

    }

    [Route("/Movies/", "GET", Summary = "Gets All Active Movies")]
    public class GetMovies : MovieSearchModelBase, IReturn<List<IMovieModel>> { }

    [Route("/Movies/Listing", "GET", Summary = "Gets All Active Movies with the mininum header information")]
    public class GetMoviesAsListing : MovieSearchModelBase, IReturn<List<IMovieModel>> { }

    [Route("/Movies/{ID}", "GET", Summary = "Gets Movie by Identifier")]
    public class GetMovie : ImplementsID, IReturn<IMovieModel> { }

    [Route("/Movies/{CustomKey}/ByKey", "GET", Summary = "Gets Movie by Key")]
    public class GetMovieByKey : ImplementsKey, IReturn<IMovieModel> { }

    //[Authenticate]
    [Route("/Movies/Create", "POST", Summary = "Creates an Movie with these contents")]
    public class CreateMovie : MovieModelBase, IReturn<IMovieModel> { }

    //[Authenticate]
    [Route("/Movies/Update", "POST", Summary = "Updates an Movie with new contents")]
    public class UpdateMovie : MovieModelBase, IReturn<IMovieModel> { }

    //[Authenticate]
    [Route("/Movies/{ID}/Deactivate", "POST", Summary = "Deactivates an Movie by Identifier")]
    public class DeactivateMovie : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/Movies/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an Movie by Key")]
    public class DeactivateMovieByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/Movies/{ID}/Remove", "POST", Summary = "Removes an Movie by Identifier")]
    public class RemoveMovie : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/Movies/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an Movie by Key")]
    public class RemoveMovieByKey : ImplementsKey, IReturn<bool> { }

    public interface IMoviesServices
    {
        List<IMovieModel> Any(GetMovies request);
        List<IMovieModel> Any(GetMoviesAsListing request);
        IMovieModel Any(GetMovie request);
        IMovieModel Any(GetMovieByKey request);
        IMovieModel Any(CreateMovie request);
        IMovieModel Any(UpdateMovie request);
        bool Any(DeactivateMovie request);
        bool Any(DeactivateMovieByKey request);
        bool Any(RemoveMovie request);
        bool Any(RemoveMovieByKey request);
    }

    public class MoviesServices : Service, IMoviesServices
    {
        private readonly IMoviesBusinessWorkflow workflow;

        public MoviesServices(IMoviesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IMovieModel> Any(GetMovies request) { return workflow.Search(request); }
        public List<IMovieModel> Any(GetMoviesAsListing request) { return workflow.Search(request, true); }
        public IMovieModel Any(GetMovie request) { return workflow.Get(request.ID); }
        public IMovieModel Any(GetMovieByKey request) { return workflow.Get(request.CustomKey); }
        public IMovieModel Any(CreateMovie request) { return workflow.Create(request); }
        public IMovieModel Any(UpdateMovie request) { return workflow.Update(request); }
        public bool Any(DeactivateMovie request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateMovieByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveMovie request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveMovieByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
