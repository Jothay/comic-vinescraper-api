// <auto-generated>
// <copyright file="Concepts.IConceptVolumeModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ConceptVolume model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Concepts
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class ConceptVolumeModelBase : NameableEntityModelBase, IConceptVolumeModel
    {
        // ConceptVolume Properties
        // <None>
        // Related Objects
        public int ConceptId { get; set; }
        public IConceptModel Concept { get; set; }
        public int VolumeId { get; set; }
        public IVolumeModel Volume { get; set; }
        // Associated Objects
        // <None>
    }
    public class ConceptVolumeSearchModelBase : NameableEntitySearchModelBase, IConceptVolumeSearchModel
    {
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

    }

    [Route("/ConceptVolumes/", "GET", Summary = "Gets All Active ConceptVolumes")]
    public class GetConceptVolumes : ConceptVolumeSearchModelBase, IReturn<List<IConceptVolumeModel>> { }

    [Route("/ConceptVolumes/Listing", "GET", Summary = "Gets All Active ConceptVolumes with the mininum header information")]
    public class GetConceptVolumesAsListing : ConceptVolumeSearchModelBase, IReturn<List<IConceptVolumeModel>> { }

    [Route("/ConceptVolumes/{ID}", "GET", Summary = "Gets ConceptVolume by Identifier")]
    public class GetConceptVolume : ImplementsID, IReturn<IConceptVolumeModel> { }

    [Route("/ConceptVolumes/{CustomKey}/ByKey", "GET", Summary = "Gets ConceptVolume by Key")]
    public class GetConceptVolumeByKey : ImplementsKey, IReturn<IConceptVolumeModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ConceptVolumes/Create", "POST", Summary = "Creates an ConceptVolume with these contents")]
    public class CreateConceptVolume : ConceptVolumeModelBase, IReturn<IConceptVolumeModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ConceptVolumes/Update", "POST", Summary = "Updates an ConceptVolume with new contents")]
    public class UpdateConceptVolume : ConceptVolumeModelBase, IReturn<IConceptVolumeModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ConceptVolumes/{ID}/Deactivate", "POST", Summary = "Deactivates an ConceptVolume by Identifier")]
    public class DeactivateConceptVolume : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ConceptVolumes/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an ConceptVolume by Key")]
    public class DeactivateConceptVolumeByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ConceptVolumes/{ID}/Remove", "POST", Summary = "Removes an ConceptVolume by Identifier")]
    public class RemoveConceptVolume : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ConceptVolumes/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an ConceptVolume by Key")]
    public class RemoveConceptVolumeByKey : ImplementsKey, IReturn<bool> { }

    public interface IConceptVolumesServices
    {
        List<IConceptVolumeModel> Any(GetConceptVolumes request);
        List<IConceptVolumeModel> Any(GetConceptVolumesAsListing request);
        IConceptVolumeModel Any(GetConceptVolume request);
        IConceptVolumeModel Any(GetConceptVolumeByKey request);
        IConceptVolumeModel Any(CreateConceptVolume request);
        IConceptVolumeModel Any(UpdateConceptVolume request);
        bool Any(DeactivateConceptVolume request);
        bool Any(DeactivateConceptVolumeByKey request);
        bool Any(RemoveConceptVolume request);
        bool Any(RemoveConceptVolumeByKey request);
    }

    public class ConceptVolumesServices : Service, IConceptVolumesServices
    {
        private readonly IConceptVolumesBusinessWorkflow workflow;

        public ConceptVolumesServices(IConceptVolumesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IConceptVolumeModel> Any(GetConceptVolumes request) { return workflow.Search(request); }
        public List<IConceptVolumeModel> Any(GetConceptVolumesAsListing request) { return workflow.Search(request, true); }
        public IConceptVolumeModel Any(GetConceptVolume request) { return workflow.Get(request.ID); }
        public IConceptVolumeModel Any(GetConceptVolumeByKey request) { return workflow.Get(request.CustomKey); }
        public IConceptVolumeModel Any(CreateConceptVolume request) { return workflow.Create(request); }
        public IConceptVolumeModel Any(UpdateConceptVolume request) { return workflow.Update(request); }
        public bool Any(DeactivateConceptVolume request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateConceptVolumeByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveConceptVolume request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveConceptVolumeByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
