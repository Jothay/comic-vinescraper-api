// <auto-generated>
// <copyright file="Objects.IObjectIssueMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between ObjectIssue and ObjectIssueModel.</summary>
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

    public static class ObjectIssueMapperExtensions
    {
        public static IObjectIssueMapper Mapper = new ObjectIssueMapper();

        public static void OverrideMapper(IObjectIssueMapper mapper) { Mapper = mapper; }

        public static IObjectIssue MapToEntity(this IObjectIssueModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IObjectIssueModel model, ref IObjectIssue entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IObjectIssueModel MapToModel(this IObjectIssue entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IObjectIssueModel MapToModelLite(this IObjectIssue entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IObjectIssueModel MapToModelListing(this IObjectIssue entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IObjectIssueSearchModel MapToSearchModel(this IObjectIssueModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IObjectIssueModel model, IObjectIssue entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class ObjectIssueMapper : IObjectIssueMapper
    {
        public virtual IObjectIssue MapToEntity(IObjectIssueModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<ObjectIssue, IObjectIssueModel>(model);
            // ObjectIssue Properties
            // <None>
            // Related Objects
            entity.ObjectId = model.ObjectId;
            entity.Object = (Object)model.Object?.MapToEntity();
            entity.IssueId = model.IssueId;
            entity.Issue = (Issue)model.Issue?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IObjectIssueModel model, ref IObjectIssue entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // ObjectIssue Properties
            // <None>
            // Related Objects
            entity.ObjectId = model.ObjectId;
            entity.Object = (Object)model.Object?.MapToEntity();
            entity.IssueId = model.IssueId;
            entity.Issue = (Issue)model.Issue?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IObjectIssueModel MapToModel(IObjectIssue entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<IObjectIssue, ObjectIssueModel>(entity);
            // ObjectIssue Properties
            // <None>
            // Related Objects
            model.ObjectId = entity.ObjectId;
            model.Object = entity.Object?.MapToModel();
            model.IssueId = entity.IssueId;
            model.Issue = entity.Issue?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IObjectIssueModel MapToModelLite(IObjectIssue entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<IObjectIssue, ObjectIssueModel>(entity);
            // ObjectIssue Properties
            // <None>
            // Related Objects
            model.ObjectId = entity.ObjectId;
            model.IssueId = entity.IssueId;
            // Return Entity
            return model;
        }

        public virtual IObjectIssueModel MapToModelListing(IObjectIssue entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<IObjectIssue, ObjectIssueModel>(entity);
            // ObjectIssue Properties
            // <None>
            // Related Objects
            model.ObjectId = entity.ObjectId;
            model.IssueId = entity.IssueId;
            // Return Entity
            return model;
        }

        public virtual IObjectIssueSearchModel MapToSearchModel(IObjectIssueModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IObjectIssueModel, ObjectIssueSearchModel>(model);
            // Search Properties
            searchModel.ObjectId = model.ObjectId;
            searchModel.ObjectCustomKey = model.Object?.CustomKey;
            searchModel.ObjectApiDetailUrl = model.Object?.ApiDetailUrl;
            searchModel.ObjectSiteDetailUrl = model.Object?.SiteDetailUrl;
            searchModel.ObjectName = model.Object?.Name;
            searchModel.ObjectShortDescription = model.Object?.ShortDescription;
            searchModel.ObjectDescription = model.Object?.Description;
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

        public virtual bool AreEqual(IObjectIssueModel model, IObjectIssue entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // ObjectIssue Properties
                // <None>
                // Related Objects
                && model.ObjectId == entity.ObjectId
                && model.IssueId == entity.IssueId
                ;
        }
    }
}
