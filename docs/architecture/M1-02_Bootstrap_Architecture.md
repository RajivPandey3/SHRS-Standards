# Blueprint: M1-02 Bootstrap Architecture

## 1. Purpose
This document defines the architectural blueprint for the **Initialization and Bootstrap Layer** of the SHRS Ecosystem (Soul-Hunter project). The goal is to provide a clean, deterministic, and highly decoupled entry point for the game. This layer will ensure that all core systems (like the Event Bus created in M1-01) are initialized in the correct order before gameplay begins.

## 2. Hierarchical Single Responsibility
Following the SHRS constitution, each class in this layer has one and only one responsibility:

- **`GameBootstrapper.cs`**: The canonical entry point. It lives on a single GameObject in the initial "Bootstrap" scene. Its only job is to sequence the initialization of core services and transition to the main game state/scene.
- **`ServiceLocator.cs` (or Dependency Injector)**: Acts as a central registry for global services. It allows decoupled access to systems (like `EventBus`) without using rigid Singletons scattered across the codebase.
- **`IService.cs`**: An interface that all core services must implement, containing an `Initialize()` method.

## 3. Execution Order (The Sequence)
When the game starts, the execution flow must be completely deterministic:
1. **Scene Load**: Unity loads the `Bootstrap` scene.
2. **Awake()**: `GameBootstrapper` wakes up and locks itself so it isn't destroyed on load (`DontDestroyOnLoad`).
3. **Service Registration**: `GameBootstrapper` registers all core systems into the `ServiceLocator`. (e.g., `ServiceLocator.Register<IEventBus>(new EventBus());`)
4. **Initialization**: `GameBootstrapper` loops through all registered `IService` instances and calls `Initialize()`.
5. **Transition**: Once initialization is fully complete, `GameBootstrapper` triggers the scene load for the Main Menu or Game Scene.

## 4. Dependencies
- **Event Bus (M1-01)**: The Bootstrap layer must depend on the Event Bus. Once the Event Bus is registered and initialized, the Bootstrapper can fire a `GameInitializedEvent` to let other loose systems know that the core is ready.

## 5. The 2036 Test Compliance
- The architecture is flat. A new engineer looking at `GameBootstrapper.cs` will read a top-to-bottom sequence of what happens when the app launches.
- No hidden execution orders (like Unity's default Script Execution Order magic) will be relied upon for core services.

---
*Status: Drafted for M1-02. Pending Chief Architect approval before moving to C# implementation.*
