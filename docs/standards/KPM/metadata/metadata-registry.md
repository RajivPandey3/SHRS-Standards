# Knowledge Package Metadata Registry

## Purpose
The purpose of this chapter is to define the exact metadata registry structure required for all Knowledge Packages within the SHRS Ecosystem. Proper metadata ensures long-term discoverability, auditability, and governance compliance.

## 12.2 The Metadata Schema
Every Knowledge Package MUST include the following metadata fields explicitly defined in its registry or front-matter block:

| Field Name | Description | Required |
|------------|-------------|----------|
| **Package ID** | A unique, immutable identifier (e.g., `KPM-001`). | Yes |
| **Owner** | The designated authority or team responsible for maintaining the package. | Yes |
| **Version** | The current semantic version of the package (e.g., `v1.0.0`). | Yes |
| **Review Date** | The date the package was last audited or approved by the Review Authority. | Yes |
| **Dependencies** | A list of other packages, documents, or systems this package relies upon. | Yes |

## 12.3 Governance Enforcement
The Repository Builder and Validation Authorities SHALL automatically reject any Knowledge Package that fails to provide the complete metadata schema outlined above.

