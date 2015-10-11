// <auto-generated>
// <copyright file="Episodes.IEpisodeObjectFirstAppearanceModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeObjectFirstAppearance model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Episodes
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;

    public class EpisodeObjectFirstAppearanceModelBase : NameableEntityModelBase, IEpisodeObjectFirstAppearanceModel
    {
        // EpisodeObjectFirstAppearance Properties
        // <None>
        // Related Objects
        public int EpisodeId { get; set; }
        public IEpisodeModel Episode { get; set; }
        public int ObjectId { get; set; }
        public IObjectModel Object { get; set; }
        // Associated Objects
        // <None>
    }
    public class EpisodeObjectFirstAppearanceSearchModelBase : NameableEntitySearchModelBase, IEpisodeObjectFirstAppearanceSearchModel
    {
        [ApiMember(Name = "EpisodeId", IsRequired = false, Description = "Filter by the Related EpisodeId")]
        public int? EpisodeId { get; set; }

        [ApiMember(Name = "EpisodeCustomKey", IsRequired = false, Description = "Filter by the Related Episode CustomKey (Equals, Case-Insensitive)")]
        public string EpisodeCustomKey { get; set; }

        [ApiMember(Name = "EpisodeApiDetailUrl", IsRequired = false, Description = "Filter by the Related Episode Api Detail Url (Contains, Case-Insensitive)")]
        public string EpisodeApiDetailUrl { get; set; }

        [ApiMember(Name = "EpisodeSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Episode Site Detail Url (Contains, Case-Insensitive)")]
        public string EpisodeSiteDetailUrl { get; set; }

        [ApiMember(Name = "EpisodeName", IsRequired = false, Description = "Filter by the Related Episode Name (Contains, Case-Insensitive)")]
        public string EpisodeName { get; set; }

        [ApiMember(Name = "EpisodeShortDescription", IsRequired = false, Description = "Filter by the Related Episode Short Description (Contains, Case-Insensitive)")]
        public string EpisodeShortDescription { get; set; }

        [ApiMember(Name = "EpisodeDescription", IsRequired = false, Description = "Filter by the Related Episode Description (Contains, Case-Insensitive)")]
        public string EpisodeDescription { get; set; }

        [ApiMember(Name = "ObjectId", IsRequired = false, Description = "Filter by the Related ObjectId")]
        public int? ObjectId { get; set; }

        [ApiMember(Name = "ObjectCustomKey", IsRequired = false, Description = "Filter by the Related Object CustomKey (Equals, Case-Insensitive)")]
        public string ObjectCustomKey { get; set; }

        [ApiMember(Name = "ObjectApiDetailUrl", IsRequired = false, Description = "Filter by the Related Object Api Detail Url (Contains, Case-Insensitive)")]
        public string ObjectApiDetailUrl { get; set; }

        [ApiMember(Name = "ObjectSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Object Site Detail Url (Contains, Case-Insensitive)")]
        public string ObjectSiteDetailUrl { get; set; }

        [ApiMember(Name = "ObjectName", IsRequired = false, Description = "Filter by the Related Object Name (Contains, Case-Insensitive)")]
        public string ObjectName { get; set; }

        [ApiMember(Name = "ObjectShortDescription", IsRequired = false, Description = "Filter by the Related Object Short Description (Contains, Case-Insensitive)")]
        public string ObjectShortDescription { get; set; }

        [ApiMember(Name = "ObjectDescription", IsRequired = false, Description = "Filter by the Related Object Description (Contains, Case-Insensitive)")]
        public string ObjectDescription { get; set; }

    }

    [Route("/EpisodeObjectFirstAppearances/", "GET", Summary = "Gets All Active EpisodeObjectFirstAppearances")]
    public class GetEpisodeObjectFirstAppearances : EpisodeObjectFirstAppearanceSearchModelBase, IReturn<List<IEpisodeObjectFirstAppearanceModel>> { }

    [Route("/EpisodeObjectFirstAppearances/Listing", "GET", Summary = "Gets All Active EpisodeObjectFirstAppearances with the mininum header information")]
    public class GetEpisodeObjectFirstAppearancesAsListing : EpisodeObjectFirstAppearanceSearchModelBase, IReturn<List<IEpisodeObjectFirstAppearanceModel>> { }

    [Route("/EpisodeObjectFirstAppearances/{ID}", "GET", Summary = "Gets EpisodeObjectFirstAppearance by Identifier")]
    public class GetEpisodeObjectFirstAppearance : ImplementsID, IReturn<IEpisodeObjectFirstAppearanceModel> { }

    [Route("/EpisodeObjectFirstAppearances/{CustomKey}/ByKey", "GET", Summary = "Gets EpisodeObjectFirstAppearance by Key")]
    public class GetEpisodeObjectFirstAppearanceByKey : ImplementsKey, IReturn<IEpisodeObjectFirstAppearanceModel> { }

    //[Authenticate]
    [Route("/EpisodeObjectFirstAppearances/Create", "POST", Summary = "Creates an EpisodeObjectFirstAppearance with these contents")]
    public class CreateEpisodeObjectFirstAppearance : EpisodeObjectFirstAppearanceModelBase, IReturn<IEpisodeObjectFirstAppearanceModel> { }

    //[Authenticate]
    [Route("/EpisodeObjectFirstAppearances/Update", "POST", Summary = "Updates an EpisodeObjectFirstAppearance with new contents")]
    public class UpdateEpisodeObjectFirstAppearance : EpisodeObjectFirstAppearanceModelBase, IReturn<IEpisodeObjectFirstAppearanceModel> { }

    //[Authenticate]
    [Route("/EpisodeObjectFirstAppearances/{ID}/Deactivate", "POST", Summary = "Deactivates an EpisodeObjectFirstAppearance by Identifier")]
    public class DeactivateEpisodeObjectFirstAppearance : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/EpisodeObjectFirstAppearances/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an EpisodeObjectFirstAppearance by Key")]
    public class DeactivateEpisodeObjectFirstAppearanceByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/EpisodeObjectFirstAppearances/{ID}/Remove", "POST", Summary = "Removes an EpisodeObjectFirstAppearance by Identifier")]
    public class RemoveEpisodeObjectFirstAppearance : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/EpisodeObjectFirstAppearances/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an EpisodeObjectFirstAppearance by Key")]
    public class RemoveEpisodeObjectFirstAppearanceByKey : ImplementsKey, IReturn<bool> { }

    public interface IEpisodeObjectFirstAppearancesServices
    {
        List<IEpisodeObjectFirstAppearanceModel> Any(GetEpisodeObjectFirstAppearances request);
        List<IEpisodeObjectFirstAppearanceModel> Any(GetEpisodeObjectFirstAppearancesAsListing request);
        IEpisodeObjectFirstAppearanceModel Any(GetEpisodeObjectFirstAppearance request);
        IEpisodeObjectFirstAppearanceModel Any(GetEpisodeObjectFirstAppearanceByKey request);
        IEpisodeObjectFirstAppearanceModel Any(CreateEpisodeObjectFirstAppearance request);
        IEpisodeObjectFirstAppearanceModel Any(UpdateEpisodeObjectFirstAppearance request);
        bool Any(DeactivateEpisodeObjectFirstAppearance request);
        bool Any(DeactivateEpisodeObjectFirstAppearanceByKey request);
        bool Any(RemoveEpisodeObjectFirstAppearance request);
        bool Any(RemoveEpisodeObjectFirstAppearanceByKey request);
    }

    public class EpisodeObjectFirstAppearancesServices : /*ServicesBase,*/ IEpisodeObjectFirstAppearancesServices
    {
        private readonly IEpisodeObjectFirstAppearancesBusinessWorkflow workflow;

        public EpisodeObjectFirstAppearancesServices(IEpisodeObjectFirstAppearancesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IEpisodeObjectFirstAppearanceModel> Any(GetEpisodeObjectFirstAppearances request) { return workflow.Search(request); }
        public List<IEpisodeObjectFirstAppearanceModel> Any(GetEpisodeObjectFirstAppearancesAsListing request) { return workflow.Search(request, true); }
        public IEpisodeObjectFirstAppearanceModel Any(GetEpisodeObjectFirstAppearance request) { return workflow.Get(request.ID); }
        public IEpisodeObjectFirstAppearanceModel Any(GetEpisodeObjectFirstAppearanceByKey request) { return workflow.Get(request.CustomKey); }
        public IEpisodeObjectFirstAppearanceModel Any(CreateEpisodeObjectFirstAppearance request) { return workflow.Create(request); }
        public IEpisodeObjectFirstAppearanceModel Any(UpdateEpisodeObjectFirstAppearance request) { return workflow.Update(request); }
        public bool Any(DeactivateEpisodeObjectFirstAppearance request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateEpisodeObjectFirstAppearanceByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveEpisodeObjectFirstAppearance request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveEpisodeObjectFirstAppearanceByKey request) { return workflow.Remove(request.CustomKey); }
    }
}