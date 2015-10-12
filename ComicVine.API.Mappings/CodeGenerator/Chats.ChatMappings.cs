// <auto-generated>
// <copyright file="Chats.IChatModel.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved. ComicVine Original Api Copyright (c) ComicVine a subsidiary of CBS.
// </copyright>
// <summary>Implements the Mapping Layer functions between Chat and ChatModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in ComicVine.API.Mappings\Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
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

        public static IChat MapToEntity(this IChatModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IChatModel model, ref IChat entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IChatModel MapToModel(this IChat entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IChatModel MapToModelLite(this IChat entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IChatModel MapToModelListing(this IChat entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
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
        public virtual IChat MapToEntity(IChatModel model, int currentDepth = 1)
        {
            currentDepth++;
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

        public virtual void MapToEntity(IChatModel model, ref IChat entity, int currentDepth = 1)
        {
            currentDepth++;
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

        public virtual IChatModel MapToModel(IChat entity, int currentDepth = 1)
        {
            currentDepth++;
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

        public virtual IChatModel MapToModelLite(IChat entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = NameableEntityMapper.MapToModelLite<IChat, ChatModel>(entity);
            // Chat Properties
            model.ChannelName = entity.ChannelName;
            model.PasswordHash = entity.PasswordHash;
            // Related Objects
            model.ImageFileId = entity.ImageFileId;
            // Return Entity
            return model;
        }

        public virtual IChatModel MapToModelListing(IChat entity, int currentDepth = 1)
        {
            currentDepth++;
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
