// <auto-generated>
// <copyright file="dbo.IChatModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Chat model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IChat : INameableEntity
    {
        // Chat Properties
        string ChannelName { get; set; }
        string PasswordHash { get; set; }
        // Related Objects
        int ImageFileId { get; set; }
        IImageFile ImageFile { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IChatModel : INameableEntityModel
    {
        // Chat Properties
        string ChannelName { get; set; }
        string PasswordHash { get; set; }
        // Related Objects
        int ImageFileId { get; set; }
        IImageFileModel ImageFile { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IChatSearchModel : INameableEntitySearchModel
    {
        int? ImageFileId { get; set; }
        string ImageFileCustomKey { get; set; }
        string ImageFileApiDetailUrl { get; set; }
        string ImageFileSiteDetailUrl { get; set; }
        string ImageFileName { get; set; }
        string ImageFileShortDescription { get; set; }
        string ImageFileDescription { get; set; }
        string ChannelName { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IChatMapper
        : IMapper<
            DataModels.IChat,
            Models.IChatModel,
            SearchModels.IChatSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IChatsRepository
        : IRepositoryBase
        , IRepository<DataModels.IChat, SearchModels.IChatSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IChatsBusinessWorkflow
        : IBusinessWorkflow<Models.IChatModel, SearchModels.IChatSearchModel>
    {
    }
}
