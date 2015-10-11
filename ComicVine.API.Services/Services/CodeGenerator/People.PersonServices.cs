// <auto-generated>
// <copyright file="People.IPersonModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Person model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.People
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;

    public class PersonModelBase : NameableEntityModelBase, IPersonModel
    {
        // Person Properties
        public string Hometown { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
        // Related Objects
        public int PrimaryImageFileId { get; set; }
        public IImageFileModel PrimaryImageFile { get; set; }
        public int? GenderId { get; set; }
        public IGenderModel Gender { get; set; }
        // Associated Objects
        public List<ICreatorCharacterModel> CharactersCreated { get; set; }
        public List<IPersonAliasModel> PersonAliases { get; set; }
        public List<IIssueWriterModel> IssuesWritten { get; set; }
        public List<IMovieProducerModel> MoviesProduced { get; set; }
        public List<IMovieWriterModel> MoviesWritten { get; set; }
        public List<IPromoModel> PromosWritten { get; set; }
        public List<IStoryArcWriterModel> StoryArcsWritten { get; set; }
        public List<IVolumeWriterModel> VolumesWritten { get; set; }
    }
    public class PersonSearchModelBase : NameableEntitySearchModelBase, IPersonSearchModel
    {
        [ApiMember(Name = "PrimaryImageFileId", IsRequired = false, Description = "Filter by the Related PrimaryImageFileId")]
        public int? PrimaryImageFileId { get; set; }

        [ApiMember(Name = "PrimaryImageFileCustomKey", IsRequired = false, Description = "Filter by the Related PrimaryImageFile CustomKey (Equals, Case-Insensitive)")]
        public string PrimaryImageFileCustomKey { get; set; }

        [ApiMember(Name = "PrimaryImageFileApiDetailUrl", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Api Detail Url (Contains, Case-Insensitive)")]
        public string PrimaryImageFileApiDetailUrl { get; set; }

        [ApiMember(Name = "PrimaryImageFileSiteDetailUrl", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Site Detail Url (Contains, Case-Insensitive)")]
        public string PrimaryImageFileSiteDetailUrl { get; set; }

        [ApiMember(Name = "PrimaryImageFileName", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Name (Contains, Case-Insensitive)")]
        public string PrimaryImageFileName { get; set; }

        [ApiMember(Name = "PrimaryImageFileShortDescription", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Short Description (Contains, Case-Insensitive)")]
        public string PrimaryImageFileShortDescription { get; set; }

        [ApiMember(Name = "PrimaryImageFileDescription", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Description (Contains, Case-Insensitive)")]
        public string PrimaryImageFileDescription { get; set; }

        [ApiMember(Name = "GenderId", IsRequired = false, Description = "Filter by the Related GenderId")]
        public int? GenderId { get; set; }

        [ApiMember(Name = "GenderCustomKey", IsRequired = false, Description = "Filter by the Related Gender CustomKey (Equals, Case-Insensitive)")]
        public string GenderCustomKey { get; set; }

        [ApiMember(Name = "GenderApiDetailUrl", IsRequired = false, Description = "Filter by the Related Gender Api Detail Url (Contains, Case-Insensitive)")]
        public string GenderApiDetailUrl { get; set; }

        [ApiMember(Name = "GenderSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Gender Site Detail Url (Contains, Case-Insensitive)")]
        public string GenderSiteDetailUrl { get; set; }

        [ApiMember(Name = "GenderName", IsRequired = false, Description = "Filter by the Related Gender Name (Contains, Case-Insensitive)")]
        public string GenderName { get; set; }

        [ApiMember(Name = "GenderShortDescription", IsRequired = false, Description = "Filter by the Related Gender Short Description (Contains, Case-Insensitive)")]
        public string GenderShortDescription { get; set; }

        [ApiMember(Name = "GenderDescription", IsRequired = false, Description = "Filter by the Related Gender Description (Contains, Case-Insensitive)")]
        public string GenderDescription { get; set; }

    }

    [Route("/People/", "GET", Summary = "Gets All Active People")]
    public class GetPeople : PersonSearchModelBase, IReturn<List<IPersonModel>> { }

    [Route("/People/Listing", "GET", Summary = "Gets All Active People with the mininum header information")]
    public class GetPeopleAsListing : PersonSearchModelBase, IReturn<List<IPersonModel>> { }

    [Route("/People/{ID}", "GET", Summary = "Gets Person by Identifier")]
    public class GetPerson : ImplementsID, IReturn<IPersonModel> { }

    [Route("/People/{CustomKey}/ByKey", "GET", Summary = "Gets Person by Key")]
    public class GetPersonByKey : ImplementsKey, IReturn<IPersonModel> { }

    //[Authenticate]
    [Route("/People/Create", "POST", Summary = "Creates an Person with these contents")]
    public class CreatePerson : PersonModelBase, IReturn<IPersonModel> { }

    //[Authenticate]
    [Route("/People/Update", "POST", Summary = "Updates an Person with new contents")]
    public class UpdatePerson : PersonModelBase, IReturn<IPersonModel> { }

    //[Authenticate]
    [Route("/People/{ID}/Deactivate", "POST", Summary = "Deactivates an Person by Identifier")]
    public class DeactivatePerson : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/People/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an Person by Key")]
    public class DeactivatePersonByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/People/{ID}/Remove", "POST", Summary = "Removes an Person by Identifier")]
    public class RemovePerson : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/People/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an Person by Key")]
    public class RemovePersonByKey : ImplementsKey, IReturn<bool> { }

    public interface IPeopleServices
    {
        List<IPersonModel> Any(GetPeople request);
        List<IPersonModel> Any(GetPeopleAsListing request);
        IPersonModel Any(GetPerson request);
        IPersonModel Any(GetPersonByKey request);
        IPersonModel Any(CreatePerson request);
        IPersonModel Any(UpdatePerson request);
        bool Any(DeactivatePerson request);
        bool Any(DeactivatePersonByKey request);
        bool Any(RemovePerson request);
        bool Any(RemovePersonByKey request);
    }

    public class PeopleServices : /*ServicesBase,*/ IPeopleServices
    {
        private readonly IPeopleBusinessWorkflow workflow;

        public PeopleServices(IPeopleBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IPersonModel> Any(GetPeople request) { return workflow.Search(request); }
        public List<IPersonModel> Any(GetPeopleAsListing request) { return workflow.Search(request, true); }
        public IPersonModel Any(GetPerson request) { return workflow.Get(request.ID); }
        public IPersonModel Any(GetPersonByKey request) { return workflow.Get(request.CustomKey); }
        public IPersonModel Any(CreatePerson request) { return workflow.Create(request); }
        public IPersonModel Any(UpdatePerson request) { return workflow.Update(request); }
        public bool Any(DeactivatePerson request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivatePersonByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemovePerson request) { return workflow.Remove(request.ID); }
        public bool Any(RemovePersonByKey request) { return workflow.Remove(request.CustomKey); }
    }
}