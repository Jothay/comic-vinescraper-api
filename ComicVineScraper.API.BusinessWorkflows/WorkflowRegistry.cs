namespace ComicVineScraper.API.BusinessWorkflows
{
    using StructureMap.Configuration.DSL;
    using Interfaces.Mappers;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Repositories;
    using Mappings;
    using Repositories;

    public class WorkflowRegistry  : Registry
    {
        public WorkflowRegistry()
        {
            // Characters
            For<ICharacterAliasMapper>().Use<CharacterAliasMapper>();
            For<ICharacterAliasesRepository>().Use<CharacterAliasesRepository>();
            For<ICharacterAliasesBusinessWorkflow>().Use<CharacterAliasesBusinessWorkflow>();
            For<ICharacterMapper>().Use<CharacterMapper>();
            For<ICharactersRepository>().Use<CharactersRepository>();
            For<ICharactersBusinessWorkflow>().Use<CharactersBusinessWorkflow>();
            // Chats
            For<IChatMapper>().Use<ChatMapper>();
            For<IChatsRepository>().Use<ChatsRepository>();
            For<IChatsBusinessWorkflow>().Use<ChatsBusinessWorkflow>();
            // Concepts
            For<IConceptAliasMapper>().Use<ConceptAliasMapper>();
            For<IConceptAliasesRepository>().Use<ConceptAliasesRepository>();
            For<IConceptAliasesBusinessWorkflow>().Use<ConceptAliasesBusinessWorkflow>();
            For<IConceptMapper>().Use<ConceptMapper>();
            For<IConceptsRepository>().Use<ConceptsRepository>();
            For<IConceptsBusinessWorkflow>().Use<ConceptsBusinessWorkflow>();
            // Episodes
            For<IEpisodeAliasMapper>().Use<EpisodeAliasMapper>();
            For<IEpisodeAliasesRepository>().Use<EpisodeAliasesRepository>();
            For<IEpisodeAliasesBusinessWorkflow>().Use<EpisodeAliasesBusinessWorkflow>();
            For<IEpisodeMapper>().Use<EpisodeMapper>();
            For<IEpisodesRepository>().Use<EpisodesRepository>();
            For<IEpisodesBusinessWorkflow>().Use<EpisodesBusinessWorkflow>();
            // People
            For<IPersonMapper>().Use<PersonMapper>();
            For<IPeopleRepository>().Use<PeopleRepository>();
            For<IPeopleBusinessWorkflow>().Use<PeopleBusinessWorkflow>();
        }
    }
}
