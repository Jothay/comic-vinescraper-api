// <copyright file="Assisting.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the assisting classes</summary>
// <remarks>This file assists the T4 template code generation throughout the solution</remarks>
// ReSharper disable InconsistentNaming, UnusedAutoPropertyAccessor.Global, UnusedMember.Global
namespace ComicVine.API.CodeGenerator
{
    using System.Collections.Generic;

    public struct propertyInfo
    {
        public string name { get; set; }
        public string type { get; set; }
        public bool isNameable { get; set; }
        public bool isContactable { get; set; }
        public bool isAttributable { get; set; }
        public bool isFilterable { get; set; }
        public string filterName { get; set; }
        public string filterDescription { get; set; }
    }

    public struct classInfo
    {
        public string name { get; set; }
        public List<propertyInfo> properties { get; set; }
        public string baseClassName { get; set; }
        public bool isAttributable { get; set; }
    }
}
