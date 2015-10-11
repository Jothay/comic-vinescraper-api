// <auto-generated>
// <copyright file="Characters.ICharacterFriendlyTeamModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterFriendlyTeam model interfaces.</summary>
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

    public class CharacterFriendlyTeamModelBase : NameableEntityModelBase, ICharacterFriendlyTeamModel
    {
        // CharacterFriendlyTeam Properties
        // <None>
        // Related Objects
        public int CharacterId { get; set; }
        public ICharacterModel Character { get; set; }
        public int FriendlyTeamId { get; set; }
        public ITeamModel FriendlyTeam { get; set; }
        // Associated Objects
        // <None>
    }
    public class CharacterFriendlyTeamSearchModelBase : NameableEntitySearchModelBase, ICharacterFriendlyTeamSearchModel
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

        [ApiMember(Name = "FriendlyTeamId", IsRequired = false, Description = "Filter by the Related FriendlyTeamId")]
        public int? FriendlyTeamId { get; set; }

        [ApiMember(Name = "FriendlyTeamCustomKey", IsRequired = false, Description = "Filter by the Related FriendlyTeam CustomKey (Equals, Case-Insensitive)")]
        public string FriendlyTeamCustomKey { get; set; }

        [ApiMember(Name = "FriendlyTeamApiDetailUrl", IsRequired = false, Description = "Filter by the Related FriendlyTeam Api Detail Url (Contains, Case-Insensitive)")]
        public string FriendlyTeamApiDetailUrl { get; set; }

        [ApiMember(Name = "FriendlyTeamSiteDetailUrl", IsRequired = false, Description = "Filter by the Related FriendlyTeam Site Detail Url (Contains, Case-Insensitive)")]
        public string FriendlyTeamSiteDetailUrl { get; set; }

        [ApiMember(Name = "FriendlyTeamName", IsRequired = false, Description = "Filter by the Related FriendlyTeam Name (Contains, Case-Insensitive)")]
        public string FriendlyTeamName { get; set; }

        [ApiMember(Name = "FriendlyTeamShortDescription", IsRequired = false, Description = "Filter by the Related FriendlyTeam Short Description (Contains, Case-Insensitive)")]
        public string FriendlyTeamShortDescription { get; set; }

        [ApiMember(Name = "FriendlyTeamDescription", IsRequired = false, Description = "Filter by the Related FriendlyTeam Description (Contains, Case-Insensitive)")]
        public string FriendlyTeamDescription { get; set; }

    }

    [Route("/CharacterFriendlyTeams/", "GET", Summary = "Gets All Active CharacterFriendlyTeams")]
    public class GetCharacterFriendlyTeams : CharacterFriendlyTeamSearchModelBase, IReturn<List<ICharacterFriendlyTeamModel>> { }

    [Route("/CharacterFriendlyTeams/Listing", "GET", Summary = "Gets All Active CharacterFriendlyTeams with the mininum header information")]
    public class GetCharacterFriendlyTeamsAsListing : CharacterFriendlyTeamSearchModelBase, IReturn<List<ICharacterFriendlyTeamModel>> { }

    [Route("/CharacterFriendlyTeams/{ID}", "GET", Summary = "Gets CharacterFriendlyTeam by Identifier")]
    public class GetCharacterFriendlyTeam : ImplementsID, IReturn<ICharacterFriendlyTeamModel> { }

    [Route("/CharacterFriendlyTeams/{CustomKey}/ByKey", "GET", Summary = "Gets CharacterFriendlyTeam by Key")]
    public class GetCharacterFriendlyTeamByKey : ImplementsKey, IReturn<ICharacterFriendlyTeamModel> { }

    //[Authenticate]
    [Route("/CharacterFriendlyTeams/Create", "POST", Summary = "Creates an CharacterFriendlyTeam with these contents")]
    public class CreateCharacterFriendlyTeam : CharacterFriendlyTeamModelBase, IReturn<ICharacterFriendlyTeamModel> { }

    //[Authenticate]
    [Route("/CharacterFriendlyTeams/Update", "POST", Summary = "Updates an CharacterFriendlyTeam with new contents")]
    public class UpdateCharacterFriendlyTeam : CharacterFriendlyTeamModelBase, IReturn<ICharacterFriendlyTeamModel> { }

    //[Authenticate]
    [Route("/CharacterFriendlyTeams/{ID}/Deactivate", "POST", Summary = "Deactivates an CharacterFriendlyTeam by Identifier")]
    public class DeactivateCharacterFriendlyTeam : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/CharacterFriendlyTeams/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an CharacterFriendlyTeam by Key")]
    public class DeactivateCharacterFriendlyTeamByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/CharacterFriendlyTeams/{ID}/Remove", "POST", Summary = "Removes an CharacterFriendlyTeam by Identifier")]
    public class RemoveCharacterFriendlyTeam : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/CharacterFriendlyTeams/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an CharacterFriendlyTeam by Key")]
    public class RemoveCharacterFriendlyTeamByKey : ImplementsKey, IReturn<bool> { }

    public interface ICharacterFriendlyTeamsServices
    {
        List<ICharacterFriendlyTeamModel> Any(GetCharacterFriendlyTeams request);
        List<ICharacterFriendlyTeamModel> Any(GetCharacterFriendlyTeamsAsListing request);
        ICharacterFriendlyTeamModel Any(GetCharacterFriendlyTeam request);
        ICharacterFriendlyTeamModel Any(GetCharacterFriendlyTeamByKey request);
        ICharacterFriendlyTeamModel Any(CreateCharacterFriendlyTeam request);
        ICharacterFriendlyTeamModel Any(UpdateCharacterFriendlyTeam request);
        bool Any(DeactivateCharacterFriendlyTeam request);
        bool Any(DeactivateCharacterFriendlyTeamByKey request);
        bool Any(RemoveCharacterFriendlyTeam request);
        bool Any(RemoveCharacterFriendlyTeamByKey request);
    }

    public class CharacterFriendlyTeamsServices : /*ServicesBase,*/ ICharacterFriendlyTeamsServices
    {
        private readonly ICharacterFriendlyTeamsBusinessWorkflow workflow;

        public CharacterFriendlyTeamsServices(ICharacterFriendlyTeamsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ICharacterFriendlyTeamModel> Any(GetCharacterFriendlyTeams request) { return workflow.Search(request); }
        public List<ICharacterFriendlyTeamModel> Any(GetCharacterFriendlyTeamsAsListing request) { return workflow.Search(request, true); }
        public ICharacterFriendlyTeamModel Any(GetCharacterFriendlyTeam request) { return workflow.Get(request.ID); }
        public ICharacterFriendlyTeamModel Any(GetCharacterFriendlyTeamByKey request) { return workflow.Get(request.CustomKey); }
        public ICharacterFriendlyTeamModel Any(CreateCharacterFriendlyTeam request) { return workflow.Create(request); }
        public ICharacterFriendlyTeamModel Any(UpdateCharacterFriendlyTeam request) { return workflow.Update(request); }
        public bool Any(DeactivateCharacterFriendlyTeam request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateCharacterFriendlyTeamByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveCharacterFriendlyTeam request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveCharacterFriendlyTeamByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
