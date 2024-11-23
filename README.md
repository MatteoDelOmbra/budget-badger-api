dotnet ef migrations add UpdateIds --project src/Infrastructure/Infrastructure.csproj --startup-project src/Web/Web.csproj

dotnet ef database update --project src/Infrastructure/Infrastructure.csproj --startup-project src/Web/Web.csproj
