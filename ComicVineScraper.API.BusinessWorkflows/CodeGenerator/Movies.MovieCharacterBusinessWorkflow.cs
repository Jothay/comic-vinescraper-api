// <auto-generated>
// <copyright file="Movies.MovieCharacterBusinessWorkflow.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the MovieCharacter business workflows.</summary>
// <remarks>This file was auto-generated using WorkflowFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.BusinessWorkflows//.Movies
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

    public class MovieCharactersBusinessWorkflow : IMovieCharactersBusinessWorkflow
    {
        public MovieCharactersBusinessWorkflow(IMovieCharactersRepository movieCharactersRepository, IMovieCharacterMapper movieCharacterMapper)
        {
            MovieCharactersRepository = movieCharactersRepository;
            MovieCharacterMapper = movieCharacterMapper;
        }

        #region Private Variables
        private IMovieCharacterMapper MovieCharacterMapper { get; }
        private IMovieCharactersRepository MovieCharactersRepository { get; }
        #endregion
        #region Read
        public IMovieCharacterModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return MovieCharacterMapper.MapToModel(MovieCharactersRepository.Get(id));
        }

        public IMovieCharacterModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return MovieCharacterMapper.MapToModel(MovieCharactersRepository.Get(key));
        }

        public List<IMovieCharacterModel> Search(IMovieCharacterSearchModel searchModel, bool asListing = false)
        {
            var results = MovieCharactersRepository.Search(searchModel);
            return asListing
                ? results.Select(MovieCharacterMapper.MapToModelListing).ToList()
                : results.Select(MovieCharacterMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IMovieCharacterModel Create(IMovieCharacterModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(MovieCharacterMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = MovieCharacterMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            MovieCharactersRepository.Add(newEntity);
            // Try to Save Changes
            MovieCharactersRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IMovieCharacterModel Update(IMovieCharacterModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = MovieCharactersRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (MovieCharacterMapper.AreEqual(model, existingEntity))
            {
                return MovieCharacterMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            MovieCharacterMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            MovieCharactersRepository.Update(MovieCharacterMapper.MapToEntity(model));
            // Try to Save Changes
            MovieCharactersRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = MovieCharactersRepository.Get(id);
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
            var existingEntity = MovieCharactersRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IMovieCharacter entity)
        {
            // Deactivate it
            MovieCharactersRepository.Deactivate(entity);
            // Try to Save Changes
            MovieCharactersRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = MovieCharactersRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = MovieCharactersRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IMovieCharacter entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            MovieCharactersRepository.Remove(entity);
            // Try to Save Changes
            MovieCharactersRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
