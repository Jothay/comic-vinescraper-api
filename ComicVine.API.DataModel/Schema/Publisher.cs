namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Publisher")]
    public partial class Publisher : NameableEntityBase, IPublisher
    {
        public string LocationAddress { get; set; }
        public string LocationCity { get; set; }
        public string LocationState { get; set; }

        // Related Objects
        public int? PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IPublisher.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        // Associated Objects
        public virtual ICollection<Character> Characters { get; set; }
        public virtual ICollection<PublisherAlias> PublisherAliases { get; set; }
        public virtual ICollection<StoryArc> StoryArcs { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Volume> Volumes { get; set; }

        ICollection<ICharacter> IPublisher.Characters { get { return (ICollection<ICharacter>)Characters; } set { Characters = value as ICollection<Character>; } }
        ICollection<IPublisherAlias> IPublisher.PublisherAliases { get { return (ICollection<IPublisherAlias>)PublisherAliases; } set { PublisherAliases = value as ICollection<PublisherAlias>; } }
        ICollection<IStoryArc> IPublisher.StoryArcs { get { return (ICollection<IStoryArc>)StoryArcs; } set { StoryArcs = value as ICollection<StoryArc>; } }
        ICollection<ITeam> IPublisher.Teams { get { return (ICollection<ITeam>)Teams; } set { Teams = value as ICollection<Team>; } }
        ICollection<IVolume> IPublisher.Volumes { get { return (ICollection<IVolume>)Volumes; } set { Volumes = value as ICollection<Volume>; } }
    }
}
