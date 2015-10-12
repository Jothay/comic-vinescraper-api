// <auto-generated>
// <copyright file="Promos.IResourceTypeModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ResourceType model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Promos
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class ResourceTypeModelBase : NameableEntityModelBase, IResourceTypeModel
    {
        // ResourceType Properties
        public string DetailResourceName { get; set; }
        public string ListResourceName { get; set; }
        // Related Objects
        // <None>
        // Associated Objects
        public List<IPromoModel> Promos { get; set; }
    }
    public class ResourceTypeSearchModelBase : NameableEntitySearchModelBase, IResourceTypeSearchModel
    {
        // No ResourceType Search Properties
    }

    [Route("/ResourceTypes/", "GET", Summary = "Gets All Active ResourceTypes")]
    public class GetResourceTypes : ResourceTypeSearchModelBase, IReturn<List<IResourceTypeModel>> { }

    [Route("/ResourceTypes/Listing", "GET", Summary = "Gets All Active ResourceTypes with the mininum header information")]
    public class GetResourceTypesAsListing : ResourceTypeSearchModelBase, IReturn<List<IResourceTypeModel>> { }

    [Route("/ResourceTypes/{ID}", "GET", Summary = "Gets ResourceType by Identifier")]
    public class GetResourceType : ImplementsID, IReturn<IResourceTypeModel> { }

    [Route("/ResourceTypes/{CustomKey}/ByKey", "GET", Summary = "Gets ResourceType by Key")]
    public class GetResourceTypeByKey : ImplementsKey, IReturn<IResourceTypeModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ResourceTypes/Create", "POST", Summary = "Creates an ResourceType with these contents")]
    public class CreateResourceType : ResourceTypeModelBase, IReturn<IResourceTypeModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ResourceTypes/Update", "POST", Summary = "Updates an ResourceType with new contents")]
    public class UpdateResourceType : ResourceTypeModelBase, IReturn<IResourceTypeModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ResourceTypes/{ID}/Deactivate", "POST", Summary = "Deactivates an ResourceType by Identifier")]
    public class DeactivateResourceType : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ResourceTypes/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an ResourceType by Key")]
    public class DeactivateResourceTypeByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ResourceTypes/{ID}/Remove", "POST", Summary = "Removes an ResourceType by Identifier")]
    public class RemoveResourceType : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/ResourceTypes/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an ResourceType by Key")]
    public class RemoveResourceTypeByKey : ImplementsKey, IReturn<bool> { }

    public interface IResourceTypesServices
    {
        List<IResourceTypeModel> Any(GetResourceTypes request);
        List<IResourceTypeModel> Any(GetResourceTypesAsListing request);
        IResourceTypeModel Any(GetResourceType request);
        IResourceTypeModel Any(GetResourceTypeByKey request);
        IResourceTypeModel Any(CreateResourceType request);
        IResourceTypeModel Any(UpdateResourceType request);
        bool Any(DeactivateResourceType request);
        bool Any(DeactivateResourceTypeByKey request);
        bool Any(RemoveResourceType request);
        bool Any(RemoveResourceTypeByKey request);
    }

    public class ResourceTypesServices : Service, IResourceTypesServices
    {
        private readonly IResourceTypesBusinessWorkflow workflow;

        public ResourceTypesServices(IResourceTypesBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IResourceTypeModel> Any(GetResourceTypes request) { return workflow.Search(request); }
        public List<IResourceTypeModel> Any(GetResourceTypesAsListing request) { return workflow.Search(request, true); }
        public IResourceTypeModel Any(GetResourceType request) { return workflow.Get(request.ID); }
        public IResourceTypeModel Any(GetResourceTypeByKey request) { return workflow.Get(request.CustomKey); }
        public IResourceTypeModel Any(CreateResourceType request) { return workflow.Create(request); }
        public IResourceTypeModel Any(UpdateResourceType request) { return workflow.Update(request); }
        public bool Any(DeactivateResourceType request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateResourceTypeByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveResourceType request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveResourceTypeByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
