// <auto-generated>
// <copyright file="Characters.ICharacterIssueRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterIssuesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryFileMaster.tt in ComicVine.API.Repositories\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Repositories//.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class CharacterIssuesRepository : RepositoryBase, ICharacterIssuesRepository
    {
        public CharacterIssuesRepository(object context) : base(context) { }

        public void Add(ICharacterIssue entity)
        {
            Context.CharacterIssues.Add((CharacterIssue)entity);
        }

        public void Remove(ICharacterIssue entity)
        {
            Context.CharacterIssues.Remove((CharacterIssue)entity);
        }

        public void Deactivate(ICharacterIssue entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(ICharacterIssue entity)
        {
            Context.SetModified(entity);
        }

        public ICharacterIssue Get(int id)
        {
            return Context.CharacterIssues.FirstOrDefault(r => r.Id == id);
        }

        public ICharacterIssue Get(string key)
        {
            return Context.CharacterIssues.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<ICharacterIssue> List => Context.CharacterIssues;

        public IEnumerable<dynamic> Search(ICharacterIssueSearchModel searchModel, System.Func<ICharacterIssue, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<ICharacterIssue> Search(ICharacterIssueSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<ICharacterIssue> SearchCommon(ICharacterIssueSearchModel searchModel, bool requireActive)
        {
            return Context.CharacterIssues
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class CharacterIssueSearchExtensions
    {
    } // end CharacterIssueSearchExtensions
}
