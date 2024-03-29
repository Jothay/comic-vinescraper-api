// <auto-generated>
// <copyright file="Series.ISeriesServices.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the Series ServiceStack DTOs and Handlers.</summary>
// <remarks>This file was auto-generated using ServiceFileMaster.tt in
// ComicVineScraper.API.Services\Framework\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Services//.Series
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class SeriesModelBase : NameableEntityModelBase, ISeriesModel
    {
        // Series Properties
        public int Startyear { get; set; }
        // Related Objects
        public int? PublisherId { get; set; }
        public IPublisherModel Publisher { get; set; }
        public int? FirstEpisodeId { get; set; }
        public IEpisodeModel FirstEpisode { get; set; }
        public int? LastEpisodeId { get; set; }
        public IEpisodeModel LastEpisode { get; set; }
        // Associated Objects
        public List<IEpisodeModel> Episodes { get; set; }
        public List<ISeriesAliasModel> SeriesAliases { get; set; }
        public List<ISeriesCharacterModel> SeriesCharacters { get; set; }
        public List<ISeriesLocationModel> SeriesLocations { get; set; }
    }
    public class SeriesSearchModelBase : NameableEntitySearchModelBase, ISeriesSearchModel
    {
        [ApiMember(Name = "PublisherId", IsRequired = false, Description = "Filter by the Related PublisherId")]
        public int? PublisherId { get; set; }

        [ApiMember(Name = "PublisherCustomKey", IsRequired = false, Description = "Filter by the Related Publisher CustomKey (Equals, Case-Insensitive)")]
        public string PublisherCustomKey { get; set; }

        [ApiMember(Name = "PublisherApiDetailUrl", IsRequired = false, Description = "Filter by the Related Publisher Api Detail Url (Contains, Case-Insensitive)")]
        public string PublisherApiDetailUrl { get; set; }

        [ApiMember(Name = "PublisherSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Publisher Site Detail Url (Contains, Case-Insensitive)")]
        public string PublisherSiteDetailUrl { get; set; }

        [ApiMember(Name = "PublisherName", IsRequired = false, Description = "Filter by the Related Publisher Name (Contains, Case-Insensitive)")]
        public string PublisherName { get; set; }

        [ApiMember(Name = "PublisherShortDescription", IsRequired = false, Description = "Filter by the Related Publisher Short Description (Contains, Case-Insensitive)")]
        public string PublisherShortDescription { get; set; }

        [ApiMember(Name = "PublisherDescription", IsRequired = false, Description = "Filter by the Related Publisher Description (Contains, Case-Insensitive)")]
        public string PublisherDescription { get; set; }

        [ApiMember(Name = "FirstEpisodeId", IsRequired = false, Description = "Filter by the Related FirstEpisodeId")]
        public int? FirstEpisodeId { get; set; }

        [ApiMember(Name = "FirstEpisodeCustomKey", IsRequired = false, Description = "Filter by the Related FirstEpisode CustomKey (Equals, Case-Insensitive)")]
        public string FirstEpisodeCustomKey { get; set; }

        [ApiMember(Name = "FirstEpisodeApiDetailUrl", IsRequired = false, Description = "Filter by the Related FirstEpisode Api Detail Url (Contains, Case-Insensitive)")]
        public string FirstEpisodeApiDetailUrl { get; set; }

        [ApiMember(Name = "FirstEpisodeSiteDetailUrl", IsRequired = false, Description = "Filter by the Related FirstEpisode Site Detail Url (Contains, Case-Insensitive)")]
        public string FirstEpisodeSiteDetailUrl { get; set; }

        [ApiMember(Name = "FirstEpisodeName", IsRequired = false, Description = "Filter by the Related FirstEpisode Name (Contains, Case-Insensitive)")]
        public string FirstEpisodeName { get; set; }

        [ApiMember(Name = "FirstEpisodeShortDescription", IsRequired = false, Description = "Filter by the Related FirstEpisode Short Description (Contains, Case-Insensitive)")]
        public string FirstEpisodeShortDescription { get; set; }

        [ApiMember(Name = "FirstEpisodeDescription", IsRequired = false, Description = "Filter by the Related FirstEpisode Description (Contains, Case-Insensitive)")]
        public string FirstEpisodeDescription { get; set; }

        [ApiMember(Name = "LastEpisodeId", IsRequired = false, Description = "Filter by the Related LastEpisodeId")]
        public int? LastEpisodeId { get; set; }

        [ApiMember(Name = "LastEpisodeCustomKey", IsRequired = false, Description = "Filter by the Related LastEpisode CustomKey (Equals, Case-Insensitive)")]
        public string LastEpisodeCustomKey { get; set; }

        [ApiMember(Name = "LastEpisodeApiDetailUrl", IsRequired = false, Description = "Filter by the Related LastEpisode Api Detail Url (Contains, Case-Insensitive)")]
        public string LastEpisodeApiDetailUrl { get; set; }

        [ApiMember(Name = "LastEpisodeSiteDetailUrl", IsRequired = false, Description = "Filter by the Related LastEpisode Site Detail Url (Contains, Case-Insensitive)")]
        public string LastEpisodeSiteDetailUrl { get; set; }

        [ApiMember(Name = "LastEpisodeName", IsRequired = false, Description = "Filter by the Related LastEpisode Name (Contains, Case-Insensitive)")]
        public string LastEpisodeName { get; set; }

        [ApiMember(Name = "LastEpisodeShortDescription", IsRequired = false, Description = "Filter by the Related LastEpisode Short Description (Contains, Case-Insensitive)")]
        public string LastEpisodeShortDescription { get; set; }

        [ApiMember(Name = "LastEpisodeDescription", IsRequired = false, Description = "Filter by the Related LastEpisode Description (Contains, Case-Insensitive)")]
        public string LastEpisodeDescription { get; set; }

    }

    [Route("/Series/", "GET", Summary = "Gets All Active Series")]
    public class GetAnySeries : SeriesSearchModelBase, IReturn<List<ISeriesModel>> { }

    [Route("/Series/Listing", "GET", Summary = "Gets All Active Series with the mininum header information")]
    public class GetAnySeriesAsListing : SeriesSearchModelBase, IReturn<List<ISeriesModel>> { }

    [Route("/Series/{ID}", "GET", Summary = "Gets Series by Identifier")]
    public class GetSeries : ImplementsID, IReturn<ISeriesModel> { }

    [Route("/Series/{CustomKey}/ByKey", "GET", Summary = "Gets Series by Key")]
    public class GetSeriesByKey : ImplementsKey, IReturn<ISeriesModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Series/Create", "POST", Summary = "Creates an Series with these contents")]
    public class CreateSeries : SeriesModelBase, IReturn<ISeriesModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Series/Update", "POST", Summary = "Updates an Series with new contents")]
    public class UpdateSeries : SeriesModelBase, IReturn<ISeriesModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Series/{ID}/Deactivate", "POST", Summary = "Deactivates an Series by Identifier")]
    public class DeactivateSeries : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Series/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an Series by Key")]
    public class DeactivateSeriesByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Series/{ID}/Remove", "POST", Summary = "Removes an Series by Identifier")]
    public class RemoveSeries : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Series/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an Series by Key")]
    public class RemoveSeriesByKey : ImplementsKey, IReturn<bool> { }

    public interface ISeriesServices
    {
        List<ISeriesModel> Any(GetAnySeries request);
        List<ISeriesModel> Any(GetAnySeriesAsListing request);
        ISeriesModel Any(GetSeries request);
        ISeriesModel Any(GetSeriesByKey request);
        ISeriesModel Any(CreateSeries request);
        ISeriesModel Any(UpdateSeries request);
        bool Any(DeactivateSeries request);
        bool Any(DeactivateSeriesByKey request);
        bool Any(RemoveSeries request);
        bool Any(RemoveSeriesByKey request);
    }

    public class SeriesServices : Service, ISeriesServices
    {
        private readonly ISeriesBusinessWorkflow workflow;

        public SeriesServices(ISeriesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ISeriesModel> Any(GetAnySeries request) { return workflow.Search(request); }
        public List<ISeriesModel> Any(GetAnySeriesAsListing request) { return workflow.Search(request, true); }
        public ISeriesModel Any(GetSeries request) { return workflow.Get(request.ID); }
        public ISeriesModel Any(GetSeriesByKey request) { return workflow.Get(request.CustomKey); }
        public ISeriesModel Any(CreateSeries request) { return workflow.Create(request); }
        public ISeriesModel Any(UpdateSeries request) { return workflow.Update(request); }
        public bool Any(DeactivateSeries request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateSeriesByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveSeries request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveSeriesByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
