// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedMember.Global
namespace ComicVine.API.DataModel
{
    using System.Data.Entity;
    using Schema;

    public interface IModelEntitiesBase
        <TAuthor, TCharacter, TCharacterAlias, TChat, TConcept, TConceptAlias, TEpisode, TEpisodeAlias, TGender
        , TImageFile, TIssue, TIssueAlias, TLocation, TLocationAlias, TMovie, TObject, TObjectAlias, TOrigin
        , TPerson, TPersonAlias, TPower, TPowerAlias, TProducer, TProfile, TPromo, TPublisher, TPublisherAlias
        , TSeries, TSeriesAlias, TStoryArc, TStoryArcAlias, TStudio, TTeam, TTeamAlias, TResourceType, TVideo
        , TVideoType, TVolume, TVolumeAlias, TWriter>
        where TAuthor : Author
        where TCharacter : Character
        where TCharacterAlias : CharacterAlias
        where TChat : Chat
        where TConcept : Concept
        where TConceptAlias : ConceptAlias
        where TEpisode : Episode
        where TEpisodeAlias : EpisodeAlias
        where TGender : Gender
        where TImageFile : ImageFile
        where TIssue : Issue
        where TIssueAlias : IssueAlias
        where TLocation : Location
        where TLocationAlias : LocationAlias
        where TMovie : Movie
        where TObject : Object
        where TObjectAlias : ObjectAlias
        where TOrigin : Origin
        where TPerson : Person
        where TPersonAlias : PersonAlias
        where TPower : Power
        where TPowerAlias : PowerAlias
        where TProducer : Producer
        where TProfile : Profile
        where TPromo : Promo
        where TPublisher : Publisher
        where TPublisherAlias : PublisherAlias
        where TSeries : Series
        where TSeriesAlias : SeriesAlias
        where TStoryArc : StoryArc
        where TStoryArcAlias : StoryArcAlias
        where TStudio : Studio
        where TTeam : Team
        where TTeamAlias : TeamAlias
        where TResourceType : ResourceType
        where TVideo : Video
        where TVideoType : VideoType
        where TVolume : Volume
        where TVolumeAlias : VolumeAlias
        where TWriter : Writer
    {
        //IDbSet<TEntity> GetIDbSet<TEntity>() where TEntity : class;
        void SetModified(object entity);
        int SaveChanges();

        IDbSet<TAuthor> Authors { get; set; }
        IDbSet<TCharacter> Characters { get; set; }
        IDbSet<TCharacterAlias> CharacterAliases { get; set; }
        IDbSet<TChat> Chats { get; set; }
        IDbSet<TConcept> Concepts { get; set; }
        IDbSet<TConceptAlias> ConceptAliases { get; set; }
        IDbSet<TEpisode> Episodes { get; set; }
        IDbSet<TEpisodeAlias> EpisodeAliases { get; set; }
        IDbSet<TGender> Genders { get; set; }
        IDbSet<TImageFile> ImageFiles { get; set; }
        IDbSet<TIssue> Issues { get; set; }
        IDbSet<TIssueAlias> IssueAliases { get; set; }
        IDbSet<TLocation> Locations { get; set; }
        IDbSet<TLocationAlias> LocationAliases { get; set; }
        IDbSet<TMovie> Movies { get; set; }
        IDbSet<TObject> Objects { get; set; }
        IDbSet<TObjectAlias> ObjectAliases { get; set; }
        IDbSet<TOrigin> Origins { get; set; }
        IDbSet<TPerson> People { get; set; }
        IDbSet<TPersonAlias> PersonAliases { get; set; }
        IDbSet<TPower> Powers { get; set; }
        IDbSet<TPowerAlias> PowerAliases { get; set; }
        IDbSet<TProducer> Producers { get; set; }
        IDbSet<TProfile> Profiles { get; set; }
        IDbSet<TPromo> Promos { get; set; }
        IDbSet<TPublisher> Publishers { get; set; }
        IDbSet<TPublisherAlias> PublisherAliases { get; set; }
        IDbSet<TSeries> Series { get; set; }
        IDbSet<TSeriesAlias> SeriesAliases { get; set; }
        IDbSet<TStoryArc> StoryArcs { get; set; }
        IDbSet<TStoryArcAlias> StoryArcAliases { get; set; }
        IDbSet<TStudio> Studios { get; set; }
        IDbSet<TTeam> Teams { get; set; }
        IDbSet<TTeamAlias> TeamAliases { get; set; }
        IDbSet<TResourceType> ResourceTypes { get; set; }
        IDbSet<TVideo> Videos { get; set; }
        IDbSet<TVideoType> VideoTypes { get; set; }
        IDbSet<TVolume> Volumes { get; set; }
        IDbSet<TVolumeAlias> VolumeAliases { get; set; }
        IDbSet<TWriter> Writers { get; set; }
    }

