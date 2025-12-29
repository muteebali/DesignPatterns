# 🌀 Chain of Responsibility Pattern

**Category:** Behavioral Design Pattern  

---

## ✅ Description

The **Chain of Responsibility (CoR)** pattern allows a request to be passed along a chain of handlers until one of them handles it.  
It **decouples the sender of a request from its receivers**, giving multiple objects a chance to process the request.

---

## ⚡ Key Features

- Multiple handlers can process a request.  
- Each handler decides: **handle it** or **pass it to the next handler**.  
- Reduces coupling between sender and receiver.  
- Useful for **event handling, logging, approvals, and request processing chains**.

---

## 💡 Real-Life Use Cases

- **Customer Support:** Calls escalate from Tier 1 → Tier 2 → Specialist.  
- **Bank Loan Approvals:** Clerk → Officer → Manager → Committee.  
- **Logging System:** InfoLogger → ErrorLogger → DebugLogger.  
- **Middleware in Web Applications:** Request passes through multiple filters.  
