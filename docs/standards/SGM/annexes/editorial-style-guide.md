# Annex B — Editorial Style Guide (SEG)

This guide defines the formatting and structural rules for all SHRS documents.

## B.1 Heading Hierarchy
- `H1 (#)` SHALL be used only for Document Titles or Chapter Titles.
- `H2 (##)` SHALL be used for primary sections (e.g., 1.1, 1.2).
- `H3 (###)` SHALL be used for subsections.

## B.2 Normative Language and RFC 2119
To ensure absolute clarity in requirements, the SHRS repository adopts the keywords defined in RFC 2119.
- **SHALL**: Indicates an absolute requirement that MUST be followed.
- **SHALL NOT**: Indicates an absolute prohibition.
- **SHOULD**: Indicates a strong recommendation, but valid exceptions may exist.
- **MAY**: Indicates an optional course of action.

## B.3 Markdown Conventions
- Use standard GitHub Flavored Markdown (GFM).
- Tables SHALL be formatted properly with aligned columns.

## B.4 Cross-Reference Formatting
- References to other chapters SHALL use relative markdown links (e.g., `[Chapter 5](../chapters/release-governance.md)`).
- Cross-references SHALL NOT use absolute URLs.

## B.5 Requirement ID Formatting
- All normative requirements SHALL be assigned a unique ID in the format: `[STANDARD]-[TYPE]-[NUMBER]`.
- Example: `SGM-REQ-001`.