    public interface IModelEntities : IModelEntitiesBase
        <Author, Character, CharacterAlias, Chat, Concept, ConceptAlias, Episode, EpisodeAlias, Gender
          , ImageFile, Issue, IssueAlias, Location, LocationAlias, Movie, Object, ObjectAlias, Origin
          , Person, PersonAlias, Power, PowerAlias, Producer, Profile, Promo, Publisher, PublisherAlias
          , Series, SeriesAlias, StoryArc, StoryArcAlias, Studio, Team, TeamAlias, ResourceType, Video
          , VideoType, Volume, VolumeAlias, Writer>
    {
    }

    public class ModelEntities : DbContext , IModelEntities
    {
        public ModelEntities() : base("name=ModelEntities") { }

        public ModelEntities(string connectionString) : base(connectionString)
        {
            //Database.SetInitializer(new Migrations.ModelDBInitializer());
        }

        public virtual IDbSet<Author> Authors { get; set; }
        public virtual IDbSet<Character> Characters { get; set; }
        public virtual IDbSet<CharacterAlias> CharacterAliases { get; set; }
        public virtual IDbSet<Chat> Chats { get; set; }
        public virtual IDbSet<Concept> Concepts { get; set; }
        public virtual IDbSet<ConceptAlias> ConceptAliases { get; set; }
        public virtual IDbSet<Episode> Episodes { get; set; }
        public virtual IDbSet<EpisodeAlias> EpisodeAliases { get; set; }
        public virtual IDbSet<Gender> Genders { get; set; }
        public virtual IDbSet<ImageFile> ImageFiles { get; set; }
        public virtual IDbSet<Issue> Issues { get; set; }
        public virtual IDbSet<IssueAlias> IssueAliases { get; set; }
        public virtual IDbSet<Location> Locations { get; set; }
        public virtual IDbSet<LocationAlias> LocationAliases { get; set; }
        public virtual IDbSet<Movie> Movies { get; set; }
        public virtual IDbSet<Object> Objects { get; set; }
        public virtual IDbSet<ObjectAlias> ObjectAliases { get; set; }
        public virtual IDbSet<Origin> Origins { get; set; }
        public virtual IDbSet<Person> People { get; set; }
        public virtual IDbSet<PersonAlias> PersonAliases { get; set; }
        public virtual IDbSet<Power> Powers { get; set; }
        public virtual IDbSet<PowerAlias> PowerAliases { get; set; }
        public virtual IDbSet<Producer> Producers { get; set; }
        public virtual IDbSet<Profile> Profiles { get; set; }
        public virtual IDbSet<Promo> Promos { get; set; }
        public virtual IDbSet<Publisher> Publishers { get; set; }
        public virtual IDbSet<PublisherAlias> PublisherAliases { get; set; }
        public virtual IDbSet<Series> Series { get; set; }
        public virtual IDbSet<SeriesAlias> SeriesAliases { get; set; }
        public virtual IDbSet<StoryArc> StoryArcs { get; set; }
        public virtual IDbSet<StoryArcAlias> StoryArcAliases { get; set; }
        public virtual IDbSet<Studio> Studios { get; set; }
        public virtual IDbSet<Team> Teams { get; set; }
        public virtual IDbSet<TeamAlias> TeamAliases { get; set; }
        public virtual IDbSet<ResourceType> ResourceTypes { get; set; }
        public virtual IDbSet<Video> Videos { get; set; }
        public virtual IDbSet<VideoType> VideoTypes { get; set; }
        public virtual IDbSet<Volume> Volumes { get; set; }
        public virtual IDbSet<VolumeAlias> VolumeAliases { get; set; }
        public virtual IDbSet<Writer> Writers { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    if (modelBuilder == null) { return; }
        //    // Do Relationships with Fluent API
        //}

        // For Mocking
        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
        //private Dictionary<Type, IDbSet<IEntity>> dbSets;
        //private Dictionary<Type, IDbSet<IEntity>> DbSets => dbSets
        //    ?? (dbSets = new Dictionary<Type, IDbSet<IEntity>>
        //    {
        //        { typeof(Author), (IDbSet<IEntity>)Authors }
        //    });
        //public IDbSet<T> GetIDbSet<T>()
        //    where T : class
        //{
        //    return (IDbSet<T>)DbSets[typeof(T)].Cast<T>();
        //}
    }
}
