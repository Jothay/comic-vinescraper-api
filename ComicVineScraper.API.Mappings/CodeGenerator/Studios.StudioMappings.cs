// <auto-generated>
// <copyright file="Studios.IStudioModel.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved. ComicVine Original Api Copyright (c) ComicVine a subsidiary of CBS.
// </copyright>
// <summary>Implements the Mapping Layer functions between Studio and StudioModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in ComicVine.API.Mappings\Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVine.API.Mappings//.Studios
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

    public static class StudioMapperExtensions
    {
        public static IStudioMapper Mapper = new StudioMapper();

        public static void OverrideMapper(IStudioMapper mapper) { Mapper = mapper; }

        public static IStudio MapToEntity(this IStudioModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IStudioModel model, ref IStudio entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IStudioModel MapToModel(this IStudio entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IStudioModel MapToModelLite(this IStudio entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IStudioModel MapToModelListing(this IStudio entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IStudioSearchModel MapToSearchModel(this IStudioModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IStudioModel model, IStudio entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class StudioMapper : IStudioMapper
    {
        public virtual IStudio MapToEntity(IStudioModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = NameableEntityMapper.MapToEntity<Studio, IStudioModel>(model);
            // Studio Properties
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            entity.MovieStudios = model.MovieStudios?.Where(i => i.Active).Select(MovieStudioMapperExtensions.MapToEntity).Cast<MovieStudio>().ToList();
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IStudioModel model, ref IStudio entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            NameableEntityMapper.MapToEntity(model, ref entity);
            // Studio Properties
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            entity.MovieStudios = model.MovieStudios?.Where(i => i.Active).Select(MovieStudioMapperExtensions.MapToEntity).ToList();
        }

        public virtual IStudioModel MapToModel(IStudio entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = NameableEntityMapper.MapToModel<IStudio, StudioModel>(entity);
            // Studio Properties
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            model.MovieStudios = entity.MovieStudios?.Where(i => i.Active).Select(MovieStudioMapperExtensions.MapToModelLite).ToList();
            // Return Entity
            return model;
        }

        public virtual IStudioModel MapToModelLite(IStudio entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = NameableEntityMapper.MapToModelLite<IStudio, StudioModel>(entity);
            // Studio Properties
            // <None>
            // Related Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IStudioModel MapToModelListing(IStudio entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = NameableEntityMapper.MapToModelListing<IStudio, StudioModel>(entity);
            // Studio Properties
            // <None>
            // Related Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IStudioSearchModel MapToSearchModel(IStudioModel model)
        {
            var searchModel = NameableEntityMapper.MapToSearchModel<IStudioModel, StudioSearchModel>(model);
            // Search Properties
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IStudioModel model, IStudio entity)
        {
            return NameableEntityMapper.AreEqual(model, entity)
                // Studio Properties
                // <None>
                // Related Objects
                // <None>
                ;
        }
    }
}