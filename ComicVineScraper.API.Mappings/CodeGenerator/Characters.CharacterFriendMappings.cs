// <auto-generated>
// <copyright file="Characters.ICharacterFriendMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between CharacterFriend and CharacterFriendModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in
// ComicVineScraper.API.Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVineScraper.API.Mappings//.Characters
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

    public static class CharacterFriendMapperExtensions
    {
        public static ICharacterFriendMapper Mapper = new CharacterFriendMapper();

        public static void OverrideMapper(ICharacterFriendMapper mapper) { Mapper = mapper; }

        public static ICharacterFriend MapToEntity(this ICharacterFriendModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this ICharacterFriendModel model, ref ICharacterFriend entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static ICharacterFriendModel MapToModel(this ICharacterFriend entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static ICharacterFriendModel MapToModelLite(this ICharacterFriend entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static ICharacterFriendModel MapToModelListing(this ICharacterFriend entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static ICharacterFriendSearchModel MapToSearchModel(this ICharacterFriendModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ICharacterFriendModel model, ICharacterFriend entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class CharacterFriendMapper : ICharacterFriendMapper
    {
        public virtual ICharacterFriend MapToEntity(ICharacterFriendModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<CharacterFriend, ICharacterFriendModel>(model);
            // CharacterFriend Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.FriendId = model.FriendId;
            entity.Friend = (Character)model.Friend?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(ICharacterFriendModel model, ref ICharacterFriend entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // CharacterFriend Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.FriendId = model.FriendId;
            entity.Friend = (Character)model.Friend?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual ICharacterFriendModel MapToModel(ICharacterFriend entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<ICharacterFriend, CharacterFriendModel>(entity);
            // CharacterFriend Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.Character = entity.Character?.MapToModel();
            model.FriendId = entity.FriendId;
            model.Friend = entity.Friend?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual ICharacterFriendModel MapToModelLite(ICharacterFriend entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<ICharacterFriend, CharacterFriendModel>(entity);
            // CharacterFriend Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.FriendId = entity.FriendId;
            // Return Entity
            return model;
        }

        public virtual ICharacterFriendModel MapToModelListing(ICharacterFriend entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<ICharacterFriend, CharacterFriendModel>(entity);
            // CharacterFriend Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.FriendId = entity.FriendId;
            // Return Entity
            return model;
        }

        public virtual ICharacterFriendSearchModel MapToSearchModel(ICharacterFriendModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ICharacterFriendModel, CharacterFriendSearchModel>(model);
            // Search Properties
            searchModel.CharacterId = model.CharacterId;
            searchModel.CharacterCustomKey = model.Character?.CustomKey;
            searchModel.CharacterApiDetailUrl = model.Character?.ApiDetailUrl;
            searchModel.CharacterSiteDetailUrl = model.Character?.SiteDetailUrl;
            searchModel.CharacterName = model.Character?.Name;
            searchModel.CharacterShortDescription = model.Character?.ShortDescription;
            searchModel.CharacterDescription = model.Character?.Description;
            searchModel.FriendId = model.FriendId;
            searchModel.FriendCustomKey = model.Friend?.CustomKey;
            searchModel.FriendApiDetailUrl = model.Friend?.ApiDetailUrl;
            searchModel.FriendSiteDetailUrl = model.Friend?.SiteDetailUrl;
            searchModel.FriendName = model.Friend?.Name;
            searchModel.FriendShortDescription = model.Friend?.ShortDescription;
            searchModel.FriendDescription = model.Friend?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(ICharacterFriendModel model, ICharacterFriend entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // CharacterFriend Properties
                // <None>
                // Related Objects
                && model.CharacterId == entity.CharacterId
                && model.FriendId == entity.FriendId
                ;
        }
    }
}
