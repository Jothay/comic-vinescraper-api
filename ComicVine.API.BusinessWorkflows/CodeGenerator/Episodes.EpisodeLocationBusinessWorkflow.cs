// <auto-generated>
// <copyright file="Episodes.IEpisodeLocationModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeLocation model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.BusinessWorkflows//.Episodes
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

    public class EpisodeLocationsBusinessWorkflow : IEpisodeLocationsBusinessWorkflow
    {
        public EpisodeLocationsBusinessWorkflow(IEpisodeLocationsRepository episodeLocationsRepository, IEpisodeLocationMapper episodeLocationMapper)
        {
            EpisodeLocationsRepository = episodeLocationsRepository;
            EpisodeLocationMapper = episodeLocationMapper;
        }

        #region Private Variables
        private IEpisodeLocationMapper EpisodeLocationMapper { get; }
        private IEpisodeLocationsRepository EpisodeLocationsRepository { get; }
        #endregion
        #region Read
        public IEpisodeLocationModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return EpisodeLocationMapper.MapToModel(EpisodeLocationsRepository.Get(id));
        }

        public IEpisodeLocationModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return EpisodeLocationMapper.MapToModel(EpisodeLocationsRepository.Get(key));
        }

        public List<IEpisodeLocationModel> Search(IEpisodeLocationSearchModel searchModel, bool asListing = false)
        {
            var results = EpisodeLocationsRepository.Search(searchModel);
            return asListing
                ? results.Select(EpisodeLocationMapper.MapToModelListing).ToList()
                : results.Select(EpisodeLocationMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IEpisodeLocationModel Create(IEpisodeLocationModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(EpisodeLocationMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = EpisodeLocationMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            EpisodeLocationsRepository.Add(newEntity);
            // Try to Save Changes
            EpisodeLocationsRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IEpisodeLocationModel Update(IEpisodeLocationModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = EpisodeLocationsRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (EpisodeLocationMapper.AreEqual(model, existingEntity))
            {
                return EpisodeLocationMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            EpisodeLocationMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            EpisodeLocationsRepository.Update(EpisodeLocationMapper.MapToEntity(model));
            // Try to Save Changes
            EpisodeLocationsRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = EpisodeLocationsRepository.Get(id);
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
            var existingEntity = EpisodeLocationsRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IEpisodeLocation entity)
        {
            // Deactivate it
            EpisodeLocationsRepository.Deactivate(entity);
            // Try to Save Changes
            EpisodeLocationsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = EpisodeLocationsRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = EpisodeLocationsRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IEpisodeLocation entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            EpisodeLocationsRepository.Remove(entity);
            // Try to Save Changes
            EpisodeLocationsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}