using CharacterManager.Domain.Models.Shared;

namespace CharacterManager.Domain.Models
{
    public class ConditionApplied
    {
        public ConditionType ConditionType { get; set; }
        public int Level { get; set; }
    }
}