// <auto-generated>
// <copyright file="Characters.ICharacterDiedInIssueModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterDiedInIssue model interfaces.</summary>
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

    public static class CharacterDiedInIssueMapperExtensions
    {
        public static ICharacterDiedInIssueMapper Mapper = new CharacterDiedInIssueMapper();

        public static void OverrideMapper(ICharacterDiedInIssueMapper mapper) { Mapper = mapper; }

        public static ICharacterDiedInIssue MapToEntity(this ICharacterDiedInIssueModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this ICharacterDiedInIssueModel model, ref ICharacterDiedInIssue entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static ICharacterDiedInIssueModel MapToModel(this ICharacterDiedInIssue entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static ICharacterDiedInIssueModel MapToModelLite(this ICharacterDiedInIssue entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static ICharacterDiedInIssueModel MapToModelListing(this ICharacterDiedInIssue entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static ICharacterDiedInIssueSearchModel MapToSearchModel(this ICharacterDiedInIssueModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ICharacterDiedInIssueModel model, ICharacterDiedInIssue entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class CharacterDiedInIssueMapper : ICharacterDiedInIssueMapper
    {
        public virtual ICharacterDiedInIssue MapToEntity(ICharacterDiedInIssueModel model)
        {
            var entity = EntityMapper.MapToEntity<CharacterDiedInIssue, ICharacterDiedInIssueModel>(model);
            // CharacterDiedInIssue Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.DiedInIssueId = model.DiedInIssueId;
            entity.DiedInIssue = (Issue)model.DiedInIssue?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(ICharacterDiedInIssueModel model, ref ICharacterDiedInIssue entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // CharacterDiedInIssue Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.DiedInIssueId = model.DiedInIssueId;
            entity.DiedInIssue = (Issue)model.DiedInIssue?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual ICharacterDiedInIssueModel MapToModel(ICharacterDiedInIssue entity)
        {
            var model = EntityMapper.MapToModel<ICharacterDiedInIssue, CharacterDiedInIssueModel>(entity);
            // CharacterDiedInIssue Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.Character = entity.Character?.MapToModel();
            model.DiedInIssueId = entity.DiedInIssueId;
            model.DiedInIssue = entity.DiedInIssue?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual ICharacterDiedInIssueModel MapToModelLite(ICharacterDiedInIssue entity)
        {
            var model = EntityMapper.MapToModelLite<ICharacterDiedInIssue, CharacterDiedInIssueModel>(entity);
            // CharacterDiedInIssue Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.DiedInIssueId = entity.DiedInIssueId;
            // Return Entity
            return model;
        }

        public virtual ICharacterDiedInIssueModel MapToModelListing(ICharacterDiedInIssue entity)
        {
            var model = EntityMapper.MapToModelListing<ICharacterDiedInIssue, CharacterDiedInIssueModel>(entity);
            // CharacterDiedInIssue Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.DiedInIssueId = entity.DiedInIssueId;
            // Return Entity
            return model;
        }

        public virtual ICharacterDiedInIssueSearchModel MapToSearchModel(ICharacterDiedInIssueModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ICharacterDiedInIssueModel, CharacterDiedInIssueSearchModel>(model);
            // Search Properties
            searchModel.CharacterId = model.CharacterId;
            searchModel.CharacterCustomKey = model.Character?.CustomKey;
            searchModel.CharacterApiDetailUrl = model.Character?.ApiDetailUrl;
            searchModel.CharacterSiteDetailUrl = model.Character?.SiteDetailUrl;
            searchModel.CharacterName = model.Character?.Name;
            searchModel.CharacterShortDescription = model.Character?.ShortDescription;
            searchModel.CharacterDescription = model.Character?.Description;
            searchModel.DiedInIssueId = model.DiedInIssueId;
            searchModel.DiedInIssueCustomKey = model.DiedInIssue?.CustomKey;
            searchModel.DiedInIssueApiDetailUrl = model.DiedInIssue?.ApiDetailUrl;
            searchModel.DiedInIssueSiteDetailUrl = model.DiedInIssue?.SiteDetailUrl;
            searchModel.DiedInIssueName = model.DiedInIssue?.Name;
            searchModel.DiedInIssueShortDescription = model.DiedInIssue?.ShortDescription;
            searchModel.DiedInIssueDescription = model.DiedInIssue?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(ICharacterDiedInIssueModel model, ICharacterDiedInIssue entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // CharacterDiedInIssue Properties
                // <None>
                // Related Objects
                && model.CharacterId == entity.CharacterId
                && model.DiedInIssueId == entity.DiedInIssueId
                ;
        }
    }
}
