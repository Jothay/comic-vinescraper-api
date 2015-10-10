namespace ComicVine.API.Testing.Mocking
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using DataModel.Schema;
    using Moq;

    public static class AuthorsMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeAuthorData, out Mock<IDbSet<Author>> mockSetAuthors, bool markAnAuthorInactive = false)
        {
            var createDate = new DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetAuthors = new Mock<IDbSet<Author>>();
            var authorData = (!includeAuthorData ? new List<Author>() : new List<Author>
            {
                new Author { Id = 1, Active = !markAnAuthorInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", Name = "Stephen King", Description = "a famous novelist" },
                new Author { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", Name = "Larry Niven", Description = "a novelist" }
            }).AsQueryable();
            mockSetAuthors.As<IQueryable<Author>>().Setup(m => m.Provider).Returns(authorData.Provider);
            mockSetAuthors.As<IQueryable<Author>>().Setup(m => m.Expression).Returns(authorData.Expression);
            mockSetAuthors.As<IQueryable<Author>>().Setup(m => m.ElementType).Returns(authorData.ElementType);
            mockSetAuthors.As<IQueryable<Author>>().Setup(m => m.GetEnumerator()).Returns(authorData.GetEnumerator());
            mockContext.Setup(m => m.Authors).Returns(mockSetAuthors.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }
}
