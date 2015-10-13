// <auto-generated>
// <copyright file="Locations.LocationBusinessWorkflow.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the Location business workflows.</summary>
// <remarks>This file was auto-generated using WorkflowFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.BusinessWorkflows//.Locations
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

    public class LocationsBusinessWorkflow : ILocationsBusinessWorkflow
    {
        public LocationsBusinessWorkflow(ILocationsRepository locationsRepository, ILocationMapper locationMapper)
        {
            LocationsRepository = locationsRepository;
            LocationMapper = locationMapper;
        }

        #region Private Variables
        private ILocationMapper LocationMapper { get; }
        private ILocationsRepository LocationsRepository { get; }
        #endregion
        #region Read
        public ILocationModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return LocationMapper.MapToModel(LocationsRepository.Get(id));
        }

        public ILocationModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return LocationMapper.MapToModel(LocationsRepository.Get(key));
        }

        public List<ILocationModel> Search(ILocationSearchModel searchModel, bool asListing = false)
        {
            var results = LocationsRepository.Search(searchModel);
            return asListing
                ? results.Select(LocationMapper.MapToModelListing).ToList()
                : results.Select(LocationMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public ILocationModel Create(ILocationModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(LocationMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = LocationMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            LocationsRepository.Add(newEntity);
            // Try to Save Changes
            LocationsRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public ILocationModel Update(ILocationModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = LocationsRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (LocationMapper.AreEqual(model, existingEntity))
            {
                return LocationMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            LocationMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            LocationsRepository.Update(LocationMapper.MapToEntity(model));
            // Try to Save Changes
            LocationsRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = LocationsRepository.Get(id);
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
            var existingEntity = LocationsRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(ILocation entity)
        {
            // Deactivate it
            LocationsRepository.Deactivate(entity);
            // Try to Save Changes
            LocationsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = LocationsRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = LocationsRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(ILocation entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            LocationsRepository.Remove(entity);
            // Try to Save Changes
            LocationsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
