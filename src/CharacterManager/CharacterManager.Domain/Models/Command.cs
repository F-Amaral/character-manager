using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CharacterManager.Domain.Models
{
    public class Command
    {
        public int Id { get; set; }
        public Dictionary<string, SavingThrow> SavingThrows { get; set; }
        public Dictionary<string, Ability> Abilities { get; set; }
        public Dictionary<string, Skill> Skills { get; set; }
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
                }
            };
        }
    }
}