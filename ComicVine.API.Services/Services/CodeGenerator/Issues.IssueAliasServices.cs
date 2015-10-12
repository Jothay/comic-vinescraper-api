// <auto-generated>
// <copyright file="Issues.IIssueAliasModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the IssueAlias model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Issues
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class IssueAliasModelBase : NameableEntityModelBase, IIssueAliasModel
    {
        // IssueAlias Properties
        // <None>
        // Related Objects
        public int IssueId { get; set; }
        public IIssueModel Issue { get; set; }
        // Associated Objects
        // <None>
    }
    public class IssueAliasSearchModelBase : NameableEntitySearchModelBase, IIssueAliasSearchModel
    {
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

    [Route("/IssueAliases/", "GET", Summary = "Gets All Active IssueAliases")]
    public class GetIssueAliases : IssueAliasSearchModelBase, IReturn<List<IIssueAliasModel>> { }

    [Route("/IssueAliases/Listing", "GET", Summary = "Gets All Active IssueAliases with the mininum header information")]
    public class GetIssueAliasesAsListing : IssueAliasSearchModelBase, IReturn<List<IIssueAliasModel>> { }

    [Route("/IssueAliases/{ID}", "GET", Summary = "Gets IssueAlias by Identifier")]
    public class GetIssueAlias : ImplementsID, IReturn<IIssueAliasModel> { }

    [Route("/IssueAliases/{CustomKey}/ByKey", "GET", Summary = "Gets IssueAlias by Key")]
    public class GetIssueAliasByKey : ImplementsKey, IReturn<IIssueAliasModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/IssueAliases/Create", "POST", Summary = "Creates an IssueAlias with these contents")]
    public class CreateIssueAlias : IssueAliasModelBase, IReturn<IIssueAliasModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/IssueAliases/Update", "POST", Summary = "Updates an IssueAlias with new contents")]
    public class UpdateIssueAlias : IssueAliasModelBase, IReturn<IIssueAliasModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/IssueAliases/{ID}/Deactivate", "POST", Summary = "Deactivates an IssueAlias by Identifier")]
    public class DeactivateIssueAlias : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/IssueAliases/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an IssueAlias by Key")]
    public class DeactivateIssueAliasByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/IssueAliases/{ID}/Remove", "POST", Summary = "Removes an IssueAlias by Identifier")]
    public class RemoveIssueAlias : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/IssueAliases/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an IssueAlias by Key")]
    public class RemoveIssueAliasByKey : ImplementsKey, IReturn<bool> { }

    public interface IIssueAliasesServices
    {
        List<IIssueAliasModel> Any(GetIssueAliases request);
        List<IIssueAliasModel> Any(GetIssueAliasesAsListing request);
        IIssueAliasModel Any(GetIssueAlias request);
        IIssueAliasModel Any(GetIssueAliasByKey request);
        IIssueAliasModel Any(CreateIssueAlias request);
        IIssueAliasModel Any(UpdateIssueAlias request);
        bool Any(DeactivateIssueAlias request);
        bool Any(DeactivateIssueAliasByKey request);
        bool Any(RemoveIssueAlias request);
        bool Any(RemoveIssueAliasByKey request);
    }

    public class IssueAliasesServices : Service, IIssueAliasesServices
    {
        private readonly IIssueAliasesBusinessWorkflow workflow;

        public IssueAliasesServices(IIssueAliasesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IIssueAliasModel> Any(GetIssueAliases request) { return workflow.Search(request); }
        public List<IIssueAliasModel> Any(GetIssueAliasesAsListing request) { return workflow.Search(request, true); }
        public IIssueAliasModel Any(GetIssueAlias request) { return workflow.Get(request.ID); }
        public IIssueAliasModel Any(GetIssueAliasByKey request) { return workflow.Get(request.CustomKey); }
        public IIssueAliasModel Any(CreateIssueAlias request) { return workflow.Create(request); }
        public IIssueAliasModel Any(UpdateIssueAlias request) { return workflow.Update(request); }
        public bool Any(DeactivateIssueAlias request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateIssueAliasByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveIssueAlias request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveIssueAliasByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
