// <auto-generated>
// <copyright file="dbo.IConceptModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Concept model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Mappings//.dbo
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Mappers;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Models;
    using SearchModels;

    public static class ConceptMapperExtensions
    {
        public static readonly ConceptMapper Mapper = new ConceptMapper();

        public static IConcept MapToEntity(this IConceptModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IConceptModel model, ref IConcept entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IConceptModel MapToModel(this IConcept entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IConceptModel MapToModelLite(this IConcept entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IConceptModel MapToModelListing(this IConcept entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IConceptSearchModel MapToSearchModel(this IConceptModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IConceptModel model, IConcept entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class ConceptMapper : IConceptMapper
    {
        public IConcept MapToEntity(IConceptModel model)
        {
            var entity = NameableEntityMapper.MapToEntity<Concept, IConceptModel>(model);
            // Concept Properties
            entity.StartYear = model.StartYear;
            // Related Objects
            entity.PrimaryImageId = model.PrimaryImageId;
            entity.PrimaryImage = (ImageFile)model.PrimaryImage.MapToEntity();
            entity.FirstIssueAppearanceId = model.FirstIssueAppearanceId;
            entity.FirstIssueAppearance = (Issue)model.FirstIssueAppearance.MapToEntity();
            // Associated Objects
            entity.ConceptAliases = model.ConceptAliases?.Where(i => i.Active).Select(ConceptAliasMapperExtensions.MapToEntity).Cast<ConceptAlias>().ToList();
            entity.IssueAppearances = model.IssueAppearances?.Where(i => i.Active).Select(IssueMapperExtensions.MapToEntity).Cast<Issue>().ToList();
            entity.IssueCredits = model.IssueCredits?.Where(i => i.Active).Select(IssueMapperExtensions.MapToEntity).Cast<Issue>().ToList();
            entity.Movies = model.Movies?.Where(i => i.Active).Select(MovieMapperExtensions.MapToEntity).Cast<Movie>().ToList();
            entity.VolumeCredits = model.VolumeCredits?.Where(i => i.Active).Select(VolumeMapperExtensions.MapToEntity).Cast<Volume>().ToList();
            // Return Entity
            return entity;
        }

        public void MapToEntity(IConceptModel model, ref IConcept entity)
        {
            // Assign Base properties
            NameableEntityMapper.MapToEntity(model, ref entity);
            // Concept Properties
            entity.StartYear = model.StartYear;
            // Related Objects
            entity.PrimaryImageId = model.PrimaryImageId;
            entity.PrimaryImage = (ImageFile)model.PrimaryImage.MapToEntity();
            entity.FirstIssueAppearanceId = model.FirstIssueAppearanceId;
            entity.FirstIssueAppearance = (Issue)model.FirstIssueAppearance.MapToEntity();
            // Associated Objects
            entity.ConceptAliases = (ICollection<IConceptAlias>)model.ConceptAliases?.Where(i => i.Active).Select(ConceptAliasMapperExtensions.MapToEntity).Cast<ConceptAlias>();
            entity.IssueAppearances = (ICollection<IIssue>)model.IssueAppearances?.Where(i => i.Active).Select(IssueMapperExtensions.MapToEntity).Cast<Issue>();
            entity.IssueCredits = (ICollection<IIssue>)model.IssueCredits?.Where(i => i.Active).Select(IssueMapperExtensions.MapToEntity).Cast<Issue>();
            entity.Movies = (ICollection<IMovie>)model.Movies?.Where(i => i.Active).Select(MovieMapperExtensions.MapToEntity).Cast<Movie>();
            entity.VolumeCredits = (ICollection<IVolume>)model.VolumeCredits?.Where(i => i.Active).Select(VolumeMapperExtensions.MapToEntity).Cast<Volume>();
        }

        public IConceptModel MapToModel(IConcept entity)
        {
            var model = NameableEntityMapper.MapToModel<IConcept, ConceptModel>(entity);
            // Concept Properties
            model.StartYear = entity.StartYear;
            // Related Objects
            model.PrimaryImageId = entity.PrimaryImageId;
            model.PrimaryImage = entity.PrimaryImage.MapToModel();
            model.FirstIssueAppearanceId = entity.FirstIssueAppearanceId;
            model.FirstIssueAppearance = entity.FirstIssueAppearance.MapToModel();
            // Associated Objects
            model.ConceptAliases = entity.ConceptAliases?.Where(i => i.Active).Select(ConceptAliasMapperExtensions.MapToModel).ToList();
            model.IssueAppearances = entity.IssueAppearances?.Where(i => i.Active).Select(IssueMapperExtensions.MapToModel).ToList();
            model.IssueCredits = entity.IssueCredits?.Where(i => i.Active).Select(IssueMapperExtensions.MapToModel).ToList();
            model.Movies = entity.Movies?.Where(i => i.Active).Select(MovieMapperExtensions.MapToModel).ToList();
            model.VolumeCredits = entity.VolumeCredits?.Where(i => i.Active).Select(VolumeMapperExtensions.MapToModel).ToList();
            // Return Entity
            return model;
        }

        public IConceptModel MapToModelLite(IConcept entity)
        {
            var model = NameableEntityMapper.MapToModelLite<IConcept, ConceptModel>(entity);
            // Concept Properties
            model.StartYear = entity.StartYear;
            // Related Objects
            model.PrimaryImageId = entity.PrimaryImageId;
            model.FirstIssueAppearanceId = entity.FirstIssueAppearanceId;
            // Return Entity
            return model;
        }

        public IConceptModel MapToModelListing(IConcept entity)
        {
            var model = NameableEntityMapper.MapToModelListing<IConcept, ConceptModel>(entity);
            // Concept Properties
            model.StartYear = entity.StartYear;
            // Related Objects
            model.PrimaryImageId = entity.PrimaryImageId;
            model.FirstIssueAppearanceId = entity.FirstIssueAppearanceId;
            // Return Entity
            return model;
        }

        public IConceptSearchModel MapToSearchModel(IConceptModel model)
        {
            var searchModel = NameableEntityMapper.MapToSearchModel<IConceptModel, ConceptSearchModel>(model);
            // Search Properties
            searchModel.PrimaryImageId = model.PrimaryImageId;
            searchModel.PrimaryImageCustomKey = model.PrimaryImage.CustomKey;
            searchModel.PrimaryImageName = model.PrimaryImage.Name;
            searchModel.PrimaryImageDescription = model.PrimaryImage.Description;
            searchModel.FirstIssueAppearanceId = model.FirstIssueAppearanceId;
            searchModel.FirstIssueAppearanceCustomKey = model.FirstIssueAppearance.CustomKey;
            searchModel.FirstIssueAppearanceName = model.FirstIssueAppearance.Name;
            searchModel.FirstIssueAppearanceDescription = model.FirstIssueAppearance.Description;
            // Return Search Model
            return searchModel;
        }

        public bool AreEqual(IConceptModel model, IConcept entity)
        {
            return NameableEntityMapper.AreEqual(model, entity)
                // Concept Properties
                && model.StartYear == entity.StartYear
                // Related Objects
                && model.PrimaryImageId == entity.PrimaryImageId
                && model.FirstIssueAppearanceId == entity.FirstIssueAppearanceId
                ;
        }
    }
}
