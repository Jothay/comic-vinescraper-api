namespace ComicVine.API.Repositories
{
    using StructureMap.Configuration.DSL;
    using DataModel;
    using Interfaces.Repositories;

    public class RepositoryRegistry  : Registry
    {
        public RepositoryRegistry()
        {
            // Context
            For<IModelEntities>().Use<ModelEntities>();
            #region Characters
            For<ICharactersRepository>().Use<CharactersRepository>();
            For<ICharacterAliasesRepository>().Use<CharacterAliasesRepository>();
            For<ICharacterAppearedInIssuesRepository>().Use<CharacterAppearedInIssuesRepository>();
            For<ICharacterCreatorsRepository>().Use<CharacterCreatorsRepository>();
            For<ICharacterDiedInIssuesRepository>().Use<CharacterDiedInIssuesRepository>();
            For<ICharacterEnemiesRepository>().Use<CharacterEnemiesRepository>();
            For<ICharacterEnemyTeamsRepository>().Use<CharacterEnemyTeamsRepository>();
            For<ICharacterFriendsRepository>().Use<CharacterFriendsRepository>();
            For<ICharacterFriendlyTeamsRepository>().Use<CharacterFriendlyTeamsRepository>();
            For<ICharacterIssuesRepository>().Use<CharacterIssuesRepository>();
            For<ICharacterMoviesRepository>().Use<CharacterMoviesRepository>();
            For<ICharacterPowersRepository>().Use<CharacterPowersRepository>();
            For<ICharacterStoryArcsRepository>().Use<CharacterStoryArcsRepository>();
            For<ICharacterTeamsRepository>().Use<CharacterTeamsRepository>();
            For<ICharacterVolumesRepository>().Use<CharacterVolumesRepository>();
            #endregion
            #region Chats
            For<IChatsRepository>().Use<ChatsRepository>();
            #endregion
            #region Concepts
            For<IConceptsRepository>().Use<ConceptsRepository>();
            For<IConceptAliasesRepository>().Use<ConceptAliasesRepository>();
            For<IConceptAppearedInIssuesRepository>().Use<ConceptAppearedInIssuesRepository>();
            For<IConceptIssuesRepository>().Use<ConceptIssuesRepository>();
            For<IConceptMoviesRepository>().Use<ConceptMoviesRepository>();
            For<IConceptVolumesRepository>().Use<ConceptVolumesRepository>();
            #endregion
            #region Episodes
            For<IEpisodesRepository>().Use<EpisodesRepository>();
            For<IEpisodeAliasesRepository>().Use<EpisodeAliasesRepository>();
            For<IEpisodeCharactersRepository>().Use<EpisodeCharactersRepository>();
            For<IEpisodeCharactersDiedRepository>().Use<EpisodeCharactersDiedRepository>();
            For<IEpisodeCharacterFirstAppearancesRepository>().Use<EpisodeCharacterFirstAppearancesRepository>();
            For<IEpisodeConceptsRepository>().Use<EpisodeConceptsRepository>();
            For<IEpisodeConceptFirstAppearancesRepository>().Use<EpisodeConceptFirstAppearancesRepository>();
            For<IEpisodeLocationsRepository>().Use<EpisodeLocationsRepository>();
            For<IEpisodeLocationFirstAppearancesRepository>().Use<EpisodeLocationFirstAppearancesRepository>();
            For<IEpisodeObjectsRepository>().Use<EpisodeObjectsRepository>();
            For<IEpisodeObjectFirstAppearancesRepository>().Use<EpisodeObjectFirstAppearancesRepository>();
            For<IEpisodePeopleRepository>().Use<EpisodePeopleRepository>();
            For<IEpisodeStoryArcsRepository>().Use<EpisodeStoryArcsRepository>();
            For<IEpisodeStoryArcFirstAppearancesRepository>().Use<EpisodeStoryArcFirstAppearancesRepository>();
            For<IEpisodeTeamsRepository>().Use<EpisodeTeamsRepository>();
            For<IEpisodeTeamFirstAppearancesRepository>().Use<EpisodeTeamFirstAppearancesRepository>();
            #endregion
            #region Issues
            For<IIssuesRepository>().Use<IssuesRepository>();
            For<IIssueAliasesRepository>().Use<IssueAliasesRepository>();
            For<IIssueWritersRepository>().Use<IssueWritersRepository>();
            #endregion
            #region Locations
            For<ILocationsRepository>().Use<LocationsRepository>();
            For<ILocationAliasesRepository>().Use<LocationAliasesRepository>();
            For<ILocationAppearedInIssuesRepository>().Use<LocationAppearedInIssuesRepository>();
            For<ILocationIssuesRepository>().Use<LocationIssuesRepository>();
            For<ILocationMoviesRepository>().Use<LocationMoviesRepository>();
            For<ILocationStoryArcsRepository>().Use<LocationStoryArcsRepository>();
            For<ILocationVolumesRepository>().Use<LocationVolumesRepository>();
            #endregion
            #region Media
            For<IImageFilesRepository>().Use<ImageFilesRepository>();
            #endregion
            #region Movies
            For<IMoviesRepository>().Use<MoviesRepository>();
            For<IMovieCharactersRepository>().Use<MovieCharactersRepository>();
            For<IMovieConceptsRepository>().Use<MovieConceptsRepository>();
            For<IMovieLocationsRepository>().Use<MovieLocationsRepository>();
            For<IMovieObjectsRepository>().Use<MovieObjectsRepository>();
            For<IMovieProducersRepository>().Use<MovieProducersRepository>();
            For<IMovieStoryArcsRepository>().Use<MovieStoryArcsRepository>();
            For<IMovieStudiosRepository>().Use<MovieStudiosRepository>();
            For<IMovieTeamsRepository>().Use<MovieTeamsRepository>();
            For<IMovieWritersRepository>().Use<MovieWritersRepository>();
            #endregion
            #region Object
            For<IObjectsRepository>().Use<ObjectsRepository>();
            For<IObjectAliasesRepository>().Use<ObjectAliasesRepository>();
            For<IObjectAppearedInIssuesRepository>().Use<ObjectAppearedInIssuesRepository>();
            For<IObjectIssuesRepository>().Use<ObjectIssuesRepository>();
            For<IObjectMoviesRepository>().Use<ObjectMoviesRepository>();
            For<IObjectStoryArcsRepository>().Use<ObjectStoryArcsRepository>();
            For<IObjectVolumesRepository>().Use<ObjectVolumesRepository>();
            #endregion
            #region Origins
            For<IOriginsRepository>().Use<OriginsRepository>();
            For<IOriginProfilesRepository>().Use<OriginProfilesRepository>();
            #endregion
            #region People
            For<IGendersRepository>().Use<GendersRepository>();
            For<ICreatorCharactersRepository>().Use<CreatorCharactersRepository>();
            For<IPeopleRepository>().Use<PeopleRepository>();
            For<IPersonAliasesRepository>().Use<PersonAliasesRepository>();
            #endregion
            #region Powers
            For<IPowersRepository>().Use<PowersRepository>();
            For<IPowerAliasesRepository>().Use<PowerAliasesRepository>();
            #endregion
            #region Profiles
            For<IProfilesRepository>().Use<ProfilesRepository>();
            #endregion
            #region Promos
            For<IPromosRepository>().Use<PromosRepository>();
            For<IResourceTypesRepository>().Use<ResourceTypesRepository>();
            #endregion
            #region Publishers
            For<IPublishersRepository>().Use<PublishersRepository>();
            For<IPublisherAliasesRepository>().Use<PublisherAliasesRepository>();
            #endregion
            #region Series
            For<ISeriesRepository>().Use<SeriesRepository>();
            For<ISeriesAliasesRepository>().Use<SeriesAliasesRepository>();
            For<ISeriesCharactersRepository>().Use<SeriesCharactersRepository>();
            For<ISeriesLocationsRepository>().Use<SeriesLocationsRepository>();
            #endregion
            #region StoryArcs
            For<IStoryArcsRepository>().Use<StoryArcsRepository>();
            For<IStoryArcAliasesRepository>().Use<StoryArcAliasesRepository>();
            For<IStoryArcIssuesRepository>().Use<StoryArcIssuesRepository>();
            For<IStoryArcWritersRepository>().Use<StoryArcWritersRepository>();
            #endregion
            #region Studios
            For<IStudiosRepository>().Use<StudiosRepository>();
            #endregion
            #region Teams
            For<ITeamsRepository>().Use<TeamsRepository>();
            For<ITeamAliasesRepository>().Use<TeamAliasesRepository>();
            For<ITeamAppearedInIssuesRepository>().Use<TeamAppearedInIssuesRepository>();
            For<ITeamCharacterEnemiesRepository>().Use<TeamCharacterEnemiesRepository>();
            For<ITeamCharacterFriendsRepository>().Use<TeamCharacterFriendsRepository>();
            For<ITeamDisbandedInIssuesRepository>().Use<TeamDisbandedInIssuesRepository>();
            For<ITeamIssuesRepository>().Use<TeamIssuesRepository>();
            For<ITeamMembersRepository>().Use<TeamMembersRepository>();
            For<ITeamMoviesRepository>().Use<TeamMoviesRepository>();
            For<ITeamStoryArcsRepository>().Use<TeamStoryArcsRepository>();
            For<ITeamVolumesRepository>().Use<TeamVolumesRepository>();
            #endregion
            #region Videos
            For<IVideosRepository>().Use<VideosRepository>();
            For<IVideoTypesRepository>().Use<VideoTypesRepository>();
            #endregion
            #region Volumes
            For<IVolumesRepository>().Use<VolumesRepository>();
            For<IVolumeAliasesRepository>().Use<VolumeAliasesRepository>();
            For<IVolumeCharactersRepository>().Use<VolumeCharactersRepository>();
            For<IVolumeConceptsRepository>().Use<VolumeConceptsRepository>();
            For<IVolumeLocationsRepository>().Use<VolumeLocationsRepository>();
            For<IVolumeObjectsRepository>().Use<VolumeObjectsRepository>();
            For<IVolumeTeamsRepository>().Use<VolumeTeamsRepository>();
            For<IVolumeWritersRepository>().Use<VolumeWritersRepository>();
            #endregion
        }
    }
}
