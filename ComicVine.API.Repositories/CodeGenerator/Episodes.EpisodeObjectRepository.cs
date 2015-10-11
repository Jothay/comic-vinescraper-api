// <auto-generated>
// <copyright file="Episodes.IEpisodeObjectRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeObjectsRepository Class.</summary>
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

    public class EpisodeObjectsRepository : RepositoryBase, IEpisodeObjectsRepository
    {
        public EpisodeObjectsRepository(object context) : base(context) { }

        public void Add(IEpisodeObject entity)
        {
            Context.EpisodeObjects.Add((EpisodeObject)entity);
        }

        public void Remove(IEpisodeObject entity)
        {
            Context.EpisodeObjects.Remove((EpisodeObject)entity);
        }

        public void Deactivate(IEpisodeObject entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IEpisodeObject entity)
        {
            Context.SetModified(entity);
        }

        public IEpisodeObject Get(int id)
        {
            return Context.EpisodeObjects.FirstOrDefault(r => r.Id == id);
        }

        public IEpisodeObject Get(string key)
        {
            return Context.EpisodeObjects.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IEpisodeObject> List => Context.EpisodeObjects;

        public IEnumerable<dynamic> Search(IEpisodeObjectSearchModel searchModel, System.Func<IEpisodeObject, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IEpisodeObject> Search(IEpisodeObjectSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IEpisodeObject> SearchCommon(IEpisodeObjectSearchModel searchModel, bool requireActive)
        {
            return Context.EpisodeObjects
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class EpisodeObjectSearchExtensions
    {
    } // end EpisodeObjectSearchExtensions
}
