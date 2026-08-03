# ADR-0002: Repository Architecture and Charter Specification

## 1. Metadata
- **Status:** Accepted
- **Date:** 2026-08-04
- **Author:** Founder / Chief Architect
- **Decider:** Founder / Chief Architect

## 2. Context
As SHRS evolves into a vast engineering ecosystem, we face the risk of "repository sprawl"—a situation where repositories are created simply as storage buckets for code without clear boundaries or responsibilities. To prevent this, we must redefine what a repository is within the SHRS ecosystem. 

## 3. Decision
We have established the **SHRS Repository Philosophy**. Within this ecosystem, a repository is NOT a storage location. **A repository is an architectural responsibility.**

### The Repository Charter Rule
Before any new repository can be created, it SHALL formally define its "Repository Charter". If the charter cannot be clearly stated, the repository SHALL NOT exist. 

Every repository charter MUST explicitly define:
1. **Purpose:** Why does this repository exist?
2. **Responsibility:** What specific problem does it solve? (Must adhere to the Single Responsibility Principle).
3. **Boundaries:** What is strictly OUT of scope for this repository?
4. **Dependencies:** What other repositories or external systems does it rely on?
5. **Lifecycle:** Is this a permanent system, a transitional tool, or a disposable spike?
6. **Version Policy:** How are releases tagged and versioned? (e.g., Semantic Versioning).
7. **Ownership:** Who is the Approval Authority or Maintainer?

## 4. Consequences
- **Positive:** This prevents dead, overlapping, or bloated repositories. It forces architects to think deeply about system boundaries before writing a single line of code.
- **Negative/Constraints:** The friction to start a new project is higher. Developers cannot just "spin up a repo" without formal justification and an approved charter.

## 5. Notes
*Learning Comment: This decision fundamentally shifts SHRS from a traditional agile environment to a highly governed engineering civilization. By treating a repository as a 'responsibility' rather than a 'folder', we guarantee architectural coherence at a macro level.*
