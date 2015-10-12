// <auto-generated>
// <copyright file="Episodes.IEpisodeConceptFirstAppearanceModel.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved. ComicVine Original Api Copyright (c) ComicVine a subsidiary of CBS.
// </copyright>
// <summary>Implements the Mapping Layer functions between EpisodeConceptFirstAppearance and EpisodeConceptFirstAppearanceModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in ComicVine.API.Mappings\Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVine.API.Mappings//.Episodes
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

    public static class EpisodeConceptFirstAppearanceMapperExtensions
    {
        public static IEpisodeConceptFirstAppearanceMapper Mapper = new EpisodeConceptFirstAppearanceMapper();

        public static void OverrideMapper(IEpisodeConceptFirstAppearanceMapper mapper) { Mapper = mapper; }

        public static IEpisodeConceptFirstAppearance MapToEntity(this IEpisodeConceptFirstAppearanceModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IEpisodeConceptFirstAppearanceModel model, ref IEpisodeConceptFirstAppearance entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IEpisodeConceptFirstAppearanceModel MapToModel(this IEpisodeConceptFirstAppearance entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IEpisodeConceptFirstAppearanceModel MapToModelLite(this IEpisodeConceptFirstAppearance entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IEpisodeConceptFirstAppearanceModel MapToModelListing(this IEpisodeConceptFirstAppearance entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IEpisodeConceptFirstAppearanceSearchModel MapToSearchModel(this IEpisodeConceptFirstAppearanceModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IEpisodeConceptFirstAppearanceModel model, IEpisodeConceptFirstAppearance entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class EpisodeConceptFirstAppearanceMapper : IEpisodeConceptFirstAppearanceMapper
    {
        public virtual IEpisodeConceptFirstAppearance MapToEntity(IEpisodeConceptFirstAppearanceModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<EpisodeConceptFirstAppearance, IEpisodeConceptFirstAppearanceModel>(model);
            // EpisodeConceptFirstAppearance Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.ConceptId = model.ConceptId;
            entity.Concept = (Concept)model.Concept?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IEpisodeConceptFirstAppearanceModel model, ref IEpisodeConceptFirstAppearance entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // EpisodeConceptFirstAppearance Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.ConceptId = model.ConceptId;
            entity.Concept = (Concept)model.Concept?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IEpisodeConceptFirstAppearanceModel MapToModel(IEpisodeConceptFirstAppearance entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<IEpisodeConceptFirstAppearance, EpisodeConceptFirstAppearanceModel>(entity);
            // EpisodeConceptFirstAppearance Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.Episode = entity.Episode?.MapToModel();
            model.ConceptId = entity.ConceptId;
            model.Concept = entity.Concept?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IEpisodeConceptFirstAppearanceModel MapToModelLite(IEpisodeConceptFirstAppearance entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<IEpisodeConceptFirstAppearance, EpisodeConceptFirstAppearanceModel>(entity);
            // EpisodeConceptFirstAppearance Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.ConceptId = entity.ConceptId;
            // Return Entity
            return model;
        }

        public virtual IEpisodeConceptFirstAppearanceModel MapToModelListing(IEpisodeConceptFirstAppearance entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<IEpisodeConceptFirstAppearance, EpisodeConceptFirstAppearanceModel>(entity);
            // EpisodeConceptFirstAppearance Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.ConceptId = entity.ConceptId;
            // Return Entity
            return model;
        }

        public virtual IEpisodeConceptFirstAppearanceSearchModel MapToSearchModel(IEpisodeConceptFirstAppearanceModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IEpisodeConceptFirstAppearanceModel, EpisodeConceptFirstAppearanceSearchModel>(model);
            // Search Properties
            searchModel.EpisodeId = model.EpisodeId;
            searchModel.EpisodeCustomKey = model.Episode?.CustomKey;
            searchModel.EpisodeApiDetailUrl = model.Episode?.ApiDetailUrl;
            searchModel.EpisodeSiteDetailUrl = model.Episode?.SiteDetailUrl;
            searchModel.EpisodeName = model.Episode?.Name;
            searchModel.EpisodeShortDescription = model.Episode?.ShortDescription;
            searchModel.EpisodeDescription = model.Episode?.Description;
            searchModel.ConceptId = model.ConceptId;
            searchModel.ConceptCustomKey = model.Concept?.CustomKey;
            searchModel.ConceptApiDetailUrl = model.Concept?.ApiDetailUrl;
            searchModel.ConceptSiteDetailUrl = model.Concept?.SiteDetailUrl;
            searchModel.ConceptName = model.Concept?.Name;
            searchModel.ConceptShortDescription = model.Concept?.ShortDescription;
            searchModel.ConceptDescription = model.Concept?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IEpisodeConceptFirstAppearanceModel model, IEpisodeConceptFirstAppearance entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // EpisodeConceptFirstAppearance Properties
                // <None>
                // Related Objects
                && model.EpisodeId == entity.EpisodeId
                && model.ConceptId == entity.ConceptId
                ;
        }
    }
}
