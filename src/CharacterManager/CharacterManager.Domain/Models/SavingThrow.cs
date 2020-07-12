namespace CharacterManager.Domain.Models
{
    public class SavingThrow
    {
         public AbilityType AbilityType { get; set; }
        public int Value { get; set; }
        public bool Proficiency { get; set; }

        public SavingThrow(AbilityType abilityType, int value, bool proficiency)
        {
            AbilityType = abilityType;
            Value = value;
            Proficiency = proficiency;
        }
    }
}