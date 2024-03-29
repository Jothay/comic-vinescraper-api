// <auto-generated>
// <copyright file="Teams.TeamAliasRepository.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the TeamAliasesRepository class and a series of
// IQueryable extensions for the search process.</summary>
// <remarks>This file was auto-generated using RepositoryFileMaster.tt in
// ComicVineScraper.API.Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Repositories//.Teams
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class TeamAliasesRepository : RepositoryBase, ITeamAliasesRepository
    {
        public TeamAliasesRepository(object context) : base(context) { }

        public void Add(ITeamAlias entity)
        {
            Context.TeamAliases.Add((TeamAlias)entity);
        }

        public void Remove(ITeamAlias entity)
        {
            Context.TeamAliases.Remove((TeamAlias)entity);
        }

        public void Deactivate(ITeamAlias entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(ITeamAlias entity)
        {
            Context.SetModified(entity);
        }

        public ITeamAlias Get(int id)
        {
            return Context.TeamAliases.FirstOrDefault(r => r.Id == id);
        }

        public ITeamAlias Get(string key)
        {
            return Context.TeamAliases.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<ITeamAlias> List => Context.TeamAliases;

        public IEnumerable<dynamic> Search(ITeamAliasSearchModel searchModel, System.Func<ITeamAlias, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<ITeamAlias> Search(ITeamAliasSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<ITeamAlias> SearchCommon(ITeamAliasSearchModel searchModel, bool requireActive)
        {
            return Context.TeamAliases
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByNameableBaseFilters(searchModel)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class TeamAliasSearchExtensions
    {
    } // end TeamAliasSearchExtensions
}
