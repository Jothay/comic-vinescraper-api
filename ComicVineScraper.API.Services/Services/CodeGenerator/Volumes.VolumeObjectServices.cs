// <auto-generated>
// <copyright file="Volumes.IVolumeObjectServices.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the VolumeObject ServiceStack DTOs and Handlers.</summary>
// <remarks>This file was auto-generated using ServiceFileMaster.tt in
// ComicVineScraper.API.Services\Framework\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Services//.Volumes
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class VolumeObjectModelBase : NameableEntityModelBase, IVolumeObjectModel
    {
        // VolumeObject Properties
        // <None>
        // Related Objects
        public int VolumeId { get; set; }
        public IVolumeModel Volume { get; set; }
        public int ObjectId { get; set; }
        public IObjectModel Object { get; set; }
        // Associated Objects
        // <None>
    }
    public class VolumeObjectSearchModelBase : NameableEntitySearchModelBase, IVolumeObjectSearchModel
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

        [ApiMember(Name = "ObjectId", IsRequired = false, Description = "Filter by the Related ObjectId")]
        public int? ObjectId { get; set; }

        [ApiMember(Name = "ObjectCustomKey", IsRequired = false, Description = "Filter by the Related Object CustomKey (Equals, Case-Insensitive)")]
        public string ObjectCustomKey { get; set; }

        [ApiMember(Name = "ObjectApiDetailUrl", IsRequired = false, Description = "Filter by the Related Object Api Detail Url (Contains, Case-Insensitive)")]
        public string ObjectApiDetailUrl { get; set; }

        [ApiMember(Name = "ObjectSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Object Site Detail Url (Contains, Case-Insensitive)")]
        public string ObjectSiteDetailUrl { get; set; }

        [ApiMember(Name = "ObjectName", IsRequired = false, Description = "Filter by the Related Object Name (Contains, Case-Insensitive)")]
        public string ObjectName { get; set; }

        [ApiMember(Name = "ObjectShortDescription", IsRequired = false, Description = "Filter by the Related Object Short Description (Contains, Case-Insensitive)")]
        public string ObjectShortDescription { get; set; }

        [ApiMember(Name = "ObjectDescription", IsRequired = false, Description = "Filter by the Related Object Description (Contains, Case-Insensitive)")]
        public string ObjectDescription { get; set; }

    }

    [Route("/VolumeObjects/", "GET", Summary = "Gets All Active VolumeObjects")]
    public class GetVolumeObjects : VolumeObjectSearchModelBase, IReturn<List<IVolumeObjectModel>> { }

    [Route("/VolumeObjects/Listing", "GET", Summary = "Gets All Active VolumeObjects with the mininum header information")]
    public class GetVolumeObjectsAsListing : VolumeObjectSearchModelBase, IReturn<List<IVolumeObjectModel>> { }

    [Route("/VolumeObjects/{ID}", "GET", Summary = "Gets VolumeObject by Identifier")]
    public class GetVolumeObject : ImplementsID, IReturn<IVolumeObjectModel> { }

    [Route("/VolumeObjects/{CustomKey}/ByKey", "GET", Summary = "Gets VolumeObject by Key")]
    public class GetVolumeObjectByKey : ImplementsKey, IReturn<IVolumeObjectModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/VolumeObjects/Create", "POST", Summary = "Creates an VolumeObject with these contents")]
    public class CreateVolumeObject : VolumeObjectModelBase, IReturn<IVolumeObjectModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/VolumeObjects/Update", "POST", Summary = "Updates an VolumeObject with new contents")]
    public class UpdateVolumeObject : VolumeObjectModelBase, IReturn<IVolumeObjectModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/VolumeObjects/{ID}/Deactivate", "POST", Summary = "Deactivates an VolumeObject by Identifier")]
    public class DeactivateVolumeObject : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/VolumeObjects/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an VolumeObject by Key")]
    public class DeactivateVolumeObjectByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/VolumeObjects/{ID}/Remove", "POST", Summary = "Removes an VolumeObject by Identifier")]
    public class RemoveVolumeObject : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/VolumeObjects/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an VolumeObject by Key")]
    public class RemoveVolumeObjectByKey : ImplementsKey, IReturn<bool> { }

    public interface IVolumeObjectsServices
    {
        List<IVolumeObjectModel> Any(GetVolumeObjects request);
        List<IVolumeObjectModel> Any(GetVolumeObjectsAsListing request);
        IVolumeObjectModel Any(GetVolumeObject request);
        IVolumeObjectModel Any(GetVolumeObjectByKey request);
        IVolumeObjectModel Any(CreateVolumeObject request);
        IVolumeObjectModel Any(UpdateVolumeObject request);
        bool Any(DeactivateVolumeObject request);
        bool Any(DeactivateVolumeObjectByKey request);
        bool Any(RemoveVolumeObject request);
        bool Any(RemoveVolumeObjectByKey request);
    }

    public class VolumeObjectsServices : Service, IVolumeObjectsServices
    {
        private readonly IVolumeObjectsBusinessWorkflow workflow;

        public VolumeObjectsServices(IVolumeObjectsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IVolumeObjectModel> Any(GetVolumeObjects request) { return workflow.Search(request); }
        public List<IVolumeObjectModel> Any(GetVolumeObjectsAsListing request) { return workflow.Search(request, true); }
        public IVolumeObjectModel Any(GetVolumeObject request) { return workflow.Get(request.ID); }
        public IVolumeObjectModel Any(GetVolumeObjectByKey request) { return workflow.Get(request.CustomKey); }
        public IVolumeObjectModel Any(CreateVolumeObject request) { return workflow.Create(request); }
        public IVolumeObjectModel Any(UpdateVolumeObject request) { return workflow.Update(request); }
        public bool Any(DeactivateVolumeObject request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateVolumeObjectByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveVolumeObject request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveVolumeObjectByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
