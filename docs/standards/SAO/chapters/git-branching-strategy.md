# Chapter 2: Git Branching Strategy

To protect the integrity of the Canonical Source, the SHRS repository utilizes a strict branching strategy.

## 2.1 The Canonical Branch
The `main` branch is the Canonical Source of Truth. 
- Direct commits (pushes) to the `main` branch are **strictly prohibited** for all users, including the Standards Maintainer.
- All changes to `main` SHALL only occur via a formal Pull Request (PR) merge.

## 2.2 Branch Naming Conventions
When an author begins work on a documented Work Order, they SHALL create a new branch. Branch names must be descriptive and directly reference the authorization record.

**Format:** `[type]/[Work-Order-ID]-[short-description]`

### 2.2.1 Allowed Types:
- `feature/`: For drafting new standards or major Knowledge Packages. (e.g., `feature/WO-012-combat-system-gdd`)
- `fix/`: For editorial corrections, broken links, or Corrigenda. (e.g., `fix/WO-013-typo-in-glossary`)
- `audit/`: For broad repository restructuring or governance checks. (e.g., `audit/WO-014-rc1-readiness`)

## 2.3 Commit Messages
Commit messages serve as the permanent historical log of the repository. They SHALL follow the Conventional Commits format to allow for automated changelog generation.

**Format:** `type(scope): description`
- **Example:** `docs(sao): draft Chapter 2 for Git branching strategy`
- **Example:** `fix(kpm): correct broken relative link in Chapter 1`

## 2.4 Pull Requests and Merging
When a branch is ready for review, the author opens a Pull Request.
- The PR title SHALL clearly state the purpose and reference the Work Order.
- The PR SHALL NOT be merged until it has received a formal approval from the designated Approval Authority.
- When merging, "Squash and Merge" SHOULD be used to maintain a clean and readable Git history on the `main` branch.

