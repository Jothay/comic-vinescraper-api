// <auto-generated>
// <copyright file="Episodes.IEpisodeConceptServices.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the EpisodeConcept ServiceStack DTOs and Handlers.</summary>
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

    public class EpisodeConceptModelBase : NameableEntityModelBase, IEpisodeConceptModel
    {
        // EpisodeConcept Properties
        // <None>
        // Related Objects
        public int EpisodeId { get; set; }
        public IEpisodeModel Episode { get; set; }
        public int ConceptId { get; set; }
        public IConceptModel Concept { get; set; }
        // Associated Objects
        // <None>
    }
    public class EpisodeConceptSearchModelBase : NameableEntitySearchModelBase, IEpisodeConceptSearchModel
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

        [ApiMember(Name = "ConceptId", IsRequired = false, Description = "Filter by the Related ConceptId")]
        public int? ConceptId { get; set; }

        [ApiMember(Name = "ConceptCustomKey", IsRequired = false, Description = "Filter by the Related Concept CustomKey (Equals, Case-Insensitive)")]
        public string ConceptCustomKey { get; set; }

        [ApiMember(Name = "ConceptApiDetailUrl", IsRequired = false, Description = "Filter by the Related Concept Api Detail Url (Contains, Case-Insensitive)")]
        public string ConceptApiDetailUrl { get; set; }

        [ApiMember(Name = "ConceptSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Concept Site Detail Url (Contains, Case-Insensitive)")]
        public string ConceptSiteDetailUrl { get; set; }

        [ApiMember(Name = "ConceptName", IsRequired = false, Description = "Filter by the Related Concept Name (Contains, Case-Insensitive)")]
        public string ConceptName { get; set; }

        [ApiMember(Name = "ConceptShortDescription", IsRequired = false, Description = "Filter by the Related Concept Short Description (Contains, Case-Insensitive)")]
        public string ConceptShortDescription { get; set; }

        [ApiMember(Name = "ConceptDescription", IsRequired = false, Description = "Filter by the Related Concept Description (Contains, Case-Insensitive)")]
        public string ConceptDescription { get; set; }

    }

    [Route("/EpisodeConcepts/", "GET", Summary = "Gets All Active EpisodeConcepts")]
    public class GetEpisodeConcepts : EpisodeConceptSearchModelBase, IReturn<List<IEpisodeConceptModel>> { }

    [Route("/EpisodeConcepts/Listing", "GET", Summary = "Gets All Active EpisodeConcepts with the mininum header information")]
    public class GetEpisodeConceptsAsListing : EpisodeConceptSearchModelBase, IReturn<List<IEpisodeConceptModel>> { }

    [Route("/EpisodeConcepts/{ID}", "GET", Summary = "Gets EpisodeConcept by Identifier")]
    public class GetEpisodeConcept : ImplementsID, IReturn<IEpisodeConceptModel> { }

    [Route("/EpisodeConcepts/{CustomKey}/ByKey", "GET", Summary = "Gets EpisodeConcept by Key")]
    public class GetEpisodeConceptByKey : ImplementsKey, IReturn<IEpisodeConceptModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeConcepts/Create", "POST", Summary = "Creates an EpisodeConcept with these contents")]
    public class CreateEpisodeConcept : EpisodeConceptModelBase, IReturn<IEpisodeConceptModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeConcepts/Update", "POST", Summary = "Updates an EpisodeConcept with new contents")]
    public class UpdateEpisodeConcept : EpisodeConceptModelBase, IReturn<IEpisodeConceptModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeConcepts/{ID}/Deactivate", "POST", Summary = "Deactivates an EpisodeConcept by Identifier")]
    public class DeactivateEpisodeConcept : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeConcepts/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an EpisodeConcept by Key")]
    public class DeactivateEpisodeConceptByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeConcepts/{ID}/Remove", "POST", Summary = "Removes an EpisodeConcept by Identifier")]
    public class RemoveEpisodeConcept : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/EpisodeConcepts/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an EpisodeConcept by Key")]
    public class RemoveEpisodeConceptByKey : ImplementsKey, IReturn<bool> { }

    public interface IEpisodeConceptsServices
    {
        List<IEpisodeConceptModel> Any(GetEpisodeConcepts request);
        List<IEpisodeConceptModel> Any(GetEpisodeConceptsAsListing request);
        IEpisodeConceptModel Any(GetEpisodeConcept request);
        IEpisodeConceptModel Any(GetEpisodeConceptByKey request);
        IEpisodeConceptModel Any(CreateEpisodeConcept request);
        IEpisodeConceptModel Any(UpdateEpisodeConcept request);
        bool Any(DeactivateEpisodeConcept request);
        bool Any(DeactivateEpisodeConceptByKey request);
        bool Any(RemoveEpisodeConcept request);
        bool Any(RemoveEpisodeConceptByKey request);
    }

    public class EpisodeConceptsServices : Service, IEpisodeConceptsServices
    {
        private readonly IEpisodeConceptsBusinessWorkflow workflow;

        public EpisodeConceptsServices(IEpisodeConceptsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IEpisodeConceptModel> Any(GetEpisodeConcepts request) { return workflow.Search(request); }
        public List<IEpisodeConceptModel> Any(GetEpisodeConceptsAsListing request) { return workflow.Search(request, true); }
        public IEpisodeConceptModel Any(GetEpisodeConcept request) { return workflow.Get(request.ID); }
        public IEpisodeConceptModel Any(GetEpisodeConceptByKey request) { return workflow.Get(request.CustomKey); }
        public IEpisodeConceptModel Any(CreateEpisodeConcept request) { return workflow.Create(request); }
        public IEpisodeConceptModel Any(UpdateEpisodeConcept request) { return workflow.Update(request); }
        public bool Any(DeactivateEpisodeConcept request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateEpisodeConceptByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveEpisodeConcept request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveEpisodeConceptByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
