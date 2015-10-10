// <auto-generated>
// <copyright file="dbo.IConceptAliasRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ConceptAliasesRepository Class.</summary>
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

    public class ConceptAliasesRepository : RepositoryBase, IConceptAliasesRepository
    {
        public ConceptAliasesRepository(object context) : base(context) { }

        public void Add(IConceptAlias entity)
        {
            Context.ConceptAliases.Add((ConceptAlias)entity);
        }

        public void Remove(IConceptAlias entity)
        {
            Context.ConceptAliases.Remove((ConceptAlias)entity);
        }

        public void Deactivate(IConceptAlias entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IConceptAlias entity)
        {
            Context.SetModified(entity);
        }

        public IConceptAlias Get(int id)
        {
            return Context.ConceptAliases.FirstOrDefault(r => r.Id == id);
        }

        public IConceptAlias Get(string key)
        {
            return Context.ConceptAliases.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IConceptAlias> List => Context.ConceptAliases;

        public IEnumerable<dynamic> Search(IConceptAliasSearchModel searchModel, System.Func<IConceptAlias, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IConceptAlias> Search(IConceptAliasSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IConceptAlias> SearchCommon(IConceptAliasSearchModel searchModel, bool requireActive)
        {
            return Context.ConceptAliases
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByNameableBaseFilters(searchModel)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class ConceptAliasSearchExtensions
    {
    } // end ConceptAliasSearchExtensions
}
