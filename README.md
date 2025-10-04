# PeopleManager---ASP.NET-Core-MVC-application

A modern ASP.NET Core MVC application for managing employees and organizational functions. Built with .NET 9.0, Entity Framework Core, and ASP.NET Core Identity.
## Features

Employee Management - Create, read, update, and delete employee records
Function/Role Management - Manage organizational roles and assign them to employees
Authentication & Authorization - Secure access with ASP.NET Core Identity
Employee Showcase - Homepage featuring employee cards and "Employee of the Month"
Responsive Design - Bootstrap 5 responsive UI with modal dialogs
Data Validation - Client and server-side validation

## Tech Stack

.NET 9.0 - Latest .NET framework
ASP.NET Core MVC - Web application framework
Entity Framework Core - ORM for data access
ASP.NET Core Identity - Authentication and authorization
Bootstrap 5 - CSS framework
jQuery - JavaScript library
SQL Server - Database (production)
In-Memory Database - Database (development)

## Project Structure

    PeopleManager/
    ├── PeopleManager.Model/           # Domain entities
    │   ├── Person.cs                  # Employee entity
    │   └── Function.cs                # Role/Function entity
    ├── PeopleManager.Repository/      # Data access layer
    │   └── PeopleManagerDbContext.cs  # EF Core context
    ├── PeopleManager.Services/        # Business logic
    │   ├── PersonService.cs           # Employee operations
    │   └── FunctionService.cs         # Function operations
    └── PeopleManager.Ui.Mvc/         # Web UI
      ├── Controllers/               # MVC Controllers
      ├── Models/                    # View models
      ├── Views/                     # Razor views
      ├── Extensions/                # Helper extensions
      └── wwwroot/                   # Static files

## Installation

Clone the repository

```
bashgit clone https://github.com/yourusername/PeopleManager.git
cd PeopleManager

Restore packages

bashdotnet restore
```


## Open browser

https://localhost:5001
Default Login
