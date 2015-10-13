// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedMember.Global
namespace ComicVine.API.DataModel
{
    using System.Data.Entity;
    using Schema;

    public interface IModelEntitiesBase
        <TCharacter, TCharacterAlias, TCharacterAppearedInIssue, TCharacterCreator, TCharacterDiedInIssue, TCharacterEnemy
        , TCharacterEnemyTeam, TCharacterFriend, TCharacterFriendlyTeam, TCharacterIssue, TCharacterMovie, TCharacterPower
        , TCharacterStoryArc, TCharacterTeam, TCharacterVolume
        , TChat
        , TConcept, TConceptAlias, TConceptAppearedInIssue, TConceptIssue, TConceptMovie, TConceptVolume
        , TEpisode, TEpisodeAlias, TEpisodeCharacter, TEpisodeCharacterDied, TEpisodeCharacterFirstAppearance, TEpisodeConcept
        , TEpisodeConceptFirstAppearance, TEpisodeLocation, TEpisodeLocationFirstAppearance, TEpisodeObject
        , TEpisodeObjectFirstAppearance, TEpisodePerson, TEpisodeStoryArc, TEpisodeStoryArcFirstAppearance, TEpisodeTeam
        , TEpisodeTeamFirstAppearance
        , TGender, TImageFile
        , TIssue, TIssueAlias, TIssueWriter
        , TLocation, TLocationAlias, TLocationAppearedInIssue, TLocationIssue, TLocationMovie, TLocationStoryArc, TLocationVolume
        , TMovie, TMovieCharacter, TMovieConcept, TMovieLocation, TMovieObject, TMovieProducer, TMovieStoryArc, TMovieStudio, TMovieTeam, TMovieWriter
        , TObject, TObjectAlias, TObjectAppearedInIssue, TObjectIssue, TObjectMovie, TObjectStoryArc, TObjectVolume
        , TOrigin, TOriginProfile
        , TPerson, TPersonAlias, TCreatorCharacter
        , TPower, TPowerAlias
        , TProfile
        , TPromo
        , TPublisher, TPublisherAlias
        , TSeries, TSeriesAlias, TSeriesCharacter, TSeriesLocation
        , TStoryArc, TStoryArcAlias, TStoryArcIssue, TStoryArcWriter
        , TStudio
        , TTeam, TTeamAlias, TTeamAppearedInIssue, TTeamCharacterEnemy, TTeamCharacterFriend, TTeamDisbandedInIssue, TTeamIssue
        , TTeamMember, TTeamMovie, TTeamStoryArc, TTeamVolume
        , TResourceType
        , TVideo, TVideoType
        , TVolume, TVolumeAlias, TVolumeCharacter, TVolumeConcept, TVolumeLocation, TVolumeObject, TVolumeTeam, TVolumeWriter>
        #region Characters
        where TCharacter : Character
        where TCharacterAlias : CharacterAlias
        where TCharacterAppearedInIssue : CharacterAppearedInIssue
        where TCharacterCreator : CharacterCreator
        where TCharacterDiedInIssue : CharacterDiedInIssue
        where TCharacterEnemy : CharacterEnemy
        where TCharacterEnemyTeam : CharacterEnemyTeam
        where TCharacterFriend : CharacterFriend
        where TCharacterFriendlyTeam : CharacterFriendlyTeam
        where TCharacterIssue : CharacterIssue
        where TCharacterMovie : CharacterMovie
        where TCharacterPower : CharacterPower
        where TCharacterStoryArc : CharacterStoryArc
        where TCharacterTeam : CharacterTeam
        where TCharacterVolume : CharacterVolume
        #endregion
        #region Chats
        where TChat : Chat
        #endregion
        #region Concepts
        where TConcept : Concept
        where TConceptAlias : ConceptAlias
        where TConceptAppearedInIssue : ConceptAppearedInIssue
        where TConceptIssue : ConceptIssue
        where TConceptMovie : ConceptMovie
        where TConceptVolume : ConceptVolume
        #endregion
        #region Episodes
        where TEpisode : Episode
        where TEpisodeAlias : EpisodeAlias
        where TEpisodeCharacter : EpisodeCharacter
        where TEpisodeCharacterDied : EpisodeCharacterDied
        where TEpisodeCharacterFirstAppearance : EpisodeCharacterFirstAppearance
        where TEpisodeConcept : EpisodeConcept
        where TEpisodeConceptFirstAppearance : EpisodeConceptFirstAppearance
        where TEpisodeLocation : EpisodeLocation
        where TEpisodeLocationFirstAppearance : EpisodeLocationFirstAppearance
        where TEpisodeObject : EpisodeObject
        where TEpisodeObjectFirstAppearance : EpisodeObjectFirstAppearance
        where TEpisodePerson : EpisodePerson
        where TEpisodeStoryArc : EpisodeStoryArc
        where TEpisodeStoryArcFirstAppearance : EpisodeStoryArcFirstAppearance
        where TEpisodeTeam : EpisodeTeam
        where TEpisodeTeamFirstAppearance : EpisodeTeamFirstAppearance
        #endregion
        #region Issues
        where TIssue : Issue
        where TIssueAlias : IssueAlias
        where TIssueWriter : IssueWriter
        #endregion
        #region Locations
        where TLocation : Location
        where TLocationAlias : LocationAlias
        where TLocationAppearedInIssue : LocationAppearedInIssue
        where TLocationIssue : LocationIssue
        where TLocationMovie : LocationMovie
        where TLocationStoryArc : LocationStoryArc
        where TLocationVolume : LocationVolume
        #endregion
        #region Media
        where TImageFile : ImageFile
        #endregion
        #region Movies
        where TMovie : Movie
        where TMovieCharacter : MovieCharacter
        where TMovieConcept : MovieConcept
        where TMovieLocation : MovieLocation
        where TMovieObject : MovieObject
        where TMovieProducer : MovieProducer
        where TMovieStoryArc : MovieStoryArc
        where TMovieStudio : MovieStudio
        where TMovieTeam : MovieTeam
        where TMovieWriter : MovieWriter
        #endregion
        #region Objects
        where TObject : Object
        where TObjectAlias : ObjectAlias
        where TObjectAppearedInIssue : ObjectAppearedInIssue
        where TObjectIssue : ObjectIssue
        where TObjectMovie : ObjectMovie
        where TObjectStoryArc : ObjectStoryArc
        where TObjectVolume : ObjectVolume
        #endregion
        #region Origins
        where TOrigin : Origin
        where TOriginProfile : OriginProfile
        #endregion
        #region People
        where TGender : Gender
        where TCreatorCharacter : CreatorCharacter
        where TPerson : Person
        where TPersonAlias : PersonAlias
        #endregion
        #region Powers
        where TPower : Power
        where TPowerAlias : PowerAlias
        #endregion
        #region Profiles
        where TProfile : Profile
        #endregion
        #region Promos
        where TPromo : Promo
        where TResourceType : ResourceType
        #endregion
        #region Publishers
        where TPublisher : Publisher
        where TPublisherAlias : PublisherAlias
        #endregion
        #region Series
        where TSeries : Series
        where TSeriesAlias : SeriesAlias
        where TSeriesCharacter : SeriesCharacter
        where TSeriesLocation : SeriesLocation
        #endregion
        #region StoryArcs
        where TStoryArc : StoryArc
        where TStoryArcAlias : StoryArcAlias
        where TStoryArcIssue : StoryArcIssue
        where TStoryArcWriter : StoryArcWriter
        #endregion
        #region Studios
        where TStudio : Studio
        #endregion
        #region Teams
        where TTeam : Team
        where TTeamAlias : TeamAlias
        where TTeamAppearedInIssue : TeamAppearedInIssue
        where TTeamCharacterEnemy : TeamCharacterEnemy
        where TTeamCharacterFriend : TeamCharacterFriend
        where TTeamDisbandedInIssue : TeamDisbandedInIssue
        where TTeamIssue : TeamIssue
        where TTeamMember : TeamMember
        where TTeamMovie : TeamMovie
        where TTeamStoryArc : TeamStoryArc
        where TTeamVolume : TeamVolume
        #endregion
        #region Videos
        where TVideo : Video
        where TVideoType : VideoType
        #endregion
        #region Volumes
        where TVolume : Volume
        where TVolumeAlias : VolumeAlias
        where TVolumeCharacter : VolumeCharacter
        where TVolumeConcept : VolumeConcept
        where TVolumeLocation : VolumeLocation
        where TVolumeObject : VolumeObject
        where TVolumeTeam : VolumeTeam
        where TVolumeWriter : VolumeWriter
        #endregion
    {
        //IDbSet<TEntity> GetIDbSet<TEntity>() where TEntity : class;
        void SetModified(object entity);
        int SaveChanges();

        #region Characters
        IDbSet<TCharacter> Characters { get; set; }
        IDbSet<TCharacterAlias> CharacterAliases { get; set; }
        IDbSet<TCharacterAppearedInIssue> CharacterAppearedInIssues { get; set; }
        IDbSet<TCharacterCreator> CharacterCreators { get; set; }
        IDbSet<TCharacterDiedInIssue> CharacterDiedInIssues { get; set; }
        IDbSet<TCharacterEnemy> CharacterEnemies { get; set; }
        IDbSet<TCharacterEnemyTeam> CharacterEnemyTeams { get; set; }
        IDbSet<TCharacterFriend> CharacterFriends { get; set; }
        IDbSet<TCharacterFriendlyTeam> CharacterFriendlyTeams { get; set; }
        IDbSet<TCharacterIssue> CharacterIssues { get; set; }
        IDbSet<TCharacterMovie> CharacterMovies { get; set; }
        IDbSet<TCharacterPower> CharacterPowers { get; set; }
        IDbSet<TCharacterStoryArc> CharacterStoryArcs { get; set; }
        IDbSet<TCharacterTeam> CharacterTeams { get; set; }
        IDbSet<TCharacterVolume> CharacterVolumes { get; set; }
        #endregion
        #region Chats
        IDbSet<TChat> Chats { get; set; }
        #endregion
        #region Concepts
        IDbSet<TConcept> Concepts { get; set; }
        IDbSet<TConceptAlias> ConceptAliases { get; set; }
        IDbSet<TConceptAppearedInIssue> ConceptAppearedInIssues { get; set; }
        IDbSet<TConceptIssue> ConceptIssues { get; set; }
        IDbSet<TConceptMovie> ConceptMovies { get; set; }
        IDbSet<TConceptVolume> ConceptVolumes { get; set; }
        #endregion
        #region Episodes
        IDbSet<TEpisode> Episodes { get; set; }
        IDbSet<TEpisodeAlias> EpisodeAliases { get; set; }
        IDbSet<TEpisodeCharacter> EpisodeCharacters { get; set; }
        IDbSet<TEpisodeCharacterDied> EpisodeCharactersDied { get; set; }
        IDbSet<TEpisodeCharacterFirstAppearance> EpisodeCharacterFirstAppearances { get; set; }
        IDbSet<TEpisodeConcept> EpisodeConcepts { get; set; }
        IDbSet<TEpisodeConceptFirstAppearance> EpisodeConceptFirstAppearances { get; set; }
        IDbSet<TEpisodeLocation> EpisodeLocations { get; set; }
        IDbSet<TEpisodeLocationFirstAppearance> EpisodeLocationFirstAppearances { get; set; }
        IDbSet<TEpisodeObject> EpisodeObjects { get; set; }
        IDbSet<TEpisodeObjectFirstAppearance> EpisodeObjectFirstAppearances { get; set; }
        IDbSet<TEpisodePerson> EpisodePeople { get; set; }
        IDbSet<TEpisodeStoryArc> EpisodeStoryArcs { get; set; }
        IDbSet<TEpisodeStoryArcFirstAppearance> EpisodeStoryArcFirstAppearances { get; set; }
        IDbSet<TEpisodeTeam> EpisodeTeams { get; set; }
        IDbSet<TEpisodeTeamFirstAppearance> EpisodeTeamFirstAppearances { get; set; }
        #endregion
        #region Issues
        IDbSet<TIssue> Issues { get; set; }
        IDbSet<TIssueAlias> IssueAliases { get; set; }
        IDbSet<TIssueWriter> IssueWriters { get; set; }
        #endregion
        #region Locations
        IDbSet<TLocation> Locations { get; set; }
        IDbSet<TLocationAlias> LocationAliases { get; set; }
        IDbSet<TLocationAppearedInIssue> LocationAppearedInIssues { get; set; }
        IDbSet<TLocationIssue> LocationIssues { get; set; }
        IDbSet<TLocationMovie> LocationMovies { get; set; }
        IDbSet<TLocationStoryArc> LocationStoryArcs { get; set; }
        IDbSet<TLocationVolume> LocationVolumes { get; set; }
        #endregion
        #region Media
        IDbSet<TImageFile> ImageFiles { get; set; }
        #endregion
        #region Movies
        IDbSet<TMovie> Movies { get; set; }
        IDbSet<TMovieCharacter> MovieCharacters { get; set; }
        IDbSet<TMovieConcept> MovieConcepts { get; set; }
        IDbSet<TMovieLocation> MovieLocations { get; set; }
        IDbSet<TMovieObject> MovieObjects { get; set; }
        IDbSet<TMovieProducer> MovieProducers { get; set; }
        IDbSet<TMovieStoryArc> MovieStoryArcs { get; set; }
        IDbSet<TMovieStudio> MovieStudios { get; set; }
        IDbSet<TMovieTeam> MovieTeams { get; set; }
        IDbSet<TMovieWriter> MovieWriters { get; set; }
        #endregion
        #region Object
        IDbSet<TObject> Objects { get; set; }
        IDbSet<TObjectAlias> ObjectAliases { get; set; }
        IDbSet<TObjectAppearedInIssue> ObjectAppearedInIssues { get; set; }
        IDbSet<TObjectIssue> ObjectIssues { get; set; }
        IDbSet<TObjectMovie> ObjectMovies { get; set; }
        IDbSet<TObjectStoryArc> ObjectStoryArcs { get; set; }
        IDbSet<TObjectVolume> ObjectVolumes { get; set; }
        #endregion
        #region Origins
        IDbSet<TOrigin> Origins { get; set; }
        IDbSet<TOriginProfile> OriginProfiles { get; set; }
        #endregion
        #region People
        IDbSet<TGender> Genders { get; set; }
        IDbSet<TCreatorCharacter> CreatorCharacters { get; set; }
        IDbSet<TPerson> People { get; set; }
        IDbSet<TPersonAlias> PersonAliases { get; set; }
        #endregion
        #region Powers
        IDbSet<TPower> Powers { get; set; }
        IDbSet<TPowerAlias> PowerAliases { get; set; }
        #endregion
        #region Profiles
        IDbSet<TProfile> Profiles { get; set; }
        #endregion
        #region Promos
        IDbSet<TPromo> Promos { get; set; }
        IDbSet<TResourceType> ResourceTypes { get; set; }
        #endregion
        #region Publishers
        IDbSet<TPublisher> Publishers { get; set; }
        IDbSet<TPublisherAlias> PublisherAliases { get; set; }
        #endregion
        #region Series
        IDbSet<TSeries> Series { get; set; }
        IDbSet<TSeriesAlias> SeriesAliases { get; set; }
        IDbSet<TSeriesCharacter> SeriesCharacters { get; set; }
        IDbSet<TSeriesLocation> SeriesLocations { get; set; }
        #endregion
        #region StoryArcs
        IDbSet<TStoryArc> StoryArcs { get; set; }
        IDbSet<TStoryArcAlias> StoryArcAliases { get; set; }
        IDbSet<TStoryArcIssue> StoryArcIssues { get; set; }
        IDbSet<TStoryArcWriter> StoryArcWriters { get; set; }
        #endregion
        #region Studio
        IDbSet<TStudio> Studios { get; set; }
        #endregion
        #region Teams
        IDbSet<TTeam> Teams { get; set; }
        IDbSet<TTeamAlias> TeamAliases { get; set; }
        IDbSet<TTeamAppearedInIssue> TeamAppearedInIssues { get; set; }
        IDbSet<TTeamCharacterEnemy> TeamCharacterEnemies { get; set; }
        IDbSet<TTeamCharacterFriend> TeamCharacterFriends { get; set; }
        IDbSet<TTeamDisbandedInIssue> TeamDisbandedInIssues { get; set; }
        IDbSet<TTeamIssue> TeamIssues { get; set; }
        IDbSet<TTeamMember> TeamMembers { get; set; }
        IDbSet<TTeamMovie> TeamMovies { get; set; }
        IDbSet<TTeamStoryArc> TeamStoryArcs { get; set; }
        IDbSet<TTeamVolume> TeamVolumes { get; set; }
        #endregion
        #region Videos
        IDbSet<TVideo> Videos { get; set; }
        IDbSet<TVideoType> VideoTypes { get; set; }
        #endregion
        #region Volumes
        IDbSet<TVolume> Volumes { get; set; }
        IDbSet<TVolumeAlias> VolumeAliases { get; set; }
        IDbSet<TVolumeCharacter> VolumeCharacters { get; set; }
        IDbSet<TVolumeConcept> VolumeConcepts { get; set; }
        IDbSet<TVolumeLocation> VolumeLocations { get; set; }
        IDbSet<TVolumeObject> VolumeObjects { get; set; }
        IDbSet<TVolumeTeam> VolumeTeams { get; set; }
        IDbSet<TVolumeWriter> VolumeWriters { get; set; }
        #endregion
    }

