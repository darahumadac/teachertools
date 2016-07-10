using System.Collections.Generic;

namespace Models.AppModels
{
    public class SubjectRequirement
    {
        public int SubjectRequirementId { get; set; }
        public string RequirementType { get; set; }
        public decimal RequirementPercentage { get; set; }
        public List<Requirement> Requirements { get; set; }
    }
}