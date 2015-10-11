// <auto-generated>
// <copyright file="Characters.ICharacterFriendModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterFriend model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Mappings//.Characters
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
        public static readonly CharacterFriendMapper Mapper = new CharacterFriendMapper();

        public static ICharacterFriend MapToEntity(this ICharacterFriendModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this ICharacterFriendModel model, ref ICharacterFriend entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static ICharacterFriendModel MapToModel(this ICharacterFriend entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static ICharacterFriendModel MapToModelLite(this ICharacterFriend entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static ICharacterFriendModel MapToModelListing(this ICharacterFriend entity)
        {
            return Mapper.MapToModelListing(entity);
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
        public ICharacterFriend MapToEntity(ICharacterFriendModel model)
        {
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

        public void MapToEntity(ICharacterFriendModel model, ref ICharacterFriend entity)
        {
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

        public ICharacterFriendModel MapToModel(ICharacterFriend entity)
        {
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

        public ICharacterFriendModel MapToModelLite(ICharacterFriend entity)
        {
            var model = EntityMapper.MapToModelLite<ICharacterFriend, CharacterFriendModel>(entity);
            // CharacterFriend Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.FriendId = entity.FriendId;
            // Return Entity
            return model;
        }

        public ICharacterFriendModel MapToModelListing(ICharacterFriend entity)
        {
            var model = EntityMapper.MapToModelListing<ICharacterFriend, CharacterFriendModel>(entity);
            // CharacterFriend Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.FriendId = entity.FriendId;
            // Return Entity
            return model;
        }

        public ICharacterFriendSearchModel MapToSearchModel(ICharacterFriendModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ICharacterFriendModel, CharacterFriendSearchModel>(model);
            // Search Properties
            searchModel.CharacterId = model.CharacterId;
            searchModel.CharacterCustomKey = model.Character?.CustomKey;
            searchModel.CharacterName = model.Character?.Name;
            searchModel.CharacterDescription = model.Character?.Description;
            searchModel.FriendId = model.FriendId;
            searchModel.FriendCustomKey = model.Friend?.CustomKey;
            searchModel.FriendName = model.Friend?.Name;
            searchModel.FriendDescription = model.Friend?.Description;
            // Return Search Model
            return searchModel;
        }

        public bool AreEqual(ICharacterFriendModel model, ICharacterFriend entity)
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
