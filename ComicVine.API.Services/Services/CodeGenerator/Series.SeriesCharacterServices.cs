// <auto-generated>
// <copyright file="Series.ISeriesCharacterModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the SeriesCharacter model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Series
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class SeriesCharacterModelBase : NameableEntityModelBase, ISeriesCharacterModel
    {
        // SeriesCharacter Properties
        // <None>
        // Related Objects
        public int SeriesId { get; set; }
        public ISeriesModel Series { get; set; }
        public int CharacterId { get; set; }
        public ICharacterModel Character { get; set; }
        // Associated Objects
        // <None>
    }
    public class SeriesCharacterSearchModelBase : NameableEntitySearchModelBase, ISeriesCharacterSearchModel
    {
        [ApiMember(Name = "SeriesId", IsRequired = false, Description = "Filter by the Related SeriesId")]
        public int? SeriesId { get; set; }

        [ApiMember(Name = "SeriesCustomKey", IsRequired = false, Description = "Filter by the Related Series CustomKey (Equals, Case-Insensitive)")]
        public string SeriesCustomKey { get; set; }

        [ApiMember(Name = "SeriesApiDetailUrl", IsRequired = false, Description = "Filter by the Related Series Api Detail Url (Contains, Case-Insensitive)")]
        public string SeriesApiDetailUrl { get; set; }

        [ApiMember(Name = "SeriesSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Series Site Detail Url (Contains, Case-Insensitive)")]
        public string SeriesSiteDetailUrl { get; set; }

        [ApiMember(Name = "SeriesName", IsRequired = false, Description = "Filter by the Related Series Name (Contains, Case-Insensitive)")]
        public string SeriesName { get; set; }

        [ApiMember(Name = "SeriesShortDescription", IsRequired = false, Description = "Filter by the Related Series Short Description (Contains, Case-Insensitive)")]
        public string SeriesShortDescription { get; set; }

        [ApiMember(Name = "SeriesDescription", IsRequired = false, Description = "Filter by the Related Series Description (Contains, Case-Insensitive)")]
        public string SeriesDescription { get; set; }

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

    [Route("/SeriesCharacters/", "GET", Summary = "Gets All Active SeriesCharacters")]
    public class GetSeriesCharacters : SeriesCharacterSearchModelBase, IReturn<List<ISeriesCharacterModel>> { }

    [Route("/SeriesCharacters/Listing", "GET", Summary = "Gets All Active SeriesCharacters with the mininum header information")]
    public class GetSeriesCharactersAsListing : SeriesCharacterSearchModelBase, IReturn<List<ISeriesCharacterModel>> { }

    [Route("/SeriesCharacters/{ID}", "GET", Summary = "Gets SeriesCharacter by Identifier")]
    public class GetSeriesCharacter : ImplementsID, IReturn<ISeriesCharacterModel> { }

    [Route("/SeriesCharacters/{CustomKey}/ByKey", "GET", Summary = "Gets SeriesCharacter by Key")]
    public class GetSeriesCharacterByKey : ImplementsKey, IReturn<ISeriesCharacterModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/SeriesCharacters/Create", "POST", Summary = "Creates an SeriesCharacter with these contents")]
    public class CreateSeriesCharacter : SeriesCharacterModelBase, IReturn<ISeriesCharacterModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/SeriesCharacters/Update", "POST", Summary = "Updates an SeriesCharacter with new contents")]
    public class UpdateSeriesCharacter : SeriesCharacterModelBase, IReturn<ISeriesCharacterModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/SeriesCharacters/{ID}/Deactivate", "POST", Summary = "Deactivates an SeriesCharacter by Identifier")]
    public class DeactivateSeriesCharacter : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/SeriesCharacters/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an SeriesCharacter by Key")]
    public class DeactivateSeriesCharacterByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/SeriesCharacters/{ID}/Remove", "POST", Summary = "Removes an SeriesCharacter by Identifier")]
    public class RemoveSeriesCharacter : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/SeriesCharacters/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an SeriesCharacter by Key")]
    public class RemoveSeriesCharacterByKey : ImplementsKey, IReturn<bool> { }

    public interface ISeriesCharactersServices
    {
        List<ISeriesCharacterModel> Any(GetSeriesCharacters request);
        List<ISeriesCharacterModel> Any(GetSeriesCharactersAsListing request);
        ISeriesCharacterModel Any(GetSeriesCharacter request);
        ISeriesCharacterModel Any(GetSeriesCharacterByKey request);
        ISeriesCharacterModel Any(CreateSeriesCharacter request);
        ISeriesCharacterModel Any(UpdateSeriesCharacter request);
        bool Any(DeactivateSeriesCharacter request);
        bool Any(DeactivateSeriesCharacterByKey request);
        bool Any(RemoveSeriesCharacter request);
        bool Any(RemoveSeriesCharacterByKey request);
    }

    public class SeriesCharactersServices : Service, ISeriesCharactersServices
    {
        private readonly ISeriesCharactersBusinessWorkflow workflow;

        public SeriesCharactersServices(ISeriesCharactersBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ISeriesCharacterModel> Any(GetSeriesCharacters request) { return workflow.Search(request); }
        public List<ISeriesCharacterModel> Any(GetSeriesCharactersAsListing request) { return workflow.Search(request, true); }
        public ISeriesCharacterModel Any(GetSeriesCharacter request) { return workflow.Get(request.ID); }
        public ISeriesCharacterModel Any(GetSeriesCharacterByKey request) { return workflow.Get(request.CustomKey); }
        public ISeriesCharacterModel Any(CreateSeriesCharacter request) { return workflow.Create(request); }
        public ISeriesCharacterModel Any(UpdateSeriesCharacter request) { return workflow.Update(request); }
        public bool Any(DeactivateSeriesCharacter request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateSeriesCharacterByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveSeriesCharacter request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveSeriesCharacterByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
