// <copyright file="SearchableAttribute.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the searchable attribute class</summary>
// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace ComicVine.API.DataModel
{
    using System;

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class SearchableBooleanAttribute : Attribute
    {
        public SearchableBooleanAttribute()
        {
            SearchName = null;
            SearchDescription = null;
            TypeString = typeof(bool).ToString();
        }

        public SearchableBooleanAttribute(string searchName, string searchDescription)
        {
            SearchName = searchName;
            SearchDescription = searchDescription;
            TypeString = typeof(bool).ToString();
        }

        public string SearchName { get; }
        public string SearchDescription { get; }
        public string TypeString { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class SearchableIntAttribute : Attribute
    {
        public SearchableIntAttribute()
        {
            SearchName = null;
            SearchDescription = null;
            TypeString = typeof(int).ToString();
        }

        public SearchableIntAttribute(string searchName, string searchDescription)
        {
            SearchName = searchName;
            SearchDescription = searchDescription;
            TypeString = typeof(int).ToString();
        }

        public string SearchName { get; }
        public string SearchDescription { get; }
        public string TypeString { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class SearchableNullableIntAttribute : Attribute
    {
        public SearchableNullableIntAttribute()
        {
            SearchName = null;
            SearchDescription = null;
            TypeString = typeof(int?).ToString();
        }

        public SearchableNullableIntAttribute(string searchName, string searchDescription)
        {
            SearchName = searchName;
            SearchDescription = searchDescription;
            TypeString = typeof(int?).ToString();
        }

        public string SearchName { get; }
        public string SearchDescription { get; }
        public string TypeString { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class SearchableDecimalAttribute : Attribute
    {
        public SearchableDecimalAttribute()
        {
            SearchName = null;
            SearchDescription = null;
            TypeString = typeof(decimal).ToString();
        }

        public SearchableDecimalAttribute(string searchName, string searchDescription)
        {
            SearchName = searchName;
            SearchDescription = searchDescription;
            TypeString = typeof(decimal).ToString();
        }

        public string SearchName { get; }
        public string SearchDescription { get; }
        public string TypeString { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class SearchableNullableDecimalAttribute : Attribute
    {
        public SearchableNullableDecimalAttribute()
        {
            SearchName = null;
            SearchDescription = null;
            TypeString = typeof(decimal?).ToString();
        }

        public SearchableNullableDecimalAttribute(string searchName, string searchDescription)
        {
            SearchName = searchName;
            SearchDescription = searchDescription;
            TypeString = typeof(decimal?).ToString();
        }

        public string SearchName { get; }
        public string SearchDescription { get; }
        public string TypeString { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class SearchableStringAttribute : Attribute
    {
        public SearchableStringAttribute()
        {
            SearchName = null;
            SearchDescription = null;
            TypeString = typeof(string).ToString();
            ComparisonType = StringComparisonType.Contains;
        }

        //public SearchableStringAttribute(StringComparisonType comparisonType)
        //{
        //    SearchName = null;
        //    SearchDescription = null;
        //    TypeString = typeof(string).ToString();
        //    ComparisonType = comparisonType;
        //}

        //public SearchableStringAttribute(StringComparisonType comparisonType, string searchName, string searchDescription)
        //{
        //    SearchName = searchName;
        //    SearchDescription = searchDescription;
        //    TypeString = typeof(string).ToString();
        //    ComparisonType = comparisonType;
        //}

        public string SearchName { get; }
        public string SearchDescription { get; }
        public string TypeString { get; set; }

        public StringComparisonType ComparisonType { get; }
    }

    public enum StringComparisonType { Contains = 0, Equals = 1 }
}
