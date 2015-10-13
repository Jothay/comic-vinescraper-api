// <copyright file="DecimalPrecisionAttribute.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the decimal precision attribute class</summary>
namespace ComicVineScraper.API.DataModel
{
    using System;

    /// <summary>Attribute for decimal precision. This class cannot be inherited.</summary>
    /// <seealso cref="T:System.Attribute"/>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class DecimalPrecisionAttribute : Attribute
    {
        /// <summary>Initializes a new instance of the
        ///          Clarity.Ecommerce.DataModel.DecimalPrecisionAttribute class.</summary>
        /// <param name="precision">The precision.</param>
        /// <param name="scale">    The scale.</param>
        public DecimalPrecisionAttribute(byte precision, byte scale)
        {
            Precision = precision;
            Scale = scale;
        }

        /// <summary>Gets the precision.</summary>
        /// <value>The precision.</value>
        public byte Precision { get; }

        /// <summary>Gets the scale.</summary>
        /// <value>The scale.</value>
        public byte Scale { get; }
    }
}
