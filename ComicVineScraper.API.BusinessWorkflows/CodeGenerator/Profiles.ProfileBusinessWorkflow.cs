// <auto-generated>
// <copyright file="Profiles.ProfileBusinessWorkflow.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the Profile business workflows.</summary>
// <remarks>This file was auto-generated using WorkflowFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.BusinessWorkflows//.Profiles
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

    public class ProfilesBusinessWorkflow : IProfilesBusinessWorkflow
    {
        public ProfilesBusinessWorkflow(IProfilesRepository profilesRepository, IProfileMapper profileMapper)
        {
            ProfilesRepository = profilesRepository;
            ProfileMapper = profileMapper;
        }

        #region Private Variables
        private IProfileMapper ProfileMapper { get; }
        private IProfilesRepository ProfilesRepository { get; }
        #endregion
        #region Read
        public IProfileModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return ProfileMapper.MapToModel(ProfilesRepository.Get(id));
        }

        public IProfileModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return ProfileMapper.MapToModel(ProfilesRepository.Get(key));
        }

        public List<IProfileModel> Search(IProfileSearchModel searchModel, bool asListing = false)
        {
            var results = ProfilesRepository.Search(searchModel);
            return asListing
                ? results.Select(ProfileMapper.MapToModelListing).ToList()
                : results.Select(ProfileMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IProfileModel Create(IProfileModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(ProfileMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = ProfileMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            ProfilesRepository.Add(newEntity);
            // Try to Save Changes
            ProfilesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IProfileModel Update(IProfileModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = ProfilesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (ProfileMapper.AreEqual(model, existingEntity))
            {
                return ProfileMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            ProfileMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            ProfilesRepository.Update(ProfileMapper.MapToEntity(model));
            // Try to Save Changes
            ProfilesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = ProfilesRepository.Get(id);
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
            var existingEntity = ProfilesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IProfile entity)
        {
            // Deactivate it
            ProfilesRepository.Deactivate(entity);
            // Try to Save Changes
            ProfilesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = ProfilesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = ProfilesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IProfile entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            ProfilesRepository.Remove(entity);
            // Try to Save Changes
            ProfilesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
