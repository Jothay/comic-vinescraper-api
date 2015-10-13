// <auto-generated>
// <copyright file="StoryArcs.IStoryArcMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between StoryArc and StoryArcModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in
// ComicVineScraper.API.Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVineScraper.API.Mappings//.StoryArcs
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

    public static class StoryArcMapperExtensions
    {
        public static IStoryArcMapper Mapper = new StoryArcMapper();

        public static void OverrideMapper(IStoryArcMapper mapper) { Mapper = mapper; }

        public static IStoryArc MapToEntity(this IStoryArcModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IStoryArcModel model, ref IStoryArc entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IStoryArcModel MapToModel(this IStoryArc entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IStoryArcModel MapToModelLite(this IStoryArc entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IStoryArcModel MapToModelListing(this IStoryArc entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IStoryArcSearchModel MapToSearchModel(this IStoryArcModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IStoryArcModel model, IStoryArc entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class StoryArcMapper : IStoryArcMapper
    {
        public virtual IStoryArc MapToEntity(IStoryArcModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = NameableEntityMapper.MapToEntity<StoryArc, IStoryArcModel>(model);
            // StoryArc Properties
            // <None>
            // Related Objects
            entity.PrimaryImageFileId = model.PrimaryImageFileId;
            entity.PrimaryImageFile = (ImageFile)model.PrimaryImageFile?.MapToEntity();
            entity.FirstIssueAppearanceId = model.FirstIssueAppearanceId;
            entity.FirstIssueAppearance = (Issue)model.FirstIssueAppearance?.MapToEntity();
            entity.PublisherId = model.PublisherId;
            entity.Publisher = (Publisher)model.Publisher?.MapToEntity();
            // Associated Objects
            entity.MovieStoryArcs = model.MovieStoryArcs?.Where(i => i.Active).Select(MovieStoryArcMapperExtensions.MapToEntity).Cast<MovieStoryArc>().ToList();
            entity.StoryArcAliases = model.StoryArcAliases?.Where(i => i.Active).Select(StoryArcAliasMapperExtensions.MapToEntity).Cast<StoryArcAlias>().ToList();
            entity.StoryArcIssues = model.StoryArcIssues?.Where(i => i.Active).Select(StoryArcIssueMapperExtensions.MapToEntity).Cast<StoryArcIssue>().ToList();
            entity.StoryArcsWritten = model.StoryArcsWritten?.Where(i => i.Active).Select(StoryArcWriterMapperExtensions.MapToEntity).Cast<StoryArcWriter>().ToList();
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IStoryArcModel model, ref IStoryArc entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            NameableEntityMapper.MapToEntity(model, ref entity);
            // StoryArc Properties
            // <None>
            // Related Objects
            entity.PrimaryImageFileId = model.PrimaryImageFileId;
            entity.PrimaryImageFile = (ImageFile)model.PrimaryImageFile?.MapToEntity();
            entity.FirstIssueAppearanceId = model.FirstIssueAppearanceId;
            entity.FirstIssueAppearance = (Issue)model.FirstIssueAppearance?.MapToEntity();
            entity.PublisherId = model.PublisherId;
            entity.Publisher = (Publisher)model.Publisher?.MapToEntity();
            // Associated Objects
            entity.MovieStoryArcs = model.MovieStoryArcs?.Where(i => i.Active).Select(MovieStoryArcMapperExtensions.MapToEntity).ToList();
            entity.StoryArcAliases = model.StoryArcAliases?.Where(i => i.Active).Select(StoryArcAliasMapperExtensions.MapToEntity).ToList();
            entity.StoryArcIssues = model.StoryArcIssues?.Where(i => i.Active).Select(StoryArcIssueMapperExtensions.MapToEntity).ToList();
            entity.StoryArcsWritten = model.StoryArcsWritten?.Where(i => i.Active).Select(StoryArcWriterMapperExtensions.MapToEntity).ToList();
        }

        public virtual IStoryArcModel MapToModel(IStoryArc entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = NameableEntityMapper.MapToModel<IStoryArc, StoryArcModel>(entity);
            // StoryArc Properties
            // <None>
            // Related Objects
            model.PrimaryImageFileId = entity.PrimaryImageFileId;
            model.PrimaryImageFile = entity.PrimaryImageFile?.MapToModel();
            model.FirstIssueAppearanceId = entity.FirstIssueAppearanceId;
            model.FirstIssueAppearance = entity.FirstIssueAppearance?.MapToModel();
            model.PublisherId = entity.PublisherId;
            model.Publisher = entity.Publisher?.MapToModel();
            // Associated Objects
            model.MovieStoryArcs = entity.MovieStoryArcs?.Where(i => i.Active).Select(MovieStoryArcMapperExtensions.MapToModelLite).ToList();
            model.StoryArcAliases = entity.StoryArcAliases?.Where(i => i.Active).Select(StoryArcAliasMapperExtensions.MapToModelLite).ToList();
            model.StoryArcIssues = entity.StoryArcIssues?.Where(i => i.Active).Select(StoryArcIssueMapperExtensions.MapToModelLite).ToList();
            model.StoryArcsWritten = entity.StoryArcsWritten?.Where(i => i.Active).Select(StoryArcWriterMapperExtensions.MapToModelLite).ToList();
            // Return Entity
            return model;
        }

        public virtual IStoryArcModel MapToModelLite(IStoryArc entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = NameableEntityMapper.MapToModelLite<IStoryArc, StoryArcModel>(entity);
            // StoryArc Properties
            // <None>
            // Related Objects
            model.PrimaryImageFileId = entity.PrimaryImageFileId;
            model.FirstIssueAppearanceId = entity.FirstIssueAppearanceId;
            model.PublisherId = entity.PublisherId;
            // Return Entity
            return model;
        }

        public virtual IStoryArcModel MapToModelListing(IStoryArc entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = NameableEntityMapper.MapToModelListing<IStoryArc, StoryArcModel>(entity);
            // StoryArc Properties
            // <None>
            // Related Objects
            model.PrimaryImageFileId = entity.PrimaryImageFileId;
            model.FirstIssueAppearanceId = entity.FirstIssueAppearanceId;
            model.PublisherId = entity.PublisherId;
            // Return Entity
            return model;
        }

        public virtual IStoryArcSearchModel MapToSearchModel(IStoryArcModel model)
        {
            var searchModel = NameableEntityMapper.MapToSearchModel<IStoryArcModel, StoryArcSearchModel>(model);
            // Search Properties
            searchModel.PrimaryImageFileId = model.PrimaryImageFileId;
            searchModel.PrimaryImageFileCustomKey = model.PrimaryImageFile?.CustomKey;
            searchModel.PrimaryImageFileApiDetailUrl = model.PrimaryImageFile?.ApiDetailUrl;
            searchModel.PrimaryImageFileSiteDetailUrl = model.PrimaryImageFile?.SiteDetailUrl;
            searchModel.PrimaryImageFileName = model.PrimaryImageFile?.Name;
            searchModel.PrimaryImageFileShortDescription = model.PrimaryImageFile?.ShortDescription;
            searchModel.PrimaryImageFileDescription = model.PrimaryImageFile?.Description;
            searchModel.FirstIssueAppearanceId = model.FirstIssueAppearanceId;
            searchModel.FirstIssueAppearanceCustomKey = model.FirstIssueAppearance?.CustomKey;
            searchModel.FirstIssueAppearanceApiDetailUrl = model.FirstIssueAppearance?.ApiDetailUrl;
            searchModel.FirstIssueAppearanceSiteDetailUrl = model.FirstIssueAppearance?.SiteDetailUrl;
            searchModel.FirstIssueAppearanceName = model.FirstIssueAppearance?.Name;
            searchModel.FirstIssueAppearanceShortDescription = model.FirstIssueAppearance?.ShortDescription;
            searchModel.FirstIssueAppearanceDescription = model.FirstIssueAppearance?.Description;
            searchModel.PublisherId = model.PublisherId;
            searchModel.PublisherCustomKey = model.Publisher?.CustomKey;
            searchModel.PublisherApiDetailUrl = model.Publisher?.ApiDetailUrl;
            searchModel.PublisherSiteDetailUrl = model.Publisher?.SiteDetailUrl;
            searchModel.PublisherName = model.Publisher?.Name;
            searchModel.PublisherShortDescription = model.Publisher?.ShortDescription;
            searchModel.PublisherDescription = model.Publisher?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IStoryArcModel model, IStoryArc entity)
        {
            return NameableEntityMapper.AreEqual(model, entity)
                // StoryArc Properties
                // <None>
                // Related Objects
                && model.PrimaryImageFileId == entity.PrimaryImageFileId
                && model.FirstIssueAppearanceId == entity.FirstIssueAppearanceId
                && model.PublisherId == entity.PublisherId
                ;
        }
    }
}
