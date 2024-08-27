# Base image for .NET
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["identity-server/identity-server.csproj", "identity-server/"]
RUN dotnet restore "identity-server/identity-server.csproj"
COPY . .
WORKDIR "/src/identity-server"
RUN dotnet build "identity-server.csproj" -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish "identity-server.csproj" -c Release -o /app/publish

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "identity-server.dll"]