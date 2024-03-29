// <auto-generated>
// <copyright file="Teams.TeamMovieBusinessWorkflow.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the TeamMovie business workflows.</summary>
// <remarks>This file was auto-generated using WorkflowFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.BusinessWorkflows//.Teams
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

    public class TeamMoviesBusinessWorkflow : ITeamMoviesBusinessWorkflow
    {
        public TeamMoviesBusinessWorkflow(ITeamMoviesRepository teamMoviesRepository, ITeamMovieMapper teamMovieMapper)
        {
            TeamMoviesRepository = teamMoviesRepository;
            TeamMovieMapper = teamMovieMapper;
        }

        #region Private Variables
        private ITeamMovieMapper TeamMovieMapper { get; }
        private ITeamMoviesRepository TeamMoviesRepository { get; }
        #endregion
        #region Read
        public ITeamMovieModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return TeamMovieMapper.MapToModel(TeamMoviesRepository.Get(id));
        }

        public ITeamMovieModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return TeamMovieMapper.MapToModel(TeamMoviesRepository.Get(key));
        }

        public List<ITeamMovieModel> Search(ITeamMovieSearchModel searchModel, bool asListing = false)
        {
            var results = TeamMoviesRepository.Search(searchModel);
            return asListing
                ? results.Select(TeamMovieMapper.MapToModelListing).ToList()
                : results.Select(TeamMovieMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public ITeamMovieModel Create(ITeamMovieModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(TeamMovieMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = TeamMovieMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            TeamMoviesRepository.Add(newEntity);
            // Try to Save Changes
            TeamMoviesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public ITeamMovieModel Update(ITeamMovieModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = TeamMoviesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (TeamMovieMapper.AreEqual(model, existingEntity))
            {
                return TeamMovieMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            TeamMovieMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            TeamMoviesRepository.Update(TeamMovieMapper.MapToEntity(model));
            // Try to Save Changes
            TeamMoviesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = TeamMoviesRepository.Get(id);
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
            var existingEntity = TeamMoviesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(ITeamMovie entity)
        {
            // Deactivate it
            TeamMoviesRepository.Deactivate(entity);
            // Try to Save Changes
            TeamMoviesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = TeamMoviesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = TeamMoviesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(ITeamMovie entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            TeamMoviesRepository.Remove(entity);
            // Try to Save Changes
            TeamMoviesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
