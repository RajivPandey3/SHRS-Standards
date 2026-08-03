# Chapter 1: Authoring Workflows

The act of writing or modifying standards and documentation within the SHRS repository SHALL follow a highly structured operational workflow. This ensures that every change is deliberate, peer-reviewed, and strictly aligns with the existing governance structure (SGM).

## 1.1 The Authoring Lifecycle

No author SHALL begin writing or modifying documentation without prior authorization. The workflow is strictly defined as follows:

1. **Authorization:** Obtain an approved Work Order or Change Request.
2. **Branch Creation:** Create an isolated Git branch specific to the Work Order (See Chapter 2).
3. **Drafting:** Write the content using the canonical templates provided in the SEG (Standards Editorial Guide).
4. **Self-Validation:** Run local checks (e.g., `mkdocs serve`, markdown linters) to ensure there are no broken links or formatting errors.
5. **Submission:** Open a Pull Request (PR) against the `main` branch.
6. **Peer Review:** The Approval Authority reviews the changes.
7. **Merge & Publish:** Upon approval, the changes are merged into the Canonical Source.

## 1.2 Using Templates

Authors SHALL NOT create documents from a blank slate. All new documents, whether Game Design Documents (GDD) or Technical Architecture definitions, SHALL be instantiated from the canonical templates provided in the SEG Annexes.
- Example: When designing a new weapon for Soul-Hunter, the author must copy `annex-a-gdd-template.md`.

## 1.3 Pre-Commit Quality Checks

Before committing any code or documentation, the author is responsible for ensuring the following:
- **No Broken Links:** All internal Markdown cross-references must resolve correctly.
- **Editorial Compliance:** The text must adhere to the rules defined in the SEG (e.g., proper use of `SHALL`, `MAY`, `MUST NOT`).
- **Build Readiness:** The repository must be able to generate the static site without throwing fatal errors in the CI/CD pipeline.
