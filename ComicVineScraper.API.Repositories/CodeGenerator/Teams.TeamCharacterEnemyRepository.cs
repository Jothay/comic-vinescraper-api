// <auto-generated>
// <copyright file="Teams.TeamCharacterEnemyRepository.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the TeamCharacterEnemiesRepository class and a series of
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

    public class TeamCharacterEnemiesRepository : RepositoryBase, ITeamCharacterEnemiesRepository
    {
        public TeamCharacterEnemiesRepository(object context) : base(context) { }

        public void Add(ITeamCharacterEnemy entity)
        {
            Context.TeamCharacterEnemies.Add((TeamCharacterEnemy)entity);
        }

        public void Remove(ITeamCharacterEnemy entity)
        {
            Context.TeamCharacterEnemies.Remove((TeamCharacterEnemy)entity);
        }

        public void Deactivate(ITeamCharacterEnemy entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(ITeamCharacterEnemy entity)
        {
            Context.SetModified(entity);
        }

        public ITeamCharacterEnemy Get(int id)
        {
            return Context.TeamCharacterEnemies.FirstOrDefault(r => r.Id == id);
        }

        public ITeamCharacterEnemy Get(string key)
        {
            return Context.TeamCharacterEnemies.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<ITeamCharacterEnemy> List => Context.TeamCharacterEnemies;

        public IEnumerable<dynamic> Search(ITeamCharacterEnemySearchModel searchModel, System.Func<ITeamCharacterEnemy, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<ITeamCharacterEnemy> Search(ITeamCharacterEnemySearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<ITeamCharacterEnemy> SearchCommon(ITeamCharacterEnemySearchModel searchModel, bool requireActive)
        {
            return Context.TeamCharacterEnemies
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class TeamCharacterEnemySearchExtensions
    {
    } // end TeamCharacterEnemySearchExtensions
}
