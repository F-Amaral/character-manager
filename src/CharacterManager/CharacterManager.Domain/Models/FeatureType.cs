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
        Fighter= 8192,
        Monk = 16384,
        Paladin = 32768,
        Ranger = 65536,
        Rogue = 131072,
        Sorcerer = 262144,
        Warlock = 524288,
        Wizard = 1048576,
        
        // Alignment
        [Description("Lawful")]
        Lawful = 2097152,
        [Description("Neutral")]
        Neutral = 4194304,
        [Description("Chaotic")]
        Chaotic = 8388608,
        [Description("Good")]
        Good = 16777216,
        [Description("Evil")]
        Evil = 33554432,

        // Features
        [Description("Dueling")]
        Dueling = 67108864,
        [Description("Great Weapon Fighting")]
        GreatWeaponFighting = 134217728,
        [Description("Protection")]
        Protection = 268435456,
        [Description("Two Weapon Fighting")]
        TwoWeaponFighting = 536870912,
        [Description("Archeary")]
        Archeary = 1073741824,
        [Description("Character")]
        Character = 2147483648,
        [Description("NonCharacter")]
        NonCharacter = 4294967296
    }
}