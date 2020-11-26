using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    public class FakeRequirementRepository : IRequirementRepository
    {
        public const string NO_ERROR = "";
        public const string DUPLICATE_STATEMENT_ERROR = "Statements must be unique";
        public const string EMPTY_STATEMENT_ERROR = "Statement must have a value";
        public const string REQUIREMENT_NOT_FOUND_ERROR = "Requirement Not Found Error";
        public const string MISSING_FEATUREID_ERROR = "Missing FeatureId Error";
        public const string MISSING_PROJECTID_ERROR = "Missing ProjectId Error";

        private static List<Requirement> _Requirements = new List<Requirement>();

        public FakeRequirementRepository()
        {
            if (_Requirements.Count() == 0)
            {
                Add(new Requirement { Id = 1, ProjectId = 1, FeatureId = 1, Statement = "Must Function" });
                Add(new Requirement { Id = 2, ProjectId = 1, FeatureId = 1, Statement = "Must Meet School Safety Guidelines For On-Campus Flamethrowers" });
                Add(new Requirement { Id = 3, ProjectId = 1, FeatureId = 2, Statement = "Must suppress to under 3 gigajoules of power" });
                Add(new Requirement { Id = 4, ProjectId = 2, FeatureId = 4, Statement = "Needs to function" });
            }
        }

        public string Add(Requirement requirement)
        {
            requirement.Id = GetNextId();

            foreach (Requirement req in _Requirements)
            {
                if (req.Statement == requirement.Statement)
                {
                    return DUPLICATE_STATEMENT_ERROR;
                }if(req.Id == requirement.Id)
                {
                    throw new Exception();
                    // How have you done this?
                }
            }

            if(requirement.Statement == "")
            {
                return EMPTY_STATEMENT_ERROR;
            }
            else if(requirement.ProjectId <= 0)
            {
                return MISSING_PROJECTID_ERROR;
            }
            else if(requirement.FeatureId <= 0)
            {
                return MISSING_FEATUREID_ERROR;
            }
            else
            {
                _Requirements.Add(requirement);
                return NO_ERROR;
            }
        }
        public List<Requirement> GetAll(int ProjectId)
        {
            if (ProjectId != 0)
            {
                List<Requirement> tmp = new List<Requirement>();

                foreach (Requirement req in _Requirements)
                {
                    if (req.ProjectId == ProjectId)
                    {
                        tmp.Add(req);
                    }
                }
                return tmp;
            }
            else
            {
                return _Requirements;
            }
        }
        public string Remove(Requirement requirement)
        {
            foreach (Requirement req in _Requirements)
            {
                if (req == requirement)
                {
                    _Requirements.Remove(requirement);
                    return NO_ERROR;
                }
            }
            return REQUIREMENT_NOT_FOUND_ERROR;
        }
        public string Modify(Requirement requirement)
        {

            if(IsDupliclateStatement(requirement.Statement, requirement.Id))
            {
                return DUPLICATE_STATEMENT_ERROR;
            }

            int index = 0;

            foreach(Requirement req in _Requirements)
            {
                if(requirement.Id == req.Id)
                {
                    _Requirements[index] = requirement;
                    return NO_ERROR;
                }
                index++;
            }
            return REQUIREMENT_NOT_FOUND_ERROR;
        }
        public Requirement GetRequirementById(int requirementId)
        {
            foreach(Requirement req in _Requirements)
            {
                if(req.Id == requirementId)
                {
                    return req;
                }
            }

            throw new Exception();
        }
        public int CountByFeatureId(int featureId)
        {
            int count = 0;

            foreach (Requirement req in _Requirements)
            {
                if (req.FeatureId == featureId)
                {
                    count++;
                }
            }

            return count;
        }
        public void RemoveByFeatureId(int featureId) // This function SHOULD remove ALL requirements with the provided feature id.
        {
            for(int i = CountByFeatureId(featureId); i!=0; i--)
            {
                foreach (Requirement req in _Requirements)
                {
                    if (req.FeatureId == featureId)
                    {
                        Remove(req);
                        break;
                    }
                }
            }
        }

        private bool IsDupliclateStatement(string requirementStatement, int? ignoreId = null)
        {
            bool isDuplicate = false;
            foreach (Requirement req in _Requirements)
            {
                if(ignoreId != null && ignoreId == req.Id)
                {
                    continue;
                }

                if (requirementStatement == req.Statement)
                {
                    isDuplicate = true;
                }
            }
            return isDuplicate;
        }
        public int GetNextId()
        {
            int highest = 0;

            foreach (Requirement req in _Requirements)
            {
                if (req.Id > highest)
                {
                    highest = req.Id;
                }
            }

            return ++highest;
        }
    }
}
