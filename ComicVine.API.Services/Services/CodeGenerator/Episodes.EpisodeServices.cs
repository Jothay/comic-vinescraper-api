// <auto-generated>
// <copyright file="Episodes.IEpisodeModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Episode model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Episodes
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;

    public class EpisodeModelBase : NameableEntityModelBase, IEpisodeModel
    {
        // Episode Properties
        public bool HasStaffReview { get; set; }
        public DateTime? AirDate { get; set; }
        public string EpisodeCode { get; set; }
        public int? SeasonNumber { get; set; }
        public int? EpisodeNumber { get; set; }
        // Related Objects
        public int? PrimaryImageFileId { get; set; }
        public IImageFileModel PrimaryImageFile { get; set; }
        public int? SeriesId { get; set; }
        public ISeriesModel Series { get; set; }
        // Associated Objects
        public List<IEpisodeAliasModel> EpisodeAliases { get; set; }
        public List<IEpisodeCharacterModel> EpisodeCharacters { get; set; }
        public List<IEpisodeCharacterDiedModel> EpisodeCharactersDied { get; set; }
        public List<IEpisodeCharacterFirstAppearanceModel> EpisodeCharacterFirstAppearances { get; set; }
        public List<IEpisodeConceptModel> EpisodeConcepts { get; set; }
        public List<IEpisodeConceptFirstAppearanceModel> EpisodeConceptFirstAppearances { get; set; }
        public List<IEpisodeLocationModel> EpisodeLocations { get; set; }
        public List<IEpisodeLocationFirstAppearanceModel> EpisodeLocationFirstAppearances { get; set; }
        public List<IEpisodeObjectModel> EpisodeObjects { get; set; }
        public List<IEpisodeObjectFirstAppearanceModel> EpisodeObjectFirstAppearances { get; set; }
        public List<IEpisodePersonModel> EpisodePeople { get; set; }
        public List<IEpisodeStoryArcModel> EpisodeStoryArcs { get; set; }
        public List<IEpisodeStoryArcFirstAppearanceModel> EpisodeStoryArcFirstAppearances { get; set; }
        public List<IEpisodeTeamModel> EpisodeTeams { get; set; }
        public List<IEpisodeTeamFirstAppearanceModel> EpisodeTeamFirstAppearances { get; set; }
    }
    public class EpisodeSearchModelBase : NameableEntitySearchModelBase, IEpisodeSearchModel
    {
        [ApiMember(Name = "PrimaryImageFileId", IsRequired = false, Description = "Filter by the Related PrimaryImageFileId")]
        public int? PrimaryImageFileId { get; set; }

        [ApiMember(Name = "PrimaryImageFileCustomKey", IsRequired = false, Description = "Filter by the Related PrimaryImageFile CustomKey (Equals, Case-Insensitive)")]
        public string PrimaryImageFileCustomKey { get; set; }

        [ApiMember(Name = "PrimaryImageFileApiDetailUrl", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Api Detail Url (Contains, Case-Insensitive)")]
        public string PrimaryImageFileApiDetailUrl { get; set; }

        [ApiMember(Name = "PrimaryImageFileSiteDetailUrl", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Site Detail Url (Contains, Case-Insensitive)")]
        public string PrimaryImageFileSiteDetailUrl { get; set; }

        [ApiMember(Name = "PrimaryImageFileName", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Name (Contains, Case-Insensitive)")]
        public string PrimaryImageFileName { get; set; }

        [ApiMember(Name = "PrimaryImageFileShortDescription", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Short Description (Contains, Case-Insensitive)")]
        public string PrimaryImageFileShortDescription { get; set; }

        [ApiMember(Name = "PrimaryImageFileDescription", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Description (Contains, Case-Insensitive)")]
        public string PrimaryImageFileDescription { get; set; }

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

        [ApiMember(Name = "HasStaffReview", IsRequired = false, Description = "The HasStaffReview to search by.")]
        public bool? HasStaffReview { get; set; }

    }

    [Route("/Episodes/", "GET", Summary = "Gets All Active Episodes")]
    public class GetEpisodes : EpisodeSearchModelBase, IReturn<List<IEpisodeModel>> { }

    [Route("/Episodes/Listing", "GET", Summary = "Gets All Active Episodes with the mininum header information")]
    public class GetEpisodesAsListing : EpisodeSearchModelBase, IReturn<List<IEpisodeModel>> { }

    [Route("/Episodes/{ID}", "GET", Summary = "Gets Episode by Identifier")]
    public class GetEpisode : ImplementsID, IReturn<IEpisodeModel> { }

    [Route("/Episodes/{CustomKey}/ByKey", "GET", Summary = "Gets Episode by Key")]
    public class GetEpisodeByKey : ImplementsKey, IReturn<IEpisodeModel> { }

    //[Authenticate]
    [Route("/Episodes/Create", "POST", Summary = "Creates an Episode with these contents")]
    public class CreateEpisode : EpisodeModelBase, IReturn<IEpisodeModel> { }

    //[Authenticate]
    [Route("/Episodes/Update", "POST", Summary = "Updates an Episode with new contents")]
    public class UpdateEpisode : EpisodeModelBase, IReturn<IEpisodeModel> { }

    //[Authenticate]
    [Route("/Episodes/{ID}/Deactivate", "POST", Summary = "Deactivates an Episode by Identifier")]
    public class DeactivateEpisode : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/Episodes/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an Episode by Key")]
    public class DeactivateEpisodeByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/Episodes/{ID}/Remove", "POST", Summary = "Removes an Episode by Identifier")]
    public class RemoveEpisode : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/Episodes/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an Episode by Key")]
    public class RemoveEpisodeByKey : ImplementsKey, IReturn<bool> { }

    public interface IEpisodesServices
    {
        List<IEpisodeModel> Any(GetEpisodes request);
        List<IEpisodeModel> Any(GetEpisodesAsListing request);
        IEpisodeModel Any(GetEpisode request);
        IEpisodeModel Any(GetEpisodeByKey request);
        IEpisodeModel Any(CreateEpisode request);
        IEpisodeModel Any(UpdateEpisode request);
        bool Any(DeactivateEpisode request);
        bool Any(DeactivateEpisodeByKey request);
        bool Any(RemoveEpisode request);
        bool Any(RemoveEpisodeByKey request);
    }

    public class EpisodesServices : /*ServicesBase,*/ IEpisodesServices
    {
        private readonly IEpisodesBusinessWorkflow workflow;

        public EpisodesServices(IEpisodesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IEpisodeModel> Any(GetEpisodes request) { return workflow.Search(request); }
        public List<IEpisodeModel> Any(GetEpisodesAsListing request) { return workflow.Search(request, true); }
        public IEpisodeModel Any(GetEpisode request) { return workflow.Get(request.ID); }
        public IEpisodeModel Any(GetEpisodeByKey request) { return workflow.Get(request.CustomKey); }
        public IEpisodeModel Any(CreateEpisode request) { return workflow.Create(request); }
        public IEpisodeModel Any(UpdateEpisode request) { return workflow.Update(request); }
        public bool Any(DeactivateEpisode request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateEpisodeByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveEpisode request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveEpisodeByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
