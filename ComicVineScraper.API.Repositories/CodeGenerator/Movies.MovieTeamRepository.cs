// <auto-generated>
// <copyright file="Movies.MovieTeamRepository.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the MovieTeamsRepository class and a series of
// IQueryable extensions for the search process.</summary>
// <remarks>This file was auto-generated using RepositoryFileMaster.tt in
// ComicVineScraper.API.Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Repositories//.Movies
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class MovieTeamsRepository : RepositoryBase, IMovieTeamsRepository
    {
        public MovieTeamsRepository(object context) : base(context) { }

        public void Add(IMovieTeam entity)
        {
            Context.MovieTeams.Add((MovieTeam)entity);
        }

        public void Remove(IMovieTeam entity)
        {
            Context.MovieTeams.Remove((MovieTeam)entity);
        }

        public void Deactivate(IMovieTeam entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IMovieTeam entity)
        {
            Context.SetModified(entity);
        }

        public IMovieTeam Get(int id)
        {
            return Context.MovieTeams.FirstOrDefault(r => r.Id == id);
        }

        public IMovieTeam Get(string key)
        {
            return Context.MovieTeams.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IMovieTeam> List => Context.MovieTeams;

        public IEnumerable<dynamic> Search(IMovieTeamSearchModel searchModel, System.Func<IMovieTeam, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IMovieTeam> Search(IMovieTeamSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IMovieTeam> SearchCommon(IMovieTeamSearchModel searchModel, bool requireActive)
        {
            return Context.MovieTeams
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class MovieTeamSearchExtensions
    {
    } // end MovieTeamSearchExtensions
}
