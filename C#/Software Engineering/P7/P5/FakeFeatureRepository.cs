using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    public class FakeFeatureRepository : IFeatureRepository
    {

        public const string NO_ERROR = "";
        public const string DUPLICATE_TITLE_ERROR = "Title must be unique.";
        public const string EMPTY_TITLE_ERROR = "Title must have a value";
        public const string NOT_FOUND_ERROR = "Not Found Error.";
        public const string INVALID_PROJECT_ID_ERROR = "Invalid Project ID Error.";

        private static List<Feature> _Features = new List<Feature>();
        FakeRequirementRepository _FakeRequirementRepository = new FakeRequirementRepository();

        public FakeFeatureRepository()
        {
            if(_Features.Count() == 0)
            {
                Add(new Feature { Id = 1, ProjectId = 1, Title = "Flamethrower" });
                Add(new Feature { Id = 2, ProjectId = 1, Title = "Heat Capacitor" });
                Add(new Feature { Id = 3, ProjectId = 1, Title = "Expanded Napalm Canisters" });
                Add(new Feature { Id = 4, ProjectId = 2, Title = "Cool Menu Button" });
            }
        }

        public string Add(Feature feature)
        {
            if(feature.Title == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            foreach(Feature feat in _Features)
            {
                if(feat.Title == feature.Title)
                {
                    return DUPLICATE_TITLE_ERROR;
                }
                if(feat.Id == feature.Id)
                {
                    return INVALID_PROJECT_ID_ERROR;
                }
            }
            _Features.Add(feature);
            return NO_ERROR;
        }
        public List<Feature> GetAll(int ProjectId)
        {
            if(ProjectId != 0)
            {
                List<Feature> tmp = new List<Feature>();

                foreach (Feature feat in _Features)
                {
                    if (feat.ProjectId == ProjectId)
                    {
                        tmp.Add(feat);
                    }
                }
                return tmp;
            }
            else
            {
                return _Features;
            }
        }
        public string Remove(Feature feature)
        {
            foreach (Feature feat in _Features)
            {
                if(feat.Id == feature.Id)
                {
                    _Features.Remove(feat);
                    _FakeRequirementRepository.RemoveByFeatureId(feat.Id); // removes corresponding req's when feature is removed.
                    return NO_ERROR;
                }
            }
            return NOT_FOUND_ERROR;
        }
        public string Modify(Feature feature)
        {

            if (IsDupliclateTitle(feature.Title))
            {
                return DUPLICATE_TITLE_ERROR;
            }
            int index = 0;
            foreach (Feature feat in _Features)
            {
                if (feature.Id == feat.Id)
                {
                    _Features[index] = feature;
                    return NO_ERROR;
                }
                index++;
            }
            return NOT_FOUND_ERROR;
        }
        public Feature GetFeatureById(int featureId)
        {
            foreach(Feature feat in _Features)
            {
                if(feat.Id == featureId)
                {
                    return feat;
                }
            }
            throw new Exception();
        }
        public Feature GetFeatureByTitle(string title)
        {
            foreach(Feature feat in _Features)
            {
                if(feat.Title == title)
                {
                    return feat;
                }
            }
            throw new Exception();
        }
        private bool IsDupliclateTitle(string featureTitle)
        {
            bool isDuplicate = false;
            foreach (Feature feat in _Features)
            {
                if (featureTitle == feat.Title)
                {
                    isDuplicate = true;
                }
            }
            return isDuplicate;
        }

        public int GetNextId()
        {
            int highest = 0;

            foreach(Feature feat in _Features)
            {
                if(feat.Id > highest)
                {
                    highest = feat.Id;
                }
            }

            return ++highest;
        }
    }
}