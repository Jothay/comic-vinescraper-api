// <auto-generated>
// <copyright file="Characters.ICharacterMovieModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterMovie model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Characters
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class CharacterMovieModelBase : NameableEntityModelBase, ICharacterMovieModel
    {
        // CharacterMovie Properties
        // <None>
        // Related Objects
        public int CharacterId { get; set; }
        public ICharacterModel Character { get; set; }
        public int MovieId { get; set; }
        public IMovieModel Movie { get; set; }
        // Associated Objects
        // <None>
    }
    public class CharacterMovieSearchModelBase : NameableEntitySearchModelBase, ICharacterMovieSearchModel
    {
        [ApiMember(Name = "CharacterId", IsRequired = false, Description = "Filter by the Related CharacterId")]
        public int? CharacterId { get; set; }

        [ApiMember(Name = "CharacterCustomKey", IsRequired = false, Description = "Filter by the Related Character CustomKey (Equals, Case-Insensitive)")]
        public string CharacterCustomKey { get; set; }

        [ApiMember(Name = "CharacterApiDetailUrl", IsRequired = false, Description = "Filter by the Related Character Api Detail Url (Contains, Case-Insensitive)")]
        public string CharacterApiDetailUrl { get; set; }

        [ApiMember(Name = "CharacterSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Character Site Detail Url (Contains, Case-Insensitive)")]
        public string CharacterSiteDetailUrl { get; set; }

        [ApiMember(Name = "CharacterName", IsRequired = false, Description = "Filter by the Related Character Name (Contains, Case-Insensitive)")]
        public string CharacterName { get; set; }

        [ApiMember(Name = "CharacterShortDescription", IsRequired = false, Description = "Filter by the Related Character Short Description (Contains, Case-Insensitive)")]
        public string CharacterShortDescription { get; set; }

        [ApiMember(Name = "CharacterDescription", IsRequired = false, Description = "Filter by the Related Character Description (Contains, Case-Insensitive)")]
        public string CharacterDescription { get; set; }

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

    [Route("/CharacterMovies/", "GET", Summary = "Gets All Active CharacterMovies")]
    public class GetCharacterMovies : CharacterMovieSearchModelBase, IReturn<List<ICharacterMovieModel>> { }

    [Route("/CharacterMovies/Listing", "GET", Summary = "Gets All Active CharacterMovies with the mininum header information")]
    public class GetCharacterMoviesAsListing : CharacterMovieSearchModelBase, IReturn<List<ICharacterMovieModel>> { }

    [Route("/CharacterMovies/{ID}", "GET", Summary = "Gets CharacterMovie by Identifier")]
    public class GetCharacterMovie : ImplementsID, IReturn<ICharacterMovieModel> { }

    [Route("/CharacterMovies/{CustomKey}/ByKey", "GET", Summary = "Gets CharacterMovie by Key")]
    public class GetCharacterMovieByKey : ImplementsKey, IReturn<ICharacterMovieModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterMovies/Create", "POST", Summary = "Creates an CharacterMovie with these contents")]
    public class CreateCharacterMovie : CharacterMovieModelBase, IReturn<ICharacterMovieModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterMovies/Update", "POST", Summary = "Updates an CharacterMovie with new contents")]
    public class UpdateCharacterMovie : CharacterMovieModelBase, IReturn<ICharacterMovieModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterMovies/{ID}/Deactivate", "POST", Summary = "Deactivates an CharacterMovie by Identifier")]
    public class DeactivateCharacterMovie : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterMovies/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an CharacterMovie by Key")]
    public class DeactivateCharacterMovieByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterMovies/{ID}/Remove", "POST", Summary = "Removes an CharacterMovie by Identifier")]
    public class RemoveCharacterMovie : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterMovies/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an CharacterMovie by Key")]
    public class RemoveCharacterMovieByKey : ImplementsKey, IReturn<bool> { }

    public interface ICharacterMoviesServices
    {
        List<ICharacterMovieModel> Any(GetCharacterMovies request);
        List<ICharacterMovieModel> Any(GetCharacterMoviesAsListing request);
        ICharacterMovieModel Any(GetCharacterMovie request);
        ICharacterMovieModel Any(GetCharacterMovieByKey request);
        ICharacterMovieModel Any(CreateCharacterMovie request);
        ICharacterMovieModel Any(UpdateCharacterMovie request);
        bool Any(DeactivateCharacterMovie request);
        bool Any(DeactivateCharacterMovieByKey request);
        bool Any(RemoveCharacterMovie request);
        bool Any(RemoveCharacterMovieByKey request);
    }

    public class CharacterMoviesServices : Service, ICharacterMoviesServices
    {
        private readonly ICharacterMoviesBusinessWorkflow workflow;

        public CharacterMoviesServices(ICharacterMoviesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ICharacterMovieModel> Any(GetCharacterMovies request) { return workflow.Search(request); }
        public List<ICharacterMovieModel> Any(GetCharacterMoviesAsListing request) { return workflow.Search(request, true); }
        public ICharacterMovieModel Any(GetCharacterMovie request) { return workflow.Get(request.ID); }
        public ICharacterMovieModel Any(GetCharacterMovieByKey request) { return workflow.Get(request.CustomKey); }
        public ICharacterMovieModel Any(CreateCharacterMovie request) { return workflow.Create(request); }
        public ICharacterMovieModel Any(UpdateCharacterMovie request) { return workflow.Update(request); }
        public bool Any(DeactivateCharacterMovie request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateCharacterMovieByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveCharacterMovie request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveCharacterMovieByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
