using System.ComponentModel;

namespace CharacterManager.Domain.Models
{
    public enum SkillType
    {
        [Description("Acrobatics")]
        Acrobatics,
        [Description("AnimalHandling")]
        AnimalHandling,
        [Description("Arcana")]
        Arcana,
        [Description("Athletics")]
        Athletics,
        [Description("Deception")]
        Deception,
        [Description("History")]
        History,
        [Description("Insight")]
        Insight,
        [Description("Indimidation")]
        Intimidation,
        [Description("Investigation")]
        Investigation,
        [Description("Medicine")]
        Medicine,
        [Description("Nature")]
        Nature,
        [Description("Perception")]
        Perception,
        [Description("Performance")]
        Performance,
        [Description("Persuasion")]
        Persuasion,
        [Description("Religion")]
        Religion,
        [Description("SleightOfHand")]
        SleightOfHand,
        [Description("Stealth")]
        Stealth,
        [Description("Survival")]
        Survival
    }
}