// <auto-generated>
// <copyright file="Volumes.VolumeRepository.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the VolumesRepository class and a series of
// IQueryable extensions for the search process.</summary>
// <remarks>This file was auto-generated using RepositoryFileMaster.tt in
// ComicVineScraper.API.Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Repositories//.Volumes
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class VolumesRepository : RepositoryBase, IVolumesRepository
    {
        public VolumesRepository(object context) : base(context) { }

        public void Add(IVolume entity)
        {
            Context.Volumes.Add((Volume)entity);
        }

        public void Remove(IVolume entity)
        {
            Context.Volumes.Remove((Volume)entity);
        }

        public void Deactivate(IVolume entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IVolume entity)
        {
            Context.SetModified(entity);
        }

        public IVolume Get(int id)
        {
            return Context.Volumes.FirstOrDefault(r => r.Id == id);
        }

        public IVolume Get(string key)
        {
            return Context.Volumes.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IVolume> List => Context.Volumes;

        public IEnumerable<dynamic> Search(IVolumeSearchModel searchModel, System.Func<IVolume, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IVolume> Search(IVolumeSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IVolume> SearchCommon(IVolumeSearchModel searchModel, bool requireActive)
        {
            return Context.Volumes
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByNameableBaseFilters(searchModel)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class VolumeSearchExtensions
    {
    } // end VolumeSearchExtensions
}
