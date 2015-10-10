// <auto-generated>
// <copyright file="dbo.IConceptModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Concept model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IConcept : INameableEntity
    {
        // Concept Properties
        int StartYear { get; set; }
        // Related Objects
        int? PrimaryImageId { get; set; }
        IImageFile PrimaryImage { get; set; }
        int FirstIssueAppearanceId { get; set; }
        IIssue FirstIssueAppearance { get; set; }
        // Associated Objects
        ICollection<IConceptAlias> ConceptAliases { get; set; }
        ICollection<IIssue> IssueAppearances { get; set; }
        ICollection<IIssue> IssueCredits { get; set; }
        ICollection<IMovie> Movies { get; set; }
        ICollection<IVolume> VolumeCredits { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IConceptModel : INameableEntityModel
    {
        // Concept Properties
        int StartYear { get; set; }
        // Related Objects
        int? PrimaryImageId { get; set; }
        IImageFileModel PrimaryImage { get; set; }
        int FirstIssueAppearanceId { get; set; }
        IIssueModel FirstIssueAppearance { get; set; }
        // Associated Objects
        List<IConceptAliasModel> ConceptAliases { get; set; }
        List<IIssueModel> IssueAppearances { get; set; }
        List<IIssueModel> IssueCredits { get; set; }
        List<IMovieModel> Movies { get; set; }
        List<IVolumeModel> VolumeCredits { get; set; }
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IConceptSearchModel : INameableEntitySearchModel
    {
        int? PrimaryImageId { get; set; }
        string PrimaryImageCustomKey { get; set; }
        string PrimaryImageApiDetailUrl { get; set; }
        string PrimaryImageSiteDetailUrl { get; set; }
        string PrimaryImageName { get; set; }
        string PrimaryImageShortDescription { get; set; }
        string PrimaryImageDescription { get; set; }
        int? FirstIssueAppearanceId { get; set; }
        string FirstIssueAppearanceCustomKey { get; set; }
        string FirstIssueAppearanceApiDetailUrl { get; set; }
        string FirstIssueAppearanceSiteDetailUrl { get; set; }
        string FirstIssueAppearanceName { get; set; }
        string FirstIssueAppearanceShortDescription { get; set; }
        string FirstIssueAppearanceDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IConceptMapper
        : IMapper<
            DataModels.IConcept,
            Models.IConceptModel,
            SearchModels.IConceptSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IConceptsRepository
        : IRepositoryBase
        , IRepository<DataModels.IConcept, SearchModels.IConceptSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IConceptsBusinessWorkflow
        : IBusinessWorkflow<Models.IConceptModel, SearchModels.IConceptSearchModel>
    {
    }
}
