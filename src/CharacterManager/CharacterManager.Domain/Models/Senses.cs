using CharacterManager.Domain.Models.Shared;

namespace CharacterManager.Domain.Models
{
    public class Senses
    {
        public int PassiveWisPerception { get; set; }
        public int PassiveIntInvestigation { get; set; }
        public int PassiveWisInsight { get; set; }
        public int DarkVision { get; set; }
    }
}