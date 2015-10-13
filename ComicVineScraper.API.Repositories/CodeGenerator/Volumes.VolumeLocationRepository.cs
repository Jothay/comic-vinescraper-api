// <auto-generated>
// <copyright file="Volumes.IVolumeLocationRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VolumeLocationsRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryFileMaster.tt in ComicVine.API.Repositories\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Repositories//.Volumes
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class VolumeLocationsRepository : RepositoryBase, IVolumeLocationsRepository
    {
        public VolumeLocationsRepository(object context) : base(context) { }

        public void Add(IVolumeLocation entity)
        {
            Context.VolumeLocations.Add((VolumeLocation)entity);
        }

        public void Remove(IVolumeLocation entity)
        {
            Context.VolumeLocations.Remove((VolumeLocation)entity);
        }

        public void Deactivate(IVolumeLocation entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IVolumeLocation entity)
        {
            Context.SetModified(entity);
        }

        public IVolumeLocation Get(int id)
        {
            return Context.VolumeLocations.FirstOrDefault(r => r.Id == id);
        }

        public IVolumeLocation Get(string key)
        {
            return Context.VolumeLocations.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IVolumeLocation> List => Context.VolumeLocations;

        public IEnumerable<dynamic> Search(IVolumeLocationSearchModel searchModel, System.Func<IVolumeLocation, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IVolumeLocation> Search(IVolumeLocationSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IVolumeLocation> SearchCommon(IVolumeLocationSearchModel searchModel, bool requireActive)
        {
            return Context.VolumeLocations
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class VolumeLocationSearchExtensions
    {
    } // end VolumeLocationSearchExtensions
}