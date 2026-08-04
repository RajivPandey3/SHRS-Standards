# Article 2: The Blueprint Boundary (SEC-020)

## 2.1 The Philosophy of Construction
SHRS follows the same engineering philosophy used in civil engineering. There is a strict distinction between the **Blueprint** (frozen architecture) and **Construction** (iterative implementation).

## 2.2 The Blueprint
The Blueprint represents the foundational, load-bearing architecture of the ecosystem. It is expensive to change and requires formal architectural review.

**The Blueprint MUST define:**
- Organization structure
- Repository ecosystem and responsibilities
- Dependency graphs and directions
- The layer model
- Governance models
- Naming philosophies
- Architectural principles

## 2.3 The Boundary Rule (SEC-020)
**The Blueprint SHALL define architecture, ownership, boundaries, and dependencies. It SHALL NOT prescribe implementation details that are expected to evolve through engineering experience.**

Implementation details include folder layouts, templates, documentation wording, Inspector rules, CI/CD workflows, automation scripts, and tooling. These belong to the Construction phase and must remain flexible.
