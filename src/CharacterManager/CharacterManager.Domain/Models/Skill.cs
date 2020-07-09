using CharacterManager.Domain.Models.Shared;

namespace CharacterManager.Domain.Models
{
    public class Skill
    {
        public SkillType SkillType { get; set; }
        public bool Proficiency { get; set; }
        public int Bonus { get; set; }
    }
}