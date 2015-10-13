// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Locations.LocationIssue")]
    public class LocationIssue : EntityBase, ILocationIssue
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        ILocation ILocationIssue.Location { get { return Location; } set { Location = value as Location; } }

        [InverseProperty("Id")][ForeignKey("Issue")]
        public int IssueId { get; set; }
        public virtual Issue Issue { get; set; }
        IIssue ILocationIssue.Issue { get { return Issue; } set { Issue = value as Issue; } }
    }
}
