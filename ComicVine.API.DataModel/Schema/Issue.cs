﻿namespace ComicVine.API.DataModel.Schema
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Issue")]
    public partial class Issue : NameableEntityBase, IIssue
    {
        [SearchableBoolean]
        public bool HasStaffReview { get; set; }
        public DateTime? CoverDate { get; set; }
        public DateTime? StoreDate { get; set; }
        public string IssueNumber { get; set; }

        // Related Objects
        public int? PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IIssue.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }
        public int? VolumeId { get; set; }
        public virtual Volume Volume { get; set; }
        IVolume IIssue.Volume { get { return Volume; } set { Volume = value as Volume; } }

        // Associated Objects
        public virtual ICollection<IssueAlias> IssueAliases { get; set; }
        ICollection<IIssueAlias> IIssue.IssueAliases { get { return (ICollection<IIssueAlias>)IssueAliases; } set { IssueAliases = value as ICollection<IssueAlias>; } }
    }
}
