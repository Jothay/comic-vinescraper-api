// <auto-generated>
// <copyright file="Episodes.IEpisodeTeamFirstAppearanceRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeTeamFirstAppearancesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryFileMaster.tt in ComicVine.API.Repositories\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Repositories//.Episodes
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class EpisodeTeamFirstAppearancesRepository : RepositoryBase, IEpisodeTeamFirstAppearancesRepository
    {
        public EpisodeTeamFirstAppearancesRepository(object context) : base(context) { }

        public void Add(IEpisodeTeamFirstAppearance entity)
        {
            Context.EpisodeTeamFirstAppearances.Add((EpisodeTeamFirstAppearance)entity);
        }

        public void Remove(IEpisodeTeamFirstAppearance entity)
        {
            Context.EpisodeTeamFirstAppearances.Remove((EpisodeTeamFirstAppearance)entity);
        }

        public void Deactivate(IEpisodeTeamFirstAppearance entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IEpisodeTeamFirstAppearance entity)
        {
            Context.SetModified(entity);
        }

        public IEpisodeTeamFirstAppearance Get(int id)
        {
            return Context.EpisodeTeamFirstAppearances.FirstOrDefault(r => r.Id == id);
        }

        public IEpisodeTeamFirstAppearance Get(string key)
        {
            return Context.EpisodeTeamFirstAppearances.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IEpisodeTeamFirstAppearance> List => Context.EpisodeTeamFirstAppearances;

        public IEnumerable<dynamic> Search(IEpisodeTeamFirstAppearanceSearchModel searchModel, System.Func<IEpisodeTeamFirstAppearance, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IEpisodeTeamFirstAppearance> Search(IEpisodeTeamFirstAppearanceSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IEpisodeTeamFirstAppearance> SearchCommon(IEpisodeTeamFirstAppearanceSearchModel searchModel, bool requireActive)
        {
            return Context.EpisodeTeamFirstAppearances
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class EpisodeTeamFirstAppearanceSearchExtensions
    {
    } // end EpisodeTeamFirstAppearanceSearchExtensions
}
