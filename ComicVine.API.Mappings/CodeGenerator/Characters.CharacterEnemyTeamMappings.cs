// <auto-generated>
// <copyright file="Characters.ICharacterEnemyTeamModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterEnemyTeam model interfaces.</summary>
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

    public static class CharacterEnemyTeamMapperExtensions
    {
        public static readonly CharacterEnemyTeamMapper Mapper = new CharacterEnemyTeamMapper();

        public static ICharacterEnemyTeam MapToEntity(this ICharacterEnemyTeamModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this ICharacterEnemyTeamModel model, ref ICharacterEnemyTeam entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static ICharacterEnemyTeamModel MapToModel(this ICharacterEnemyTeam entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static ICharacterEnemyTeamModel MapToModelLite(this ICharacterEnemyTeam entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static ICharacterEnemyTeamModel MapToModelListing(this ICharacterEnemyTeam entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static ICharacterEnemyTeamSearchModel MapToSearchModel(this ICharacterEnemyTeamModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ICharacterEnemyTeamModel model, ICharacterEnemyTeam entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class CharacterEnemyTeamMapper : ICharacterEnemyTeamMapper
    {
        public ICharacterEnemyTeam MapToEntity(ICharacterEnemyTeamModel model)
        {
            var entity = EntityMapper.MapToEntity<CharacterEnemyTeam, ICharacterEnemyTeamModel>(model);
            // CharacterEnemyTeam Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.EnemyTeamId = model.EnemyTeamId;
            entity.EnemyTeam = (Team)model.EnemyTeam?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public void MapToEntity(ICharacterEnemyTeamModel model, ref ICharacterEnemyTeam entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // CharacterEnemyTeam Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.EnemyTeamId = model.EnemyTeamId;
            entity.EnemyTeam = (Team)model.EnemyTeam?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public ICharacterEnemyTeamModel MapToModel(ICharacterEnemyTeam entity)
        {
            var model = EntityMapper.MapToModel<ICharacterEnemyTeam, CharacterEnemyTeamModel>(entity);
            // CharacterEnemyTeam Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.Character = entity.Character?.MapToModel();
            model.EnemyTeamId = entity.EnemyTeamId;
            model.EnemyTeam = entity.EnemyTeam?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public ICharacterEnemyTeamModel MapToModelLite(ICharacterEnemyTeam entity)
        {
            var model = EntityMapper.MapToModelLite<ICharacterEnemyTeam, CharacterEnemyTeamModel>(entity);
            // CharacterEnemyTeam Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.EnemyTeamId = entity.EnemyTeamId;
            // Return Entity
            return model;
        }

        public ICharacterEnemyTeamModel MapToModelListing(ICharacterEnemyTeam entity)
        {
            var model = EntityMapper.MapToModelListing<ICharacterEnemyTeam, CharacterEnemyTeamModel>(entity);
            // CharacterEnemyTeam Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.EnemyTeamId = entity.EnemyTeamId;
            // Return Entity
            return model;
        }

        public ICharacterEnemyTeamSearchModel MapToSearchModel(ICharacterEnemyTeamModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ICharacterEnemyTeamModel, CharacterEnemyTeamSearchModel>(model);
            // Search Properties
            searchModel.CharacterId = model.CharacterId;
            searchModel.CharacterCustomKey = model.Character?.CustomKey;
            searchModel.CharacterName = model.Character?.Name;
            searchModel.CharacterDescription = model.Character?.Description;
            searchModel.EnemyTeamId = model.EnemyTeamId;
            searchModel.EnemyTeamCustomKey = model.EnemyTeam?.CustomKey;
            searchModel.EnemyTeamName = model.EnemyTeam?.Name;
            searchModel.EnemyTeamDescription = model.EnemyTeam?.Description;
            // Return Search Model
            return searchModel;
        }

        public bool AreEqual(ICharacterEnemyTeamModel model, ICharacterEnemyTeam entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // CharacterEnemyTeam Properties
                // <None>
                // Related Objects
                && model.CharacterId == entity.CharacterId
                && model.EnemyTeamId == entity.EnemyTeamId
                ;
        }
    }
}
