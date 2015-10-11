// <auto-generated>
// <copyright file="Episodes.IEpisodeModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Episode model interfaces.</summary>
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

    public class EpisodesBusinessWorkflow : IEpisodesBusinessWorkflow
    {
        public EpisodesBusinessWorkflow(IEpisodesRepository episodesRepository, IEpisodeMapper episodeMapper)
        {
            EpisodesRepository = episodesRepository;
            EpisodeMapper = episodeMapper;
        }

        #region Private Variables
        private IEpisodeMapper EpisodeMapper { get; }
        private IEpisodesRepository EpisodesRepository { get; }
        #endregion
        #region Read
        public IEpisodeModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return EpisodeMapper.MapToModel(EpisodesRepository.Get(id));
        }

        public IEpisodeModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return EpisodeMapper.MapToModel(EpisodesRepository.Get(key));
        }

        public List<IEpisodeModel> Search(IEpisodeSearchModel searchModel, bool asListing = false)
        {
            var results = EpisodesRepository.Search(searchModel);
            return asListing
                ? results.Select(EpisodeMapper.MapToModelListing).ToList()
                : results.Select(EpisodeMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IEpisodeModel Create(IEpisodeModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(EpisodeMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = EpisodeMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            EpisodesRepository.Add(newEntity);
            // Try to Save Changes
            EpisodesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IEpisodeModel Update(IEpisodeModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = EpisodesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (EpisodeMapper.AreEqual(model, existingEntity))
            {
                return EpisodeMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            EpisodeMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            EpisodesRepository.Update(EpisodeMapper.MapToEntity(model));
            // Try to Save Changes
            EpisodesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = EpisodesRepository.Get(id);
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
            var existingEntity = EpisodesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IEpisode entity)
        {
            // Deactivate it
            EpisodesRepository.Deactivate(entity);
            // Try to Save Changes
            EpisodesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = EpisodesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = EpisodesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IEpisode entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            EpisodesRepository.Remove(entity);
            // Try to Save Changes
            EpisodesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
