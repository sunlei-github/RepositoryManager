#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/RepositoryManager.Web.Host/RepositoryManager.Web.Host.csproj", "src/RepositoryManager.Web.Host/"]
COPY ["src/RepositoryManager.Web.Core/RepositoryManager.Web.Core.csproj", "src/RepositoryManager.Web.Core/"]
COPY ["src/RepositoryManager.EntityFrameworkCore/RepositoryManager.EntityFrameworkCore.csproj", "src/RepositoryManager.EntityFrameworkCore/"]
COPY ["src/RepositoryManager.Core/RepositoryManager.Core.csproj", "src/RepositoryManager.Core/"]
COPY ["src/RepositoryManager.Application/RepositoryManager.Application.csproj", "src/RepositoryManager.Application/"]
RUN dotnet restore "src/RepositoryManager.Web.Host/RepositoryManager.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/RepositoryManager.Web.Host"
RUN dotnet build "RepositoryManager.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RepositoryManager.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RepositoryManager.Web.Host.dll"]
