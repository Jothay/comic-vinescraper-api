// <auto-generated>
// <copyright file="StoryArcs.IStoryArcIssueModel.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved. ComicVine Original Api Copyright (c) ComicVine a subsidiary of CBS.
// </copyright>
// <summary>Implements the Mapping Layer functions between StoryArcIssue and StoryArcIssueModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in ComicVine.API.Mappings\Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVine.API.Mappings//.StoryArcs
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

    public static class StoryArcIssueMapperExtensions
    {
        public static IStoryArcIssueMapper Mapper = new StoryArcIssueMapper();

        public static void OverrideMapper(IStoryArcIssueMapper mapper) { Mapper = mapper; }

        public static IStoryArcIssue MapToEntity(this IStoryArcIssueModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IStoryArcIssueModel model, ref IStoryArcIssue entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IStoryArcIssueModel MapToModel(this IStoryArcIssue entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IStoryArcIssueModel MapToModelLite(this IStoryArcIssue entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IStoryArcIssueModel MapToModelListing(this IStoryArcIssue entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IStoryArcIssueSearchModel MapToSearchModel(this IStoryArcIssueModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IStoryArcIssueModel model, IStoryArcIssue entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class StoryArcIssueMapper : IStoryArcIssueMapper
    {
        public virtual IStoryArcIssue MapToEntity(IStoryArcIssueModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<StoryArcIssue, IStoryArcIssueModel>(model);
            // StoryArcIssue Properties
            // <None>
            // Related Objects
            entity.StoryArcId = model.StoryArcId;
            entity.StoryArc = (StoryArc)model.StoryArc?.MapToEntity();
            entity.IssueId = model.IssueId;
            entity.Issue = (Issue)model.Issue?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IStoryArcIssueModel model, ref IStoryArcIssue entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // StoryArcIssue Properties
            // <None>
            // Related Objects
            entity.StoryArcId = model.StoryArcId;
            entity.StoryArc = (StoryArc)model.StoryArc?.MapToEntity();
            entity.IssueId = model.IssueId;
            entity.Issue = (Issue)model.Issue?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IStoryArcIssueModel MapToModel(IStoryArcIssue entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<IStoryArcIssue, StoryArcIssueModel>(entity);
            // StoryArcIssue Properties
            // <None>
            // Related Objects
            model.StoryArcId = entity.StoryArcId;
            model.StoryArc = entity.StoryArc?.MapToModel();
            model.IssueId = entity.IssueId;
            model.Issue = entity.Issue?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IStoryArcIssueModel MapToModelLite(IStoryArcIssue entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<IStoryArcIssue, StoryArcIssueModel>(entity);
            // StoryArcIssue Properties
            // <None>
            // Related Objects
            model.StoryArcId = entity.StoryArcId;
            model.IssueId = entity.IssueId;
            // Return Entity
            return model;
        }

        public virtual IStoryArcIssueModel MapToModelListing(IStoryArcIssue entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<IStoryArcIssue, StoryArcIssueModel>(entity);
            // StoryArcIssue Properties
            // <None>
            // Related Objects
            model.StoryArcId = entity.StoryArcId;
            model.IssueId = entity.IssueId;
            // Return Entity
            return model;
        }

        public virtual IStoryArcIssueSearchModel MapToSearchModel(IStoryArcIssueModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IStoryArcIssueModel, StoryArcIssueSearchModel>(model);
            // Search Properties
            searchModel.StoryArcId = model.StoryArcId;
            searchModel.StoryArcCustomKey = model.StoryArc?.CustomKey;
            searchModel.StoryArcApiDetailUrl = model.StoryArc?.ApiDetailUrl;
            searchModel.StoryArcSiteDetailUrl = model.StoryArc?.SiteDetailUrl;
            searchModel.StoryArcName = model.StoryArc?.Name;
            searchModel.StoryArcShortDescription = model.StoryArc?.ShortDescription;
            searchModel.StoryArcDescription = model.StoryArc?.Description;
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

        public virtual bool AreEqual(IStoryArcIssueModel model, IStoryArcIssue entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // StoryArcIssue Properties
                // <None>
                // Related Objects
                && model.StoryArcId == entity.StoryArcId
                && model.IssueId == entity.IssueId
                ;
        }
    }
}
