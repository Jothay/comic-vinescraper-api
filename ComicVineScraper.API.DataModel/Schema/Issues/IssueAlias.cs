// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Issues.IssueAlias")]
    public class IssueAlias : NameableEntityBase, IIssueAlias
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Issue")]
        public int IssueId { get; set; }
        public virtual Issue Issue { get; set; }
        IIssue IIssueAlias.Issue { get { return Issue; } set { Issue = value as Issue; } }
    }
}
