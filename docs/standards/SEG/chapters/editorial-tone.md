# Chapter 3: Editorial Tone & Voice

The SHRS ecosystem documentation serves multiple disciplines—programming, game design, and narrative writing. A consistent tone across these disciplines ensures that every team member can seamlessly read and understand the documentation.

## 3.1 Technical & Engineering Tone
When writing technical documentation (such as architecture, Unity script descriptions, and API guides), the tone SHALL be objective, concise, and imperative.
- **Active Voice:** Use the active voice to clearly define what a system does.
  - *Correct:* The `HealthComponent` calculates damage reduction.
  - *Incorrect:* Damage reduction is calculated by the `HealthComponent`.
- **Imperative Commands:** Use direct instructions when defining rules.
  - *Correct:* Instantiate the prefab before calling `Initialize()`.
  - *Incorrect:* You should probably instantiate the prefab before you try to call `Initialize()`.

## 3.2 Game Design Document (GDD) Tone
GDDs dictate how the game feels and plays. The tone SHALL be authoritative and descriptive, removing all ambiguity about mechanics.
- **Definitive Statements:** Avoid words like "maybe", "could", or "might". If a mechanic is undecided, explicitly mark it as `[TBD]`.
  - *Correct:* The player's dash has a cooldown of 2.5 seconds.
  - *Incorrect:* The player's dash could have a cooldown of around 2.5 seconds.

## 3.3 Lore and Narrative Tone
Narrative documents (world-building, character backstories, dialogue rules) MAY adopt a more evocative and atmospheric tone appropriate for the dark fantasy setting of Soul-Hunter.
- **Structured Lore:** Even when writing atmospheric text, the document structure SHALL remain scannable. Use clear headings for character names, locations, and historical eras.
- **Separation of Mechanics and Fiction:** Lore explanations SHALL NOT be mixed with mechanical rules in the same paragraph. 
  - *Correct:* **Lore:** The cursed blade feeds on souls. **Mechanic:** Grants +5% Lifesteal per hit.
  - *Incorrect:* The cursed blade feeds on souls, meaning it gives you +5% Lifesteal.
