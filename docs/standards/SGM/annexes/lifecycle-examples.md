# Annex D — Lifecycle Examples

This annex provides informative examples of standard lifecycle transitions.

## D.1 Minor Revision Example
1. **Initiation**: A Work Order (WO-010) is created to fix a typo.
2. **Drafting**: The change is made in a feature branch.
3. **Review**: The Approval Authority verifies the fix.
4. **Approval**: A Governance Record is generated.
5. **Publication**: The `main` branch is updated, generating a new Version (v0.2.1).

## D.2 Full Lifecycle (Published to Withdrawn)
1. **Published**: Standard SGM Edition 1 is live.
2. **Deprecated**: A newer Governance Model (SGM Edition 2) is released. The Publication Authority formally changes the state of Edition 1 to **Deprecated**. It remains accessible but is not recommended for new projects.
3. **Withdrawn**: After 5 years, Edition 1 is entirely obsolete and causes confusion. A formal Change Request is approved to move the state to **Withdrawn**. The files are archived, and a tombstone notice is placed at the Canonical URL.
