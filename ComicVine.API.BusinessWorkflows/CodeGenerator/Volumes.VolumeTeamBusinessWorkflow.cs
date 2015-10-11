// <auto-generated>
// <copyright file="Volumes.IVolumeTeamModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VolumeTeam model interfaces.</summary>
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

    public class VolumeTeamsBusinessWorkflow : IVolumeTeamsBusinessWorkflow
    {
        public VolumeTeamsBusinessWorkflow(IVolumeTeamsRepository volumeTeamsRepository, IVolumeTeamMapper volumeTeamMapper)
        {
            VolumeTeamsRepository = volumeTeamsRepository;
            VolumeTeamMapper = volumeTeamMapper;
        }

        #region Private Variables
        private IVolumeTeamMapper VolumeTeamMapper { get; }
        private IVolumeTeamsRepository VolumeTeamsRepository { get; }
        #endregion
        #region Read
        public IVolumeTeamModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return VolumeTeamMapper.MapToModel(VolumeTeamsRepository.Get(id));
        }

        public IVolumeTeamModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return VolumeTeamMapper.MapToModel(VolumeTeamsRepository.Get(key));
        }

        public List<IVolumeTeamModel> Search(IVolumeTeamSearchModel searchModel, bool asListing = false)
        {
            var results = VolumeTeamsRepository.Search(searchModel);
            return asListing
                ? results.Select(VolumeTeamMapper.MapToModelListing).ToList()
                : results.Select(VolumeTeamMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IVolumeTeamModel Create(IVolumeTeamModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(VolumeTeamMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = VolumeTeamMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            VolumeTeamsRepository.Add(newEntity);
            // Try to Save Changes
            VolumeTeamsRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IVolumeTeamModel Update(IVolumeTeamModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = VolumeTeamsRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (VolumeTeamMapper.AreEqual(model, existingEntity))
            {
                return VolumeTeamMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            VolumeTeamMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            VolumeTeamsRepository.Update(VolumeTeamMapper.MapToEntity(model));
            // Try to Save Changes
            VolumeTeamsRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = VolumeTeamsRepository.Get(id);
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
            var existingEntity = VolumeTeamsRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IVolumeTeam entity)
        {
            // Deactivate it
            VolumeTeamsRepository.Deactivate(entity);
            // Try to Save Changes
            VolumeTeamsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = VolumeTeamsRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = VolumeTeamsRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IVolumeTeam entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            VolumeTeamsRepository.Remove(entity);
            // Try to Save Changes
            VolumeTeamsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
