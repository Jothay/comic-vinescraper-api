// <copyright file="StringIsUnicodeAttribute.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the string is unicode attribute class</summary>
namespace ComicVineScraper.API.DataModel
{
    using System;

    /// <summary>Attribute for string is unicode. This class cannot be inherited.</summary>
    /// <seealso cref="T:System.Attribute"/>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class StringIsUnicodeAttribute : System.Attribute
    {
        /// <summary>Initializes a new instance of the
        ///          Clarity.Ecommerce.DataModel.StringIsUnicodeAttribute class.</summary>
        /// <param name="isUnicode">true if this object is unicode, false if not.</param>
        public StringIsUnicodeAttribute(bool isUnicode)
        {
            IsUnicode = isUnicode;
        }

        /// <summary>Gets a value indicating whether this object is unicode.</summary>
        /// <value>true if this object is unicode, false if not.</value>
        public bool IsUnicode { get; }
    }
}
