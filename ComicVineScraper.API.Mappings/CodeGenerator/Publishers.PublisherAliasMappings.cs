// <auto-generated>
// <copyright file="Publishers.IPublisherAliasMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between PublisherAlias and PublisherAliasModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in
// ComicVineScraper.API.Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVineScraper.API.Mappings//.Publishers
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

    public static class PublisherAliasMapperExtensions
    {
        public static IPublisherAliasMapper Mapper = new PublisherAliasMapper();

        public static void OverrideMapper(IPublisherAliasMapper mapper) { Mapper = mapper; }

        public static IPublisherAlias MapToEntity(this IPublisherAliasModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IPublisherAliasModel model, ref IPublisherAlias entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IPublisherAliasModel MapToModel(this IPublisherAlias entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IPublisherAliasModel MapToModelLite(this IPublisherAlias entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IPublisherAliasModel MapToModelListing(this IPublisherAlias entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IPublisherAliasSearchModel MapToSearchModel(this IPublisherAliasModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IPublisherAliasModel model, IPublisherAlias entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class PublisherAliasMapper : IPublisherAliasMapper
    {
        public virtual IPublisherAlias MapToEntity(IPublisherAliasModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = NameableEntityMapper.MapToEntity<PublisherAlias, IPublisherAliasModel>(model);
            // PublisherAlias Properties
            // <None>
            // Related Objects
            entity.PublisherId = model.PublisherId;
            entity.Publisher = (Publisher)model.Publisher?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IPublisherAliasModel model, ref IPublisherAlias entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            NameableEntityMapper.MapToEntity(model, ref entity);
            // PublisherAlias Properties
            // <None>
            // Related Objects
            entity.PublisherId = model.PublisherId;
            entity.Publisher = (Publisher)model.Publisher?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IPublisherAliasModel MapToModel(IPublisherAlias entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = NameableEntityMapper.MapToModel<IPublisherAlias, PublisherAliasModel>(entity);
            // PublisherAlias Properties
            // <None>
            // Related Objects
            model.PublisherId = entity.PublisherId;
            model.Publisher = entity.Publisher?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IPublisherAliasModel MapToModelLite(IPublisherAlias entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = NameableEntityMapper.MapToModelLite<IPublisherAlias, PublisherAliasModel>(entity);
            // PublisherAlias Properties
            // <None>
            // Related Objects
            model.PublisherId = entity.PublisherId;
            // Return Entity
            return model;
        }

        public virtual IPublisherAliasModel MapToModelListing(IPublisherAlias entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = NameableEntityMapper.MapToModelListing<IPublisherAlias, PublisherAliasModel>(entity);
            // PublisherAlias Properties
            // <None>
            // Related Objects
            model.PublisherId = entity.PublisherId;
            // Return Entity
            return model;
        }

        public virtual IPublisherAliasSearchModel MapToSearchModel(IPublisherAliasModel model)
        {
            var searchModel = NameableEntityMapper.MapToSearchModel<IPublisherAliasModel, PublisherAliasSearchModel>(model);
            // Search Properties
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

        public virtual bool AreEqual(IPublisherAliasModel model, IPublisherAlias entity)
        {
            return NameableEntityMapper.AreEqual(model, entity)
                // PublisherAlias Properties
                // <None>
                // Related Objects
                && model.PublisherId == entity.PublisherId
                ;
        }
    }
}
