using CharacterManager.Domain.Models.Shared;
using CharacterManager.Infra.Commons.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterManager.Domain.Models
{
    [BsonCollection("Tests")]
    public class Test : Entity
    {
        public string Name { get; set; }
    }
}
