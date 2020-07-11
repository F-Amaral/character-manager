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
            return new CommandDTO()
            {
                Id = entry.Id,
                SavingThrows = entry.SavingThrows,
                Abilities = entry.Abilities,
                Skills = entry.Skills,
                Choices = entry.Choices.Select(x => new ChoiceDTO
                {
                    Options = x.Options.Select(y => EnumToDescription
                        .GetEnumDescription(y))
                        .ToList()
                }).ToList()
            };
        }
    }
}