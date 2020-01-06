FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["ThreeAmigosReveseProxy/ThreeAmigosReveseProxy.csproj", "ThreeAmigosReveseProxy/"]
RUN dotnet restore "ThreeAmigosReveseProxy/ThreeAmigosReveseProxy.csproj"
COPY . .
WORKDIR "/src/ThreeAmigosReveseProxy"
RUN dotnet build "ThreeAmigosReveseProxy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ThreeAmigosReveseProxy.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ThreeAmigosReveseProxy.dll"]
