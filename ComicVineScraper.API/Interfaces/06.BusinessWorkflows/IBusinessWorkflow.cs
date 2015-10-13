namespace ComicVineScraper.API.Interfaces.BusinessWorkflows
{
    using System.Collections.Generic;

    public interface IBusinessWorkflow<TIModel, TISearchModel>
    {
        TIModel Get(int id);
        TIModel Get(string key);
        List<TIModel> Search(TISearchModel searchModel, bool asListing = false);
        TIModel Create(TIModel model);
        TIModel Update(TIModel model);
        bool Deactivate(int id);
        bool Deactivate(string key);
        bool Remove(int id);
        bool Remove(string key);
    }
}