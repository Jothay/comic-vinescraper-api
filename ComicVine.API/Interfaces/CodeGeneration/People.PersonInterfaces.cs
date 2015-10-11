// <auto-generated>
// <copyright file="People.IPersonModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Person model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
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

namespace ComicVine.API.Interfaces.Models
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

namespace ComicVine.API.Interfaces.SearchModels
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

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IPersonMapper
        : IMapper<
            DataModels.IPerson,
            Models.IPersonModel,
            SearchModels.IPersonSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IPeopleRepository
        : IRepositoryBase
        , IRepository<DataModels.IPerson, SearchModels.IPersonSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IPeopleBusinessWorkflow
        : IBusinessWorkflow<Models.IPersonModel, SearchModels.IPersonSearchModel>
    {
    }
}