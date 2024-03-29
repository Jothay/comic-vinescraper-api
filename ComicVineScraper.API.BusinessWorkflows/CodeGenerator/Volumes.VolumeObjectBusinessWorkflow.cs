// <auto-generated>
// <copyright file="Volumes.VolumeObjectBusinessWorkflow.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the VolumeObject business workflows.</summary>
// <remarks>This file was auto-generated using WorkflowFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.BusinessWorkflows//.Volumes
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

    public class VolumeObjectsBusinessWorkflow : IVolumeObjectsBusinessWorkflow
    {
        public VolumeObjectsBusinessWorkflow(IVolumeObjectsRepository volumeObjectsRepository, IVolumeObjectMapper volumeObjectMapper)
        {
            VolumeObjectsRepository = volumeObjectsRepository;
            VolumeObjectMapper = volumeObjectMapper;
        }

        #region Private Variables
        private IVolumeObjectMapper VolumeObjectMapper { get; }
        private IVolumeObjectsRepository VolumeObjectsRepository { get; }
        #endregion
        #region Read
        public IVolumeObjectModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return VolumeObjectMapper.MapToModel(VolumeObjectsRepository.Get(id));
        }

        public IVolumeObjectModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return VolumeObjectMapper.MapToModel(VolumeObjectsRepository.Get(key));
        }

        public List<IVolumeObjectModel> Search(IVolumeObjectSearchModel searchModel, bool asListing = false)
        {
            var results = VolumeObjectsRepository.Search(searchModel);
            return asListing
                ? results.Select(VolumeObjectMapper.MapToModelListing).ToList()
                : results.Select(VolumeObjectMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IVolumeObjectModel Create(IVolumeObjectModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(VolumeObjectMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = VolumeObjectMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            VolumeObjectsRepository.Add(newEntity);
            // Try to Save Changes
            VolumeObjectsRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IVolumeObjectModel Update(IVolumeObjectModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = VolumeObjectsRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (VolumeObjectMapper.AreEqual(model, existingEntity))
            {
                return VolumeObjectMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            VolumeObjectMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            VolumeObjectsRepository.Update(VolumeObjectMapper.MapToEntity(model));
            // Try to Save Changes
            VolumeObjectsRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = VolumeObjectsRepository.Get(id);
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
            var existingEntity = VolumeObjectsRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IVolumeObject entity)
        {
            // Deactivate it
            VolumeObjectsRepository.Deactivate(entity);
            // Try to Save Changes
            VolumeObjectsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = VolumeObjectsRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = VolumeObjectsRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IVolumeObject entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            VolumeObjectsRepository.Remove(entity);
            // Try to Save Changes
            VolumeObjectsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