    public interface IModelEntities : IModelEntitiesBase
        <Character, CharacterAlias, CharacterAppearedInIssue, CharacterCreator, CharacterDiedInIssue, CharacterEnemy
        , CharacterEnemyTeam, CharacterFriend, CharacterFriendlyTeam, CharacterIssue, CharacterMovie, CharacterPower
        , CharacterStoryArc, CharacterTeam, CharacterVolume
        , Chat
        , Concept, ConceptAlias, ConceptAppearedInIssue, ConceptIssue, ConceptMovie, ConceptVolume
        , Episode, EpisodeAlias, EpisodeCharacter, EpisodeCharacterDied, EpisodeCharacterFirstAppearance, EpisodeConcept
        , EpisodeConceptFirstAppearance, EpisodeLocation, EpisodeLocationFirstAppearance, EpisodeObject
        , EpisodeObjectFirstAppearance, EpisodePerson, EpisodeStoryArc, EpisodeStoryArcFirstAppearance, EpisodeTeam
        , EpisodeTeamFirstAppearance
        , Gender, ImageFile
        , Issue, IssueAlias, IssueWriter
        , Location, LocationAlias, LocationAppearedInIssue, LocationIssue, LocationMovie, LocationStoryArc, LocationVolume
        , Movie, MovieCharacter, MovieConcept, MovieLocation, MovieObject, MovieProducer, MovieStoryArc, MovieStudio, MovieTeam, MovieWriter
        , Object, ObjectAlias, ObjectAppearedInIssue, ObjectIssue, ObjectMovie, ObjectStoryArc, ObjectVolume
        , Origin, OriginProfile
        , Person, PersonAlias, CreatorCharacter
        , Power, PowerAlias
        , Profile
        , Promo
        , Publisher, PublisherAlias
        , Series, SeriesAlias, SeriesCharacter, SeriesLocation
        , StoryArc, StoryArcAlias, StoryArcIssue, StoryArcWriter
        , Studio
        , Team, TeamAlias, TeamAppearedInIssue, TeamCharacterEnemy, TeamCharacterFriend, TeamDisbandedInIssue, TeamIssue
        , TeamMember, TeamMovie, TeamStoryArc, TeamVolume
        , ResourceType
        , Video, VideoType
        , Volume, VolumeAlias, VolumeCharacter, VolumeConcept, VolumeLocation, VolumeObject, VolumeTeam, VolumeWriter>
    {
    }

