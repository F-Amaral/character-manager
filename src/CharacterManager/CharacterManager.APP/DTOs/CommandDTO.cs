using System.Collections.Generic;
using System.Collections.ObjectModel;
using CharacterManager.Domain.Models;

namespace CharacterManager.APP.DTOs
{
    public class ChoiceDTO
    {
        public string ChoiceType { get; set; }
        public ICollection<string> Options { get; set; }
        public ICollection<string> AbilityDistributionPolicies { get; set; }
        public ICollection<string> PreferenceAbilities { get; set; }
    }
    
    public class CommandDTO
    {
        public int Id { get; set; }
        public int ProficiencyBonus { get; set; }
        public ICollection<string> SavingThrows { get; set; }
        public Dictionary<string, int> Abilities { get; set; }
        public int SkillQuantityToPick { get; set; }
        public ICollection<string> Skills { get; set; }
        public ICollection<ChoiceDTO> Choices { get; set; }
    }
}