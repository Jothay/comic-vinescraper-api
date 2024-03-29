// <auto-generated>
// <copyright file="Volumes.IVolumeServices.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the Volume ServiceStack DTOs and Handlers.</summary>
// <remarks>This file was auto-generated using ServiceFileMaster.tt in
// ComicVineScraper.API.Services\Framework\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Services//.Volumes
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class VolumeModelBase : NameableEntityModelBase, IVolumeModel
    {
        // Volume Properties
        public int Startyear { get; set; }
        // Related Objects
        public int? PrimaryImageFileId { get; set; }
        public IImageFileModel PrimaryImageFile { get; set; }
        public int? FirstIssueId { get; set; }
        public IIssueModel FirstIssue { get; set; }
        public int? LastIssueId { get; set; }
        public IIssueModel LastIssue { get; set; }
        public int? PublisherId { get; set; }
        public IPublisherModel Publisher { get; set; }
        // Associated Objects
        public List<IIssueModel> Issues { get; set; }
        public List<IVolumeAliasModel> VolumeAliases { get; set; }
        public List<IVolumeCharacterModel> VolumeCharacters { get; set; }
        public List<IVolumeConceptModel> VolumeConcepts { get; set; }
        public List<IVolumeLocationModel> VolumeLocations { get; set; }
        public List<IVolumeObjectModel> VolumeObjects { get; set; }
        public List<IVolumeTeamModel> VolumeTeams { get; set; }
        public List<IVolumeWriterModel> VolumeWriters { get; set; }
    }
    public class VolumeSearchModelBase : NameableEntitySearchModelBase, IVolumeSearchModel
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

        [ApiMember(Name = "FirstIssueId", IsRequired = false, Description = "Filter by the Related FirstIssueId")]
        public int? FirstIssueId { get; set; }

        [ApiMember(Name = "FirstIssueCustomKey", IsRequired = false, Description = "Filter by the Related FirstIssue CustomKey (Equals, Case-Insensitive)")]
        public string FirstIssueCustomKey { get; set; }

        [ApiMember(Name = "FirstIssueApiDetailUrl", IsRequired = false, Description = "Filter by the Related FirstIssue Api Detail Url (Contains, Case-Insensitive)")]
        public string FirstIssueApiDetailUrl { get; set; }

        [ApiMember(Name = "FirstIssueSiteDetailUrl", IsRequired = false, Description = "Filter by the Related FirstIssue Site Detail Url (Contains, Case-Insensitive)")]
        public string FirstIssueSiteDetailUrl { get; set; }

        [ApiMember(Name = "FirstIssueName", IsRequired = false, Description = "Filter by the Related FirstIssue Name (Contains, Case-Insensitive)")]
        public string FirstIssueName { get; set; }

        [ApiMember(Name = "FirstIssueShortDescription", IsRequired = false, Description = "Filter by the Related FirstIssue Short Description (Contains, Case-Insensitive)")]
        public string FirstIssueShortDescription { get; set; }

        [ApiMember(Name = "FirstIssueDescription", IsRequired = false, Description = "Filter by the Related FirstIssue Description (Contains, Case-Insensitive)")]
        public string FirstIssueDescription { get; set; }

        [ApiMember(Name = "LastIssueId", IsRequired = false, Description = "Filter by the Related LastIssueId")]
        public int? LastIssueId { get; set; }

        [ApiMember(Name = "LastIssueCustomKey", IsRequired = false, Description = "Filter by the Related LastIssue CustomKey (Equals, Case-Insensitive)")]
        public string LastIssueCustomKey { get; set; }

        [ApiMember(Name = "LastIssueApiDetailUrl", IsRequired = false, Description = "Filter by the Related LastIssue Api Detail Url (Contains, Case-Insensitive)")]
        public string LastIssueApiDetailUrl { get; set; }

        [ApiMember(Name = "LastIssueSiteDetailUrl", IsRequired = false, Description = "Filter by the Related LastIssue Site Detail Url (Contains, Case-Insensitive)")]
        public string LastIssueSiteDetailUrl { get; set; }

        [ApiMember(Name = "LastIssueName", IsRequired = false, Description = "Filter by the Related LastIssue Name (Contains, Case-Insensitive)")]
        public string LastIssueName { get; set; }

        [ApiMember(Name = "LastIssueShortDescription", IsRequired = false, Description = "Filter by the Related LastIssue Short Description (Contains, Case-Insensitive)")]
        public string LastIssueShortDescription { get; set; }

        [ApiMember(Name = "LastIssueDescription", IsRequired = false, Description = "Filter by the Related LastIssue Description (Contains, Case-Insensitive)")]
        public string LastIssueDescription { get; set; }

        [ApiMember(Name = "PublisherId", IsRequired = false, Description = "Filter by the Related PublisherId")]
        public int? PublisherId { get; set; }

        [ApiMember(Name = "PublisherCustomKey", IsRequired = false, Description = "Filter by the Related Publisher CustomKey (Equals, Case-Insensitive)")]
        public string PublisherCustomKey { get; set; }

        [ApiMember(Name = "PublisherApiDetailUrl", IsRequired = false, Description = "Filter by the Related Publisher Api Detail Url (Contains, Case-Insensitive)")]
        public string PublisherApiDetailUrl { get; set; }

        [ApiMember(Name = "PublisherSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Publisher Site Detail Url (Contains, Case-Insensitive)")]
        public string PublisherSiteDetailUrl { get; set; }

        [ApiMember(Name = "PublisherName", IsRequired = false, Description = "Filter by the Related Publisher Name (Contains, Case-Insensitive)")]
        public string PublisherName { get; set; }

        [ApiMember(Name = "PublisherShortDescription", IsRequired = false, Description = "Filter by the Related Publisher Short Description (Contains, Case-Insensitive)")]
        public string PublisherShortDescription { get; set; }

        [ApiMember(Name = "PublisherDescription", IsRequired = false, Description = "Filter by the Related Publisher Description (Contains, Case-Insensitive)")]
        public string PublisherDescription { get; set; }

    }

    [Route("/Volumes/", "GET", Summary = "Gets All Active Volumes")]
    public class GetVolumes : VolumeSearchModelBase, IReturn<List<IVolumeModel>> { }

    [Route("/Volumes/Listing", "GET", Summary = "Gets All Active Volumes with the mininum header information")]
    public class GetVolumesAsListing : VolumeSearchModelBase, IReturn<List<IVolumeModel>> { }

    [Route("/Volumes/{ID}", "GET", Summary = "Gets Volume by Identifier")]
    public class GetVolume : ImplementsID, IReturn<IVolumeModel> { }

    [Route("/Volumes/{CustomKey}/ByKey", "GET", Summary = "Gets Volume by Key")]
    public class GetVolumeByKey : ImplementsKey, IReturn<IVolumeModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Volumes/Create", "POST", Summary = "Creates an Volume with these contents")]
    public class CreateVolume : VolumeModelBase, IReturn<IVolumeModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Volumes/Update", "POST", Summary = "Updates an Volume with new contents")]
    public class UpdateVolume : VolumeModelBase, IReturn<IVolumeModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Volumes/{ID}/Deactivate", "POST", Summary = "Deactivates an Volume by Identifier")]
    public class DeactivateVolume : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Volumes/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an Volume by Key")]
    public class DeactivateVolumeByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Volumes/{ID}/Remove", "POST", Summary = "Removes an Volume by Identifier")]
    public class RemoveVolume : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Volumes/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an Volume by Key")]
    public class RemoveVolumeByKey : ImplementsKey, IReturn<bool> { }

    public interface IVolumesServices
    {
        List<IVolumeModel> Any(GetVolumes request);
        List<IVolumeModel> Any(GetVolumesAsListing request);
        IVolumeModel Any(GetVolume request);
        IVolumeModel Any(GetVolumeByKey request);
        IVolumeModel Any(CreateVolume request);
        IVolumeModel Any(UpdateVolume request);
        bool Any(DeactivateVolume request);
        bool Any(DeactivateVolumeByKey request);
        bool Any(RemoveVolume request);
        bool Any(RemoveVolumeByKey request);
    }

    public class VolumesServices : Service, IVolumesServices
    {
        private readonly IVolumesBusinessWorkflow workflow;

        public VolumesServices(IVolumesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IVolumeModel> Any(GetVolumes request) { return workflow.Search(request); }
        public List<IVolumeModel> Any(GetVolumesAsListing request) { return workflow.Search(request, true); }
        public IVolumeModel Any(GetVolume request) { return workflow.Get(request.ID); }
        public IVolumeModel Any(GetVolumeByKey request) { return workflow.Get(request.CustomKey); }
        public IVolumeModel Any(CreateVolume request) { return workflow.Create(request); }
        public IVolumeModel Any(UpdateVolume request) { return workflow.Update(request); }
        public bool Any(DeactivateVolume request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateVolumeByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveVolume request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveVolumeByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
