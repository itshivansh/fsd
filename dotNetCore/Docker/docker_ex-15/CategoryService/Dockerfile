# Build
FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore 

COPY . ./
RUN dotnet publish -c Release -o /app

# Run
FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS final
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet","CategoryService.dll"]