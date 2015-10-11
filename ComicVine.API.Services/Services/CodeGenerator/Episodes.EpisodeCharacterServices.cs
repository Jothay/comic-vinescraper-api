// <auto-generated>
// <copyright file="Episodes.IEpisodeCharacterModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeCharacter model interfaces.</summary>
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

    public class EpisodeCharacterModelBase : NameableEntityModelBase, IEpisodeCharacterModel
    {
        // EpisodeCharacter Properties
        // <None>
        // Related Objects
        public int EpisodeId { get; set; }
        public IEpisodeModel Episode { get; set; }
        public int CharacterId { get; set; }
        public ICharacterModel Character { get; set; }
        // Associated Objects
        // <None>
    }
    public class EpisodeCharacterSearchModelBase : NameableEntitySearchModelBase, IEpisodeCharacterSearchModel
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

    [Route("/EpisodeCharacters/", "GET", Summary = "Gets All Active EpisodeCharacters")]
    public class GetEpisodeCharacters : EpisodeCharacterSearchModelBase, IReturn<List<IEpisodeCharacterModel>> { }

    [Route("/EpisodeCharacters/Listing", "GET", Summary = "Gets All Active EpisodeCharacters with the mininum header information")]
    public class GetEpisodeCharactersAsListing : EpisodeCharacterSearchModelBase, IReturn<List<IEpisodeCharacterModel>> { }

    [Route("/EpisodeCharacters/{ID}", "GET", Summary = "Gets EpisodeCharacter by Identifier")]
    public class GetEpisodeCharacter : ImplementsID, IReturn<IEpisodeCharacterModel> { }

    [Route("/EpisodeCharacters/{CustomKey}/ByKey", "GET", Summary = "Gets EpisodeCharacter by Key")]
    public class GetEpisodeCharacterByKey : ImplementsKey, IReturn<IEpisodeCharacterModel> { }

    //[Authenticate]
    [Route("/EpisodeCharacters/Create", "POST", Summary = "Creates an EpisodeCharacter with these contents")]
    public class CreateEpisodeCharacter : EpisodeCharacterModelBase, IReturn<IEpisodeCharacterModel> { }

    //[Authenticate]
    [Route("/EpisodeCharacters/Update", "POST", Summary = "Updates an EpisodeCharacter with new contents")]
    public class UpdateEpisodeCharacter : EpisodeCharacterModelBase, IReturn<IEpisodeCharacterModel> { }

    //[Authenticate]
    [Route("/EpisodeCharacters/{ID}/Deactivate", "POST", Summary = "Deactivates an EpisodeCharacter by Identifier")]
    public class DeactivateEpisodeCharacter : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/EpisodeCharacters/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an EpisodeCharacter by Key")]
    public class DeactivateEpisodeCharacterByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/EpisodeCharacters/{ID}/Remove", "POST", Summary = "Removes an EpisodeCharacter by Identifier")]
    public class RemoveEpisodeCharacter : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/EpisodeCharacters/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an EpisodeCharacter by Key")]
    public class RemoveEpisodeCharacterByKey : ImplementsKey, IReturn<bool> { }

    public interface IEpisodeCharactersServices
    {
        List<IEpisodeCharacterModel> Any(GetEpisodeCharacters request);
        List<IEpisodeCharacterModel> Any(GetEpisodeCharactersAsListing request);
        IEpisodeCharacterModel Any(GetEpisodeCharacter request);
        IEpisodeCharacterModel Any(GetEpisodeCharacterByKey request);
        IEpisodeCharacterModel Any(CreateEpisodeCharacter request);
        IEpisodeCharacterModel Any(UpdateEpisodeCharacter request);
        bool Any(DeactivateEpisodeCharacter request);
        bool Any(DeactivateEpisodeCharacterByKey request);
        bool Any(RemoveEpisodeCharacter request);
        bool Any(RemoveEpisodeCharacterByKey request);
    }

    public class EpisodeCharactersServices : /*ServicesBase,*/ IEpisodeCharactersServices
    {
        private readonly IEpisodeCharactersBusinessWorkflow workflow;

        public EpisodeCharactersServices(IEpisodeCharactersBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IEpisodeCharacterModel> Any(GetEpisodeCharacters request) { return workflow.Search(request); }
        public List<IEpisodeCharacterModel> Any(GetEpisodeCharactersAsListing request) { return workflow.Search(request, true); }
        public IEpisodeCharacterModel Any(GetEpisodeCharacter request) { return workflow.Get(request.ID); }
        public IEpisodeCharacterModel Any(GetEpisodeCharacterByKey request) { return workflow.Get(request.CustomKey); }
        public IEpisodeCharacterModel Any(CreateEpisodeCharacter request) { return workflow.Create(request); }
        public IEpisodeCharacterModel Any(UpdateEpisodeCharacter request) { return workflow.Update(request); }
        public bool Any(DeactivateEpisodeCharacter request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateEpisodeCharacterByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveEpisodeCharacter request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveEpisodeCharacterByKey request) { return workflow.Remove(request.CustomKey); }
    }
}