// <auto-generated>
// <copyright file="dbo.ICharacterRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharactersRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryFileMaster.tt in ComicVine.API.Repositories\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Repositories//.dbo
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class CharactersRepository : RepositoryBase, ICharactersRepository
    {
        public CharactersRepository(object context) : base(context) { }

        public void Add(ICharacter entity)
        {
            Context.Characters.Add((Character)entity);
        }

        public void Remove(ICharacter entity)
        {
            Context.Characters.Remove((Character)entity);
        }

        public void Deactivate(ICharacter entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(ICharacter entity)
        {
            Context.SetModified(entity);
        }

        public ICharacter Get(int id)
        {
            return Context.Characters.FirstOrDefault(r => r.Id == id);
        }

        public ICharacter Get(string key)
        {
            return Context.Characters.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<ICharacter> List => Context.Characters;

        public IEnumerable<dynamic> Search(ICharacterSearchModel searchModel, System.Func<ICharacter, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<ICharacter> Search(ICharacterSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<ICharacter> SearchCommon(ICharacterSearchModel searchModel, bool requireActive)
        {
            return Context.Characters
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByNameableBaseFilters(searchModel)
                .FilterByRealName(searchModel.RealName)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class CharacterSearchExtensions
    {
        public static IQueryable<Character> FilterByRealName(this IQueryable<Character> query, string realname)
        {
            if (string.IsNullOrWhiteSpace(realname)) { return query; }
            var search = realname.ToLower();
            return query.Where(i => i.RealName.ToLower().Contains(search));
        }

    } // end CharacterSearchExtensions
}