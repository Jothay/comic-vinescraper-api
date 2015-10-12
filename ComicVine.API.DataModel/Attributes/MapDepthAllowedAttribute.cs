namespace ComicVine.API.DataModel
{
    using System;

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class MapDepthAllowedAttribute : Attribute
    {
        public MapDepthAllowedAttribute() { }

        public int Depth { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class MapLiteDepthAllowedAttribute : Attribute
    {
        public MapLiteDepthAllowedAttribute() { }

        public int Depth { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class MapListingDepthAllowedAttribute : Attribute
    {
        public MapListingDepthAllowedAttribute() { }

        public int Depth { get; set; }
    }
}
