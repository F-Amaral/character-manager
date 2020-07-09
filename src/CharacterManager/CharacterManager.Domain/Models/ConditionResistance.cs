using CharacterManager.Domain.Models.Shared;

namespace CharacterManager.Domain.Models
{
    public class ConditionResistance
    {
        public ConditionType ConditionType { get; set; }
        public StatusRelationType StatusRelationType { get; set; }
    }
}