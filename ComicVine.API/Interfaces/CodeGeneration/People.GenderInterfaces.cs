// <auto-generated>
// <copyright file="People.IGenderModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Gender model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IGender : INameableEntity
    {
        // Gender Properties
        // <None>
        // Related Objects
        // <None>
        // Associated Objects
        ICollection<ICharacter> Characters { get; set; }
        ICollection<IPerson> People { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IGenderModel : INameableEntityModel
    {
        // Gender Properties
        // <None>
        // Related Objects
        // <None>
        // Associated Objects
        List<ICharacterModel> Characters { get; set; }
        List<IPersonModel> People { get; set; }
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IGenderSearchModel : INameableEntitySearchModel
    {
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IGenderMapper
        : IMapper<
            DataModels.IGender,
            Models.IGenderModel,
            SearchModels.IGenderSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IGendersRepository
        : IRepositoryBase
        , IRepository<DataModels.IGender, SearchModels.IGenderSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IGendersBusinessWorkflow
        : IBusinessWorkflow<Models.IGenderModel, SearchModels.IGenderSearchModel>
    {
    }
}