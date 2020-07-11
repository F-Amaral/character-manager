using System.Collections.Generic;
using System.Collections.ObjectModel;
using CharacterManager.Domain.Models;

namespace CharacterManager.APP.DTOs
{
    public class ChoiceDTO
    {
        public ICollection<string> Options { get; set; }
    }
    
    public class CommandDTO
    {
        public int Id { get; set; }
        public Dictionary<string, SavingThrow> SavingThrows { get; set; }
        public Dictionary<string, Ability> Abilities { get; set; }
        public Dictionary<string, Skill> Skills { get; set; }
        public ICollection<ChoiceDTO> Choices { get; set; }
    }
}