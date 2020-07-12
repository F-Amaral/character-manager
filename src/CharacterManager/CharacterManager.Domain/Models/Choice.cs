using System.Collections.Generic;
using CharacterManager.Domain.Models.Shared;

namespace CharacterManager.Domain.Models
{
    public class Choice
    {
        public ChoiceType ChoiceType { get; set; }
        public ICollection<FeatureType> Options { get; set; }
        public ICollection<AbilityDistributionPolicy> AbilityDistributionPolicies { get; set; }
        public ICollection<AbilityType> PreferenceAbilities { get; set; }
    }
}
