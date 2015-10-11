// <auto-generated>
// <copyright file="Teams.ITeamDisbandedInIssueModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamDisbandedInIssue model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.BusinessWorkflows//.Teams
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

    public class TeamDisbandedInIssuesBusinessWorkflow : ITeamDisbandedInIssuesBusinessWorkflow
    {
        public TeamDisbandedInIssuesBusinessWorkflow(ITeamDisbandedInIssuesRepository teamDisbandedInIssuesRepository, ITeamDisbandedInIssueMapper teamDisbandedInIssueMapper)
        {
            TeamDisbandedInIssuesRepository = teamDisbandedInIssuesRepository;
            TeamDisbandedInIssueMapper = teamDisbandedInIssueMapper;
        }

        #region Private Variables
        private ITeamDisbandedInIssueMapper TeamDisbandedInIssueMapper { get; }
        private ITeamDisbandedInIssuesRepository TeamDisbandedInIssuesRepository { get; }
        #endregion
        #region Read
        public ITeamDisbandedInIssueModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return TeamDisbandedInIssueMapper.MapToModel(TeamDisbandedInIssuesRepository.Get(id));
        }

        public ITeamDisbandedInIssueModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return TeamDisbandedInIssueMapper.MapToModel(TeamDisbandedInIssuesRepository.Get(key));
        }

        public List<ITeamDisbandedInIssueModel> Search(ITeamDisbandedInIssueSearchModel searchModel, bool asListing = false)
        {
            var results = TeamDisbandedInIssuesRepository.Search(searchModel);
            return asListing
                ? results.Select(TeamDisbandedInIssueMapper.MapToModelListing).ToList()
                : results.Select(TeamDisbandedInIssueMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public ITeamDisbandedInIssueModel Create(ITeamDisbandedInIssueModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(TeamDisbandedInIssueMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = TeamDisbandedInIssueMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            TeamDisbandedInIssuesRepository.Add(newEntity);
            // Try to Save Changes
            TeamDisbandedInIssuesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public ITeamDisbandedInIssueModel Update(ITeamDisbandedInIssueModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = TeamDisbandedInIssuesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (TeamDisbandedInIssueMapper.AreEqual(model, existingEntity))
            {
                return TeamDisbandedInIssueMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            TeamDisbandedInIssueMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            TeamDisbandedInIssuesRepository.Update(TeamDisbandedInIssueMapper.MapToEntity(model));
            // Try to Save Changes
            TeamDisbandedInIssuesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = TeamDisbandedInIssuesRepository.Get(id);
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
            var existingEntity = TeamDisbandedInIssuesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(ITeamDisbandedInIssue entity)
        {
            // Deactivate it
            TeamDisbandedInIssuesRepository.Deactivate(entity);
            // Try to Save Changes
            TeamDisbandedInIssuesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = TeamDisbandedInIssuesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = TeamDisbandedInIssuesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(ITeamDisbandedInIssue entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            TeamDisbandedInIssuesRepository.Remove(entity);
            // Try to Save Changes
            TeamDisbandedInIssuesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}