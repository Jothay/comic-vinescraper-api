// <auto-generated>
// <copyright file="Movies.IMovieProducerRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieProducersRepository Class.</summary>
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

    public class MovieProducersRepository : RepositoryBase, IMovieProducersRepository
    {
        public MovieProducersRepository(object context) : base(context) { }

        public void Add(IMovieProducer entity)
        {
            Context.MovieProducers.Add((MovieProducer)entity);
        }

        public void Remove(IMovieProducer entity)
        {
            Context.MovieProducers.Remove((MovieProducer)entity);
        }

        public void Deactivate(IMovieProducer entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IMovieProducer entity)
        {
            Context.SetModified(entity);
        }

        public IMovieProducer Get(int id)
        {
            return Context.MovieProducers.FirstOrDefault(r => r.Id == id);
        }

        public IMovieProducer Get(string key)
        {
            return Context.MovieProducers.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IMovieProducer> List => Context.MovieProducers;

        public IEnumerable<dynamic> Search(IMovieProducerSearchModel searchModel, System.Func<IMovieProducer, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IMovieProducer> Search(IMovieProducerSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IMovieProducer> SearchCommon(IMovieProducerSearchModel searchModel, bool requireActive)
        {
            return Context.MovieProducers
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class MovieProducerSearchExtensions
    {
    } // end MovieProducerSearchExtensions
}
