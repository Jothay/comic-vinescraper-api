// <auto-generated>
// <copyright file="Characters.ICharacterFriendlyTeamModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterFriendlyTeam model interfaces.</summary>
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

    public static class CharacterFriendlyTeamMapperExtensions
    {
        public static ICharacterFriendlyTeamMapper Mapper = new CharacterFriendlyTeamMapper();

        public static void OverrideMapper(ICharacterFriendlyTeamMapper mapper) { Mapper = mapper; }

        public static ICharacterFriendlyTeam MapToEntity(this ICharacterFriendlyTeamModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this ICharacterFriendlyTeamModel model, ref ICharacterFriendlyTeam entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static ICharacterFriendlyTeamModel MapToModel(this ICharacterFriendlyTeam entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static ICharacterFriendlyTeamModel MapToModelLite(this ICharacterFriendlyTeam entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static ICharacterFriendlyTeamModel MapToModelListing(this ICharacterFriendlyTeam entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static ICharacterFriendlyTeamSearchModel MapToSearchModel(this ICharacterFriendlyTeamModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ICharacterFriendlyTeamModel model, ICharacterFriendlyTeam entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class CharacterFriendlyTeamMapper : ICharacterFriendlyTeamMapper
    {
        public virtual ICharacterFriendlyTeam MapToEntity(ICharacterFriendlyTeamModel model)
        {
            var entity = EntityMapper.MapToEntity<CharacterFriendlyTeam, ICharacterFriendlyTeamModel>(model);
            // CharacterFriendlyTeam Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.FriendlyTeamId = model.FriendlyTeamId;
            entity.FriendlyTeam = (Team)model.FriendlyTeam?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(ICharacterFriendlyTeamModel model, ref ICharacterFriendlyTeam entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // CharacterFriendlyTeam Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.FriendlyTeamId = model.FriendlyTeamId;
            entity.FriendlyTeam = (Team)model.FriendlyTeam?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual ICharacterFriendlyTeamModel MapToModel(ICharacterFriendlyTeam entity)
        {
            var model = EntityMapper.MapToModel<ICharacterFriendlyTeam, CharacterFriendlyTeamModel>(entity);
            // CharacterFriendlyTeam Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.Character = entity.Character?.MapToModel();
            model.FriendlyTeamId = entity.FriendlyTeamId;
            model.FriendlyTeam = entity.FriendlyTeam?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual ICharacterFriendlyTeamModel MapToModelLite(ICharacterFriendlyTeam entity)
        {
            var model = EntityMapper.MapToModelLite<ICharacterFriendlyTeam, CharacterFriendlyTeamModel>(entity);
            // CharacterFriendlyTeam Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.FriendlyTeamId = entity.FriendlyTeamId;
            // Return Entity
            return model;
        }

        public virtual ICharacterFriendlyTeamModel MapToModelListing(ICharacterFriendlyTeam entity)
        {
            var model = EntityMapper.MapToModelListing<ICharacterFriendlyTeam, CharacterFriendlyTeamModel>(entity);
            // CharacterFriendlyTeam Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.FriendlyTeamId = entity.FriendlyTeamId;
            // Return Entity
            return model;
        }

        public virtual ICharacterFriendlyTeamSearchModel MapToSearchModel(ICharacterFriendlyTeamModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ICharacterFriendlyTeamModel, CharacterFriendlyTeamSearchModel>(model);
            // Search Properties
            searchModel.CharacterId = model.CharacterId;
            searchModel.CharacterCustomKey = model.Character?.CustomKey;
            searchModel.CharacterApiDetailUrl = model.Character?.ApiDetailUrl;
            searchModel.CharacterSiteDetailUrl = model.Character?.SiteDetailUrl;
            searchModel.CharacterName = model.Character?.Name;
            searchModel.CharacterShortDescription = model.Character?.ShortDescription;
            searchModel.CharacterDescription = model.Character?.Description;
            searchModel.FriendlyTeamId = model.FriendlyTeamId;
            searchModel.FriendlyTeamCustomKey = model.FriendlyTeam?.CustomKey;
            searchModel.FriendlyTeamApiDetailUrl = model.FriendlyTeam?.ApiDetailUrl;
            searchModel.FriendlyTeamSiteDetailUrl = model.FriendlyTeam?.SiteDetailUrl;
            searchModel.FriendlyTeamName = model.FriendlyTeam?.Name;
            searchModel.FriendlyTeamShortDescription = model.FriendlyTeam?.ShortDescription;
            searchModel.FriendlyTeamDescription = model.FriendlyTeam?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(ICharacterFriendlyTeamModel model, ICharacterFriendlyTeam entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // CharacterFriendlyTeam Properties
                // <None>
                // Related Objects
                && model.CharacterId == entity.CharacterId
                && model.FriendlyTeamId == entity.FriendlyTeamId
                ;
        }
    }
}
