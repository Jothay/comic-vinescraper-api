// <auto-generated>
// <copyright file="Volumes.IVolumeLocationModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VolumeLocation model interfaces.</summary>
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

    public class VolumeLocationModelBase : NameableEntityModelBase, IVolumeLocationModel
    {
        // VolumeLocation Properties
        // <None>
        // Related Objects
        public int VolumeId { get; set; }
        public IVolumeModel Volume { get; set; }
        public int LocationId { get; set; }
        public ILocationModel Location { get; set; }
        // Associated Objects
        // <None>
    }
    public class VolumeLocationSearchModelBase : NameableEntitySearchModelBase, IVolumeLocationSearchModel
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

        [ApiMember(Name = "LocationId", IsRequired = false, Description = "Filter by the Related LocationId")]
        public int? LocationId { get; set; }

        [ApiMember(Name = "LocationCustomKey", IsRequired = false, Description = "Filter by the Related Location CustomKey (Equals, Case-Insensitive)")]
        public string LocationCustomKey { get; set; }

        [ApiMember(Name = "LocationApiDetailUrl", IsRequired = false, Description = "Filter by the Related Location Api Detail Url (Contains, Case-Insensitive)")]
        public string LocationApiDetailUrl { get; set; }

        [ApiMember(Name = "LocationSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Location Site Detail Url (Contains, Case-Insensitive)")]
        public string LocationSiteDetailUrl { get; set; }

        [ApiMember(Name = "LocationName", IsRequired = false, Description = "Filter by the Related Location Name (Contains, Case-Insensitive)")]
        public string LocationName { get; set; }

        [ApiMember(Name = "LocationShortDescription", IsRequired = false, Description = "Filter by the Related Location Short Description (Contains, Case-Insensitive)")]
        public string LocationShortDescription { get; set; }

        [ApiMember(Name = "LocationDescription", IsRequired = false, Description = "Filter by the Related Location Description (Contains, Case-Insensitive)")]
        public string LocationDescription { get; set; }

    }

    [Route("/VolumeLocations/", "GET", Summary = "Gets All Active VolumeLocations")]
    public class GetVolumeLocations : VolumeLocationSearchModelBase, IReturn<List<IVolumeLocationModel>> { }

    [Route("/VolumeLocations/Listing", "GET", Summary = "Gets All Active VolumeLocations with the mininum header information")]
    public class GetVolumeLocationsAsListing : VolumeLocationSearchModelBase, IReturn<List<IVolumeLocationModel>> { }

    [Route("/VolumeLocations/{ID}", "GET", Summary = "Gets VolumeLocation by Identifier")]
    public class GetVolumeLocation : ImplementsID, IReturn<IVolumeLocationModel> { }

    [Route("/VolumeLocations/{CustomKey}/ByKey", "GET", Summary = "Gets VolumeLocation by Key")]
    public class GetVolumeLocationByKey : ImplementsKey, IReturn<IVolumeLocationModel> { }

    //[Authenticate]
    [Route("/VolumeLocations/Create", "POST", Summary = "Creates an VolumeLocation with these contents")]
    public class CreateVolumeLocation : VolumeLocationModelBase, IReturn<IVolumeLocationModel> { }

    //[Authenticate]
    [Route("/VolumeLocations/Update", "POST", Summary = "Updates an VolumeLocation with new contents")]
    public class UpdateVolumeLocation : VolumeLocationModelBase, IReturn<IVolumeLocationModel> { }

    //[Authenticate]
    [Route("/VolumeLocations/{ID}/Deactivate", "POST", Summary = "Deactivates an VolumeLocation by Identifier")]
    public class DeactivateVolumeLocation : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/VolumeLocations/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an VolumeLocation by Key")]
    public class DeactivateVolumeLocationByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/VolumeLocations/{ID}/Remove", "POST", Summary = "Removes an VolumeLocation by Identifier")]
    public class RemoveVolumeLocation : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/VolumeLocations/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an VolumeLocation by Key")]
    public class RemoveVolumeLocationByKey : ImplementsKey, IReturn<bool> { }

    public interface IVolumeLocationsServices
    {
        List<IVolumeLocationModel> Any(GetVolumeLocations request);
        List<IVolumeLocationModel> Any(GetVolumeLocationsAsListing request);
        IVolumeLocationModel Any(GetVolumeLocation request);
        IVolumeLocationModel Any(GetVolumeLocationByKey request);
        IVolumeLocationModel Any(CreateVolumeLocation request);
        IVolumeLocationModel Any(UpdateVolumeLocation request);
        bool Any(DeactivateVolumeLocation request);
        bool Any(DeactivateVolumeLocationByKey request);
        bool Any(RemoveVolumeLocation request);
        bool Any(RemoveVolumeLocationByKey request);
    }

    public class VolumeLocationsServices : Service, IVolumeLocationsServices
    {
        private readonly IVolumeLocationsBusinessWorkflow workflow;

        public VolumeLocationsServices(IVolumeLocationsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IVolumeLocationModel> Any(GetVolumeLocations request) { return workflow.Search(request); }
        public List<IVolumeLocationModel> Any(GetVolumeLocationsAsListing request) { return workflow.Search(request, true); }
        public IVolumeLocationModel Any(GetVolumeLocation request) { return workflow.Get(request.ID); }
        public IVolumeLocationModel Any(GetVolumeLocationByKey request) { return workflow.Get(request.CustomKey); }
        public IVolumeLocationModel Any(CreateVolumeLocation request) { return workflow.Create(request); }
        public IVolumeLocationModel Any(UpdateVolumeLocation request) { return workflow.Update(request); }
        public bool Any(DeactivateVolumeLocation request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateVolumeLocationByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveVolumeLocation request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveVolumeLocationByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
