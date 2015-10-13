namespace ComicVine.API.Mappings
{
    using System.Linq;

    /// <summary>An entity mapper helper.</summary>
    public static class EntityMapperHelper
    {
        /// <summary>Allowed map depth.</summary>
        /// <param name="type">The type.</param>
        /// <returns>An int.</returns>
        public static int AllowedMapDepth(System.Type type)
        {
            var attrs = type.GetCustomAttributes(typeof(DataModel.MapDepthAllowedAttribute), true)
                .Cast<DataModel.MapDepthAllowedAttribute>()
                .ToArray();
            return !attrs.Any() ? 1 : attrs.Max(a => a.Depth);
        }

        /// <summary>Allowed map lite depth.</summary>
        /// <param name="type">The type.</param>
        /// <returns>An int.</returns>
        public static int AllowedMapLiteDepth(System.Type type)
        {
            var attrs = type.GetCustomAttributes(typeof(DataModel.MapLiteDepthAllowedAttribute), true)
                .Cast<DataModel.MapLiteDepthAllowedAttribute>()
                .ToArray();
            return !attrs.Any() ? 0 : attrs.Max(a => a.Depth);
        }

        /// <summary>Allowed map listing depth.</summary>
        /// <param name="type">The type.</param>
        /// <returns>An int.</returns>
        public static int AllowedMapListingDepth(System.Type type)
        {
            var attrs = type.GetCustomAttributes(typeof(DataModel.MapListingDepthAllowedAttribute), true)
                .Cast<DataModel.MapListingDepthAllowedAttribute>()
                .ToArray();
            return !attrs.Any() ? 0 : attrs.Max(a => a.Depth);
        }
    }
}
