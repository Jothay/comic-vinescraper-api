// <auto-generated>
// <copyright file="Locations.ILocationMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between Location and LocationModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in
// ComicVineScraper.API.Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVineScraper.API.Mappings//.Locations
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

    public static class LocationMapperExtensions
    {
        public static ILocationMapper Mapper = new LocationMapper();

        public static void OverrideMapper(ILocationMapper mapper) { Mapper = mapper; }

        public static ILocation MapToEntity(this ILocationModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this ILocationModel model, ref ILocation entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static ILocationModel MapToModel(this ILocation entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static ILocationModel MapToModelLite(this ILocation entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static ILocationModel MapToModelListing(this ILocation entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static ILocationSearchModel MapToSearchModel(this ILocationModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ILocationModel model, ILocation entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class LocationMapper : ILocationMapper
    {
        public virtual ILocation MapToEntity(ILocationModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = NameableEntityMapper.MapToEntity<Location, ILocationModel>(model);
            // Location Properties
            entity.StartYear = model.StartYear;
            // Related Objects
            entity.FirstIssueAppearanceId = model.FirstIssueAppearanceId;
            entity.FirstIssueAppearance = (Issue)model.FirstIssueAppearance?.MapToEntity();
            entity.PrimaryImageFileId = model.PrimaryImageFileId;
            entity.PrimaryImageFile = (ImageFile)model.PrimaryImageFile?.MapToEntity();
            // Associated Objects
            entity.LocationAliases = model.LocationAliases?.Where(i => i.Active).Select(LocationAliasMapperExtensions.MapToEntity).Cast<LocationAlias>().ToList();
            entity.LocationAppearedInIssues = model.LocationAppearedInIssues?.Where(i => i.Active).Select(LocationAppearedInIssueMapperExtensions.MapToEntity).Cast<LocationAppearedInIssue>().ToList();
            entity.LocationIssues = model.LocationIssues?.Where(i => i.Active).Select(LocationIssueMapperExtensions.MapToEntity).Cast<LocationIssue>().ToList();
            entity.LocationMovies = model.LocationMovies?.Where(i => i.Active).Select(LocationMovieMapperExtensions.MapToEntity).Cast<LocationMovie>().ToList();
            entity.LocationStoryArcs = model.LocationStoryArcs?.Where(i => i.Active).Select(LocationStoryArcMapperExtensions.MapToEntity).Cast<LocationStoryArc>().ToList();
            entity.LocationVolumes = model.LocationVolumes?.Where(i => i.Active).Select(LocationVolumeMapperExtensions.MapToEntity).Cast<LocationVolume>().ToList();
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(ILocationModel model, ref ILocation entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            NameableEntityMapper.MapToEntity(model, ref entity);
            // Location Properties
            entity.StartYear = model.StartYear;
            // Related Objects
            entity.FirstIssueAppearanceId = model.FirstIssueAppearanceId;
            entity.FirstIssueAppearance = (Issue)model.FirstIssueAppearance?.MapToEntity();
            entity.PrimaryImageFileId = model.PrimaryImageFileId;
            entity.PrimaryImageFile = (ImageFile)model.PrimaryImageFile?.MapToEntity();
            // Associated Objects
            entity.LocationAliases = model.LocationAliases?.Where(i => i.Active).Select(LocationAliasMapperExtensions.MapToEntity).ToList();
            entity.LocationAppearedInIssues = model.LocationAppearedInIssues?.Where(i => i.Active).Select(LocationAppearedInIssueMapperExtensions.MapToEntity).ToList();
            entity.LocationIssues = model.LocationIssues?.Where(i => i.Active).Select(LocationIssueMapperExtensions.MapToEntity).ToList();
            entity.LocationMovies = model.LocationMovies?.Where(i => i.Active).Select(LocationMovieMapperExtensions.MapToEntity).ToList();
            entity.LocationStoryArcs = model.LocationStoryArcs?.Where(i => i.Active).Select(LocationStoryArcMapperExtensions.MapToEntity).ToList();
            entity.LocationVolumes = model.LocationVolumes?.Where(i => i.Active).Select(LocationVolumeMapperExtensions.MapToEntity).ToList();
        }

        public virtual ILocationModel MapToModel(ILocation entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = NameableEntityMapper.MapToModel<ILocation, LocationModel>(entity);
            // Location Properties
            model.StartYear = entity.StartYear;
            // Related Objects
            model.FirstIssueAppearanceId = entity.FirstIssueAppearanceId;
            model.FirstIssueAppearance = entity.FirstIssueAppearance?.MapToModel();
            model.PrimaryImageFileId = entity.PrimaryImageFileId;
            model.PrimaryImageFile = entity.PrimaryImageFile?.MapToModel();
            // Associated Objects
            model.LocationAliases = entity.LocationAliases?.Where(i => i.Active).Select(LocationAliasMapperExtensions.MapToModelLite).ToList();
            model.LocationAppearedInIssues = entity.LocationAppearedInIssues?.Where(i => i.Active).Select(LocationAppearedInIssueMapperExtensions.MapToModelLite).ToList();
            model.LocationIssues = entity.LocationIssues?.Where(i => i.Active).Select(LocationIssueMapperExtensions.MapToModelLite).ToList();
            model.LocationMovies = entity.LocationMovies?.Where(i => i.Active).Select(LocationMovieMapperExtensions.MapToModelLite).ToList();
            model.LocationStoryArcs = entity.LocationStoryArcs?.Where(i => i.Active).Select(LocationStoryArcMapperExtensions.MapToModelLite).ToList();
            model.LocationVolumes = entity.LocationVolumes?.Where(i => i.Active).Select(LocationVolumeMapperExtensions.MapToModelLite).ToList();
            // Return Entity
            return model;
        }

        public virtual ILocationModel MapToModelLite(ILocation entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = NameableEntityMapper.MapToModelLite<ILocation, LocationModel>(entity);
            // Location Properties
            model.StartYear = entity.StartYear;
            // Related Objects
            model.FirstIssueAppearanceId = entity.FirstIssueAppearanceId;
            model.PrimaryImageFileId = entity.PrimaryImageFileId;
            // Return Entity
            return model;
        }

        public virtual ILocationModel MapToModelListing(ILocation entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = NameableEntityMapper.MapToModelListing<ILocation, LocationModel>(entity);
            // Location Properties
            model.StartYear = entity.StartYear;
            // Related Objects
            model.FirstIssueAppearanceId = entity.FirstIssueAppearanceId;
            model.PrimaryImageFileId = entity.PrimaryImageFileId;
            // Return Entity
            return model;
        }

        public virtual ILocationSearchModel MapToSearchModel(ILocationModel model)
        {
            var searchModel = NameableEntityMapper.MapToSearchModel<ILocationModel, LocationSearchModel>(model);
            // Search Properties
            searchModel.FirstIssueAppearanceId = model.FirstIssueAppearanceId;
            searchModel.FirstIssueAppearanceCustomKey = model.FirstIssueAppearance?.CustomKey;
            searchModel.FirstIssueAppearanceApiDetailUrl = model.FirstIssueAppearance?.ApiDetailUrl;
            searchModel.FirstIssueAppearanceSiteDetailUrl = model.FirstIssueAppearance?.SiteDetailUrl;
            searchModel.FirstIssueAppearanceName = model.FirstIssueAppearance?.Name;
            searchModel.FirstIssueAppearanceShortDescription = model.FirstIssueAppearance?.ShortDescription;
            searchModel.FirstIssueAppearanceDescription = model.FirstIssueAppearance?.Description;
            searchModel.PrimaryImageFileId = model.PrimaryImageFileId;
            searchModel.PrimaryImageFileCustomKey = model.PrimaryImageFile?.CustomKey;
            searchModel.PrimaryImageFileApiDetailUrl = model.PrimaryImageFile?.ApiDetailUrl;
            searchModel.PrimaryImageFileSiteDetailUrl = model.PrimaryImageFile?.SiteDetailUrl;
            searchModel.PrimaryImageFileName = model.PrimaryImageFile?.Name;
            searchModel.PrimaryImageFileShortDescription = model.PrimaryImageFile?.ShortDescription;
            searchModel.PrimaryImageFileDescription = model.PrimaryImageFile?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(ILocationModel model, ILocation entity)
        {
            return NameableEntityMapper.AreEqual(model, entity)
                // Location Properties
                && model.StartYear == entity.StartYear
                // Related Objects
                && model.FirstIssueAppearanceId == entity.FirstIssueAppearanceId
                && model.PrimaryImageFileId == entity.PrimaryImageFileId
                ;
        }
    }
}
