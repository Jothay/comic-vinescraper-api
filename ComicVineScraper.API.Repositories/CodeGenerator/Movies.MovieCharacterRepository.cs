// <auto-generated>
// <copyright file="Movies.IMovieCharacterRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieCharactersRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryFileMaster.tt in ComicVine.API.Repositories\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Repositories//.Movies
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class MovieCharactersRepository : RepositoryBase, IMovieCharactersRepository
    {
        public MovieCharactersRepository(object context) : base(context) { }

        public void Add(IMovieCharacter entity)
        {
            Context.MovieCharacters.Add((MovieCharacter)entity);
        }

        public void Remove(IMovieCharacter entity)
        {
            Context.MovieCharacters.Remove((MovieCharacter)entity);
        }

        public void Deactivate(IMovieCharacter entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IMovieCharacter entity)
        {
            Context.SetModified(entity);
        }

        public IMovieCharacter Get(int id)
        {
            return Context.MovieCharacters.FirstOrDefault(r => r.Id == id);
        }

        public IMovieCharacter Get(string key)
        {
            return Context.MovieCharacters.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IMovieCharacter> List => Context.MovieCharacters;

        public IEnumerable<dynamic> Search(IMovieCharacterSearchModel searchModel, System.Func<IMovieCharacter, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IMovieCharacter> Search(IMovieCharacterSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IMovieCharacter> SearchCommon(IMovieCharacterSearchModel searchModel, bool requireActive)
        {
            return Context.MovieCharacters
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class MovieCharacterSearchExtensions
    {
    } // end MovieCharacterSearchExtensions
}