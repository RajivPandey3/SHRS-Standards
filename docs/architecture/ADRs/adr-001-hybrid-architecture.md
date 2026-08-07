# ADR-001: Hybrid System Architecture

**Status:** Approved  
**Author:** Chief Systems Architect (by order of the Founding Architect)  
**Date:** August 2026  

## 1. Context
During the Engineering Era (Sprint-003, Task M1-02), a critical architectural ambiguity was identified. The founding documents and rulesets (KPM, SEC) did not explicitly mandate a Hybrid ECS (Entity Component System) architecture. However, the Founding Architect explicitly directed that the Soul-Hunter project MUST be built as a Hybrid System.

## 2. Decision
The Soul-Hunter project will officially follow a **Hybrid Architecture** combining Unity's Data-Oriented Technology Stack (DOTS/ECS) principles with traditional Object-Oriented Programming (OOP) where necessary.

## 3. Engineering Rules & Consequences
To comply with this hybrid system, all future engineering work must follow these constraints:
1. **Zero-Allocation Data Streams:** Core gameplay systems and high-frequency communication (like the Event Bus) must prioritize using `structs` (value types) over `classes` to prevent garbage collection spikes.
2. **Interface over Inheritance:** Base systems should rely on interfaces (e.g., `IGameEvent`) rather than abstract classes. This allows value types to implement the contracts and keeps the heap clean.
3. **Separation of Concerns:** 
   - **OOP / MonoBehaviours:** Reserved for high-level flow (Bootstrap), UI interactions, and systems that do not require massive parallel processing.
   - **ECS / DOTS / Structs:** Reserved for heavy computational logic, entities, combat mechanics, and high-volume data processing.

## 4. Retrospective Fixes
As a direct consequence of this ADR, legacy scripts such as the manual `EventBus.cs` and `GameEvent.cs` have been audited and rewritten to support interface-based zero-allocation events, aligning the code with this Hybrid mandate.
