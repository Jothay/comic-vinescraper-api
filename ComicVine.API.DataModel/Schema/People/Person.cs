// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("People.Person")]
    public class Person : NameableEntityBase, IPerson
    {
        public string Hometown { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public System.DateTime? BirthDate { get; set; }
        public System.DateTime? DeathDate { get; set; }

        // Related Objects
        [InverseProperty("Id")][ForeignKey("PrimaryImageFile")]
        public int PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IPerson.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        [InverseProperty("Id")][ForeignKey("Gender")]
        public int? GenderId { get; set; }
        public Gender Gender { get; set; }
        IGender IPerson.Gender { get { return Gender; } set { Gender = value as Gender; } }

        // Associated Objects
        public virtual ICollection<CreatorCharacter> CharactersCreated { get; set; }
        public virtual ICollection<PersonAlias> PersonAliases { get; set; }
        public virtual ICollection<IssueWriter> IssuesWritten { get; set; }
        public virtual ICollection<MovieProducer> MoviesProduced { get; set; }
        public virtual ICollection<MovieWriter> MoviesWritten { get; set; }
        public virtual ICollection<Promo> PromosWritten { get; set; }
        public virtual ICollection<StoryArcWriter> StoryArcsWritten { get; set; }
        public virtual ICollection<VolumeWriter> VolumesWritten { get; set; }

        ICollection<ICreatorCharacter> IPerson.CharactersCreated { get { return (ICollection<ICreatorCharacter>)CharactersCreated; } set { CharactersCreated = value as ICollection<CreatorCharacter>; } }
        ICollection<IIssueWriter> IPerson.IssuesWritten { get { return (ICollection<IIssueWriter>)IssuesWritten; } set { IssuesWritten = value as ICollection<IssueWriter>; } }
        ICollection<IMovieProducer> IPerson.MoviesProduced { get { return (ICollection<IMovieProducer>)MoviesProduced; } set { MoviesProduced = value as ICollection<MovieProducer>; } }
        ICollection<IMovieWriter> IPerson.MoviesWritten { get { return (ICollection<IMovieWriter>)MoviesWritten; } set { MoviesWritten = value as ICollection<MovieWriter>; } }
        ICollection<IPersonAlias> IPerson.PersonAliases { get { return (ICollection<IPersonAlias>)PersonAliases; } set { PersonAliases = value as ICollection<PersonAlias>; } }
        ICollection<IPromo> IPerson.PromosWritten { get { return (ICollection<IPromo>)PromosWritten; } set { PromosWritten = value as ICollection<Promo>; } }
        ICollection<IStoryArcWriter> IPerson.StoryArcsWritten { get { return (ICollection<IStoryArcWriter>)StoryArcsWritten; } set { StoryArcsWritten = value as ICollection<StoryArcWriter>; } }
        ICollection<IVolumeWriter> IPerson.VolumesWritten { get { return (ICollection<IVolumeWriter>)VolumesWritten; } set { VolumesWritten = value as ICollection<VolumeWriter>; } }
    }
}
