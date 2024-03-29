// <auto-generated>
// <copyright file="Episodes.EpisodeObjectFirstAppearanceRepository.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the EpisodeObjectFirstAppearancesRepository class and a series of
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

    public class EpisodeObjectFirstAppearancesRepository : RepositoryBase, IEpisodeObjectFirstAppearancesRepository
    {
        public EpisodeObjectFirstAppearancesRepository(object context) : base(context) { }

        public void Add(IEpisodeObjectFirstAppearance entity)
        {
            Context.EpisodeObjectFirstAppearances.Add((EpisodeObjectFirstAppearance)entity);
        }

        public void Remove(IEpisodeObjectFirstAppearance entity)
        {
            Context.EpisodeObjectFirstAppearances.Remove((EpisodeObjectFirstAppearance)entity);
        }

        public void Deactivate(IEpisodeObjectFirstAppearance entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IEpisodeObjectFirstAppearance entity)
        {
            Context.SetModified(entity);
        }

        public IEpisodeObjectFirstAppearance Get(int id)
        {
            return Context.EpisodeObjectFirstAppearances.FirstOrDefault(r => r.Id == id);
        }

        public IEpisodeObjectFirstAppearance Get(string key)
        {
            return Context.EpisodeObjectFirstAppearances.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IEpisodeObjectFirstAppearance> List => Context.EpisodeObjectFirstAppearances;

        public IEnumerable<dynamic> Search(IEpisodeObjectFirstAppearanceSearchModel searchModel, System.Func<IEpisodeObjectFirstAppearance, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IEpisodeObjectFirstAppearance> Search(IEpisodeObjectFirstAppearanceSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IEpisodeObjectFirstAppearance> SearchCommon(IEpisodeObjectFirstAppearanceSearchModel searchModel, bool requireActive)
        {
            return Context.EpisodeObjectFirstAppearances
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class EpisodeObjectFirstAppearanceSearchExtensions
    {
    } // end EpisodeObjectFirstAppearanceSearchExtensions
}
