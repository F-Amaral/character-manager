using System.Collections.Generic;
using CharacterManager.Domain.Models.Shared;

namespace CharacterManager.Domain.Models
{
    public class Choice
    {
        public ICollection<FeatureType> Options { get; set; }
    }
    
}
