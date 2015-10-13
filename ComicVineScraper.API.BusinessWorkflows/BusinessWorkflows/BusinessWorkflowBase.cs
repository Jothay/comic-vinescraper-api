namespace ComicVineScraper.API.BusinessWorkflows
{
    using System;

    public static class BusinessWorkflowBase
    {
        public static DateTime GenDateTime => DateTime.Now;

        public static void ValidateRequiredID(int id)
        {
            if (id <= 0 || id == int.MaxValue)
            {
                throw new ArgumentNullException(nameof(id), "Must be set");
            }
            // Passed!
        }
        public static void ValidateRequiredNullableID(int? id)
        {
            if (!id.HasValue || id <= 0 || id == int.MaxValue)
            {
                throw new ArgumentNullException(nameof(id), "Must be set");
            }
            // Passed!
        }
        public static void ValidateIDIsNull(int? id)
        {
            if (id.HasValue && id > 0 && id != int.MaxValue)
            {
                throw new ArgumentException("Must be null", nameof(id));
            }
            // Passed!
        }
        public static void ValidateRequiredKey(string key)
        {
            ValidateRequiredString(key, nameof(key));
            // Passed!
        }
        // ReSharper disable once UnusedParameter.Global
        public static void ValidateRequiredString(string source, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentNullException(propertyName, "Must be set");
            }
            // Passed!
        }
    }
}
