# Annex C — Governance Record Templates

These templates SHALL be used for all formal governance actions within the SHRS repository.

## C.1 Work Order (WO)
```yaml
Work Order ID: WO-[XXX]
Title: [Short Description]
Author: [Name]
Target Document: [File Path]
Objective: [Why is this change needed?]
Status: [Draft/Active/Completed]
```

## C.2 Change Request (CR)
```yaml
Change Request ID: CR-[XXX]
Related Work Order: WO-[XXX]
Proposed Changes: [List of modifications]
Justification: [Reasoning]
```

## C.3 Review Record
```yaml
Review ID: REV-[XXX]
Reviewer: [Name/Role]
Target Document/CR: [ID]
Findings: [List of issues or approvals]
Decision: [Approved/Conditional/Rejected]
```

## C.4 Approval Record
```yaml
Approval ID: APP-[XXX]
Approving Authority: [Role]
Target CR: CR-[XXX]
Decision: Approved
Signature/Timestamp: [Date]
```

## C.5 Publication / Release Record
```yaml
Release ID: REL-[XXX]
Version/Edition: [vX.X.X]
Publication Authority: [Role]
Verification: All Evidence Present (Yes/No)
Release Date: [Date]
```
