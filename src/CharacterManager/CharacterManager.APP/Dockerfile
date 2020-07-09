#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["CharacterManager.APP/CharacterManager.APP.csproj", "CharacterManager.APP/"]
COPY ["CharacterManager.Application/CharacterManager.Application.csproj", "CharacterManager.Application/"]
COPY ["CharacterManager.Domain/CharacterManager.Domain.csproj", "CharacterManager.Domain/"]
COPY ["CharacterManager.Infra.Commons/CharacterManager.Infra.Commons.csproj", "CharacterManager.Infra.Commons/"]
RUN dotnet restore "CharacterManager.APP/CharacterManager.APP.csproj"
COPY . .
WORKDIR "/src/CharacterManager.APP"
RUN dotnet build "CharacterManager.APP.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CharacterManager.APP.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CharacterManager.APP.dll"]