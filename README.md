# Commander

This is an ASP.NET Core Web API project.

The model is a catalogue of commands. 

Model schema include, a command title, the command and the platform in which the command is to be fired.
Example:
```
"howTo": "How to roll back an Entity framework migration",
"line": "dotnet ef migration remove",
"platform": ".NET Core CLI"
```

This project is made by following the tutorials of *Les Jackson*.

Implemented features in the project:
- MVC (No views)
- REST
- Repository Pattern
- Dependency Injection
- EF Core
- DTOs
- Automapper
- CRUD operations
