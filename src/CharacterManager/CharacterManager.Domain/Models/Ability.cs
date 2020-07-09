using CharacterManager.Domain.Models.Shared;

namespace CharacterManager.Domain.Models
{
    public class Ability
    {
        public AbilityType AbilityType { get; set; }
        public int Value { get; set; }
        public int Bonus { get; set; }

        public Ability(AbilityType abilityType, int value)
        {
            AbilityType = abilityType;
            Value = value;
        }
    }
}