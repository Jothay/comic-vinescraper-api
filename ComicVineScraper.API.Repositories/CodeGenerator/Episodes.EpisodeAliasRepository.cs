// <auto-generated>
// <copyright file="Episodes.EpisodeAliasRepository.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the EpisodeAliasesRepository class and a series of
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

    public class EpisodeAliasesRepository : RepositoryBase, IEpisodeAliasesRepository
    {
        public EpisodeAliasesRepository(object context) : base(context) { }

        public void Add(IEpisodeAlias entity)
        {
            Context.EpisodeAliases.Add((EpisodeAlias)entity);
        }

        public void Remove(IEpisodeAlias entity)
        {
            Context.EpisodeAliases.Remove((EpisodeAlias)entity);
        }

        public void Deactivate(IEpisodeAlias entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IEpisodeAlias entity)
        {
            Context.SetModified(entity);
        }

        public IEpisodeAlias Get(int id)
        {
            return Context.EpisodeAliases.FirstOrDefault(r => r.Id == id);
        }

        public IEpisodeAlias Get(string key)
        {
            return Context.EpisodeAliases.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IEpisodeAlias> List => Context.EpisodeAliases;

        public IEnumerable<dynamic> Search(IEpisodeAliasSearchModel searchModel, System.Func<IEpisodeAlias, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IEpisodeAlias> Search(IEpisodeAliasSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IEpisodeAlias> SearchCommon(IEpisodeAliasSearchModel searchModel, bool requireActive)
        {
            return Context.EpisodeAliases
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByNameableBaseFilters(searchModel)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class EpisodeAliasSearchExtensions
    {
    } // end EpisodeAliasSearchExtensions
}
