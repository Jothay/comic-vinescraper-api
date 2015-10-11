// <auto-generated>
// <copyright file="Characters.ICharacterVolumeModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterVolume model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Characters
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;

    public class CharacterVolumeModelBase : NameableEntityModelBase, ICharacterVolumeModel
    {
        // CharacterVolume Properties
        // <None>
        // Related Objects
        public int CharacterId { get; set; }
        public ICharacterModel Character { get; set; }
        public int VolumeId { get; set; }
        public IVolumeModel Volume { get; set; }
        // Associated Objects
        // <None>
    }
    public class CharacterVolumeSearchModelBase : NameableEntitySearchModelBase, ICharacterVolumeSearchModel
    {
        [ApiMember(Name = "CharacterId", IsRequired = false, Description = "Filter by the Related CharacterId")]
        public int? CharacterId { get; set; }

        [ApiMember(Name = "CharacterCustomKey", IsRequired = false, Description = "Filter by the Related Character CustomKey (Equals, Case-Insensitive)")]
        public string CharacterCustomKey { get; set; }

        [ApiMember(Name = "CharacterApiDetailUrl", IsRequired = false, Description = "Filter by the Related Character Api Detail Url (Contains, Case-Insensitive)")]
        public string CharacterApiDetailUrl { get; set; }

        [ApiMember(Name = "CharacterSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Character Site Detail Url (Contains, Case-Insensitive)")]
        public string CharacterSiteDetailUrl { get; set; }

        [ApiMember(Name = "CharacterName", IsRequired = false, Description = "Filter by the Related Character Name (Contains, Case-Insensitive)")]
        public string CharacterName { get; set; }

        [ApiMember(Name = "CharacterShortDescription", IsRequired = false, Description = "Filter by the Related Character Short Description (Contains, Case-Insensitive)")]
        public string CharacterShortDescription { get; set; }

        [ApiMember(Name = "CharacterDescription", IsRequired = false, Description = "Filter by the Related Character Description (Contains, Case-Insensitive)")]
        public string CharacterDescription { get; set; }

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

    [Route("/CharacterVolumes/", "GET", Summary = "Gets All Active CharacterVolumes")]
    public class GetCharacterVolumes : CharacterVolumeSearchModelBase, IReturn<List<ICharacterVolumeModel>> { }

    [Route("/CharacterVolumes/Listing", "GET", Summary = "Gets All Active CharacterVolumes with the mininum header information")]
    public class GetCharacterVolumesAsListing : CharacterVolumeSearchModelBase, IReturn<List<ICharacterVolumeModel>> { }

    [Route("/CharacterVolumes/{ID}", "GET", Summary = "Gets CharacterVolume by Identifier")]
    public class GetCharacterVolume : ImplementsID, IReturn<ICharacterVolumeModel> { }

    [Route("/CharacterVolumes/{CustomKey}/ByKey", "GET", Summary = "Gets CharacterVolume by Key")]
    public class GetCharacterVolumeByKey : ImplementsKey, IReturn<ICharacterVolumeModel> { }

    //[Authenticate]
    [Route("/CharacterVolumes/Create", "POST", Summary = "Creates an CharacterVolume with these contents")]
    public class CreateCharacterVolume : CharacterVolumeModelBase, IReturn<ICharacterVolumeModel> { }

    //[Authenticate]
    [Route("/CharacterVolumes/Update", "POST", Summary = "Updates an CharacterVolume with new contents")]
    public class UpdateCharacterVolume : CharacterVolumeModelBase, IReturn<ICharacterVolumeModel> { }

    //[Authenticate]
    [Route("/CharacterVolumes/{ID}/Deactivate", "POST", Summary = "Deactivates an CharacterVolume by Identifier")]
    public class DeactivateCharacterVolume : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/CharacterVolumes/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an CharacterVolume by Key")]
    public class DeactivateCharacterVolumeByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/CharacterVolumes/{ID}/Remove", "POST", Summary = "Removes an CharacterVolume by Identifier")]
    public class RemoveCharacterVolume : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/CharacterVolumes/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an CharacterVolume by Key")]
    public class RemoveCharacterVolumeByKey : ImplementsKey, IReturn<bool> { }

    public interface ICharacterVolumesServices
    {
        List<ICharacterVolumeModel> Any(GetCharacterVolumes request);
        List<ICharacterVolumeModel> Any(GetCharacterVolumesAsListing request);
        ICharacterVolumeModel Any(GetCharacterVolume request);
        ICharacterVolumeModel Any(GetCharacterVolumeByKey request);
        ICharacterVolumeModel Any(CreateCharacterVolume request);
        ICharacterVolumeModel Any(UpdateCharacterVolume request);
        bool Any(DeactivateCharacterVolume request);
        bool Any(DeactivateCharacterVolumeByKey request);
        bool Any(RemoveCharacterVolume request);
        bool Any(RemoveCharacterVolumeByKey request);
    }

    public class CharacterVolumesServices : /*ServicesBase,*/ ICharacterVolumesServices
    {
        private readonly ICharacterVolumesBusinessWorkflow workflow;

        public CharacterVolumesServices(ICharacterVolumesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ICharacterVolumeModel> Any(GetCharacterVolumes request) { return workflow.Search(request); }
        public List<ICharacterVolumeModel> Any(GetCharacterVolumesAsListing request) { return workflow.Search(request, true); }
        public ICharacterVolumeModel Any(GetCharacterVolume request) { return workflow.Get(request.ID); }
        public ICharacterVolumeModel Any(GetCharacterVolumeByKey request) { return workflow.Get(request.CustomKey); }
        public ICharacterVolumeModel Any(CreateCharacterVolume request) { return workflow.Create(request); }
        public ICharacterVolumeModel Any(UpdateCharacterVolume request) { return workflow.Update(request); }
        public bool Any(DeactivateCharacterVolume request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateCharacterVolumeByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveCharacterVolume request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveCharacterVolumeByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