    // ReSharper disable once ClassWithVirtualMembersNeverInherited.Global
    public class ModelEntities : DbContext , IModelEntities
    {
        public ModelEntities() : base("name=ModelEntities") { }
        public ModelEntities(string connectionString) : base(connectionString) { /*Database.SetInitializer(new Migrations.ModelDBInitializer());*/ }

        #region Characters
        public virtual IDbSet<Character> Characters { get; set; }
        public virtual IDbSet<CharacterAlias> CharacterAliases { get; set; }
        public virtual IDbSet<CharacterAppearedInIssue> CharacterAppearedInIssues { get; set; }
        public virtual IDbSet<CharacterCreator> CharacterCreators { get; set; }
        public virtual IDbSet<CharacterDiedInIssue> CharacterDiedInIssues { get; set; }
        public virtual IDbSet<CharacterEnemy> CharacterEnemies { get; set; }
        public virtual IDbSet<CharacterEnemyTeam> CharacterEnemyTeams { get; set; }
        public virtual IDbSet<CharacterFriend> CharacterFriends { get; set; }
        public virtual IDbSet<CharacterFriendlyTeam> CharacterFriendlyTeams { get; set; }
        public virtual IDbSet<CharacterIssue> CharacterIssues { get; set; }
        public virtual IDbSet<CharacterMovie> CharacterMovies { get; set; }
        public virtual IDbSet<CharacterPower> CharacterPowers { get; set; }
        public virtual IDbSet<CharacterStoryArc> CharacterStoryArcs { get; set; }
        public virtual IDbSet<CharacterTeam> CharacterTeams { get; set; }
        public virtual IDbSet<CharacterVolume> CharacterVolumes { get; set; }
        #endregion
        #region Chats
        public virtual IDbSet<Chat> Chats { get; set; }
        #endregion
        #region Concepts
        public virtual IDbSet<Concept> Concepts { get; set; }
        public virtual IDbSet<ConceptAlias> ConceptAliases { get; set; }
        public virtual IDbSet<ConceptAppearedInIssue> ConceptAppearedInIssues { get; set; }
        public virtual IDbSet<ConceptIssue> ConceptIssues { get; set; }
        public virtual IDbSet<ConceptMovie> ConceptMovies { get; set; }
        public virtual IDbSet<ConceptVolume> ConceptVolumes { get; set; }
        #endregion
        #region Episodes
        public virtual IDbSet<Episode> Episodes { get; set; }
        public virtual IDbSet<EpisodeAlias> EpisodeAliases { get; set; }
        public virtual IDbSet<EpisodeCharacter> EpisodeCharacters { get; set; }
        public virtual IDbSet<EpisodeCharacterDied> EpisodeCharactersDied { get; set; }
        public virtual IDbSet<EpisodeCharacterFirstAppearance> EpisodeCharacterFirstAppearances { get; set; }
        public virtual IDbSet<EpisodeConcept> EpisodeConcepts { get; set; }
        public virtual IDbSet<EpisodeConceptFirstAppearance> EpisodeConceptFirstAppearances { get; set; }
        public virtual IDbSet<EpisodeLocation> EpisodeLocations { get; set; }
        public virtual IDbSet<EpisodeLocationFirstAppearance> EpisodeLocationFirstAppearances { get; set; }
        public virtual IDbSet<EpisodeObject> EpisodeObjects { get; set; }
        public virtual IDbSet<EpisodeObjectFirstAppearance> EpisodeObjectFirstAppearances { get; set; }
        public virtual IDbSet<EpisodePerson> EpisodePeople { get; set; }
        public virtual IDbSet<EpisodeStoryArc> EpisodeStoryArcs { get; set; }
        public virtual IDbSet<EpisodeStoryArcFirstAppearance> EpisodeStoryArcFirstAppearances { get; set; }
        public virtual IDbSet<EpisodeTeam> EpisodeTeams { get; set; }
        public virtual IDbSet<EpisodeTeamFirstAppearance> EpisodeTeamFirstAppearances { get; set; }
        #endregion
        #region Issues
        public virtual IDbSet<Issue> Issues { get; set; }
        public virtual IDbSet<IssueAlias> IssueAliases { get; set; }
        public virtual IDbSet<IssueWriter> IssueWriters { get; set; }
        #endregion
        #region Locations
        public virtual IDbSet<Location> Locations { get; set; }
        public virtual IDbSet<LocationAlias> LocationAliases { get; set; }
        public virtual IDbSet<LocationAppearedInIssue> LocationAppearedInIssues { get; set; }
        public virtual IDbSet<LocationIssue> LocationIssues { get; set; }
        public virtual IDbSet<LocationMovie> LocationMovies { get; set; }
        public virtual IDbSet<LocationStoryArc> LocationStoryArcs { get; set; }
        public virtual IDbSet<LocationVolume> LocationVolumes { get; set; }
        #endregion
        #region Media
        public virtual IDbSet<ImageFile> ImageFiles { get; set; }
        #endregion
        #region Movies
        public virtual IDbSet<Movie> Movies { get; set; }
        public virtual IDbSet<MovieCharacter> MovieCharacters { get; set; }
        public virtual IDbSet<MovieConcept> MovieConcepts { get; set; }
        public virtual IDbSet<MovieLocation> MovieLocations { get; set; }
        public virtual IDbSet<MovieObject> MovieObjects { get; set; }
        public virtual IDbSet<MovieProducer> MovieProducers { get; set; }
        public virtual IDbSet<MovieStoryArc> MovieStoryArcs { get; set; }
        public virtual IDbSet<MovieStudio> MovieStudios { get; set; }
        public virtual IDbSet<MovieTeam> MovieTeams { get; set; }
        public virtual IDbSet<MovieWriter> MovieWriters { get; set; }
        #endregion
        #region Object
        public virtual IDbSet<Object> Objects { get; set; }
        public virtual IDbSet<ObjectAlias> ObjectAliases { get; set; }
        public virtual IDbSet<ObjectAppearedInIssue> ObjectAppearedInIssues { get; set; }
        public virtual IDbSet<ObjectIssue> ObjectIssues { get; set; }
        public virtual IDbSet<ObjectMovie> ObjectMovies { get; set; }
        public virtual IDbSet<ObjectStoryArc> ObjectStoryArcs { get; set; }
        public virtual IDbSet<ObjectVolume> ObjectVolumes { get; set; }
        #endregion
        #region Origins
        public virtual IDbSet<Origin> Origins { get; set; }
        public virtual IDbSet<OriginProfile> OriginProfiles { get; set; }
        #endregion
        #region People
        public virtual IDbSet<Gender> Genders { get; set; }
        public virtual IDbSet<CreatorCharacter> CreatorCharacters { get; set; }
        public virtual IDbSet<Person> People { get; set; }
        public virtual IDbSet<PersonAlias> PersonAliases { get; set; }
        #endregion
        #region Powers
        public virtual IDbSet<Power> Powers { get; set; }
        public virtual IDbSet<PowerAlias> PowerAliases { get; set; }
        #endregion
        #region Profiles
        public virtual IDbSet<Profile> Profiles { get; set; }
        #endregion
        #region Promos
        public virtual IDbSet<Promo> Promos { get; set; }
        public virtual IDbSet<ResourceType> ResourceTypes { get; set; }
        #endregion
        #region Publishers
        public virtual IDbSet<Publisher> Publishers { get; set; }
        public virtual IDbSet<PublisherAlias> PublisherAliases { get; set; }
        #endregion
        #region Series
        public virtual IDbSet<Series> Series { get; set; }
        public virtual IDbSet<SeriesAlias> SeriesAliases { get; set; }
        public virtual IDbSet<SeriesCharacter> SeriesCharacters { get; set; }
        public virtual IDbSet<SeriesLocation> SeriesLocations { get; set; }
        #endregion
        #region StoryArcs
        public virtual IDbSet<StoryArc> StoryArcs { get; set; }
        public virtual IDbSet<StoryArcAlias> StoryArcAliases { get; set; }
        public virtual IDbSet<StoryArcIssue> StoryArcIssues { get; set; }
        public virtual IDbSet<StoryArcWriter> StoryArcWriters { get; set; }
        #endregion
        #region Studios
        public virtual IDbSet<Studio> Studios { get; set; }
        #endregion
        #region Teams
        public virtual IDbSet<Team> Teams { get; set; }
        public virtual IDbSet<TeamAlias> TeamAliases { get; set; }
        public virtual IDbSet<TeamAppearedInIssue> TeamAppearedInIssues { get; set; }
        public virtual IDbSet<TeamCharacterEnemy> TeamCharacterEnemies { get; set; }
        public virtual IDbSet<TeamCharacterFriend> TeamCharacterFriends { get; set; }
        public virtual IDbSet<TeamDisbandedInIssue> TeamDisbandedInIssues { get; set; }
        public virtual IDbSet<TeamIssue> TeamIssues { get; set; }
        public virtual IDbSet<TeamMember> TeamMembers { get; set; }
        public virtual IDbSet<TeamMovie> TeamMovies { get; set; }
        public virtual IDbSet<TeamStoryArc> TeamStoryArcs { get; set; }
        public virtual IDbSet<TeamVolume> TeamVolumes { get; set; }
        #endregion
        #region Videos
        public virtual IDbSet<Video> Videos { get; set; }
        public virtual IDbSet<VideoType> VideoTypes { get; set; }
        #endregion
        #region Volumes
        public virtual IDbSet<Volume> Volumes { get; set; }
        public virtual IDbSet<VolumeAlias> VolumeAliases { get; set; }
        public virtual IDbSet<VolumeCharacter> VolumeCharacters { get; set; }
        public virtual IDbSet<VolumeConcept> VolumeConcepts { get; set; }
        public virtual IDbSet<VolumeLocation> VolumeLocations { get; set; }
        public virtual IDbSet<VolumeObject> VolumeObjects { get; set; }
        public virtual IDbSet<VolumeTeam> VolumeTeams { get; set; }
        public virtual IDbSet<VolumeWriter> VolumeWriters { get; set; }
        #endregion

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
            //if (modelBuilder == null) { return; }
            // Do Relationships with Fluent API
            //#region Characters
            //modelBuilder.Entity<Character>().HasMany(e => e.CharacterCreators).WithMany(e => e.CharactersCreated);
            //#endregion
            //#region Movies
            //modelBuilder.Entity<Movie>().HasMany(e => e.WriterCredits).WithMany(e => e.Movies);
            //#endregion
            //#region Origins
            //modelBuilder.Entity<Origin>().HasMany(e => e.Profiles).WithMany(e => e.Origins);
            //#endregion
            //#region People
            //modelBuilder.Entity<Person>().HasMany(e => e.CharactersCreated).WithMany(e => e.Creators);
            //modelBuilder.Entity<Person>().HasMany(e => e.Movies).WithMany(e => e.WriterCredits);
            //#endregion
            //#region Profile
            //modelBuilder.Entity<Profile>().HasMany(e => e.Origins).WithMany(e => e.Profiles);
            //#endregion
        //}

        // For Mocking
        public virtual void SetModified(object entity) { Entry(entity).State = EntityState.Modified; }
    }
}
