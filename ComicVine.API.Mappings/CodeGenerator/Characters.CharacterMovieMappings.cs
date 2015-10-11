// <auto-generated>
// <copyright file="Characters.ICharacterMovieModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterMovie model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Mappings//.Characters
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

    public static class CharacterMovieMapperExtensions
    {
        public static readonly CharacterMovieMapper Mapper = new CharacterMovieMapper();

        public static ICharacterMovie MapToEntity(this ICharacterMovieModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this ICharacterMovieModel model, ref ICharacterMovie entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static ICharacterMovieModel MapToModel(this ICharacterMovie entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static ICharacterMovieModel MapToModelLite(this ICharacterMovie entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static ICharacterMovieModel MapToModelListing(this ICharacterMovie entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static ICharacterMovieSearchModel MapToSearchModel(this ICharacterMovieModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ICharacterMovieModel model, ICharacterMovie entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class CharacterMovieMapper : ICharacterMovieMapper
    {
        public ICharacterMovie MapToEntity(ICharacterMovieModel model)
        {
            var entity = EntityMapper.MapToEntity<CharacterMovie, ICharacterMovieModel>(model);
            // CharacterMovie Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public void MapToEntity(ICharacterMovieModel model, ref ICharacterMovie entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // CharacterMovie Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public ICharacterMovieModel MapToModel(ICharacterMovie entity)
        {
            var model = EntityMapper.MapToModel<ICharacterMovie, CharacterMovieModel>(entity);
            // CharacterMovie Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.Character = entity.Character?.MapToModel();
            model.MovieId = entity.MovieId;
            model.Movie = entity.Movie?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public ICharacterMovieModel MapToModelLite(ICharacterMovie entity)
        {
            var model = EntityMapper.MapToModelLite<ICharacterMovie, CharacterMovieModel>(entity);
            // CharacterMovie Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.MovieId = entity.MovieId;
            // Return Entity
            return model;
        }

        public ICharacterMovieModel MapToModelListing(ICharacterMovie entity)
        {
            var model = EntityMapper.MapToModelListing<ICharacterMovie, CharacterMovieModel>(entity);
            // CharacterMovie Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.MovieId = entity.MovieId;
            // Return Entity
            return model;
        }

        public ICharacterMovieSearchModel MapToSearchModel(ICharacterMovieModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ICharacterMovieModel, CharacterMovieSearchModel>(model);
            // Search Properties
            searchModel.CharacterId = model.CharacterId;
            searchModel.CharacterCustomKey = model.Character?.CustomKey;
            searchModel.CharacterName = model.Character?.Name;
            searchModel.CharacterDescription = model.Character?.Description;
            searchModel.MovieId = model.MovieId;
            searchModel.MovieCustomKey = model.Movie?.CustomKey;
            searchModel.MovieName = model.Movie?.Name;
            searchModel.MovieDescription = model.Movie?.Description;
            // Return Search Model
            return searchModel;
        }

        public bool AreEqual(ICharacterMovieModel model, ICharacterMovie entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // CharacterMovie Properties
                // <None>
                // Related Objects
                && model.CharacterId == entity.CharacterId
                && model.MovieId == entity.MovieId
                ;
        }
    }
}
