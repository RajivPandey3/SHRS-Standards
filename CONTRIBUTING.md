# Contributing to SHRS Standards Repository

Welcome to the SHRS Standards Repository! This document outlines the required processes and rules for contributing to the SHRS ecosystem. By contributing, you agree to abide by the [SHRS Constitution](docs/CONSTITUTION.md) and the following engineering principles.

## 1. Branch Strategy and PR Process
All changes must be proposed via a Pull Request (PR).
1. **Never push directly to `main`.** `main` is protected.
2. Create a feature or fix branch (e.g., `feature/add-new-standard` or `fix/broken-links`).
3. Commit your changes logically with descriptive commit messages.
4. Open a Pull Request against `main`. Ensure you fill out the provided PR template.
5. A PR must pass all CI checks before it can be merged.

## 2. CI/CD and Validation (MkDocs & Lychee)
When you submit a PR, the GitHub Actions CI pipeline will run two primary checks:
- **MkDocs Strict Build:** Ensures that the static site can be built without warnings.
- **Lychee Link Checker:** Scans every `.md` file in the entire repository to ensure no broken internal or external links exist.

**If the CI fails, your PR cannot be merged.** Fix the errors indicated in the action logs and push the corrections to your branch.

## 3. Naming Rules
- **All repository filenames SHALL use `kebab-case`.** 
  - *Allowed:* `feature-request.md`
  - *Not Allowed:* `Feature_Request.md`, `featureRequest.md`, `feature_request.md`
- Do not use uppercase filenames except for universally standard root files like `README.md` or `CONTRIBUTING.md`.

## 4. Metadata Rules
Any new standard, chapter, or major architectural document must include a standard YAML metadata block or a `METADATA.yaml` file in its folder. The mandatory schema requires 5 fields:
- `package_id`
- `title`
- `version`
- `owner`
- `status`
- `review_date` (optional but recommended)
- `dependencies`

Ensure consistency with existing standards like SGM, SEG, SAO, and KPM.

## 5. Constitution Compliance
Before making any architectural decisions or adding new rules, read the [SHRS Constitution](docs/CONSTITUTION.md).
- Do not bypass established governance models.
- If you intend to change an existing process, ensure you update the relevant Standard (e.g., SEG for editorial rules, SAO for architecture rules).

Thank you for helping maintain a robust, transparent, and professionally governed repository!
