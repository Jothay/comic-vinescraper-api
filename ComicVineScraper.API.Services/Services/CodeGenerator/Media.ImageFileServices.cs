// <auto-generated>
// <copyright file="Media.IImageFileServices.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the ImageFile ServiceStack DTOs and Handlers.</summary>
// <remarks>This file was auto-generated using ServiceFileMaster.tt in
// ComicVineScraper.API.Services\Framework\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Services//.Media
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class ImageFileModelBase : NameableEntityModelBase, IImageFileModel
    {
        // ImageFile Properties
        // <None>
        // Related Objects
        // <None>
        // Associated Objects
        public List<ICharacterModel> Characters { get; set; }
        public List<IChatModel> Chats { get; set; }
        public List<IConceptModel> Concepts { get; set; }
        public List<IEpisodeModel> Episodes { get; set; }
        public List<IIssueModel> Issues { get; set; }
        public List<ILocationModel> Locations { get; set; }
        public List<IMovieModel> Movies { get; set; }
        public List<IObjectModel> Objects { get; set; }
        public List<IPersonModel> People { get; set; }
        public List<IPromoModel> Promos { get; set; }
        public List<IPublisherModel> Publishers { get; set; }
        public List<IStoryArcModel> StoryArcs { get; set; }
        public List<ITeamModel> Teams { get; set; }
        public List<IVideoModel> Videos { get; set; }
        public List<IVolumeModel> Volumes { get; set; }
    }
    public class ImageFileSearchModelBase : NameableEntitySearchModelBase, IImageFileSearchModel
    {
        // No ImageFile Search Properties
    }

    [Route("/ImageFiles/", "GET", Summary = "Gets All Active ImageFiles")]
    public class GetImageFiles : ImageFileSearchModelBase, IReturn<List<IImageFileModel>> { }

    [Route("/ImageFiles/Listing", "GET", Summary = "Gets All Active ImageFiles with the mininum header information")]
    public class GetImageFilesAsListing : ImageFileSearchModelBase, IReturn<List<IImageFileModel>> { }

    [Route("/ImageFiles/{ID}", "GET", Summary = "Gets ImageFile by Identifier")]
    public class GetImageFile : ImplementsID, IReturn<IImageFileModel> { }

    [Route("/ImageFiles/{CustomKey}/ByKey", "GET", Summary = "Gets ImageFile by Key")]
    public class GetImageFileByKey : ImplementsKey, IReturn<IImageFileModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ImageFiles/Create", "POST", Summary = "Creates an ImageFile with these contents")]
    public class CreateImageFile : ImageFileModelBase, IReturn<IImageFileModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ImageFiles/Update", "POST", Summary = "Updates an ImageFile with new contents")]
    public class UpdateImageFile : ImageFileModelBase, IReturn<IImageFileModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ImageFiles/{ID}/Deactivate", "POST", Summary = "Deactivates an ImageFile by Identifier")]
    public class DeactivateImageFile : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ImageFiles/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an ImageFile by Key")]
    public class DeactivateImageFileByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ImageFiles/{ID}/Remove", "POST", Summary = "Removes an ImageFile by Identifier")]
    public class RemoveImageFile : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ImageFiles/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an ImageFile by Key")]
    public class RemoveImageFileByKey : ImplementsKey, IReturn<bool> { }

    public interface IImageFilesServices
    {
        List<IImageFileModel> Any(GetImageFiles request);
        List<IImageFileModel> Any(GetImageFilesAsListing request);
        IImageFileModel Any(GetImageFile request);
        IImageFileModel Any(GetImageFileByKey request);
        IImageFileModel Any(CreateImageFile request);
        IImageFileModel Any(UpdateImageFile request);
        bool Any(DeactivateImageFile request);
        bool Any(DeactivateImageFileByKey request);
        bool Any(RemoveImageFile request);
        bool Any(RemoveImageFileByKey request);
    }

    public class ImageFilesServices : Service, IImageFilesServices
    {
        private readonly IImageFilesBusinessWorkflow workflow;

        public ImageFilesServices(IImageFilesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IImageFileModel> Any(GetImageFiles request) { return workflow.Search(request); }
        public List<IImageFileModel> Any(GetImageFilesAsListing request) { return workflow.Search(request, true); }
        public IImageFileModel Any(GetImageFile request) { return workflow.Get(request.ID); }
        public IImageFileModel Any(GetImageFileByKey request) { return workflow.Get(request.CustomKey); }
        public IImageFileModel Any(CreateImageFile request) { return workflow.Create(request); }
        public IImageFileModel Any(UpdateImageFile request) { return workflow.Update(request); }
        public bool Any(DeactivateImageFile request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateImageFileByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveImageFile request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveImageFileByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
