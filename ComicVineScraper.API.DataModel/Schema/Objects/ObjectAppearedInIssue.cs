// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Objects.ObjectAppearedInIssue")]
    public class ObjectAppearedInIssue : EntityBase, IObjectAppearedInIssue
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Object")]
        public int ObjectId { get; set; }
        public virtual Object Object { get; set; }
        IObject IObjectAppearedInIssue.Object { get { return Object; } set { Object = value as Object; } }

        [InverseProperty("Id")][ForeignKey("AppearedInIssue")]
        public int AppearedInIssueId { get; set; }
        public virtual Issue AppearedInIssue { get; set; }
        IIssue IObjectAppearedInIssue.AppearedInIssue { get { return AppearedInIssue; } set { AppearedInIssue = value as Issue; } }
    }
}
