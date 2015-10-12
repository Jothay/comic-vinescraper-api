// <auto-generated>
// <copyright file="Movies.IMovieCharacterModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieCharacter model interfaces.</summary>
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

    public class MovieCharacterModelBase : NameableEntityModelBase, IMovieCharacterModel
    {
        // MovieCharacter Properties
        // <None>
        // Related Objects
        public int MovieId { get; set; }
        public IMovieModel Movie { get; set; }
        public int CharacterId { get; set; }
        public ICharacterModel Character { get; set; }
        // Associated Objects
        // <None>
    }
    public class MovieCharacterSearchModelBase : NameableEntitySearchModelBase, IMovieCharacterSearchModel
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

    }

    [Route("/MovieCharacters/", "GET", Summary = "Gets All Active MovieCharacters")]
    public class GetMovieCharacters : MovieCharacterSearchModelBase, IReturn<List<IMovieCharacterModel>> { }

    [Route("/MovieCharacters/Listing", "GET", Summary = "Gets All Active MovieCharacters with the mininum header information")]
    public class GetMovieCharactersAsListing : MovieCharacterSearchModelBase, IReturn<List<IMovieCharacterModel>> { }

    [Route("/MovieCharacters/{ID}", "GET", Summary = "Gets MovieCharacter by Identifier")]
    public class GetMovieCharacter : ImplementsID, IReturn<IMovieCharacterModel> { }

    [Route("/MovieCharacters/{CustomKey}/ByKey", "GET", Summary = "Gets MovieCharacter by Key")]
    public class GetMovieCharacterByKey : ImplementsKey, IReturn<IMovieCharacterModel> { }

    //[Authenticate]
    [Route("/MovieCharacters/Create", "POST", Summary = "Creates an MovieCharacter with these contents")]
    public class CreateMovieCharacter : MovieCharacterModelBase, IReturn<IMovieCharacterModel> { }

    //[Authenticate]
    [Route("/MovieCharacters/Update", "POST", Summary = "Updates an MovieCharacter with new contents")]
    public class UpdateMovieCharacter : MovieCharacterModelBase, IReturn<IMovieCharacterModel> { }

    //[Authenticate]
    [Route("/MovieCharacters/{ID}/Deactivate", "POST", Summary = "Deactivates an MovieCharacter by Identifier")]
    public class DeactivateMovieCharacter : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/MovieCharacters/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an MovieCharacter by Key")]
    public class DeactivateMovieCharacterByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/MovieCharacters/{ID}/Remove", "POST", Summary = "Removes an MovieCharacter by Identifier")]
    public class RemoveMovieCharacter : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/MovieCharacters/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an MovieCharacter by Key")]
    public class RemoveMovieCharacterByKey : ImplementsKey, IReturn<bool> { }

    public interface IMovieCharactersServices
    {
        List<IMovieCharacterModel> Any(GetMovieCharacters request);
        List<IMovieCharacterModel> Any(GetMovieCharactersAsListing request);
        IMovieCharacterModel Any(GetMovieCharacter request);
        IMovieCharacterModel Any(GetMovieCharacterByKey request);
        IMovieCharacterModel Any(CreateMovieCharacter request);
        IMovieCharacterModel Any(UpdateMovieCharacter request);
        bool Any(DeactivateMovieCharacter request);
        bool Any(DeactivateMovieCharacterByKey request);
        bool Any(RemoveMovieCharacter request);
        bool Any(RemoveMovieCharacterByKey request);
    }

    public class MovieCharactersServices : Service, IMovieCharactersServices
    {
        private readonly IMovieCharactersBusinessWorkflow workflow;

        public MovieCharactersServices(IMovieCharactersBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IMovieCharacterModel> Any(GetMovieCharacters request) { return workflow.Search(request); }
        public List<IMovieCharacterModel> Any(GetMovieCharactersAsListing request) { return workflow.Search(request, true); }
        public IMovieCharacterModel Any(GetMovieCharacter request) { return workflow.Get(request.ID); }
        public IMovieCharacterModel Any(GetMovieCharacterByKey request) { return workflow.Get(request.CustomKey); }
        public IMovieCharacterModel Any(CreateMovieCharacter request) { return workflow.Create(request); }
        public IMovieCharacterModel Any(UpdateMovieCharacter request) { return workflow.Update(request); }
        public bool Any(DeactivateMovieCharacter request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateMovieCharacterByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveMovieCharacter request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveMovieCharacterByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
