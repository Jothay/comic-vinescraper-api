// <auto-generated>
// <copyright file="Characters.CharacterMovieBusinessWorkflow.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the CharacterMovie business workflows.</summary>
// <remarks>This file was auto-generated using WorkflowFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.BusinessWorkflows//.Characters
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

    public class CharacterMoviesBusinessWorkflow : ICharacterMoviesBusinessWorkflow
    {
        public CharacterMoviesBusinessWorkflow(ICharacterMoviesRepository characterMoviesRepository, ICharacterMovieMapper characterMovieMapper)
        {
            CharacterMoviesRepository = characterMoviesRepository;
            CharacterMovieMapper = characterMovieMapper;
        }

        #region Private Variables
        private ICharacterMovieMapper CharacterMovieMapper { get; }
        private ICharacterMoviesRepository CharacterMoviesRepository { get; }
        #endregion
        #region Read
        public ICharacterMovieModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return CharacterMovieMapper.MapToModel(CharacterMoviesRepository.Get(id));
        }

        public ICharacterMovieModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return CharacterMovieMapper.MapToModel(CharacterMoviesRepository.Get(key));
        }

        public List<ICharacterMovieModel> Search(ICharacterMovieSearchModel searchModel, bool asListing = false)
        {
            var results = CharacterMoviesRepository.Search(searchModel);
            return asListing
                ? results.Select(CharacterMovieMapper.MapToModelListing).ToList()
                : results.Select(CharacterMovieMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public ICharacterMovieModel Create(ICharacterMovieModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(CharacterMovieMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = CharacterMovieMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            CharacterMoviesRepository.Add(newEntity);
            // Try to Save Changes
            CharacterMoviesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public ICharacterMovieModel Update(ICharacterMovieModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = CharacterMoviesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (CharacterMovieMapper.AreEqual(model, existingEntity))
            {
                return CharacterMovieMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            CharacterMovieMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            CharacterMoviesRepository.Update(CharacterMovieMapper.MapToEntity(model));
            // Try to Save Changes
            CharacterMoviesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = CharacterMoviesRepository.Get(id);
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
            var existingEntity = CharacterMoviesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(ICharacterMovie entity)
        {
            // Deactivate it
            CharacterMoviesRepository.Deactivate(entity);
            // Try to Save Changes
            CharacterMoviesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = CharacterMoviesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = CharacterMoviesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(ICharacterMovie entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            CharacterMoviesRepository.Remove(entity);
            // Try to Save Changes
            CharacterMoviesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
