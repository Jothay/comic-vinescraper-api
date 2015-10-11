// <auto-generated>
// <copyright file="Locations.ILocationMovieModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the LocationMovie model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Locations
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;

    public class LocationMovieModelBase : NameableEntityModelBase, ILocationMovieModel
    {
        // LocationMovie Properties
        // <None>
        // Related Objects
        public int LocationId { get; set; }
        public ILocationModel Location { get; set; }
        public int MovieId { get; set; }
        public IMovieModel Movie { get; set; }
        // Associated Objects
        // <None>
    }
    public class LocationMovieSearchModelBase : NameableEntitySearchModelBase, ILocationMovieSearchModel
    {
        [ApiMember(Name = "LocationId", IsRequired = false, Description = "Filter by the Related LocationId")]
        public int? LocationId { get; set; }

        [ApiMember(Name = "LocationCustomKey", IsRequired = false, Description = "Filter by the Related Location CustomKey (Equals, Case-Insensitive)")]
        public string LocationCustomKey { get; set; }

        [ApiMember(Name = "LocationApiDetailUrl", IsRequired = false, Description = "Filter by the Related Location Api Detail Url (Contains, Case-Insensitive)")]
        public string LocationApiDetailUrl { get; set; }

        [ApiMember(Name = "LocationSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Location Site Detail Url (Contains, Case-Insensitive)")]
        public string LocationSiteDetailUrl { get; set; }

        [ApiMember(Name = "LocationName", IsRequired = false, Description = "Filter by the Related Location Name (Contains, Case-Insensitive)")]
        public string LocationName { get; set; }

        [ApiMember(Name = "LocationShortDescription", IsRequired = false, Description = "Filter by the Related Location Short Description (Contains, Case-Insensitive)")]
        public string LocationShortDescription { get; set; }

        [ApiMember(Name = "LocationDescription", IsRequired = false, Description = "Filter by the Related Location Description (Contains, Case-Insensitive)")]
        public string LocationDescription { get; set; }

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

    }

    [Route("/LocationMovies/", "GET", Summary = "Gets All Active LocationMovies")]
    public class GetLocationMovies : LocationMovieSearchModelBase, IReturn<List<ILocationMovieModel>> { }

    [Route("/LocationMovies/Listing", "GET", Summary = "Gets All Active LocationMovies with the mininum header information")]
    public class GetLocationMoviesAsListing : LocationMovieSearchModelBase, IReturn<List<ILocationMovieModel>> { }

    [Route("/LocationMovies/{ID}", "GET", Summary = "Gets LocationMovie by Identifier")]
    public class GetLocationMovie : ImplementsID, IReturn<ILocationMovieModel> { }

    [Route("/LocationMovies/{CustomKey}/ByKey", "GET", Summary = "Gets LocationMovie by Key")]
    public class GetLocationMovieByKey : ImplementsKey, IReturn<ILocationMovieModel> { }

    //[Authenticate]
    [Route("/LocationMovies/Create", "POST", Summary = "Creates an LocationMovie with these contents")]
    public class CreateLocationMovie : LocationMovieModelBase, IReturn<ILocationMovieModel> { }

    //[Authenticate]
    [Route("/LocationMovies/Update", "POST", Summary = "Updates an LocationMovie with new contents")]
    public class UpdateLocationMovie : LocationMovieModelBase, IReturn<ILocationMovieModel> { }

    //[Authenticate]
    [Route("/LocationMovies/{ID}/Deactivate", "POST", Summary = "Deactivates an LocationMovie by Identifier")]
    public class DeactivateLocationMovie : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/LocationMovies/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an LocationMovie by Key")]
    public class DeactivateLocationMovieByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/LocationMovies/{ID}/Remove", "POST", Summary = "Removes an LocationMovie by Identifier")]
    public class RemoveLocationMovie : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/LocationMovies/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an LocationMovie by Key")]
    public class RemoveLocationMovieByKey : ImplementsKey, IReturn<bool> { }

    public interface ILocationMoviesServices
    {
        List<ILocationMovieModel> Any(GetLocationMovies request);
        List<ILocationMovieModel> Any(GetLocationMoviesAsListing request);
        ILocationMovieModel Any(GetLocationMovie request);
        ILocationMovieModel Any(GetLocationMovieByKey request);
        ILocationMovieModel Any(CreateLocationMovie request);
        ILocationMovieModel Any(UpdateLocationMovie request);
        bool Any(DeactivateLocationMovie request);
        bool Any(DeactivateLocationMovieByKey request);
        bool Any(RemoveLocationMovie request);
        bool Any(RemoveLocationMovieByKey request);
    }

    public class LocationMoviesServices : /*ServicesBase,*/ ILocationMoviesServices
    {
        private readonly ILocationMoviesBusinessWorkflow workflow;

        public LocationMoviesServices(ILocationMoviesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ILocationMovieModel> Any(GetLocationMovies request) { return workflow.Search(request); }
        public List<ILocationMovieModel> Any(GetLocationMoviesAsListing request) { return workflow.Search(request, true); }
        public ILocationMovieModel Any(GetLocationMovie request) { return workflow.Get(request.ID); }
        public ILocationMovieModel Any(GetLocationMovieByKey request) { return workflow.Get(request.CustomKey); }
        public ILocationMovieModel Any(CreateLocationMovie request) { return workflow.Create(request); }
        public ILocationMovieModel Any(UpdateLocationMovie request) { return workflow.Update(request); }
        public bool Any(DeactivateLocationMovie request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateLocationMovieByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveLocationMovie request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveLocationMovieByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
