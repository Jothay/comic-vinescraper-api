// <auto-generated>
// <copyright file="Series.SeriesRepository.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the SeriesRepository class and a series of
// IQueryable extensions for the search process.</summary>
// <remarks>This file was auto-generated using RepositoryFileMaster.tt in
// ComicVineScraper.API.Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Repositories//.Series
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class SeriesRepository : RepositoryBase, ISeriesRepository
    {
        public SeriesRepository(object context) : base(context) { }

        public void Add(ISeries entity)
        {
            Context.Series.Add((Series)entity);
        }

        public void Remove(ISeries entity)
        {
            Context.Series.Remove((Series)entity);
        }

        public void Deactivate(ISeries entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(ISeries entity)
        {
            Context.SetModified(entity);
        }

        public ISeries Get(int id)
        {
            return Context.Series.FirstOrDefault(r => r.Id == id);
        }

        public ISeries Get(string key)
        {
            return Context.Series.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<ISeries> List => Context.Series;

        public IEnumerable<dynamic> Search(ISeriesSearchModel searchModel, System.Func<ISeries, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<ISeries> Search(ISeriesSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<ISeries> SearchCommon(ISeriesSearchModel searchModel, bool requireActive)
        {
            return Context.Series
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByNameableBaseFilters(searchModel)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class SeriesSearchExtensions
    {
    } // end SeriesSearchExtensions
}
