using System.Collections.Generic;

namespace P6
{
    interface IRequirementRepository
    {
        string Add(Requirement requirment);
        List<Requirement> GetAll(int ProjectId);
        string Remove(Requirement requirement);
        string Modify(Requirement requirement);
        Requirement GetRequirementById(int requirementId);
        int CountByFeatureId(int featureId);
        void RemoveByFeatureId(int featureId);
    }
}
