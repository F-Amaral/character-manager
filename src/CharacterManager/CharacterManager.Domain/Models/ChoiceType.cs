using System.ComponentModel;

namespace CharacterManager.Domain.Models
{
    public enum ChoiceType
    {
        [Description("Race")]
        Race,
        [Description("Class")]
        Class,
        [Description("Alignment 1")]
        Alignment1,
        [Description("Alignment 2")]
        Alignment2,
        [Description("Expertise")]
        Expertise,
        [Description("Basic Ability Points")]
        BasicAbilityPoints
    }
}