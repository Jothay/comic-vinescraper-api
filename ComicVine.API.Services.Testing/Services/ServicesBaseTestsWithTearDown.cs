namespace ComicVine.API.Testing.Services
{
    using System;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using ServiceStack;
    using ServiceStack.Testing;

    public abstract class ServiceTestsSetupTeardown : IDisposable
    {
        protected ServiceStackHost AppHost;
        public void Dispose()
        {
            AppHost.Dispose();
            AppHost = null;
        }
    }

    public partial class AllServicesTests : ServicesTestsWithTearDown { }

    public class ServicesTestsWithTearDown : ServiceTestsSetupTeardown
    {
        public ServicesTestsWithTearDown()
        {
            if (ServiceStackHost.Instance != null) { return; }
            try
            {
                AppHost = new BasicAppHost(typeof(PeopleServices).Assembly)
                {
                    ConfigureContainer = container => ConfigureContainer(container)
                }.Init();
            }
            catch (Exception)
            {
                // It's already set, use existing
                AppHost = ServiceStackHost.Instance;
                //AppHost.Configure(container);
            }
        }

        public static void ConfigureContainer(Funq.Container container)
        {
            //container.Register<IPersonMapper>(c => new PersonMapper());
            //container.Register<IModelEntities<Person>>(c => {
            //    Mock<IDbSet<Person>> mockAuthSet;
            //    return PeopleMockingSetup.DoMockingSetupForContext(true, out mockAuthSet).Object;
            //});
            //container.Register<IPeopleRepository>(c => {
            //    Mock<IDbSet<Person>> mockAuthSet;
            //    var mockContext = PeopleMockingSetup.DoMockingSetupForContext(true, out mockAuthSet);
            //    return PeopleMockingSetup.DoMockingSetupForRepository(ref mockContext).Object;
            //});
            #region Characters
            container.Register(c => CharactersMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ICharactersServices>(c => new CharactersServices(c.Resolve<ICharactersBusinessWorkflow>()));
            container.Register(c => CharacterAliasesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ICharacterAliasesServices>(c => new CharacterAliasesServices(c.Resolve<ICharacterAliasesBusinessWorkflow>()));
            container.Register(c => CharacterAppearedInIssuesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ICharacterAppearedInIssuesServices>(c => new CharacterAppearedInIssuesServices(c.Resolve<ICharacterAppearedInIssuesBusinessWorkflow>()));
            container.Register(c => CharacterCreatorsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ICharacterCreatorsServices>(c => new CharacterCreatorsServices(c.Resolve<ICharacterCreatorsBusinessWorkflow>()));
            container.Register(c => CharacterDiedInIssuesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ICharacterDiedInIssuesServices>(c => new CharacterDiedInIssuesServices(c.Resolve<ICharacterDiedInIssuesBusinessWorkflow>()));
            container.Register(c => CharacterEnemiesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ICharacterEnemiesServices>(c => new CharacterEnemiesServices(c.Resolve<ICharacterEnemiesBusinessWorkflow>()));
            container.Register(c => CharacterEnemyTeamsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ICharacterEnemyTeamsServices>(c => new CharacterEnemyTeamsServices(c.Resolve<ICharacterEnemyTeamsBusinessWorkflow>()));
            container.Register(c => CharacterFriendsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ICharacterFriendsServices>(c => new CharacterFriendsServices(c.Resolve<ICharacterFriendsBusinessWorkflow>()));
            container.Register(c => CharacterFriendlyTeamsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ICharacterFriendlyTeamsServices>(c => new CharacterFriendlyTeamsServices(c.Resolve<ICharacterFriendlyTeamsBusinessWorkflow>()));
            container.Register(c => CharacterIssuesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ICharacterIssuesServices>(c => new CharacterIssuesServices(c.Resolve<ICharacterIssuesBusinessWorkflow>()));
            container.Register(c => CharacterMoviesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ICharacterMoviesServices>(c => new CharacterMoviesServices(c.Resolve<ICharacterMoviesBusinessWorkflow>()));
            container.Register(c => CharacterPowersMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ICharacterPowersServices>(c => new CharacterPowersServices(c.Resolve<ICharacterPowersBusinessWorkflow>()));
            container.Register(c => CharacterStoryArcsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ICharacterStoryArcsServices>(c => new CharacterStoryArcsServices(c.Resolve<ICharacterStoryArcsBusinessWorkflow>()));
            container.Register(c => CharacterTeamsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ICharacterTeamsServices>(c => new CharacterTeamsServices(c.Resolve<ICharacterTeamsBusinessWorkflow>()));
            container.Register(c => CharacterVolumesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ICharacterVolumesServices>(c => new CharacterVolumesServices(c.Resolve<ICharacterVolumesBusinessWorkflow>()));
            #endregion
            #region Chats
            container.Register(c => ChatsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IChatsServices>(c => new ChatsServices(c.Resolve<IChatsBusinessWorkflow>()));
            #endregion
            #region Concepts
            container.Register(c => ConceptsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IConceptsServices>(c => new ConceptsServices(c.Resolve<IConceptsBusinessWorkflow>()));
            container.Register(c => ConceptAliasesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IConceptAliasesServices>(c => new ConceptAliasesServices(c.Resolve<IConceptAliasesBusinessWorkflow>()));
            container.Register(c => ConceptAppearedInIssuesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IConceptAppearedInIssuesServices>(c => new ConceptAppearedInIssuesServices(c.Resolve<IConceptAppearedInIssuesBusinessWorkflow>()));
            container.Register(c => ConceptIssuesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IConceptIssuesServices>(c => new ConceptIssuesServices(c.Resolve<IConceptIssuesBusinessWorkflow>()));
            container.Register(c => ConceptMoviesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IConceptMoviesServices>(c => new ConceptMoviesServices(c.Resolve<IConceptMoviesBusinessWorkflow>()));
            container.Register(c => ConceptVolumesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IConceptVolumesServices>(c => new ConceptVolumesServices(c.Resolve<IConceptVolumesBusinessWorkflow>()));
            #endregion
            #region Episodes
            container.Register(c => EpisodesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IEpisodesServices>(c => new EpisodesServices(c.Resolve<IEpisodesBusinessWorkflow>()));
            container.Register(c => EpisodeAliasesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IEpisodeAliasesServices>(c => new EpisodeAliasesServices(c.Resolve<IEpisodeAliasesBusinessWorkflow>()));
            container.Register(c => EpisodeCharactersMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IEpisodeCharactersServices>(c => new EpisodeCharactersServices(c.Resolve<IEpisodeCharactersBusinessWorkflow>()));
            container.Register(c => EpisodeCharactersDiedMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IEpisodeCharactersDiedServices>(c => new EpisodeCharactersDiedServices(c.Resolve<IEpisodeCharactersDiedBusinessWorkflow>()));
            container.Register(c => EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IEpisodeCharacterFirstAppearancesServices>(c => new EpisodeCharacterFirstAppearancesServices(c.Resolve<IEpisodeCharacterFirstAppearancesBusinessWorkflow>()));
            container.Register(c => EpisodeConceptsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IEpisodeConceptsServices>(c => new EpisodeConceptsServices(c.Resolve<IEpisodeConceptsBusinessWorkflow>()));
            container.Register(c => EpisodeConceptFirstAppearancesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IEpisodeConceptFirstAppearancesServices>(c => new EpisodeConceptFirstAppearancesServices(c.Resolve<IEpisodeConceptFirstAppearancesBusinessWorkflow>()));
            container.Register(c => EpisodeLocationsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IEpisodeLocationsServices>(c => new EpisodeLocationsServices(c.Resolve<IEpisodeLocationsBusinessWorkflow>()));
            container.Register(c => EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IEpisodeLocationFirstAppearancesServices>(c => new EpisodeLocationFirstAppearancesServices(c.Resolve<IEpisodeLocationFirstAppearancesBusinessWorkflow>()));
            container.Register(c => EpisodeObjectsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IEpisodeObjectsServices>(c => new EpisodeObjectsServices(c.Resolve<IEpisodeObjectsBusinessWorkflow>()));
            container.Register(c => EpisodeObjectFirstAppearancesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IEpisodeObjectFirstAppearancesServices>(c => new EpisodeObjectFirstAppearancesServices(c.Resolve<IEpisodeObjectFirstAppearancesBusinessWorkflow>()));
            container.Register(c => EpisodePeopleMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IEpisodePeopleServices>(c => new EpisodePeopleServices(c.Resolve<IEpisodePeopleBusinessWorkflow>()));
            container.Register(c => EpisodeStoryArcsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IEpisodeStoryArcsServices>(c => new EpisodeStoryArcsServices(c.Resolve<IEpisodeStoryArcsBusinessWorkflow>()));
            container.Register(c => EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IEpisodeStoryArcFirstAppearancesServices>(c => new EpisodeStoryArcFirstAppearancesServices(c.Resolve<IEpisodeStoryArcFirstAppearancesBusinessWorkflow>()));
            container.Register(c => EpisodeTeamsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IEpisodeTeamsServices>(c => new EpisodeTeamsServices(c.Resolve<IEpisodeTeamsBusinessWorkflow>()));
            container.Register(c => EpisodeTeamFirstAppearancesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IEpisodeTeamFirstAppearancesServices>(c => new EpisodeTeamFirstAppearancesServices(c.Resolve<IEpisodeTeamFirstAppearancesBusinessWorkflow>()));
            #endregion
            #region Issues
            container.Register(c => IssuesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IIssuesServices>(c => new IssuesServices(c.Resolve<IIssuesBusinessWorkflow>()));
            container.Register(c => IssueAliasesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IIssueAliasesServices>(c => new IssueAliasesServices(c.Resolve<IIssueAliasesBusinessWorkflow>()));
            container.Register(c => IssueWritersMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IIssueWritersServices>(c => new IssueWritersServices(c.Resolve<IIssueWritersBusinessWorkflow>()));
            #endregion
            #region Locations
            container.Register(c => LocationsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ILocationsServices>(c => new LocationsServices(c.Resolve<ILocationsBusinessWorkflow>()));
            container.Register(c => LocationAliasesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ILocationAliasesServices>(c => new LocationAliasesServices(c.Resolve<ILocationAliasesBusinessWorkflow>()));
            container.Register(c => LocationAppearedInIssuesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ILocationAppearedInIssuesServices>(c => new LocationAppearedInIssuesServices(c.Resolve<ILocationAppearedInIssuesBusinessWorkflow>()));
            container.Register(c => LocationIssuesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ILocationIssuesServices>(c => new LocationIssuesServices(c.Resolve<ILocationIssuesBusinessWorkflow>()));
            container.Register(c => LocationMoviesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ILocationMoviesServices>(c => new LocationMoviesServices(c.Resolve<ILocationMoviesBusinessWorkflow>()));
            container.Register(c => LocationStoryArcsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ILocationStoryArcsServices>(c => new LocationStoryArcsServices(c.Resolve<ILocationStoryArcsBusinessWorkflow>()));
            container.Register(c => LocationVolumesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ILocationVolumesServices>(c => new LocationVolumesServices(c.Resolve<ILocationVolumesBusinessWorkflow>()));
            #endregion
            #region Media
            container.Register(c => ImageFilesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IImageFilesServices>(c => new ImageFilesServices(c.Resolve<IImageFilesBusinessWorkflow>()));
            #endregion
            #region Movies
            container.Register(c => MoviesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IMoviesServices>(c => new MoviesServices(c.Resolve<IMoviesBusinessWorkflow>()));
            container.Register(c => MovieCharactersMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IMovieCharactersServices>(c => new MovieCharactersServices(c.Resolve<IMovieCharactersBusinessWorkflow>()));
            container.Register(c => MovieConceptsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IMovieConceptsServices>(c => new MovieConceptsServices(c.Resolve<IMovieConceptsBusinessWorkflow>()));
            container.Register(c => MovieLocationsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IMovieLocationsServices>(c => new MovieLocationsServices(c.Resolve<IMovieLocationsBusinessWorkflow>()));
            container.Register(c => MovieObjectsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IMovieObjectsServices>(c => new MovieObjectsServices(c.Resolve<IMovieObjectsBusinessWorkflow>()));
            container.Register(c => MovieProducersMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IMovieProducersServices>(c => new MovieProducersServices(c.Resolve<IMovieProducersBusinessWorkflow>()));
            container.Register(c => MovieStoryArcsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IMovieStoryArcsServices>(c => new MovieStoryArcsServices(c.Resolve<IMovieStoryArcsBusinessWorkflow>()));
            container.Register(c => MovieStudiosMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IMovieStudiosServices>(c => new MovieStudiosServices(c.Resolve<IMovieStudiosBusinessWorkflow>()));
            container.Register(c => MovieTeamsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IMovieTeamsServices>(c => new MovieTeamsServices(c.Resolve<IMovieTeamsBusinessWorkflow>()));
            container.Register(c => MovieWritersMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IMovieWritersServices>(c => new MovieWritersServices(c.Resolve<IMovieWritersBusinessWorkflow>()));
            #endregion
            #region Object
            container.Register(c => ObjectsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IObjectsServices>(c => new ObjectsServices(c.Resolve<IObjectsBusinessWorkflow>()));
            container.Register(c => ObjectAliasesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IObjectAliasesServices>(c => new ObjectAliasesServices(c.Resolve<IObjectAliasesBusinessWorkflow>()));
            container.Register(c => ObjectAppearedInIssuesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IObjectAppearedInIssuesServices>(c => new ObjectAppearedInIssuesServices(c.Resolve<IObjectAppearedInIssuesBusinessWorkflow>()));
            container.Register(c => ObjectIssuesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IObjectIssuesServices>(c => new ObjectIssuesServices(c.Resolve<IObjectIssuesBusinessWorkflow>()));
            container.Register(c => ObjectMoviesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IObjectMoviesServices>(c => new ObjectMoviesServices(c.Resolve<IObjectMoviesBusinessWorkflow>()));
            container.Register(c => ObjectStoryArcsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IObjectStoryArcsServices>(c => new ObjectStoryArcsServices(c.Resolve<IObjectStoryArcsBusinessWorkflow>()));
            container.Register(c => ObjectVolumesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IObjectVolumesServices>(c => new ObjectVolumesServices(c.Resolve<IObjectVolumesBusinessWorkflow>()));
            #endregion
            #region Origins
            container.Register(c => OriginsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IOriginsServices>(c => new OriginsServices(c.Resolve<IOriginsBusinessWorkflow>()));
            container.Register(c => OriginProfilesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IOriginProfilesServices>(c => new OriginProfilesServices(c.Resolve<IOriginProfilesBusinessWorkflow>()));
            #endregion
            #region People
            container.Register(c => GendersMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IGendersServices>(c => new GendersServices(c.Resolve<IGendersBusinessWorkflow>()));
            container.Register(c => CreatorCharactersMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ICreatorCharactersServices>(c => new CreatorCharactersServices(c.Resolve<ICreatorCharactersBusinessWorkflow>()));
            container.Register(c => PeopleMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IPeopleServices>(c => new PeopleServices(c.Resolve<IPeopleBusinessWorkflow>()));
            container.Register(c => PersonAliasesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IPersonAliasesServices>(c => new PersonAliasesServices(c.Resolve<IPersonAliasesBusinessWorkflow>()));
            #endregion
            #region Powers
            container.Register(c => PowersMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IPowersServices>(c => new PowersServices(c.Resolve<IPowersBusinessWorkflow>()));
            container.Register(c => PowerAliasesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IPowerAliasesServices>(c => new PowerAliasesServices(c.Resolve<IPowerAliasesBusinessWorkflow>()));
            #endregion
            #region Profiles
            container.Register(c => ProfilesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IProfilesServices>(c => new ProfilesServices(c.Resolve<IProfilesBusinessWorkflow>()));
            #endregion
            #region Promos
            container.Register(c => PromosMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IPromosServices>(c => new PromosServices(c.Resolve<IPromosBusinessWorkflow>()));
            container.Register(c => ResourceTypesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IResourceTypesServices>(c => new ResourceTypesServices(c.Resolve<IResourceTypesBusinessWorkflow>()));
            #endregion
            #region Publishers
            container.Register(c => PublishersMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IPublishersServices>(c => new PublishersServices(c.Resolve<IPublishersBusinessWorkflow>()));
            container.Register(c => PublisherAliasesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IPublisherAliasesServices>(c => new PublisherAliasesServices(c.Resolve<IPublisherAliasesBusinessWorkflow>()));
            #endregion
            #region Series
            container.Register(c => SeriesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ISeriesServices>(c => new SeriesServices(c.Resolve<ISeriesBusinessWorkflow>()));
            container.Register(c => SeriesAliasesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ISeriesAliasesServices>(c => new SeriesAliasesServices(c.Resolve<ISeriesAliasesBusinessWorkflow>()));
            container.Register(c => SeriesCharactersMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ISeriesCharactersServices>(c => new SeriesCharactersServices(c.Resolve<ISeriesCharactersBusinessWorkflow>()));
            container.Register(c => SeriesLocationsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ISeriesLocationsServices>(c => new SeriesLocationsServices(c.Resolve<ISeriesLocationsBusinessWorkflow>()));
            #endregion
            #region StoryArcs
            container.Register(c => StoryArcsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IStoryArcsServices>(c => new StoryArcsServices(c.Resolve<IStoryArcsBusinessWorkflow>()));
            container.Register(c => StoryArcAliasesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IStoryArcAliasesServices>(c => new StoryArcAliasesServices(c.Resolve<IStoryArcAliasesBusinessWorkflow>()));
            container.Register(c => StoryArcIssuesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IStoryArcIssuesServices>(c => new StoryArcIssuesServices(c.Resolve<IStoryArcIssuesBusinessWorkflow>()));
            container.Register(c => StoryArcWritersMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IStoryArcWritersServices>(c => new StoryArcWritersServices(c.Resolve<IStoryArcWritersBusinessWorkflow>()));
            #endregion
            #region Studios
            container.Register(c => StudiosMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IStudiosServices>(c => new StudiosServices(c.Resolve<IStudiosBusinessWorkflow>()));
            #endregion
            #region Teams
            container.Register(c => TeamsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ITeamsServices>(c => new TeamsServices(c.Resolve<ITeamsBusinessWorkflow>()));
            container.Register(c => TeamAliasesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ITeamAliasesServices>(c => new TeamAliasesServices(c.Resolve<ITeamAliasesBusinessWorkflow>()));
            container.Register(c => TeamAppearedInIssuesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ITeamAppearedInIssuesServices>(c => new TeamAppearedInIssuesServices(c.Resolve<ITeamAppearedInIssuesBusinessWorkflow>()));
            container.Register(c => TeamCharacterEnemiesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ITeamCharacterEnemiesServices>(c => new TeamCharacterEnemiesServices(c.Resolve<ITeamCharacterEnemiesBusinessWorkflow>()));
            container.Register(c => TeamCharacterFriendsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ITeamCharacterFriendsServices>(c => new TeamCharacterFriendsServices(c.Resolve<ITeamCharacterFriendsBusinessWorkflow>()));
            container.Register(c => TeamDisbandedInIssuesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ITeamDisbandedInIssuesServices>(c => new TeamDisbandedInIssuesServices(c.Resolve<ITeamDisbandedInIssuesBusinessWorkflow>()));
            container.Register(c => TeamIssuesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ITeamIssuesServices>(c => new TeamIssuesServices(c.Resolve<ITeamIssuesBusinessWorkflow>()));
            container.Register(c => TeamMembersMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ITeamMembersServices>(c => new TeamMembersServices(c.Resolve<ITeamMembersBusinessWorkflow>()));
            container.Register(c => TeamMoviesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ITeamMoviesServices>(c => new TeamMoviesServices(c.Resolve<ITeamMoviesBusinessWorkflow>()));
            container.Register(c => TeamStoryArcsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ITeamStoryArcsServices>(c => new TeamStoryArcsServices(c.Resolve<ITeamStoryArcsBusinessWorkflow>()));
            container.Register(c => TeamVolumesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<ITeamVolumesServices>(c => new TeamVolumesServices(c.Resolve<ITeamVolumesBusinessWorkflow>()));
            #endregion
            #region Videos
            container.Register(c => VideosMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IVideosServices>(c => new VideosServices(c.Resolve<IVideosBusinessWorkflow>()));
            container.Register(c => VideoTypesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IVideoTypesServices>(c => new VideoTypesServices(c.Resolve<IVideoTypesBusinessWorkflow>()));
            #endregion
            #region Volumes
            container.Register(c => VolumesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IVolumesServices>(c => new VolumesServices(c.Resolve<IVolumesBusinessWorkflow>()));
            container.Register(c => VolumeAliasesMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IVolumeAliasesServices>(c => new VolumeAliasesServices(c.Resolve<IVolumeAliasesBusinessWorkflow>()));
            container.Register(c => VolumeCharactersMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IVolumeCharactersServices>(c => new VolumeCharactersServices(c.Resolve<IVolumeCharactersBusinessWorkflow>()));
            container.Register(c => VolumeConceptsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IVolumeConceptsServices>(c => new VolumeConceptsServices(c.Resolve<IVolumeConceptsBusinessWorkflow>()));
            container.Register(c => VolumeLocationsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IVolumeLocationsServices>(c => new VolumeLocationsServices(c.Resolve<IVolumeLocationsBusinessWorkflow>()));
            container.Register(c => VolumeObjectsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IVolumeObjectsServices>(c => new VolumeObjectsServices(c.Resolve<IVolumeObjectsBusinessWorkflow>()));
            container.Register(c => VolumeTeamsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IVolumeTeamsServices>(c => new VolumeTeamsServices(c.Resolve<IVolumeTeamsBusinessWorkflow>()));
            container.Register(c => VolumeWritersMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
            container.Register<IVolumeWritersServices>(c => new VolumeWritersServices(c.Resolve<IVolumeWritersBusinessWorkflow>()));
            #endregion
        }
    }
}
