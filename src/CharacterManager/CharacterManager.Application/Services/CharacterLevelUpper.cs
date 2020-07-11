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
            // All this logs would be a query in DB
            var featureCommands = FeatureCommand.GetFighterLevelUp();
            featureCommands.LevelUps.TryGetValue(newLevel, out var commandId);
            
            var commands = Command.GetAllCommands();
            
            foreach (var command in commands)
            {
                if (commandId == command.Id)
                {
                    return new List<Command>
                    {
                        command,
                    };
                }
            }
            // END

            return null;
        }
    }
}