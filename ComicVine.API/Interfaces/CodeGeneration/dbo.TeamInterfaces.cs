// <auto-generated>
// <copyright file="dbo.ITeamModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Team model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface ITeam : INameableEntity
    {
        // Team Properties
        // <None>
        // Related Objects
        int PrimaryImageFileId { get; set; }
        IImageFile PrimaryImageFile { get; set; }
        int FirstIssueAppearanceId { get; set; }
        IIssue FirstIssueAppearance { get; set; }
        int PublisherId { get; set; }
        IPublisher Publisher { get; set; }
        // Associated Objects
        ICollection<ICharacter> CharacterFriends { get; set; }
        ICollection<ICharacter> CharacterEnemies { get; set; }
        ICollection<IIssue> IssueAppearances { get; set; }
        ICollection<IIssue> IssueCredits { get; set; }
        ICollection<IIssue> DisbandedInIssues { get; set; }
        ICollection<IMovie> Movies { get; set; }
        ICollection<ITeamAlias> TeamAliases { get; set; }
        ICollection<ICharacter> TeamMembers { get; set; }
        ICollection<IStoryArc> StoryArcCredits { get; set; }
        ICollection<IVolume> VolumeCredits { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface ITeamModel : INameableEntityModel
    {
        // Team Properties
        // <None>
        // Related Objects
        int PrimaryImageFileId { get; set; }
        IImageFileModel PrimaryImageFile { get; set; }
        int FirstIssueAppearanceId { get; set; }
        IIssueModel FirstIssueAppearance { get; set; }
        int PublisherId { get; set; }
        IPublisherModel Publisher { get; set; }
        // Associated Objects
        List<ICharacterModel> CharacterFriends { get; set; }
        List<ICharacterModel> CharacterEnemies { get; set; }
        List<IIssueModel> IssueAppearances { get; set; }
        List<IIssueModel> IssueCredits { get; set; }
        List<IIssueModel> DisbandedInIssues { get; set; }
        List<IMovieModel> Movies { get; set; }
        List<ITeamAliasModel> TeamAliases { get; set; }
        List<ICharacterModel> TeamMembers { get; set; }
        List<IStoryArcModel> StoryArcCredits { get; set; }
        List<IVolumeModel> VolumeCredits { get; set; }
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface ITeamSearchModel : INameableEntitySearchModel
    {
        int? PrimaryImageFileId { get; set; }
        string PrimaryImageFileCustomKey { get; set; }
        string PrimaryImageFileApiDetailUrl { get; set; }
        string PrimaryImageFileSiteDetailUrl { get; set; }
        string PrimaryImageFileName { get; set; }
        string PrimaryImageFileShortDescription { get; set; }
        string PrimaryImageFileDescription { get; set; }
        int? FirstIssueAppearanceId { get; set; }
        string FirstIssueAppearanceCustomKey { get; set; }
        string FirstIssueAppearanceApiDetailUrl { get; set; }
        string FirstIssueAppearanceSiteDetailUrl { get; set; }
        string FirstIssueAppearanceName { get; set; }
        string FirstIssueAppearanceShortDescription { get; set; }
        string FirstIssueAppearanceDescription { get; set; }
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
    public interface ITeamMapper
        : IMapper<
            DataModels.ITeam,
            Models.ITeamModel,
            SearchModels.ITeamSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface ITeamsRepository
        : IRepositoryBase
        , IRepository<DataModels.ITeam, SearchModels.ITeamSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface ITeamsBusinessWorkflow
        : IBusinessWorkflow<Models.ITeamModel, SearchModels.ITeamSearchModel>
    {
    }
}