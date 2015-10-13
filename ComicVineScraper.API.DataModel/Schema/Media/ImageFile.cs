// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Media.ImageFile")]
    public class ImageFile : NameableEntityBase, IImageFile
    {
        // Associated Objects
        public virtual ICollection<Character> Characters { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<Concept> Concepts { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<Object> Objects { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<Promo> Promos { get; set; }
        public virtual ICollection<Publisher> Publishers { get; set; }
        public virtual ICollection<StoryArc> StoryArcs { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
        public virtual ICollection<Volume> Volumes { get; set; }

        ICollection<ICharacter> IImageFile.Characters { get { return (ICollection<ICharacter>)Characters; } set { Characters = value as ICollection<Character>; } }
        ICollection<IChat> IImageFile.Chats { get { return (ICollection<IChat>)Chats; } set { Chats = value as ICollection<Chat>; } }
        ICollection<IConcept> IImageFile.Concepts { get { return (ICollection<IConcept>)Concepts; } set { Concepts = value as ICollection<Concept>; } }
        ICollection<IEpisode> IImageFile.Episodes { get { return (ICollection<IEpisode>)Episodes; } set { Episodes = value as ICollection<Episode>; } }
        ICollection<IIssue> IImageFile.Issues { get { return (ICollection<IIssue>)Issues; } set { Issues = value as ICollection<Issue>; } }
        ICollection<ILocation> IImageFile.Locations { get { return (ICollection<ILocation>)Locations; } set { Locations = value as ICollection<Location>; } }
        ICollection<IMovie> IImageFile.Movies { get { return (ICollection<IMovie>)Movies; } set { Movies = value as ICollection<Movie>; } }
        ICollection<IObject> IImageFile.Objects { get { return (ICollection<IObject>)Objects; } set { Objects = value as ICollection<Object>; } }
        ICollection<IPerson> IImageFile.People { get { return (ICollection<IPerson>)People; } set { People = value as ICollection<Person>; } }
        ICollection<IPromo> IImageFile.Promos { get { return (ICollection<IPromo>)Promos; } set { Promos = value as ICollection<Promo>; } }
        ICollection<IPublisher> IImageFile.Publishers { get { return (ICollection<IPublisher>)Publishers; } set { Publishers = value as ICollection<Publisher>; } }
        ICollection<IStoryArc> IImageFile.StoryArcs { get { return (ICollection<IStoryArc>)StoryArcs; } set { StoryArcs = value as ICollection<StoryArc>; } }
        ICollection<ITeam> IImageFile.Teams { get { return (ICollection<ITeam>)Teams; } set { Teams = value as ICollection<Team>; } }
        ICollection<IVideo> IImageFile.Videos { get { return (ICollection<IVideo>)Videos; } set { Videos = value as ICollection<Video>; } }
        ICollection<IVolume> IImageFile.Volumes { get { return (ICollection<IVolume>)Volumes; } set { Volumes = value as ICollection<Volume>; } }
    }
}
