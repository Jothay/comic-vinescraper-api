// <auto-generated>
// <copyright file="Episodes.IEpisodeTeamFirstAppearanceModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeTeamFirstAppearance model interfaces.</summary>
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

    public class EpisodeTeamFirstAppearancesBusinessWorkflow : IEpisodeTeamFirstAppearancesBusinessWorkflow
    {
        public EpisodeTeamFirstAppearancesBusinessWorkflow(IEpisodeTeamFirstAppearancesRepository episodeTeamFirstAppearancesRepository, IEpisodeTeamFirstAppearanceMapper episodeTeamFirstAppearanceMapper)
        {
            EpisodeTeamFirstAppearancesRepository = episodeTeamFirstAppearancesRepository;
            EpisodeTeamFirstAppearanceMapper = episodeTeamFirstAppearanceMapper;
        }

        #region Private Variables
        private IEpisodeTeamFirstAppearanceMapper EpisodeTeamFirstAppearanceMapper { get; }
        private IEpisodeTeamFirstAppearancesRepository EpisodeTeamFirstAppearancesRepository { get; }
        #endregion
        #region Read
        public IEpisodeTeamFirstAppearanceModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return EpisodeTeamFirstAppearanceMapper.MapToModel(EpisodeTeamFirstAppearancesRepository.Get(id));
        }

        public IEpisodeTeamFirstAppearanceModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return EpisodeTeamFirstAppearanceMapper.MapToModel(EpisodeTeamFirstAppearancesRepository.Get(key));
        }

        public List<IEpisodeTeamFirstAppearanceModel> Search(IEpisodeTeamFirstAppearanceSearchModel searchModel, bool asListing = false)
        {
            var results = EpisodeTeamFirstAppearancesRepository.Search(searchModel);
            return asListing
                ? results.Select(EpisodeTeamFirstAppearanceMapper.MapToModelListing).ToList()
                : results.Select(EpisodeTeamFirstAppearanceMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IEpisodeTeamFirstAppearanceModel Create(IEpisodeTeamFirstAppearanceModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(EpisodeTeamFirstAppearanceMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = EpisodeTeamFirstAppearanceMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            EpisodeTeamFirstAppearancesRepository.Add(newEntity);
            // Try to Save Changes
            EpisodeTeamFirstAppearancesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IEpisodeTeamFirstAppearanceModel Update(IEpisodeTeamFirstAppearanceModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = EpisodeTeamFirstAppearancesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (EpisodeTeamFirstAppearanceMapper.AreEqual(model, existingEntity))
            {
                return EpisodeTeamFirstAppearanceMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            EpisodeTeamFirstAppearanceMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            EpisodeTeamFirstAppearancesRepository.Update(EpisodeTeamFirstAppearanceMapper.MapToEntity(model));
            // Try to Save Changes
            EpisodeTeamFirstAppearancesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = EpisodeTeamFirstAppearancesRepository.Get(id);
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
            var existingEntity = EpisodeTeamFirstAppearancesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IEpisodeTeamFirstAppearance entity)
        {
            // Deactivate it
            EpisodeTeamFirstAppearancesRepository.Deactivate(entity);
            // Try to Save Changes
            EpisodeTeamFirstAppearancesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = EpisodeTeamFirstAppearancesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = EpisodeTeamFirstAppearancesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IEpisodeTeamFirstAppearance entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            EpisodeTeamFirstAppearancesRepository.Remove(entity);
            // Try to Save Changes
            EpisodeTeamFirstAppearancesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
