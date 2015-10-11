// <auto-generated>
// <copyright file="Chats.IChatModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Chat model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Mappings//.Chats
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Mappers;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Models;
    using SearchModels;

    public static class ChatMapperExtensions
    {
        public static IChatMapper Mapper = new ChatMapper();

        public static void OverrideMapper(IChatMapper mapper) { Mapper = mapper; }

        public static IChat MapToEntity(this IChatModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IChatModel model, ref IChat entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IChatModel MapToModel(this IChat entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IChatModel MapToModelLite(this IChat entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IChatModel MapToModelListing(this IChat entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IChatSearchModel MapToSearchModel(this IChatModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IChatModel model, IChat entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class ChatMapper : IChatMapper
    {
        public virtual IChat MapToEntity(IChatModel model)
        {
            var entity = NameableEntityMapper.MapToEntity<Chat, IChatModel>(model);
            // Chat Properties
            entity.ChannelName = model.ChannelName;
            entity.PasswordHash = model.PasswordHash;
            // Related Objects
            entity.ImageFileId = model.ImageFileId;
            entity.ImageFile = (ImageFile)model.ImageFile?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IChatModel model, ref IChat entity)
        {
            // Assign Base properties
            NameableEntityMapper.MapToEntity(model, ref entity);
            // Chat Properties
            entity.ChannelName = model.ChannelName;
            entity.PasswordHash = model.PasswordHash;
            // Related Objects
            entity.ImageFileId = model.ImageFileId;
            entity.ImageFile = (ImageFile)model.ImageFile?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IChatModel MapToModel(IChat entity)
        {
            var model = NameableEntityMapper.MapToModel<IChat, ChatModel>(entity);
            // Chat Properties
            model.ChannelName = entity.ChannelName;
            model.PasswordHash = entity.PasswordHash;
            // Related Objects
            model.ImageFileId = entity.ImageFileId;
            model.ImageFile = entity.ImageFile?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IChatModel MapToModelLite(IChat entity)
        {
            var model = NameableEntityMapper.MapToModelLite<IChat, ChatModel>(entity);
            // Chat Properties
            model.ChannelName = entity.ChannelName;
            model.PasswordHash = entity.PasswordHash;
            // Related Objects
            model.ImageFileId = entity.ImageFileId;
            // Return Entity
            return model;
        }

        public virtual IChatModel MapToModelListing(IChat entity)
        {
            var model = NameableEntityMapper.MapToModelListing<IChat, ChatModel>(entity);
            // Chat Properties
            model.ChannelName = entity.ChannelName;
            model.PasswordHash = entity.PasswordHash;
            // Related Objects
            model.ImageFileId = entity.ImageFileId;
            // Return Entity
            return model;
        }

        public virtual IChatSearchModel MapToSearchModel(IChatModel model)
        {
            var searchModel = NameableEntityMapper.MapToSearchModel<IChatModel, ChatSearchModel>(model);
            // Search Properties
            searchModel.ImageFileId = model.ImageFileId;
            searchModel.ImageFileCustomKey = model.ImageFile?.CustomKey;
            searchModel.ImageFileApiDetailUrl = model.ImageFile?.ApiDetailUrl;
            searchModel.ImageFileSiteDetailUrl = model.ImageFile?.SiteDetailUrl;
            searchModel.ImageFileName = model.ImageFile?.Name;
            searchModel.ImageFileShortDescription = model.ImageFile?.ShortDescription;
            searchModel.ImageFileDescription = model.ImageFile?.Description;
            searchModel.ChannelName = model.ChannelName;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IChatModel model, IChat entity)
        {
            return NameableEntityMapper.AreEqual(model, entity)
                // Chat Properties
                && model.ChannelName == entity.ChannelName
                && model.PasswordHash == entity.PasswordHash
                // Related Objects
                && model.ImageFileId == entity.ImageFileId
                ;
        }
    }
}
