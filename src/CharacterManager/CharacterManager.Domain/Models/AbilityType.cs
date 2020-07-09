using System.ComponentModel;

namespace CharacterManager.Domain.Models
{
    public enum AbilityType
    {
        [Description("STR")]
        Strength,
        [Description("DEX")]
        Dexterity,
        [Description("CON")]
        Constitution,
        [Description("INT")]
        Intelligence,
        [Description("WIS")]
        Wisdom,
        [Description("CHA")]
        Charisma
    }
}