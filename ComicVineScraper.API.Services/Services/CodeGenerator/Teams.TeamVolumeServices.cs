// <auto-generated>
// <copyright file="Teams.ITeamVolumeServices.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the TeamVolume ServiceStack DTOs and Handlers.</summary>
// <remarks>This file was auto-generated using ServiceFileMaster.tt in
// ComicVineScraper.API.Services\Framework\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Services//.Teams
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class TeamVolumeModelBase : NameableEntityModelBase, ITeamVolumeModel
    {
        // TeamVolume Properties
        // <None>
        // Related Objects
        public int TeamId { get; set; }
        public ITeamModel Team { get; set; }
        public int VolumeId { get; set; }
        public IVolumeModel Volume { get; set; }
        // Associated Objects
        // <None>
    }
    public class TeamVolumeSearchModelBase : NameableEntitySearchModelBase, ITeamVolumeSearchModel
    {
        [ApiMember(Name = "TeamId", IsRequired = false, Description = "Filter by the Related TeamId")]
        public int? TeamId { get; set; }

        [ApiMember(Name = "TeamCustomKey", IsRequired = false, Description = "Filter by the Related Team CustomKey (Equals, Case-Insensitive)")]
        public string TeamCustomKey { get; set; }

        [ApiMember(Name = "TeamApiDetailUrl", IsRequired = false, Description = "Filter by the Related Team Api Detail Url (Contains, Case-Insensitive)")]
        public string TeamApiDetailUrl { get; set; }

        [ApiMember(Name = "TeamSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Team Site Detail Url (Contains, Case-Insensitive)")]
        public string TeamSiteDetailUrl { get; set; }

        [ApiMember(Name = "TeamName", IsRequired = false, Description = "Filter by the Related Team Name (Contains, Case-Insensitive)")]
        public string TeamName { get; set; }

        [ApiMember(Name = "TeamShortDescription", IsRequired = false, Description = "Filter by the Related Team Short Description (Contains, Case-Insensitive)")]
        public string TeamShortDescription { get; set; }

        [ApiMember(Name = "TeamDescription", IsRequired = false, Description = "Filter by the Related Team Description (Contains, Case-Insensitive)")]
        public string TeamDescription { get; set; }

        [ApiMember(Name = "VolumeId", IsRequired = false, Description = "Filter by the Related VolumeId")]
        public int? VolumeId { get; set; }

        [ApiMember(Name = "VolumeCustomKey", IsRequired = false, Description = "Filter by the Related Volume CustomKey (Equals, Case-Insensitive)")]
        public string VolumeCustomKey { get; set; }

        [ApiMember(Name = "VolumeApiDetailUrl", IsRequired = false, Description = "Filter by the Related Volume Api Detail Url (Contains, Case-Insensitive)")]
        public string VolumeApiDetailUrl { get; set; }

        [ApiMember(Name = "VolumeSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Volume Site Detail Url (Contains, Case-Insensitive)")]
        public string VolumeSiteDetailUrl { get; set; }

        [ApiMember(Name = "VolumeName", IsRequired = false, Description = "Filter by the Related Volume Name (Contains, Case-Insensitive)")]
        public string VolumeName { get; set; }

        [ApiMember(Name = "VolumeShortDescription", IsRequired = false, Description = "Filter by the Related Volume Short Description (Contains, Case-Insensitive)")]
        public string VolumeShortDescription { get; set; }

        [ApiMember(Name = "VolumeDescription", IsRequired = false, Description = "Filter by the Related Volume Description (Contains, Case-Insensitive)")]
        public string VolumeDescription { get; set; }

    }

    [Route("/TeamVolumes/", "GET", Summary = "Gets All Active TeamVolumes")]
    public class GetTeamVolumes : TeamVolumeSearchModelBase, IReturn<List<ITeamVolumeModel>> { }

    [Route("/TeamVolumes/Listing", "GET", Summary = "Gets All Active TeamVolumes with the mininum header information")]
    public class GetTeamVolumesAsListing : TeamVolumeSearchModelBase, IReturn<List<ITeamVolumeModel>> { }

    [Route("/TeamVolumes/{ID}", "GET", Summary = "Gets TeamVolume by Identifier")]
    public class GetTeamVolume : ImplementsID, IReturn<ITeamVolumeModel> { }

    [Route("/TeamVolumes/{CustomKey}/ByKey", "GET", Summary = "Gets TeamVolume by Key")]
    public class GetTeamVolumeByKey : ImplementsKey, IReturn<ITeamVolumeModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamVolumes/Create", "POST", Summary = "Creates an TeamVolume with these contents")]
    public class CreateTeamVolume : TeamVolumeModelBase, IReturn<ITeamVolumeModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamVolumes/Update", "POST", Summary = "Updates an TeamVolume with new contents")]
    public class UpdateTeamVolume : TeamVolumeModelBase, IReturn<ITeamVolumeModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamVolumes/{ID}/Deactivate", "POST", Summary = "Deactivates an TeamVolume by Identifier")]
    public class DeactivateTeamVolume : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamVolumes/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an TeamVolume by Key")]
    public class DeactivateTeamVolumeByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamVolumes/{ID}/Remove", "POST", Summary = "Removes an TeamVolume by Identifier")]
    public class RemoveTeamVolume : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamVolumes/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an TeamVolume by Key")]
    public class RemoveTeamVolumeByKey : ImplementsKey, IReturn<bool> { }

    public interface ITeamVolumesServices
    {
        List<ITeamVolumeModel> Any(GetTeamVolumes request);
        List<ITeamVolumeModel> Any(GetTeamVolumesAsListing request);
        ITeamVolumeModel Any(GetTeamVolume request);
        ITeamVolumeModel Any(GetTeamVolumeByKey request);
        ITeamVolumeModel Any(CreateTeamVolume request);
        ITeamVolumeModel Any(UpdateTeamVolume request);
        bool Any(DeactivateTeamVolume request);
        bool Any(DeactivateTeamVolumeByKey request);
        bool Any(RemoveTeamVolume request);
        bool Any(RemoveTeamVolumeByKey request);
    }

    public class TeamVolumesServices : Service, ITeamVolumesServices
    {
        private readonly ITeamVolumesBusinessWorkflow workflow;

        public TeamVolumesServices(ITeamVolumesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ITeamVolumeModel> Any(GetTeamVolumes request) { return workflow.Search(request); }
        public List<ITeamVolumeModel> Any(GetTeamVolumesAsListing request) { return workflow.Search(request, true); }
        public ITeamVolumeModel Any(GetTeamVolume request) { return workflow.Get(request.ID); }
        public ITeamVolumeModel Any(GetTeamVolumeByKey request) { return workflow.Get(request.CustomKey); }
        public ITeamVolumeModel Any(CreateTeamVolume request) { return workflow.Create(request); }
        public ITeamVolumeModel Any(UpdateTeamVolume request) { return workflow.Update(request); }
        public bool Any(DeactivateTeamVolume request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateTeamVolumeByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveTeamVolume request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveTeamVolumeByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
