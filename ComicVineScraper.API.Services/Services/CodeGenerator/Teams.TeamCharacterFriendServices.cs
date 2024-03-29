// <auto-generated>
// <copyright file="Teams.ITeamCharacterFriendServices.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the TeamCharacterFriend ServiceStack DTOs and Handlers.</summary>
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

    public class TeamCharacterFriendModelBase : NameableEntityModelBase, ITeamCharacterFriendModel
    {
        // TeamCharacterFriend Properties
        // <None>
        // Related Objects
        public int TeamId { get; set; }
        public ITeamModel Team { get; set; }
        public int FriendId { get; set; }
        public ICharacterModel Friend { get; set; }
        // Associated Objects
        // <None>
    }
    public class TeamCharacterFriendSearchModelBase : NameableEntitySearchModelBase, ITeamCharacterFriendSearchModel
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

        [ApiMember(Name = "FriendId", IsRequired = false, Description = "Filter by the Related FriendId")]
        public int? FriendId { get; set; }

        [ApiMember(Name = "FriendCustomKey", IsRequired = false, Description = "Filter by the Related Friend CustomKey (Equals, Case-Insensitive)")]
        public string FriendCustomKey { get; set; }

        [ApiMember(Name = "FriendApiDetailUrl", IsRequired = false, Description = "Filter by the Related Friend Api Detail Url (Contains, Case-Insensitive)")]
        public string FriendApiDetailUrl { get; set; }

        [ApiMember(Name = "FriendSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Friend Site Detail Url (Contains, Case-Insensitive)")]
        public string FriendSiteDetailUrl { get; set; }

        [ApiMember(Name = "FriendName", IsRequired = false, Description = "Filter by the Related Friend Name (Contains, Case-Insensitive)")]
        public string FriendName { get; set; }

        [ApiMember(Name = "FriendShortDescription", IsRequired = false, Description = "Filter by the Related Friend Short Description (Contains, Case-Insensitive)")]
        public string FriendShortDescription { get; set; }

        [ApiMember(Name = "FriendDescription", IsRequired = false, Description = "Filter by the Related Friend Description (Contains, Case-Insensitive)")]
        public string FriendDescription { get; set; }

    }

    [Route("/TeamCharacterFriends/", "GET", Summary = "Gets All Active TeamCharacterFriends")]
    public class GetTeamCharacterFriends : TeamCharacterFriendSearchModelBase, IReturn<List<ITeamCharacterFriendModel>> { }

    [Route("/TeamCharacterFriends/Listing", "GET", Summary = "Gets All Active TeamCharacterFriends with the mininum header information")]
    public class GetTeamCharacterFriendsAsListing : TeamCharacterFriendSearchModelBase, IReturn<List<ITeamCharacterFriendModel>> { }

    [Route("/TeamCharacterFriends/{ID}", "GET", Summary = "Gets TeamCharacterFriend by Identifier")]
    public class GetTeamCharacterFriend : ImplementsID, IReturn<ITeamCharacterFriendModel> { }

    [Route("/TeamCharacterFriends/{CustomKey}/ByKey", "GET", Summary = "Gets TeamCharacterFriend by Key")]
    public class GetTeamCharacterFriendByKey : ImplementsKey, IReturn<ITeamCharacterFriendModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamCharacterFriends/Create", "POST", Summary = "Creates an TeamCharacterFriend with these contents")]
    public class CreateTeamCharacterFriend : TeamCharacterFriendModelBase, IReturn<ITeamCharacterFriendModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamCharacterFriends/Update", "POST", Summary = "Updates an TeamCharacterFriend with new contents")]
    public class UpdateTeamCharacterFriend : TeamCharacterFriendModelBase, IReturn<ITeamCharacterFriendModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamCharacterFriends/{ID}/Deactivate", "POST", Summary = "Deactivates an TeamCharacterFriend by Identifier")]
    public class DeactivateTeamCharacterFriend : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamCharacterFriends/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an TeamCharacterFriend by Key")]
    public class DeactivateTeamCharacterFriendByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamCharacterFriends/{ID}/Remove", "POST", Summary = "Removes an TeamCharacterFriend by Identifier")]
    public class RemoveTeamCharacterFriend : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/TeamCharacterFriends/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an TeamCharacterFriend by Key")]
    public class RemoveTeamCharacterFriendByKey : ImplementsKey, IReturn<bool> { }

    public interface ITeamCharacterFriendsServices
    {
        List<ITeamCharacterFriendModel> Any(GetTeamCharacterFriends request);
        List<ITeamCharacterFriendModel> Any(GetTeamCharacterFriendsAsListing request);
        ITeamCharacterFriendModel Any(GetTeamCharacterFriend request);
        ITeamCharacterFriendModel Any(GetTeamCharacterFriendByKey request);
        ITeamCharacterFriendModel Any(CreateTeamCharacterFriend request);
        ITeamCharacterFriendModel Any(UpdateTeamCharacterFriend request);
        bool Any(DeactivateTeamCharacterFriend request);
        bool Any(DeactivateTeamCharacterFriendByKey request);
        bool Any(RemoveTeamCharacterFriend request);
        bool Any(RemoveTeamCharacterFriendByKey request);
    }

    public class TeamCharacterFriendsServices : Service, ITeamCharacterFriendsServices
    {
        private readonly ITeamCharacterFriendsBusinessWorkflow workflow;

        public TeamCharacterFriendsServices(ITeamCharacterFriendsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ITeamCharacterFriendModel> Any(GetTeamCharacterFriends request) { return workflow.Search(request); }
        public List<ITeamCharacterFriendModel> Any(GetTeamCharacterFriendsAsListing request) { return workflow.Search(request, true); }
        public ITeamCharacterFriendModel Any(GetTeamCharacterFriend request) { return workflow.Get(request.ID); }
        public ITeamCharacterFriendModel Any(GetTeamCharacterFriendByKey request) { return workflow.Get(request.CustomKey); }
        public ITeamCharacterFriendModel Any(CreateTeamCharacterFriend request) { return workflow.Create(request); }
        public ITeamCharacterFriendModel Any(UpdateTeamCharacterFriend request) { return workflow.Update(request); }
        public bool Any(DeactivateTeamCharacterFriend request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateTeamCharacterFriendByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveTeamCharacterFriend request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveTeamCharacterFriendByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
