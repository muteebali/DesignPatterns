# Observer Design Pattern (Behavioral)

## Overview
The **Observer Pattern** defines a **one-to-many relationship** between objects.  
When the state of one object (Subject) changes, all dependent objects (Observers) are **automatically notified**.

This pattern is widely used in **event-driven and reactive systems**.

---

## Problem
You have an object whose state changes frequently, and multiple other objects need to react to those changes **without tight coupling**.

---

## Solution
Create a **Subject** that maintains a list of **Observers**.  
Observers register themselves and get notified whenever the subject’s state changes.

---

## Structure
- **Subject** – Maintains observers and notifies them
- **Observer** – Defines update behavior
- **ConcreteSubject** – Implements subject logic
- **ConcreteObserver** – Reacts to notifications

---

## Real-World Example
- YouTube channel notifying subscribers
- Stock price updates
- Order status notifications

---

## .NET Examples
- Events & Delegates
- `IObservable<T>` / `IObserver<T>`
- WPF `INotifyPropertyChanged`
- Domain Events in ASP.NET Core

---

## When to Use
- Event-driven architectures
- Real-time updates
- Loose coupling between components

---

## Pros & Cons
**Pros**
- Loose coupling
- Open/Closed Principle
- Easy to extend

**Cons**
- Possible memory leaks if observers are not removed
- Debugging can be complex

---

## Related Patterns
- Mediator
- Publish-Subscribe
- Event Aggregator
