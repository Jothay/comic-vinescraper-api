namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.IssueAlias")]
    public partial class IssueAlias : NameableEntityBase, IIssueAlias
    {
        public int IssueId { get; set; }
        public virtual Issue Issue { get; set; }
        IIssue IIssueAlias.Issue { get { return Issue; } set { Issue = value as Issue; } }
    }
}
