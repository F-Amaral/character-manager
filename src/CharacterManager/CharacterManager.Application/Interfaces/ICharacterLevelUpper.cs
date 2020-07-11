using System.Collections.Generic;
using CharacterManager.Domain.Models;

namespace CharacterManager.Application.Interfaces
{
    public interface ICharacterLevelUpper
    {
        public ICollection<Command> GetCommands(Character character);
    }
}