// <auto-generated>
// <copyright file="dbo.IImageFileModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ImageFile model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Mappings//.dbo
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

    public static class ImageFileMapperExtensions
    {
        public static readonly ImageFileMapper Mapper = new ImageFileMapper();

        public static IImageFile MapToEntity(this IImageFileModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IImageFileModel model, ref IImageFile entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IImageFileModel MapToModel(this IImageFile entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IImageFileModel MapToModelLite(this IImageFile entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IImageFileModel MapToModelListing(this IImageFile entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IImageFileSearchModel MapToSearchModel(this IImageFileModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IImageFileModel model, IImageFile entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class ImageFileMapper : IImageFileMapper
    {
        public IImageFile MapToEntity(IImageFileModel model)
        {
            var entity = NameableEntityMapper.MapToEntity<ImageFile, IImageFileModel>(model);
            // ImageFile Properties
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public void MapToEntity(IImageFileModel model, ref IImageFile entity)
        {
            // Assign Base properties
            NameableEntityMapper.MapToEntity(model, ref entity);
            // ImageFile Properties
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            // <None>
        }

        public IImageFileModel MapToModel(IImageFile entity)
        {
            var model = NameableEntityMapper.MapToModel<IImageFile, ImageFileModel>(entity);
            // ImageFile Properties
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public IImageFileModel MapToModelLite(IImageFile entity)
        {
            var model = NameableEntityMapper.MapToModelLite<IImageFile, ImageFileModel>(entity);
            // ImageFile Properties
            // <None>
            // Related Objects
            // <None>
            // Return Entity
            return model;
        }

        public IImageFileModel MapToModelListing(IImageFile entity)
        {
            var model = NameableEntityMapper.MapToModelListing<IImageFile, ImageFileModel>(entity);
            // ImageFile Properties
            // <None>
            // Related Objects
            // <None>
            // Return Entity
            return model;
        }

        public IImageFileSearchModel MapToSearchModel(IImageFileModel model)
        {
            var searchModel = NameableEntityMapper.MapToSearchModel<IImageFileModel, ImageFileSearchModel>(model);
            // Search Properties
            // Return Search Model
            return searchModel;
        }

        public bool AreEqual(IImageFileModel model, IImageFile entity)
        {
            return NameableEntityMapper.AreEqual(model, entity)
                // ImageFile Properties
                // <None>
                // Related Objects
                // <None>
                ;
        }
    }
}
