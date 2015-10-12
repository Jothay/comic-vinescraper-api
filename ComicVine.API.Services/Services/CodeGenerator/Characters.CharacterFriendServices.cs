// <auto-generated>
// <copyright file="Characters.ICharacterFriendModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterFriend model interfaces.</summary>
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
    using ServiceStack.DataAnnotations;

    public class CharacterFriendModelBase : NameableEntityModelBase, ICharacterFriendModel
    {
        // CharacterFriend Properties
        // <None>
        // Related Objects
        public int CharacterId { get; set; }
        public ICharacterModel Character { get; set; }
        public int FriendId { get; set; }
        public ICharacterModel Friend { get; set; }
        // Associated Objects
        // <None>
    }
    public class CharacterFriendSearchModelBase : NameableEntitySearchModelBase, ICharacterFriendSearchModel
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

    [Route("/CharacterFriends/", "GET", Summary = "Gets All Active CharacterFriends")]
    public class GetCharacterFriends : CharacterFriendSearchModelBase, IReturn<List<ICharacterFriendModel>> { }

    [Route("/CharacterFriends/Listing", "GET", Summary = "Gets All Active CharacterFriends with the mininum header information")]
    public class GetCharacterFriendsAsListing : CharacterFriendSearchModelBase, IReturn<List<ICharacterFriendModel>> { }

    [Route("/CharacterFriends/{ID}", "GET", Summary = "Gets CharacterFriend by Identifier")]
    public class GetCharacterFriend : ImplementsID, IReturn<ICharacterFriendModel> { }

    [Route("/CharacterFriends/{CustomKey}/ByKey", "GET", Summary = "Gets CharacterFriend by Key")]
    public class GetCharacterFriendByKey : ImplementsKey, IReturn<ICharacterFriendModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterFriends/Create", "POST", Summary = "Creates an CharacterFriend with these contents")]
    public class CreateCharacterFriend : CharacterFriendModelBase, IReturn<ICharacterFriendModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterFriends/Update", "POST", Summary = "Updates an CharacterFriend with new contents")]
    public class UpdateCharacterFriend : CharacterFriendModelBase, IReturn<ICharacterFriendModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterFriends/{ID}/Deactivate", "POST", Summary = "Deactivates an CharacterFriend by Identifier")]
    public class DeactivateCharacterFriend : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterFriends/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an CharacterFriend by Key")]
    public class DeactivateCharacterFriendByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterFriends/{ID}/Remove", "POST", Summary = "Removes an CharacterFriend by Identifier")]
    public class RemoveCharacterFriend : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/CharacterFriends/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an CharacterFriend by Key")]
    public class RemoveCharacterFriendByKey : ImplementsKey, IReturn<bool> { }

    public interface ICharacterFriendsServices
    {
        List<ICharacterFriendModel> Any(GetCharacterFriends request);
        List<ICharacterFriendModel> Any(GetCharacterFriendsAsListing request);
        ICharacterFriendModel Any(GetCharacterFriend request);
        ICharacterFriendModel Any(GetCharacterFriendByKey request);
        ICharacterFriendModel Any(CreateCharacterFriend request);
        ICharacterFriendModel Any(UpdateCharacterFriend request);
        bool Any(DeactivateCharacterFriend request);
        bool Any(DeactivateCharacterFriendByKey request);
        bool Any(RemoveCharacterFriend request);
        bool Any(RemoveCharacterFriendByKey request);
    }

    public class CharacterFriendsServices : Service, ICharacterFriendsServices
    {
        private readonly ICharacterFriendsBusinessWorkflow workflow;

        public CharacterFriendsServices(ICharacterFriendsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ICharacterFriendModel> Any(GetCharacterFriends request) { return workflow.Search(request); }
        public List<ICharacterFriendModel> Any(GetCharacterFriendsAsListing request) { return workflow.Search(request, true); }
        public ICharacterFriendModel Any(GetCharacterFriend request) { return workflow.Get(request.ID); }
        public ICharacterFriendModel Any(GetCharacterFriendByKey request) { return workflow.Get(request.CustomKey); }
        public ICharacterFriendModel Any(CreateCharacterFriend request) { return workflow.Create(request); }
        public ICharacterFriendModel Any(UpdateCharacterFriend request) { return workflow.Update(request); }
        public bool Any(DeactivateCharacterFriend request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateCharacterFriendByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveCharacterFriend request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveCharacterFriendByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
