// <auto-generated>
// <copyright file="Characters.ICharacterIssueModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterIssue model interfaces.</summary>
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

    public static class CharacterIssueMapperExtensions
    {
        public static ICharacterIssueMapper Mapper = new CharacterIssueMapper();

        public static void OverrideMapper(ICharacterIssueMapper mapper) { Mapper = mapper; }

        public static ICharacterIssue MapToEntity(this ICharacterIssueModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this ICharacterIssueModel model, ref ICharacterIssue entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static ICharacterIssueModel MapToModel(this ICharacterIssue entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static ICharacterIssueModel MapToModelLite(this ICharacterIssue entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static ICharacterIssueModel MapToModelListing(this ICharacterIssue entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static ICharacterIssueSearchModel MapToSearchModel(this ICharacterIssueModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ICharacterIssueModel model, ICharacterIssue entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class CharacterIssueMapper : ICharacterIssueMapper
    {
        public virtual ICharacterIssue MapToEntity(ICharacterIssueModel model)
        {
            var entity = EntityMapper.MapToEntity<CharacterIssue, ICharacterIssueModel>(model);
            // CharacterIssue Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.IssueId = model.IssueId;
            entity.Issue = (Issue)model.Issue?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(ICharacterIssueModel model, ref ICharacterIssue entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // CharacterIssue Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.IssueId = model.IssueId;
            entity.Issue = (Issue)model.Issue?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual ICharacterIssueModel MapToModel(ICharacterIssue entity)
        {
            var model = EntityMapper.MapToModel<ICharacterIssue, CharacterIssueModel>(entity);
            // CharacterIssue Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.Character = entity.Character?.MapToModel();
            model.IssueId = entity.IssueId;
            model.Issue = entity.Issue?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual ICharacterIssueModel MapToModelLite(ICharacterIssue entity)
        {
            var model = EntityMapper.MapToModelLite<ICharacterIssue, CharacterIssueModel>(entity);
            // CharacterIssue Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.IssueId = entity.IssueId;
            // Return Entity
            return model;
        }

        public virtual ICharacterIssueModel MapToModelListing(ICharacterIssue entity)
        {
            var model = EntityMapper.MapToModelListing<ICharacterIssue, CharacterIssueModel>(entity);
            // CharacterIssue Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.IssueId = entity.IssueId;
            // Return Entity
            return model;
        }

        public virtual ICharacterIssueSearchModel MapToSearchModel(ICharacterIssueModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ICharacterIssueModel, CharacterIssueSearchModel>(model);
            // Search Properties
            searchModel.CharacterId = model.CharacterId;
            searchModel.CharacterCustomKey = model.Character?.CustomKey;
            searchModel.CharacterApiDetailUrl = model.Character?.ApiDetailUrl;
            searchModel.CharacterSiteDetailUrl = model.Character?.SiteDetailUrl;
            searchModel.CharacterName = model.Character?.Name;
            searchModel.CharacterShortDescription = model.Character?.ShortDescription;
            searchModel.CharacterDescription = model.Character?.Description;
            searchModel.IssueId = model.IssueId;
            searchModel.IssueCustomKey = model.Issue?.CustomKey;
            searchModel.IssueApiDetailUrl = model.Issue?.ApiDetailUrl;
            searchModel.IssueSiteDetailUrl = model.Issue?.SiteDetailUrl;
            searchModel.IssueName = model.Issue?.Name;
            searchModel.IssueShortDescription = model.Issue?.ShortDescription;
            searchModel.IssueDescription = model.Issue?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(ICharacterIssueModel model, ICharacterIssue entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // CharacterIssue Properties
                // <None>
                // Related Objects
                && model.CharacterId == entity.CharacterId
                && model.IssueId == entity.IssueId
                ;
        }
    }
}
