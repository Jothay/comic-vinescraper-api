// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Publishers.Publisher")]
    public class Publisher : NameableEntityBase, IPublisher
    {
        public string LocationAddress { get; set; }
        public string LocationCity { get; set; }
        public string LocationState { get; set; }

        // Related Objects
        [InverseProperty("Id")][ForeignKey("PrimaryImageFile")]
        public int? PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IPublisher.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        // Associated Objects
        public virtual ICollection<Character> CharactersPublished { get; set; }
        public virtual ICollection<PublisherAlias> PublisherAliases { get; set; }
        public virtual ICollection<Series> SeriesPublished { get; set; }
        public virtual ICollection<StoryArc> StoryArcsPublished { get; set; }
        public virtual ICollection<Team> TeamsPublished { get; set; }
        public virtual ICollection<Volume> VolumesPublished { get; set; }

        ICollection<ICharacter> IPublisher.CharactersPublished { get { return (ICollection<ICharacter>)CharactersPublished; } set { CharactersPublished = value as ICollection<Character>; } }
        ICollection<IPublisherAlias> IPublisher.PublisherAliases { get { return (ICollection<IPublisherAlias>)PublisherAliases; } set { PublisherAliases = value as ICollection<PublisherAlias>; } }
        ICollection<ISeries> IPublisher.SeriesPublished { get { return (ICollection<ISeries>)SeriesPublished; } set { SeriesPublished = value as ICollection<Series>; } }
        ICollection<IStoryArc> IPublisher.StoryArcsPublished { get { return (ICollection<IStoryArc>)StoryArcsPublished; } set { StoryArcsPublished = value as ICollection<StoryArc>; } }
        ICollection<ITeam> IPublisher.TeamsPublished { get { return (ICollection<ITeam>)TeamsPublished; } set { TeamsPublished = value as ICollection<Team>; } }
        ICollection<IVolume> IPublisher.VolumesPublished { get { return (ICollection<IVolume>)VolumesPublished; } set { VolumesPublished = value as ICollection<Volume>; } }
    }
}
