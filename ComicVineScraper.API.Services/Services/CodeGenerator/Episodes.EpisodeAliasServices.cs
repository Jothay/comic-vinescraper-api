// <auto-generated>
// <copyright file="Episodes.IEpisodeAliasServices.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the EpisodeAlias ServiceStack DTOs and Handlers.</summary>
// <remarks>This file was auto-generated using ServiceFileMaster.tt in
// ComicVineScraper.API.Services\Framework\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Services//.Episodes
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class EpisodeAliasModelBase : NameableEntityModelBase, IEpisodeAliasModel
    {
        // EpisodeAlias Properties
        // <None>
        // Related Objects
        public int EpisodeId { get; set; }
        public IEpisodeModel Episode { get; set; }
        // Associated Objects
        // <None>
    }
    public class EpisodeAliasSearchModelBase : NameableEntitySearchModelBase, IEpisodeAliasSearchModel
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

    }

    [Route("/EpisodeAliases/", "GET", Summary = "Gets All Active EpisodeAliases")]
    public class GetEpisodeAliases : EpisodeAliasSearchModelBase, IReturn<List<IEpisodeAliasModel>> { }

    [Route("/EpisodeAliases/Listing", "GET", Summary = "Gets All Active EpisodeAliases with the mininum header information")]
    public class GetEpisodeAliasesAsListing : EpisodeAliasSearchModelBase, IReturn<List<IEpisodeAliasModel>> { }

    [Route("/EpisodeAliases/{ID}", "GET", Summary = "Gets EpisodeAlias by Identifier")]
    public class GetEpisodeAlias : ImplementsID, IReturn<IEpisodeAliasModel> { }

    [Route("/EpisodeAliases/{CustomKey}/ByKey", "GET", Summary = "Gets EpisodeAlias by Key")]
    public class GetEpisodeAliasByKey : ImplementsKey, IReturn<IEpisodeAliasModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeAliases/Create", "POST", Summary = "Creates an EpisodeAlias with these contents")]
    public class CreateEpisodeAlias : EpisodeAliasModelBase, IReturn<IEpisodeAliasModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeAliases/Update", "POST", Summary = "Updates an EpisodeAlias with new contents")]
    public class UpdateEpisodeAlias : EpisodeAliasModelBase, IReturn<IEpisodeAliasModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeAliases/{ID}/Deactivate", "POST", Summary = "Deactivates an EpisodeAlias by Identifier")]
    public class DeactivateEpisodeAlias : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeAliases/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an EpisodeAlias by Key")]
    public class DeactivateEpisodeAliasByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeAliases/{ID}/Remove", "POST", Summary = "Removes an EpisodeAlias by Identifier")]
    public class RemoveEpisodeAlias : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeAliases/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an EpisodeAlias by Key")]
    public class RemoveEpisodeAliasByKey : ImplementsKey, IReturn<bool> { }

    public interface IEpisodeAliasesServices
    {
        List<IEpisodeAliasModel> Any(GetEpisodeAliases request);
        List<IEpisodeAliasModel> Any(GetEpisodeAliasesAsListing request);
        IEpisodeAliasModel Any(GetEpisodeAlias request);
        IEpisodeAliasModel Any(GetEpisodeAliasByKey request);
        IEpisodeAliasModel Any(CreateEpisodeAlias request);
        IEpisodeAliasModel Any(UpdateEpisodeAlias request);
        bool Any(DeactivateEpisodeAlias request);
        bool Any(DeactivateEpisodeAliasByKey request);
        bool Any(RemoveEpisodeAlias request);
        bool Any(RemoveEpisodeAliasByKey request);
    }

    public class EpisodeAliasesServices : Service, IEpisodeAliasesServices
    {
        private readonly IEpisodeAliasesBusinessWorkflow workflow;

        public EpisodeAliasesServices(IEpisodeAliasesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IEpisodeAliasModel> Any(GetEpisodeAliases request) { return workflow.Search(request); }
        public List<IEpisodeAliasModel> Any(GetEpisodeAliasesAsListing request) { return workflow.Search(request, true); }
        public IEpisodeAliasModel Any(GetEpisodeAlias request) { return workflow.Get(request.ID); }
        public IEpisodeAliasModel Any(GetEpisodeAliasByKey request) { return workflow.Get(request.CustomKey); }
        public IEpisodeAliasModel Any(CreateEpisodeAlias request) { return workflow.Create(request); }
        public IEpisodeAliasModel Any(UpdateEpisodeAlias request) { return workflow.Update(request); }
        public bool Any(DeactivateEpisodeAlias request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateEpisodeAliasByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveEpisodeAlias request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveEpisodeAliasByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
