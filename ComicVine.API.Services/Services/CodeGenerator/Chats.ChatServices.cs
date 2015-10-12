// <auto-generated>
// <copyright file="Chats.IChatModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Chat model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Chats
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class ChatModelBase : NameableEntityModelBase, IChatModel
    {
        // Chat Properties
        public string ChannelName { get; set; }
        public string PasswordHash { get; set; }
        // Related Objects
        public int ImageFileId { get; set; }
        public IImageFileModel ImageFile { get; set; }
        // Associated Objects
        // <None>
    }
    public class ChatSearchModelBase : NameableEntitySearchModelBase, IChatSearchModel
    {
        [ApiMember(Name = "ImageFileId", IsRequired = false, Description = "Filter by the Related ImageFileId")]
        public int? ImageFileId { get; set; }

        [ApiMember(Name = "ImageFileCustomKey", IsRequired = false, Description = "Filter by the Related ImageFile CustomKey (Equals, Case-Insensitive)")]
        public string ImageFileCustomKey { get; set; }

        [ApiMember(Name = "ImageFileApiDetailUrl", IsRequired = false, Description = "Filter by the Related ImageFile Api Detail Url (Contains, Case-Insensitive)")]
        public string ImageFileApiDetailUrl { get; set; }

        [ApiMember(Name = "ImageFileSiteDetailUrl", IsRequired = false, Description = "Filter by the Related ImageFile Site Detail Url (Contains, Case-Insensitive)")]
        public string ImageFileSiteDetailUrl { get; set; }

        [ApiMember(Name = "ImageFileName", IsRequired = false, Description = "Filter by the Related ImageFile Name (Contains, Case-Insensitive)")]
        public string ImageFileName { get; set; }

        [ApiMember(Name = "ImageFileShortDescription", IsRequired = false, Description = "Filter by the Related ImageFile Short Description (Contains, Case-Insensitive)")]
        public string ImageFileShortDescription { get; set; }

        [ApiMember(Name = "ImageFileDescription", IsRequired = false, Description = "Filter by the Related ImageFile Description (Contains, Case-Insensitive)")]
        public string ImageFileDescription { get; set; }

        [ApiMember(Name = "ChannelName", IsRequired = false, Description = "The ChannelName to search by. (Contains, Case-Insensitive)")]
        public string ChannelName { get; set; }

    }

    [Route("/Chats/", "GET", Summary = "Gets All Active Chats")]
    public class GetChats : ChatSearchModelBase, IReturn<List<IChatModel>> { }

    [Route("/Chats/Listing", "GET", Summary = "Gets All Active Chats with the mininum header information")]
    public class GetChatsAsListing : ChatSearchModelBase, IReturn<List<IChatModel>> { }

    [Route("/Chats/{ID}", "GET", Summary = "Gets Chat by Identifier")]
    public class GetChat : ImplementsID, IReturn<IChatModel> { }

    [Route("/Chats/{CustomKey}/ByKey", "GET", Summary = "Gets Chat by Key")]
    public class GetChatByKey : ImplementsKey, IReturn<IChatModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Chats/Create", "POST", Summary = "Creates an Chat with these contents")]
    public class CreateChat : ChatModelBase, IReturn<IChatModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Chats/Update", "POST", Summary = "Updates an Chat with new contents")]
    public class UpdateChat : ChatModelBase, IReturn<IChatModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Chats/{ID}/Deactivate", "POST", Summary = "Deactivates an Chat by Identifier")]
    public class DeactivateChat : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Chats/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an Chat by Key")]
    public class DeactivateChatByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Chats/{ID}/Remove", "POST", Summary = "Removes an Chat by Identifier")]
    public class RemoveChat : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Chats/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an Chat by Key")]
    public class RemoveChatByKey : ImplementsKey, IReturn<bool> { }

    public interface IChatsServices
    {
        List<IChatModel> Any(GetChats request);
        List<IChatModel> Any(GetChatsAsListing request);
        IChatModel Any(GetChat request);
        IChatModel Any(GetChatByKey request);
        IChatModel Any(CreateChat request);
        IChatModel Any(UpdateChat request);
        bool Any(DeactivateChat request);
        bool Any(DeactivateChatByKey request);
        bool Any(RemoveChat request);
        bool Any(RemoveChatByKey request);
    }

    public class ChatsServices : Service, IChatsServices
    {
        private readonly IChatsBusinessWorkflow workflow;

        public ChatsServices(IChatsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IChatModel> Any(GetChats request) { return workflow.Search(request); }
        public List<IChatModel> Any(GetChatsAsListing request) { return workflow.Search(request, true); }
        public IChatModel Any(GetChat request) { return workflow.Get(request.ID); }
        public IChatModel Any(GetChatByKey request) { return workflow.Get(request.CustomKey); }
        public IChatModel Any(CreateChat request) { return workflow.Create(request); }
        public IChatModel Any(UpdateChat request) { return workflow.Update(request); }
        public bool Any(DeactivateChat request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateChatByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveChat request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveChatByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
