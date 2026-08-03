# Chapter 4: Markdown Formatting for Game Data

Soul-Hunter relies heavily on balanced numerical data (stats, damage, cooldowns). Formatting this data correctly in Markdown ensures it is readable and can be easily translated into Unity ScriptableObjects or databases.

## 4.1 Formatting Numerical Stats
Whenever specific gameplay numbers are mentioned in text, they SHALL be bolded to stand out for quick scanning by designers and engineers.
- **Correct:** The base movement speed is **5.0** m/s.
- **Incorrect:** The base movement speed is 5.0 m/s.

## 4.2 Tabular Data for Balancing
When comparing multiple items, characters, or upgrade tiers, authors SHALL use Markdown tables. Tables provide a clear structure for balancing data.

### 4.2.1 Table Structure Rules
- Columns SHALL be clearly labeled (e.g., Level, Damage, Cooldown).
- Data SHALL be aligned consistently.

**Example: Weapon Balancing Table**
| Weapon Name | Base Damage | Attack Speed | Crit Chance |
|-------------|-------------|--------------|-------------|
| Phantom Dagger | **15** | **1.2s** | **20%** |
| Obsidian Greatsword | **45** | **2.5s** | **5%** |

## 4.3 Stat Blocks for Entities
When documenting an Enemy, NPC, or Player Class, a structured "Stat Block" SHALL be used via bulleted lists. This mirrors how data is inspected in the Unity Inspector.

**Example: Enemy Stat Block**
- **Entity ID:** `Enemy_Wraith_T1`
- **Health:** **150**
- **Movement Speed:** **3.5**
- **Aggro Radius:** **15m**
- **Loot Drop:** `Item_SoulFragment` (Drop Rate: **25%**)

## 4.4 Using Admonitions (Callouts)
MkDocs supports Admonitions. These SHALL be used to highlight critical design constraints or technical warnings.
- Use `!!! warning` for technical constraints (e.g., performance issues if a mechanic is overused).
- Use `!!! note` for design context or tips for level designers.
