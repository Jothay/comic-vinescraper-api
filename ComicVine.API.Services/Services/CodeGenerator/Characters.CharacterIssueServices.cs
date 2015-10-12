// <auto-generated>
// <copyright file="Characters.ICharacterIssueModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterIssue model interfaces.</summary>
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

    public class CharacterIssueModelBase : NameableEntityModelBase, ICharacterIssueModel
    {
        // CharacterIssue Properties
        // <None>
        // Related Objects
        public int CharacterId { get; set; }
        public ICharacterModel Character { get; set; }
        public int IssueId { get; set; }
        public IIssueModel Issue { get; set; }
        // Associated Objects
        // <None>
    }
    public class CharacterIssueSearchModelBase : NameableEntitySearchModelBase, ICharacterIssueSearchModel
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

        [ApiMember(Name = "IssueId", IsRequired = false, Description = "Filter by the Related IssueId")]
        public int? IssueId { get; set; }

        [ApiMember(Name = "IssueCustomKey", IsRequired = false, Description = "Filter by the Related Issue CustomKey (Equals, Case-Insensitive)")]
        public string IssueCustomKey { get; set; }

        [ApiMember(Name = "IssueApiDetailUrl", IsRequired = false, Description = "Filter by the Related Issue Api Detail Url (Contains, Case-Insensitive)")]
        public string IssueApiDetailUrl { get; set; }

        [ApiMember(Name = "IssueSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Issue Site Detail Url (Contains, Case-Insensitive)")]
        public string IssueSiteDetailUrl { get; set; }

        [ApiMember(Name = "IssueName", IsRequired = false, Description = "Filter by the Related Issue Name (Contains, Case-Insensitive)")]
        public string IssueName { get; set; }

        [ApiMember(Name = "IssueShortDescription", IsRequired = false, Description = "Filter by the Related Issue Short Description (Contains, Case-Insensitive)")]
        public string IssueShortDescription { get; set; }

        [ApiMember(Name = "IssueDescription", IsRequired = false, Description = "Filter by the Related Issue Description (Contains, Case-Insensitive)")]
        public string IssueDescription { get; set; }

    }

    [Route("/CharacterIssues/", "GET", Summary = "Gets All Active CharacterIssues")]
    public class GetCharacterIssues : CharacterIssueSearchModelBase, IReturn<List<ICharacterIssueModel>> { }

    [Route("/CharacterIssues/Listing", "GET", Summary = "Gets All Active CharacterIssues with the mininum header information")]
    public class GetCharacterIssuesAsListing : CharacterIssueSearchModelBase, IReturn<List<ICharacterIssueModel>> { }

    [Route("/CharacterIssues/{ID}", "GET", Summary = "Gets CharacterIssue by Identifier")]
    public class GetCharacterIssue : ImplementsID, IReturn<ICharacterIssueModel> { }

    [Route("/CharacterIssues/{CustomKey}/ByKey", "GET", Summary = "Gets CharacterIssue by Key")]
    public class GetCharacterIssueByKey : ImplementsKey, IReturn<ICharacterIssueModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterIssues/Create", "POST", Summary = "Creates an CharacterIssue with these contents")]
    public class CreateCharacterIssue : CharacterIssueModelBase, IReturn<ICharacterIssueModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterIssues/Update", "POST", Summary = "Updates an CharacterIssue with new contents")]
    public class UpdateCharacterIssue : CharacterIssueModelBase, IReturn<ICharacterIssueModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterIssues/{ID}/Deactivate", "POST", Summary = "Deactivates an CharacterIssue by Identifier")]
    public class DeactivateCharacterIssue : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterIssues/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an CharacterIssue by Key")]
    public class DeactivateCharacterIssueByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterIssues/{ID}/Remove", "POST", Summary = "Removes an CharacterIssue by Identifier")]
    public class RemoveCharacterIssue : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterIssues/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an CharacterIssue by Key")]
    public class RemoveCharacterIssueByKey : ImplementsKey, IReturn<bool> { }

    public interface ICharacterIssuesServices
    {
        List<ICharacterIssueModel> Any(GetCharacterIssues request);
        List<ICharacterIssueModel> Any(GetCharacterIssuesAsListing request);
        ICharacterIssueModel Any(GetCharacterIssue request);
        ICharacterIssueModel Any(GetCharacterIssueByKey request);
        ICharacterIssueModel Any(CreateCharacterIssue request);
        ICharacterIssueModel Any(UpdateCharacterIssue request);
        bool Any(DeactivateCharacterIssue request);
        bool Any(DeactivateCharacterIssueByKey request);
        bool Any(RemoveCharacterIssue request);
        bool Any(RemoveCharacterIssueByKey request);
    }

    public class CharacterIssuesServices : Service, ICharacterIssuesServices
    {
        private readonly ICharacterIssuesBusinessWorkflow workflow;

        public CharacterIssuesServices(ICharacterIssuesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ICharacterIssueModel> Any(GetCharacterIssues request) { return workflow.Search(request); }
        public List<ICharacterIssueModel> Any(GetCharacterIssuesAsListing request) { return workflow.Search(request, true); }
        public ICharacterIssueModel Any(GetCharacterIssue request) { return workflow.Get(request.ID); }
        public ICharacterIssueModel Any(GetCharacterIssueByKey request) { return workflow.Get(request.CustomKey); }
        public ICharacterIssueModel Any(CreateCharacterIssue request) { return workflow.Create(request); }
        public ICharacterIssueModel Any(UpdateCharacterIssue request) { return workflow.Update(request); }
        public bool Any(DeactivateCharacterIssue request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateCharacterIssueByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveCharacterIssue request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveCharacterIssueByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
