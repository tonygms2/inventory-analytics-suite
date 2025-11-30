# Inventory Analytics Suite

A full-stack inventory system built to demonstrate **Clean Architecture** with .NET 9. This project moves away from monolithic MVC patterns by separating the domain logic, database infrastructure, and API layer.

**Current Status:** Backend API & Database are complete. Frontend is in progress.

## Tech Stack
* **Framework:** .NET 9 Web API
* **Database:** MSSQL / Entity Framework Core (Code First)
* **Architecture:** Clean Architecture (Core, Infrastructure, API)
* **Tools:** Swagger UI, Git

## Project Structure
* `Inventory.Core`: Holds the business entities (e.g., `Product.cs`). No external dependencies.
* `Inventory.Infrastructure`: Handles the SQL connection and EF Migrations.
* `Inventory.API`: The REST endpoints (Controllers).

## How to Run

1. **Clone the repo**
   ```bash
   git clone [https://github.com/YOUR_USERNAME/inventory-analytics-suite.git](https://github.com/YOUR_USERNAME/inventory-analytics-suite.git)
