// <auto-generated>
// <copyright file="Movies.IMovieStoryArcModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieStoryArc model interfaces.</summary>
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

    public class MovieStoryArcModelBase : NameableEntityModelBase, IMovieStoryArcModel
    {
        // MovieStoryArc Properties
        // <None>
        // Related Objects
        public int MovieId { get; set; }
        public IMovieModel Movie { get; set; }
        public int StoryArcId { get; set; }
        public IStoryArcModel StoryArc { get; set; }
        // Associated Objects
        // <None>
    }
    public class MovieStoryArcSearchModelBase : NameableEntitySearchModelBase, IMovieStoryArcSearchModel
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

    [Route("/MovieStoryArcs/", "GET", Summary = "Gets All Active MovieStoryArcs")]
    public class GetMovieStoryArcs : MovieStoryArcSearchModelBase, IReturn<List<IMovieStoryArcModel>> { }

    [Route("/MovieStoryArcs/Listing", "GET", Summary = "Gets All Active MovieStoryArcs with the mininum header information")]
    public class GetMovieStoryArcsAsListing : MovieStoryArcSearchModelBase, IReturn<List<IMovieStoryArcModel>> { }

    [Route("/MovieStoryArcs/{ID}", "GET", Summary = "Gets MovieStoryArc by Identifier")]
    public class GetMovieStoryArc : ImplementsID, IReturn<IMovieStoryArcModel> { }

    [Route("/MovieStoryArcs/{CustomKey}/ByKey", "GET", Summary = "Gets MovieStoryArc by Key")]
    public class GetMovieStoryArcByKey : ImplementsKey, IReturn<IMovieStoryArcModel> { }

    //[Authenticate]
    [Route("/MovieStoryArcs/Create", "POST", Summary = "Creates an MovieStoryArc with these contents")]
    public class CreateMovieStoryArc : MovieStoryArcModelBase, IReturn<IMovieStoryArcModel> { }

    //[Authenticate]
    [Route("/MovieStoryArcs/Update", "POST", Summary = "Updates an MovieStoryArc with new contents")]
    public class UpdateMovieStoryArc : MovieStoryArcModelBase, IReturn<IMovieStoryArcModel> { }

    //[Authenticate]
    [Route("/MovieStoryArcs/{ID}/Deactivate", "POST", Summary = "Deactivates an MovieStoryArc by Identifier")]
    public class DeactivateMovieStoryArc : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/MovieStoryArcs/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an MovieStoryArc by Key")]
    public class DeactivateMovieStoryArcByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/MovieStoryArcs/{ID}/Remove", "POST", Summary = "Removes an MovieStoryArc by Identifier")]
    public class RemoveMovieStoryArc : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/MovieStoryArcs/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an MovieStoryArc by Key")]
    public class RemoveMovieStoryArcByKey : ImplementsKey, IReturn<bool> { }

    public interface IMovieStoryArcsServices
    {
        List<IMovieStoryArcModel> Any(GetMovieStoryArcs request);
        List<IMovieStoryArcModel> Any(GetMovieStoryArcsAsListing request);
        IMovieStoryArcModel Any(GetMovieStoryArc request);
        IMovieStoryArcModel Any(GetMovieStoryArcByKey request);
        IMovieStoryArcModel Any(CreateMovieStoryArc request);
        IMovieStoryArcModel Any(UpdateMovieStoryArc request);
        bool Any(DeactivateMovieStoryArc request);
        bool Any(DeactivateMovieStoryArcByKey request);
        bool Any(RemoveMovieStoryArc request);
        bool Any(RemoveMovieStoryArcByKey request);
    }

    public class MovieStoryArcsServices : Service, IMovieStoryArcsServices
    {
        private readonly IMovieStoryArcsBusinessWorkflow workflow;

        public MovieStoryArcsServices(IMovieStoryArcsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IMovieStoryArcModel> Any(GetMovieStoryArcs request) { return workflow.Search(request); }
        public List<IMovieStoryArcModel> Any(GetMovieStoryArcsAsListing request) { return workflow.Search(request, true); }
        public IMovieStoryArcModel Any(GetMovieStoryArc request) { return workflow.Get(request.ID); }
        public IMovieStoryArcModel Any(GetMovieStoryArcByKey request) { return workflow.Get(request.CustomKey); }
        public IMovieStoryArcModel Any(CreateMovieStoryArc request) { return workflow.Create(request); }
        public IMovieStoryArcModel Any(UpdateMovieStoryArc request) { return workflow.Update(request); }
        public bool Any(DeactivateMovieStoryArc request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateMovieStoryArcByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveMovieStoryArc request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveMovieStoryArcByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
