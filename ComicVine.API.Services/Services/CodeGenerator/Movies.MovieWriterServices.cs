// <auto-generated>
// <copyright file="Movies.IMovieWriterModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieWriter model interfaces.</summary>
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

    public class MovieWriterModelBase : NameableEntityModelBase, IMovieWriterModel
    {
        // MovieWriter Properties
        // <None>
        // Related Objects
        public int MovieId { get; set; }
        public IMovieModel Movie { get; set; }
        public int WriterId { get; set; }
        public IPersonModel Writer { get; set; }
        // Associated Objects
        // <None>
    }
    public class MovieWriterSearchModelBase : NameableEntitySearchModelBase, IMovieWriterSearchModel
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

        [ApiMember(Name = "WriterId", IsRequired = false, Description = "Filter by the Related WriterId")]
        public int? WriterId { get; set; }

        [ApiMember(Name = "WriterCustomKey", IsRequired = false, Description = "Filter by the Related Writer CustomKey (Equals, Case-Insensitive)")]
        public string WriterCustomKey { get; set; }

        [ApiMember(Name = "WriterApiDetailUrl", IsRequired = false, Description = "Filter by the Related Writer Api Detail Url (Contains, Case-Insensitive)")]
        public string WriterApiDetailUrl { get; set; }

        [ApiMember(Name = "WriterSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Writer Site Detail Url (Contains, Case-Insensitive)")]
        public string WriterSiteDetailUrl { get; set; }

        [ApiMember(Name = "WriterName", IsRequired = false, Description = "Filter by the Related Writer Name (Contains, Case-Insensitive)")]
        public string WriterName { get; set; }

        [ApiMember(Name = "WriterShortDescription", IsRequired = false, Description = "Filter by the Related Writer Short Description (Contains, Case-Insensitive)")]
        public string WriterShortDescription { get; set; }

        [ApiMember(Name = "WriterDescription", IsRequired = false, Description = "Filter by the Related Writer Description (Contains, Case-Insensitive)")]
        public string WriterDescription { get; set; }

    }

    [Route("/MovieWriters/", "GET", Summary = "Gets All Active MovieWriters")]
    public class GetMovieWriters : MovieWriterSearchModelBase, IReturn<List<IMovieWriterModel>> { }

    [Route("/MovieWriters/Listing", "GET", Summary = "Gets All Active MovieWriters with the mininum header information")]
    public class GetMovieWritersAsListing : MovieWriterSearchModelBase, IReturn<List<IMovieWriterModel>> { }

    [Route("/MovieWriters/{ID}", "GET", Summary = "Gets MovieWriter by Identifier")]
    public class GetMovieWriter : ImplementsID, IReturn<IMovieWriterModel> { }

    [Route("/MovieWriters/{CustomKey}/ByKey", "GET", Summary = "Gets MovieWriter by Key")]
    public class GetMovieWriterByKey : ImplementsKey, IReturn<IMovieWriterModel> { }

    //[Authenticate]
    [Route("/MovieWriters/Create", "POST", Summary = "Creates an MovieWriter with these contents")]
    public class CreateMovieWriter : MovieWriterModelBase, IReturn<IMovieWriterModel> { }

    //[Authenticate]
    [Route("/MovieWriters/Update", "POST", Summary = "Updates an MovieWriter with new contents")]
    public class UpdateMovieWriter : MovieWriterModelBase, IReturn<IMovieWriterModel> { }

    //[Authenticate]
    [Route("/MovieWriters/{ID}/Deactivate", "POST", Summary = "Deactivates an MovieWriter by Identifier")]
    public class DeactivateMovieWriter : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/MovieWriters/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an MovieWriter by Key")]
    public class DeactivateMovieWriterByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/MovieWriters/{ID}/Remove", "POST", Summary = "Removes an MovieWriter by Identifier")]
    public class RemoveMovieWriter : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/MovieWriters/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an MovieWriter by Key")]
    public class RemoveMovieWriterByKey : ImplementsKey, IReturn<bool> { }

    public interface IMovieWritersServices
    {
        List<IMovieWriterModel> Any(GetMovieWriters request);
        List<IMovieWriterModel> Any(GetMovieWritersAsListing request);
        IMovieWriterModel Any(GetMovieWriter request);
        IMovieWriterModel Any(GetMovieWriterByKey request);
        IMovieWriterModel Any(CreateMovieWriter request);
        IMovieWriterModel Any(UpdateMovieWriter request);
        bool Any(DeactivateMovieWriter request);
        bool Any(DeactivateMovieWriterByKey request);
        bool Any(RemoveMovieWriter request);
        bool Any(RemoveMovieWriterByKey request);
    }

    public class MovieWritersServices : /*ServicesBase,*/ IMovieWritersServices
    {
        private readonly IMovieWritersBusinessWorkflow workflow;

        public MovieWritersServices(IMovieWritersBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IMovieWriterModel> Any(GetMovieWriters request) { return workflow.Search(request); }
        public List<IMovieWriterModel> Any(GetMovieWritersAsListing request) { return workflow.Search(request, true); }
        public IMovieWriterModel Any(GetMovieWriter request) { return workflow.Get(request.ID); }
        public IMovieWriterModel Any(GetMovieWriterByKey request) { return workflow.Get(request.CustomKey); }
        public IMovieWriterModel Any(CreateMovieWriter request) { return workflow.Create(request); }
        public IMovieWriterModel Any(UpdateMovieWriter request) { return workflow.Update(request); }
        public bool Any(DeactivateMovieWriter request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateMovieWriterByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveMovieWriter request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveMovieWriterByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
