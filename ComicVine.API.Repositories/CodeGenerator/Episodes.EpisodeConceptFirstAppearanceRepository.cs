// <auto-generated>
// <copyright file="Episodes.IEpisodeConceptFirstAppearanceRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeConceptFirstAppearancesRepository Class.</summary>
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

    public class EpisodeConceptFirstAppearancesRepository : RepositoryBase, IEpisodeConceptFirstAppearancesRepository
    {
        public EpisodeConceptFirstAppearancesRepository(object context) : base(context) { }

        public void Add(IEpisodeConceptFirstAppearance entity)
        {
            Context.EpisodeConceptFirstAppearances.Add((EpisodeConceptFirstAppearance)entity);
        }

        public void Remove(IEpisodeConceptFirstAppearance entity)
        {
            Context.EpisodeConceptFirstAppearances.Remove((EpisodeConceptFirstAppearance)entity);
        }

        public void Deactivate(IEpisodeConceptFirstAppearance entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IEpisodeConceptFirstAppearance entity)
        {
            Context.SetModified(entity);
        }

        public IEpisodeConceptFirstAppearance Get(int id)
        {
            return Context.EpisodeConceptFirstAppearances.FirstOrDefault(r => r.Id == id);
        }

        public IEpisodeConceptFirstAppearance Get(string key)
        {
            return Context.EpisodeConceptFirstAppearances.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IEpisodeConceptFirstAppearance> List => Context.EpisodeConceptFirstAppearances;

        public IEnumerable<dynamic> Search(IEpisodeConceptFirstAppearanceSearchModel searchModel, System.Func<IEpisodeConceptFirstAppearance, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IEpisodeConceptFirstAppearance> Search(IEpisodeConceptFirstAppearanceSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IEpisodeConceptFirstAppearance> SearchCommon(IEpisodeConceptFirstAppearanceSearchModel searchModel, bool requireActive)
        {
            return Context.EpisodeConceptFirstAppearances
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class EpisodeConceptFirstAppearanceSearchExtensions
    {
    } // end EpisodeConceptFirstAppearanceSearchExtensions
}