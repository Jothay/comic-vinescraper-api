// <auto-generated>
// <copyright file="Characters.ICharacterStoryArcModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterStoryArc model interfaces.</summary>
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

    public class CharacterStoryArcModelBase : NameableEntityModelBase, ICharacterStoryArcModel
    {
        // CharacterStoryArc Properties
        // <None>
        // Related Objects
        public int CharacterId { get; set; }
        public ICharacterModel Character { get; set; }
        public int StoryArcId { get; set; }
        public IStoryArcModel StoryArc { get; set; }
        // Associated Objects
        // <None>
    }
    public class CharacterStoryArcSearchModelBase : NameableEntitySearchModelBase, ICharacterStoryArcSearchModel
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

        [ApiMember(Name = "StoryArcId", IsRequired = false, Description = "Filter by the Related StoryArcId")]
        public int? StoryArcId { get; set; }

        [ApiMember(Name = "StoryArcCustomKey", IsRequired = false, Description = "Filter by the Related StoryArc CustomKey (Equals, Case-Insensitive)")]
        public string StoryArcCustomKey { get; set; }

        [ApiMember(Name = "StoryArcApiDetailUrl", IsRequired = false, Description = "Filter by the Related StoryArc Api Detail Url (Contains, Case-Insensitive)")]
        public string StoryArcApiDetailUrl { get; set; }

        [ApiMember(Name = "StoryArcSiteDetailUrl", IsRequired = false, Description = "Filter by the Related StoryArc Site Detail Url (Contains, Case-Insensitive)")]
        public string StoryArcSiteDetailUrl { get; set; }

        [ApiMember(Name = "StoryArcName", IsRequired = false, Description = "Filter by the Related StoryArc Name (Contains, Case-Insensitive)")]
        public string StoryArcName { get; set; }

        [ApiMember(Name = "StoryArcShortDescription", IsRequired = false, Description = "Filter by the Related StoryArc Short Description (Contains, Case-Insensitive)")]
        public string StoryArcShortDescription { get; set; }

        [ApiMember(Name = "StoryArcDescription", IsRequired = false, Description = "Filter by the Related StoryArc Description (Contains, Case-Insensitive)")]
        public string StoryArcDescription { get; set; }

    }

    [Route("/CharacterStoryArcs/", "GET", Summary = "Gets All Active CharacterStoryArcs")]
    public class GetCharacterStoryArcs : CharacterStoryArcSearchModelBase, IReturn<List<ICharacterStoryArcModel>> { }

    [Route("/CharacterStoryArcs/Listing", "GET", Summary = "Gets All Active CharacterStoryArcs with the mininum header information")]
    public class GetCharacterStoryArcsAsListing : CharacterStoryArcSearchModelBase, IReturn<List<ICharacterStoryArcModel>> { }

    [Route("/CharacterStoryArcs/{ID}", "GET", Summary = "Gets CharacterStoryArc by Identifier")]
    public class GetCharacterStoryArc : ImplementsID, IReturn<ICharacterStoryArcModel> { }

    [Route("/CharacterStoryArcs/{CustomKey}/ByKey", "GET", Summary = "Gets CharacterStoryArc by Key")]
    public class GetCharacterStoryArcByKey : ImplementsKey, IReturn<ICharacterStoryArcModel> { }

    //[Authenticate]
    [Route("/CharacterStoryArcs/Create", "POST", Summary = "Creates an CharacterStoryArc with these contents")]
    public class CreateCharacterStoryArc : CharacterStoryArcModelBase, IReturn<ICharacterStoryArcModel> { }

    //[Authenticate]
    [Route("/CharacterStoryArcs/Update", "POST", Summary = "Updates an CharacterStoryArc with new contents")]
    public class UpdateCharacterStoryArc : CharacterStoryArcModelBase, IReturn<ICharacterStoryArcModel> { }

    //[Authenticate]
    [Route("/CharacterStoryArcs/{ID}/Deactivate", "POST", Summary = "Deactivates an CharacterStoryArc by Identifier")]
    public class DeactivateCharacterStoryArc : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/CharacterStoryArcs/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an CharacterStoryArc by Key")]
    public class DeactivateCharacterStoryArcByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/CharacterStoryArcs/{ID}/Remove", "POST", Summary = "Removes an CharacterStoryArc by Identifier")]
    public class RemoveCharacterStoryArc : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/CharacterStoryArcs/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an CharacterStoryArc by Key")]
    public class RemoveCharacterStoryArcByKey : ImplementsKey, IReturn<bool> { }

    public interface ICharacterStoryArcsServices
    {
        List<ICharacterStoryArcModel> Any(GetCharacterStoryArcs request);
        List<ICharacterStoryArcModel> Any(GetCharacterStoryArcsAsListing request);
        ICharacterStoryArcModel Any(GetCharacterStoryArc request);
        ICharacterStoryArcModel Any(GetCharacterStoryArcByKey request);
        ICharacterStoryArcModel Any(CreateCharacterStoryArc request);
        ICharacterStoryArcModel Any(UpdateCharacterStoryArc request);
        bool Any(DeactivateCharacterStoryArc request);
        bool Any(DeactivateCharacterStoryArcByKey request);
        bool Any(RemoveCharacterStoryArc request);
        bool Any(RemoveCharacterStoryArcByKey request);
    }

    public class CharacterStoryArcsServices : Service, ICharacterStoryArcsServices
    {
        private readonly ICharacterStoryArcsBusinessWorkflow workflow;

        public CharacterStoryArcsServices(ICharacterStoryArcsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<ICharacterStoryArcModel> Any(GetCharacterStoryArcs request) { return workflow.Search(request); }
        public List<ICharacterStoryArcModel> Any(GetCharacterStoryArcsAsListing request) { return workflow.Search(request, true); }
        public ICharacterStoryArcModel Any(GetCharacterStoryArc request) { return workflow.Get(request.ID); }
        public ICharacterStoryArcModel Any(GetCharacterStoryArcByKey request) { return workflow.Get(request.CustomKey); }
        public ICharacterStoryArcModel Any(CreateCharacterStoryArc request) { return workflow.Create(request); }
        public ICharacterStoryArcModel Any(UpdateCharacterStoryArc request) { return workflow.Update(request); }
        public bool Any(DeactivateCharacterStoryArc request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateCharacterStoryArcByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveCharacterStoryArc request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveCharacterStoryArcByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
