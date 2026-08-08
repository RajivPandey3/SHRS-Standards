# AI Collaboration Governance Review

**Date:** 2026-08-08  
**Topic:** Root Cause Analysis, Preventive Controls, and Engineering Principles

This document serves as a permanent governance record detailing how initial repository mistakes were analyzed and mitigated through systemic controls.

## 1. Root Cause Analysis (RCA)

**RCA-01: Direct Commits**
- **Issue:** 64 commits were pushed directly to `main` without PRs.
- **Root Cause:** Lack of physical repository branch protection despite written rules.

**RCA-02: Fake Automation**
- **Issue:** The `SHRS-Inspector` tool outputted cosmetic checks instead of real validation.
- **Root Cause:** A tool was created without establishing strict pass/fail criteria or failure injection tests.

**RCA-03: Broken References**
- **Issue:** Files were moved without updating relative links pointing to them.
- **Root Cause:** Lack of a repository-wide link validation CI pipeline.

**RCA-04: Blind Trust in CI Scope**
- **Issue:** Trusted `mkdocs --strict` without realizing it ignored files outside `docs/`.
- **Root Cause:** Treating a single scoped tool as a repository-wide guarantee.

**RCA-05: Rule Hypocrisy**
- **Issue:** Created a rule that reviews must end in `.md` but saved chats as `.txt`.
- **Root Cause:** Lack of automated linting/enforcement for file naming conventions.

**RCA-06: Communication Gaps**
- **Issue:** Provided "Create PR" links while acting as if the PR was already open, causing confusion.
- **Root Cause:** Ambiguous language used by the AI contributor regarding repository state.

**RCA-07: Over-Automation**
- **Issue:** Built Unity scripts that automated too much without asking the user.
- **Root Cause:** Ignoring the "Confirm First" rule in favor of rapid implementation.

## 2. Repository Controls Added

The following systemic controls have been implemented to ensure future contributors cannot repeat these mistakes:

- **Control 1: Direct Commits Prevention**
  - **Mitigation:** GitHub Branch Protection Rules enforced on `main`. All changes now require a Pull Request.

- **Control 2: Broken References & CI Blindspots**
  - **Mitigation:** Integrated `lycheeverse/lychee-action` in the CI pipeline to strictly validate all internal links across the *entire* repository (`**/*.md`), failing the build on any broken link.

- **Control 3: Fake Automation Elimination**
  - **Mitigation:** Deleted the cosmetic `SHRS-Inspector`. Adopted a policy where CI checks must be proven to fail (go red) before they can be trusted.

- **Control 4: Metadata Inconsistency**
  - **Mitigation:** Standardized a 5-field metadata schema across all Standards (SGM, SEG, SAO, KPM) enforced by the MkDocs strict build process.

- **Control 5: Naming Violations**
  - **Mitigation:** Added Chapter 6 to the Standards Editorial Guide (SEG) explicitly enforcing `kebab-case` for all repository filenames. Renamed all existing violations.

- **Control 6: Canonical Source Violations**
  - **Mitigation:** Moved `CONSTITUTION.md` into the published `docs/` folder to ensure it is visible and canonical. Updated PR templates to explicitly reference it.

## 3. Engineering Principles

Instead of personal promises, this collaboration is governed by the following engineering principles:

- **Principle 1:** Repository state is the source of truth.
- **Principle 2:** All changes must be validated automatically. A green tick only guarantees what it was explicitly configured to check.
- **Principle 3:** Human review overrides AI assumptions.
- **Principle 4:** Documentation and implementation must remain synchronized.
- **Principle 5:** A rule without a system control is just a suggestion. Architecture relies on enforced process.
