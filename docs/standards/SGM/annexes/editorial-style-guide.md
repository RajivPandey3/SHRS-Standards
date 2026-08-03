# Annex B — Editorial Style Guide (SEG)

## Status
**Draft**

This Editorial Style Guide (SEG) defines the mandatory formatting and structural rules for all Markdown files within the SHRS Standards Governance Model (SGM). 

## B.1 Heading Structure
- **H1 (`#`)**: Reserved strictly for the Chapter Title. There SHALL be only one H1 per file.
- **H2 (`##`)**: Used for primary sections (e.g., `## 1.1 Purpose`).
- **H3 (`###`)**: Used for subsections (e.g., `### 1.1.1 Details`).

## B.2 Capitalization of Defined Terms
Any term listed in the Glossary (Annex A) MUST be Capitalized exactly as defined whenever used in its normative context (e.g., "The Approval Authority SHALL...").

## B.3 Normative Keywords
RFC 2119 keywords MUST be fully capitalized to indicate requirement levels:
- **SHALL** / **MUST**: Absolute requirement.
- **SHOULD**: Highly recommended but not mandatory.
- **MAY**: Optional.

## B.4 Cross-Referencing
When referencing another chapter, section, or annex, the reference SHOULD be explicit and, if possible, hyperlinked using relative paths.
*Example:* `See [Chapter 2](../chapters/governance-principles.md) for details.`

## B.5 Lists and Bullet Points
- Use hyphens (`-`) for unordered lists.
- Leave an empty line before and after a list to ensure proper Markdown rendering.
