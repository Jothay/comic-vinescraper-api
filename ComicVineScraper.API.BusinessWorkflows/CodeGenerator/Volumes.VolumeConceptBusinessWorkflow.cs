// <auto-generated>
// <copyright file="Volumes.IVolumeConceptModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VolumeConcept model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.BusinessWorkflows//.Volumes
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

    public class VolumeConceptsBusinessWorkflow : IVolumeConceptsBusinessWorkflow
    {
        public VolumeConceptsBusinessWorkflow(IVolumeConceptsRepository volumeConceptsRepository, IVolumeConceptMapper volumeConceptMapper)
        {
            VolumeConceptsRepository = volumeConceptsRepository;
            VolumeConceptMapper = volumeConceptMapper;
        }

        #region Private Variables
        private IVolumeConceptMapper VolumeConceptMapper { get; }
        private IVolumeConceptsRepository VolumeConceptsRepository { get; }
        #endregion
        #region Read
        public IVolumeConceptModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return VolumeConceptMapper.MapToModel(VolumeConceptsRepository.Get(id));
        }

        public IVolumeConceptModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return VolumeConceptMapper.MapToModel(VolumeConceptsRepository.Get(key));
        }

        public List<IVolumeConceptModel> Search(IVolumeConceptSearchModel searchModel, bool asListing = false)
        {
            var results = VolumeConceptsRepository.Search(searchModel);
            return asListing
                ? results.Select(VolumeConceptMapper.MapToModelListing).ToList()
                : results.Select(VolumeConceptMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IVolumeConceptModel Create(IVolumeConceptModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(VolumeConceptMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = VolumeConceptMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            VolumeConceptsRepository.Add(newEntity);
            // Try to Save Changes
            VolumeConceptsRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IVolumeConceptModel Update(IVolumeConceptModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = VolumeConceptsRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (VolumeConceptMapper.AreEqual(model, existingEntity))
            {
                return VolumeConceptMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            VolumeConceptMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            VolumeConceptsRepository.Update(VolumeConceptMapper.MapToEntity(model));
            // Try to Save Changes
            VolumeConceptsRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = VolumeConceptsRepository.Get(id);
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
            var existingEntity = VolumeConceptsRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IVolumeConcept entity)
        {
            // Deactivate it
            VolumeConceptsRepository.Deactivate(entity);
            // Try to Save Changes
            VolumeConceptsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = VolumeConceptsRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = VolumeConceptsRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IVolumeConcept entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            VolumeConceptsRepository.Remove(entity);
            // Try to Save Changes
            VolumeConceptsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}