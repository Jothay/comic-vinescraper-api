// <auto-generated>
// <copyright file="Objects.IObjectAppearedInIssueMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between ObjectAppearedInIssue and ObjectAppearedInIssueModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in
// ComicVineScraper.API.Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVineScraper.API.Mappings//.Objects
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

    public static class ObjectAppearedInIssueMapperExtensions
    {
        public static IObjectAppearedInIssueMapper Mapper = new ObjectAppearedInIssueMapper();

        public static void OverrideMapper(IObjectAppearedInIssueMapper mapper) { Mapper = mapper; }

        public static IObjectAppearedInIssue MapToEntity(this IObjectAppearedInIssueModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IObjectAppearedInIssueModel model, ref IObjectAppearedInIssue entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IObjectAppearedInIssueModel MapToModel(this IObjectAppearedInIssue entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IObjectAppearedInIssueModel MapToModelLite(this IObjectAppearedInIssue entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IObjectAppearedInIssueModel MapToModelListing(this IObjectAppearedInIssue entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IObjectAppearedInIssueSearchModel MapToSearchModel(this IObjectAppearedInIssueModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IObjectAppearedInIssueModel model, IObjectAppearedInIssue entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class ObjectAppearedInIssueMapper : IObjectAppearedInIssueMapper
    {
        public virtual IObjectAppearedInIssue MapToEntity(IObjectAppearedInIssueModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<ObjectAppearedInIssue, IObjectAppearedInIssueModel>(model);
            // ObjectAppearedInIssue Properties
            // <None>
            // Related Objects
            entity.ObjectId = model.ObjectId;
            entity.Object = (Object)model.Object?.MapToEntity();
            entity.AppearedInIssueId = model.AppearedInIssueId;
            entity.AppearedInIssue = (Issue)model.AppearedInIssue?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IObjectAppearedInIssueModel model, ref IObjectAppearedInIssue entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // ObjectAppearedInIssue Properties
            // <None>
            // Related Objects
            entity.ObjectId = model.ObjectId;
            entity.Object = (Object)model.Object?.MapToEntity();
            entity.AppearedInIssueId = model.AppearedInIssueId;
            entity.AppearedInIssue = (Issue)model.AppearedInIssue?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IObjectAppearedInIssueModel MapToModel(IObjectAppearedInIssue entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<IObjectAppearedInIssue, ObjectAppearedInIssueModel>(entity);
            // ObjectAppearedInIssue Properties
            // <None>
            // Related Objects
            model.ObjectId = entity.ObjectId;
            model.Object = entity.Object?.MapToModel();
            model.AppearedInIssueId = entity.AppearedInIssueId;
            model.AppearedInIssue = entity.AppearedInIssue?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IObjectAppearedInIssueModel MapToModelLite(IObjectAppearedInIssue entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<IObjectAppearedInIssue, ObjectAppearedInIssueModel>(entity);
            // ObjectAppearedInIssue Properties
            // <None>
            // Related Objects
            model.ObjectId = entity.ObjectId;
            model.AppearedInIssueId = entity.AppearedInIssueId;
            // Return Entity
            return model;
        }

        public virtual IObjectAppearedInIssueModel MapToModelListing(IObjectAppearedInIssue entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<IObjectAppearedInIssue, ObjectAppearedInIssueModel>(entity);
            // ObjectAppearedInIssue Properties
            // <None>
            // Related Objects
            model.ObjectId = entity.ObjectId;
            model.AppearedInIssueId = entity.AppearedInIssueId;
            // Return Entity
            return model;
        }

        public virtual IObjectAppearedInIssueSearchModel MapToSearchModel(IObjectAppearedInIssueModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IObjectAppearedInIssueModel, ObjectAppearedInIssueSearchModel>(model);
            // Search Properties
            searchModel.ObjectId = model.ObjectId;
            searchModel.ObjectCustomKey = model.Object?.CustomKey;
            searchModel.ObjectApiDetailUrl = model.Object?.ApiDetailUrl;
            searchModel.ObjectSiteDetailUrl = model.Object?.SiteDetailUrl;
            searchModel.ObjectName = model.Object?.Name;
            searchModel.ObjectShortDescription = model.Object?.ShortDescription;
            searchModel.ObjectDescription = model.Object?.Description;
            searchModel.AppearedInIssueId = model.AppearedInIssueId;
            searchModel.AppearedInIssueCustomKey = model.AppearedInIssue?.CustomKey;
            searchModel.AppearedInIssueApiDetailUrl = model.AppearedInIssue?.ApiDetailUrl;
            searchModel.AppearedInIssueSiteDetailUrl = model.AppearedInIssue?.SiteDetailUrl;
            searchModel.AppearedInIssueName = model.AppearedInIssue?.Name;
            searchModel.AppearedInIssueShortDescription = model.AppearedInIssue?.ShortDescription;
            searchModel.AppearedInIssueDescription = model.AppearedInIssue?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IObjectAppearedInIssueModel model, IObjectAppearedInIssue entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // ObjectAppearedInIssue Properties
                // <None>
                // Related Objects
                && model.ObjectId == entity.ObjectId
                && model.AppearedInIssueId == entity.AppearedInIssueId
                ;
        }
    }
}
