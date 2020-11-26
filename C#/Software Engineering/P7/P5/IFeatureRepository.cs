using System.Collections.Generic;

namespace P6
{
    interface IFeatureRepository
    {
        string Add(Feature feature);
        List<Feature> GetAll(int ProjectId);
        string Remove(Feature feature);
        string Modify(Feature feature);
        Feature GetFeatureById(int featureId);
        Feature GetFeatureByTitle(string title);
    }
}
