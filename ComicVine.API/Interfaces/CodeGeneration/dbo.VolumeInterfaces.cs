// <auto-generated>
// <copyright file="dbo.IVolumeModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Volume model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IVolume : INameableEntity
    {
        // Volume Properties
        int Startyear { get; set; }
        // Related Objects
        int? PrimaryImageFileId { get; set; }
        IImageFile PrimaryImageFile { get; set; }
        int? FirstIssueId { get; set; }
        IIssue FirstIssue { get; set; }
        int? LastIssueId { get; set; }
        IIssue LastIssue { get; set; }
        int? PublisherId { get; set; }
        IPublisher Publisher { get; set; }
        // Associated Objects
        ICollection<ICharacter> CharacterCredits { get; set; }
        ICollection<IConcept> ConceptCredits { get; set; }
        ICollection<IIssue> Issues { get; set; }
        ICollection<ILocation> LocationCredits { get; set; }
        ICollection<IObject> ObjectCredits { get; set; }
        ICollection<IPerson> PersonCredits { get; set; }
        ICollection<ITeam> TeamCredits { get; set; }
        ICollection<IVolumeAlias> VolumeAliases { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IVolumeModel : INameableEntityModel
    {
        // Volume Properties
        int Startyear { get; set; }
        // Related Objects
        int? PrimaryImageFileId { get; set; }
        IImageFileModel PrimaryImageFile { get; set; }
        int? FirstIssueId { get; set; }
        IIssueModel FirstIssue { get; set; }
        int? LastIssueId { get; set; }
        IIssueModel LastIssue { get; set; }
        int? PublisherId { get; set; }
        IPublisherModel Publisher { get; set; }
        // Associated Objects
        List<ICharacterModel> CharacterCredits { get; set; }
        List<IConceptModel> ConceptCredits { get; set; }
        List<IIssueModel> Issues { get; set; }
        List<ILocationModel> LocationCredits { get; set; }
        List<IObjectModel> ObjectCredits { get; set; }
        List<IPersonModel> PersonCredits { get; set; }
        List<ITeamModel> TeamCredits { get; set; }
        List<IVolumeAliasModel> VolumeAliases { get; set; }
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IVolumeSearchModel : INameableEntitySearchModel
    {
        int? PrimaryImageFileId { get; set; }
        string PrimaryImageFileCustomKey { get; set; }
        string PrimaryImageFileApiDetailUrl { get; set; }
        string PrimaryImageFileSiteDetailUrl { get; set; }
        string PrimaryImageFileName { get; set; }
        string PrimaryImageFileShortDescription { get; set; }
        string PrimaryImageFileDescription { get; set; }
        int? FirstIssueId { get; set; }
        string FirstIssueCustomKey { get; set; }
        string FirstIssueApiDetailUrl { get; set; }
        string FirstIssueSiteDetailUrl { get; set; }
        string FirstIssueName { get; set; }
        string FirstIssueShortDescription { get; set; }
        string FirstIssueDescription { get; set; }
        int? LastIssueId { get; set; }
        string LastIssueCustomKey { get; set; }
        string LastIssueApiDetailUrl { get; set; }
        string LastIssueSiteDetailUrl { get; set; }
        string LastIssueName { get; set; }
        string LastIssueShortDescription { get; set; }
        string LastIssueDescription { get; set; }
        int? PublisherId { get; set; }
        string PublisherCustomKey { get; set; }
        string PublisherApiDetailUrl { get; set; }
        string PublisherSiteDetailUrl { get; set; }
        string PublisherName { get; set; }
        string PublisherShortDescription { get; set; }
        string PublisherDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IVolumeMapper
        : IMapper<
            DataModels.IVolume,
            Models.IVolumeModel,
            SearchModels.IVolumeSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IVolumesRepository
        : IRepositoryBase
        , IRepository<DataModels.IVolume, SearchModels.IVolumeSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IVolumesBusinessWorkflow
        : IBusinessWorkflow<Models.IVolumeModel, SearchModels.IVolumeSearchModel>
    {
    }
}
