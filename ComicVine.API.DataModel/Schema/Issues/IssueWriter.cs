// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Issues.IssueWriter")]
    public class IssueWriter : EntityBase, IIssueWriter
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Issue")]
        public int IssueId { get; set; }
        public virtual Issue Issue { get; set; }
        IIssue IIssueWriter.Issue { get { return Issue; } set { Issue = value as Issue; } }

        [InverseProperty("Id")][ForeignKey("Writer")]
        public int WriterId { get; set; }
        public virtual Person Writer { get; set; }
        IPerson IIssueWriter.Writer { get { return Writer; } set { Writer = value as Person; } }
    }
}
