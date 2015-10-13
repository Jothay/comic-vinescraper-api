// <auto-generated>
// <copyright file="Teams.ITeamCharacterEnemyModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamCharacterEnemy model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Teams
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class TeamCharacterEnemyModelBase : NameableEntityModelBase, ITeamCharacterEnemyModel
    {
        // TeamCharacterEnemy Properties
        // <None>
        // Related Objects
        public int TeamId { get; set; }
        public ITeamModel Team { get; set; }
        public int EnemyId { get; set; }
        public ICharacterModel Enemy { get; set; }
        // Associated Objects
        // <None>
    }
    public class TeamCharacterEnemySearchModelBase : NameableEntitySearchModelBase, ITeamCharacterEnemySearchModel
    {
        [ApiMember(Name = "TeamId", IsRequired = false, Description = "Filter by the Related TeamId")]
        public int? TeamId { get; set; }

        [ApiMember(Name = "TeamCustomKey", IsRequired = false, Description = "Filter by the Related Team CustomKey (Equals, Case-Insensitive)")]
        public string TeamCustomKey { get; set; }

        [ApiMember(Name = "TeamApiDetailUrl", IsRequired = false, Description = "Filter by the Related Team Api Detail Url (Contains, Case-Insensitive)")]
        public string TeamApiDetailUrl { get; set; }

        [ApiMember(Name = "TeamSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Team Site Detail Url (Contains, Case-Insensitive)")]
        public string TeamSiteDetailUrl { get; set; }

        [ApiMember(Name = "TeamName", IsRequired = false, Description = "Filter by the Related Team Name (Contains, Case-Insensitive)")]
        public string TeamName { get; set; }

        [ApiMember(Name = "TeamShortDescription", IsRequired = false, Description = "Filter by the Related Team Short Description (Contains, Case-Insensitive)")]
        public string TeamShortDescription { get; set; }

        [ApiMember(Name = "TeamDescription", IsRequired = false, Description = "Filter by the Related Team Description (Contains, Case-Insensitive)")]
        public string TeamDescription { get; set; }

        [ApiMember(Name = "EnemyId", IsRequired = false, Description = "Filter by the Related EnemyId")]
        public int? EnemyId { get; set; }

        [ApiMember(Name = "EnemyCustomKey", IsRequired = false, Description = "Filter by the Related Enemy CustomKey (Equals, Case-Insensitive)")]
        public string EnemyCustomKey { get; set; }

        [ApiMember(Name = "EnemyApiDetailUrl", IsRequired = false, Description = "Filter by the Related Enemy Api Detail Url (Contains, Case-Insensitive)")]
        public string EnemyApiDetailUrl { get; set; }

        [ApiMember(Name = "EnemySiteDetailUrl", IsRequired = false, Description = "Filter by the Related Enemy Site Detail Url (Contains, Case-Insensitive)")]
        public string EnemySiteDetailUrl { get; set; }

        [ApiMember(Name = "EnemyName", IsRequired = false, Description = "Filter by the Related Enemy Name (Contains, Case-Insensitive)")]
        public string EnemyName { get; set; }

        [ApiMember(Name = "EnemyShortDescription", IsRequired = false, Description = "Filter by the Related Enemy Short Description (Contains, Case-Insensitive)")]
        public string EnemyShortDescription { get; set; }

        [ApiMember(Name = "EnemyDescription", IsRequired = false, Description = "Filter by the Related Enemy Description (Contains, Case-Insensitive)")]
        public string EnemyDescription { get; set; }

    }

    [Route("/TeamCharacterEnemies/", "GET", Summary = "Gets All Active TeamCharacterEnemies")]
    public class GetTeamCharacterEnemies : TeamCharacterEnemySearchModelBase, IReturn<List<ITeamCharacterEnemyModel>> { }

    [Route("/TeamCharacterEnemies/Listing", "GET", Summary = "Gets All Active TeamCharacterEnemies with the mininum header information")]
    public class GetTeamCharacterEnemiesAsListing : TeamCharacterEnemySearchModelBase, IReturn<List<ITeamCharacterEnemyModel>> { }

    [Route("/TeamCharacterEnemies/{ID}", "GET", Summary = "Gets TeamCharacterEnemy by Identifier")]
    public class GetTeamCharacterEnemy : ImplementsID, IReturn<ITeamCharacterEnemyModel> { }

    [Route("/TeamCharacterEnemies/{CustomKey}/ByKey", "GET", Summary = "Gets TeamCharacterEnemy by Key")]
    public class GetTeamCharacterEnemyByKey : ImplementsKey, IReturn<ITeamCharacterEnemyModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamCharacterEnemies/Create", "POST", Summary = "Creates an TeamCharacterEnemy with these contents")]
    public class CreateTeamCharacterEnemy : TeamCharacterEnemyModelBase, IReturn<ITeamCharacterEnemyModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamCharacterEnemies/Update", "POST", Summary = "Updates an TeamCharacterEnemy with new contents")]
    public class UpdateTeamCharacterEnemy : TeamCharacterEnemyModelBase, IReturn<ITeamCharacterEnemyModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamCharacterEnemies/{ID}/Deactivate", "POST", Summary = "Deactivates an TeamCharacterEnemy by Identifier")]
    public class DeactivateTeamCharacterEnemy : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamCharacterEnemies/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an TeamCharacterEnemy by Key")]
    public class DeactivateTeamCharacterEnemyByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamCharacterEnemies/{ID}/Remove", "POST", Summary = "Removes an TeamCharacterEnemy by Identifier")]
    public class RemoveTeamCharacterEnemy : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamCharacterEnemies/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an TeamCharacterEnemy by Key")]
    public class RemoveTeamCharacterEnemyByKey : ImplementsKey, IReturn<bool> { }

    public interface ITeamCharacterEnemiesServices
    {
        List<ITeamCharacterEnemyModel> Any(GetTeamCharacterEnemies request);
        List<ITeamCharacterEnemyModel> Any(GetTeamCharacterEnemiesAsListing request);
        ITeamCharacterEnemyModel Any(GetTeamCharacterEnemy request);
        ITeamCharacterEnemyModel Any(GetTeamCharacterEnemyByKey request);
        ITeamCharacterEnemyModel Any(CreateTeamCharacterEnemy request);
        ITeamCharacterEnemyModel Any(UpdateTeamCharacterEnemy request);
        bool Any(DeactivateTeamCharacterEnemy request);
        bool Any(DeactivateTeamCharacterEnemyByKey request);
        bool Any(RemoveTeamCharacterEnemy request);
        bool Any(RemoveTeamCharacterEnemyByKey request);
    }

    public class TeamCharacterEnemiesServices : Service, ITeamCharacterEnemiesServices
    {
        private readonly ITeamCharacterEnemiesBusinessWorkflow workflow;

        public TeamCharacterEnemiesServices(ITeamCharacterEnemiesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ITeamCharacterEnemyModel> Any(GetTeamCharacterEnemies request) { return workflow.Search(request); }
        public List<ITeamCharacterEnemyModel> Any(GetTeamCharacterEnemiesAsListing request) { return workflow.Search(request, true); }
        public ITeamCharacterEnemyModel Any(GetTeamCharacterEnemy request) { return workflow.Get(request.ID); }
        public ITeamCharacterEnemyModel Any(GetTeamCharacterEnemyByKey request) { return workflow.Get(request.CustomKey); }
        public ITeamCharacterEnemyModel Any(CreateTeamCharacterEnemy request) { return workflow.Create(request); }
        public ITeamCharacterEnemyModel Any(UpdateTeamCharacterEnemy request) { return workflow.Update(request); }
        public bool Any(DeactivateTeamCharacterEnemy request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateTeamCharacterEnemyByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveTeamCharacterEnemy request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveTeamCharacterEnemyByKey request) { return workflow.Remove(request.CustomKey); }
    }
}