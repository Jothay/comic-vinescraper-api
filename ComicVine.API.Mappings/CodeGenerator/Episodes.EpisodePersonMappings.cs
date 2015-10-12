// <auto-generated>
// <copyright file="Episodes.IEpisodePersonModel.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved. ComicVine Original Api Copyright (c) ComicVine a subsidiary of CBS.
// </copyright>
// <summary>Implements the Mapping Layer functions between EpisodePerson and EpisodePersonModel.</summary>
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

    public static class EpisodePersonMapperExtensions
    {
        public static IEpisodePersonMapper Mapper = new EpisodePersonMapper();

        public static void OverrideMapper(IEpisodePersonMapper mapper) { Mapper = mapper; }

        public static IEpisodePerson MapToEntity(this IEpisodePersonModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IEpisodePersonModel model, ref IEpisodePerson entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IEpisodePersonModel MapToModel(this IEpisodePerson entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IEpisodePersonModel MapToModelLite(this IEpisodePerson entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IEpisodePersonModel MapToModelListing(this IEpisodePerson entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IEpisodePersonSearchModel MapToSearchModel(this IEpisodePersonModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IEpisodePersonModel model, IEpisodePerson entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class EpisodePersonMapper : IEpisodePersonMapper
    {
        public virtual IEpisodePerson MapToEntity(IEpisodePersonModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<EpisodePerson, IEpisodePersonModel>(model);
            // EpisodePerson Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.PersonId = model.PersonId;
            entity.Person = (Person)model.Person?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IEpisodePersonModel model, ref IEpisodePerson entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // EpisodePerson Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.PersonId = model.PersonId;
            entity.Person = (Person)model.Person?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IEpisodePersonModel MapToModel(IEpisodePerson entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<IEpisodePerson, EpisodePersonModel>(entity);
            // EpisodePerson Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.Episode = entity.Episode?.MapToModel();
            model.PersonId = entity.PersonId;
            model.Person = entity.Person?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IEpisodePersonModel MapToModelLite(IEpisodePerson entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<IEpisodePerson, EpisodePersonModel>(entity);
            // EpisodePerson Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.PersonId = entity.PersonId;
            // Return Entity
            return model;
        }

        public virtual IEpisodePersonModel MapToModelListing(IEpisodePerson entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<IEpisodePerson, EpisodePersonModel>(entity);
            // EpisodePerson Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.PersonId = entity.PersonId;
            // Return Entity
            return model;
        }

        public virtual IEpisodePersonSearchModel MapToSearchModel(IEpisodePersonModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IEpisodePersonModel, EpisodePersonSearchModel>(model);
            // Search Properties
            searchModel.EpisodeId = model.EpisodeId;
            searchModel.EpisodeCustomKey = model.Episode?.CustomKey;
            searchModel.EpisodeApiDetailUrl = model.Episode?.ApiDetailUrl;
            searchModel.EpisodeSiteDetailUrl = model.Episode?.SiteDetailUrl;
            searchModel.EpisodeName = model.Episode?.Name;
            searchModel.EpisodeShortDescription = model.Episode?.ShortDescription;
            searchModel.EpisodeDescription = model.Episode?.Description;
            searchModel.PersonId = model.PersonId;
            searchModel.PersonCustomKey = model.Person?.CustomKey;
            searchModel.PersonApiDetailUrl = model.Person?.ApiDetailUrl;
            searchModel.PersonSiteDetailUrl = model.Person?.SiteDetailUrl;
            searchModel.PersonName = model.Person?.Name;
            searchModel.PersonShortDescription = model.Person?.ShortDescription;
            searchModel.PersonDescription = model.Person?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IEpisodePersonModel model, IEpisodePerson entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // EpisodePerson Properties
                // <None>
                // Related Objects
                && model.EpisodeId == entity.EpisodeId
                && model.PersonId == entity.PersonId
                ;
        }
    }
}
