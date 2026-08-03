# Chapter 3: Validation & CI/CD Pipelines

To maintain the AAA standard of the SHRS repository, human review is supplemented by automated Continuous Integration / Continuous Deployment (CI/CD) checks. These checks ensure that no broken documentation enters the Canonical Source.

## 3.1 Automated Build Validation
Every time a Pull Request is opened against the `main` branch, a CI pipeline (e.g., GitHub Actions) SHALL automatically trigger a dry-run of the site generator (`mkdocs build --strict`).
- If the build throws any warnings or errors (such as broken links or missing images), the Pull Request SHALL automatically be blocked from merging.
- The author is responsible for fixing all errors in their branch and pushing the corrections.

## 3.2 Traceability Checks
Authors SHALL ensure that their PRs reference a valid Work Order. In advanced CI setups, the pipeline MAY automatically scan commit messages to verify that a Work Order ID (e.g., `WO-015`) is present in the branch name or commit history.

## 3.3 Post-Merge Deployment
Once a Pull Request is approved and merged into `main`, the CI/CD pipeline SHALL automatically:
1. Generate the static HTML artifacts.
2. Deploy the updated documentation site to the official hosting environment (e.g., GitHub Pages).
- The `site/` directory is never committed manually to Git; it is strictly an artifact of the deployment pipeline.
