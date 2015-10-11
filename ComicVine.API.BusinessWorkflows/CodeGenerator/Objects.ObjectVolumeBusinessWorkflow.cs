// <auto-generated>
// <copyright file="Objects.IObjectVolumeModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectVolume model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.BusinessWorkflows//.Objects
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

    public class ObjectVolumesBusinessWorkflow : IObjectVolumesBusinessWorkflow
    {
        public ObjectVolumesBusinessWorkflow(IObjectVolumesRepository objectVolumesRepository, IObjectVolumeMapper objectVolumeMapper)
        {
            ObjectVolumesRepository = objectVolumesRepository;
            ObjectVolumeMapper = objectVolumeMapper;
        }

        #region Private Variables
        private IObjectVolumeMapper ObjectVolumeMapper { get; }
        private IObjectVolumesRepository ObjectVolumesRepository { get; }
        #endregion
        #region Read
        public IObjectVolumeModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return ObjectVolumeMapper.MapToModel(ObjectVolumesRepository.Get(id));
        }

        public IObjectVolumeModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return ObjectVolumeMapper.MapToModel(ObjectVolumesRepository.Get(key));
        }

        public List<IObjectVolumeModel> Search(IObjectVolumeSearchModel searchModel, bool asListing = false)
        {
            var results = ObjectVolumesRepository.Search(searchModel);
            return asListing
                ? results.Select(ObjectVolumeMapper.MapToModelListing).ToList()
                : results.Select(ObjectVolumeMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IObjectVolumeModel Create(IObjectVolumeModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(ObjectVolumeMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = ObjectVolumeMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            ObjectVolumesRepository.Add(newEntity);
            // Try to Save Changes
            ObjectVolumesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IObjectVolumeModel Update(IObjectVolumeModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = ObjectVolumesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (ObjectVolumeMapper.AreEqual(model, existingEntity))
            {
                return ObjectVolumeMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            ObjectVolumeMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            ObjectVolumesRepository.Update(ObjectVolumeMapper.MapToEntity(model));
            // Try to Save Changes
            ObjectVolumesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = ObjectVolumesRepository.Get(id);
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
            var existingEntity = ObjectVolumesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IObjectVolume entity)
        {
            // Deactivate it
            ObjectVolumesRepository.Deactivate(entity);
            // Try to Save Changes
            ObjectVolumesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = ObjectVolumesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = ObjectVolumesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IObjectVolume entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            ObjectVolumesRepository.Remove(entity);
            // Try to Save Changes
            ObjectVolumesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
