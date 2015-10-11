// <auto-generated>
// <copyright file="Characters.ICharacterEnemyTeamModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterEnemyTeam model interfaces.</summary>
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

    public class CharacterEnemyTeamModelBase : NameableEntityModelBase, ICharacterEnemyTeamModel
    {
        // CharacterEnemyTeam Properties
        // <None>
        // Related Objects
        public int CharacterId { get; set; }
        public ICharacterModel Character { get; set; }
        public int EnemyTeamId { get; set; }
        public ITeamModel EnemyTeam { get; set; }
        // Associated Objects
        // <None>
    }
    public class CharacterEnemyTeamSearchModelBase : NameableEntitySearchModelBase, ICharacterEnemyTeamSearchModel
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

        [ApiMember(Name = "EnemyTeamId", IsRequired = false, Description = "Filter by the Related EnemyTeamId")]
        public int? EnemyTeamId { get; set; }

        [ApiMember(Name = "EnemyTeamCustomKey", IsRequired = false, Description = "Filter by the Related EnemyTeam CustomKey (Equals, Case-Insensitive)")]
        public string EnemyTeamCustomKey { get; set; }

        [ApiMember(Name = "EnemyTeamApiDetailUrl", IsRequired = false, Description = "Filter by the Related EnemyTeam Api Detail Url (Contains, Case-Insensitive)")]
        public string EnemyTeamApiDetailUrl { get; set; }

        [ApiMember(Name = "EnemyTeamSiteDetailUrl", IsRequired = false, Description = "Filter by the Related EnemyTeam Site Detail Url (Contains, Case-Insensitive)")]
        public string EnemyTeamSiteDetailUrl { get; set; }

        [ApiMember(Name = "EnemyTeamName", IsRequired = false, Description = "Filter by the Related EnemyTeam Name (Contains, Case-Insensitive)")]
        public string EnemyTeamName { get; set; }

        [ApiMember(Name = "EnemyTeamShortDescription", IsRequired = false, Description = "Filter by the Related EnemyTeam Short Description (Contains, Case-Insensitive)")]
        public string EnemyTeamShortDescription { get; set; }

        [ApiMember(Name = "EnemyTeamDescription", IsRequired = false, Description = "Filter by the Related EnemyTeam Description (Contains, Case-Insensitive)")]
        public string EnemyTeamDescription { get; set; }

    }

    [Route("/CharacterEnemyTeams/", "GET", Summary = "Gets All Active CharacterEnemyTeams")]
    public class GetCharacterEnemyTeams : CharacterEnemyTeamSearchModelBase, IReturn<List<ICharacterEnemyTeamModel>> { }

    [Route("/CharacterEnemyTeams/Listing", "GET", Summary = "Gets All Active CharacterEnemyTeams with the mininum header information")]
    public class GetCharacterEnemyTeamsAsListing : CharacterEnemyTeamSearchModelBase, IReturn<List<ICharacterEnemyTeamModel>> { }

    [Route("/CharacterEnemyTeams/{ID}", "GET", Summary = "Gets CharacterEnemyTeam by Identifier")]
    public class GetCharacterEnemyTeam : ImplementsID, IReturn<ICharacterEnemyTeamModel> { }

    [Route("/CharacterEnemyTeams/{CustomKey}/ByKey", "GET", Summary = "Gets CharacterEnemyTeam by Key")]
    public class GetCharacterEnemyTeamByKey : ImplementsKey, IReturn<ICharacterEnemyTeamModel> { }

    //[Authenticate]
    [Route("/CharacterEnemyTeams/Create", "POST", Summary = "Creates an CharacterEnemyTeam with these contents")]
    public class CreateCharacterEnemyTeam : CharacterEnemyTeamModelBase, IReturn<ICharacterEnemyTeamModel> { }

    //[Authenticate]
    [Route("/CharacterEnemyTeams/Update", "POST", Summary = "Updates an CharacterEnemyTeam with new contents")]
    public class UpdateCharacterEnemyTeam : CharacterEnemyTeamModelBase, IReturn<ICharacterEnemyTeamModel> { }

    //[Authenticate]
    [Route("/CharacterEnemyTeams/{ID}/Deactivate", "POST", Summary = "Deactivates an CharacterEnemyTeam by Identifier")]
    public class DeactivateCharacterEnemyTeam : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/CharacterEnemyTeams/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an CharacterEnemyTeam by Key")]
    public class DeactivateCharacterEnemyTeamByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/CharacterEnemyTeams/{ID}/Remove", "POST", Summary = "Removes an CharacterEnemyTeam by Identifier")]
    public class RemoveCharacterEnemyTeam : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/CharacterEnemyTeams/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an CharacterEnemyTeam by Key")]
    public class RemoveCharacterEnemyTeamByKey : ImplementsKey, IReturn<bool> { }

    public interface ICharacterEnemyTeamsServices
    {
        List<ICharacterEnemyTeamModel> Any(GetCharacterEnemyTeams request);
        List<ICharacterEnemyTeamModel> Any(GetCharacterEnemyTeamsAsListing request);
        ICharacterEnemyTeamModel Any(GetCharacterEnemyTeam request);
        ICharacterEnemyTeamModel Any(GetCharacterEnemyTeamByKey request);
        ICharacterEnemyTeamModel Any(CreateCharacterEnemyTeam request);
        ICharacterEnemyTeamModel Any(UpdateCharacterEnemyTeam request);
        bool Any(DeactivateCharacterEnemyTeam request);
        bool Any(DeactivateCharacterEnemyTeamByKey request);
        bool Any(RemoveCharacterEnemyTeam request);
        bool Any(RemoveCharacterEnemyTeamByKey request);
    }

    public class CharacterEnemyTeamsServices : /*ServicesBase,*/ ICharacterEnemyTeamsServices
    {
        private readonly ICharacterEnemyTeamsBusinessWorkflow workflow;

        public CharacterEnemyTeamsServices(ICharacterEnemyTeamsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ICharacterEnemyTeamModel> Any(GetCharacterEnemyTeams request) { return workflow.Search(request); }
        public List<ICharacterEnemyTeamModel> Any(GetCharacterEnemyTeamsAsListing request) { return workflow.Search(request, true); }
        public ICharacterEnemyTeamModel Any(GetCharacterEnemyTeam request) { return workflow.Get(request.ID); }
        public ICharacterEnemyTeamModel Any(GetCharacterEnemyTeamByKey request) { return workflow.Get(request.CustomKey); }
        public ICharacterEnemyTeamModel Any(CreateCharacterEnemyTeam request) { return workflow.Create(request); }
        public ICharacterEnemyTeamModel Any(UpdateCharacterEnemyTeam request) { return workflow.Update(request); }
        public bool Any(DeactivateCharacterEnemyTeam request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateCharacterEnemyTeamByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveCharacterEnemyTeam request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveCharacterEnemyTeamByKey request) { return workflow.Remove(request.CustomKey); }
    }
}