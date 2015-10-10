// ReSharper disable ClassNeverInstantiated.Global, UnusedAutoPropertyAccessor.Global
namespace ComicVine.API.Services.Authors
{
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;

    public class AuthorModelBase : NameableEntityModelBase, IAuthorModel { }
    public class AuthorSearchModelBase : NameableEntitySearchModelBase, IAuthorSearchModel { }

    [Route("/Authors/", "GET", Summary = "Gets All Active Authors")]
    public class GetAuthors : AuthorSearchModelBase, IReturn<List<IAuthorModel>> { }

    [Route("/Authors/Listing", "GET", Summary = "Gets All Active Authors with the mininum header information")]
    public class GetAuthorsAsListing : AuthorSearchModelBase, IReturn<List<IAuthorModel>> { }

    [Route("/Authors/{ID}", "GET", Summary = "Gets Author by Identifier")]
    public class GetAuthor : ImplementsID, IReturn<IAuthorModel> { }

    [Route("/Authors/{CustomKey}/ByKey", "GET", Summary = "Gets Author by Key")]
    public class GetAuthorByKey : ImplementsKey, IReturn<IAuthorModel> { }

    //[Authenticate]
    [Route("/Authors/Create", "POST", Summary = "Creates an Author with these contents")]
    public class CreateAuthor : AuthorModelBase, IReturn<IAuthorModel> { }

    //[Authenticate]
    [Route("/Authors/Update", "POST", Summary = "Updates an Author with new contents")]
    public class UpdateAuthor : AuthorModelBase, IReturn<IAuthorModel> { }

    //[Authenticate]
    [Route("/Authors/{ID}/Deactivate", "POST", Summary = "Deactivates an Author by Identifier")]
    public class DeactivateAuthor : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/Authors/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an Author by Key")]
    public class DeactivateAuthorByKey : ImplementsKey, IReturn<bool> { }

    //[Authenticate]
    [Route("/Authors/{ID}/Remove", "POST", Summary = "Removes an Author by Identifier")]
    public class RemoveAuthor : ImplementsID, IReturn<bool> { }

    //[Authenticate]
    [Route("/Authors/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an Author by Key")]
    public class RemoveAuthorByKey : ImplementsKey, IReturn<bool> { }

    public interface IAuthorsServices
    {
        List<IAuthorModel> Any(GetAuthors request);
        List<IAuthorModel> Any(GetAuthorsAsListing request);
        IAuthorModel Any(GetAuthor request);
        IAuthorModel Any(GetAuthorByKey request);
        IAuthorModel Any(CreateAuthor request);
        IAuthorModel Any(UpdateAuthor request);
        bool Any(DeactivateAuthor request);
        bool Any(DeactivateAuthorByKey request);
        bool Any(RemoveAuthor request);
        bool Any(RemoveAuthorByKey request);
    }

    public class AuthorsServices : /*ServicesBase,*/ IAuthorsServices
    {
        private readonly IAuthorsBusinessWorkflow workflow;

        public AuthorsServices(IAuthorsBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IAuthorModel> Any(GetAuthors request) { return workflow.Search(request); }
        public List<IAuthorModel> Any(GetAuthorsAsListing request) { return workflow.Search(request, true); }
        public IAuthorModel Any(GetAuthor request) { return workflow.Get(request.ID); }
        public IAuthorModel Any(GetAuthorByKey request) { return workflow.Get(request.CustomKey); }
        public IAuthorModel Any(CreateAuthor request) { return workflow.Create(request); }
        public IAuthorModel Any(UpdateAuthor request) { return workflow.Update(request); }
        public bool Any(DeactivateAuthor request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateAuthorByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveAuthor request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveAuthorByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
