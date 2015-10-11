// <auto-generated>
// <copyright file="Objects.IObjectStoryArcModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectStoryArc model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Objects
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;

    public class ObjectStoryArcModelBase : NameableEntityModelBase, IObjectStoryArcModel
    {
        // ObjectStoryArc Properties
        // <None>
        // Related Objects
        public int ObjectId { get; set; }
        public IObjectModel Object { get; set; }
        public int StoryArcId { get; set; }
        public IStoryArcModel StoryArc { get; set; }
        // Associated Objects
        // <None>
    }
    public class ObjectStoryArcSearchModelBase : NameableEntitySearchModelBase, IObjectStoryArcSearchModel
    {
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

    [Route("/ObjectStoryArcs/", "GET", Summary = "Gets All Active ObjectStoryArcs")]
    public class GetObjectStoryArcs : ObjectStoryArcSearchModelBase, IReturn<List<IObjectStoryArcModel>> { }

    [Route("/ObjectStoryArcs/Listing", "GET", Summary = "Gets All Active ObjectStoryArcs with the mininum header information")]
    public class GetObjectStoryArcsAsListing : ObjectStoryArcSearchModelBase, IReturn<List<IObjectStoryArcModel>> { }

    [Route("/ObjectStoryArcs/{ID}", "GET", Summary = "Gets ObjectStoryArc by Identifier")]
    public class GetObjectStoryArc : ImplementsID, IReturn<IObjectStoryArcModel> { }

    [Route("/ObjectStoryArcs/{CustomKey}/ByKey", "GET", Summary = "Gets ObjectStoryArc by Key")]
    public class GetObjectStoryArcByKey : ImplementsKey, IReturn<IObjectStoryArcModel> { }

    //[Authenticate]
    [Route("/ObjectStoryArcs/Create", "POST", Summary = "Creates an ObjectStoryArc with these contents")]
    public class CreateObjectStoryArc : ObjectStoryArcModelBase, IReturn<IObjectStoryArcModel> { }

    //[Authenticate]
    [Route("/ObjectStoryArcs/Update", "POST", Summary = "Updates an ObjectStoryArc with new contents")]
    public class UpdateObjectStoryArc : ObjectStoryArcModelBase, IReturn<IObjectStoryArcModel> { }

    //[Authenticate]
    [Route("/ObjectStoryArcs/{ID}/Deactivate", "POST", Summary = "Deactivates an ObjectStoryArc by Identifier")]
    public class DeactivateObjectStoryArc : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/ObjectStoryArcs/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an ObjectStoryArc by Key")]
    public class DeactivateObjectStoryArcByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/ObjectStoryArcs/{ID}/Remove", "POST", Summary = "Removes an ObjectStoryArc by Identifier")]
    public class RemoveObjectStoryArc : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/ObjectStoryArcs/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an ObjectStoryArc by Key")]
    public class RemoveObjectStoryArcByKey : ImplementsKey, IReturn<bool> { }

    public interface IObjectStoryArcsServices
    {
        List<IObjectStoryArcModel> Any(GetObjectStoryArcs request);
        List<IObjectStoryArcModel> Any(GetObjectStoryArcsAsListing request);
        IObjectStoryArcModel Any(GetObjectStoryArc request);
        IObjectStoryArcModel Any(GetObjectStoryArcByKey request);
        IObjectStoryArcModel Any(CreateObjectStoryArc request);
        IObjectStoryArcModel Any(UpdateObjectStoryArc request);
        bool Any(DeactivateObjectStoryArc request);
        bool Any(DeactivateObjectStoryArcByKey request);
        bool Any(RemoveObjectStoryArc request);
        bool Any(RemoveObjectStoryArcByKey request);
    }

    public class ObjectStoryArcsServices : /*ServicesBase,*/ IObjectStoryArcsServices
    {
        private readonly IObjectStoryArcsBusinessWorkflow workflow;

        public ObjectStoryArcsServices(IObjectStoryArcsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IObjectStoryArcModel> Any(GetObjectStoryArcs request) { return workflow.Search(request); }
        public List<IObjectStoryArcModel> Any(GetObjectStoryArcsAsListing request) { return workflow.Search(request, true); }
        public IObjectStoryArcModel Any(GetObjectStoryArc request) { return workflow.Get(request.ID); }
        public IObjectStoryArcModel Any(GetObjectStoryArcByKey request) { return workflow.Get(request.CustomKey); }
        public IObjectStoryArcModel Any(CreateObjectStoryArc request) { return workflow.Create(request); }
        public IObjectStoryArcModel Any(UpdateObjectStoryArc request) { return workflow.Update(request); }
        public bool Any(DeactivateObjectStoryArc request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateObjectStoryArcByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveObjectStoryArc request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveObjectStoryArcByKey request) { return workflow.Remove(request.CustomKey); }
    }
}