# Chapter 5: Visuals & Media Guidelines

Game development documentation often requires more than text to convey complex designs. The SHRS ecosystem documentation leverages diagrams, screenshots, and UI mockups to bridge the gap between design and engineering.

## 5.1 Mermaid Architecture Diagrams
Whenever possible, logic flows, state machines, and class structures SHALL be documented using Mermaid diagrams. Text-based diagrams are preferred over external image files because they can be version-controlled and edited directly in the Markdown source.

### 5.1.1 State Machines
For AI behaviors or game state logic, use `stateDiagram-v2`.
- Example: Defining the aggro state of an enemy.

### 5.1.2 Class Diagrams
For Unity script architectures, use `classDiagram` to map dependencies (e.g., how the `InventoryManager` connects to `ItemData`).

## 5.2 Screenshots and Concept Art
Images MAY be embedded in the documentation when necessary (e.g., UI mockups, level design layouts, or concept art).

### 5.2.1 Image Sourcing
- All images SHALL be stored in a dedicated `assets/images/` directory within the respective standard or knowledge package.
- Images SHALL NOT be linked from external, unmanaged URLs (e.g., Discord or Imgur links) as these may expire.

### 5.2.2 Accessibility and Context
- Every embedded image SHALL include descriptive `alt` text.
- Example: `![Mockup of the Main Menu UI](../assets/images/ui-main-menu.png)`
- Screenshots of Unity Inspector settings MAY be used, but the critical values SHALL also be written out in text or stat blocks (as per Chapter 4) so they are searchable.

## 5.3 File Formats
- **Diagrams:** Use Mermaid (`.md`).
- **Standard Imagery (UI, Art):** Use `.png` for lossless quality.
- **Large Assets (Level Screenshots):** Use `.jpg` to conserve repository bandwidth.
- Videos or `.gif` files SHALL NOT be directly committed to the main repository to avoid repository bloat. Host them externally (e.g., unlisted YouTube) and link to them if necessary.
