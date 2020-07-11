using System.Collections.Generic;

namespace CharacterManager.Domain.Models
{
    public class FeatureCommand
    {
        public FeatureType FeatureType { get; set; }
        public Dictionary<int, int> LevelUps { get; set; }

        public static FeatureCommand GetFighterLevelUp()
        {
            return new FeatureCommand
            {
                FeatureType = FeatureType.Fighter,
                LevelUps = new Dictionary<int, int>
                {
                    {1, 0}
                }
            };
        }
    }
}