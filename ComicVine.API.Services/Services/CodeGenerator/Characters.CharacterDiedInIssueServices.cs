// <auto-generated>
// <copyright file="Characters.ICharacterDiedInIssueModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterDiedInIssue model interfaces.</summary>
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

    public class CharacterDiedInIssueModelBase : NameableEntityModelBase, ICharacterDiedInIssueModel
    {
        // CharacterDiedInIssue Properties
        // <None>
        // Related Objects
        public int CharacterId { get; set; }
        public ICharacterModel Character { get; set; }
        public int DiedInIssueId { get; set; }
        public IIssueModel DiedInIssue { get; set; }
        // Associated Objects
        // <None>
    }
    public class CharacterDiedInIssueSearchModelBase : NameableEntitySearchModelBase, ICharacterDiedInIssueSearchModel
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

        [ApiMember(Name = "DiedInIssueId", IsRequired = false, Description = "Filter by the Related DiedInIssueId")]
        public int? DiedInIssueId { get; set; }

        [ApiMember(Name = "DiedInIssueCustomKey", IsRequired = false, Description = "Filter by the Related DiedInIssue CustomKey (Equals, Case-Insensitive)")]
        public string DiedInIssueCustomKey { get; set; }

        [ApiMember(Name = "DiedInIssueApiDetailUrl", IsRequired = false, Description = "Filter by the Related DiedInIssue Api Detail Url (Contains, Case-Insensitive)")]
        public string DiedInIssueApiDetailUrl { get; set; }

        [ApiMember(Name = "DiedInIssueSiteDetailUrl", IsRequired = false, Description = "Filter by the Related DiedInIssue Site Detail Url (Contains, Case-Insensitive)")]
        public string DiedInIssueSiteDetailUrl { get; set; }

        [ApiMember(Name = "DiedInIssueName", IsRequired = false, Description = "Filter by the Related DiedInIssue Name (Contains, Case-Insensitive)")]
        public string DiedInIssueName { get; set; }

        [ApiMember(Name = "DiedInIssueShortDescription", IsRequired = false, Description = "Filter by the Related DiedInIssue Short Description (Contains, Case-Insensitive)")]
        public string DiedInIssueShortDescription { get; set; }

        [ApiMember(Name = "DiedInIssueDescription", IsRequired = false, Description = "Filter by the Related DiedInIssue Description (Contains, Case-Insensitive)")]
        public string DiedInIssueDescription { get; set; }

    }

    [Route("/CharacterDiedInIssues/", "GET", Summary = "Gets All Active CharacterDiedInIssues")]
    public class GetCharacterDiedInIssues : CharacterDiedInIssueSearchModelBase, IReturn<List<ICharacterDiedInIssueModel>> { }

    [Route("/CharacterDiedInIssues/Listing", "GET", Summary = "Gets All Active CharacterDiedInIssues with the mininum header information")]
    public class GetCharacterDiedInIssuesAsListing : CharacterDiedInIssueSearchModelBase, IReturn<List<ICharacterDiedInIssueModel>> { }

    [Route("/CharacterDiedInIssues/{ID}", "GET", Summary = "Gets CharacterDiedInIssue by Identifier")]
    public class GetCharacterDiedInIssue : ImplementsID, IReturn<ICharacterDiedInIssueModel> { }

    [Route("/CharacterDiedInIssues/{CustomKey}/ByKey", "GET", Summary = "Gets CharacterDiedInIssue by Key")]
    public class GetCharacterDiedInIssueByKey : ImplementsKey, IReturn<ICharacterDiedInIssueModel> { }

    //[Authenticate]
    [Route("/CharacterDiedInIssues/Create", "POST", Summary = "Creates an CharacterDiedInIssue with these contents")]
    public class CreateCharacterDiedInIssue : CharacterDiedInIssueModelBase, IReturn<ICharacterDiedInIssueModel> { }

    //[Authenticate]
    [Route("/CharacterDiedInIssues/Update", "POST", Summary = "Updates an CharacterDiedInIssue with new contents")]
    public class UpdateCharacterDiedInIssue : CharacterDiedInIssueModelBase, IReturn<ICharacterDiedInIssueModel> { }

    //[Authenticate]
    [Route("/CharacterDiedInIssues/{ID}/Deactivate", "POST", Summary = "Deactivates an CharacterDiedInIssue by Identifier")]
    public class DeactivateCharacterDiedInIssue : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/CharacterDiedInIssues/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an CharacterDiedInIssue by Key")]
    public class DeactivateCharacterDiedInIssueByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/CharacterDiedInIssues/{ID}/Remove", "POST", Summary = "Removes an CharacterDiedInIssue by Identifier")]
    public class RemoveCharacterDiedInIssue : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/CharacterDiedInIssues/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an CharacterDiedInIssue by Key")]
    public class RemoveCharacterDiedInIssueByKey : ImplementsKey, IReturn<bool> { }

    public interface ICharacterDiedInIssuesServices
    {
        List<ICharacterDiedInIssueModel> Any(GetCharacterDiedInIssues request);
        List<ICharacterDiedInIssueModel> Any(GetCharacterDiedInIssuesAsListing request);
        ICharacterDiedInIssueModel Any(GetCharacterDiedInIssue request);
        ICharacterDiedInIssueModel Any(GetCharacterDiedInIssueByKey request);
        ICharacterDiedInIssueModel Any(CreateCharacterDiedInIssue request);
        ICharacterDiedInIssueModel Any(UpdateCharacterDiedInIssue request);
        bool Any(DeactivateCharacterDiedInIssue request);
        bool Any(DeactivateCharacterDiedInIssueByKey request);
        bool Any(RemoveCharacterDiedInIssue request);
        bool Any(RemoveCharacterDiedInIssueByKey request);
    }

    public class CharacterDiedInIssuesServices : /*ServicesBase,*/ ICharacterDiedInIssuesServices
    {
        private readonly ICharacterDiedInIssuesBusinessWorkflow workflow;

        public CharacterDiedInIssuesServices(ICharacterDiedInIssuesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ICharacterDiedInIssueModel> Any(GetCharacterDiedInIssues request) { return workflow.Search(request); }
        public List<ICharacterDiedInIssueModel> Any(GetCharacterDiedInIssuesAsListing request) { return workflow.Search(request, true); }
        public ICharacterDiedInIssueModel Any(GetCharacterDiedInIssue request) { return workflow.Get(request.ID); }
        public ICharacterDiedInIssueModel Any(GetCharacterDiedInIssueByKey request) { return workflow.Get(request.CustomKey); }
        public ICharacterDiedInIssueModel Any(CreateCharacterDiedInIssue request) { return workflow.Create(request); }
        public ICharacterDiedInIssueModel Any(UpdateCharacterDiedInIssue request) { return workflow.Update(request); }
        public bool Any(DeactivateCharacterDiedInIssue request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateCharacterDiedInIssueByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveCharacterDiedInIssue request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveCharacterDiedInIssueByKey request) { return workflow.Remove(request.CustomKey); }
    }
}