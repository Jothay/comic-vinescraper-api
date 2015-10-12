// <auto-generated>
// <copyright file="Chats.IChatServices.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ChatsRepository Class.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in ComicVine.API.Services.Testing\Services\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Services//.Chats
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class ChatsMockingSetup
    {
        public static Mock<IChatsBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockChatsBusinessWorkflow = new Mock<IChatsBusinessWorkflow>();
            // Mock Functions
            mockChatsBusinessWorkflow.Setup(m => m.Search(It.IsAny<IChatSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IChatModel>());
            mockChatsBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IChatModel>().Object);
            mockChatsBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IChatModel>().Object);
            mockChatsBusinessWorkflow.Setup(m => m.Create(It.IsAny<IChatModel>())).Returns(() => new Mock<IChatModel>().Object);
            mockChatsBusinessWorkflow.Setup(m => m.Update(It.IsAny<IChatModel>())).Returns(() => new Mock<IChatModel>().Object);
            mockChatsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockChatsBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockChatsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockChatsBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockChatsBusinessWorkflow;
        }
    }

    //public class ChatsServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "Chats")]
        public void Verify_GetChats_Should_ReturnAListOfChatModels()
        {
            var service = AppHost.Container.Resolve<IChatsServices>();
            var response = service.Any(new GetChats { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = null, ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IChatModel>>(response);
        }
        [Fact][Trait("Category", "Chats")]
        public void Verify_GetChatsAsListing_Should_ReturnAListOfChatModels()
        {
            var service = AppHost.Container.Resolve<IChatsServices>();
            var response = service.Any(new GetChatsAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = "famous", ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IChatModel>>(response);
        }
        [Fact][Trait("Category", "Chats")]
        public void Verify_GetChat_Should_ReturnAnChatModel()
        {
            var service = AppHost.Container.Resolve<IChatsServices>();
            var response = service.Any(new GetChat { ID = 1 });
            Assert.Equal(nameof(IChatModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Chats")]
        public void Verify_GetChatByKey_Should_ReturnAnChatModel()
        {
            var service = AppHost.Container.Resolve<IChatsServices>();
            var response = service.Any(new GetChatByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IChatModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Chats")]
        public void Verify_CreateChat_Should_ReturnAnChatModel()
        {
            var service = AppHost.Container.Resolve<IChatsServices>();
            var response = service.Any(new CreateChat { Name = "Stephen King", CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IChatModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Chats")]
        public void Verify_UpdateChat_Should_ReturnAnChatModel()
        {
            var service = AppHost.Container.Resolve<IChatsServices>();
            var response = service.Any(new UpdateChat { Id = 1 });
            Assert.Equal(nameof(IChatModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "Chats")]
        public void Verify_DeactivateChat_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IChatsServices>();
            var response = service.Any(new DeactivateChat { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Chats")]
        public void Verify_DeactivateChatByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IChatsServices>();
            var response = service.Any(new DeactivateChatByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Chats")]
        public void Verify_RemoveChat_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IChatsServices>();
            var response = service.Any(new RemoveChat { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "Chats")]
        public void Verify_RemoveChatByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IChatsServices>();
            var response = service.Any(new RemoveChatByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
