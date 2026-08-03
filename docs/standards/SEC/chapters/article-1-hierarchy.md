# Article 1: The Hierarchy of Authority

The SHRS Ecosystem is governed by a strict hierarchy of authority. To ensure that "Architecture Precedes Implementation," no subordinate document, rule, or implementation MAY contradict a higher authority.

## 1.1 The Supreme Hierarchy

The following is the immutable order of authority within the SHRS ecosystem:

1. **The Founding Charter (ADR-0001)** - The origin of all ecosystem laws.
2. **The SHRS Vision (ADR-0003)** - The ultimate goal ("Build systems that govern themselves").
3. **The Constitution (SEC)** - This document, which binds the ecosystem together.
4. **Architectural Principles (SAP)** - The foundational engineering rules.
5. **Governance Models (SGM)** - The procedural rules for managing repositories and standards.
6. **Editorial & Operations (SEG, SAO)** - Guidelines for authoring and workflows.
7. **The Automation Inspector** - CI/CD and verification engines that enforce the rules above.
8. **Implementation** - The actual Game Code (e.g., Soul-Hunter Unity scripts).

## 1.2 The Law of Subordination

- **Rule 1.2.1:** If an Implementation (Code) violates the Architectural Principles (SAP), the code SHALL be rejected.
- **Rule 1.2.2:** If an Architectural Principle (SAP) contradicts the Constitution (SEC), the SAP rule is void and SHALL be rewritten.
- **Rule 1.2.3:** No feature SHALL be implemented if it violates the Vision (e.g., creating a system that cannot be governed or automated).

## 1.3 Enforcement

The ultimate responsibility for enforcing this hierarchy lies with the **Automation Inspector**. Until the Inspector is fully built, the enforcement responsibility falls manually upon the **Chief Systems Architect** during Pull Request (PR) reviews.
