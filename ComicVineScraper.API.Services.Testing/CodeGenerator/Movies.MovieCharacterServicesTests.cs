// <auto-generated>
// <copyright file="Movies.IMovieCharacterServicesTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the MovieCharacters ServiceStack Services Tests.</summary>
// <remarks>This file was autogenerated using ServicesTestingFileMaster.tt in
// ComicVineScraper.API.Services.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Services//.Movies
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Moq;
    using Xunit;

    public static class MovieCharactersMockingSetup
    {
        public static Mock<IMovieCharactersBusinessWorkflow> DoMockingSetupForBusinessWorkflow()
        {
            var mockMovieCharactersBusinessWorkflow = new Mock<IMovieCharactersBusinessWorkflow>();
            // Mock Functions
            mockMovieCharactersBusinessWorkflow.Setup(m => m.Search(It.IsAny<IMovieCharacterSearchModel>(), It.IsAny<bool>())).Returns(() => new List<IMovieCharacterModel>());
            mockMovieCharactersBusinessWorkflow.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IMovieCharacterModel>().Object);
            mockMovieCharactersBusinessWorkflow.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IMovieCharacterModel>().Object);
            mockMovieCharactersBusinessWorkflow.Setup(m => m.Create(It.IsAny<IMovieCharacterModel>())).Returns(() => new Mock<IMovieCharacterModel>().Object);
            mockMovieCharactersBusinessWorkflow.Setup(m => m.Update(It.IsAny<IMovieCharacterModel>())).Returns(() => new Mock<IMovieCharacterModel>().Object);
            mockMovieCharactersBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<int>())).Returns(() => true);
            mockMovieCharactersBusinessWorkflow.Setup(m => m.Deactivate(It.IsAny<string>())).Returns(() => true);
            mockMovieCharactersBusinessWorkflow.Setup(m => m.Remove(It.IsAny<int>())).Returns(() => true);
            mockMovieCharactersBusinessWorkflow.Setup(m => m.Remove(It.IsAny<string>())).Returns(() => true);
            // Return
            return mockMovieCharactersBusinessWorkflow;
        }
    }

    //public class MovieCharactersServicesTests : ServicesTestsWithTearDown
    public partial class AllServicesTests
    {
        [Fact][Trait("Category", "MovieCharacters")]
        public void Verify_GetMovieCharacters_Should_ReturnAListOfMovieCharacterModels()
        {
            var service = AppHost.Container.Resolve<IMovieCharactersServices>();
            var response = service.Any(new GetMovieCharacters { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IMovieCharacterModel>>(response);
        }
        [Fact][Trait("Category", "MovieCharacters")]
        public void Verify_GetMovieCharactersAsListing_Should_ReturnAListOfMovieCharacterModels()
        {
            var service = AppHost.Container.Resolve<IMovieCharactersServices>();
            var response = service.Any(new GetMovieCharactersAsListing { Id = 1, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN",  ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IMovieCharacterModel>>(response);
        }
        [Fact][Trait("Category", "MovieCharacters")]
        public void Verify_GetMovieCharacter_Should_ReturnAnMovieCharacterModel()
        {
            var service = AppHost.Container.Resolve<IMovieCharactersServices>();
            var response = service.Any(new GetMovieCharacter { ID = 1 });
            Assert.Equal(nameof(IMovieCharacterModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "MovieCharacters")]
        public void Verify_GetMovieCharacterByKey_Should_ReturnAnMovieCharacterModel()
        {
            var service = AppHost.Container.Resolve<IMovieCharactersServices>();
            var response = service.Any(new GetMovieCharacterByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IMovieCharacterModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "MovieCharacters")]
        public void Verify_CreateMovieCharacter_Should_ReturnAnMovieCharacterModel()
        {
            var service = AppHost.Container.Resolve<IMovieCharactersServices>();
            var response = service.Any(new CreateMovieCharacter { CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IMovieCharacterModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "MovieCharacters")]
        public void Verify_UpdateMovieCharacter_Should_ReturnAnMovieCharacterModel()
        {
            var service = AppHost.Container.Resolve<IMovieCharactersServices>();
            var response = service.Any(new UpdateMovieCharacter { Id = 1 });
            Assert.Equal(nameof(IMovieCharacterModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact][Trait("Category", "MovieCharacters")]
        public void Verify_DeactivateMovieCharacter_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IMovieCharactersServices>();
            var response = service.Any(new DeactivateMovieCharacter { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "MovieCharacters")]
        public void Verify_DeactivateMovieCharacterByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IMovieCharactersServices>();
            var response = service.Any(new DeactivateMovieCharacterByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "MovieCharacters")]
        public void Verify_RemoveMovieCharacter_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IMovieCharactersServices>();
            var response = service.Any(new RemoveMovieCharacter { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact][Trait("Category", "MovieCharacters")]
        public void Verify_RemoveMovieCharacterByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IMovieCharactersServices>();
            var response = service.Any(new RemoveMovieCharacterByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}