// <auto-generated>
// <copyright file="Characters.CharacterInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the Character interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVineScraper.API\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVineScraper.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface ICharacter : INameableEntity
    {
        // Character Properties
        string RealName { get; set; }
        DateTime? DateOfBirth { get; set; }
        // Related Objects
        int PrimaryImageFileId { get; set; }
        IImageFile PrimaryImageFile { get; set; }
        int FirstIssueAppearanceId { get; set; }
        IIssue FirstIssueAppearance { get; set; }
        int GenderId { get; set; }
        IGender Gender { get; set; }
        int OriginId { get; set; }
        IOrigin Origin { get; set; }
        int PublisherId { get; set; }
        IPublisher Publisher { get; set; }
        // Associated Objects
        ICollection<ICharacterAlias> CharacterAliases { get; set; }
        ICollection<ICharacterCreator> CharacterCreators { get; set; }
        ICollection<ICharacterEnemy> CharacterEnemies { get; set; }
        ICollection<ICharacterEnemyTeam> CharacterEnemyTeams { get; set; }
        ICollection<ICharacterFriend> CharacterFriends { get; set; }
        ICollection<ICharacterFriendlyTeam> CharacterFriendlyTeams { get; set; }
        ICollection<ICharacterAppearedInIssue> CharacterIssuesAppearedIn { get; set; }
        ICollection<ICharacterDiedInIssue> CharacterIssuesDiedIn { get; set; }
        ICollection<ICharacterIssue> CharacterIssues { get; set; }
        ICollection<ICharacterMovie> CharacterMovies { get; set; }
        ICollection<ICharacterPower> CharacterPowers { get; set; }
        ICollection<ICharacterStoryArc> CharacterStoryArcs { get; set; }
        ICollection<ICharacterTeam> CharacterTeams { get; set; }
        ICollection<ICharacterVolume> CharacterVolumes { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface ICharacterModel : INameableEntityModel
    {
        // Character Properties
        string RealName { get; set; }
        DateTime? DateOfBirth { get; set; }
        // Related Objects
        int PrimaryImageFileId { get; set; }
        IImageFileModel PrimaryImageFile { get; set; }
        int FirstIssueAppearanceId { get; set; }
        IIssueModel FirstIssueAppearance { get; set; }
        int GenderId { get; set; }
        IGenderModel Gender { get; set; }
        int OriginId { get; set; }
        IOriginModel Origin { get; set; }
        int PublisherId { get; set; }
        IPublisherModel Publisher { get; set; }
        // Associated Objects
        List<ICharacterAliasModel> CharacterAliases { get; set; }
        List<ICharacterCreatorModel> CharacterCreators { get; set; }
        List<ICharacterEnemyModel> CharacterEnemies { get; set; }
        List<ICharacterEnemyTeamModel> CharacterEnemyTeams { get; set; }
        List<ICharacterFriendModel> CharacterFriends { get; set; }
        List<ICharacterFriendlyTeamModel> CharacterFriendlyTeams { get; set; }
        List<ICharacterAppearedInIssueModel> CharacterIssuesAppearedIn { get; set; }
        List<ICharacterDiedInIssueModel> CharacterIssuesDiedIn { get; set; }
        List<ICharacterIssueModel> CharacterIssues { get; set; }
        List<ICharacterMovieModel> CharacterMovies { get; set; }
        List<ICharacterPowerModel> CharacterPowers { get; set; }
        List<ICharacterStoryArcModel> CharacterStoryArcs { get; set; }
        List<ICharacterTeamModel> CharacterTeams { get; set; }
        List<ICharacterVolumeModel> CharacterVolumes { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.SearchModels
{
    public interface ICharacterSearchModel : INameableEntitySearchModel
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
        int? GenderId { get; set; }
        string GenderCustomKey { get; set; }
        string GenderApiDetailUrl { get; set; }
        string GenderSiteDetailUrl { get; set; }
        string GenderName { get; set; }
        string GenderShortDescription { get; set; }
        string GenderDescription { get; set; }
        int? OriginId { get; set; }
        string OriginCustomKey { get; set; }
        string OriginApiDetailUrl { get; set; }
        string OriginSiteDetailUrl { get; set; }
        string OriginName { get; set; }
        string OriginShortDescription { get; set; }
        string OriginDescription { get; set; }
        int? PublisherId { get; set; }
        string PublisherCustomKey { get; set; }
        string PublisherApiDetailUrl { get; set; }
        string PublisherSiteDetailUrl { get; set; }
        string PublisherName { get; set; }
        string PublisherShortDescription { get; set; }
        string PublisherDescription { get; set; }
        string RealName { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.Mappers
{
    public interface ICharacterMapper
        : IMapper<
            DataModels.ICharacter,
            Models.ICharacterModel,
            SearchModels.ICharacterSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.Repositories
{
    public interface ICharactersRepository
        : IRepositoryBase
        , IRepository<DataModels.ICharacter, SearchModels.ICharacterSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.BusinessWorkflows
{
    public interface ICharactersBusinessWorkflow
        : IBusinessWorkflow<Models.ICharacterModel, SearchModels.ICharacterSearchModel>
    {
    }
}
