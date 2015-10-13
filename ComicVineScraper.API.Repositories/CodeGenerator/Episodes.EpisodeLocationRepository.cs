// <auto-generated>
// <copyright file="Episodes.EpisodeLocationRepository.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the EpisodeLocationsRepository class and a series of
// IQueryable extensions for the search process.</summary>
// <remarks>This file was auto-generated using RepositoryFileMaster.tt in
// ComicVineScraper.API.Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Repositories//.Episodes
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class EpisodeLocationsRepository : RepositoryBase, IEpisodeLocationsRepository
    {
        public EpisodeLocationsRepository(object context) : base(context) { }

        public void Add(IEpisodeLocation entity)
        {
            Context.EpisodeLocations.Add((EpisodeLocation)entity);
        }

        public void Remove(IEpisodeLocation entity)
        {
            Context.EpisodeLocations.Remove((EpisodeLocation)entity);
        }

        public void Deactivate(IEpisodeLocation entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IEpisodeLocation entity)
        {
            Context.SetModified(entity);
        }

        public IEpisodeLocation Get(int id)
        {
            return Context.EpisodeLocations.FirstOrDefault(r => r.Id == id);
        }

        public IEpisodeLocation Get(string key)
        {
            return Context.EpisodeLocations.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IEpisodeLocation> List => Context.EpisodeLocations;

        public IEnumerable<dynamic> Search(IEpisodeLocationSearchModel searchModel, System.Func<IEpisodeLocation, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IEpisodeLocation> Search(IEpisodeLocationSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IEpisodeLocation> SearchCommon(IEpisodeLocationSearchModel searchModel, bool requireActive)
        {
            return Context.EpisodeLocations
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class EpisodeLocationSearchExtensions
    {
    } // end EpisodeLocationSearchExtensions
}
