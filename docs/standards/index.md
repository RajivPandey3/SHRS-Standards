# SHRS Standards Directory

This directory hosts the canonical standards for the SHRS framework. 

## Active Standards
- **[SGM - Standards Governance Model](SGM/index.md)**: The foundational governance architecture for the repository.
- **[KPM - Knowledge Package Publication Model](KPM/chapters/publication.md)**: The standard for publishing knowledge packages.

## Site Generation Policy
The `site/` directory in the repository root contains the generated static HTML artifacts. As a matter of policy, `site/` SHALL NOT be versioned in Git. It is dynamically generated via CI/CD (e.g. `mkdocs build`) from the Canonical Source in the `docs/` directory.
