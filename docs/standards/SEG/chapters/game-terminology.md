# Chapter 2: Game Terminology & Naming Conventions

Consistency in how game elements are referenced in documentation is critical to prevent miscommunication between design, art, and engineering teams.

## 2.1 Unity Ecosystem Terminology

When documenting technical elements related to the Soul-Hunter Unity project, authors SHALL strictly adhere to the following formatting conventions:

### 2.1.1 Scripts and Classes
Any reference to a C# script, class, or interface SHALL be written in `PascalCase` and enclosed in inline code blocks.
- **Correct:** The `PlayerController` script manages input.
- **Incorrect:** The player controller script manages input.

### 2.1.2 GameObjects and Prefabs
References to specific Unity GameObjects or Prefabs in the scene hierarchy SHALL be enclosed in inline code blocks and match the exact in-engine spelling.
- **Correct:** Instantiate the `VFX_SoulAbsorb` prefab at the target's location.
- **Incorrect:** Instantiate the soul absorb vfx at the target's location.

### 2.1.3 Components and Methods
When referring to Unity Components or specific methods, use inline code blocks. Methods SHALL include parentheses `()` to distinguish them from properties.
- **Correct:** The `Rigidbody` component is required. Call `TakeDamage()` when hit.

## 2.2 Lore and Narrative Terminology

Narrative consistency is essential for world-building. 

### 2.2.1 Proper Nouns
In-game proper nouns (Characters, Factions, Locations, Unique Items) SHALL always be Capitalized but SHALL NOT be enclosed in code blocks unless specifically referring to their technical ID.
- **Correct:** The Shadow Guild operates out of the Obsidian Citadel.
- **Incorrect:** The `Shadow Guild` operates out of the obsidian citadel.

### 2.2.2 The Terminology Registry
Any newly introduced mechanic, lore term, or technical acronym SHALL be formally registered in the [Terminology Registry](../metadata/terminology-registry.md). Authors SHALL verify a term's canonical spelling against the registry before using it in official documentation.

## 2.3 UI and Input References

When instructing the player or documenting UI elements:
- **Button Prompts:** SHALL be bolded and enclosed in brackets: e.g., Press **[Space]** to jump, or Press **[X]** to attack.
- **UI Elements:** References to on-screen text, buttons, or menus SHALL be enclosed in double quotes: e.g., Click the "Start Game" button on the "Main Menu" canvas.
