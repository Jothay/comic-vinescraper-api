// <auto-generated>
// <copyright file="Characters.ICharacterAliasServices.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the CharacterAlias ServiceStack DTOs and Handlers.</summary>
// <remarks>This file was auto-generated using ServiceFileMaster.tt in
// ComicVineScraper.API.Services\Framework\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Services//.Characters
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class CharacterAliasModelBase : NameableEntityModelBase, ICharacterAliasModel
    {
        // CharacterAlias Properties
        // <None>
        // Related Objects
        public int CharacterId { get; set; }
        public ICharacterModel Character { get; set; }
        // Associated Objects
        // <None>
    }
    public class CharacterAliasSearchModelBase : NameableEntitySearchModelBase, ICharacterAliasSearchModel
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

    }

    [Route("/CharacterAliases/", "GET", Summary = "Gets All Active CharacterAliases")]
    public class GetCharacterAliases : CharacterAliasSearchModelBase, IReturn<List<ICharacterAliasModel>> { }

    [Route("/CharacterAliases/Listing", "GET", Summary = "Gets All Active CharacterAliases with the mininum header information")]
    public class GetCharacterAliasesAsListing : CharacterAliasSearchModelBase, IReturn<List<ICharacterAliasModel>> { }

    [Route("/CharacterAliases/{ID}", "GET", Summary = "Gets CharacterAlias by Identifier")]
    public class GetCharacterAlias : ImplementsID, IReturn<ICharacterAliasModel> { }

    [Route("/CharacterAliases/{CustomKey}/ByKey", "GET", Summary = "Gets CharacterAlias by Key")]
    public class GetCharacterAliasByKey : ImplementsKey, IReturn<ICharacterAliasModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterAliases/Create", "POST", Summary = "Creates an CharacterAlias with these contents")]
    public class CreateCharacterAlias : CharacterAliasModelBase, IReturn<ICharacterAliasModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterAliases/Update", "POST", Summary = "Updates an CharacterAlias with new contents")]
    public class UpdateCharacterAlias : CharacterAliasModelBase, IReturn<ICharacterAliasModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterAliases/{ID}/Deactivate", "POST", Summary = "Deactivates an CharacterAlias by Identifier")]
    public class DeactivateCharacterAlias : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterAliases/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an CharacterAlias by Key")]
    public class DeactivateCharacterAliasByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterAliases/{ID}/Remove", "POST", Summary = "Removes an CharacterAlias by Identifier")]
    public class RemoveCharacterAlias : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterAliases/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an CharacterAlias by Key")]
    public class RemoveCharacterAliasByKey : ImplementsKey, IReturn<bool> { }

    public interface ICharacterAliasesServices
    {
        List<ICharacterAliasModel> Any(GetCharacterAliases request);
        List<ICharacterAliasModel> Any(GetCharacterAliasesAsListing request);
        ICharacterAliasModel Any(GetCharacterAlias request);
        ICharacterAliasModel Any(GetCharacterAliasByKey request);
        ICharacterAliasModel Any(CreateCharacterAlias request);
        ICharacterAliasModel Any(UpdateCharacterAlias request);
        bool Any(DeactivateCharacterAlias request);
        bool Any(DeactivateCharacterAliasByKey request);
        bool Any(RemoveCharacterAlias request);
        bool Any(RemoveCharacterAliasByKey request);
    }

    public class CharacterAliasesServices : Service, ICharacterAliasesServices
    {
        private readonly ICharacterAliasesBusinessWorkflow workflow;

        public CharacterAliasesServices(ICharacterAliasesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ICharacterAliasModel> Any(GetCharacterAliases request) { return workflow.Search(request); }
        public List<ICharacterAliasModel> Any(GetCharacterAliasesAsListing request) { return workflow.Search(request, true); }
        public ICharacterAliasModel Any(GetCharacterAlias request) { return workflow.Get(request.ID); }
        public ICharacterAliasModel Any(GetCharacterAliasByKey request) { return workflow.Get(request.CustomKey); }
        public ICharacterAliasModel Any(CreateCharacterAlias request) { return workflow.Create(request); }
        public ICharacterAliasModel Any(UpdateCharacterAlias request) { return workflow.Update(request); }
        public bool Any(DeactivateCharacterAlias request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateCharacterAliasByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveCharacterAlias request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveCharacterAliasByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
