# character-manager

# Data Structure

## Command Level Up
The bonus applied to a character. When a character has a feature, when the character reaches certain level, the feature may provide some bonus stats, 
choices or new features.

```json
{
    "id": 1234,
    "saving_throws": [
        {
            "STR": "+2"
        }
    ],
    "abilities": [
        {
            "STR": "+2"
        }
    ],
    "skills": [
        {
            "Acrobatics": "+2"
        }
    ],
    "choices": [
        {
            "or": [
                "archery",
                "dueling",
                "great-weapon-fighting",
                "protection",
                "two-weapon-fighting"
            ]
        }
    ]
}
```

## Feature Command Level Up Array
Map every command level up provided by a feature that have to be applied to a character after a level up.

```json
{
    "feature_bitwise": 1,
    "feature_name": "fighter",
    "level_ups": [
        {
            "level": 1,
            "command_id": 1234
        },
        { 
            "level": 5,
            "command_id": 4434 
        }
    ]
}
```

## Character
Represents a character

```json
{
    "level": 1,
    "feature_bitwise": "human|fighter|two-weapon-fighting",
}
```

## Behavior

1. When a character choose to be a human, his feature_bitwise receive the **human** bitwise. After that, every level up applied to this
character may trigger a command level up. The first run will apply the current bonus, a:s +1 in every ability check (from d&d player`s handbook).
2. When a character choose to be a fighter, his feature_bitwise receive the **fighter** bitwise. After that, every level up applied to this
character may trigger a command level up. The first run will apply the current bonus, as: 1d10 of hit points, skills and equipment (from d&d player`s handbook).
3. When the character up from 1 to 2, the system will check if a feature will trigger a command level up, a fighter command level up will trigger,
it will receive a choice to do (from d&d player`s handbook).
    1. Choose fight style: Archery, Defense, Dueling, Great Weapon Fighting, Protection or Two-Weapon Fighting. 
    2. If the character pick archery, now he will receive the **two-weapon-fighting** bitwise.
    3. The current bonus will compute and now the character has the **second attack bonus** (from d&d player`s handbook).
4. When the character up from 2 to 3, now the system will check **human|fighter|two-weapon-fighting**, and this will be running for every level up.
may aggregating more and more bitwise and choices in every level.

