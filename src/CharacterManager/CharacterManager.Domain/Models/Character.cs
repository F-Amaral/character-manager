using CharacterManager.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterManager.Domain.Models
{
    public class Character : Entity
    {
        public string Name { get; set; }
        public FeatureType FeatureType { get; set; }
        public int Level { get; set; }
        public int Initiative { get; set; }
        public int ArmorClass { get; set; }
        public int CurrentHitPoints { get; set; }
        public int MaxHitPoints { get; set; }
        public Senses Senses { get; set; }
        public Dictionary<string, Skill> Skills { get; set; }
        public Dictionary<string, Ability> Abilities { get; set; }
        public Dictionary<string, SavingThrow> SavingThrows { get; set; }
        public Dictionary<string, ConditionResistance> ConditionResistances { get; set; }
        public Dictionary<string, ConditionApplied> ConditionApplieds { get; set; }
    }
}
