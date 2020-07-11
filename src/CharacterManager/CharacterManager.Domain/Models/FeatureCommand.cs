using System.Collections.Generic;

namespace CharacterManager.Domain.Models
{
    public class FeatureCommand
    {
        public FeatureType FeatureType { get; set; }
        public Dictionary<int, int> LevelUps { get; set; }
        
        public static ICollection<FeatureCommand> GetAllFeatureCommands()
        {
            return new List<FeatureCommand>
            {
                new FeatureCommand
                {
                    FeatureType = FeatureType.Character,
                    LevelUps = new Dictionary<int, int>
                    {
                        {1, 1}
                    }
                },
                new FeatureCommand
                {
                    FeatureType = FeatureType.Fighter,
                    LevelUps = new Dictionary<int, int>
                    {
                        {2, 0}
                    }
                }

            };
        }
    }
}