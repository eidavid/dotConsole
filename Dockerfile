FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /admin

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY [".","."]

RUN dotnet restore "dotConsole.csproj"
RUN dotnet build "dotConsole.csproj" -c Release -o /app/build

FROM build AS publish
WORKDIR /src
RUN dotnet publish "dotConsole.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

RUN ls

ENTRYPOINT ["dotnet", "dotConsole.dll"]