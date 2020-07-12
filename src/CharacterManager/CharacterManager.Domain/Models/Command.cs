using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CharacterManager.Domain.Models
{
    public class Command
    {
        public int Id { get; set; }
        public int ProficiencyBonus { get; set; }
        public ICollection<AbilityType> SavingThrows { get; set; }
        public Dictionary<AbilityType, int> Abilities { get; set; }
        public int SkillQuantityToPick { get; set; }
        public ICollection<SkillType> Skills { get; set; }
        public ICollection<Choice> Choices { get; set; }

        public static ICollection<Command> GetAllCommands()
        {
            return new Collection<Command>
            {
                new Command
                {
                    Id = 0,
                    Choices = new Collection<Choice>
                    {
                        new Choice
                        {
                            ChoiceType = ChoiceType.Expertise,
                            Options = new Collection<FeatureType>
                            {
                                FeatureType.Dueling,
                                FeatureType.GreatWeaponFighting,
                                FeatureType.Protection,
                                FeatureType.TwoWeaponFighting,
                                FeatureType.Archeary
                            }
                        }
                    }
                },
                new Command
                {
                    Id = 1,
                    Choices = new Collection<Choice>
                    {
                        new Choice
                        {
                            ChoiceType = ChoiceType.Race,
                            Options = new Collection<FeatureType>
                            {
                                FeatureType.Dwarf,
                                FeatureType.Elf,
                                FeatureType.Halfling,
                                FeatureType.Human,
                                FeatureType.Dragonborn,
                                FeatureType.Gnome,
                                FeatureType.HalfElf,
                                FeatureType.HalfOrc,
                                FeatureType.Tiefling,
                            }
                        },
                        new Choice
                        {
                            ChoiceType = ChoiceType.Class,
                            Options = new Collection<FeatureType>
                            {
                                FeatureType.Barbarian,
                                FeatureType.Bard,
                                FeatureType.Cleric,
                                FeatureType.Druid,
                                FeatureType.Fighter,
                                FeatureType.Monk,
                                FeatureType.Paladin,
                                FeatureType.Ranger,
                                FeatureType.Rogue,
                                FeatureType.Sorcerer,
                                FeatureType.Warlock,
                                FeatureType.Wizard,
                            }
                        },
                        new Choice
                        {
                            ChoiceType = ChoiceType.Alignment1,
                            Options = new Collection<FeatureType>
                            {
                                FeatureType.Lawful,
                                FeatureType.Neutral,
                                FeatureType.Chaotic,
                            }
                        },
                        new Choice
                        {
                            ChoiceType = ChoiceType.Alignment2,
                            Options = new Collection<FeatureType>
                            {
                                FeatureType.Good,
                                FeatureType.Neutral,
                                FeatureType.Evil,
                            }
                        },
                        new Choice
                        {
                            ChoiceType = ChoiceType.BasicAbilityPoints, 
                            AbilityDistributionPolicies = new List<AbilityDistributionPolicy>
                            {
                              AbilityDistributionPolicy.Default,
                              AbilityDistributionPolicy.Random,
                            },
                            PreferenceAbilities = new Collection<AbilityType>
                            {
                                AbilityType.Strength,
                                AbilityType.Dexterity,
                                AbilityType.Constitution,
                                AbilityType.Intelligence,
                                AbilityType.Wisdom,
                                AbilityType.Charisma,
                            }
                        }
                    }
                },
                new Command
                {
                    Id = 2,
                    Abilities = new Dictionary<AbilityType, int>
                    {
                        {AbilityType.Strength, 1},
                        {AbilityType.Dexterity, 1},
                        {AbilityType.Intelligence, 1},
                        {AbilityType.Constitution, 1},
                        {AbilityType.Wisdom, 1},
                        {AbilityType.Charisma, 1}
                    }
                },
                new Command
                {
                    Id = 3,
                    ProficiencyBonus = 2,
                },
                new Command
                {
                    Id = 4,
                    SavingThrows = new List<AbilityType>
                    {
                        AbilityType.Strength,
                        AbilityType.Constitution,
                    },
                    SkillQuantityToPick = 2,
                    Skills = new List<SkillType>
                    {
                        SkillType.Acrobatics,
                        SkillType.Athletics,
                        SkillType.AnimalHandling,
                        SkillType.Insight,
                        SkillType.Intimidation,
                        SkillType.Perception,
                        SkillType.Survival,
                    }
                }
            };
        }
    }
}