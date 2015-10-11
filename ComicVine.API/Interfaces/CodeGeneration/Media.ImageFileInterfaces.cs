// <auto-generated>
// <copyright file="Media.IImageFileModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ImageFile model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IImageFile : INameableEntity
    {
        // ImageFile Properties
        // <None>
        // Related Objects
        // <None>
        // Associated Objects
        ICollection<ICharacter> Characters { get; set; }
        ICollection<IChat> Chats { get; set; }
        ICollection<IConcept> Concepts { get; set; }
        ICollection<IEpisode> Episodes { get; set; }
        ICollection<IIssue> Issues { get; set; }
        ICollection<ILocation> Locations { get; set; }
        ICollection<IMovie> Movies { get; set; }
        ICollection<IObject> Objects { get; set; }
        ICollection<IPerson> People { get; set; }
        ICollection<IPromo> Promos { get; set; }
        ICollection<IPublisher> Publishers { get; set; }
        ICollection<IStoryArc> StoryArcs { get; set; }
        ICollection<ITeam> Teams { get; set; }
        ICollection<IVideo> Videos { get; set; }
        ICollection<IVolume> Volumes { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IImageFileModel : INameableEntityModel
    {
        // ImageFile Properties
        // <None>
        // Related Objects
        // <None>
        // Associated Objects
        List<ICharacterModel> Characters { get; set; }
        List<IChatModel> Chats { get; set; }
        List<IConceptModel> Concepts { get; set; }
        List<IEpisodeModel> Episodes { get; set; }
        List<IIssueModel> Issues { get; set; }
        List<ILocationModel> Locations { get; set; }
        List<IMovieModel> Movies { get; set; }
        List<IObjectModel> Objects { get; set; }
        List<IPersonModel> People { get; set; }
        List<IPromoModel> Promos { get; set; }
        List<IPublisherModel> Publishers { get; set; }
        List<IStoryArcModel> StoryArcs { get; set; }
        List<ITeamModel> Teams { get; set; }
        List<IVideoModel> Videos { get; set; }
        List<IVolumeModel> Volumes { get; set; }
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IImageFileSearchModel : INameableEntitySearchModel
    {
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IImageFileMapper
        : IMapper<
            DataModels.IImageFile,
            Models.IImageFileModel,
            SearchModels.IImageFileSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IImageFilesRepository
        : IRepositoryBase
        , IRepository<DataModels.IImageFile, SearchModels.IImageFileSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IImageFilesBusinessWorkflow
        : IBusinessWorkflow<Models.IImageFileModel, SearchModels.IImageFileSearchModel>
    {
    }
}