# SHRS Standards Repository

> 🛑 **START HERE:** Before writing code, raising issues, or proposing architecture, you must read the **[SHRS Engineering Constitution](CONSTITUTION.md)**. It is the supreme governing document of this ecosystem.

Welcome to the **SHRS Standards Repository**, the canonical home for the governance, publication, and compliance models that power the SHRS ecosystem.

## What is SHRS?
SHRS (Standardized Hierarchical Record System) is an advanced framework designed to maintain knowledge and standards with absolute structural and semantic integrity. This repository contains the constitutional baselines that govern how knowledge is created, validated, published, and evolved.

## Repository Architecture Layers
The repository is strictly divided into functional layers. Every file must earn its place in one of these boundaries:
```text
├── docs/       # Canonical Knowledge (Standards, Charters, ADRs, Game Design)
├── tools/      # Engineering Utilities (Inspectors, scripts)
├── reviews/    # Audit Evidence (Engineering review records)
├── site/       # Generated Output (Never committed to main)
```
*Note: `site/` is a generated artifact and is ignored by version control. It is only built during deployment.*

## Standards Included
- **[Standards Governance Model (SGM)](docs/standards/SGM/index.md)**: The foundational rules for creating, maintaining, and publishing high-quality standards.
- **[Knowledge Package Publication Model (KPM)](docs/standards/KPM/chapters/publication.md)**: The canonical framework for publishing Knowledge Packages (KPM-BL-001).
- **[SHRS Ecosystem Constitution (SEC)](CONSTITUTION.md)**: The supreme legal document governing the entire engineering ecosystem.
- **[Architecture Decision Records (ADRs)](docs/architecture/ADRs/index.md)**: Canonical registry of all major ecosystem decisions.

## Current Status
See our active decisions and active sprint status in the Roadmap.

## Roadmap
For the canonical source of truth regarding Sprints and Program Missions, see: 
**[docs/program/ROADMAP.md](docs/program/ROADMAP.md)**

## How to Contribute
SHRS follows a strict Governance Process to ensure no architectural debt is introduced.
**Workflow:** `Issue` ➔ `Review` ➔ `Approval` ➔ `Merge`

All modifications must pass through the Governance Gates. Direct pushes to `main` are strictly prohibited.

## Repository Navigation
- Browse the raw markdown files in `docs/standards/`.
- Run `mkdocs serve` to view the AAA-grade documentation website locally.

## License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
