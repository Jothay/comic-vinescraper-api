// <auto-generated>
// <copyright file="Issues.IIssueWriterMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between IssueWriter and IssueWriterModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in
// ComicVineScraper.API.Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVineScraper.API.Mappings//.Issues
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

    public static class IssueWriterMapperExtensions
    {
        public static IIssueWriterMapper Mapper = new IssueWriterMapper();

        public static void OverrideMapper(IIssueWriterMapper mapper) { Mapper = mapper; }

        public static IIssueWriter MapToEntity(this IIssueWriterModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IIssueWriterModel model, ref IIssueWriter entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IIssueWriterModel MapToModel(this IIssueWriter entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IIssueWriterModel MapToModelLite(this IIssueWriter entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IIssueWriterModel MapToModelListing(this IIssueWriter entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IIssueWriterSearchModel MapToSearchModel(this IIssueWriterModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IIssueWriterModel model, IIssueWriter entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class IssueWriterMapper : IIssueWriterMapper
    {
        public virtual IIssueWriter MapToEntity(IIssueWriterModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<IssueWriter, IIssueWriterModel>(model);
            // IssueWriter Properties
            // <None>
            // Related Objects
            entity.IssueId = model.IssueId;
            entity.Issue = (Issue)model.Issue?.MapToEntity();
            entity.WriterId = model.WriterId;
            entity.Writer = (Person)model.Writer?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IIssueWriterModel model, ref IIssueWriter entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // IssueWriter Properties
            // <None>
            // Related Objects
            entity.IssueId = model.IssueId;
            entity.Issue = (Issue)model.Issue?.MapToEntity();
            entity.WriterId = model.WriterId;
            entity.Writer = (Person)model.Writer?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IIssueWriterModel MapToModel(IIssueWriter entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<IIssueWriter, IssueWriterModel>(entity);
            // IssueWriter Properties
            // <None>
            // Related Objects
            model.IssueId = entity.IssueId;
            model.Issue = entity.Issue?.MapToModel();
            model.WriterId = entity.WriterId;
            model.Writer = entity.Writer?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IIssueWriterModel MapToModelLite(IIssueWriter entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<IIssueWriter, IssueWriterModel>(entity);
            // IssueWriter Properties
            // <None>
            // Related Objects
            model.IssueId = entity.IssueId;
            model.WriterId = entity.WriterId;
            // Return Entity
            return model;
        }

        public virtual IIssueWriterModel MapToModelListing(IIssueWriter entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<IIssueWriter, IssueWriterModel>(entity);
            // IssueWriter Properties
            // <None>
            // Related Objects
            model.IssueId = entity.IssueId;
            model.WriterId = entity.WriterId;
            // Return Entity
            return model;
        }

        public virtual IIssueWriterSearchModel MapToSearchModel(IIssueWriterModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IIssueWriterModel, IssueWriterSearchModel>(model);
            // Search Properties
            searchModel.IssueId = model.IssueId;
            searchModel.IssueCustomKey = model.Issue?.CustomKey;
            searchModel.IssueApiDetailUrl = model.Issue?.ApiDetailUrl;
            searchModel.IssueSiteDetailUrl = model.Issue?.SiteDetailUrl;
            searchModel.IssueName = model.Issue?.Name;
            searchModel.IssueShortDescription = model.Issue?.ShortDescription;
            searchModel.IssueDescription = model.Issue?.Description;
            searchModel.WriterId = model.WriterId;
            searchModel.WriterCustomKey = model.Writer?.CustomKey;
            searchModel.WriterApiDetailUrl = model.Writer?.ApiDetailUrl;
            searchModel.WriterSiteDetailUrl = model.Writer?.SiteDetailUrl;
            searchModel.WriterName = model.Writer?.Name;
            searchModel.WriterShortDescription = model.Writer?.ShortDescription;
            searchModel.WriterDescription = model.Writer?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IIssueWriterModel model, IIssueWriter entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // IssueWriter Properties
                // <None>
                // Related Objects
                && model.IssueId == entity.IssueId
                && model.WriterId == entity.WriterId
                ;
        }
    }
}
