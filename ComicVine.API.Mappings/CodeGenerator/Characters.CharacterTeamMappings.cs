// <auto-generated>
// <copyright file="Characters.ICharacterTeamModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterTeam model interfaces.</summary>
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

    public static class CharacterTeamMapperExtensions
    {
        public static readonly CharacterTeamMapper Mapper = new CharacterTeamMapper();

        public static ICharacterTeam MapToEntity(this ICharacterTeamModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this ICharacterTeamModel model, ref ICharacterTeam entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static ICharacterTeamModel MapToModel(this ICharacterTeam entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static ICharacterTeamModel MapToModelLite(this ICharacterTeam entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static ICharacterTeamModel MapToModelListing(this ICharacterTeam entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static ICharacterTeamSearchModel MapToSearchModel(this ICharacterTeamModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ICharacterTeamModel model, ICharacterTeam entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class CharacterTeamMapper : ICharacterTeamMapper
    {
        public ICharacterTeam MapToEntity(ICharacterTeamModel model)
        {
            var entity = EntityMapper.MapToEntity<CharacterTeam, ICharacterTeamModel>(model);
            // CharacterTeam Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.TeamId = model.TeamId;
            entity.Team = (Team)model.Team?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public void MapToEntity(ICharacterTeamModel model, ref ICharacterTeam entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // CharacterTeam Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.TeamId = model.TeamId;
            entity.Team = (Team)model.Team?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public ICharacterTeamModel MapToModel(ICharacterTeam entity)
        {
            var model = EntityMapper.MapToModel<ICharacterTeam, CharacterTeamModel>(entity);
            // CharacterTeam Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.Character = entity.Character?.MapToModel();
            model.TeamId = entity.TeamId;
            model.Team = entity.Team?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public ICharacterTeamModel MapToModelLite(ICharacterTeam entity)
        {
            var model = EntityMapper.MapToModelLite<ICharacterTeam, CharacterTeamModel>(entity);
            // CharacterTeam Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.TeamId = entity.TeamId;
            // Return Entity
            return model;
        }

        public ICharacterTeamModel MapToModelListing(ICharacterTeam entity)
        {
            var model = EntityMapper.MapToModelListing<ICharacterTeam, CharacterTeamModel>(entity);
            // CharacterTeam Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.TeamId = entity.TeamId;
            // Return Entity
            return model;
        }

        public ICharacterTeamSearchModel MapToSearchModel(ICharacterTeamModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ICharacterTeamModel, CharacterTeamSearchModel>(model);
            // Search Properties
            searchModel.CharacterId = model.CharacterId;
            searchModel.CharacterCustomKey = model.Character?.CustomKey;
            searchModel.CharacterName = model.Character?.Name;
            searchModel.CharacterDescription = model.Character?.Description;
            searchModel.TeamId = model.TeamId;
            searchModel.TeamCustomKey = model.Team?.CustomKey;
            searchModel.TeamName = model.Team?.Name;
            searchModel.TeamDescription = model.Team?.Description;
            // Return Search Model
            return searchModel;
        }

        public bool AreEqual(ICharacterTeamModel model, ICharacterTeam entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // CharacterTeam Properties
                // <None>
                // Related Objects
                && model.CharacterId == entity.CharacterId
                && model.TeamId == entity.TeamId
                ;
        }
    }
}
