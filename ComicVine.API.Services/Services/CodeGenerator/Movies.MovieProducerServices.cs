// <auto-generated>
// <copyright file="Movies.IMovieProducerModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieProducer model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Movies
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;

    public class MovieProducerModelBase : NameableEntityModelBase, IMovieProducerModel
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
    public class MovieProducerSearchModelBase : NameableEntitySearchModelBase, IMovieProducerSearchModel
    {
        [ApiMember(Name = "MovieId", IsRequired = false, Description = "Filter by the Related MovieId")]
        public int? MovieId { get; set; }

        [ApiMember(Name = "MovieCustomKey", IsRequired = false, Description = "Filter by the Related Movie CustomKey (Equals, Case-Insensitive)")]
        public string MovieCustomKey { get; set; }

        [ApiMember(Name = "MovieApiDetailUrl", IsRequired = false, Description = "Filter by the Related Movie Api Detail Url (Contains, Case-Insensitive)")]
        public string MovieApiDetailUrl { get; set; }

        [ApiMember(Name = "MovieSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Movie Site Detail Url (Contains, Case-Insensitive)")]
        public string MovieSiteDetailUrl { get; set; }

        [ApiMember(Name = "MovieName", IsRequired = false, Description = "Filter by the Related Movie Name (Contains, Case-Insensitive)")]
        public string MovieName { get; set; }

        [ApiMember(Name = "MovieShortDescription", IsRequired = false, Description = "Filter by the Related Movie Short Description (Contains, Case-Insensitive)")]
        public string MovieShortDescription { get; set; }

        [ApiMember(Name = "MovieDescription", IsRequired = false, Description = "Filter by the Related Movie Description (Contains, Case-Insensitive)")]
        public string MovieDescription { get; set; }

        [ApiMember(Name = "ProducerId", IsRequired = false, Description = "Filter by the Related ProducerId")]
        public int? ProducerId { get; set; }

        [ApiMember(Name = "ProducerCustomKey", IsRequired = false, Description = "Filter by the Related Producer CustomKey (Equals, Case-Insensitive)")]
        public string ProducerCustomKey { get; set; }

        [ApiMember(Name = "ProducerApiDetailUrl", IsRequired = false, Description = "Filter by the Related Producer Api Detail Url (Contains, Case-Insensitive)")]
        public string ProducerApiDetailUrl { get; set; }

        [ApiMember(Name = "ProducerSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Producer Site Detail Url (Contains, Case-Insensitive)")]
        public string ProducerSiteDetailUrl { get; set; }

        [ApiMember(Name = "ProducerName", IsRequired = false, Description = "Filter by the Related Producer Name (Contains, Case-Insensitive)")]
        public string ProducerName { get; set; }

        [ApiMember(Name = "ProducerShortDescription", IsRequired = false, Description = "Filter by the Related Producer Short Description (Contains, Case-Insensitive)")]
        public string ProducerShortDescription { get; set; }

        [ApiMember(Name = "ProducerDescription", IsRequired = false, Description = "Filter by the Related Producer Description (Contains, Case-Insensitive)")]
        public string ProducerDescription { get; set; }

    }

    [Route("/MovieProducers/", "GET", Summary = "Gets All Active MovieProducers")]
    public class GetMovieProducers : MovieProducerSearchModelBase, IReturn<List<IMovieProducerModel>> { }

    [Route("/MovieProducers/Listing", "GET", Summary = "Gets All Active MovieProducers with the mininum header information")]
    public class GetMovieProducersAsListing : MovieProducerSearchModelBase, IReturn<List<IMovieProducerModel>> { }

    [Route("/MovieProducers/{ID}", "GET", Summary = "Gets MovieProducer by Identifier")]
    public class GetMovieProducer : ImplementsID, IReturn<IMovieProducerModel> { }

    [Route("/MovieProducers/{CustomKey}/ByKey", "GET", Summary = "Gets MovieProducer by Key")]
    public class GetMovieProducerByKey : ImplementsKey, IReturn<IMovieProducerModel> { }

    //[Authenticate]
    [Route("/MovieProducers/Create", "POST", Summary = "Creates an MovieProducer with these contents")]
    public class CreateMovieProducer : MovieProducerModelBase, IReturn<IMovieProducerModel> { }

    //[Authenticate]
    [Route("/MovieProducers/Update", "POST", Summary = "Updates an MovieProducer with new contents")]
    public class UpdateMovieProducer : MovieProducerModelBase, IReturn<IMovieProducerModel> { }

    //[Authenticate]
    [Route("/MovieProducers/{ID}/Deactivate", "POST", Summary = "Deactivates an MovieProducer by Identifier")]
    public class DeactivateMovieProducer : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/MovieProducers/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an MovieProducer by Key")]
    public class DeactivateMovieProducerByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/MovieProducers/{ID}/Remove", "POST", Summary = "Removes an MovieProducer by Identifier")]
    public class RemoveMovieProducer : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/MovieProducers/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an MovieProducer by Key")]
    public class RemoveMovieProducerByKey : ImplementsKey, IReturn<bool> { }

    public interface IMovieProducersServices
    {
        List<IMovieProducerModel> Any(GetMovieProducers request);
        List<IMovieProducerModel> Any(GetMovieProducersAsListing request);
        IMovieProducerModel Any(GetMovieProducer request);
        IMovieProducerModel Any(GetMovieProducerByKey request);
        IMovieProducerModel Any(CreateMovieProducer request);
        IMovieProducerModel Any(UpdateMovieProducer request);
        bool Any(DeactivateMovieProducer request);
        bool Any(DeactivateMovieProducerByKey request);
        bool Any(RemoveMovieProducer request);
        bool Any(RemoveMovieProducerByKey request);
    }

    public class MovieProducersServices : /*ServicesBase,*/ IMovieProducersServices
    {
        private readonly IMovieProducersBusinessWorkflow workflow;

        public MovieProducersServices(IMovieProducersBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IMovieProducerModel> Any(GetMovieProducers request) { return workflow.Search(request); }
        public List<IMovieProducerModel> Any(GetMovieProducersAsListing request) { return workflow.Search(request, true); }
        public IMovieProducerModel Any(GetMovieProducer request) { return workflow.Get(request.ID); }
        public IMovieProducerModel Any(GetMovieProducerByKey request) { return workflow.Get(request.CustomKey); }
        public IMovieProducerModel Any(CreateMovieProducer request) { return workflow.Create(request); }
        public IMovieProducerModel Any(UpdateMovieProducer request) { return workflow.Update(request); }
        public bool Any(DeactivateMovieProducer request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateMovieProducerByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveMovieProducer request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveMovieProducerByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
