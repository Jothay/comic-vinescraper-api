// <auto-generated>
// <copyright file="Movies.IMovieProducerModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieProducer model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class MovieProducerModel : EntityModel, IMovieProducerModel
    {
        // MovieProducer Properties
        // <None>
        // Related Objects
        public int MovieId { get; set; }
        public IMovieModel Movie { get; set; }
        public int ProducerId { get; set; }
        public IPersonModel Producer { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class MovieProducerSearchModel : EntitySearchModel, Interfaces.SearchModels.IMovieProducerSearchModel
    {
        [ServiceStack.ApiMember(Name = "MovieId", IsRequired = false, Description = "Filter by the Related MovieId")]
        public int? MovieId { get; set; }

        [ServiceStack.ApiMember(Name = "MovieCustomKey", IsRequired = false, Description = "Filter by the Related Movie CustomKey (Equals, Case-Insensitive)")]
        public string MovieCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "MovieApiDetailUrl", IsRequired = false, Description = "Filter by the Related Movie Api Detail Url (Contains, Case-Insensitive)")]
        public string MovieApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "MovieSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Movie Site Detail Url (Contains, Case-Insensitive)")]
        public string MovieSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "MovieName", IsRequired = false, Description = "Filter by the Related Movie Name (Contains, Case-Insensitive)")]
        public string MovieName { get; set; }

        [ServiceStack.ApiMember(Name = "MovieShortDescription", IsRequired = false, Description = "Filter by the Related Movie Short Description (Contains, Case-Insensitive)")]
        public string MovieShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "MovieDescription", IsRequired = false, Description = "Filter by the Related Movie Description (Contains, Case-Insensitive)")]
        public string MovieDescription { get; set; }

        [ServiceStack.ApiMember(Name = "ProducerId", IsRequired = false, Description = "Filter by the Related ProducerId")]
        public int? ProducerId { get; set; }

        [ServiceStack.ApiMember(Name = "ProducerCustomKey", IsRequired = false, Description = "Filter by the Related Producer CustomKey (Equals, Case-Insensitive)")]
        public string ProducerCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "ProducerApiDetailUrl", IsRequired = false, Description = "Filter by the Related Producer Api Detail Url (Contains, Case-Insensitive)")]
        public string ProducerApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "ProducerSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Producer Site Detail Url (Contains, Case-Insensitive)")]
        public string ProducerSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "ProducerName", IsRequired = false, Description = "Filter by the Related Producer Name (Contains, Case-Insensitive)")]
        public string ProducerName { get; set; }

        [ServiceStack.ApiMember(Name = "ProducerShortDescription", IsRequired = false, Description = "Filter by the Related Producer Short Description (Contains, Case-Insensitive)")]
        public string ProducerShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "ProducerDescription", IsRequired = false, Description = "Filter by the Related Producer Description (Contains, Case-Insensitive)")]
        public string ProducerDescription { get; set; }

    }
}
