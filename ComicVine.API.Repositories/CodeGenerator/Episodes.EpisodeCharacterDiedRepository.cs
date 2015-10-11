// <auto-generated>
// <copyright file="Episodes.IEpisodeCharacterDiedRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeCharactersDiedRepository Class.</summary>
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

    public class EpisodeCharactersDiedRepository : RepositoryBase, IEpisodeCharactersDiedRepository
    {
        public EpisodeCharactersDiedRepository(object context) : base(context) { }

        public void Add(IEpisodeCharacterDied entity)
        {
            Context.EpisodeCharactersDied.Add((EpisodeCharacterDied)entity);
        }

        public void Remove(IEpisodeCharacterDied entity)
        {
            Context.EpisodeCharactersDied.Remove((EpisodeCharacterDied)entity);
        }

        public void Deactivate(IEpisodeCharacterDied entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IEpisodeCharacterDied entity)
        {
            Context.SetModified(entity);
        }

        public IEpisodeCharacterDied Get(int id)
        {
            return Context.EpisodeCharactersDied.FirstOrDefault(r => r.Id == id);
        }

        public IEpisodeCharacterDied Get(string key)
        {
            return Context.EpisodeCharactersDied.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IEpisodeCharacterDied> List => Context.EpisodeCharactersDied;

        public IEnumerable<dynamic> Search(IEpisodeCharacterDiedSearchModel searchModel, System.Func<IEpisodeCharacterDied, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IEpisodeCharacterDied> Search(IEpisodeCharacterDiedSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IEpisodeCharacterDied> SearchCommon(IEpisodeCharacterDiedSearchModel searchModel, bool requireActive)
        {
            return Context.EpisodeCharactersDied
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class EpisodeCharacterDiedSearchExtensions
    {
    } // end EpisodeCharacterDiedSearchExtensions
}
