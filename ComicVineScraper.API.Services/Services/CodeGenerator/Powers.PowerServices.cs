// <auto-generated>
// <copyright file="Powers.IPowerServices.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the Power ServiceStack DTOs and Handlers.</summary>
// <remarks>This file was auto-generated using ServiceFileMaster.tt in
// ComicVineScraper.API.Services\Framework\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Services//.Powers
{
    using System;
    using System.Collections.Generic;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;
    using ServiceStack.DataAnnotations;

    public class PowerModelBase : NameableEntityModelBase, IPowerModel
    {
        // Power Properties
        // <None>
        // Related Objects
        // <None>
        // Associated Objects
        public List<ICharacterPowerModel> CharacterPowers { get; set; }
        public List<IPowerAliasModel> PowerAliases { get; set; }
    }
    public class PowerSearchModelBase : NameableEntitySearchModelBase, IPowerSearchModel
    {
        // No Power Search Properties
    }

    [Route("/Powers/", "GET", Summary = "Gets All Active Powers")]
    public class GetPowers : PowerSearchModelBase, IReturn<List<IPowerModel>> { }

    [Route("/Powers/Listing", "GET", Summary = "Gets All Active Powers with the mininum header information")]
    public class GetPowersAsListing : PowerSearchModelBase, IReturn<List<IPowerModel>> { }

    [Route("/Powers/{ID}", "GET", Summary = "Gets Power by Identifier")]
    public class GetPower : ImplementsID, IReturn<IPowerModel> { }

    [Route("/Powers/{CustomKey}/ByKey", "GET", Summary = "Gets Power by Key")]
    public class GetPowerByKey : ImplementsKey, IReturn<IPowerModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Powers/Create", "POST", Summary = "Creates an Power with these contents")]
    public class CreatePower : PowerModelBase, IReturn<IPowerModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Powers/Update", "POST", Summary = "Updates an Power with new contents")]
    public class UpdatePower : PowerModelBase, IReturn<IPowerModel> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Powers/{ID}/Deactivate", "POST", Summary = "Deactivates an Power by Identifier")]
    public class DeactivatePower : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Powers/{CustomKey}/DeactivateByKey", "POST", Summary = "Deactivates an Power by Key")]
    public class DeactivatePowerByKey : ImplementsKey, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Powers/{ID}/Remove", "POST", Summary = "Removes an Power by Identifier")]
    public class RemovePower : ImplementsID, IReturn<bool> { }

    [Authenticate][Exclude(Feature.Metadata)][Restrict(VisibilityTo = RequestAttributes.None)]
    [Route("/Powers/{CustomKey}/RemoveByKey", "POST", Summary = "Removes an Power by Key")]
    public class RemovePowerByKey : ImplementsKey, IReturn<bool> { }

    public interface IPowersServices
    {
        List<IPowerModel> Any(GetPowers request);
        List<IPowerModel> Any(GetPowersAsListing request);
        IPowerModel Any(GetPower request);
        IPowerModel Any(GetPowerByKey request);
        IPowerModel Any(CreatePower request);
        IPowerModel Any(UpdatePower request);
        bool Any(DeactivatePower request);
        bool Any(DeactivatePowerByKey request);
        bool Any(RemovePower request);
        bool Any(RemovePowerByKey request);
    }

    public class PowersServices : Service, IPowersServices
    {
        private readonly IPowersBusinessWorkflow workflow;

        public PowersServices(IPowersBusinessWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public List<IPowerModel> Any(GetPowers request) { return workflow.Search(request); }
        public List<IPowerModel> Any(GetPowersAsListing request) { return workflow.Search(request, true); }
        public IPowerModel Any(GetPower request) { return workflow.Get(request.ID); }
        public IPowerModel Any(GetPowerByKey request) { return workflow.Get(request.CustomKey); }
        public IPowerModel Any(CreatePower request) { return workflow.Create(request); }
        public IPowerModel Any(UpdatePower request) { return workflow.Update(request); }
        public bool Any(DeactivatePower request) { return workflow.Deactivate(request.ID); }
        public bool Any(DeactivatePowerByKey request) { return workflow.Deactivate(request.CustomKey); }
        public bool Any(RemovePower request) { return workflow.Remove(request.ID); }
        public bool Any(RemovePowerByKey request) { return workflow.Remove(request.CustomKey); }
    }
}
