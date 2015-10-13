// <auto-generated>
// <copyright file="Characters.ICharacterIssueMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between CharacterIssue and CharacterIssueModel.</summary>
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

    public static class CharacterIssueMapperExtensions
    {
        public static ICharacterIssueMapper Mapper = new CharacterIssueMapper();

        public static void OverrideMapper(ICharacterIssueMapper mapper) { Mapper = mapper; }

        public static ICharacterIssue MapToEntity(this ICharacterIssueModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this ICharacterIssueModel model, ref ICharacterIssue entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static ICharacterIssueModel MapToModel(this ICharacterIssue entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static ICharacterIssueModel MapToModelLite(this ICharacterIssue entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static ICharacterIssueModel MapToModelListing(this ICharacterIssue entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
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
        public virtual ICharacterIssue MapToEntity(ICharacterIssueModel model, int currentDepth = 1)
        {
            currentDepth++;
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

        public virtual void MapToEntity(ICharacterIssueModel model, ref ICharacterIssue entity, int currentDepth = 1)
        {
            currentDepth++;
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

        public virtual ICharacterIssueModel MapToModel(ICharacterIssue entity, int currentDepth = 1)
        {
            currentDepth++;
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

        public virtual ICharacterIssueModel MapToModelLite(ICharacterIssue entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<ICharacterIssue, CharacterIssueModel>(entity);
            // CharacterIssue Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.IssueId = entity.IssueId;
            // Return Entity
            return model;
        }

        public virtual ICharacterIssueModel MapToModelListing(ICharacterIssue entity, int currentDepth = 1)
        {
            currentDepth++;
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
