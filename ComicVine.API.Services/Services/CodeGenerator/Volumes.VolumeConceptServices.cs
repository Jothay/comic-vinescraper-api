// <auto-generated>
// <copyright file="Volumes.IVolumeConceptModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VolumeConcept model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Volumes
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;

    public class VolumeConceptModelBase : NameableEntityModelBase, IVolumeConceptModel
    {
        // VolumeConcept Properties
        // <None>
        // Related Objects
        public int VolumeId { get; set; }
        public IVolumeModel Volume { get; set; }
        public int ConceptId { get; set; }
        public IConceptModel Concept { get; set; }
        // Associated Objects
        // <None>
    }
    public class VolumeConceptSearchModelBase : NameableEntitySearchModelBase, IVolumeConceptSearchModel
    {
        [ApiMember(Name = "VolumeId", IsRequired = false, Description = "Filter by the Related VolumeId")]
        public int? VolumeId { get; set; }

        [ApiMember(Name = "VolumeCustomKey", IsRequired = false, Description = "Filter by the Related Volume CustomKey (Equals, Case-Insensitive)")]
        public string VolumeCustomKey { get; set; }

        [ApiMember(Name = "VolumeApiDetailUrl", IsRequired = false, Description = "Filter by the Related Volume Api Detail Url (Contains, Case-Insensitive)")]
        public string VolumeApiDetailUrl { get; set; }

        [ApiMember(Name = "VolumeSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Volume Site Detail Url (Contains, Case-Insensitive)")]
        public string VolumeSiteDetailUrl { get; set; }

        [ApiMember(Name = "VolumeName", IsRequired = false, Description = "Filter by the Related Volume Name (Contains, Case-Insensitive)")]
        public string VolumeName { get; set; }

        [ApiMember(Name = "VolumeShortDescription", IsRequired = false, Description = "Filter by the Related Volume Short Description (Contains, Case-Insensitive)")]
        public string VolumeShortDescription { get; set; }

        [ApiMember(Name = "VolumeDescription", IsRequired = false, Description = "Filter by the Related Volume Description (Contains, Case-Insensitive)")]
        public string VolumeDescription { get; set; }

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

    [Route("/VolumeConcepts/", "GET", Summary = "Gets All Active VolumeConcepts")]
    public class GetVolumeConcepts : VolumeConceptSearchModelBase, IReturn<List<IVolumeConceptModel>> { }

    [Route("/VolumeConcepts/Listing", "GET", Summary = "Gets All Active VolumeConcepts with the mininum header information")]
    public class GetVolumeConceptsAsListing : VolumeConceptSearchModelBase, IReturn<List<IVolumeConceptModel>> { }

    [Route("/VolumeConcepts/{ID}", "GET", Summary = "Gets VolumeConcept by Identifier")]
    public class GetVolumeConcept : ImplementsID, IReturn<IVolumeConceptModel> { }

    [Route("/VolumeConcepts/{CustomKey}/ByKey", "GET", Summary = "Gets VolumeConcept by Key")]
    public class GetVolumeConceptByKey : ImplementsKey, IReturn<IVolumeConceptModel> { }

    //[Authenticate]
    [Route("/VolumeConcepts/Create", "POST", Summary = "Creates an VolumeConcept with these contents")]
    public class CreateVolumeConcept : VolumeConceptModelBase, IReturn<IVolumeConceptModel> { }

    //[Authenticate]
    [Route("/VolumeConcepts/Update", "POST", Summary = "Updates an VolumeConcept with new contents")]
    public class UpdateVolumeConcept : VolumeConceptModelBase, IReturn<IVolumeConceptModel> { }

    //[Authenticate]
    [Route("/VolumeConcepts/{ID}/Deactivate", "POST", Summary = "Deactivates an VolumeConcept by Identifier")]
    public class DeactivateVolumeConcept : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/VolumeConcepts/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an VolumeConcept by Key")]
    public class DeactivateVolumeConceptByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/VolumeConcepts/{ID}/Remove", "POST", Summary = "Removes an VolumeConcept by Identifier")]
    public class RemoveVolumeConcept : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/VolumeConcepts/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an VolumeConcept by Key")]
    public class RemoveVolumeConceptByKey : ImplementsKey, IReturn<bool> { }

    public interface IVolumeConceptsServices
    {
        List<IVolumeConceptModel> Any(GetVolumeConcepts request);
        List<IVolumeConceptModel> Any(GetVolumeConceptsAsListing request);
        IVolumeConceptModel Any(GetVolumeConcept request);
        IVolumeConceptModel Any(GetVolumeConceptByKey request);
        IVolumeConceptModel Any(CreateVolumeConcept request);
        IVolumeConceptModel Any(UpdateVolumeConcept request);
        bool Any(DeactivateVolumeConcept request);
        bool Any(DeactivateVolumeConceptByKey request);
        bool Any(RemoveVolumeConcept request);
        bool Any(RemoveVolumeConceptByKey request);
    }

    public class VolumeConceptsServices : Service, IVolumeConceptsServices
    {
        private readonly IVolumeConceptsBusinessWorkflow workflow;

        public VolumeConceptsServices(IVolumeConceptsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IVolumeConceptModel> Any(GetVolumeConcepts request) { return workflow.Search(request); }
        public List<IVolumeConceptModel> Any(GetVolumeConceptsAsListing request) { return workflow.Search(request, true); }
        public IVolumeConceptModel Any(GetVolumeConcept request) { return workflow.Get(request.ID); }
        public IVolumeConceptModel Any(GetVolumeConceptByKey request) { return workflow.Get(request.CustomKey); }
        public IVolumeConceptModel Any(CreateVolumeConcept request) { return workflow.Create(request); }
        public IVolumeConceptModel Any(UpdateVolumeConcept request) { return workflow.Update(request); }
        public bool Any(DeactivateVolumeConcept request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateVolumeConceptByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveVolumeConcept request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveVolumeConceptByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
