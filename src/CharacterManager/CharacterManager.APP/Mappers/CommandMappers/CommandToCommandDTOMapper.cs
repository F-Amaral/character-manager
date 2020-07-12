using System;
using System.Collections.Generic;
using System.Linq;
using CharacterManager.APP.DTOs;
using CharacterManager.APP.Mappers.Shared;
using CharacterManager.Domain.Models;
using CharacterManager.Domain.Models.Shared;

namespace CharacterManager.APP.Mappers.CommandMappers
{
    public class CommandToCommandDTOMapper : BaseMapper<Command, CommandDTO>
    {
        public override CommandDTO Map(Command entry)
        {
            var commandDto = new CommandDTO
            {
                Id = entry.Id,
                ProficiencyBonus = entry.ProficiencyBonus,
                SkillQuantityToPick = entry.SkillQuantityToPick,
                Choices = entry.Choices?.Select(x => new ChoiceDTO
                {
                    ChoiceType = EnumToDescription.GetEnumDescription(x.ChoiceType),
                    Options = x.Options?.Select(y => EnumToDescription
                            .GetEnumDescription(y))
                        .ToList(),
                    PreferenceAbilities = x.PreferenceAbilities?.Select(y => EnumToDescription
                            .GetEnumDescription(y))
                        .ToList(),
                    AbilityDistributionPolicies = x.AbilityDistributionPolicies?.Select(y => EnumToDescription
                            .GetEnumDescription(y))
                        .ToList()
                }).ToList(),
                SavingThrows = entry.SavingThrows?.Select(x => EnumToDescription.GetEnumDescription(x)).ToList(),
                Skills = entry.Skills?.Select(x => EnumToDescription.GetEnumDescription(x)).ToList(),
            };

            if(entry.Abilities != null)
            {
                var abilities = new Dictionary<string, int>();
                foreach (var ability in entry.Abilities)
                {
                    abilities.Add(EnumToDescription.GetEnumDescription(ability.Key), ability.Value);
                }
                commandDto.Abilities = abilities;
            }
            
            return commandDto;
        }
    }
}