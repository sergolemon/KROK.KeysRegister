dotnet ef database drop --force Init --startup-project WebAPI\WebAPI.csproj --project Persistence\Persistence.csproj
dotnet ef migrations remove Init --startup-project WebAPI\WebAPI.csproj --project Persistence\Persistence.csproj
dotnet ef migrations add Init --startup-project WebAPI\WebAPI.csproj --project Persistence\Persistence.csproj
dotnet ef database update Init --startup-project WebAPI\WebAPI.csproj --project Persistence\Persistence.csproj