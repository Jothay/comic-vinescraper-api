// <auto-generated>
// <copyright file="Series.ISeriesLocationModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the SeriesLocation model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Series
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;

    public class SeriesLocationModelBase : NameableEntityModelBase, ISeriesLocationModel
    {
        // SeriesLocation Properties
        // <None>
        // Related Objects
        public int SeriesId { get; set; }
        public ISeriesModel Series { get; set; }
        public int LocationId { get; set; }
        public ILocationModel Location { get; set; }
        // Associated Objects
        // <None>
    }
    public class SeriesLocationSearchModelBase : NameableEntitySearchModelBase, ISeriesLocationSearchModel
    {
        [ApiMember(Name = "SeriesId", IsRequired = false, Description = "Filter by the Related SeriesId")]
        public int? SeriesId { get; set; }

        [ApiMember(Name = "SeriesCustomKey", IsRequired = false, Description = "Filter by the Related Series CustomKey (Equals, Case-Insensitive)")]
        public string SeriesCustomKey { get; set; }

        [ApiMember(Name = "SeriesApiDetailUrl", IsRequired = false, Description = "Filter by the Related Series Api Detail Url (Contains, Case-Insensitive)")]
        public string SeriesApiDetailUrl { get; set; }

        [ApiMember(Name = "SeriesSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Series Site Detail Url (Contains, Case-Insensitive)")]
        public string SeriesSiteDetailUrl { get; set; }

        [ApiMember(Name = "SeriesName", IsRequired = false, Description = "Filter by the Related Series Name (Contains, Case-Insensitive)")]
        public string SeriesName { get; set; }

        [ApiMember(Name = "SeriesShortDescription", IsRequired = false, Description = "Filter by the Related Series Short Description (Contains, Case-Insensitive)")]
        public string SeriesShortDescription { get; set; }

        [ApiMember(Name = "SeriesDescription", IsRequired = false, Description = "Filter by the Related Series Description (Contains, Case-Insensitive)")]
        public string SeriesDescription { get; set; }

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

    [Route("/SeriesLocations/", "GET", Summary = "Gets All Active SeriesLocations")]
    public class GetSeriesLocations : SeriesLocationSearchModelBase, IReturn<List<ISeriesLocationModel>> { }

    [Route("/SeriesLocations/Listing", "GET", Summary = "Gets All Active SeriesLocations with the mininum header information")]
    public class GetSeriesLocationsAsListing : SeriesLocationSearchModelBase, IReturn<List<ISeriesLocationModel>> { }

    [Route("/SeriesLocations/{ID}", "GET", Summary = "Gets SeriesLocation by Identifier")]
    public class GetSeriesLocation : ImplementsID, IReturn<ISeriesLocationModel> { }

    [Route("/SeriesLocations/{CustomKey}/ByKey", "GET", Summary = "Gets SeriesLocation by Key")]
    public class GetSeriesLocationByKey : ImplementsKey, IReturn<ISeriesLocationModel> { }

    //[Authenticate]
    [Route("/SeriesLocations/Create", "POST", Summary = "Creates an SeriesLocation with these contents")]
    public class CreateSeriesLocation : SeriesLocationModelBase, IReturn<ISeriesLocationModel> { }

    //[Authenticate]
    [Route("/SeriesLocations/Update", "POST", Summary = "Updates an SeriesLocation with new contents")]
    public class UpdateSeriesLocation : SeriesLocationModelBase, IReturn<ISeriesLocationModel> { }

    //[Authenticate]
    [Route("/SeriesLocations/{ID}/Deactivate", "POST", Summary = "Deactivates an SeriesLocation by Identifier")]
    public class DeactivateSeriesLocation : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/SeriesLocations/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an SeriesLocation by Key")]
    public class DeactivateSeriesLocationByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/SeriesLocations/{ID}/Remove", "POST", Summary = "Removes an SeriesLocation by Identifier")]
    public class RemoveSeriesLocation : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/SeriesLocations/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an SeriesLocation by Key")]
    public class RemoveSeriesLocationByKey : ImplementsKey, IReturn<bool> { }

    public interface ISeriesLocationsServices
    {
        List<ISeriesLocationModel> Any(GetSeriesLocations request);
        List<ISeriesLocationModel> Any(GetSeriesLocationsAsListing request);
        ISeriesLocationModel Any(GetSeriesLocation request);
        ISeriesLocationModel Any(GetSeriesLocationByKey request);
        ISeriesLocationModel Any(CreateSeriesLocation request);
        ISeriesLocationModel Any(UpdateSeriesLocation request);
        bool Any(DeactivateSeriesLocation request);
        bool Any(DeactivateSeriesLocationByKey request);
        bool Any(RemoveSeriesLocation request);
        bool Any(RemoveSeriesLocationByKey request);
    }

    public class SeriesLocationsServices : Service, ISeriesLocationsServices
    {
        private readonly ISeriesLocationsBusinessWorkflow workflow;

        public SeriesLocationsServices(ISeriesLocationsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ISeriesLocationModel> Any(GetSeriesLocations request) { return workflow.Search(request); }
        public List<ISeriesLocationModel> Any(GetSeriesLocationsAsListing request) { return workflow.Search(request, true); }
        public ISeriesLocationModel Any(GetSeriesLocation request) { return workflow.Get(request.ID); }
        public ISeriesLocationModel Any(GetSeriesLocationByKey request) { return workflow.Get(request.CustomKey); }
        public ISeriesLocationModel Any(CreateSeriesLocation request) { return workflow.Create(request); }
        public ISeriesLocationModel Any(UpdateSeriesLocation request) { return workflow.Update(request); }
        public bool Any(DeactivateSeriesLocation request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateSeriesLocationByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveSeriesLocation request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveSeriesLocationByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
