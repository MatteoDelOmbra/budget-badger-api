# BudgetBadger

## Developer commands

Here are bunch of commands that are used during developing process. Every one of them should be run from solution directory

### Adding migrations

```
dotnet ef migrations add [MigrationName] --project src/Infrastructure/Infrastructure.csproj --startup-project src/Web/Web.csproj
```

### Updating database

```
dotnet ef database update --project src/Infrastructure/Infrastructure.csproj --startup-project src/Web/Web.csproj
```

### Analyze code

```
roslynator analyze --severity-level hidden
```
