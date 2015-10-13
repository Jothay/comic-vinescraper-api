// <auto-generated>
// <copyright file="Series.ISeriesLocationModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the SeriesLocation model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.BusinessWorkflows//.Series
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces.BusinessWorkflows;
    using Interfaces.DataModels;
    using Interfaces.Mappers;
    using Interfaces.Models;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class SeriesLocationsBusinessWorkflow : ISeriesLocationsBusinessWorkflow
    {
        public SeriesLocationsBusinessWorkflow(ISeriesLocationsRepository seriesLocationsRepository, ISeriesLocationMapper seriesLocationMapper)
        {
            SeriesLocationsRepository = seriesLocationsRepository;
            SeriesLocationMapper = seriesLocationMapper;
        }

        #region Private Variables
        private ISeriesLocationMapper SeriesLocationMapper { get; }
        private ISeriesLocationsRepository SeriesLocationsRepository { get; }
        #endregion
        #region Read
        public ISeriesLocationModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return SeriesLocationMapper.MapToModel(SeriesLocationsRepository.Get(id));
        }

        public ISeriesLocationModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return SeriesLocationMapper.MapToModel(SeriesLocationsRepository.Get(key));
        }

        public List<ISeriesLocationModel> Search(ISeriesLocationSearchModel searchModel, bool asListing = false)
        {
            var results = SeriesLocationsRepository.Search(searchModel);
            return asListing
                ? results.Select(SeriesLocationMapper.MapToModelListing).ToList()
                : results.Select(SeriesLocationMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public ISeriesLocationModel Create(ISeriesLocationModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(SeriesLocationMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = SeriesLocationMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            SeriesLocationsRepository.Add(newEntity);
            // Try to Save Changes
            SeriesLocationsRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public ISeriesLocationModel Update(ISeriesLocationModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = SeriesLocationsRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (SeriesLocationMapper.AreEqual(model, existingEntity))
            {
                return SeriesLocationMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            SeriesLocationMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            SeriesLocationsRepository.Update(SeriesLocationMapper.MapToEntity(model));
            // Try to Save Changes
            SeriesLocationsRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = SeriesLocationsRepository.Get(id);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with id {id} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        public bool Deactivate(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = SeriesLocationsRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(ISeriesLocation entity)
        {
            // Deactivate it
            SeriesLocationsRepository.Deactivate(entity);
            // Try to Save Changes
            SeriesLocationsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = SeriesLocationsRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = SeriesLocationsRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(ISeriesLocation entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            SeriesLocationsRepository.Remove(entity);
            // Try to Save Changes
            SeriesLocationsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}