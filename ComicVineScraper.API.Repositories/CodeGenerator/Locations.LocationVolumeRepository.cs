// <auto-generated>
// <copyright file="Locations.LocationVolumeRepository.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the LocationVolumesRepository class and a series of
// IQueryable extensions for the search process.</summary>
// <remarks>This file was auto-generated using RepositoryFileMaster.tt in
// ComicVineScraper.API.Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Repositories//.Locations
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class LocationVolumesRepository : RepositoryBase, ILocationVolumesRepository
    {
        public LocationVolumesRepository(object context) : base(context) { }

        public void Add(ILocationVolume entity)
        {
            Context.LocationVolumes.Add((LocationVolume)entity);
        }

        public void Remove(ILocationVolume entity)
        {
            Context.LocationVolumes.Remove((LocationVolume)entity);
        }

        public void Deactivate(ILocationVolume entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(ILocationVolume entity)
        {
            Context.SetModified(entity);
        }

        public ILocationVolume Get(int id)
        {
            return Context.LocationVolumes.FirstOrDefault(r => r.Id == id);
        }

        public ILocationVolume Get(string key)
        {
            return Context.LocationVolumes.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<ILocationVolume> List => Context.LocationVolumes;

        public IEnumerable<dynamic> Search(ILocationVolumeSearchModel searchModel, System.Func<ILocationVolume, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<ILocationVolume> Search(ILocationVolumeSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<ILocationVolume> SearchCommon(ILocationVolumeSearchModel searchModel, bool requireActive)
        {
            return Context.LocationVolumes
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class LocationVolumeSearchExtensions
    {
    } // end LocationVolumeSearchExtensions
}
