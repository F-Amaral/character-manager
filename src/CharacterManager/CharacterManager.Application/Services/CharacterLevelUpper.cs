using System.Collections.Generic;
using System.Linq;
using CharacterManager.Application.Interfaces;
using CharacterManager.Domain.Models;

namespace CharacterManager.Application.Services
{
    public class CharacterLevelUpper : ICharacterLevelUpper
    {
        public ICollection<Command> GetCommands(Character character)
        {
            var newLevel = character.Level + 1;

            var featureTypes = EnumToDescription.GetFlags(character.FeatureType)
                .Cast<FeatureType>()
                .ToList();
            
            // INIT Future DB searchs
            // All this logic would be a query in DB
            var allFeatureCommands = FeatureCommand.GetAllFeatureCommands();

            var commandIds =
                allFeatureCommands.Where(x => featureTypes.Any(y => x.FeatureType.HasFlag(y)))
                    .Where(x => x.LevelUps.ContainsKey(newLevel))
                    .Select(x => x.LevelUps.GetValueOrDefault(newLevel));

            var allCommands = Command.GetAllCommands();

            return allCommands.Where(x => commandIds.Any(y => y == x.Id)).ToList();
        }
    }
}