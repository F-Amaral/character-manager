using System;
using System.ComponentModel;

namespace CharacterManager.Domain.Models
{
    [Flags]
    public enum FeatureType : ulong
    {
        // Races
        Dwarf = 1,
        Elf = 2,
        Halfling = 4,
        [Description("Human")]
        Human = 8,
        Dragonborn = 16,
        Gnome = 32,
        HalfElf = 64,
        HalfOrc = 128,
        Tiefling = 256,

        // Classes
        Barbarian = 512,
        Bard = 1024,
        Cleric = 2048,
        Druid = 4096,
        [Description("Fighter")]
        Fighter= 8192,
        Monk = 16384,
        Paladin = 32768,
        Ranger = 65536,
        Rogue = 131072,
        Sorcerer = 262144,
        Warlock = 524288,
        Wizard = 1048576,
        
        // Features
        [Description("Dueling")]
        Dueling = 2097152,
        [Description("GreatWeaponFighting")]
        GreatWeaponFighting = 4194304,
        [Description("Protection")]
        Protection = 8388608,
        [Description("TwoWeaponFighting")]
        TwoWeaponFighting = 16777216,
        [Description("Archeary")]
        Archeary = 33554432,
    }
}