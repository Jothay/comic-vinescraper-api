// <auto-generated>
// <copyright file="People.PersonInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the Person interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVineScraper.API\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVineScraper.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IPerson : INameableEntity
    {
        // Person Properties
        string Hometown { get; set; }
        string Country { get; set; }
        string Email { get; set; }
        string Website { get; set; }
        DateTime? BirthDate { get; set; }
        DateTime? DeathDate { get; set; }
        // Related Objects
        int PrimaryImageFileId { get; set; }
        IImageFile PrimaryImageFile { get; set; }
        int? GenderId { get; set; }
        IGender Gender { get; set; }
        // Associated Objects
        ICollection<ICreatorCharacter> CharactersCreated { get; set; }
        ICollection<IPersonAlias> PersonAliases { get; set; }
        ICollection<IIssueWriter> IssuesWritten { get; set; }
        ICollection<IMovieProducer> MoviesProduced { get; set; }
        ICollection<IMovieWriter> MoviesWritten { get; set; }
        ICollection<IPromo> PromosWritten { get; set; }
        ICollection<IStoryArcWriter> StoryArcsWritten { get; set; }
        ICollection<IVolumeWriter> VolumesWritten { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IPersonModel : INameableEntityModel
    {
        // Person Properties
        string Hometown { get; set; }
        string Country { get; set; }
        string Email { get; set; }
        string Website { get; set; }
        DateTime? BirthDate { get; set; }
        DateTime? DeathDate { get; set; }
        // Related Objects
        int PrimaryImageFileId { get; set; }
        IImageFileModel PrimaryImageFile { get; set; }
        int? GenderId { get; set; }
        IGenderModel Gender { get; set; }
        // Associated Objects
        List<ICreatorCharacterModel> CharactersCreated { get; set; }
        List<IPersonAliasModel> PersonAliases { get; set; }
        List<IIssueWriterModel> IssuesWritten { get; set; }
        List<IMovieProducerModel> MoviesProduced { get; set; }
        List<IMovieWriterModel> MoviesWritten { get; set; }
        List<IPromoModel> PromosWritten { get; set; }
        List<IStoryArcWriterModel> StoryArcsWritten { get; set; }
        List<IVolumeWriterModel> VolumesWritten { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.SearchModels
{
    public interface IPersonSearchModel : INameableEntitySearchModel
    {
        int? PrimaryImageFileId { get; set; }
        string PrimaryImageFileCustomKey { get; set; }
        string PrimaryImageFileApiDetailUrl { get; set; }
        string PrimaryImageFileSiteDetailUrl { get; set; }
        string PrimaryImageFileName { get; set; }
        string PrimaryImageFileShortDescription { get; set; }
        string PrimaryImageFileDescription { get; set; }
        int? GenderId { get; set; }
        string GenderCustomKey { get; set; }
        string GenderApiDetailUrl { get; set; }
        string GenderSiteDetailUrl { get; set; }
        string GenderName { get; set; }
        string GenderShortDescription { get; set; }
        string GenderDescription { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.Mappers
{
    public interface IPersonMapper
        : IMapper<
            DataModels.IPerson,
            Models.IPersonModel,
            SearchModels.IPersonSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.Repositories
{
    public interface IPeopleRepository
        : IRepositoryBase
        , IRepository<DataModels.IPerson, SearchModels.IPersonSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.BusinessWorkflows
{
    public interface IPeopleBusinessWorkflow
        : IBusinessWorkflow<Models.IPersonModel, SearchModels.IPersonSearchModel>
    {
    }
}
