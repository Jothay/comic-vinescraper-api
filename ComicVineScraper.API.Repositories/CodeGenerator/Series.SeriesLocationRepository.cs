// <auto-generated>
// <copyright file="Series.SeriesLocationRepository.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the SeriesLocationsRepository class and a series of
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

    public class SeriesLocationsRepository : RepositoryBase, ISeriesLocationsRepository
    {
        public SeriesLocationsRepository(object context) : base(context) { }

        public void Add(ISeriesLocation entity)
        {
            Context.SeriesLocations.Add((SeriesLocation)entity);
        }

        public void Remove(ISeriesLocation entity)
        {
            Context.SeriesLocations.Remove((SeriesLocation)entity);
        }

        public void Deactivate(ISeriesLocation entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(ISeriesLocation entity)
        {
            Context.SetModified(entity);
        }

        public ISeriesLocation Get(int id)
        {
            return Context.SeriesLocations.FirstOrDefault(r => r.Id == id);
        }

        public ISeriesLocation Get(string key)
        {
            return Context.SeriesLocations.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<ISeriesLocation> List => Context.SeriesLocations;

        public IEnumerable<dynamic> Search(ISeriesLocationSearchModel searchModel, System.Func<ISeriesLocation, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<ISeriesLocation> Search(ISeriesLocationSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<ISeriesLocation> SearchCommon(ISeriesLocationSearchModel searchModel, bool requireActive)
        {
            return Context.SeriesLocations
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class SeriesLocationSearchExtensions
    {
    } // end SeriesLocationSearchExtensions
}
