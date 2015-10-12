// <auto-generated>
// <copyright file="Volumes.IVolumeWriterModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VolumeWriter model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Services//.Volumes
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class VolumeWriterModelBase : NameableEntityModelBase, IVolumeWriterModel
    {
        // VolumeWriter Properties
        // <None>
        // Related Objects
        public int VolumeId { get; set; }
        public IVolumeModel Volume { get; set; }
        public int WriterId { get; set; }
        public IPersonModel Writer { get; set; }
        // Associated Objects
        // <None>
    }
    public class VolumeWriterSearchModelBase : NameableEntitySearchModelBase, IVolumeWriterSearchModel
    {
        [ApiMember(Name = "VolumeId", IsRequired = false, Description = "Filter by the Related VolumeId")]
        public int? VolumeId { get; set; }

        [ApiMember(Name = "VolumeCustomKey", IsRequired = false, Description = "Filter by the Related Volume CustomKey (Equals, Case-Insensitive)")]
        public string VolumeCustomKey { get; set; }

        [ApiMember(Name = "VolumeApiDetailUrl", IsRequired = false, Description = "Filter by the Related Volume Api Detail Url (Contains, Case-Insensitive)")]
        public string VolumeApiDetailUrl { get; set; }

        [ApiMember(Name = "VolumeSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Volume Site Detail Url (Contains, Case-Insensitive)")]
        public string VolumeSiteDetailUrl { get; set; }

        [ApiMember(Name = "VolumeName", IsRequired = false, Description = "Filter by the Related Volume Name (Contains, Case-Insensitive)")]
        public string VolumeName { get; set; }

        [ApiMember(Name = "VolumeShortDescription", IsRequired = false, Description = "Filter by the Related Volume Short Description (Contains, Case-Insensitive)")]
        public string VolumeShortDescription { get; set; }

        [ApiMember(Name = "VolumeDescription", IsRequired = false, Description = "Filter by the Related Volume Description (Contains, Case-Insensitive)")]
        public string VolumeDescription { get; set; }

        [ApiMember(Name = "WriterId", IsRequired = false, Description = "Filter by the Related WriterId")]
        public int? WriterId { get; set; }

        [ApiMember(Name = "WriterCustomKey", IsRequired = false, Description = "Filter by the Related Writer CustomKey (Equals, Case-Insensitive)")]
        public string WriterCustomKey { get; set; }

        [ApiMember(Name = "WriterApiDetailUrl", IsRequired = false, Description = "Filter by the Related Writer Api Detail Url (Contains, Case-Insensitive)")]
        public string WriterApiDetailUrl { get; set; }

        [ApiMember(Name = "WriterSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Writer Site Detail Url (Contains, Case-Insensitive)")]
        public string WriterSiteDetailUrl { get; set; }

        [ApiMember(Name = "WriterName", IsRequired = false, Description = "Filter by the Related Writer Name (Contains, Case-Insensitive)")]
        public string WriterName { get; set; }

        [ApiMember(Name = "WriterShortDescription", IsRequired = false, Description = "Filter by the Related Writer Short Description (Contains, Case-Insensitive)")]
        public string WriterShortDescription { get; set; }

        [ApiMember(Name = "WriterDescription", IsRequired = false, Description = "Filter by the Related Writer Description (Contains, Case-Insensitive)")]
        public string WriterDescription { get; set; }

    }

    [Route("/VolumeWriters/", "GET", Summary = "Gets All Active VolumeWriters")]
    public class GetVolumeWriters : VolumeWriterSearchModelBase, IReturn<List<IVolumeWriterModel>> { }

    [Route("/VolumeWriters/Listing", "GET", Summary = "Gets All Active VolumeWriters with the mininum header information")]
    public class GetVolumeWritersAsListing : VolumeWriterSearchModelBase, IReturn<List<IVolumeWriterModel>> { }

    [Route("/VolumeWriters/{ID}", "GET", Summary = "Gets VolumeWriter by Identifier")]
    public class GetVolumeWriter : ImplementsID, IReturn<IVolumeWriterModel> { }

    [Route("/VolumeWriters/{CustomKey}/ByKey", "GET", Summary = "Gets VolumeWriter by Key")]
    public class GetVolumeWriterByKey : ImplementsKey, IReturn<IVolumeWriterModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/VolumeWriters/Create", "POST", Summary = "Creates an VolumeWriter with these contents")]
    public class CreateVolumeWriter : VolumeWriterModelBase, IReturn<IVolumeWriterModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/VolumeWriters/Update", "POST", Summary = "Updates an VolumeWriter with new contents")]
    public class UpdateVolumeWriter : VolumeWriterModelBase, IReturn<IVolumeWriterModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/VolumeWriters/{ID}/Deactivate", "POST", Summary = "Deactivates an VolumeWriter by Identifier")]
    public class DeactivateVolumeWriter : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/VolumeWriters/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an VolumeWriter by Key")]
    public class DeactivateVolumeWriterByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/VolumeWriters/{ID}/Remove", "POST", Summary = "Removes an VolumeWriter by Identifier")]
    public class RemoveVolumeWriter : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/VolumeWriters/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an VolumeWriter by Key")]
    public class RemoveVolumeWriterByKey : ImplementsKey, IReturn<bool> { }

    public interface IVolumeWritersServices
    {
        List<IVolumeWriterModel> Any(GetVolumeWriters request);
        List<IVolumeWriterModel> Any(GetVolumeWritersAsListing request);
        IVolumeWriterModel Any(GetVolumeWriter request);
        IVolumeWriterModel Any(GetVolumeWriterByKey request);
        IVolumeWriterModel Any(CreateVolumeWriter request);
        IVolumeWriterModel Any(UpdateVolumeWriter request);
        bool Any(DeactivateVolumeWriter request);
        bool Any(DeactivateVolumeWriterByKey request);
        bool Any(RemoveVolumeWriter request);
        bool Any(RemoveVolumeWriterByKey request);
    }

    public class VolumeWritersServices : Service, IVolumeWritersServices
    {
        private readonly IVolumeWritersBusinessWorkflow workflow;

        public VolumeWritersServices(IVolumeWritersBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IVolumeWriterModel> Any(GetVolumeWriters request) { return workflow.Search(request); }
        public List<IVolumeWriterModel> Any(GetVolumeWritersAsListing request) { return workflow.Search(request, true); }
        public IVolumeWriterModel Any(GetVolumeWriter request) { return workflow.Get(request.ID); }
        public IVolumeWriterModel Any(GetVolumeWriterByKey request) { return workflow.Get(request.CustomKey); }
        public IVolumeWriterModel Any(CreateVolumeWriter request) { return workflow.Create(request); }
        public IVolumeWriterModel Any(UpdateVolumeWriter request) { return workflow.Update(request); }
        public bool Any(DeactivateVolumeWriter request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivateVolumeWriterByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemoveVolumeWriter request) { return workflow.Remove(request.ID); }
        public bool Any(RemoveVolumeWriterByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
