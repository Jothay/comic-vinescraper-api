// <auto-generated>
// <copyright file="Concepts.IConceptVolumeRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ConceptVolumesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryFileMaster.tt in ComicVine.API.Repositories\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Repositories//.Concepts
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class ConceptVolumesRepository : RepositoryBase, IConceptVolumesRepository
    {
        public ConceptVolumesRepository(object context) : base(context) { }

        public void Add(IConceptVolume entity)
        {
            Context.ConceptVolumes.Add((ConceptVolume)entity);
        }

        public void Remove(IConceptVolume entity)
        {
            Context.ConceptVolumes.Remove((ConceptVolume)entity);
        }

        public void Deactivate(IConceptVolume entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IConceptVolume entity)
        {
            Context.SetModified(entity);
        }

        public IConceptVolume Get(int id)
        {
            return Context.ConceptVolumes.FirstOrDefault(r => r.Id == id);
        }

        public IConceptVolume Get(string key)
        {
            return Context.ConceptVolumes.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IConceptVolume> List => Context.ConceptVolumes;

        public IEnumerable<dynamic> Search(IConceptVolumeSearchModel searchModel, System.Func<IConceptVolume, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IConceptVolume> Search(IConceptVolumeSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IConceptVolume> SearchCommon(IConceptVolumeSearchModel searchModel, bool requireActive)
        {
            return Context.ConceptVolumes
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class ConceptVolumeSearchExtensions
    {
    } // end ConceptVolumeSearchExtensions
}
