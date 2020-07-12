using System.ComponentModel;

namespace CharacterManager.Domain.Models
{
    public enum AbilityDistributionPolicy
    {
        [Description("Default")]
        Default,
        [Description("Random")]
        Random
    }
}