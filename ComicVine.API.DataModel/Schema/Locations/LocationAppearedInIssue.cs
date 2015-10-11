// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Locations.LocationAppearedInIssue")]
    public class LocationAppearedInIssue : EntityBase, ILocationAppearedInIssue
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        ILocation ILocationAppearedInIssue.Location { get { return Location; } set { Location = value as Location; } }

        [InverseProperty("Id")][ForeignKey("AppearedInIssue")]
        public int AppearedInIssueId { get; set; }
        public virtual Issue AppearedInIssue { get; set; }
        IIssue ILocationAppearedInIssue.AppearedInIssue { get { return AppearedInIssue; } set { AppearedInIssue = value as Issue; } }
    }
}
