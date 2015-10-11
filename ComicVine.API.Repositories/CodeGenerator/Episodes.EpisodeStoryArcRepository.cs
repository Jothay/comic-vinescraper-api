// <auto-generated>
// <copyright file="Episodes.IEpisodeStoryArcRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeStoryArcsRepository Class.</summary>
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

    public class EpisodeStoryArcsRepository : RepositoryBase, IEpisodeStoryArcsRepository
    {
        public EpisodeStoryArcsRepository(object context) : base(context) { }

        public void Add(IEpisodeStoryArc entity)
        {
            Context.EpisodeStoryArcs.Add((EpisodeStoryArc)entity);
        }

        public void Remove(IEpisodeStoryArc entity)
        {
            Context.EpisodeStoryArcs.Remove((EpisodeStoryArc)entity);
        }

        public void Deactivate(IEpisodeStoryArc entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IEpisodeStoryArc entity)
        {
            Context.SetModified(entity);
        }

        public IEpisodeStoryArc Get(int id)
        {
            return Context.EpisodeStoryArcs.FirstOrDefault(r => r.Id == id);
        }

        public IEpisodeStoryArc Get(string key)
        {
            return Context.EpisodeStoryArcs.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IEpisodeStoryArc> List => Context.EpisodeStoryArcs;

        public IEnumerable<dynamic> Search(IEpisodeStoryArcSearchModel searchModel, System.Func<IEpisodeStoryArc, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IEpisodeStoryArc> Search(IEpisodeStoryArcSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IEpisodeStoryArc> SearchCommon(IEpisodeStoryArcSearchModel searchModel, bool requireActive)
        {
            return Context.EpisodeStoryArcs
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class EpisodeStoryArcSearchExtensions
    {
    } // end EpisodeStoryArcSearchExtensions
}
