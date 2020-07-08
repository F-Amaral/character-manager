using System;
using System.ComponentModel.DataAnnotations;

namespace CharacterManager.Domain.Models.Shared
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
